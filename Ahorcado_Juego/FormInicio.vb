Public Class FormInicio

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtPalabra.Text.Length = 0 Then
            MsgBox("Debe ingresar la palabra secreta", vbCritical, "Error")
            txtPalabra.Focus()
        Else
            FormAhorcado.laPalabra = txtPalabra.Text
            FormAhorcado.Show()  ' muestra el FormAhorcado al usuario
            Me.Hide() ' oculta este Form al usuario
        End If
    End Sub

End Class
