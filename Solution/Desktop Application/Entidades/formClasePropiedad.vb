Public Class formClasePropiedad

#Region "Declarations"

    Private mClaseActual As Clase
    Private mClasePropiedadActual As ClasePropiedad

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef ClaseActual As Clase, ByRef ClasePropiedadActual As ClasePropiedad)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mClaseActual = ClaseActual
        mClasePropiedadActual = ClasePropiedadActual

        'Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        ChangeMode()
        Me.ShowDialog(ParentForm)
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.WindowState = FormWindowState.Normal
        'End If
        'Me.Focus()
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode And Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        textboxNombre.ReadOnly = Not mEditMode
        comboboxTipoDato.Enabled = (mClasePropiedadActual.IdPropiedad = 0 And mEditMode)
        comboboxClase.Enabled = (mClasePropiedadActual.IdPropiedad = 0 And mEditMode)

        toolstripListaValores.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Cargo los ComboBox
        pFillAndRefreshLists.Propiedad_TipoDato(comboboxTipoDato)
        pFillAndRefreshLists.Clase(comboboxClase, False, False)
    End Sub

    Private Sub FormEnd(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mClaseActual = Nothing
        mClasePropiedadActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mClasePropiedadActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxTipoDato, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .TipoDato, "")
            If .TipoDato = Constantes.TipoDatoLista Or .TipoDato = Constantes.TipoDatoPlantillaEnlace Then
                RefreshData_ListaValores()
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mClasePropiedadActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .TipoDato = CS_ValueTranslation.FromControlComboBoxToObjectString(comboboxTipoDato.SelectedValue)
            If .TipoDato = Constantes.TipoDatoClase Or .TipoDato = Constantes.TipoDatoPlantillaEnlace Then
                .TipoDatoIdClase = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxClase)
            End If
        End With
    End Sub

    Friend Sub RefreshData_ListaValores(Optional ByVal PosicionIDLista As Short = 0, Optional ByVal RestaurarPosicionActual As Boolean = False)
        Dim Total As Decimal = 0

        If RestaurarPosicionActual Then
            If datagridviewListaValores.CurrentRow Is Nothing Then
                PosicionIDLista = 0
            Else
                PosicionIDLista = CType(datagridviewListaValores.CurrentRow.DataBoundItem, ClasePropiedadLista).IdLista
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            datagridviewListaValores.AutoGenerateColumns = False
            datagridviewListaValores.DataSource = mClasePropiedadActual.ClasePropiedadesLista.ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Valores de la Lista.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PosicionIDLista <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewListaValores.Rows
                If CType(CurrentRowChecked.DataBoundItem, ClasePropiedadLista).IdLista = PosicionIDLista Then
                    datagridviewListaValores.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub TipoDato_Selected() Handles comboboxTipoDato.SelectedValueChanged
        If comboboxTipoDato.SelectedIndex > -1 Then
            comboboxClase.Visible = (comboboxTipoDato.SelectedValue.ToString() = Constantes.TipoDatoClase)
            groupboxListaValores.Visible = (comboboxTipoDato.SelectedValue.ToString() = Constantes.TipoDatoLista)
        Else
            comboboxClase.Visible = False
            groupboxListaValores.Visible = False
        End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        If comboboxTipoDato.SelectedIndex = -1 Then
            MsgBox("Debe especificar el Tipo de Dato.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTipoDato.Focus()
            Exit Sub
        End If
        If comboboxTipoDato.SelectedValue.ToString() = Constantes.TipoDatoClase Then
            If comboboxClase.SelectedIndex = -1 Then
                MsgBox("Debe especificar la Clase.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxClase.Focus()
                Exit Sub
            End If
        End If
        'If comboboxTipoDato.SelectedValue = Constantes.TIPODATO_LISTA Then
        '    If datagridviewListaValores.CurrentRow Is Nothing Then
        '        MsgBox("Debe especificar los Valores para la Lista.", MsgBoxStyle.Information, My.Application.Info.Title)
        '        datagridviewListaValores.Focus()
        '        Exit Sub
        '    End If
        'End If

        ' Si es un nuevo item, busco el próximo ID y agrego el objeto nuevo a la colección del parent
        If mClasePropiedadActual.IDPropiedad = 0 Then
            If mClaseActual.ClasePropiedades.Count = 0 Then
                mClasePropiedadActual.IdPropiedad = 1
            Else
                mClasePropiedadActual.IdPropiedad = mClaseActual.ClasePropiedades.Max(Function(c) c.IdPropiedad) + CByte(1)
            End If
            mClaseActual.ClasePropiedades.Add(mClasePropiedadActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formClase") Then
            Dim formClase As formClase = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formClase"), formClase)
            formClase.RefreshData_Propiedades(mClasePropiedadActual.IdPropiedad)
            formClase = Nothing
        End If

        Me.Close()
    End Sub

#End Region

#Region "ListaValores Toolbar"

    Private Sub ListaValoresAgregar() Handles buttonListaValores_Agregar.Click

        Me.Cursor = Cursors.WaitCursor

        datagridviewListaValores.Enabled = False

        Dim CPLNueva As New ClasePropiedadLista
        formClasePropiedadLista.LoadAndShow(True, True, Me, mClasePropiedadActual, CPLNueva)

        datagridviewListaValores.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListaValoresEditar() Handles buttonListaValores_Editar.Click
        If datagridviewListaValores.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewListaValores.Enabled = False

            Dim CLPActual As ClasePropiedadLista
            CLPActual = CType(datagridviewListaValores.SelectedRows(0).DataBoundItem, ClasePropiedadLista)
            formClasePropiedadLista.LoadAndShow(True, True, Me, mClasePropiedadActual, CLPActual)

            datagridviewListaValores.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ListaValoresEliminar() Handles buttonListaValores_Eliminar.Click
        If datagridviewListaValores.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim CPLEliminar As ClasePropiedadLista
            CPLEliminar = CType(datagridviewListaValores.SelectedRows(0).DataBoundItem, ClasePropiedadLista)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará el Valor de la Lista seleccionado.{0}{0}Nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CPLEliminar.Nombre)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mClasePropiedadActual.ClasePropiedadesLista.Remove(CPLEliminar)

                RefreshData_ListaValores()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

End Class