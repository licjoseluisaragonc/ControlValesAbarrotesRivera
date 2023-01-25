<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministradorVales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministradorVales))
        Me.lblCompañia = New System.Windows.Forms.Label
        Me.lblClaveCompañia = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem
        Me.txtBuscador = New System.Windows.Forms.ToolStripTextBox
        Me.mnuNuevosVales = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRegistrarVales = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEliminaVales = New System.Windows.Forms.ToolStripMenuItem
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtStatusVales = New System.Windows.Forms.ToolStripTextBox
        Me.mnuReporteImpreso = New System.Windows.Forms.ToolStripMenuItem
        Me.ImprimirTirajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtClaveCompañia = New System.Windows.Forms.TextBox
        Me.txtCompañia = New System.Windows.Forms.TextBox
        Me.grpCompañia = New System.Windows.Forms.GroupBox
        Me.txtRutaFormato = New System.Windows.Forms.TextBox
        Me.lblRutaFormato = New System.Windows.Forms.Label
        Me.btnBuscarCompañias = New System.Windows.Forms.Button
        Me.grpVales = New System.Windows.Forms.GroupBox
        Me.dteFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dteFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.txtMontoEspecifico = New System.Windows.Forms.TextBox
        Me.txtMontoEnLetra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolioFinal = New System.Windows.Forms.TextBox
        Me.lblFolioFinal = New System.Windows.Forms.Label
        Me.txtFolioInicial = New System.Windows.Forms.TextBox
        Me.lblFolioInicial = New System.Windows.Forms.Label
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.pnlBuscarClientes = New System.Windows.Forms.Panel
        Me.lblFiltroCompañias = New System.Windows.Forms.Label
        Me.txtFiltroCompañias = New System.Windows.Forms.TextBox
        Me.dtaBuscarCliente = New System.Windows.Forms.DataGridView
        Me.colClaveCompañia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlBuscarCorridas = New System.Windows.Forms.Panel
        Me.dtaBuscarVales = New System.Windows.Forms.DataGridView
        Me.colClaveCompañiabuscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNombreBuscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaInicioBscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaFinBuscadr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFolioInicialBuscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFolioFinalBuscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMontoBuscador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValesRivera11 = New ControlValesAbarrotesRivera.ValesRivera1
        Me.MenuStrip1.SuspendLayout()
        Me.grpCompañia.SuspendLayout()
        Me.grpVales.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlBuscarClientes.SuspendLayout()
        CType(Me.dtaBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBuscarCorridas.SuspendLayout()
        CType(Me.dtaBuscarVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCompañia
        '
        Me.lblCompañia.AutoSize = True
        Me.lblCompañia.Location = New System.Drawing.Point(18, 54)
        Me.lblCompañia.Name = "lblCompañia"
        Me.lblCompañia.Size = New System.Drawing.Size(54, 13)
        Me.lblCompañia.TabIndex = 2
        Me.lblCompañia.Text = "Compañia"
        '
        'lblClaveCompañia
        '
        Me.lblClaveCompañia.AutoSize = True
        Me.lblClaveCompañia.Location = New System.Drawing.Point(18, 15)
        Me.lblClaveCompañia.Name = "lblClaveCompañia"
        Me.lblClaveCompañia.Size = New System.Drawing.Size(34, 13)
        Me.lblClaveCompañia.TabIndex = 3
        Me.lblClaveCompañia.Text = "Clave"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBuscar, Me.txtBuscador, Me.mnuNuevosVales, Me.mnuRegistrarVales, Me.mnuEliminaVales, Me.DeshacerToolStripMenuItem, Me.txtStatusVales, Me.mnuReporteImpreso, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(996, 27)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuBuscar.Size = New System.Drawing.Size(60, 23)
        Me.mnuBuscar.Text = "Buscar: "
        '
        'txtBuscador
        '
        Me.txtBuscador.BackColor = System.Drawing.Color.Black
        Me.txtBuscador.ForeColor = System.Drawing.Color.White
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(250, 23)
        '
        'mnuNuevosVales
        '
        Me.mnuNuevosVales.Name = "mnuNuevosVales"
        Me.mnuNuevosVales.Size = New System.Drawing.Size(83, 23)
        Me.mnuNuevosVales.Text = "Nuevo tiraje"
        '
        'mnuRegistrarVales
        '
        Me.mnuRegistrarVales.Enabled = False
        Me.mnuRegistrarVales.Name = "mnuRegistrarVales"
        Me.mnuRegistrarVales.Size = New System.Drawing.Size(65, 23)
        Me.mnuRegistrarVales.Text = "Registrar"
        '
        'mnuEliminaVales
        '
        Me.mnuEliminaVales.Enabled = False
        Me.mnuEliminaVales.Name = "mnuEliminaVales"
        Me.mnuEliminaVales.Size = New System.Drawing.Size(91, 23)
        Me.mnuEliminaVales.Text = "Eliminar tiraje"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'txtStatusVales
        '
        Me.txtStatusVales.BackColor = System.Drawing.Color.Black
        Me.txtStatusVales.ForeColor = System.Drawing.Color.Yellow
        Me.txtStatusVales.Name = "txtStatusVales"
        Me.txtStatusVales.Size = New System.Drawing.Size(100, 23)
        Me.txtStatusVales.Text = "Status..."
        '
        'mnuReporteImpreso
        '
        Me.mnuReporteImpreso.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirTirajeToolStripMenuItem})
        Me.mnuReporteImpreso.Name = "mnuReporteImpreso"
        Me.mnuReporteImpreso.Size = New System.Drawing.Size(106, 23)
        Me.mnuReporteImpreso.Text = "Reporte impreso"
        '
        'ImprimirTirajeToolStripMenuItem
        '
        Me.ImprimirTirajeToolStripMenuItem.Name = "ImprimirTirajeToolStripMenuItem"
        Me.ImprimirTirajeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImprimirTirajeToolStripMenuItem.Text = "Imprimir tiraje"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 23)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtClaveCompañia
        '
        Me.txtClaveCompañia.Location = New System.Drawing.Point(18, 31)
        Me.txtClaveCompañia.Name = "txtClaveCompañia"
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtClaveCompañia.Size = New System.Drawing.Size(151, 20)
        Me.txtClaveCompañia.TabIndex = 1
        '
        'txtCompañia
        '
        Me.txtCompañia.Location = New System.Drawing.Point(18, 70)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.ReadOnly = True
        Me.txtCompañia.Size = New System.Drawing.Size(525, 20)
        Me.txtCompañia.TabIndex = 2
        '
        'grpCompañia
        '
        Me.grpCompañia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCompañia.Controls.Add(Me.txtRutaFormato)
        Me.grpCompañia.Controls.Add(Me.lblRutaFormato)
        Me.grpCompañia.Controls.Add(Me.btnBuscarCompañias)
        Me.grpCompañia.Controls.Add(Me.lblClaveCompañia)
        Me.grpCompañia.Controls.Add(Me.txtClaveCompañia)
        Me.grpCompañia.Controls.Add(Me.lblCompañia)
        Me.grpCompañia.Controls.Add(Me.txtCompañia)
        Me.grpCompañia.Enabled = False
        Me.grpCompañia.Location = New System.Drawing.Point(8, 6)
        Me.grpCompañia.Name = "grpCompañia"
        Me.grpCompañia.Size = New System.Drawing.Size(974, 136)
        Me.grpCompañia.TabIndex = 8
        Me.grpCompañia.TabStop = False
        Me.grpCompañia.Text = "Compañia de asignación"
        '
        'txtRutaFormato
        '
        Me.txtRutaFormato.Location = New System.Drawing.Point(18, 111)
        Me.txtRutaFormato.Name = "txtRutaFormato"
        Me.txtRutaFormato.ReadOnly = True
        Me.txtRutaFormato.Size = New System.Drawing.Size(797, 20)
        Me.txtRutaFormato.TabIndex = 5
        '
        'lblRutaFormato
        '
        Me.lblRutaFormato.AutoSize = True
        Me.lblRutaFormato.Location = New System.Drawing.Point(18, 95)
        Me.lblRutaFormato.Name = "lblRutaFormato"
        Me.lblRutaFormato.Size = New System.Drawing.Size(68, 13)
        Me.lblRutaFormato.TabIndex = 15
        Me.lblRutaFormato.Text = "Ruta formato"
        '
        'btnBuscarCompañias
        '
        Me.btnBuscarCompañias.Location = New System.Drawing.Point(175, 29)
        Me.btnBuscarCompañias.Name = "btnBuscarCompañias"
        Me.btnBuscarCompañias.Size = New System.Drawing.Size(210, 23)
        Me.btnBuscarCompañias.TabIndex = 10
        Me.btnBuscarCompañias.Text = "Buscar compañias"
        Me.btnBuscarCompañias.UseVisualStyleBackColor = True
        '
        'grpVales
        '
        Me.grpVales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVales.Controls.Add(Me.dteFechaFinal)
        Me.grpVales.Controls.Add(Me.dteFechaInicial)
        Me.grpVales.Controls.Add(Me.txtMontoEspecifico)
        Me.grpVales.Controls.Add(Me.txtMontoEnLetra)
        Me.grpVales.Controls.Add(Me.Label1)
        Me.grpVales.Controls.Add(Me.Label2)
        Me.grpVales.Controls.Add(Me.txtFolioFinal)
        Me.grpVales.Controls.Add(Me.lblFolioFinal)
        Me.grpVales.Controls.Add(Me.txtFolioInicial)
        Me.grpVales.Controls.Add(Me.lblFolioInicial)
        Me.grpVales.Controls.Add(Me.lblFechaFinal)
        Me.grpVales.Controls.Add(Me.lblFechaInicial)
        Me.grpVales.Location = New System.Drawing.Point(8, 144)
        Me.grpVales.Name = "grpVales"
        Me.grpVales.Size = New System.Drawing.Size(974, 292)
        Me.grpVales.TabIndex = 9
        Me.grpVales.TabStop = False
        Me.grpVales.Text = "Vales"
        '
        'dteFechaFinal
        '
        Me.dteFechaFinal.Location = New System.Drawing.Point(224, 32)
        Me.dteFechaFinal.Name = "dteFechaFinal"
        Me.dteFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.dteFechaFinal.TabIndex = 14
        '
        'dteFechaInicial
        '
        Me.dteFechaInicial.Location = New System.Drawing.Point(18, 32)
        Me.dteFechaInicial.Name = "dteFechaInicial"
        Me.dteFechaInicial.Size = New System.Drawing.Size(200, 20)
        Me.dteFechaInicial.TabIndex = 13
        '
        'txtMontoEspecifico
        '
        Me.txtMontoEspecifico.Location = New System.Drawing.Point(18, 71)
        Me.txtMontoEspecifico.Name = "txtMontoEspecifico"
        Me.txtMontoEspecifico.Size = New System.Drawing.Size(188, 20)
        Me.txtMontoEspecifico.TabIndex = 12
        '
        'txtMontoEnLetra
        '
        Me.txtMontoEnLetra.Location = New System.Drawing.Point(18, 110)
        Me.txtMontoEnLetra.Multiline = True
        Me.txtMontoEnLetra.Name = "txtMontoEnLetra"
        Me.txtMontoEnLetra.ReadOnly = True
        Me.txtMontoEnLetra.Size = New System.Drawing.Size(382, 164)
        Me.txtMontoEnLetra.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Monto en letra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Monto específico"
        '
        'txtFolioFinal
        '
        Me.txtFolioFinal.Location = New System.Drawing.Point(726, 32)
        Me.txtFolioFinal.Name = "txtFolioFinal"
        Me.txtFolioFinal.Size = New System.Drawing.Size(188, 20)
        Me.txtFolioFinal.TabIndex = 9
        '
        'lblFolioFinal
        '
        Me.lblFolioFinal.AutoSize = True
        Me.lblFolioFinal.Location = New System.Drawing.Point(726, 16)
        Me.lblFolioFinal.Name = "lblFolioFinal"
        Me.lblFolioFinal.Size = New System.Drawing.Size(51, 13)
        Me.lblFolioFinal.TabIndex = 6
        Me.lblFolioFinal.Text = "Folio final"
        '
        'txtFolioInicial
        '
        Me.txtFolioInicial.Location = New System.Drawing.Point(532, 32)
        Me.txtFolioInicial.Name = "txtFolioInicial"
        Me.txtFolioInicial.Size = New System.Drawing.Size(188, 20)
        Me.txtFolioInicial.TabIndex = 8
        '
        'lblFolioInicial
        '
        Me.lblFolioInicial.AutoSize = True
        Me.lblFolioInicial.Location = New System.Drawing.Point(532, 16)
        Me.lblFolioInicial.Name = "lblFolioInicial"
        Me.lblFolioInicial.Size = New System.Drawing.Size(58, 13)
        Me.lblFolioInicial.TabIndex = 4
        Me.lblFolioInicial.Text = "Folio inicial"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(221, 16)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(59, 13)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Fecha final"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(18, 16)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaInicial.TabIndex = 0
        Me.lblFechaInicial.Text = "Fecha inicial"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(938, 436)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'reportDocument1
        '
        Me.reportDocument1.FileName = "rassdk://C:\Aragon\Proyectos Aragon 2018 VS2008\ControlValesRivera2018\ControlVal" & _
            "esAbarrotesRivera\ControlValesAbarrotesRivera\ValesRivera1.rpt"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(996, 468)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpCompañia)
        Me.TabPage1.Controls.Add(Me.grpVales)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(988, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(944, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Vista previa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'pnlBuscarClientes
        '
        Me.pnlBuscarClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBuscarClientes.Controls.Add(Me.lblFiltroCompañias)
        Me.pnlBuscarClientes.Controls.Add(Me.txtFiltroCompañias)
        Me.pnlBuscarClientes.Controls.Add(Me.dtaBuscarCliente)
        Me.pnlBuscarClientes.Location = New System.Drawing.Point(401, 88)
        Me.pnlBuscarClientes.Name = "pnlBuscarClientes"
        Me.pnlBuscarClientes.Size = New System.Drawing.Size(533, 393)
        Me.pnlBuscarClientes.TabIndex = 19
        Me.pnlBuscarClientes.Visible = False
        '
        'lblFiltroCompañias
        '
        Me.lblFiltroCompañias.AutoSize = True
        Me.lblFiltroCompañias.Location = New System.Drawing.Point(13, 6)
        Me.lblFiltroCompañias.Name = "lblFiltroCompañias"
        Me.lblFiltroCompañias.Size = New System.Drawing.Size(29, 13)
        Me.lblFiltroCompañias.TabIndex = 2
        Me.lblFiltroCompañias.Text = "Filtro"
        '
        'txtFiltroCompañias
        '
        Me.txtFiltroCompañias.Location = New System.Drawing.Point(101, 3)
        Me.txtFiltroCompañias.Name = "txtFiltroCompañias"
        Me.txtFiltroCompañias.Size = New System.Drawing.Size(429, 20)
        Me.txtFiltroCompañias.TabIndex = 1
        '
        'dtaBuscarCliente
        '
        Me.dtaBuscarCliente.AllowUserToAddRows = False
        Me.dtaBuscarCliente.AllowUserToDeleteRows = False
        Me.dtaBuscarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaBuscarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaveCompañia, Me.colNombreCliente})
        Me.dtaBuscarCliente.Location = New System.Drawing.Point(0, 29)
        Me.dtaBuscarCliente.Name = "dtaBuscarCliente"
        Me.dtaBuscarCliente.ReadOnly = True
        Me.dtaBuscarCliente.RowHeadersWidth = 4
        Me.dtaBuscarCliente.Size = New System.Drawing.Size(533, 364)
        Me.dtaBuscarCliente.TabIndex = 0
        '
        'colClaveCompañia
        '
        Me.colClaveCompañia.HeaderText = "Clave compañia"
        Me.colClaveCompañia.Name = "colClaveCompañia"
        Me.colClaveCompañia.ReadOnly = True
        '
        'colNombreCliente
        '
        Me.colNombreCliente.HeaderText = "Nombre"
        Me.colNombreCliente.Name = "colNombreCliente"
        Me.colNombreCliente.ReadOnly = True
        Me.colNombreCliente.Width = 350
        '
        'pnlBuscarCorridas
        '
        Me.pnlBuscarCorridas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBuscarCorridas.Controls.Add(Me.dtaBuscarVales)
        Me.pnlBuscarCorridas.Location = New System.Drawing.Point(0, 29)
        Me.pnlBuscarCorridas.Name = "pnlBuscarCorridas"
        Me.pnlBuscarCorridas.Size = New System.Drawing.Size(994, 469)
        Me.pnlBuscarCorridas.TabIndex = 20
        Me.pnlBuscarCorridas.Visible = False
        '
        'dtaBuscarVales
        '
        Me.dtaBuscarVales.AllowUserToAddRows = False
        Me.dtaBuscarVales.AllowUserToDeleteRows = False
        Me.dtaBuscarVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaBuscarVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colClaveCompañiabuscador, Me.colNombreBuscador, Me.colFechaInicioBscador, Me.colFechaFinBuscadr, Me.colFolioInicialBuscador, Me.colFolioFinalBuscador, Me.colMontoBuscador})
        Me.dtaBuscarVales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtaBuscarVales.Location = New System.Drawing.Point(0, 0)
        Me.dtaBuscarVales.Name = "dtaBuscarVales"
        Me.dtaBuscarVales.ReadOnly = True
        Me.dtaBuscarVales.RowHeadersWidth = 4
        Me.dtaBuscarVales.Size = New System.Drawing.Size(994, 469)
        Me.dtaBuscarVales.TabIndex = 0
        '
        'colClaveCompañiabuscador
        '
        Me.colClaveCompañiabuscador.HeaderText = "Clave compañia"
        Me.colClaveCompañiabuscador.Name = "colClaveCompañiabuscador"
        Me.colClaveCompañiabuscador.ReadOnly = True
        '
        'colNombreBuscador
        '
        Me.colNombreBuscador.HeaderText = "Nombre"
        Me.colNombreBuscador.Name = "colNombreBuscador"
        Me.colNombreBuscador.ReadOnly = True
        Me.colNombreBuscador.Width = 350
        '
        'colFechaInicioBscador
        '
        Me.colFechaInicioBscador.HeaderText = "Fecha inicio"
        Me.colFechaInicioBscador.Name = "colFechaInicioBscador"
        Me.colFechaInicioBscador.ReadOnly = True
        '
        'colFechaFinBuscadr
        '
        Me.colFechaFinBuscadr.HeaderText = "Fecha fin"
        Me.colFechaFinBuscadr.Name = "colFechaFinBuscadr"
        Me.colFechaFinBuscadr.ReadOnly = True
        '
        'colFolioInicialBuscador
        '
        Me.colFolioInicialBuscador.HeaderText = "Folio inicial"
        Me.colFolioInicialBuscador.Name = "colFolioInicialBuscador"
        Me.colFolioInicialBuscador.ReadOnly = True
        '
        'colFolioFinalBuscador
        '
        Me.colFolioFinalBuscador.HeaderText = "Folio final"
        Me.colFolioFinalBuscador.Name = "colFolioFinalBuscador"
        Me.colFolioFinalBuscador.ReadOnly = True
        '
        'colMontoBuscador
        '
        Me.colMontoBuscador.HeaderText = "Monto vales"
        Me.colMontoBuscador.Name = "colMontoBuscador"
        Me.colMontoBuscador.ReadOnly = True
        '
        'frmAdministradorVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 499)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlBuscarCorridas)
        Me.Controls.Add(Me.pnlBuscarClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(960, 530)
        Me.Name = "frmAdministradorVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de vales"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpCompañia.ResumeLayout(False)
        Me.grpCompañia.PerformLayout()
        Me.grpVales.ResumeLayout(False)
        Me.grpVales.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.pnlBuscarClientes.ResumeLayout(False)
        Me.pnlBuscarClientes.PerformLayout()
        CType(Me.dtaBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBuscarCorridas.ResumeLayout(False)
        CType(Me.dtaBuscarVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompañia As System.Windows.Forms.Label
    Friend WithEvents lblClaveCompañia As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBuscador As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtClaveCompañia As System.Windows.Forms.TextBox
    Friend WithEvents txtCompañia As System.Windows.Forms.TextBox
    Friend WithEvents grpCompañia As System.Windows.Forms.GroupBox
    Friend WithEvents mnuNuevosVales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminaVales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtStatusVales As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents mnuReporteImpreso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpVales As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents txtFolioFinal As System.Windows.Forms.TextBox
    Friend WithEvents lblFolioFinal As System.Windows.Forms.Label
    Friend WithEvents txtFolioInicial As System.Windows.Forms.TextBox
    Friend WithEvents lblFolioInicial As System.Windows.Forms.Label
    Friend WithEvents txtMontoEnLetra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents btnBuscarCompañias As System.Windows.Forms.Button
    Friend WithEvents txtRutaFormato As System.Windows.Forms.TextBox
    Friend WithEvents lblRutaFormato As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pnlBuscarClientes As System.Windows.Forms.Panel
    Friend WithEvents dtaBuscarCliente As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltroCompañias As System.Windows.Forms.TextBox
    Friend WithEvents lblFiltroCompañias As System.Windows.Forms.Label
    Friend WithEvents colClaveCompañia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuRegistrarVales As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlBuscarCorridas As System.Windows.Forms.Panel
    Friend WithEvents dtaBuscarVales As System.Windows.Forms.DataGridView
    Friend WithEvents colClaveCompañiabuscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreBuscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicioBscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaFinBuscadr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFolioInicialBuscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFolioFinalBuscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMontoBuscador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMontoEspecifico As System.Windows.Forms.TextBox
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dteFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents ValesRivera11 As ControlValesAbarrotesRivera.ValesRivera1
    Friend WithEvents ImprimirTirajeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
