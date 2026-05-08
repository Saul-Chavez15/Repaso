Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num = Num1.Text
        Dim entero = Val(num)
        Dim operacion = entero * 2
        Label1.Text = operacion

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Dim numero1 = Val(Num1.Text)
        Dim numero2 = Val(Num2.Text)
        Dim resultado = numero1 + numero2
        Label3.Text = resultado
    End Sub

    Private Sub btnresta_Click(sender As Object, e As EventArgs) Handles btnresta.Click
        Dim numero1 = Val(Num1.Text)
        Dim numero2 = Val(Num2.Text)
        Dim resultado = numero1 - numero2
        Label3.Text = resultado
    End Sub

    Private Sub btnmultiplicación_Click(sender As Object, e As EventArgs) Handles btnmultiplicación.Click
        Dim numero1 = Val(Num1.Text)
        Dim numero2 = Val(Num2.Text)
        Dim resultado = numero1 * numero2
        Label3.Text = resultado
    End Sub

    Private Sub btndivision_Click(sender As Object, e As EventArgs) Handles btndivision.Click
        If Val(Num2.Text) = 0 Then
            Label3.Text = "Error"
        Else
            Dim numero1 = Val(Num1.Text)
            Dim numero2 = Val(Num2.Text)
            Dim resultado = numero1 / numero2
            Label3.Text = resultado
        End If


    End Sub
End Class
