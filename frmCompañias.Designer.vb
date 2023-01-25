<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompañias
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem
        Me.txtBuscador = New System.Windows.Forms.ToolStripTextBox
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGuardar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDeshacer = New System.Windows.Forms.ToolStripMenuItem
        Me.txtStatus = New System.Windows.Forms.ToolStripTextBox
        Me.mnuBloquear = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDesbloquear = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCargarFormato = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dtaCompañias = New System.Windows.Forms.DataGridView
        Me.colSerieListado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colClaveCompañia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNombreCompañia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLogo = New System.Windows.Forms.DataGridViewImageColumn
        Me.lblCompañia = New System.Windows.Forms.Label
        Me.txtClaveCompañia = New System.Windows.Forms.TextBox
        Me.txtNombreCompañia = New System.Windows.Forms.TextBox
        Me.lblNombreCompañia = New System.Windows.Forms.Label
        Me.txtRFC = New System.Windows.Forms.TextBox
        Me.lblRFC = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.cmbSerie = New System.Windows.Forms.ComboBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.lblSerie = New System.Windows.Forms.Label
        Me.lblDoblClickImagen = New System.Windows.Forms.Label
        Me.txtFormato = New System.Windows.Forms.TextBox
        Me.lblFormato = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dtaCompañias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBuscar, Me.txtBuscador, Me.mnuNuevo, Me.mnuGuardar, Me.mnuModificar, Me.mnuEliminar, Me.mnuDeshacer, Me.txtStatus, Me.mnuBloquear, Me.mnuDesbloquear, Me.mnuOpciones, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1003, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuBuscar.Size = New System.Drawing.Size(54, 23)
        Me.mnuBuscar.Text = "Buscar"
        '
        'txtBuscador
        '
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(200, 23)
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.Size = New System.Drawing.Size(53, 23)
        Me.mnuNuevo.Text = "Nueva"
        '
        'mnuGuardar
        '
        Me.mnuGuardar.Enabled = False
        Me.mnuGuardar.Name = "mnuGuardar"
        Me.mnuGuardar.Size = New System.Drawing.Size(61, 23)
        Me.mnuGuardar.Text = "Guardar"
        '
        'mnuModificar
        '
        Me.mnuModificar.Enabled = False
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(70, 23)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Enabled = False
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(62, 23)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuDeshacer
        '
        Me.mnuDeshacer.Name = "mnuDeshacer"
        Me.mnuDeshacer.Size = New System.Drawing.Size(67, 23)
        Me.mnuDeshacer.Text = "Deshacer"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Black
        Me.txtStatus.ForeColor = System.Drawing.Color.Yellow
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(100, 23)
        Me.txtStatus.Text = "Status"
        '
        'mnuBloquear
        '
        Me.mnuBloquear.Enabled = False
        Me.mnuBloquear.Name = "mnuBloquear"
        Me.mnuBloquear.Size = New System.Drawing.Size(66, 23)
        Me.mnuBloquear.Text = "Bloquear"
        '
        'mnuDesbloquear
        '
        Me.mnuDesbloquear.Enabled = False
        Me.mnuDesbloquear.Name = "mnuDesbloquear"
        Me.mnuDesbloquear.Size = New System.Drawing.Size(85, 23)
        Me.mnuDesbloquear.Text = "Desbloquear"
        '
        'mnuOpciones
        '
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCargarFormato})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(69, 23)
        Me.mnuOpciones.Text = "Opciones"
        '
        'mnuCargarFormato
        '
        Me.mnuCargarFormato.Name = "mnuCargarFormato"
        Me.mnuCargarFormato.Size = New System.Drawing.Size(155, 22)
        Me.mnuCargarFormato.Text = "Cargar formato"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'dtaCompañias
        '
        Me.dtaCompañias.AllowUserToAddRows = False
        Me.dtaCompañias.AllowUserToDeleteRows = False
        Me.dtaCompañias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaCompañias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtaCompañias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtaCompañias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaCompañias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSerieListado, Me.colClaveCompañia, Me.colNombreCompañia, Me.colStatus, Me.colLogo})
        Me.dtaCompañias.Location = New System.Drawing.Point(0, 189)
        Me.dtaCompañias.Name = "dtaCompañias"
        Me.dtaCompañias.ReadOnly = True
        Me.dtaCompañias.RowHeadersWidth = 4
        Me.dtaCompañias.Size = New System.Drawing.Size(1003, 281)
        Me.dtaCompañias.TabIndex = 1
        '
        'colSerieListado
        '
        Me.colSerieListado.HeaderText = "Serie"
        Me.colSerieListado.Name = "colSerieListado"
        Me.colSerieListado.ReadOnly = True
        Me.colSerieListado.Width = 56
        '
        'colClaveCompañia
        '
        Me.colClaveCompañia.HeaderText = "Clave compañia"
        Me.colClaveCompañia.Name = "colClaveCompañia"
        Me.colClaveCompañia.ReadOnly = True
        Me.colClaveCompañia.Width = 99
        '
        'colNombreCompañia
        '
        Me.colNombreCompañia.HeaderText = "Nombre compañía"
        Me.colNombreCompañia.Name = "colNombreCompañia"
        Me.colNombreCompañia.ReadOnly = True
        Me.colNombreCompañia.Width = 110
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 62
        '
        'colLogo
        '
        Me.colLogo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colLogo.HeaderText = "Logo"
        Me.colLogo.Name = "colLogo"
        Me.colLogo.ReadOnly = True
        Me.colLogo.Width = 37
        '
        'lblCompañia
        '
        Me.lblCompañia.AutoSize = True
        Me.lblCompañia.Location = New System.Drawing.Point(12, 51)
        Me.lblCompañia.Name = "lblCompañia"
        Me.lblCompañia.Size = New System.Drawing.Size(83, 13)
        Me.lblCompañia.TabIndex = 2
        Me.lblCompañia.Text = "Clave compañia"
        '
        'txtClaveCompañia
        '
        Me.txtClaveCompañia.Location = New System.Drawing.Point(148, 49)
        Me.txtClaveCompañia.Name = "txtClaveCompañia"
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtClaveCompañia.Size = New System.Drawing.Size(135, 20)
        Me.txtClaveCompañia.TabIndex = 3
        '
        'txtNombreCompañia
        '
        Me.txtNombreCompañia.Location = New System.Drawing.Point(99, 80)
        Me.txtNombreCompañia.Name = "txtNombreCompañia"
        Me.txtNombreCompañia.ReadOnly = True
        Me.txtNombreCompañia.Size = New System.Drawing.Size(465, 20)
        Me.txtNombreCompañia.TabIndex = 5
        '
        'lblNombreCompañia
        '
        Me.lblNombreCompañia.AutoSize = True
        Me.lblNombreCompañia.Location = New System.Drawing.Point(12, 83)
        Me.lblNombreCompañia.Name = "lblNombreCompañia"
        Me.lblNombreCompañia.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreCompañia.TabIndex = 4
        Me.lblNombreCompañia.Text = "Nombre"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(99, 111)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.ReadOnly = True
        Me.txtRFC.Size = New System.Drawing.Size(243, 20)
        Me.txtRFC.TabIndex = 7
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(12, 114)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(28, 13)
        Me.lblRFC.TabIndex = 6
        Me.lblRFC.Text = "RFC"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(99, 137)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(465, 20)
        Me.txtDireccion.TabIndex = 9
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(12, 140)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Dirección"
        '
        'cmbSerie
        '
        Me.cmbSerie.Enabled = False
        Me.cmbSerie.FormattingEnabled = True
        Me.cmbSerie.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "A", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.cmbSerie.Location = New System.Drawing.Point(99, 48)
        Me.cmbSerie.Name = "cmbSerie"
        Me.cmbSerie.Size = New System.Drawing.Size(43, 21)
        Me.cmbSerie.TabIndex = 10
        Me.cmbSerie.Text = "A"
        '
        'imgLogo
        '
        Me.imgLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgLogo.Enabled = False
        Me.imgLogo.Location = New System.Drawing.Point(891, 30)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(100, 89)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 11
        Me.imgLogo.TabStop = False
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(99, 34)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 12
        Me.lblSerie.Text = "Serie"
        '
        'lblDoblClickImagen
        '
        Me.lblDoblClickImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDoblClickImagen.Location = New System.Drawing.Point(889, 120)
        Me.lblDoblClickImagen.Name = "lblDoblClickImagen"
        Me.lblDoblClickImagen.Size = New System.Drawing.Size(103, 39)
        Me.lblDoblClickImagen.TabIndex = 14
        Me.lblDoblClickImagen.Text = "De doble click para cargar nueva imágen"
        '
        'txtFormato
        '
        Me.txtFormato.Location = New System.Drawing.Point(99, 163)
        Me.txtFormato.Name = "txtFormato"
        Me.txtFormato.ReadOnly = True
        Me.txtFormato.Size = New System.Drawing.Size(793, 20)
        Me.txtFormato.TabIndex = 16
        '
        'lblFormato
        '
        Me.lblFormato.AutoSize = True
        Me.lblFormato.Location = New System.Drawing.Point(12, 166)
        Me.lblFormato.Name = "lblFormato"
        Me.lblFormato.Size = New System.Drawing.Size(45, 13)
        Me.lblFormato.TabIndex = 15
        Me.lblFormato.Text = "Formato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Clave"
        '
        'frmCompañias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 470)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFormato)
        Me.Controls.Add(Me.lblFormato)
        Me.Controls.Add(Me.lblDoblClickImagen)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.cmbSerie)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.lblRFC)
        Me.Controls.Add(Me.txtNombreCompañia)
        Me.Controls.Add(Me.lblNombreCompañia)
        Me.Controls.Add(Me.txtClaveCompañia)
        Me.Controls.Add(Me.lblCompañia)
        Me.Controls.Add(Me.dtaCompañias)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(931, 501)
        Me.Name = "frmCompañias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compañias"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dtaCompañias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuModificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeshacer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtaCompañias As System.Windows.Forms.DataGridView
    Friend WithEvents lblCompañia As System.Windows.Forms.Label
    Friend WithEvents txtClaveCompañia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCompañia As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCompañia As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtBuscador As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBloquear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDesbloquear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbSerie As System.Windows.Forms.ComboBox
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblDoblClickImagen As System.Windows.Forms.Label
    Friend WithEvents txtFormato As System.Windows.Forms.TextBox
    Friend WithEvents lblFormato As System.Windows.Forms.Label
    Friend WithEvents mnuOpciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCargarFormato As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colSerieListado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colClaveCompañia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreCompañia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLogo As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
