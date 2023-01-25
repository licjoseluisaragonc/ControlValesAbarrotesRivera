<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuDatos = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportarLecturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarComunicadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GestiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCompañias = New System.Windows.Forms.ToolStripMenuItem
        Me.TiendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GeneraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.muAdministradorVales = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuVerificadorVales = New System.Windows.Forms.ToolStripMenuItem
        Me.SoporteCVR2018ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbouthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudasVisualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDatos, Me.GestiónToolStripMenuItem, Me.GeneraciónToolStripMenuItem, Me.SoporteCVR2018ToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(959, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDatos
        '
        Me.mnuDatos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarLecturasToolStripMenuItem, Me.GenerarComunicadosToolStripMenuItem})
        Me.mnuDatos.Name = "mnuDatos"
        Me.mnuDatos.Size = New System.Drawing.Size(49, 20)
        Me.mnuDatos.Text = "Datos"
        '
        'ImportarLecturasToolStripMenuItem
        '
        Me.ImportarLecturasToolStripMenuItem.Name = "ImportarLecturasToolStripMenuItem"
        Me.ImportarLecturasToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ImportarLecturasToolStripMenuItem.Text = "Importar lecturas"
        '
        'GenerarComunicadosToolStripMenuItem
        '
        Me.GenerarComunicadosToolStripMenuItem.Name = "GenerarComunicadosToolStripMenuItem"
        Me.GenerarComunicadosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.GenerarComunicadosToolStripMenuItem.Text = "Generar envio a tiendas"
        '
        'GestiónToolStripMenuItem
        '
        Me.GestiónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCompañias, Me.TiendasToolStripMenuItem})
        Me.GestiónToolStripMenuItem.Name = "GestiónToolStripMenuItem"
        Me.GestiónToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestiónToolStripMenuItem.Text = "Gestión"
        '
        'mnuCompañias
        '
        Me.mnuCompañias.Name = "mnuCompañias"
        Me.mnuCompañias.Size = New System.Drawing.Size(152, 22)
        Me.mnuCompañias.Text = "Compañias"
        '
        'TiendasToolStripMenuItem
        '
        Me.TiendasToolStripMenuItem.Name = "TiendasToolStripMenuItem"
        Me.TiendasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TiendasToolStripMenuItem.Text = "Tiendas"
        '
        'GeneraciónToolStripMenuItem
        '
        Me.GeneraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.muAdministradorVales, Me.mnuVerificadorVales})
        Me.GeneraciónToolStripMenuItem.Name = "GeneraciónToolStripMenuItem"
        Me.GeneraciónToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.GeneraciónToolStripMenuItem.Text = "Administraciòn"
        '
        'muAdministradorVales
        '
        Me.muAdministradorVales.Name = "muAdministradorVales"
        Me.muAdministradorVales.Size = New System.Drawing.Size(179, 22)
        Me.muAdministradorVales.Text = "Administrador vales"
        '
        'mnuVerificadorVales
        '
        Me.mnuVerificadorVales.Name = "mnuVerificadorVales"
        Me.mnuVerificadorVales.Size = New System.Drawing.Size(179, 22)
        Me.mnuVerificadorVales.Text = "Verificador de vales"
        '
        'SoporteCVR2018ToolStripMenuItem
        '
        Me.SoporteCVR2018ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbouthToolStripMenuItem, Me.AyudasVisualesToolStripMenuItem})
        Me.SoporteCVR2018ToolStripMenuItem.Name = "SoporteCVR2018ToolStripMenuItem"
        Me.SoporteCVR2018ToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.SoporteCVR2018ToolStripMenuItem.Text = "Soporte CVR 2018"
        '
        'AbouthToolStripMenuItem
        '
        Me.AbouthToolStripMenuItem.Name = "AbouthToolStripMenuItem"
        Me.AbouthToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AbouthToolStripMenuItem.Text = "Abouth"
        '
        'AyudasVisualesToolStripMenuItem
        '
        Me.AyudasVisualesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.AyudasVisualesToolStripMenuItem.Name = "AyudasVisualesToolStripMenuItem"
        Me.AyudasVisualesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AyudasVisualesToolStripMenuItem.Text = "Ayudas visuales"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 517)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control vales de despensa Abarrotes Rivera V 2.0.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteCVR2018ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbouthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudasVisualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarLecturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarComunicadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCompañias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents muAdministradorVales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerificadorVales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
