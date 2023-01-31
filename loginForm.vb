Public Class loginForm

    Public stFname As String
    Public stLname As String
    Public stFullName As String

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        stFname = txb_FName.Text
        stLname = txb_LName.Text
        stFullName = stFname & " " & stLname

        publicVariableOutput.Text = stFullName

        formattedPublicVariableOutput.Text = stLname & ", " & stFname

        textControlOutput.Text = txb_FName.Text & " " & txb_LName.Text

        mainOutputForm.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()

    End Sub


End Class
