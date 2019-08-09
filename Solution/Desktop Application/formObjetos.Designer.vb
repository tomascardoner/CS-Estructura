<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formObjetos
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
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formObjetos))
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemAgregarPlantilla = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAgregarNodoRaiz = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAgregarEnUbicacionActual = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.splitcontainerMain = New System.Windows.Forms.SplitContainer()
        Me.treeviewObjetos = New System.Windows.Forms.TreeView()
        Me.splitcontainerDatos = New System.Windows.Forms.SplitContainer()
        Me.labelClase = New System.Windows.Forms.Label()
        Me.comboboxClase = New System.Windows.Forms.ComboBox()
        Me.textboxUbicacion = New System.Windows.Forms.TextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.tabcontrolDatos = New CSEstructura.CS_Control_TabControl()
        Me.tabpagePropiedades = New System.Windows.Forms.TabPage()
        Me.datagridviewPropiedades = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabpageAcciones = New System.Windows.Forms.TabPage()
        Me.toolstripEdit = New System.Windows.Forms.ToolStrip()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        labelEsActivo = New System.Windows.Forms.Label()
        labelNombre = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.splitcontainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMain.Panel1.SuspendLayout()
        Me.splitcontainerMain.Panel2.SuspendLayout()
        Me.splitcontainerMain.SuspendLayout()
        CType(Me.splitcontainerDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerDatos.Panel1.SuspendLayout()
        Me.splitcontainerDatos.Panel2.SuspendLayout()
        Me.splitcontainerDatos.SuspendLayout()
        Me.tabcontrolDatos.SuspendLayout()
        Me.tabpagePropiedades.SuspendLayout()
        CType(Me.datagridviewPropiedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(7, 157)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 8
        labelEsActivo.Text = "Activo:"
        '
        'labelNombre
        '
        labelNombre.AutoSize = True
        labelNombre.Location = New System.Drawing.Point(7, 40)
        labelNombre.Name = "labelNombre"
        labelNombre.Size = New System.Drawing.Size(47, 13)
        labelNombre.TabIndex = 2
        labelNombre.Text = "Nombre:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(7, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 0
        Label1.Text = "Ubicación:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.ToolStripSeparator1, Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar, Me.ToolStripSeparator4, Me.labelActivo, Me.comboboxActivo})
        Me.toolstripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(721, 39)
        Me.toolstripMain.TabIndex = 2
        '
        'buttonAgregar
        '
        Me.buttonAgregar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAgregarPlantilla, Me.menuitemAgregarNodoRaiz, Me.menuitemAgregarEnUbicacionActual})
        Me.buttonAgregar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(97, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'menuitemAgregarPlantilla
        '
        Me.menuitemAgregarPlantilla.Name = "menuitemAgregarPlantilla"
        Me.menuitemAgregarPlantilla.Size = New System.Drawing.Size(177, 22)
        Me.menuitemAgregarPlantilla.Text = "Plantilla"
        '
        'menuitemAgregarNodoRaiz
        '
        Me.menuitemAgregarNodoRaiz.Name = "menuitemAgregarNodoRaiz"
        Me.menuitemAgregarNodoRaiz.Size = New System.Drawing.Size(177, 22)
        Me.menuitemAgregarNodoRaiz.Text = "Nodo raíz"
        '
        'menuitemAgregarEnUbicacionActual
        '
        Me.menuitemAgregarEnUbicacionActual.Name = "menuitemAgregarEnUbicacionActual"
        Me.menuitemAgregarEnUbicacionActual.Size = New System.Drawing.Size(177, 22)
        Me.menuitemAgregarEnUbicacionActual.Text = "En ubicación actual"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(44, 36)
        Me.labelActivo.Text = "Activo:"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 489)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(721, 22)
        Me.statusstripMain.TabIndex = 0
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(706, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'splitcontainerMain
        '
        Me.splitcontainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerMain.Location = New System.Drawing.Point(0, 39)
        Me.splitcontainerMain.Name = "splitcontainerMain"
        '
        'splitcontainerMain.Panel1
        '
        Me.splitcontainerMain.Panel1.Controls.Add(Me.treeviewObjetos)
        '
        'splitcontainerMain.Panel2
        '
        Me.splitcontainerMain.Panel2.Controls.Add(Me.splitcontainerDatos)
        Me.splitcontainerMain.Size = New System.Drawing.Size(721, 450)
        Me.splitcontainerMain.SplitterDistance = 239
        Me.splitcontainerMain.TabIndex = 0
        '
        'treeviewObjetos
        '
        Me.treeviewObjetos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeviewObjetos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeviewObjetos.HideSelection = False
        Me.treeviewObjetos.Location = New System.Drawing.Point(0, 0)
        Me.treeviewObjetos.Name = "treeviewObjetos"
        Me.treeviewObjetos.Size = New System.Drawing.Size(239, 450)
        Me.treeviewObjetos.TabIndex = 0
        '
        'splitcontainerDatos
        '
        Me.splitcontainerDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerDatos.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerDatos.Name = "splitcontainerDatos"
        Me.splitcontainerDatos.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitcontainerDatos.Panel1
        '
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.labelClase)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.comboboxClase)
        Me.splitcontainerDatos.Panel1.Controls.Add(Label1)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.textboxUbicacion)
        Me.splitcontainerDatos.Panel1.Controls.Add(labelNombre)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.textboxNombre)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.checkboxEsActivo)
        Me.splitcontainerDatos.Panel1.Controls.Add(labelEsActivo)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.textboxNotas)
        Me.splitcontainerDatos.Panel1.Controls.Add(Me.labelNotas)
        '
        'splitcontainerDatos.Panel2
        '
        Me.splitcontainerDatos.Panel2.Controls.Add(Me.tabcontrolDatos)
        Me.splitcontainerDatos.Size = New System.Drawing.Size(478, 450)
        Me.splitcontainerDatos.SplitterDistance = 182
        Me.splitcontainerDatos.TabIndex = 0
        '
        'labelClase
        '
        Me.labelClase.AutoSize = True
        Me.labelClase.Location = New System.Drawing.Point(7, 66)
        Me.labelClase.Name = "labelClase"
        Me.labelClase.Size = New System.Drawing.Size(36, 13)
        Me.labelClase.TabIndex = 4
        Me.labelClase.Text = "Clase:"
        '
        'comboboxClase
        '
        Me.comboboxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxClase.FormattingEnabled = True
        Me.comboboxClase.Location = New System.Drawing.Point(71, 63)
        Me.comboboxClase.Name = "comboboxClase"
        Me.comboboxClase.Size = New System.Drawing.Size(317, 21)
        Me.comboboxClase.TabIndex = 5
        '
        'textboxUbicacion
        '
        Me.textboxUbicacion.Location = New System.Drawing.Point(71, 11)
        Me.textboxUbicacion.MaxLength = 100
        Me.textboxUbicacion.Name = "textboxUbicacion"
        Me.textboxUbicacion.ReadOnly = True
        Me.textboxUbicacion.Size = New System.Drawing.Size(317, 20)
        Me.textboxUbicacion.TabIndex = 1
        Me.textboxUbicacion.TabStop = False
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(71, 37)
        Me.textboxNombre.MaxLength = 100
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(317, 20)
        Me.textboxNombre.TabIndex = 3
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(71, 157)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 9
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(71, 90)
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(395, 61)
        Me.textboxNotas.TabIndex = 7
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(7, 93)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 6
        Me.labelNotas.Text = "Notas:"
        '
        'tabcontrolDatos
        '
        Me.tabcontrolDatos.Controls.Add(Me.tabpagePropiedades)
        Me.tabcontrolDatos.Controls.Add(Me.tabpageAcciones)
        Me.tabcontrolDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolDatos.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrolDatos.Name = "tabcontrolDatos"
        Me.tabcontrolDatos.SelectedIndex = 0
        Me.tabcontrolDatos.Size = New System.Drawing.Size(478, 264)
        Me.tabcontrolDatos.TabIndex = 0
        '
        'tabpagePropiedades
        '
        Me.tabpagePropiedades.Controls.Add(Me.datagridviewPropiedades)
        Me.tabpagePropiedades.Location = New System.Drawing.Point(4, 22)
        Me.tabpagePropiedades.Name = "tabpagePropiedades"
        Me.tabpagePropiedades.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePropiedades.Size = New System.Drawing.Size(470, 238)
        Me.tabpagePropiedades.TabIndex = 0
        Me.tabpagePropiedades.Text = "Propiedades"
        Me.tabpagePropiedades.UseVisualStyleBackColor = True
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
        Me.datagridviewPropiedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnValor})
        Me.datagridviewPropiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPropiedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewPropiedades.Location = New System.Drawing.Point(3, 3)
        Me.datagridviewPropiedades.MultiSelect = False
        Me.datagridviewPropiedades.Name = "datagridviewPropiedades"
        Me.datagridviewPropiedades.RowHeadersVisible = False
        Me.datagridviewPropiedades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPropiedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPropiedades.Size = New System.Drawing.Size(464, 232)
        Me.datagridviewPropiedades.TabIndex = 0
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.Width = 69
        '
        'columnValor
        '
        Me.columnValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnValor.DataPropertyName = "Valor"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnValor.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnValor.HeaderText = "Valor"
        Me.columnValor.Name = "columnValor"
        Me.columnValor.Width = 56
        '
        'tabpageAcciones
        '
        Me.tabpageAcciones.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAcciones.Name = "tabpageAcciones"
        Me.tabpageAcciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAcciones.Size = New System.Drawing.Size(470, 238)
        Me.tabpageAcciones.TabIndex = 1
        Me.tabpageAcciones.Text = "Acciones"
        Me.tabpageAcciones.UseVisualStyleBackColor = True
        '
        'toolstripEdit
        '
        Me.toolstripEdit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripEdit.Location = New System.Drawing.Point(0, 39)
        Me.toolstripEdit.Name = "toolstripEdit"
        Me.toolstripEdit.Size = New System.Drawing.Size(606, 39)
        Me.toolstripEdit.TabIndex = 8
        Me.toolstripEdit.Visible = False
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
        'formObjetos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 511)
        Me.Controls.Add(Me.splitcontainerMain)
        Me.Controls.Add(Me.toolstripEdit)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formObjetos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Objetos"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.splitcontainerMain.Panel1.ResumeLayout(False)
        Me.splitcontainerMain.Panel2.ResumeLayout(False)
        CType(Me.splitcontainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerMain.ResumeLayout(False)
        Me.splitcontainerDatos.Panel1.ResumeLayout(False)
        Me.splitcontainerDatos.Panel1.PerformLayout()
        Me.splitcontainerDatos.Panel2.ResumeLayout(False)
        CType(Me.splitcontainerDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerDatos.ResumeLayout(False)
        Me.tabcontrolDatos.ResumeLayout(False)
        Me.tabpagePropiedades.ResumeLayout(False)
        CType(Me.datagridviewPropiedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripEdit.ResumeLayout(False)
        Me.toolstripEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents splitcontainerMain As System.Windows.Forms.SplitContainer
    Friend WithEvents treeviewObjetos As System.Windows.Forms.TreeView
    Friend WithEvents toolstripEdit As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents splitcontainerDatos As System.Windows.Forms.SplitContainer
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents tabcontrolDatos As CS_Control_TabControl
    Friend WithEvents tabpagePropiedades As System.Windows.Forms.TabPage
    Friend WithEvents datagridviewPropiedades As System.Windows.Forms.DataGridView
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabpageAcciones As System.Windows.Forms.TabPage
    Friend WithEvents textboxUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents labelClase As System.Windows.Forms.Label
    Friend WithEvents comboboxClase As System.Windows.Forms.ComboBox
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemAgregarPlantilla As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAgregarNodoRaiz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAgregarEnUbicacionActual As System.Windows.Forms.ToolStripMenuItem
End Class
