<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerificadorVales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerificadorVales))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox
        Me.cmbSerie = New System.Windows.Forms.ComboBox
        Me.lblSerie = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.lblFolio = New System.Windows.Forms.Label
        Me.dtaVales = New System.Windows.Forms.DataGridView
        Me.lblCompañia = New System.Windows.Forms.Label
        Me.txtCompañia = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.colFechaActivacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColFechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtaVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lector de códigos"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtCodigoBarras.BackColor = System.Drawing.Color.Black
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.ForeColor = System.Drawing.Color.Yellow
        Me.txtCodigoBarras.Location = New System.Drawing.Point(200, 356)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(358, 40)
        Me.txtCodigoBarras.TabIndex = 1
        '
        'cmbSerie
        '
        Me.cmbSerie.FormattingEnabled = True
        Me.cmbSerie.Location = New System.Drawing.Point(49, 62)
        Me.cmbSerie.Name = "cmbSerie"
        Me.cmbSerie.Size = New System.Drawing.Size(121, 21)
        Me.cmbSerie.TabIndex = 2
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(12, 65)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 3
        Me.lblSerie.Text = "Serie"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(176, 65)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(37, 13)
        Me.lblMonto.TabIndex = 4
        Me.lblMonto.Text = "Monto"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(219, 62)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(120, 20)
        Me.txtMonto.TabIndex = 5
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(391, 62)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(120, 20)
        Me.txtFolio.TabIndex = 7
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(348, 65)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(29, 13)
        Me.lblFolio.TabIndex = 6
        Me.lblFolio.Text = "Folio"
        '
        'dtaVales
        '
        Me.dtaVales.AllowUserToAddRows = False
        Me.dtaVales.AllowUserToDeleteRows = False
        Me.dtaVales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtaVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFechaActivacion, Me.colFechaInicial, Me.ColFechaFinal, Me.colFolio, Me.colMonto, Me.colStatus})
        Me.dtaVales.Location = New System.Drawing.Point(12, 90)
        Me.dtaVales.Name = "dtaVales"
        Me.dtaVales.ReadOnly = True
        Me.dtaVales.RowHeadersWidth = 4
        Me.dtaVales.Size = New System.Drawing.Size(718, 239)
        Me.dtaVales.TabIndex = 8
        '
        'lblCompañia
        '
        Me.lblCompañia.AutoSize = True
        Me.lblCompañia.Location = New System.Drawing.Point(9, 21)
        Me.lblCompañia.Name = "lblCompañia"
        Me.lblCompañia.Size = New System.Drawing.Size(54, 13)
        Me.lblCompañia.TabIndex = 9
        Me.lblCompañia.Text = "Compañia"
        '
        'txtCompañia
        '
        Me.txtCompañia.Location = New System.Drawing.Point(69, 18)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.ReadOnly = True
        Me.txtCompañia.Size = New System.Drawing.Size(672, 20)
        Me.txtCompañia.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(744, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Reactivar Vale"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(744, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(744, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Cancela corrida"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(744, 119)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(132, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Reactivar corrida"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'colFechaActivacion
        '
        Me.colFechaActivacion.Frozen = True
        Me.colFechaActivacion.HeaderText = "Fecha activación"
        Me.colFechaActivacion.Name = "colFechaActivacion"
        Me.colFechaActivacion.ReadOnly = True
        Me.colFechaActivacion.Width = 130
        '
        'colFechaInicial
        '
        Me.colFechaInicial.Frozen = True
        Me.colFechaInicial.HeaderText = "Fecha incial"
        Me.colFechaInicial.Name = "colFechaInicial"
        Me.colFechaInicial.ReadOnly = True
        Me.colFechaInicial.Width = 130
        '
        'ColFechaFinal
        '
        Me.ColFechaFinal.Frozen = True
        Me.ColFechaFinal.HeaderText = "Fecha final"
        Me.ColFechaFinal.Name = "ColFechaFinal"
        Me.ColFechaFinal.ReadOnly = True
        Me.ColFechaFinal.Width = 130
        '
        'colFolio
        '
        Me.colFolio.Frozen = True
        Me.colFolio.HeaderText = "Folio"
        Me.colFolio.Name = "colFolio"
        Me.colFolio.ReadOnly = True
        '
        'colMonto
        '
        Me.colMonto.Frozen = True
        Me.colMonto.HeaderText = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.Frozen = True
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmVerificadorVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 408)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCompañia)
        Me.Controls.Add(Me.lblCompañia)
        Me.Controls.Add(Me.dtaVales)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.cmbSerie)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(896, 439)
        Me.Name = "frmVerificadorVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificador de vales"
        CType(Me.dtaVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents cmbSerie As System.Windows.Forms.ComboBox
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents lblFolio As System.Windows.Forms.Label
    Friend WithEvents dtaVales As System.Windows.Forms.DataGridView
    Friend WithEvents lblCompañia As System.Windows.Forms.Label
    Friend WithEvents txtCompañia As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents colFechaActivacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
