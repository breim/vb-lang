Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valor1, valor2 As Integer
        valor1 = CInt(TextBox1.Text)
        valor2 = CInt(TextBox2.Text)
        TextBox3.Text = valor1 + valor2
    End Sub

End Class
