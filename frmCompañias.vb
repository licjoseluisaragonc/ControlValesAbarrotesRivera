Imports System.IO

Public Class frmCompañias

    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevo.Click
        Call Me.LimpiarTodo()

        Me.cmbSerie.Text = "A"
        Me.txtClaveCompañia.Text = "..."
        Me.txtNombreCompañia.Text = " "
        Me.txtRFC.Text = " "
        Me.txtDireccion.Text = " "
        Me.txtStatus.Text = "AC"
        Me.txtFormato.Text = " "

        Me.cmbSerie.Enabled = True
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtNombreCompañia.ReadOnly = False
        Me.txtRFC.ReadOnly = False
        Me.txtDireccion.ReadOnly = False
        Me.txtFormato.ReadOnly = False

        Me.imgLogo.Image = Nothing

        Me.mnuNuevo.Enabled = False
        Me.mnuGuardar.Enabled = True
        Me.mnuModificar.Enabled = False
        Me.mnuEliminar.Enabled = False
        Me.mnuDeshacer.Enabled = True
        Me.mnuBloquear.Enabled = False
        Me.mnuDesbloquear.Enabled = False
        Me.mnuCargarFormato.Enabled = False
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGuardar.Click
        Try
            Dim NombreExistente As Boolean = False
            Dim cmd As ADODB.Command = New ADODB.Command
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            cmd.ActiveConnection = Cnn1

            If Cnn1.State = 0 Then Cnn1.Open()

            cmd.CommandText = "Select * From Compañias Where (Nombre_Compañia LIKE '%" & Me.txtNombreCompañia.Text.Trim & "%')"
            rst1 = cmd.Execute

            While Not rst1.EOF = True
                NombreExistente = True
                rst1.MoveNext()
            End While

            If NombreExistente = True Then
                MessageBox.Show("La compañia ya existe intente otro nombre")
            Else
                Me.txtClaveCompañia.Text = Me.cmbSerie.Text.Trim.ToUpper & NuevoFolioSerieCompañia(Me.cmbSerie.Text.Trim)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en validación de datos para registro: " & ex.Message)
        End Try

        Me.cmbSerie.Enabled = False
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtNombreCompañia.ReadOnly = True
        Me.txtRFC.ReadOnly = True
        Me.txtDireccion.ReadOnly = True
        Me.txtFormato.ReadOnly = True

        Me.imgLogo.Enabled = False

        Me.mnuNuevo.Enabled = True
        Me.mnuGuardar.Enabled = False
        Me.mnuModificar.Enabled = True
        Me.mnuEliminar.Enabled = False
        Me.mnuDeshacer.Enabled = True
        Me.mnuBloquear.Enabled = False
        Me.mnuDesbloquear.Enabled = False
        Me.mnuCargarFormato.Enabled = False

        Me.RegistrarCompañia()
    End Sub

    Private Sub RegistrarCompañia()
        Try
            Dim SIEsta As Boolean = False
            If Me.txtClaveCompañia.Text.Trim.Length <= 0 Then MsgBox("Tiene que asignar un nombre clave a compañía") : Exit Sub
            If Me.txtNombreCompañia.Text.Trim.Length <= 0 Then MsgBox("No ha especificado el nombre de la compañía") : Exit Sub
            If Me.txtDireccion.Text.Trim.Length <= 0 Then MsgBox("Tiene que especificar la dirección") : Exit Sub

            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            With rst1
                If .State = 1 Then .Close()
                .Open("Select * from Compañias", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    If .Fields!Serie_Compañia.Value.ToString.Trim.ToUpper = Me.cmbSerie.Text.Trim.ToUpper And .Fields!Clave_Compañia.Value.ToString.Trim.ToUpper = Me.txtClaveCompañia.Text.Trim.ToUpper Then
                        SIEsta = True
                    End If
                    .MoveNext()
                Loop

                If SIEsta = True Then
                    Dim cmd As ADODB.Command = New ADODB.Command
                    cmd.ActiveConnection = Cnn1
                    cmd.CommandText = "Update Compañias set Nombre_Compañia = '" & Me.txtNombreCompañia.Text.Trim.ToUpper & "', Direccion = '" & Me.txtDireccion.Text.Trim.ToUpper & "', RFC = '" & Me.txtRFC.Text.Trim.ToUpper & "', Formato = '" & Me.txtFormato.Text.Trim.ToUpper & "' Where (Serie_Compañia = '" & Me.cmbSerie.Text.Trim.ToUpper & "') AND (Clave_Compañia = '" & Me.txtClaveCompañia.Text.Trim.ToUpper & "')"
                    cmd.Execute()
                Else
                    .AddNew()
                    .Fields!Fecha_Alta.Value = Date.Now
                    .Fields!Serie_Compañia.Value = Me.cmbSerie.Text.Trim.ToUpper
                    .Fields!Clave_Compañia.Value = Me.txtClaveCompañia.Text.Trim.ToUpper
                    .Fields!Nombre_Compañia.Value = Me.txtNombreCompañia.Text.Trim.ToUpper
                    .Fields!Direccion.Value = Me.txtDireccion.Text.Trim.ToUpper
                    .Fields!RFC.Value = Me.txtRFC.Text.Trim.ToUpper
                    .Fields!Formato.Value = Me.txtFormato.Text.Trim
                    .Fields!Status.Value = "AC"
                    .Update()
                End If
            End With
            Call CargarCompañia(Me.cmbSerie.Text.Trim, Me.txtClaveCompañia.Text.Trim)
            Call CargarFiltroCompañias("")
        Catch ex As Exception
            MessageBox.Show("Error al registrar datos de compañia: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCompañia(ByVal SerieX As String, ByVal ClaveCompañiaX As String)
        Try
            Dim ByteX As Byte() = Nothing
            Dim rst1 As ADODB.Recordset = New ADODB.Recordset

            With rst1
                If .State = 1 Then .Close()
                .Open("Select * from Compañias Where (Serie_Compañia = '" & SerieX.Trim.ToUpper & "') AND (Clave_Compañia = '" & ClaveCompañiaX.Trim & "')", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    Me.cmbSerie.Text = .Fields!Serie_Compañia.Value
                    Me.txtClaveCompañia.Text = .Fields!Clave_Compañia.Value
                    Me.txtNombreCompañia.Text = .Fields!Nombre_Compañia.Value
                    Me.txtDireccion.Text = .Fields!Direccion.Value
                    Me.txtRFC.Text = .Fields!RFC.Value
                    Me.txtStatus.Text = .Fields!Status.Value
                    Me.txtFormato.Text = .Fields!Formato.Value

                    If .Fields!Logo.ActualSize > 0 Then
                        ByteX = CType(.Fields!Logo.Value, Byte())
                        Dim memorybits As New MemoryStream(ByteX)
                        Dim bitmap As New Bitmap(memorybits, False)
                        Me.imgLogo.Image = bitmap
                    Else
                        Me.imgLogo.Image = Nothing
                    End If

                    .MoveNext()
                Loop
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de compañia: " & ex.Message)
        End Try
    End Sub

    Private Sub frmCompañias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Me.LimpiarTodo()
        Call Me.CargarFiltroCompañias(" ")
    End Sub

    Private Sub LimpiarTodo()
        Me.dtaCompañias.Rows.Clear()

        Me.cmbSerie.Text = " "
        Me.txtClaveCompañia.Text = " "
        Me.txtNombreCompañia.Text = " "
        Me.txtRFC.Text = " "
        Me.txtDireccion.Text = " "
        Me.txtStatus.Text = " "
        Me.txtFormato.Text = " "

        Me.cmbSerie.Enabled = False
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtNombreCompañia.ReadOnly = True
        Me.txtRFC.ReadOnly = True
        Me.txtDireccion.ReadOnly = True
        Me.txtFormato.ReadOnly = True

        Me.imgLogo.Image = Nothing
        Me.imgLogo.Enabled = False

        Me.mnuNuevo.Enabled = True
        Me.mnuGuardar.Enabled = False
        Me.mnuModificar.Enabled = False
        Me.mnuEliminar.Enabled = False
        Me.mnuBloquear.Enabled = False
        Me.mnuDesbloquear.Enabled = False
        Me.mnuCargarFormato.Enabled = False

        Me.dtaCompañias.Rows.Clear()
        Call Me.CargarFiltroCompañias(Me.txtBuscador.Text.Trim)
    End Sub

    Private Sub mnuBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBuscar.Click
        Me.txtBuscador.Select(0, Me.txtBuscador.Text.Length)
        Me.txtBuscador.Focus()
    End Sub

    Private Sub CargarFiltroCompañias(ByVal DatoX As String)
        Try
            Me.dtaCompañias.Rows.Clear()

            If Cnn1.State = 0 Then Cnn1.Open()

            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            With rst1
                If .State = 1 Then .Close()
                .Open("Select * from Compañias Where Nombre_Compañia LIKE '%" & DatoX.Trim & "%'", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    Me.dtaCompañias.Rows.Add()
                    Me.dtaCompañias.Item(0, Me.dtaCompañias.Rows.Count - 1).Value = .Fields!Serie_Compañia.Value
                    Me.dtaCompañias.Item(1, Me.dtaCompañias.Rows.Count - 1).Value = .Fields!Clave_Compañia.Value
                    Me.dtaCompañias.Item(2, Me.dtaCompañias.Rows.Count - 1).Value = .Fields!Nombre_Compañia.Value
                    Me.dtaCompañias.Item(3, Me.dtaCompañias.Rows.Count - 1).Value = .Fields!Status.Value
                    Me.CargarImagen2(.Fields!Serie_Compañia.Value, .Fields!Clave_Compañia.Value)
                    .MoveNext()
                Loop
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar lista de compañías: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarImagen2(ByVal SerieX As String, ByVal ClaveX As String)
        Try
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select * From Compañias Where (Serie_Compañia = '" & SerieX.Trim.ToUpper & "') AND (Clave_Compañia = '" & ClaveX.Trim.ToUpper & "')"

            Dim rst1 As ADODB.Recordset = New ADODB.Recordset
            rst1 = cmd.Execute
            With rst1
                While Not .EOF = True
                    Dim ByteX() As Byte
                    If .Fields!Logo.ActualSize > 0 Then
                        ByteX = CType(.Fields!Logo.Value, Byte())
                        Dim memorybits As New MemoryStream(ByteX)
                        Dim bitmap As New Bitmap(memorybits)
                        Me.dtaCompañias.Item(4, Me.dtaCompañias.Rows.Count - 1).Value = bitmap.GetThumbnailImage(144, 144, Nothing, New IntPtr())
                    End If
                    .MoveNext()
                End While
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar logotipo: " & ex.Message)
        End Try
    End Sub

    Private Sub mnuModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModificar.Click
        Me.cmbSerie.Enabled = False
        Me.txtClaveCompañia.ReadOnly = True
        Me.txtNombreCompañia.ReadOnly = False
        Me.txtRFC.ReadOnly = False
        Me.txtDireccion.ReadOnly = False
        Me.txtFormato.ReadOnly = False

        Me.imgLogo.Enabled = True

        Me.mnuNuevo.Enabled = False
        Me.mnuGuardar.Enabled = True
        Me.mnuModificar.Enabled = False
        Me.mnuEliminar.Enabled = True
        Me.mnuDeshacer.Enabled = True
        Me.mnuBloquear.Enabled = True
        Me.mnuDesbloquear.Enabled = True
        Me.mnuCargarFormato.Enabled = True
    End Sub

    Private Sub mnuEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminar.Click
        Call Me.EliminarRegistro(Me.cmbSerie.Text.Trim, Me.txtClaveCompañia.Text.Trim)
        Call Me.LimpiarTodo()
    End Sub

    Private Sub EliminarRegistro(ByVal Serie As String, ByVal Clave As String)
        Try
            If MessageBox.Show("¿Está seuro de querer eliminar el registro actual?", "Alerta de sistema", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Delete from Compañias Where Serie_Compañia = '" & Serie.Trim.ToUpper & "' AND Clave_Compañia = '" & Clave.Trim.ToUpper & "'"
            cmd.Execute()
            Call LimpiarTodo()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar registro: " & ex.Message)
        End Try
    End Sub

    Private Sub imgLogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles imgLogo.DoubleClick
        Me.CargarImagenArchivo(Me.cmbSerie.Text.Trim.ToUpper, Me.txtClaveCompañia.Text.Trim.ToUpper)
    End Sub

    Private Sub CargarImagenArchivo(ByVal SerieCompañia As String, ByVal ClaveCOmpañia As String)
        Try
            Dim SaveImage As Boolean = False
            Dim curFileName As String = ""
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "All JPEG files|*.jpg|All Bitmap files|*.bmp"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Open a Bitmap File"
            If (openDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                curFileName = openDlg.FileName
                SaveImage = True
            Else
                SaveImage = False
                Exit Sub
            End If
            If SaveImage = True Then
                Dim fsFoto As FileStream
                fsFoto = New FileStream(curFileName, FileMode.Open)
                Dim fiFoto As FileInfo = New FileInfo(curFileName)
                Dim Temp As Long = fiFoto.Length
                Dim lung As Long = Convert.ToInt32(Temp)
                Dim picture(lung) As Byte
                Dim bits As Byte() = Nothing
                fsFoto.Read(picture, 0, lung)
                fsFoto.Close()
                Dim rsFoto As ADODB.Recordset = New ADODB.Recordset
                With rsFoto
                    If .State = 0 Then .Open("Select * From Compañias Where (Serie_Compañia = '" & SerieCompañia.Trim.ToUpper & "') AND (Clave_Compañia = '" & ClaveCOmpañia.Trim.ToUpper & "')", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                    Do While Not .EOF = True
                        .Fields!Logo.Value = picture
                        bits = CType(.Fields!Logo.Value, Byte())
                        .Update()
                        .MoveNext()
                    Loop
                    .Close()
                End With
                Dim memorybits As New MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                Me.imgLogo.Image = bitmap
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar imágen: " & ex.Message, "Alerta de sistema")
        End Try
    End Sub

    Private Sub CargarImagen(ByVal ObjetoX As PictureBox, ByVal SerieCompañia As String, ByVal ClaveCompañia As String)
        Try
            Dim SiEsta As Boolean = False
            Dim bits As Byte() = Nothing
            Dim rsFoto As ADODB.Recordset = New ADODB.Recordset
            With rsFoto
                If .State = 0 Then .Open("Select * From Compañias Where (Serie_Compañia = '" & SerieCompañia.Trim.ToUpper & "') AND (Clave_Compañia = '" & ClaveCompañia.Trim.ToUpper & "')", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    SiEsta = True
                    bits = CType(.Fields!Logo.Value, Byte())
                    .Update()
                    .MoveNext()
                Loop
                .Close()
            End With
            If SiEsta = True Then
                Dim memorybits As New MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                ObjetoX.Image = bitmap
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar imágen almacenada: " & ex.Message, "Alerta de sistema")
        End Try
    End Sub

    Private Function NuevoFolioSerieCompañia(ByVal SerieX As String) As String
        NuevoFolioSerieCompañia = Nothing
        Try
            Dim Cargado As Boolean = False
            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1

            Dim rstFolio As ADODB.Recordset = New ADODB.Recordset
            With rstFolio
                If .State = 0 Then .Open("Select * From Parametros Where (Parametro = 'FOLIO SERIE " & SerieX.Trim.ToUpper & "')", Cnn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                Do While Not .EOF = True
                    Dim Folio As Integer = Val(.Fields!Valor.Value)
                    NuevoFolioSerieCompañia &= CDbl(Folio)
                    .Fields!Valor.Value = Val(.Fields!Valor.Value) + 1
                    Cargado = True
                    .Update()
                    .MoveNext()
                Loop
                If Cargado = False Then
                    .AddNew()
                    .Fields!Parametro.Value = "FOLIO SERIE " & SerieX.Trim.ToUpper
                    .Fields!Valor.Value = 2
                    NuevoFolioSerieCompañia = "1"
                    .Update()
                End If
                .Close()
            End With
        Catch ex As Exception
            MessageBox.Show("Error al cargar folio de la serie: " & ex.Message)
        End Try
    End Function

    Private Function ClaveCompañia(ByVal NombreCompañia As String) As String
        ClaveCompañia = " "
        Try
            If Cnn1.State = 0 Then Cnn1.Open()

            Dim cmd As ADODB.Command = New ADODB.Command
            cmd.ActiveConnection = Cnn1
            cmd.CommandText = "Select * From Compañias Where (Nombre_Compañia = '" & NombreCompañia.Trim.Trim & "')"
            While Not cmd.Execute.EOF = True
                ClaveCompañia = cmd.Execute.Fields!Clave_Compañia.Value.ToString.Trim.ToUpper
            End While
        Catch ex As Exception
            MessageBox.Show("Error al cargar la clave de la compañía:" & ex.Message)
        End Try
    End Function

    Private Sub mnuCargarFormato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCargarFormato.Click
        Try
            Dim SaveImage As Boolean = False
            Dim curFileName As String = ""
            Dim openDlg As OpenFileDialog = New OpenFileDialog()
            openDlg.Filter = "All Format files|*.rpt"
            Dim filter As String = openDlg.Filter
            openDlg.Title = "Open a Format File"
            If (openDlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK) Then
                curFileName = openDlg.FileName
                Me.txtFormato.Text = curFileName.Trim
            Else
                MessageBox.Show("Proceso cancelado")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar archivo de formato: " & ex.Message)
        End Try
    End Sub

    Private Sub mnuDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeshacer.Click
        Call Me.LimpiarTodo()
    End Sub

    Private Sub mnuBloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBloquear.Click
        Me.txtStatus.Text = "BL"
    End Sub

    Private Sub mnuDesbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDesbloquear.Click
        Me.txtStatus.Text = "AC"
    End Sub

    Private Sub dtaCompañias_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtaCompañias.CellContentClick
        Try
            Call Me.CargarCompañia(Me.dtaCompañias.Item(0, Me.dtaCompañias.CurrentRow.Index).Value, Me.dtaCompañias.Item(1, Me.dtaCompañias.CurrentRow.Index).Value)
            Me.mnuModificar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de la compañia: " & ex.Message)
        End Try
    End Sub

    Private Sub frmCompañias_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        My.Forms.Main.Show()
        Me.Close()
    End Sub
End Class