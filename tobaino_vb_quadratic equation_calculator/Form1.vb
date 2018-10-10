Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unita, unitb, unitc As Integer
        Dim resultx As Integer
        unita = Val(TextBox1.Text)
        unitb = Val(TextBox2.Text)
        unitc = Val(TextBox3.Text)
        resultx = -unitb + unitb ^ 2 - 4 * unita * unitc / 2 * unita
        TextBox4.Text = resultx
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
