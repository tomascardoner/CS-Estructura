Public Class formObjetos

#Region "Declarations"
    Private Const NODO_CARGANDO_TEXTO As String = "Cargando..."

    Private mdbContext As New CSEstructuraContext(True)

    Private mObjetoActual As New Objeto
    Private mEditMode As Boolean = False

    Public Class GridRowData_PropiedadesYValores
        Public Property IDPropiedad As Short
        Public Property Nombre As String
        Public Property TipoDato As String
        Public Property Valor As String
    End Class
#End Region

#Region "Form stuff"
    Private Sub ChangeMode()
        toolstripMain.Visible = (mEditMode = False)
        toolstripEdit.Visible = mEditMode

        treeviewObjetos.Enabled = (mEditMode = False)

        textboxNombre.ReadOnly = (mEditMode = False)
        comboboxClase.Enabled = (mEditMode And mObjetoActual.IDObjeto = 0)
        textboxNotas.ReadOnly = (mEditMode = False)
        checkboxEsActivo.Enabled = mEditMode

        If mEditMode Then
            tabcontrolDatos.HideTabPageByName(tabpageAcciones.Name)
        Else
            tabcontrolDatos.ShowTabPageByName(tabpageAcciones.Name)
        End If
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Clase(comboboxClase, False, True)
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        'datagridviewMain.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        'datagridviewMain.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub formObjetos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFormAndControls()
        ChangeMode()

        LoadNodes(Nothing)
    End Sub

    Private Sub formObjetos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mObjetoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Show Data"
    Friend Sub SetDataFromObjectToControls()
        If mObjetoActual Is Nothing Then
            textboxNombre.Clear()
            comboboxClase.SelectedIndex = 0
            textboxNotas.Clear()
            checkboxEsActivo.CheckState = CheckState.Indeterminate

            datagridviewPropiedades.DataSource = Nothing
        Else
            With mObjetoActual
                If mObjetoActual.IDObjeto = 0 Then
                    textboxUbicacion.Text = treeviewObjetos.SelectedNode.FullPath
                Else
                    textboxUbicacion.Text = CS_String.RemoveLastSubString(treeviewObjetos.SelectedNode.FullPath, "\")
                End If
                textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
                CS_ComboBox.SetSelectedValue(comboboxClase, SelectedItemOptions.ValueOrFirst, mObjetoActual.IDClase)
                textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
                checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)

                RefreshData_Propiedades()
            End With
        End If
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mObjetoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            If comboboxClase.SelectedIndex = 0 Then
                .IDClase = Nothing
            Else
                .IDClase = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxClase.SelectedValue)
            End If
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub

    Friend Sub RefreshData_Objetos()
        treeviewObjetos.Nodes.Clear()
        LoadNodes(Nothing)
    End Sub

    Private Sub LoadNodes(ByRef ParentNode As TreeNode)
        Dim listObjetos As List(Of Objeto)
        Dim Objeto_Padre As Objeto
        Dim NewNode As TreeNode

        Me.Cursor = Cursors.WaitCursor

        If ParentNode Is Nothing Then
            Objeto_Padre = Nothing
        Else
            Objeto_Padre = CType(ParentNode.Tag, Objeto)
        End If

        ' Leo los Objetos
        If Objeto_Padre Is Nothing Then
            listObjetos = (From obj In mdbContext.Objeto
                           Where obj.IDObjeto_Padre Is Nothing
                           Order By obj.Nombre).ToList
        Else
            listObjetos = (From obj In mdbContext.Objeto
                           Where obj.IDObjeto_Padre = Objeto_Padre.IDObjeto
                           Order By obj.Nombre).ToList
        End If

        ' Los muestro en el TreeView
        treeviewObjetos.BeginUpdate()
        For Each ObjetoActual As Objeto In listObjetos
            ' Agrego el nodo correspondiente al Objeto actual y agrego un nodo hijo que diga "cargando..." para cuando se expanda el nodo
            NewNode = New TreeNode(ObjetoActual.Nombre, {New TreeNode(NODO_CARGANDO_TEXTO)})
            NewNode.Tag = ObjetoActual
            If ParentNode Is Nothing Then
                treeviewObjetos.Nodes.Add(NewNode)
            Else
                ParentNode.Nodes.Add(NewNode)
            End If
        Next
        treeviewObjetos.EndUpdate()

        listObjetos = Nothing
        Objeto_Padre = Nothing
        NewNode = Nothing

        Me.Cursor = Cursors.Default
    End Sub

    Friend Sub RefreshData_Propiedades(Optional ByVal PosicionIDPropiedad As Short = 0, Optional ByVal RestaurarPosicionActual As Boolean = False)
        Dim IDClase As Short
        Dim IDObjeto As Short

        IDClase = Convert.ToInt16(IIf(mObjetoActual.IDClase.HasValue, mObjetoActual.IDClase, 0))
        IDObjeto = mObjetoActual.IDObjeto

        If RestaurarPosicionActual Then
            If datagridviewPropiedades.CurrentRow Is Nothing Then
                PosicionIDPropiedad = 0
            Else
                PosicionIDPropiedad = CType(datagridviewPropiedades.CurrentRow.DataBoundItem, GridRowData_PropiedadesYValores).IDPropiedad
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim listGridRowData_PropiedadesYValores As List(Of GridRowData_PropiedadesYValores)
            Dim listObjetosPropiedades As List(Of Objeto_Propiedad)
            Dim IndiceObjetoActual As Short
            Dim Objeto_PropiedadActual As Objeto_Propiedad

            listGridRowData_PropiedadesYValores = (From cla_pro In mdbContext.Clase_Propiedad
                                                    Where cla_pro.IDClase = IDClase
                                                    Order By cla_pro.IDPropiedad
                                                    Select New GridRowData_PropiedadesYValores With {.IDPropiedad = cla_pro.IDPropiedad, .Nombre = cla_pro.Nombre, .TipoDato = cla_pro.TipoDato}).ToList

            listObjetosPropiedades = (From obj_pro In mObjetoActual.Objeto_Propiedades
                                      Where obj_pro.IDObjeto = IDObjeto
                                      Order By obj_pro.IDPropiedad).ToList

            If listObjetosPropiedades.Count > 0 Then
                IndiceObjetoActual = 0

                For Each RowActual As GridRowData_PropiedadesYValores In listGridRowData_PropiedadesYValores
                    Objeto_PropiedadActual = listObjetosPropiedades(IndiceObjetoActual)
                    Select Case Objeto_PropiedadActual.IDPropiedad
                        Case Is < RowActual.IDPropiedad
                            ' Es una propiedad huérfana
                            listGridRowData_PropiedadesYValores.Add(New GridRowData_PropiedadesYValores With {.IDPropiedad = Objeto_PropiedadActual.IDPropiedad, .Nombre = My.Resources.STRING_ITEM_NONE_CHARS20, .Valor = Objeto_PropiedadActual.Valor(IDClase, .TipoDato, mdbContext)})
                            IndiceObjetoActual += Convert.ToInt16(1)
                            If IndiceObjetoActual > listObjetosPropiedades.Count - 1 Then
                                Exit For
                            End If
                        Case RowActual.IDPropiedad
                            ' Es la propiedad correcta
                            RowActual.Valor = Objeto_PropiedadActual.Valor(IDClase, RowActual.TipoDato, mdbContext)
                            IndiceObjetoActual += Convert.ToInt16(1)
                            If IndiceObjetoActual > listObjetosPropiedades.Count - 1 Then
                                Exit For
                            End If
                        Case Is > RowActual.IDPropiedad
                            ' Espero a la próxima iteración
                    End Select
                Next
            End If

            datagridviewPropiedades.AutoGenerateColumns = False
            datagridviewPropiedades.DataSource = listGridRowData_PropiedadesYValores

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer los Valores de la Lista.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PosicionIDPropiedad <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewPropiedades.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData_PropiedadesYValores).IDPropiedad = PosicionIDPropiedad Then
                    datagridviewPropiedades.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If

    End Sub
