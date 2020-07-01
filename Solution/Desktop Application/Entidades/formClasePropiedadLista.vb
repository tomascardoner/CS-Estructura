Public Class formClasePropiedadLista

#Region "Declarations"

    Private mClasePropiedadActual As ClasePropiedad
    Private mClasePropiedadListaActual As ClasePropiedadLista

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef clasePropiedadActual As ClasePropiedad, ByRef clasePropiedadListaActual As ClasePropiedadLista)
        mParentEditMode = parentEditMode
        mEditMode = editMode

        mClasePropiedadActual = clasePropiedadActual
        mClasePropiedadListaActual = clasePropiedadListaActual

        If mClasePropiedadListaActual.IdLista = 0 Then
            mClasePropiedadListaActual.EsActivo = True
        End If

        CS_Form.CenterToParent(parentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        ChangeMode()
        Me.ShowDialog(parentForm)
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
        mClasePropiedadActual = Nothing
        mClasePropiedadListaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mClasePropiedadListaActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mClasePropiedadListaActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                e.Handled = True
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
        If mClasePropiedadListaActual.IdLista = 0 Then
            If mClasePropiedadActual.ClasePropiedadesLista.Count = 0 Then
                mClasePropiedadListaActual.IdLista = 1
            Else
                mClasePropiedadListaActual.IdLista = mClasePropiedadActual.ClasePropiedadesLista.Max(Function(c) c.IdLista) + CByte(1)
            End If
            mClasePropiedadActual.ClasePropiedadesLista.Add(mClasePropiedadListaActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CS_Form.IsLoaded("formClasePropiedad") Then
            Dim formCP As formClasePropiedad = CType(CS_Form.GetInstance("formClasePropiedad"), formClasePropiedad)
            formCP.RefreshData_ListaValores(mClasePropiedadListaActual.IdLista)
            formCP = Nothing
        End If

        Me.Close()
    End Sub

#End Region

End Class