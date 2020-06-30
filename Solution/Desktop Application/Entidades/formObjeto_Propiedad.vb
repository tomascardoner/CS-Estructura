Public Class formObjeto_Propiedad

#Region "Declarations"
    Private mObjetoActual As Objeto
    Private mObjeto_PropiedadActual As Objeto_Propiedad
    Private mPropiedadNombre As String
    Private mPropiedadTipoDato As String

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef ObjetoActual As Objeto, ByRef Objeto_PropiedadActual As Objeto_Propiedad, ByVal PropiedadNombre As String, ByVal PropiedadTipoDato As String)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode

        mObjetoActual = ObjetoActual
        mObjeto_PropiedadActual = Objeto_PropiedadActual
        mPropiedadNombre = PropiedadNombre
        mPropiedadTipoDato = PropiedadTipoDato

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

        textboxTexto.ReadOnly = Not mEditMode
        textboxNumeroEntero.ReadOnly = Not mEditMode
        textboxNumeroDecimal.ReadOnly = Not mEditMode
        datetimepickerFecha.Enabled = mEditMode
        datetimepickerHora.Enabled = mEditMode
        comboboxLista.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        textboxTexto.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_TEXTO)
        textboxNumeroEntero.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_NUMEROENTERO)
        textboxNumeroDecimal.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_NUMERODECIMAL)
        datetimepickerFecha.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_FECHAHORA Or mPropiedadTipoDato = Constantes.TIPODATO_FECHA)
        datetimepickerHora.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_FECHAHORA Or mPropiedadTipoDato = Constantes.TIPODATO_HORA)
        If mPropiedadTipoDato = Constantes.TIPODATO_HORA Then
            datetimepickerHora.Left = datetimepickerFecha.Left
        End If
        checkboxSiNo.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_SINO)
        comboboxLista.Visible = (mPropiedadTipoDato = Constantes.TIPODATO_LISTA)

        pFillAndRefreshLists.Clase_Propiedad_Lista(comboboxLista, mObjetoActual.IDClase.Value, mObjeto_PropiedadActual.IDPropiedad)

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
        With mObjeto_Propiedadactual
            Select Case mPropiedadTipoDato
                Case Constantes.TIPODATO_TEXTO
                    textboxTexto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Valor_Texto)
                Case Constantes.TIPODATO_NUMEROENTERO
                    textboxNumeroEntero.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Valor_NumeroEntero)
                Case Constantes.TIPODATO_NUMERODECIMAL
                    textboxNumeroDecimal.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Valor_NumeroDecimal)
                Case Constantes.TIPODATO_FECHAHORA
                    datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Valor_FechaHora)
                    datetimepickerHora.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyTime(.Valor_FechaHora)
                Case Constantes.TIPODATO_FECHA
                    datetimepickerFecha.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.Valor_FechaHora)
                Case Constantes.TIPODATO_HORA
                    datetimepickerHora.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyTime(.Valor_FechaHora)
                Case Constantes.TIPODATO_SINO
                    checkboxSiNo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Valor_SiNo)
                Case Constantes.TIPODATO_LISTA
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxLista, CardonerSistemas.ComboBox.SelectedItemOptions.Value, .Valor_Lista, CShort(0))
                Case Constantes.TIPODATO_CLASE
                Case Else
            End Select
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mObjeto_Propiedadactual
            Select Case mPropiedadTipoDato
                Case Constantes.TIPODATO_TEXTO
                    .Valor_Texto = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTexto.Text)
                Case Constantes.TIPODATO_NUMEROENTERO
                    .Valor_NumeroEntero = CS_ValueTranslation.FromControlTextBoxToObjectInteger(textboxNumeroEntero.Text)
                Case Constantes.TIPODATO_NUMERODECIMAL
                    .Valor_NumeroDecimal = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(textboxNumeroDecimal.Text)
                Case Constantes.TIPODATO_FECHAHORA
                    .Valor_FechaHora = Convert.ToDateTime(datetimepickerFecha.Value & " " & datetimepickerHora.Value)
                Case Constantes.TIPODATO_FECHA
                    .Valor_FechaHora = datetimepickerFecha.Value
                Case Constantes.TIPODATO_HORA
                    .Valor_FechaHora = datetimepickerHora.Value
                Case Constantes.TIPODATO_SINO
                    .Valor_SiNo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxSiNo.CheckState)
                Case Constantes.TIPODATO_LISTA
                    .Valor_Lista = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxLista.SelectedValue, 0)
                Case Constantes.TIPODATO_CLASE
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

        With mObjeto_Propiedadactual
            Select Case mPropiedadTipoDato
                Case Constantes.TIPODATO_TEXTO
                    If textboxTexto.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Texto.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxTexto.Focus()
                        Exit Sub
                    End If
                Case Constantes.TIPODATO_NUMEROENTERO
                    If textboxNumeroEntero.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxNumeroEntero.Focus()
                        Exit Sub
                    End If
                Case Constantes.TIPODATO_NUMERODECIMAL
                    If textboxNumeroDecimal.Text.Trim.Length = 0 Then
                        MsgBox("Debe ingresar el Número.", MsgBoxStyle.Information, My.Application.Info.Title)
                        textboxNumeroDecimal.Focus()
                        Exit Sub
                    End If
                Case Constantes.TIPODATO_FECHAHORA
                Case Constantes.TIPODATO_FECHA
                Case Constantes.TIPODATO_HORA
                Case Constantes.TIPODATO_SINO
                Case Constantes.TIPODATO_LISTA
                    If comboboxLista.SelectedIndex = -1 Then
                        MsgBox("Debe seleccionar un ítem de la Lista.", MsgBoxStyle.Information, My.Application.Info.Title)
                        comboboxLista.Focus()
                        Exit Sub
                    End If
                Case Constantes.TIPODATO_CLASE
                Case Else
            End Select
        End With

        If mObjeto_PropiedadActual.IDObjeto = 0 Then
            mObjeto_PropiedadActual.IDObjeto = mObjetoActual.IDObjeto
            mObjetoActual.Objeto_Propiedades.Add(mObjeto_PropiedadActual)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        formObjetos.RefreshData_Propiedades(0, True)

        Me.Close()
    End Sub
#End Region

End Class