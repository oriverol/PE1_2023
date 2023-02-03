Public Class mainInputForm

    Public stFname As String
    Public stLname As String
    Public stFullName As String
    Public stSex As String
    Public csMajor As String
    Public phMajor As String
    Public mtMajor As String
    Public biMajor As String
    Public noneMajor As String
    Public csCost As Double
    Public phCost As Double
    Public mtCost As Double
    Public biCost As Double


    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        stFname = txb_FName.Text
        stLname = txb_LName.Text
        stFullName = stFname & " " & stLname

        publicVariableOutput.Text = stFullName

        formattedPublicVariableOutput.Text = stLname & ", " & stFname

        textControlOutput.Text = txb_FName.Text & " " & txb_LName.Text

        'code for sex radio buttons
        If rb_female.Checked Then
            stSex = rb_female.Text
        ElseIf rb_male.Checked Then
            stSex = "Male"
        Else
            stSex = rb_other.Text
        End If

        'code for selection of majors
        If cb_cs.Checked Then
            csMajor = "Computer Science"
            csCost = 250
        Else
            csMajor = ""
        End If

        If cb_ph.Checked Then
            phMajor = cb_ph.Text
            phCost = 200
        Else
            phMajor = ""
        End If

        If cb_mt.Checked Then
            mtMajor = "Math"
            mtCost = 150
        Else
            mtMajor = ""
        End If

        If cb_bi.Checked Then
            biMajor = "Biology"
            biCost = 100
        Else
            biMajor = ""
        End If

        mainOutputForm.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()

    End Sub

End Class
