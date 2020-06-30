Public Class formClase

#Region "Declarations"
    Private mdbContext As New CSEstructuraContext(True)
    Private mClaseActual As Clase

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDClase As Short)
        mIsLoading = True
        mEditMode = EditMode

        If IDClase = 0 Then
            ' Es Nueva
            mClaseActual = New Clase
            With mClaseActual
                .EsActivo = True
            End With
            mdbContext.Clase.Add(mClaseActual)
        Else
            mClaseActual = mdbContext.Clase.Find(IDClase)
        End If

        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        checkboxEsActivo.Enabled = mEditMode
        textboxNombre.ReadOnly = (mEditMode = False)

        toolstripPropiedades.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        'datagridviewCursosAsistidos.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        'datagridviewCursosAsistidos.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub formClase_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mClaseActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mClaseActual
            ' Datos del Encabezado
            If .IDClase = 0 Then
                textboxIDClase.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDClase.Text = String.Format(.IDClase.ToString, "G")
            End If
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            RefreshData_Propiedades()
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mClaseActual
            ' Datos del Encabezado
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
        End With
    End Sub

    Friend Sub RefreshData_Propiedades(Optional ByVal PosicionIDPropiedad As Short = 0, Optional ByVal RestaurarPosicionActual As Boolean = False)
        If RestaurarPosicionActual Then
            If datagridviewPropiedades.CurrentRow Is Nothing Then
                PosicionIDPropiedad = 0
            Else
                PosicionIDPropiedad = CType(datagridviewPropiedades.CurrentRow.DataBoundItem, Clase_Propiedad).IDPropiedad
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            datagridviewPropiedades.AutoGenerateColumns = False
            datagridviewPropiedades.DataSource = mClaseActual.Clase_Propiedad.ToList

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Propiedades de la Clase.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If PosicionIDPropiedad <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewPropiedades.Rows
                If CType(CurrentRowChecked.DataBoundItem, Clase_Propiedad).IDPropiedad = PosicionIDPropiedad Then
                    datagridviewPropiedades.CurrentCell = CurrentRowChecked.Cells(0)
                    Exit For
                End If
            Next
        End If
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Es una Clase Nueva
        If mClaseActual.IDClase = 0 Then
            ' Calculo el nuevo ID
            Using dbcMaxID As New CSEstructuraContext(True)
                If dbcMaxID.Clase.Count = 0 Then
                    mClaseActual.IDClase = 1
                Else
                    mClaseActual.IDClase = Convert.ToInt16(dbcMaxID.Clase.Max(Function(c) c.IDClase) + 1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objeto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Clase con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.Unknown, CardonerSistemas.Database.EntityFramework.Errors.NoDBError
                        CardonerSistemas.ErrorHandler.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                    Case Else
                        CardonerSistemas.ErrorHandler.ProcessError(dbuex.GetBaseException, My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try

            ' Refresco la lista de Clases para mostrar los cambios
            If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formClases") Then
                Dim formClases As formClases = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formClases"), formClases)
                formClases.RefreshData(mClaseActual.IDClase)
                formClases = Nothing
            End If
        End If

        Me.Close()
    End Sub

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Propiedades Toolbar"
    Private Sub Propiedades_Agregar() Handles buttonPropiedades_Agregar.Click

        Me.Cursor = Cursors.WaitCursor

        datagridviewPropiedades.Enabled = False

        Dim Clase_PropiedadNueva As New Clase_Propiedad
        formClase_Propiedad.LoadAndShow(True, True, Me, mClaseActual, Clase_PropiedadNueva)

        datagridviewPropiedades.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Propiedades_Editar() Handles buttonPropiedades_Editar.Click
        If datagridviewPropiedades.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewPropiedades.Enabled = False

            Dim Clase_PropiedadActual As Clase_Propiedad
            Clase_PropiedadActual = CType(datagridviewPropiedades.SelectedRows(0).DataBoundItem, Clase_Propiedad)
            formClase_Propiedad.LoadAndShow(True, True, Me, mClaseActual, Clase_PropiedadActual)

            datagridviewPropiedades.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Propiedades_Eliminar() Handles buttonPropiedades_Eliminar.Click
        If datagridviewPropiedades.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim Clase_PropiedadEliminar As Clase_Propiedad
            Clase_PropiedadEliminar = CType(datagridviewPropiedades.SelectedRows(0).DataBoundItem, Clase_Propiedad)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará la Propiedad seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, Clase_PropiedadEliminar.Nombre)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mClaseActual.Clase_Propiedad.Remove(Clase_PropiedadEliminar)

                RefreshData_Propiedades()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewPropiedades.DoubleClick
        If datagridviewPropiedades.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Propiedad para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewPropiedades.Enabled = False

            Dim Clase_PropiedadActual As Clase_Propiedad
            Clase_PropiedadActual = CType(datagridviewPropiedades.SelectedRows(0).DataBoundItem, Clase_Propiedad)
            formClase_Propiedad.LoadAndShow(mEditMode, False, Me, mClaseActual, Clase_PropiedadActual)

            datagridviewPropiedades.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Extra stuff"

#End Region

End Class