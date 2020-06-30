<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMDIMain))
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.labelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menustripMain = New System.Windows.Forms.MenuStrip()
        Me.menuitemArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_Salir = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaMosaicoHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaMosaicoVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaOrganizarIconos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaSeparadorCerrarTodas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemVentanaCerrarTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaEncajarEnVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaSeparadorListaVentanas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAyuda_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonTablas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemClases = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonObjetos = New System.Windows.Forms.ToolStripButton()
        Me.buttonReportes = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain.SuspendLayout()
        Me.menustripMain.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelStatus})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 513)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(928, 22)
        Me.statusstripMain.TabIndex = 2
        '
        'labelStatus
        '
        Me.labelStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(913, 17)
        Me.labelStatus.Spring = True
        '
        'menustripMain
        '
        Me.menustripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo, Me.menuitemVentana, Me.menuitemAyuda})
        Me.menustripMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripMain.MdiWindowListItem = Me.menuitemVentana
        Me.menustripMain.Name = "menustripMain"
        Me.menustripMain.Size = New System.Drawing.Size(928, 24)
        Me.menustripMain.TabIndex = 0
        '
        'menuitemArchivo
        '
        Me.menuitemArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo_Opciones, Me.menuitemArchivo_Separador_Salir, Me.menuitemArchivo_Salir})
        Me.menuitemArchivo.Name = "menuitemArchivo"
        Me.menuitemArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuitemArchivo.Text = "&Archivo"
        '
        'menuitemArchivo_Opciones
        '
        Me.menuitemArchivo_Opciones.Name = "menuitemArchivo_Opciones"
        Me.menuitemArchivo_Opciones.Size = New System.Drawing.Size(124, 22)
        Me.menuitemArchivo_Opciones.Text = "Opciones"
        '
        'menuitemArchivo_Separador_Salir
        '
        Me.menuitemArchivo_Separador_Salir.Name = "menuitemArchivo_Separador_Salir"
        Me.menuitemArchivo_Separador_Salir.Size = New System.Drawing.Size(121, 6)
        '
        'menuitemArchivo_Salir
        '
        Me.menuitemArchivo_Salir.Name = "menuitemArchivo_Salir"
        Me.menuitemArchivo_Salir.Size = New System.Drawing.Size(124, 22)
        Me.menuitemArchivo_Salir.Text = "&Salir"
        '
        'menuitemVentana
        '
        Me.menuitemVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemVentanaMosaicoHorizontal, Me.menuitemVentanaMosaicoVertical, Me.menuitemVentanaCascada, Me.menuitemVentanaOrganizarIconos, Me.menuitemVentanaSeparadorCerrarTodas, Me.menuitemVentanaCerrarTodas, Me.menuitemVentanaEncajarEnVentana, Me.menuitemVentanaSeparadorListaVentanas})
        Me.menuitemVentana.Name = "menuitemVentana"
        Me.menuitemVentana.Size = New System.Drawing.Size(61, 20)
        Me.menuitemVentana.Text = "&Ventana"
        '
        'menuitemVentanaMosaicoHorizontal
        '
        Me.menuitemVentanaMosaicoHorizontal.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_HORIZONTALLY
        Me.menuitemVentanaMosaicoHorizontal.Name = "menuitemVentanaMosaicoHorizontal"
        Me.menuitemVentanaMosaicoHorizontal.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal"
        '
        'menuitemVentanaMosaicoVertical
        '
        Me.menuitemVentanaMosaicoVertical.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_VERTICALLY
        Me.menuitemVentanaMosaicoVertical.Name = "menuitemVentanaMosaicoVertical"
        Me.menuitemVentanaMosaicoVertical.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaMosaicoVertical.Text = "Mosaico &Vertical"
        '
        'menuitemVentanaCascada
        '
        Me.menuitemVentanaCascada.Name = "menuitemVentanaCascada"
        Me.menuitemVentanaCascada.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaCascada.Text = "&Cascada"
        '
        'menuitemVentanaOrganizarIconos
        '
        Me.menuitemVentanaOrganizarIconos.Name = "menuitemVentanaOrganizarIconos"
        Me.menuitemVentanaOrganizarIconos.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaOrganizarIconos.Text = "&Organizar Iconos"
        '
        'menuitemVentanaSeparadorCerrarTodas
        '
        Me.menuitemVentanaSeparadorCerrarTodas.Name = "menuitemVentanaSeparadorCerrarTodas"
        Me.menuitemVentanaSeparadorCerrarTodas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemVentanaCerrarTodas
        '
        Me.menuitemVentanaCerrarTodas.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_MENU_WINDOW_CLOSE_ALL
        Me.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas"
        Me.menuitemVentanaCerrarTodas.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaCerrarTodas.Text = "Cerrar todas"
        '
        'menuitemVentanaEncajarEnVentana
        '
        Me.menuitemVentanaEncajarEnVentana.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_MENU_WINDOW_FIT_SIZE
        Me.menuitemVentanaEncajarEnVentana.Name = "menuitemVentanaEncajarEnVentana"
        Me.menuitemVentanaEncajarEnVentana.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaEncajarEnVentana.Text = "Encajar en ventana"
        '
        'menuitemVentanaSeparadorListaVentanas
        '
        Me.menuitemVentanaSeparadorListaVentanas.Name = "menuitemVentanaSeparadorListaVentanas"
        Me.menuitemVentanaSeparadorListaVentanas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemAyuda
        '
        Me.menuitemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAyuda_AcercaDe})
        Me.menuitemAyuda.Name = "menuitemAyuda"
        Me.menuitemAyuda.Size = New System.Drawing.Size(53, 20)
        Me.menuitemAyuda.Text = "A&yuda"
        '
        'menuitemAyuda_AcercaDe
        '
        Me.menuitemAyuda_AcercaDe.Name = "menuitemAyuda_AcercaDe"
        Me.menuitemAyuda_AcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.menuitemAyuda_AcercaDe.Text = "&Acerca de..."
        '
        'toolstripMain
        '
        Me.toolstripMain.AllowMerge = False
        Me.toolstripMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonTablas, Me.buttonObjetos, Me.buttonReportes})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 24)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(90, 489)
        Me.toolstripMain.TabIndex = 1
        Me.toolstripMain.Text = "Principal"
        '
        'dropdownbuttonTablas
        '
        Me.dropdownbuttonTablas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemClases})
        Me.dropdownbuttonTablas.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_TABLAS_32
        Me.dropdownbuttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dropdownbuttonTablas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dropdownbuttonTablas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonTablas.Name = "dropdownbuttonTablas"
        Me.dropdownbuttonTablas.Size = New System.Drawing.Size(87, 36)
        Me.dropdownbuttonTablas.Text = "Tablas"
        '
        'menuitemClases
        '
        Me.menuitemClases.Name = "menuitemClases"
        Me.menuitemClases.Size = New System.Drawing.Size(107, 22)
        Me.menuitemClases.Text = "Clases"
        '
        'buttonObjetos
        '
        Me.buttonObjetos.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_OBJETOS_32
        Me.buttonObjetos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonObjetos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonObjetos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonObjetos.Name = "buttonObjetos"
        Me.buttonObjetos.Size = New System.Drawing.Size(87, 36)
        Me.buttonObjetos.Text = "Objetos"
        '
        'buttonReportes
        '
        Me.buttonReportes.Image = Global.CSEstructura.My.Resources.Resources.IMAGE_REPORTES_32
        Me.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonReportes.Name = "buttonReportes"
        Me.buttonReportes.Size = New System.Drawing.Size(87, 36)
        Me.buttonReportes.Text = "Reportes"
        '
        'formMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 535)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.menustripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menustripMain
        Me.Name = "formMDIMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Title"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.menustripMain.ResumeLayout(False)
        Me.menustripMain.PerformLayout()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents labelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menustripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuitemArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Opciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_Salir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaMosaicoHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaMosaicoVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaOrganizarIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaSeparadorCerrarTodas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemVentanaCerrarTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaEncajarEnVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda_AcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonTablas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemClases As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaSeparadorListaVentanas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonObjetos As System.Windows.Forms.ToolStripButton
End Class
