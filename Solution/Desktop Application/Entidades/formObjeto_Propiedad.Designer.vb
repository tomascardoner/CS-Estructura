<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formObjeto_Propiedad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim labelNombre As System.Windows.Forms.Label
        Dim labelValor As System.Windows.Forms.Label
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.textboxTexto = New System.Windows.Forms.TextBox()
        Me.datetimepickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerHora = New System.Windows.Forms.DateTimePicker()
        Me.comboboxLista = New System.Windows.Forms.ComboBox()
        Me.checkboxSiNo = New System.Windows.Forms.CheckBox()
        Me.textboxNumeroEntero = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.textboxNumeroDecimal = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        labelNombre = New System.Windows.Forms.Label()
        labelValor = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.textboxNumeroEntero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textboxNumeroDecimal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(15, 55)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(47, 13)
        labelNombre.TabIndex = 0
        labelNombre.Text = "Nombre:"
        '
        'labelValor
        '
        labelValor.AutoSize = True
        labelValor.Location = New System.Drawing.Point(15, 90)
        labelValor.Name = "labelValor"
        labelValor.Size = New System.Drawing.Size(34, 13)
        labelValor.TabIndex = 2
        labelValor.Text = "Valor:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(484, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(93, 52)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.ReadOnly = True
        Me.textboxNombre.Size = New System.Drawing.Size(371, 20)
        Me.textboxNombre.TabIndex = 1
        Me.textboxNombre.TabStop = False
        '
        'textboxTexto
        '
        Me.textboxTexto.Location = New System.Drawing.Point(93, 87)
        Me.textboxTexto.MaxLength = 4000
        Me.textboxTexto.Multiline = True
        Me.textboxTexto.Name = "textboxTexto"
        Me.textboxTexto.Size = New System.Drawing.Size(371, 113)
        Me.textboxTexto.TabIndex = 3
        '
        'datetimepickerFecha
        '
        Me.datetimepickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFecha.Location = New System.Drawing.Point(93, 87)
        Me.datetimepickerFecha.Name = "datetimepickerFecha"
        Me.datetimepickerFecha.Size = New System.Drawing.Size(126, 20)
        Me.datetimepickerFecha.TabIndex = 6
        '
        'datetimepickerHora
        '
        Me.datetimepickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHora.Location = New System.Drawing.Point(225, 87)
        Me.datetimepickerHora.Name = "datetimepickerHora"
        Me.datetimepickerHora.ShowUpDown = True
        Me.datetimepickerHora.Size = New System.Drawing.Size(92, 20)
        Me.datetimepickerHora.TabIndex = 7
        '
        'comboboxLista
        '
        Me.comboboxLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxLista.FormattingEnabled = True
        Me.comboboxLista.Location = New System.Drawing.Point(93, 87)
        Me.comboboxLista.Name = "comboboxLista"
        Me.comboboxLista.Size = New System.Drawing.Size(371, 21)
        Me.comboboxLista.TabIndex = 9
        '
        'checkboxSiNo
        '
        Me.checkboxSiNo.AutoSize = True
        Me.checkboxSiNo.Location = New System.Drawing.Point(93, 90)
        Me.checkboxSiNo.Name = "checkboxSiNo"
        Me.checkboxSiNo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxSiNo.TabIndex = 8
        Me.checkboxSiNo.UseVisualStyleBackColor = True
        '
        'textboxNumeroEntero
        '
        Me.textboxNumeroEntero.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.textboxNumeroEntero.IntegerValue = CType(0, Long)
        Me.textboxNumeroEntero.Location = New System.Drawing.Point(93, 87)
        Me.textboxNumeroEntero.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.textboxNumeroEntero.MinValue = CType(0, Long)
        Me.textboxNumeroEntero.Name = "textboxNumeroEntero"
        Me.textboxNumeroEntero.NullString = ""
        Me.textboxNumeroEntero.Size = New System.Drawing.Size(100, 20)
        Me.textboxNumeroEntero.TabIndex = 12
        Me.textboxNumeroEntero.Text = "0"
        '
        'textboxNumeroDecimal
        '
        Me.textboxNumeroDecimal.BeforeTouchSize = New System.Drawing.Size(100, 20)
        Me.textboxNumeroDecimal.DoubleValue = 0R
        Me.textboxNumeroDecimal.Location = New System.Drawing.Point(93, 87)
        Me.textboxNumeroDecimal.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.textboxNumeroDecimal.MinValue = 0R
        Me.textboxNumeroDecimal.Name = "textboxNumeroDecimal"
        Me.textboxNumeroDecimal.NullString = ""
        Me.textboxNumeroDecimal.Size = New System.Drawing.Size(100, 20)
        Me.textboxNumeroDecimal.TabIndex = 13
        Me.textboxNumeroDecimal.Text = "0,00"
        '
        'formObjeto_Propiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 220)
        Me.Controls.Add(Me.textboxNumeroDecimal)
        Me.Controls.Add(Me.textboxNumeroEntero)
        Me.Controls.Add(Me.checkboxSiNo)
        Me.Controls.Add(Me.comboboxLista)
        Me.Controls.Add(Me.datetimepickerHora)
        Me.Controls.Add(Me.datetimepickerFecha)
        Me.Controls.Add(Me.textboxTexto)
        Me.Controls.Add(labelValor)
        Me.Controls.Add(labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formObjeto_Propiedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Propiedad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.textboxNumeroEntero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textboxNumeroDecimal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents textboxTexto As System.Windows.Forms.TextBox
    Friend WithEvents datetimepickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents comboboxLista As System.Windows.Forms.ComboBox
    Friend WithEvents checkboxSiNo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxNumeroEntero As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents textboxNumeroDecimal As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
