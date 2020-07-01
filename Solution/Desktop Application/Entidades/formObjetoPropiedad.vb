Public Class formObjetoPropiedad

#Region "Declarations"

    Private mObjetoActual As Objeto
    Private mObjetoPropiedadActual As ObjetoPropiedad
    Private mPropiedadNombre As String
    Private mPropiedadTipoDato As String

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal parentEditMode As Boolean, ByVal editMode As Boolean, ByRef parentForm As Form, ByRef objetoActual As Objeto, ByRef objetoPropiedadActual As ObjetoPropiedad, ByVal propiedadNombre As String, ByVal propiedadTipoDato As String)
        mParentEditMode = parentEditMode
        mEditMode = editMode

        mObjetoActual = objetoActual
        mObjetoPropiedadActual = objetoPropiedadActual
        mPropiedadNombre = propiedadNombre
        mPropiedadTipoDato = propiedadTipoDato

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

        textboxTexto.ReadOnly = Not mEditMode
        textboxNumeroEntero.ReadOnly = Not mEditMode
        textboxNumeroDecimal.ReadOnly = Not mEditMode
        datetimepickerFecha.Enabled = mEditMode
        datetimepickerHora.Enabled = mEditMode
        comboboxLista.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        textboxTexto.Visible = (mPropiedadTipoDato = Constantes.TipoDatoTexto)
        textboxNumeroEntero.Visible = (mPropiedadTipoDato = Constantes.TipoDatoNumeroEntero)
        textboxNumeroDecimal.Visible = (mPropiedadTipoDato = Constantes.TipoDatoNumeroDecimal)
        datetimepickerFecha.Visible = (mPropiedadTipoDato = Constantes.TipoDatoFechaHora Or mPropiedadTipoDato = Constantes.TipoDatoFecha)
        datetimepickerHora.Visible = (mPropiedadTipoDato = Constantes.TipoDatoFechaHora Or mPropiedadTipoDato = Constantes.TipoDatoHora)
        If mPropiedadTipoDato = Constantes.TipoDatoHora Then
            datetimepickerHora.Left = datetimepickerFecha.Left
        End If
        checkboxSiNo.Visible = (mPropiedadTipoDato = Constantes.TipoDatoSiNo)
        comboboxLista.Visible = (mPropiedadTipoDato = Constantes.TipoDatoLista)

        pFillAndRefreshLists.Clase_Propiedad_Lista(comboboxLista, mObjetoActual.IdClase.Value, mObjetoPropiedadActual.IdPropiedad)

        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        'datagridviewMain.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        'datagridviewMain.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub formObjetos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mObjetoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Show Data"

    Friend Sub SetDataFromObjectToControls()
        textboxNombre.Text = mPropiedadNombre
        With mObjetoPropiedadActual
            Select Case mPropiedadTipoDato
                Case Constantes.TipoDatoTexto
                    textboxTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ValorTexto)
                Case Constantes.TipoDatoNumeroEntero
                    textboxNumeroEntero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.ValorNumeroEntero)
                Case Constantes.TipoDatoNumeroDecimal
                    textboxNumeroDecimal.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.ValorNumeroDecimal)
                Case Constantes.TipoDatoFechaHora
                    datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.ValorFechaHora)
                    datetimepickerHora.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyTime(.ValorFechaHora)
                Case Constantes.TipoDatoFecha
                    datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.ValorFechaHora)
                Case Constantes.TipoDatoHora
                    datetimepickerHora.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyTime(.ValorFechaHora)
                Case Constantes.TipoDatoSiNo
                    checkboxSiNo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.ValorSiNo)
                Case Constantes.TipoDatoLista
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxLista, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .ValorLista, CShort(0))
                Case Constantes.TipoDatoClase
                Case Else
            End Select
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mObjetoPropiedadActual
            Select Case mPropiedadTipoDato
                Case Constantes.TipoDatoTexto
                    .ValorTexto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTexto.Text)
                Case Constantes.TipoDatoNumeroEntero
                    .ValorNumeroEntero = CS_ValueTranslation.FromControlTextBoxToObjectInteger(textboxNumeroEntero.Text)
                Case Constantes.TipoDatoNumeroDecimal
                    .ValorNumeroDecimal = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(textboxNumeroDecimal.Text)
                Case Constantes.TipoDatoFechaHora
                    .ValorFechaHora = Convert.ToDateTime(datetimepickerFecha.Value & " " & datetimepickerHora.Value)
                Case Constantes.TipoDatoFecha
                    .ValorFechaHora = datetimepickerFecha.Value
                Case Constantes.TipoDatoHora
                    .ValorFechaHora = datetimepickerHora.Value
                Case Constantes.TipoDatoSiNo
                    .ValorSiNo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxSiNo.CheckState)
                Case Constantes.TipoDatoLista
                    .ValorLista = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxLista.SelectedValue, 0)
                Case Constantes.TipoDatoClase
                Case Else
            End Select
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxTexto.GotFocus
        If TypeOf (sender) Is TextBox Then
            CType(sender, TextBox).SelectAll()
        ElseIf TypeOf (sender) Is MaskedTextBox Then
            CType(sender, MaskedTextBox).SelectAll()
        End If
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

        With mObjetoPropiedadActual
            Select Case mPropiedadTipoDato
                Case Constantes.TipoDatoTexto
                    If textboxTexto.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Texto.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxTexto.Focus()
                        Exit Sub
                    End If
                Case Constantes.TipoDatoNumeroEntero
                    If textboxNumeroEntero.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxNumeroEntero.Focus()
                        Exit Sub
                    End If
                Case Constantes.TipoDatoNumeroDecimal
                    If textboxNumeroDecimal.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxNumeroDecimal.Focus()
                        Exit Sub
                    End If
                Case Constantes.TipoDatoFechaHora
                Case Constantes.TipoDatoFecha
                Case Constantes.TipoDatoHora
                Case Constantes.TipoDatoSiNo
                Case Constantes.TipoDatoLista
                    If comboboxLista.SelectedIndex = -1 Then
                        MsgBox("Debe seleccionar un ítem de la Lista.", MsgBoxStyle.Information, My.Application.Info.Title)
                        comboboxLista.Focus()
                        Exit Sub
                    End If
                Case Constantes.TipoDatoClase
                Case Else
            End Select
        End With

        If mObjetoPropiedadActual.IdObjeto = 0 Then
            mObjetoPropiedadActual.IdObjeto = mObjetoActual.IdObjeto
            mObjetoActual.ObjetoPropiedades.Add(mObjetoPropiedadActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        formObjetos.RefreshData_Propiedades(0, True)

        Me.Close()
    End Sub

#End Region

End Class