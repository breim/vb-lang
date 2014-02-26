Public Class Soma


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim av1, av2, av3, media, menor As Single

        av1 = CSng(TextBox1.Text)
        av2 = CSng(TextBox2.Text)
        av3 = CSng(TextBox3.Text)

        If (av2 < av1) Then
            menor = av2
        End If

        If (av3 < av1) Then
            menor = av3
        End If

        media = (av1 + av2 + av3 - menor) / 2

        Label4.Text = "O valor da média é: " & media.ToString

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label4.Text = vbNullString
        TextBox1.Focus()
    End Sub
End Class
