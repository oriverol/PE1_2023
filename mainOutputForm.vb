Public Class mainOutputForm
    Private Sub mainOutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stPronoun As String
        Dim stMajors As String
        Dim totalCost As Double

        stMajors = mainInputForm.csMajor & " " & mainInputForm.phMajor & " " & mainInputForm.mtMajor & " " & mainInputForm.biMajor & " " & mainInputForm.noneMajor

        totalCost = mainInputForm.csCost + mainInputForm.phCost + mainInputForm.mtCost + mainInputForm.biCost

        If mainInputForm.stSex = "Male" Then
            stPronoun = "his"
            outputFormPublic.ForeColor = Color.BlueViolet
        Else
            stPronoun = "her"
            outputFormPublic.ForeColor = Color.Pink

        End If

        outputFormPublic.Text = "The last name of the person that just logged in is: " & mainInputForm.stLname & ", " & stPronoun & " first name is: " & mainInputForm.stFname & " and the sex is " & mainInputForm.stSex & stMajors

        outputMajorCost.Text = "$" & totalCost

    End Sub
End Class