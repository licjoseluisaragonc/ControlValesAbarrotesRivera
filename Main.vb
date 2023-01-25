Imports System.IO
Imports System.Text
Imports System.Net.Mail
Imports System.Net

Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\logo.jpg") = True Then
                Me.BackgroundImage = Bitmap.FromFile(My.Application.Info.DirectoryPath & "\logo.jpg", True)
                Me.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Me.BackgroundImage = Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Publicidad.jpg", True)
                Me.BackgroundImageLayout = ImageLayout.Stretch
            End If

            If Cnn1.State = 1 Then Cnn1.Close()
            Cnn1.ConnectionString = "Driver={SQL Server Native Client 10.0};Server=127.0.0.1\SQLEXPRESS;APP=ValesRiera;WSID=sistemas;UID=sistemas;PWD=102xpk4;DATABASE=ValesRivera2018;LANGUAGE=spanish"
            Cnn1.Open()
        Catch ex As Exception
            MessageBox.Show("Error al inicializar programa: " & ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub muGeneradorVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muAdministradorVales.Click
        My.Forms.frmAdministradorVales.MdiParent = Me
        My.Forms.frmAdministradorVales.Show()
    End Sub

    Private Sub mnuCompañias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompañias.Click
        My.Forms.frmCompañias.MdiParent = Me
        My.Forms.frmCompañias.Show()
    End Sub

    Private Sub mnuVerificadorVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVerificadorVales.Click
        My.Forms.frmVerificadorVales.MdiParent = Me
        My.Forms.frmVerificadorVales.Show()
    End Sub

    Public Structure MailX
        Dim MailFrom As String
        Dim Tienda As String
    End Structure

    Private Sub GenerarComunicadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarComunicadosToolStripMenuItem.Click
        Try
            'Rutina de generación del archivo de envio de datos de status de vales a tiendas Vales.csv
            Dim FechaX As Date = DateAdd(DateInterval.Day, -240, Date.Now)
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select * From VistaImpresionVales Where (Fecha_Activacion >= CONVERT(DATETIME,'" & FechaX.ToString("yyyy-MM-dd") & " 00:00:00',102)) "
            If File.Exists(My.Application.Info.DirectoryPath & "\Vales.csv") = True Then File.Delete(My.Application.Info.DirectoryPath & "\Vales.csv")
            rst1 = cmd.Execute
            Using SW As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & "\Vales.csv", False, System.Text.Encoding.Default)
                With rst1
                    While Not .EOF = True
                        SW.WriteLine(.GetString(ADODB.StringFormatEnum.adClipString, -1, ",", vbCrLf, "(NULL)"))
                    End While
                    .Close()
                End With
            End Using
            MessageBox.Show("Creación de la información para tiendas lista y eviada a tiendas")
        Catch ex As Exception
            MessageBox.Show("Error al generar datos de envio para tiendas: " & ex.Message)
        End Try
    End Sub

    Public arlAttachments As System.Net.Mail.MailMessage
    Public Sub SendMail(ByVal CorreoDestino As String, ByVal Mensaje As String)
        If CorreoDestino.ToString.Trim.Length <= 0 Then
            MsgBox("Tiene que especificar datos de correo para el envio de correos por parte del sistema Developers TecnoAra Tienda General")
            Exit Sub
        End If


        Try
        Catch ex As Exception
            MessageBox.Show("Error al cargar adjuntos al correo: " & ex.Message)
        End Try

        Try
        Catch exp As Exception
            MessageBox.Show("problemas para envio de email: " & exp.Message, "Alerta de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ImportarLecturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarLecturasToolStripMenuItem.Click
        Try
            Dim curFileName As String = ""
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "All Excel files|*.csv"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Open a Excel File"
            If (openDlg.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                curFileName = openDlg.FileName
                Call ImportarDatos(curFileName)
                MessageBox.Show("Proceso de importación terminado proceda a revición de datos")
            Else
                MessageBox.Show("Proceso cancelado")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar archivo: " & ex.Message)
        End Try
    End Sub
    Private Sub ImportarDatos(ByVal Dato As String)
        Try
            If Dato.Length <= 0 Then Exit Sub

            Dim X As Integer = 0, a As Integer = 0
            Dim DatoX As String = Nothing
            Dim SearchWithinThis As String = Nothing
            Dim SearchForThis As String = ","
            Dim FirstCharacter As Integer = Nothing
            Dim DatosX As String = ""
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1

            Using Importador As StreamReader = New StreamReader(Dato, System.Text.Encoding.Default)
                While Not Importador.EndOfStream = True
                    DatosX = Importador.ReadLine & ","
                    If DatosX.ToString.Length > 2 Then
                        a += 1
                        For X = 1 To 12
                            SearchWithinThis = DatosX
                            FirstCharacter = SearchWithinThis.IndexOf(SearchForThis)
                            DatoX = Microsoft.VisualBasic.Left(DatosX, FirstCharacter)
                            DatosX = Microsoft.VisualBasic.Right(DatosX, (Microsoft.VisualBasic.Len(DatosX) - (FirstCharacter + 1)))
                            Campo(X) = DatoX
                        Next X
                        'RUTINA DE ACTUALIZACION DE VALORES DE VALES EN BASE DATOS GENERAL
                        cmd.CommandText = "Select * From Seriales Where (Clave_Compañia = '" & Campo(5).ToString.Trim & "') AND (Serial = " & Val(Campo(7)) & ")"
                        Dim Status9 As Boolean = cmd.Execute.EOF
                        If Status9 = False Then
                            cmd.CommandText = "UPDATE Seriales Set Status = 'TR', Tienda = '" & Campo(6) & "' Where (Clave_Compañia = '" & Campo(5).ToString.Trim & "') AND (Serial = " & Campo(7) & ")"
                            cmd.Execute()
                        End If
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al importar datos de entradas: " & ex.Message)
        End Try
    End Sub
End Class
