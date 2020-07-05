Public Class FormAhorcado

    Public laPalabra As String
    Public modoTexto As Boolean ' modo texto: Ingreso de las letras en el TextBox 
    Private errores As Integer = 0

    Private Sub FormAhorcado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblLetrasUsadas.Text = ""
        lblPalabra.Text = ""
        laPalabra = laPalabra.ToUpper ' convierto la cadena a mayusculas

        If modoTexto Then

        Else
            lblTextoLetra.Visible = False
            txtLetra.Visible = False
            btnJugada.Visible = False
        End If

        For i As Integer = 0 To laPalabra.Length - 1 Step 1
            If laPalabra(i) = " " Then
                ' voy completando el String con +=
                lblPalabra.Text += "/"
            Else
                lblPalabra.Text += "-"
            End If
        Next

    End Sub

    Private Function noEsta() As Boolean
        Dim perdio As Boolean = False

        Select Case errores
            Case = 1
                lbl1.Visible = True
            Case = 2
                lbl2.Visible = True
            Case = 3
                lbl3.Visible = True
            Case = 4
                lbl4.Visible = True
            Case = 5
                lbl5.Visible = True
            Case = 6
                ' perdio
                lbl6.Visible = True
                perdio = True
        End Select

        Return perdio

    End Function

    Private Sub acierto(ByVal letra As String)

        Dim texto As Char() = lblPalabra.Text.ToCharArray

        For i As Integer = 0 To texto.Length - 1 Step 1

            If laPalabra(i) = letra And texto(i).ToString = "-" Then
                texto(i) = letra
            End If

        Next

        Dim texMostrar As String

        For i = 0 To texto.Length - 1 Step 1
            texMostrar += texto(i)
        Next

        lblPalabra.Text = texMostrar

    End Sub

    Private Sub FormAhorcado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        ' Esta funcion hara su trabajo solo si NO estamos en el modo de juego "modo texto"
        If Not modoTexto Then

            If lblLetrasUsadas.Text.Contains(e.KeyChar.ToString.ToUpper) Or laPalabra.Contains(e.KeyChar.ToString.ToUpper) Then
                MsgBox("¡Letra repetida!", vbExclamation, "Mensaje")
            Else
                If laPalabra.Contains(e.KeyChar.ToString.ToUpper) Then
                    ' acierto
                    acierto(e.KeyChar.ToString.ToUpper)
                    Dim ganoJuego As Boolean = True
                    For i As Integer = 0 To lblPalabra.Text.Length - 1 Step 1
                        If lblPalabra.Text(i) = "-" Then
                            ganoJuego = False
                            Exit For
                        End If
                    Next
                    If ganoJuego Then
                        MsgBox("Acertaste la palabra oculta: " & laPalabra, vbInformation, "¡Has Ganado!")
                        If MsgBox("¿Desea jugar otra ronda?", vbQuestion + vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
                            Application.Restart()
                        Else
                            Application.Exit()
                        End If
                    End If

                Else
                    ' equivocado
                    lblLetrasUsadas.Text += e.KeyChar.ToString.ToUpper
                    errores += 1
                    If noEsta() Then
                        If MsgBox("Has perdido, ¿Desea jugar otra ronda?", vbQuestion + vbYesNo, "LOOSER!") = MsgBoxResult.Yes Then
                            Application.Restart()
                        Else
                            Application.Exit()
                        End If
                    End If
                End If
            End If

        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        If MsgBox("¿Estas seguro de salir?", vbQuestion + vbYesNo, "Confirmación") = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnJugada_Click(sender As Object, e As EventArgs) Handles btnJugada.Click

        If lblLetrasUsadas.Text.Contains(txtLetra.Text.ToUpper) Or lblPalabra.Text.Contains(txtLetra.Text.ToUpper) Then
            MsgBox("¡Letra repetida!", vbExclamation, "Mensaje")
            txtLetra.Text = ""
        Else
            If laPalabra.Contains(txtLetra.Text.ToUpper) Then
                ' acierto
                acierto(txtLetra.Text.ToUpper)
                Dim ganoJuego As Boolean = True
                For i As Integer = 0 To lblPalabra.Text.Length - 1 Step 1
                    If lblPalabra.Text(i) = "-" Then
                        ganoJuego = False
                        Exit For
                    End If
                Next
                If ganoJuego Then
                    MsgBox("Acertaste la palabra oculta: " & laPalabra, vbInformation, "¡Has Ganado!")
                    If MsgBox("¿Desea jugar otra ronda?", vbQuestion + vbYesNo, "Mensaje") = MsgBoxResult.Yes Then
                        Application.Restart()
                    Else
                        Application.Exit()
                    End If
                End If

            Else
                ' equivocado
                lblLetrasUsadas.Text += txtLetra.Text.ToUpper
                errores += 1
                If noEsta() Then
                    If MsgBox("Has perdido, ¿Desea jugar otra ronda?", vbQuestion + vbYesNo, "LOOSER!") = MsgBoxResult.Yes Then
                        Application.Restart()
                    Else
                        Application.Exit()
                    End If
                End If
            End If
        End If
    End Sub
End Class