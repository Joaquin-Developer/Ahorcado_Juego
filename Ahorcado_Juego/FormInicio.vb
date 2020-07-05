Public Class FormInicio

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        cBoxModo.SelectedIndex = 0
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtPalabra.Text.Length = 0 Then
            MsgBox("Debe ingresar la palabra secreta", vbCritical, "Error")
            txtPalabra.Focus()
        Else
            FormAhorcado.laPalabra = txtPalabra.Text
            If cBoxModo.SelectedIndex.Equals(0) Then
                FormAhorcado.modoTexto = True
            Else
                FormAhorcado.modoTexto = False
            End If
            FormAhorcado.Show()  ' muestra el FormAhorcado al usuario
            Me.Hide() ' oculta este Form al usuario
        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Dim info As String = "Modo Texto:" & vbCrLf _
            & "Ingresas las letras en un cuadro de texto" & vbCrLf _
            & "Modo Teclado:" & vbCrLf _
            & "Seleccionas las letras al pulsarlas en el" & vbCrLf _
            & "teclado."
        MsgBox(info, vbInformation, "Acerca de los Modos de Juego:")
    End Sub


End Class
