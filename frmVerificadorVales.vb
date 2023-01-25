Public Class frmVerificadorVales
    Private Sub frmVerificadorVales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\logo.jpg") = True Then
            Me.BackgroundImage = Bitmap.FromFile(My.Application.Info.DirectoryPath & "\logo.jpg", True)
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Me.BackgroundImage = Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Publicidad.jpg", True)
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
        Call Me.LimpiarTodo()
        Call CargarSeries()
    End Sub

    Private Sub LimpiarTodo()
        Me.txtCompañia.Text = ""
        Me.dtaVales.Rows.Clear()
        Me.txtCodigoBarras.Focus()
    End Sub

    Private Sub CargarSeries()
        Try
            Me.cmbSerie.Items.Clear()
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select Clave_Compañia From Seriales GROUP BY Clave_Compañia ORDER BY Clave_Compañia ASC"
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            rst1 = cmd.Execute
            With rst1
                While Not .EOF = True
                    Me.cmbSerie.Items.Add(.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper)
                    .MoveNext()
                End While
                .Close()
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar series: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCodigoBarras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoBarras.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Call Me.LimpiarTodo()
                Call Me.CargarDetalles()
            ElseIf e.KeyCode = Keys.Escape Then
                Call Me.LimpiarTodo()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al validar vale: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDetalles()
        Try
            Call Me.LimpiarTodo()
            Dim DatoX As String = ExtraerDato(Me.txtCodigoBarras.Text.Trim)
            Me.cmbSerie.Text = Campo(1)
            Me.txtFolio.Text = Campo(2)

            If Me.txtFolio.Text.Length <= 0 Then Me.txtFolio.Text = 0
            If Me.txtMonto.Text.Length <= 0 Then Me.txtMonto.Text = 0
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select * From Compañias Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "')"
            While cmd.Execute.EOF = False
                Me.txtCompañia.Text = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & cmd.Execute.Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                Call CargarCorridas(Me.cmbSerie.Text.Trim.ToUpper, CDbl(Me.txtMonto.Text), CDbl(Me.txtFolio.Text))
                Exit Sub
            End While
        Catch ex As Exception
            MessageBox.Show("Error al validar detalles de vale: " & ex.Message)
        End Try
    End Sub


    Private Function NombreCompañia(ByVal clave As String) As String
        NombreCompañia = ""
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            If Cnn1.State = 0 Then Cnn1.Open()

            cmd.CommandText = "Select Nombre_Compañia from Compañias Where Clave_Compañia = '" & clave.Trim & "'"
            While Not cmd.Execute.EOF = True
                NombreCompañia = cmd.Execute.Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                Exit While
            End While
        Catch ex As Exception
            MessageBox.Show("Error al buscar nombre de la compañia: " & ex.Message)
        End Try
    End Function

    Private Sub cmbSerie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSerie.SelectedIndexChanged
        Try
            If Me.txtFolio.Text.Length <= 0 Then Me.txtFolio.Text = 0
            If Me.txtMonto.Text.Length <= 0 Then Me.txtMonto.Text = 0
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select * From Compañias Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "')"
            While cmd.Execute.EOF = False
                Me.txtCompañia.Text = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & cmd.Execute.Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                Call CargarCorridas(Me.cmbSerie.Text.Trim.ToUpper, CDbl(Me.txtMonto.Text), CDbl(Me.txtFolio.Text))
                Exit Sub
            End While
        Catch ex As Exception
            MessageBox.Show("Error al validar compañia: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCorridas(ByVal SerieX As String, ByVal MontoX As Double, ByVal FolioX As Integer)
        Try
            If Not SerieX.Length >= 0 Then MessageBox.Show("Tiene que especificar la serie para poder filtrar las corridas") : Exit Sub
            Me.dtaVales.Rows.Clear()
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            Dim Consulta As String = ""
            If SerieX.Length > 0 Then Consulta = "Select * From Seriales Where (Clave_Compañia = '" & SerieX.Trim.ToUpper & "') "
            If MontoX > 0 Then Consulta &= " AND (Monto = " & CDbl(MontoX) & ")"
            If FolioX > 0 Then Consulta &= " AND (Serial = " & Val(FolioX) & ")"
            Dim RST1 As ADODB.Recordset = New ADODB.Recordset
            cmd.CommandText = Consulta
            RST1 = cmd.Execute
            With RST1
                Do While Not .EOF = True
                    Me.dtaVales.Rows.Add()
                    Me.dtaVales.Item(0, Me.dtaVales.Rows.Count - 1).Value = .Fields!Fecha_Activacion.Value
                    Me.dtaVales.Item(1, Me.dtaVales.Rows.Count - 1).Value = .Fields!Fecha_Inicial.Value
                    Me.dtaVales.Item(2, Me.dtaVales.Rows.Count - 1).Value = .Fields!Fecha_Final.Value
                    Me.dtaVales.Item(3, Me.dtaVales.Rows.Count - 1).Value = .Fields!Serial.Value
                    Me.dtaVales.Item(4, Me.dtaVales.Rows.Count - 1).Value = .Fields!Monto.Value
                    Me.dtaVales.Item(5, Me.dtaVales.Rows.Count - 1).Value = .Fields!Status.Value
                    .MoveNext()
                Loop
                .Close()
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar corridas: " & ex.Message)
        End Try
    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtFolio.Text.Length <= 0 Then Me.txtFolio.Text = 0
                If Me.txtMonto.Text.Length <= 0 Then Me.txtMonto.Text = 0
                Dim cmd As ADODB.Command = New ADODB.Command
                cmd.ActiveConnection = Cnn1
                cmd.CommandText = "Select * From Compañias Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "')"
                While cmd.Execute.EOF = False
                    Me.txtCompañia.Text = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & cmd.Execute.Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                    Call CargarCorridas(Me.cmbSerie.Text.Trim.ToUpper, CDbl(Me.txtMonto.Text), CDbl(Me.txtFolio.Text))
                    Exit Sub
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error al validar monto: " & ex.Message)
        End Try
    End Sub

    Private Sub txtFolio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFolio.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Me.txtFolio.Text.Length <= 0 Then Me.txtFolio.Text = 0
                If Me.txtMonto.Text.Length <= 0 Then Me.txtMonto.Text = 0
                Dim cmd As ADODB.Command = New ADODB.Command
                cmd.ActiveConnection = Cnn1
                cmd.CommandText = "Select * From Compañias Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "')"
                While cmd.Execute.EOF = False
                    Me.txtCompañia.Text = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper & "-" & cmd.Execute.Fields!Nombre_Compañia.Value.ToString.Trim.ToUpper
                    Call CargarCorridas(Me.cmbSerie.Text.Trim.ToUpper, CDbl(Me.txtMonto.Text), CDbl(Me.txtFolio.Text))
                    Exit Sub
                End While
            End If
        Catch ex As Exception
            MessageBox.Show("Error al validar folio: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoBarras.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            If Me.dtaVales.Item(5, Me.dtaVales.CurrentRow.Index).Value.ToString.Trim.ToUpper = "TR" Then MessageBox.Show("Folio terminado imposible cancelarlo ") : Exit Sub
            cmd.CommandText = "Update Seriales Set Status = 'CA' Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "') AND (Serial = " & Val(Me.dtaVales.Item(3, Me.dtaVales.CurrentRow.Index).Value) & ") AND (Monto = " & Val(Me.dtaVales.Item(4, Me.dtaVales.CurrentRow.Index).Value) & ")"
            cmd.Execute()
            Call CargarDetalles()
        Catch ex As Exception
            MessageBox.Show("Error al cancelar serie: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            Dim a As Integer = 0
            For a = 0 To Me.dtaVales.Rows.Count - 1
                If Not Me.dtaVales.Item(5, a).Value.ToString.Trim.ToUpper = "TR" Then
                    cmd.CommandText = "Update Seriales Set Status = 'CA' Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "') AND (Serial = " & Val(Me.dtaVales.Item(3, a).Value) & ") AND (Monto = " & Val(Me.dtaVales.Item(4, a).Value) & ")"
                    cmd.Execute()
                End If
            Next a
            Call CargarDetalles()
        Catch ex As Exception
            MessageBox.Show("Error al cancelar serie: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            If Me.dtaVales.Item(5, Me.dtaVales.CurrentRow.Index).Value.ToString.Trim.ToUpper = "TR" Then MessageBox.Show("Folio terminado imposible cancelarlo ") : Exit Sub
            cmd.CommandText = "Update Seriales Set Status = 'PE' Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "') AND (Serial = " & Val(Me.dtaVales.Item(3, Me.dtaVales.CurrentRow.Index).Value) & ") AND (Monto = " & Val(Me.dtaVales.Item(4, Me.dtaVales.CurrentRow.Index).Value) & ")"
            cmd.Execute()
            Call CargarDetalles()
        Catch ex As Exception
            MessageBox.Show("Error al reactivar serie: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            Dim a As Integer = 0
            For a = 0 To Me.dtaVales.Rows.Count - 1
                If Not Me.dtaVales.Item(5, a).Value.ToString.Trim.ToUpper = "TR" Then
                    cmd.CommandText = "Update Seriales Set Status = 'PE' Where (Clave_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "') AND (Serial = " & Val(Me.dtaVales.Item(3, a).Value) & ") AND (Monto = " & Val(Me.dtaVales.Item(4, a).Value) & ")"
                    cmd.Execute()
                End If
            Next a
            Call CargarDetalles()
        Catch ex As Exception
            MessageBox.Show("Error al cancelar serie: " & ex.Message)
        End Try
    End Sub
End Class