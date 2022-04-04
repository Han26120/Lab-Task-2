Public Class Form3


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim strNum1 As Integer = txtNum1.Text
        Dim strNum2 As Integer = txtNum2.Text
        Dim strAdd As Integer = strNum1 + strNum2
        txtOutput.Text = strAdd

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim strNum1 As Integer = txtNum1.Text
        Dim strNum2 As Integer = txtNum2.Text
        Dim strMinus As Integer = strNum1 - strNum2
        txtOutput.Text = strMinus
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim strNum1 As Integer = txtNum1.Text
        Dim strNum2 As Integer = txtNum2.Text
        Dim strMulti As Integer = strNum1 * strNum2
        txtOutput.Text = strMulti
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim strNum1 As Integer = txtNum1.Text
        Dim strNum2 As Integer = txtNum2.Text
        Dim strDivi As Integer = strNum1 / strNum2
        txtOutput.Text = strDivi
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class