Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName As String = txtName.Text
        Dim strAge As String = txtAge.Text
        Dim strOutput As String = "My Name is " + strName & vbCrLf & "My Age is " + strAge

        lblOutput.Text = strOutput
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            BackColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.ShowDialog()
    End Sub
End Class