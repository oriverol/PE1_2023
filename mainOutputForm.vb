Public Class mainOutputForm
    Private Sub mainInputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        outputFormPublic.Text = "The last name of the person that just logged in is: " & loginForm.stLname & ", his first name is: " & loginForm.stFname

    End Sub
End Class