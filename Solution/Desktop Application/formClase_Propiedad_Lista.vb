Public Class formClase_Propiedad_Lista

#Region "Declarations"
    Private mClase_PropiedadActual As Clase_Propiedad
    Private mClase_Propiedad_ListaActual As Clase_Propiedad_Lista

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef Clase_PropiedadActual As Clase_Propiedad, ByRef Clase_Propiedad_ListaActual As Clase_Propiedad_Lista)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mClase_PropiedadActual = Clase_PropiedadActual
        mClase_Propiedad_ListaActual = Clase_Propiedad_ListaActual

        If mClase_Propiedad_ListaActual.IDLista = 0 Then
            mClase_Propiedad_ListaActual.EsActivo = True
        End If

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
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Nada por ahora
    End Sub

    Private Sub FormEnd(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mClase_PropiedadActual = Nothing
        mClase_Propiedad_ListaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mClase_Propiedad_ListaActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mClase_Propiedad_ListaActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
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

        ' Si es un nuevo item, busco el próximo ID y agrego el objeto nuevo a la colección del parent
        If mClase_Propiedad_ListaActual.IDLista = 0 Then
            If mClase_PropiedadActual.Clase_Propiedad_Lista.Count = 0 Then
                mClase_Propiedad_ListaActual.IDLista = 1
            Else
                mClase_Propiedad_ListaActual.IDLista = mClase_PropiedadActual.Clase_Propiedad_Lista.Max(Function(c) c.IDLista) + CByte(1)
            End If
            mClase_PropiedadActual.Clase_Propiedad_Lista.Add(mClase_Propiedad_ListaActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CS_Form.IsLoaded("formClase_Propiedad") Then
            Dim formClase_Propiedad As formClase_Propiedad = CType(CS_Form.GetInstance("formClase_Propiedad"), formClase_Propiedad)
            formClase_Propiedad.RefreshData_ListaValores(mClase_Propiedad_ListaActual.IDLista)
            formClase_Propiedad = Nothing
        End If

        Me.Close()
    End Sub
#End Region

End Class