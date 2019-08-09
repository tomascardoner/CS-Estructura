<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formClase
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelNombre As System.Windows.Forms.Label
        Dim labelIDClase As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.textboxIDClase = New System.Windows.Forms.TextBox()
        Me.groupboxPropiedades = New System.Windows.Forms.GroupBox()
        Me.datagridviewPropiedades = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTipoDato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripPropiedades = New System.Windows.Forms.ToolStrip()
        Me.buttonPropiedades_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPropiedades_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPropiedades_Eliminar = New System.Windows.Forms.ToolStripButton()
        labelEsActivo = New System.Windows.Forms.Label()
        labelNombre = New System.Windows.Forms.Label()
        labelIDClase = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxPropiedades.SuspendLayout()
        CType(Me.datagridviewPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPropiedades.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(212, 61)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 4
        labelEsActivo.Text = "Activo:"
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(12, 89)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(47, 13)
        labelNombre.TabIndex = 2
        labelNombre.Text = "Nombre:"
        '
        'labelIDClase
        '
        labelIDClase.AutoSize = True
        labelIDClase.Location = New System.Drawing.Point(12, 61)
        labelIDClase.Name = "labelIDClase"
        labelIDClase.Size = New System.Drawing.Size(66, 13)
        labelIDClase.TabIndex = 0
        labelIDClase.Text = "N° de Clase:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(478, 39)
        Me.toolstripMain.TabIndex = 7
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
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(258, 61)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 5
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(94, 86)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(371, 20)
        Me.textboxNombre.TabIndex = 3
        '
        'textboxIDClase
        '
        Me.textboxIDClase.Location = New System.Drawing.Point(94, 58)
        Me.textboxIDClase.MaxLength = 10
        Me.textboxIDClase.Name = "textboxIDClase"
        Me.textboxIDClase.ReadOnly = True
        Me.textboxIDClase.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDClase.TabIndex = 1
        Me.textboxIDClase.TabStop = False
        Me.textboxIDClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'groupboxPropiedades
        '
        Me.groupboxPropiedades.Controls.Add(Me.datagridviewPropiedades)
        Me.groupboxPropiedades.Controls.Add(Me.toolstripPropiedades)
        Me.groupboxPropiedades.Location = New System.Drawing.Point(12, 112)
        Me.groupboxPropiedades.Name = "groupboxPropiedades"
        Me.groupboxPropiedades.Size = New System.Drawing.Size(453, 380)
        Me.groupboxPropiedades.TabIndex = 6
        Me.groupboxPropiedades.TabStop = False
        Me.groupboxPropiedades.Text = "Propiedades:"
        '
        'datagridviewPropiedades
        '
        Me.datagridviewPropiedades.AllowUserToAddRows = False
        Me.datagridviewPropiedades.AllowUserToDeleteRows = False
        Me.datagridviewPropiedades.AllowUserToOrderColumns = True
        Me.datagridviewPropiedades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPropiedades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPropiedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnTipoDato})
        Me.datagridviewPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPropiedades.Location = New System.Drawing.Point(90, 16)
        Me.datagridviewPropiedades.MultiSelect = False
        Me.datagridviewPropiedades.Name = "datagridviewPropiedades"
        Me.datagridviewPropiedades.ReadOnly = True
        Me.datagridviewPropiedades.RowHeadersVisible = False
        Me.datagridviewPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPropiedades.Size = New System.Drawing.Size(360, 361)
        Me.datagridviewPropiedades.TabIndex = 1
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
        'columnTipoDato
        '
        Me.columnTipoDato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnTipoDato.DataPropertyName = "TipoDatoNombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnTipoDato.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnTipoDato.HeaderText = "Tipo de Dato"
        Me.columnTipoDato.Name = "columnTipoDato"
        Me.columnTipoDato.ReadOnly = True
        Me.columnTipoDato.Width = 94
        '
        'toolstripPropiedades
        '
        Me.toolstripPropiedades.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripPropiedades.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPropiedades.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonPropiedades_Agregar, Me.buttonPropiedades_Editar, Me.buttonPropiedades_Eliminar})
        Me.toolstripPropiedades.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripPropiedades.Location = New System.Drawing.Point(3, 16)
        Me.toolstripPropiedades.Name = "toolstripPropiedades"
        Me.toolstripPropiedades.Size = New System.Drawing.Size(87, 361)
        Me.toolstripPropiedades.TabIndex = 0
        '
        'buttonPropiedades_Agregar
        '
        Me.buttonPropiedades_Agregar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonPropiedades_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPropiedades_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPropiedades_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPropiedades_Agregar.Name = "buttonPropiedades_Agregar"
        Me.buttonPropiedades_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPropiedades_Agregar.Text = "Agregar"
        '
        'buttonPropiedades_Editar
        '
        Me.buttonPropiedades_Editar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonPropiedades_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPropiedades_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPropiedades_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPropiedades_Editar.Name = "buttonPropiedades_Editar"
        Me.buttonPropiedades_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPropiedades_Editar.Text = "Editar"
        '
        'buttonPropiedades_Eliminar
        '
        Me.buttonPropiedades_Eliminar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonPropiedades_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPropiedades_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPropiedades_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPropiedades_Eliminar.Name = "buttonPropiedades_Eliminar"
        Me.buttonPropiedades_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonPropiedades_Eliminar.Text = "Eliminar"
        '
        'formClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 504)
        Me.Controls.Add(Me.groupboxPropiedades)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(labelIDClase)
        Me.Controls.Add(Me.textboxIDClase)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formClase"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Clase"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxPropiedades.ResumeLayout(False)
        Me.groupboxPropiedades.PerformLayout()
        CType(Me.datagridviewPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPropiedades.ResumeLayout(False)
        Me.toolstripPropiedades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents textboxIDClase As System.Windows.Forms.TextBox
    Friend WithEvents groupboxPropiedades As System.Windows.Forms.GroupBox
    Friend WithEvents datagridviewPropiedades As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripPropiedades As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonPropiedades_Agregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonPropiedades_Editar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonPropiedades_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTipoDato As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