#End Region

#Region "Controls Behavior"
    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub treeviewObjetos_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles treeviewObjetos.AfterExpand
        If e.Node.Nodes.Count = 1 AndAlso e.Node.Nodes(0).Tag Is Nothing Then
            e.Node.Nodes.RemoveAt(0)
            Application.DoEvents()
            LoadNodes(e.Node)
        End If
    End Sub

    Private Sub treeviewObjetos_AfterSelect() Handles treeviewObjetos.AfterSelect
        mObjetoActual = CType(treeviewObjetos.SelectedNode.Tag, Objeto)

        SetDataFromObjectToControls()
    End Sub

    Private Sub AbrirPropiedad() Handles datagridviewPropiedades.DoubleClick
        Dim Objeto_PropiedadActual As Objeto_Propiedad
        Dim GridRowData_Actual As GridRowData_PropiedadesYValores

        If datagridviewPropiedades.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para Editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewPropiedades.Enabled = False

            GridRowData_Actual = CType(datagridviewPropiedades.SelectedRows(0).DataBoundItem, GridRowData_PropiedadesYValores)
            Objeto_PropiedadActual = mObjetoActual.Objeto_Propiedades.Where(Function(obj_pro) obj_pro.IDPropiedad = GridRowData_Actual.IDPropiedad).FirstOrDefault
            If Objeto_PropiedadActual Is Nothing Then
                Objeto_PropiedadActual = New Objeto_Propiedad
                Objeto_PropiedadActual.IDPropiedad = GridRowData_Actual.IDPropiedad
            End If
            formObjeto_Propiedad.LoadAndShow(mEditMode, mEditMode, Me, mObjetoActual, Objeto_PropiedadActual, GridRowData_Actual.Nombre, GridRowData_Actual.TipoDato)

            datagridviewPropiedades.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub EliminarValorPropiedad(sender As Object, e As KeyPressEventArgs) Handles datagridviewPropiedades.KeyPress
        Dim Objeto_PropiedadActual As Objeto_Propiedad
        Dim GridRowData_Actual As GridRowData_PropiedadesYValores

        If mEditMode AndAlso e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Delete) Then
            If datagridviewPropiedades.CurrentRow Is Nothing Then
                MsgBox("No hay ninguna Propiedad para Eliminar.", vbInformation, My.Application.Info.Title)
            Else
                Me.Cursor = Cursors.WaitCursor

                GridRowData_Actual = CType(datagridviewPropiedades.SelectedRows(0).DataBoundItem, GridRowData_PropiedadesYValores)
                Objeto_PropiedadActual = mObjetoActual.Objeto_Propiedades.Where(Function(obj_pro) obj_pro.IDPropiedad = GridRowData_Actual.IDPropiedad).First
                mObjetoActual.Objeto_Propiedades.Remove(Objeto_PropiedadActual)
                RefreshData_Propiedades(0, True)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub AgregarEnUbicacionActual_Click(sender As Object, e As EventArgs) Handles buttonAgregar.ButtonClick, menuitemAgregarEnUbicacionActual.Click
        mObjetoActual = New Objeto
        mObjetoActual.EsActivo = True
        If Not treeviewObjetos.SelectedNode Is Nothing Then
            mObjetoActual.IDObjeto_Padre = CType(treeviewObjetos.SelectedNode.Tag, Objeto).IDObjeto
        End If
        SetDataFromObjectToControls()

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub AgregarPlantilla_Click(sender As Object, e As EventArgs) Handles menuitemAgregarPlantilla.Click
        mObjetoActual = New Objeto
        mObjetoActual.EsActivo = True
        If Not treeviewObjetos.SelectedNode Is Nothing Then
            mObjetoActual.IDObjeto_Padre = OBJETO_PLANTILLA_ID
        End If
        SetDataFromObjectToControls()

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub AgregarNodoRaiz_Click(sender As Object, e As EventArgs) Handles menuitemAgregarNodoRaiz.Click
        mObjetoActual = New Objeto
        mObjetoActual.EsActivo = True
        mObjetoActual.IDObjeto_Padre = Nothing
        SetDataFromObjectToControls()

        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If treeviewObjetos.SelectedNode Is Nothing Then
            MsgBox("No hay ningún Objeto para editar.", vbInformation, My.Application.Info.Title)
        Else
            Dim ObjetoActual As Objeto = CType(treeviewObjetos.SelectedNode.Tag, Objeto)

            mEditMode = True
            ChangeMode()

            ObjetoActual = Nothing
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If treeviewObjetos.SelectedNode Is Nothing Then
            MsgBox("No hay ningún Objeto para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim ObjetoActual As Objeto = CType(treeviewObjetos.SelectedNode.Tag, Objeto)

            If MsgBox("Se eliminará el Objeto seleccionado." & vbCrLf & vbCrLf & ObjetoActual.Nombre & vbCrLf & vbCrLf & "¿Confirma la eliminación definitiva?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    Using dbContext = New CSEstructuraContext(True)
                        dbContext.Objeto.Attach(ObjetoActual)
                        dbContext.Objeto.Remove(ObjetoActual)
                        dbContext.SaveChanges()
                    End Using

                Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                    Me.Cursor = Cursors.Default
                    Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                        Case Errors.RelatedEntity
                            MsgBox("No se puede eliminar el Objeto porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    End Select
                    Exit Sub

                Catch ex As Exception
                    CS_Error.ProcessError(ex, "Error al eliminar el Objeto.")
                End Try

                RefreshData_Objetos()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
#End Region

#Region "Edit Toolbar"
    Private Sub Guardar() Handles buttonGuardar.Click
        Dim IsNew As Boolean

        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If
        If comboboxClase.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar la Clase.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxClase.Focus()
            Exit Sub
        End If

        IsNew = (mObjetoActual.IDObjeto = 0)
        ' Es un Objeto Nuevo
        If IsNew Then
            ' Calculo el nuevo ID
            Using dbcMaxID As New CSEstructuraContext(True)
                If dbcMaxID.Objeto.Count = 0 Then
                    mObjetoActual.IDObjeto = 1
                Else
                    mObjetoActual.IDObjeto = Convert.ToInt16(dbcMaxID.Objeto.Max(Function(c) c.IDObjeto) + 1)
                End If
            End Using

            ' Agrego el objeto a la Base de Datos
            mObjetoActual = mdbContext.Objeto.Add(mObjetoActual)
        End If

        ' Paso los datos desde los controles al Objeto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Objeto con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Errors.Unknown, Errors.NoDBError
                        CS_Error.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                    Case Else
                        CS_Error.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try

            ' Refresco el Arbol de Objetos para mostrar los cambios
            If IsNew Then
                ' Agregar el Nodo al TreeView para no recargar todo el árbol completo
                Dim NewNode As New TreeNode(mObjetoActual.Nombre)

                NewNode.Tag = mObjetoActual
                If treeviewObjetos.SelectedNode Is Nothing Then
                    treeviewObjetos.Nodes.Add(NewNode)
                Else
                    treeviewObjetos.SelectedNode.Nodes.Add(NewNode)
                End If
            Else
                ' Refresco las propiedados del Objeto actual para no recargar todo el árbol completo
                treeviewObjetos.SelectedNode.Text = mObjetoActual.Nombre
                treeviewObjetos.SelectedNode.Tag = mObjetoActual
                SetDataFromObjectToControls()
            End If
        End If

        mEditMode = False
        ChangeMode()

        treeviewObjetos.Focus()
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        mEditMode = False
        ChangeMode()

        ' Tengo que resetear las propiedades modificadas
        For Each Objeto_PropiedadActual In mdbContext.ChangeTracker.Entries(Of Objeto_Propiedad)()
            Select Case Objeto_PropiedadActual.State
                Case Entity.EntityState.Added
                    Objeto_PropiedadActual.State = Entity.EntityState.Detached
                Case Entity.EntityState.Deleted
                    Objeto_PropiedadActual.Reload()
                Case Entity.EntityState.Modified
                    Objeto_PropiedadActual.State = Entity.EntityState.Unchanged
            End Select
        Next
        If treeviewObjetos.SelectedNode Is Nothing Then
            mObjetoActual = Nothing
        Else
            mObjetoActual = CType(treeviewObjetos.SelectedNode.Tag, Objeto)
        End If
        SetDataFromObjectToControls()
    End Sub
#End Region

End Class