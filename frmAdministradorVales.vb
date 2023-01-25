Option Explicit On
Imports ADODB


Public Class frmAdministradorVales

    Function CantidadEnLetra(ByVal tyCantidad As Double) As String
        If tyCantidad <= 0 Then Return "Valor Negativo"
        CantidadEnLetra = ""
        Dim lyCantidad, lyCentavos, laUnidades, laDecenas, laCentenas, lnNumeroBloques, lnPrimerDigito, lnSegundoDigito, lnTercerDigito, lcBloque, lnBloqueCero
        Dim i, lnDigito
        Dim ArrayUnidades() As String = {"UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE", "VEINTIUN", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE"}
        Dim ArrayDecenas() As String = {"DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"}
        Dim ArrayCentenas() As String = {"CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}
        tyCantidad = Math.Round(tyCantidad, 2)
        lyCantidad = Int(tyCantidad)
        lyCentavos = (tyCantidad - lyCantidad) * 100
        laUnidades = ArrayUnidades
        laDecenas = ArrayDecenas
        laCentenas = ArrayCentenas
        lnNumeroBloques = 1
        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0
            For i = 1 To 3
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", System.DBNull.Value) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "CIEN", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    CantidadEnLetra = lcBloque
                Case 2
                    CantidadEnLetra = lcBloque & IIf(lnBloqueCero = 3, System.DBNull.Value, " MIL") & CantidadEnLetra
                Case 3
                    CantidadEnLetra = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " MILLON", " MILLONES") & CantidadEnLetra
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        CantidadEnLetra = "(" & CantidadEnLetra & IIf(tyCantidad > 1, " PESOS ", " PESO ") & Format(lyCentavos, "00") & "/100 M.N. )"
    End Function

    Private Function Mes(ByVal NumeroMes As Integer) As String
        Mes = " "
        Select Case NumeroMes
            Case 1
                Mes = "ENERO"
            Case 2
                Mes = "FEBRERO"
            Case 3
                Mes = "MARZO"
            Case 4
                Mes = "ABRIL"
            Case 5
                Mes = "MAYO"
            Case 6
                Mes = "JUNIO"
            Case 7
                Mes = "JULIO"
            Case 8
                Mes = "AGOSTO"
            Case 9
                Mes = "SEPTIEMBRE"
            Case 10
                Mes = "OCTUBRE"
            Case 11
                Mes = "NOVIEMBRE"
            Case 12
                Mes = "DICIEMBRE"
        End Select
    End Function

    Private Sub Compañias(ByVal ObjetoX As Object)
        Try
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            With rst1
                If .State = 1 Then .Close()
                .Open("Select * from Compañias where Status = 'AC'", Cnn1, CursorTypeEnum.adOpenKeyset, LockTypeEnum.adLockOptimistic)
                ObjetoX.Clear()
                If .RecordCount >= 0 Then
                    .MoveFirst()
                    Do While Not .EOF = True
                        ObjetoX.AddItem(.Fields!Nombre_Compañia.Value)
                        .MoveNext()
                    Loop
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error al buscar compañias: " & ex.Message)
        End Try
    End Sub

    Private Sub frmAdministradorVales_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call CerrarPendientes()
    End Sub

    Private Sub frmAdministradorVales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Limpiar_Todo()
        Me.pnlBuscarClientes.BringToFront()
        Me.pnlBuscarCorridas.BringToFront()
    End Sub


    Private Sub CerrarPendientes()
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            If Cnn1.State = 0 Then Cnn1.Open()

            cmd.CommandText = "UPDATE Seriales Set Status = 'PE' Where Status = 'IM'"
            cmd.Execute()
        Catch ex As Exception
            MessageBox.Show("Error al cerrar series impresas: " & ex.Message)
        End Try
    End Sub

    Private Sub Limpiar_Todo()
        Try
            Me.txtClaveCompañia.Text = " "
            Me.txtCompañia.Text = " "
            Me.txtRutaFormato.Text = " "

            Me.grpCompañia.Enabled = False

            Me.dteFechaInicial.Value = Date.Now.ToString("dd/MM/yyyy")
            Me.dteFechaFinal.Value = Date.Now.ToString("dd/MM/yyyy")
            Me.txtFolioInicial.Text = " "
            Me.txtFolioFinal.Text = " "

            Me.dteFechaInicial.Enabled = False
            Me.dteFechaFinal.Enabled = False
            Me.txtFolioInicial.ReadOnly = True
            Me.txtFolioFinal.ReadOnly = True

            Me.txtMontoEspecifico.Text = 0
            Me.txtMontoEspecifico.ReadOnly = True

        Catch ex As Exception
            MessageBox.Show("Error al limpiar ventana: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarFormato(ByVal RutaX As String, ByVal Consulta As String)
        Try
            Dim rsAccesos As ADODB.Recordset = New ADODB.Recordset

            Me.reportDocument1.Load(RutaX)

            If rsAccesos.State = 0 Then rsAccesos.Open(Consulta, Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockBatchOptimistic)
            Me.reportDocument1.SetDataSource(rsAccesos)
            Me.CrystalReportViewer1.ReportSource = Me.reportDocument1
            Me.CrystalReportViewer1.Refresh()
            Me.Show()
        Catch ex As Exception
            MessageBox.Show("No hay datos para mostrar: " & ex.Message)
        End Try
    End Sub

    Private Sub ImpresosX()
        Dim Consulta As String = ""
        Dim rsReportes As ADODB.Recordset = New ADODB.Recordset

        Consulta = "Select * from VistaArticulosExistencias Where Descripcion LIKE '%" & Me.txtBuscador.Text.Trim & "%' AND Existencia > 0 AND Nombre = '"
        Me.reportDocument1.Load(My.Application.Info.DirectoryPath & "\rptExistencias.rpt")

        If rsReportes.State = 0 Then rsReportes.Open(Consulta, Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        Me.reportDocument1.SetDataSource(rsReportes)
        Me.CrystalReportViewer1.ReportSource = Me.reportDocument1
        Me.Show()
    End Sub

    Private Sub txtMontoEspecifico_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoEspecifico.TextChanged
        Me.txtMontoEnLetra.Text = CantidadEnLetra(Me.txtMontoEspecifico.Text.Trim)
    End Sub

    Private Sub mnuNuevosVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevosVales.Click
        Try
            Me.txtClaveCompañia.Text = " "
            Me.txtCompañia.Text = " "
            Me.txtRutaFormato.Text = " "

            Me.grpCompañia.Enabled = True

            Me.dteFechaInicial.Value = Date.Now
            Me.dteFechaFinal.Value = Date.Now
            Me.txtFolioInicial.Text = " "
            Me.txtFolioFinal.Text = " "

            Me.dteFechaInicial.Enabled = True
            Me.dteFechaFinal.Enabled = True
            Me.txtFolioInicial.ReadOnly = False
            Me.txtFolioFinal.ReadOnly = False

            Me.txtMontoEspecifico.Text = "0"
            Me.txtMontoEspecifico.ReadOnly = False

            Me.mnuRegistrarVales.Enabled = True
            Me.mnuEliminaVales.Enabled = False
            Me.mnuNuevosVales.Enabled = False

            Me.txtClaveCompañia.Focus()
            MessageBox.Show("Listo, es necesario cargar un cliente")
        Catch ex As Exception
            MessageBox.Show("Error al limpiar ventana: " & ex.Message)
        End Try
    End Sub

    Private Sub mnuEliminaVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminaVales.Click
        Try
            If MessageBox.Show("¿Está seguro de querer eliminar el tiraje? esta acción eliminara toda información correspondiente y no será posible recuperar datos", "Alerta de sistema", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Delete from Altas_Vales Where (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Folio_Inicial = " & Val(Me.txtFolioInicial.Text) & " AND Folio_Final = " & Val(Me.txtFolioFinal.Text) & ") "
            cmd.Execute()
            Dim a As Integer = 0
            For a = Val(Me.txtFolioInicial.Text) To Val(Me.txtFolioFinal.Text)
                cmd.CommandText = "Delete from Seriales Where (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Serial = " & Val(a) & ")"
                cmd.Execute()
            Next
            Call Limpiar_Todo()
            MessageBox.Show("Datos borrados satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show("Error al eliminar tiraje del sistema: " & ex.Message)
        End Try
    End Sub

    Private Sub txtBuscador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscador.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Me.dtaBuscarVales.Rows.Clear()
                Dim cmd As ADODB.Command = New ADODB.Command
                cmd.ActiveConnection = Cnn1
                cmd.CommandText = "Select * From Altas_Vales Where (Compañia Like '%" & Me.txtBuscador.Text.Trim & "%')"

                Dim rst1 As ADODB.Recordset = New ADODB.Recordset

                rst1 = cmd.Execute
                With rst1
                    While Not .EOF = True
                        Me.dtaBuscarVales.Rows.Add()
                        Me.dtaBuscarVales.Item(0, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Clave_Compañia.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(1, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Compañia.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(2, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Fecha_Inicial.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(3, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Fecha_Final.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(4, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Folio_Inicial.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(5, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Folio_Final.Value.ToString.Trim
                        Me.dtaBuscarVales.Item(6, Me.dtaBuscarVales.Rows.Count - 1).Value = .Fields!Monto.Value.ToString.Trim
                        .MoveNext()
                    End While
                End With
                Me.pnlBuscarCorridas.Visible = True
                Me.dtaBuscarVales.Focus()
            ElseIf e.KeyCode = Keys.Escape Then
                Me.txtBuscador.Text = ""
                Me.pnlBuscarCorridas.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar vales: " & ex.Message)
        End Try
    End Sub

    Private Sub BuscarCompañia(ByVal Dato As String)
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset

            cmd.CommandText = "Select * From Compañias Where Nombre_Compañia Like '%" & Dato.Trim & "%' And Status = 'AC'"
            cmd.ActiveConnection = Cnn1

            rst1 = cmd.Execute
            With rst1
                Do While Not .EOF = True
                    Me.dtaBuscarCliente.Rows.Add()
                    Me.dtaBuscarCliente.Item(0, Me.dtaBuscarCliente.Rows.Count - 1).Value = .Fields!Serie_Compañia.Value.ToString.Trim.ToUpper & .Fields!Clave_Compañia.Value.ToString.Trim.ToUpper
                    Me.dtaBuscarCliente.Item(1, Me.dtaBuscarCliente.Rows.Count - 1).Value = .Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                    .MoveNext()
                Loop
                .Close()
            End With
            Me.dtaBuscarCliente.Focus()
        Catch ex As Exception
            MessageBox.Show("Error al buscar cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCompañias.Click
        Me.pnlBuscarClientes.Visible = True
        Me.txtFiltroCompañias.Select(0, Me.txtFiltroCompañias.Text.Length)
        Me.txtFiltroCompañias.Focus()
    End Sub

    Private Sub txtFiltroCompañias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroCompañias.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Call BuscarCompañia(Me.txtFiltroCompañias.Text.Trim)
            ElseIf e.KeyCode = Keys.Escape Then
                Me.pnlBuscarClientes.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtaBuscarCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtaBuscarCliente.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim cmd As ADODB.Command = New ADODB.Command
                cmd.ActiveConnection = Cnn1
                cmd.CommandText = "Select * From Compañias Where Nombre_Compañia = '" & Me.dtaBuscarCliente.Item(1, Me.dtaBuscarCliente.CurrentRow.Index).Value & "'"

                With cmd.Execute.EOF = False
                    Me.txtClaveCompañia.Text = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper
                    Me.txtCompañia.Text = cmd.Execute.Fields!Nombre_Compañia.Value
                    Me.txtRutaFormato.Text = cmd.Execute.Fields!Formato.Value
                End With
                Me.pnlBuscarClientes.Visible = False
            ElseIf e.KeyCode = Keys.Escape Then
                Me.pnlBuscarClientes.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de la compañía: " & ex.Message)
        End Try
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrarVales.Click
        Try
            Me.grpCompañia.Enabled = False

            Me.dteFechaInicial.Enabled = False
            Me.dteFechaFinal.Enabled = False
            Me.txtFolioInicial.ReadOnly = True
            Me.txtFolioFinal.ReadOnly = True

            Me.txtMontoEspecifico.ReadOnly = True

            Me.mnuRegistrarVales.Enabled = False
            Me.mnuEliminaVales.Enabled = True
            Me.mnuNuevosVales.Enabled = True

            Me.txtClaveCompañia.Focus()

            Call Me.RegistrarVales()
        Catch ex As Exception
            MessageBox.Show("Error al registrar vales: " & ex.Message)
        End Try
    End Sub

    Private Sub RegistrarVales()
        Try
            Dim rstConsulta As ADODB.Recordset = New ADODB.Recordset
            Dim rstFolios As ADODB.Recordset = New ADODB.Recordset
            Dim FechaInicialX As Date = CDate(Me.dteFechaInicial.Value).ToString("dd/MM/yyyy")
            Dim FechaFinalX As Date = CDate(Me.dteFechaFinal.Value).ToString("dd/MM/yyyy")

            If Me.txtClaveCompañia.Text.Trim.Length <= 0 Then MessageBox.Show("Seleccione la compañía y cargue todos los datos faltantes", "Alerta de sistema") : Exit Sub
            If Me.txtFolioInicial.Text.Trim.Length = 0 Or Me.txtFolioFinal.Text.Trim.Length = 0 Then MessageBox.Show("Faltan datos de consecutividad", "Alerta de sistema") : Exit Sub
            If Me.dteFechaInicial.Text.Trim.Length = 0 Or Me.dteFechaFinal.Text.Trim.Length = 0 Then MessageBox.Show("Faltan datos de fechas", "Alerta de sistema") : Exit Sub
            If Val(Me.txtMontoEspecifico.Text) = 0 Then MessageBox.Show("Faltan el monto para los vales", "Alerta de sistema") : Exit Sub
            With rstConsulta
                If .State = 1 Then .Close()
                .Open("Select * from Altas_Vales where Status = 'AC' and Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "'", Cnn1, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    If Val(.Fields!Folio_Inicial.Value) = Val(Me.txtFolioInicial.Text) And Val(.Fields!Monto.Value) = Val(Me.txtMontoEspecifico.Text) Then
                        MessageBox.Show("El tiraje ya está registrado no se puede procesar")
                        Exit Sub
                    End If
                    .MoveNext()
                Loop
                'Alta en cabecero de vales  
                .AddNew()
                .Fields!Fecha_Registro.Value = Date.Now
                .Fields!Fecha_Autorizacion.Value = Date.Now
                .Fields!Fecha_Inicial.Value = FechaInicialX
                .Fields!Fecha_Final.Value = FechaFinalX
                .Fields!Clave_Compañia.Value = Me.txtClaveCompañia.Text.Trim.ToUpper
                .Fields!Compañia.Value = Me.txtCompañia.Text.Trim.ToUpper
                .Fields!Folio_Inicial.Value = Val(Me.txtFolioInicial.Text)
                .Fields!Folio_Final.Value = Val(Me.txtFolioFinal.Text)
                .Fields!Status.Value = "AC"
                .Fields!Monto.Value = Val(Me.txtMontoEspecifico.Text)
                .Fields!Monto_Letra.Value = Me.txtMontoEnLetra.Text.Trim.ToUpper
                .Update()
            End With
            With rstFolios
                'Registro en tabla de seriales independientes con status individual
                'Esta tabla es la que hay que actualizar en sucursales y recuperar datos de vales
                'en corte de tiendas 
                Dim a As Integer
                If .State = 1 Then .Close()
                .Open("Select * from Seriales", Cnn1, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
                For a = Val(Me.txtFolioInicial.Text) To Val(Me.txtFolioFinal.Text)
                    .AddNew()
                    .Fields!Fecha_Activacion.Value = Date.Now
                    .Fields!Fecha_Inicial.Value = FechaInicialX
                    .Fields!Fecha_Final.Value = FechaFinalX
                    .Fields!Clave_Compañia.Value = Me.txtClaveCompañia.Text.Trim.ToUpper
                    .Fields!Serial.Value = Val(a)
                    .Fields!Monto.Value = Val(Me.txtMontoEspecifico.Text)
                    .Fields!Status.Value = "PE"
                    .Update()
                Next a
            End With
        Catch ex As Exception
            MessageBox.Show("Error al registrar vales en sistema: " & ex.Message)
        End Try
    End Sub

    Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
        Me.txtBuscador.Select(0, Me.txtBuscador.Text.Length)
        Me.txtBuscador.Focus()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        Call Limpiar_Todo()
    End Sub

    Private Sub frmAdministradorVales_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        My.Forms.Main.Show()
        Me.Close()
    End Sub

    Private Sub dtaBuscarVales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtaBuscarVales.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Call Me.CargarTiraje(Me.dtaBuscarVales.Item(0, Me.dtaBuscarVales.CurrentRow.Index).Value, Me.dtaBuscarVales.Item(4, Me.dtaBuscarVales.CurrentRow.Index).Value, Me.dtaBuscarVales.Item(5, Me.dtaBuscarVales.CurrentRow.Index).Value)
            ElseIf e.KeyCode = Keys.Escape Then
                Me.pnlBuscarCorridas.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarTiraje(ByVal ClaveCompañia As String, ByVal FolioInicio As Integer, ByVal FolioFin As Integer)
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            If Cnn1.State = 0 Then Cnn1.Open()

            cmd.CommandText = "Select * From Altas_Vales Where (Clave_Compañia = '" & ClaveCompañia.Trim.ToUpper & "') AND (Folio_Inicial = " & FolioInicio & ") AND (Folio_Final = " & FolioFin & ") "

            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            rst1 = cmd.Execute
            With rst1
                Do While Not .EOF = True
                    Me.txtClaveCompañia.Text = .Fields!Clave_Compañia.Value.ToString.Trim.ToUpper
                    Me.txtCompañia.Text = .Fields!Compañia.Value.ToString.Trim.ToUpper
                    Me.dteFechaInicial.Value = .Fields!Fecha_Inicial.Value.ToString.Trim.ToUpper
                    Me.dteFechaFinal.Value = .Fields!Fecha_Final.Value.ToString.Trim.ToUpper
                    Me.txtFolioInicial.Text = Val(.Fields!Folio_Inicial.Value)
                    Me.txtFolioFinal.Text = Val(.Fields!Folio_Final.Value)
                    Me.txtStatusVales.Text = .Fields!Status.Value
                    Me.txtMontoEspecifico.Text = CDbl(.Fields!Monto.Value).ToString("0.00")
                    Me.txtMontoEnLetra.Text = CantidadEnLetra(.Fields!Monto.Value)
                    Me.pnlBuscarCorridas.Visible = False
                    Me.mnuEliminaVales.Enabled = True
                    .MoveNext()
                Loop
                .Close()
            End With
            cmd.CommandText = "Select Formato from Compañias Where Nombre_Compañia = '" & Me.txtCompañia.Text.Trim.ToUpper & "'"
            While Not cmd.Execute.EOF = True
                Me.txtRutaFormato.Text = cmd.Execute.Fields!Formato.Value
                Exit While
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar la corrida de la compañia seleccionada: " & ex.Message)
        End Try
    End Sub

    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Try
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            Dim cmd As ADODB.Command = New ADODB.Command
            Dim cmd1 As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd1.ActiveConnection = Cnn1

            'Libera registros pendientes de impresión
            Dim consulta As String = "Update Seriales Set Status = 'PE' Where Status = 'IM' "
            cmd.CommandText = consulta
            cmd.Execute()

            'Prepara los vales para su impresión sin tocar los vales ya concluidos y cancelados
            cmd.CommandText = "UPDATE Seriales Set Status = 'IM' where (Status <> 'TR' AND Status <> 'CA') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
            cmd.Execute()

            'rutina de encriptacion para el código de barras del vale
            cmd.CommandText = "Select * From Seriales where (Status = 'IM') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
            rst1 = cmd.Execute
            With rst1
                Do While Not .EOF = True
                    Dim CodigoX As String = Convertir_Dato(.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & Val(.Fields!Serial.Value))
                    cmd1.CommandText = "UPDATE Seriales Set CodigoEncriptado = '*" & CodigoX.ToString.Trim & "*' Where (Serial = " & Val(.Fields!Serial.Value) & ") AND (Status <> 'TR' AND Status <> 'CA') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
                    cmd1.Execute()
                    .MoveNext()
                Loop
                .Close()
            End With

            'Rutina de presentación de los vales en pantalla
            consulta = "SELECT * From VistaImpresionVales "
            consulta += " Where "
            consulta += " Status = 'IM' "

            Dim rsReportes As ADODB.Recordset = New ADODB.Recordset
            Me.reportDocument1.Load(Me.txtRutaFormato.Text.Trim)
            If rsReportes.State = 0 Then rsReportes.Open(consulta, Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockBatchOptimistic)
            Me.reportDocument1.SetDataSource(rsReportes)
            Me.CrystalReportViewer1.ReportSource = Me.reportDocument1
            Me.CrystalReportViewer1.Show()
        Catch ex As Exception
            MessageBox.Show("Error al cargar informe en vista previa: " & ex.Message)
        End Try
    End Sub

    Private Sub dtaBuscarVales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaBuscarVales.CellContentClick

    End Sub

    Private Sub ImprimirTirajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirTirajeToolStripMenuItem.Click
        Try
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            Dim cmd As ADODB.Command = New ADODB.Command
            Dim cmd1 As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd1.ActiveConnection = Cnn1

            'Libera registros pendientes de impresión
            Dim consulta As String = "Update Seriales Set Status = 'PE' Where Status = 'IM' "
            cmd.CommandText = consulta
            cmd.Execute()

            'Prepara los vales para su impresión sin tocar los vales ya concluidos y cancelados
            cmd.CommandText = "UPDATE Seriales Set Status = 'IM' where (Status <> 'TR' AND Status <> 'CA') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
            cmd.Execute()

            'rutina de encriptacion para el código de barras del vale
            cmd.CommandText = "Select * From Seriales where (Status = 'IM') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
            rst1 = cmd.Execute
            With rst1
                Do While Not .EOF = True
                    Dim CodigoX As String = Convertir_Dato(.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & Val(.Fields!Serial.Value))
                    cmd1.CommandText = "UPDATE Seriales Set CodigoEncriptado = '*" & CodigoX.ToString.Trim & "*' Where (Serial = " & Val(.Fields!Serial.Value) & ") AND (Status <> 'TR' AND Status <> 'CA') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "') AND (Monto = " & Val(Me.txtMontoEspecifico.Text) & ") AND (Fecha_Activacion >= CONVERT(DATETIME, '" & Me.dteFechaInicial.Value.ToString("yyyy-MM-dd") & " 00:00:00', 102) AND Fecha_Activacion <= CONVERT(DATETIME, '" & Me.dteFechaFinal.Value.ToString("yyyy-MM-dd") & " 23:59:59', 102))"
                    cmd1.Execute()
                    .MoveNext()
                Loop
                .Close()
            End With

            'Rutina de presentación de los vales en pantalla
            consulta = "SELECT * From VistaImpresionVales "
            consulta += " Where "
            consulta += " Status = 'IM' "

            Dim rsReportes As ADODB.Recordset = New ADODB.Recordset
            My.Forms.frmVistaReportes.reportDocument1.Load(Me.txtRutaFormato.Text.Trim)
            If rsReportes.State = 0 Then rsReportes.Open(consulta, Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockBatchOptimistic)
            My.Forms.frmVistaReportes.reportDocument1.SetDataSource(rsReportes)
            My.Forms.frmVistaReportes.CrystalReportViewer1.ReportSource = My.Forms.frmVistaReportes.reportDocument1
            My.Forms.frmVistaReportes.CrystalReportViewer1.Show()
            My.Forms.frmVistaReportes.Show()
        Catch ex As Exception
            MessageBox.Show("Error al imprimir tiraje: " & ex.Message)
        End Try
    End Sub

    Private Sub Imprimir_Vales()
        Try
        Catch ex As Exception
            MessageBox.Show("Error al imprimir vales: " & ex.Message)
        End Try
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txtBuscador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscador.Click

    End Sub

    Private Sub dtaBuscarCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaBuscarCliente.CellContentClick

    End Sub
End Class