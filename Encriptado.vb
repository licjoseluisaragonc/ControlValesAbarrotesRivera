Module Encriptado
    Public Campo(12) As String

    Public Function ExtraerDato(ByVal dato As String) As String
        If dato.Trim.Length <= 0 Then Return ""
        Campo(1) = ""
        Campo(2) = ""
        ExtraerDato = ""
        Try
            ExtraerDato = Nothing
            Dim Valor As String = Traducir_Dato(dato)

            Dim X As Integer = 0
            Dim DatoX As String = Nothing
            Dim SearchWithinThis As String = Nothing
            Dim SearchForThis As String = "-"
            Dim FirstCharacter As Integer = Nothing

            If Valor.Length > 0 Then
                For X = 1 To 2
                    SearchWithinThis = Valor
                    FirstCharacter = SearchWithinThis.IndexOf(SearchForThis)
                    DatoX = Microsoft.VisualBasic.Left(Valor, FirstCharacter)
                    Valor = Microsoft.VisualBasic.Right(Valor, (Microsoft.VisualBasic.Len(Valor) - (FirstCharacter + 1)))

                    Campo(1) = DatoX
                    Campo(2) = Valor
                    Exit For
                Next X
            End If
            ExtraerDato = Campo(1) & "/" & Campo(2)
        Catch ex As Exception
            MessageBox.Show("Error al obtener dato desde lectura: " & ex.Message)
            End
        End Try
    End Function

    Public Function Traducir_Dato(ByVal texto As String) As String
        Traducir_Dato = Nothing
        If texto.Trim.Length = 0 Then Exit Function
        Dim a As Integer = 0
        For a = 2 To Len(texto) Step 2
            Traducir_Dato &= Traducir_Llave(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(texto, a), 2))
        Next
    End Function

    Private Function Traducir_Llave(ByVal dato As Integer) As String
        Traducir_Llave = Nothing
        Select Case dato
            Case 70
                Traducir_Llave = "A"
            Case 71
                Traducir_Llave = "B"
            Case 72
                Traducir_Llave = "C"
            Case 73
                Traducir_Llave = "D"
            Case 74
                Traducir_Llave = "E"
            Case 30
                Traducir_Llave = "F"
            Case 31
                Traducir_Llave = "G"
            Case 32
                Traducir_Llave = "H"
            Case 33
                Traducir_Llave = "I"
            Case 34
                Traducir_Llave = "J"
            Case 80
                Traducir_Llave = "K"
            Case 81
                Traducir_Llave = "L"
            Case 82
                Traducir_Llave = "M"
            Case 83
                Traducir_Llave = "N"
            Case 84
                Traducir_Llave = "Ñ"
            Case 20
                Traducir_Llave = "O"
            Case 21
                Traducir_Llave = "P"
            Case 22
                Traducir_Llave = "Q"
            Case 23
                Traducir_Llave = "R"
            Case 24
                Traducir_Llave = "S"
            Case 10
                Traducir_Llave = "T"
            Case 11
                Traducir_Llave = "U"
            Case 12
                Traducir_Llave = "V"
            Case 13
                Traducir_Llave = "W"
            Case 14
                Traducir_Llave = "X"
            Case 15
                Traducir_Llave = "Y"
            Case 16
                Traducir_Llave = "Z"
            Case 40
                Traducir_Llave = "1"
            Case 41
                Traducir_Llave = "2"
            Case 42
                Traducir_Llave = "3"
            Case 43
                Traducir_Llave = "4"
            Case 44
                Traducir_Llave = "5"
            Case 45
                Traducir_Llave = "6"
            Case 46
                Traducir_Llave = "7"
            Case 47
                Traducir_Llave = "8"
            Case 48
                Traducir_Llave = "9"
            Case 49
                Traducir_Llave = "0"
            Case 50
                Traducir_Llave = "."
            Case 51
                Traducir_Llave = ","
            Case 52
                Traducir_Llave = "-"
            Case 53
                Traducir_Llave = "_"
            Case 54
                Traducir_Llave = "|"
            Case 55
                Traducir_Llave = ";"
            Case 56
                Traducir_Llave = ":"
            Case 57
                Traducir_Llave = "'"
            Case 58
                Traducir_Llave = " "
            Case 59
                Traducir_Llave = "/"
        End Select
    End Function

    Public Function Convertir_Dato(ByVal texto As String) As String
        Convertir_Dato = Nothing
        Dim a As Integer = 0
        For a = 1 To Len(texto)
            Convertir_Dato &= Llave(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(texto, a), 1))
        Next
    End Function

    Private Function Llave(ByVal dato As String)
        Llave = Nothing
        Select Case dato.ToUpper
            Case "A"
                Llave = 70
            Case "B"
                Llave = 71
            Case "C"
                Llave = 72
            Case "D"
                Llave = 73
            Case "E"
                Llave = 74
            Case "F"
                Llave = 30
            Case "G"
                Llave = 31
            Case "H"
                Llave = 32
            Case "I"
                Llave = 33
            Case "J"
                Llave = 34
            Case "K"
                Llave = 80
            Case "L"
                Llave = 81
            Case "M"
                Llave = 82
            Case "N"
                Llave = 83
            Case "Ñ"
                Llave = 84
            Case "O"
                Llave = 20
            Case "P"
                Llave = 21
            Case "Q"
                Llave = 22
            Case "R"
                Llave = 23
            Case "S"
                Llave = 24
            Case "T"
                Llave = 10
            Case "U"
                Llave = 11
            Case "V"
                Llave = 12
            Case "W"
                Llave = 13
            Case "X"
                Llave = 14
            Case "Y"
                Llave = 15
            Case "Z"
                Llave = 16
            Case "1"
                Llave = 40
            Case "2"
                Llave = 41
            Case "3"
                Llave = 42
            Case "4"
                Llave = 43
            Case "5"
                Llave = 44
            Case "6"
                Llave = 45
            Case "7"
                Llave = 46
            Case "8"
                Llave = 47
            Case "9"
                Llave = 48
            Case "0"
                Llave = 49
            Case "."
                Llave = 50
            Case ","
                Llave = 51
            Case "-"
                Llave = 52
            Case "_"
                Llave = 53
            Case "|"
                Llave = 54
            Case ";"
                Llave = 55
            Case ":"
                Llave = 56
            Case "'"
                Llave = 57
            Case " "
                Llave = 58
            Case "/"
                Llave = 59
        End Select
    End Function
End Module
