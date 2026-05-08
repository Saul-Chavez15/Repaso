Public Class Form1
    Dim contador = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador = contador + 1
        Cuenta.Text = contador
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contador = 0
        Cuenta.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contador = contador + 2
        Cuenta.Text = contador
    End Sub
End Class
