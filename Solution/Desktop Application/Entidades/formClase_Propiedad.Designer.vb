<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClase_Propiedad
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.comboboxTipoDato = New System.Windows.Forms.ComboBox()
        Me.labelTipoDato = New System.Windows.Forms.Label()
        Me.groupboxListaValores = New System.Windows.Forms.GroupBox()
        Me.datagridviewListaValores = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripListaValores = New System.Windows.Forms.ToolStrip()
        Me.buttonListaValores_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonListaValores_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonListaValores_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.comboboxClase = New System.Windows.Forms.ComboBox()
        labelNombre = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxListaValores.SuspendLayout()
        CType(Me.datagridviewListaValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripListaValores.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(12, 55)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(47, 13)
        labelNombre.TabIndex = 0
        labelNombre.Text = "Nombre:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(477, 39)
        Me.toolstripMain.TabIndex = 6
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
        Me.textboxNombre.Location = New System.Drawing.Point(90, 52)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(371, 20)
        Me.textboxNombre.TabIndex = 1
        '
        'comboboxTipoDato
        '
        Me.comboboxTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTipoDato.FormattingEnabled = True
        Me.comboboxTipoDato.Location = New System.Drawing.Point(90, 89)
        Me.comboboxTipoDato.Name = "comboboxTipoDato"
        Me.comboboxTipoDato.Size = New System.Drawing.Size(163, 21)
        Me.comboboxTipoDato.TabIndex = 3
        '
        'labelTipoDato
        '
        Me.labelTipoDato.AutoSize = True
        Me.labelTipoDato.Location = New System.Drawing.Point(12, 92)
        Me.labelTipoDato.Name = "labelTipoDato"
        Me.labelTipoDato.Size = New System.Drawing.Size(72, 13)
        Me.labelTipoDato.TabIndex = 2
        Me.labelTipoDato.Text = "Tipo de Dato:"
        '
        'groupboxListaValores
        '
        Me.groupboxListaValores.Controls.Add(Me.datagridviewListaValores)
        Me.groupboxListaValores.Controls.Add(Me.toolstripListaValores)
        Me.groupboxListaValores.Location = New System.Drawing.Point(12, 129)
        Me.groupboxListaValores.Name = "groupboxListaValores"
        Me.groupboxListaValores.Size = New System.Drawing.Size(453, 235)
        Me.groupboxListaValores.TabIndex = 5
        Me.groupboxListaValores.TabStop = False
        Me.groupboxListaValores.Text = "Valores:"
        Me.groupboxListaValores.Visible = False
        '
        'datagridviewListaValores
        '
        Me.datagridviewListaValores.AllowUserToAddRows = False
        Me.datagridviewListaValores.AllowUserToDeleteRows = False
        Me.datagridviewListaValores.AllowUserToOrderColumns = True
        Me.datagridviewListaValores.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewListaValores.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewListaValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewListaValores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnEsActivo})
        Me.datagridviewListaValores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewListaValores.Location = New System.Drawing.Point(90, 16)
        Me.datagridviewListaValores.MultiSelect = False
        Me.datagridviewListaValores.Name = "datagridviewListaValores"
        Me.datagridviewListaValores.ReadOnly = True
        Me.datagridviewListaValores.RowHeadersVisible = False
        Me.datagridviewListaValores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewListaValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewListaValores.Size = New System.Drawing.Size(360, 216)
        Me.datagridviewListaValores.TabIndex = 1
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 69
        '
        'columnEsActivo
        '
        Me.columnEsActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsActivo.DataPropertyName = "EsActivo"
        Me.columnEsActivo.HeaderText = "Activo"
        Me.columnEsActivo.Name = "columnEsActivo"
        Me.columnEsActivo.ReadOnly = True
        Me.columnEsActivo.Width = 43
        '
        'toolstripListaValores
        '
        Me.toolstripListaValores.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripListaValores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripListaValores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonListaValores_Agregar, Me.buttonListaValores_Editar, Me.buttonListaValores_Eliminar})
        Me.toolstripListaValores.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripListaValores.Location = New System.Drawing.Point(3, 16)
        Me.toolstripListaValores.Name = "toolstripListaValores"
        Me.toolstripListaValores.Size = New System.Drawing.Size(87, 216)
        Me.toolstripListaValores.TabIndex = 0
        '
        'buttonListaValores_Agregar
        '
        Me.buttonListaValores_Agregar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonListaValores_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonListaValores_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonListaValores_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonListaValores_Agregar.Name = "buttonListaValores_Agregar"
        Me.buttonListaValores_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonListaValores_Agregar.Text = "Agregar"
        '
        'buttonListaValores_Editar
        '
        Me.buttonListaValores_Editar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonListaValores_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonListaValores_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonListaValores_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonListaValores_Editar.Name = "buttonListaValores_Editar"
        Me.buttonListaValores_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonListaValores_Editar.Text = "Editar"
        '
        'buttonListaValores_Eliminar
        '
        Me.buttonListaValores_Eliminar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonListaValores_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonListaValores_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonListaValores_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonListaValores_Eliminar.Name = "buttonListaValores_Eliminar"
        Me.buttonListaValores_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonListaValores_Eliminar.Text = "Eliminar"
        '
        'comboboxClase
        '
        Me.comboboxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxClase.FormattingEnabled = True
        Me.comboboxClase.Location = New System.Drawing.Point(259, 89)
        Me.comboboxClase.Name = "comboboxClase"
        Me.comboboxClase.Size = New System.Drawing.Size(202, 21)
        Me.comboboxClase.TabIndex = 4
        '
        'formClase_Propiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 375)
        Me.Controls.Add(Me.comboboxClase)
        Me.Controls.Add(Me.groupboxListaValores)
        Me.Controls.Add(Me.comboboxTipoDato)
        Me.Controls.Add(Me.labelTipoDato)
        Me.Controls.Add(labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formClase_Propiedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle de la Propiedad de la Clase"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxListaValores.ResumeLayout(False)
        Me.groupboxListaValores.PerformLayout()
        CType(Me.datagridviewListaValores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripListaValores.ResumeLayout(False)
        Me.toolstripListaValores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents comboboxTipoDato As System.Windows.Forms.ComboBox
    Friend WithEvents labelTipoDato As System.Windows.Forms.Label
    Friend WithEvents groupboxListaValores As System.Windows.Forms.GroupBox
    Friend WithEvents datagridviewListaValores As System.Windows.Forms.DataGridView
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEsActivo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents toolstripListaValores As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonListaValores_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonListaValores_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonListaValores_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents comboboxClase As System.Windows.Forms.ComboBox
End Class
