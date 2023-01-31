<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txb_FName = New System.Windows.Forms.TextBox()
        Me.txb_LName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textControlOutput = New System.Windows.Forms.Label()
        Me.publicVariableOutput = New System.Windows.Forms.Label()
        Me.formattedPublicVariableOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(48, 185)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(214, 185)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txb_FName
        '
        Me.txb_FName.Location = New System.Drawing.Point(48, 58)
        Me.txb_FName.Name = "txb_FName"
        Me.txb_FName.Size = New System.Drawing.Size(241, 20)
        Me.txb_FName.TabIndex = 0
        '
        'txb_LName
        '
        Me.txb_LName.Location = New System.Drawing.Point(48, 138)
        Me.txb_LName.Name = "txb_LName"
        Me.txb_LName.Size = New System.Drawing.Size(241, 20)
        Me.txb_LName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'textControlOutput
        '
        Me.textControlOutput.AutoSize = True
        Me.textControlOutput.Location = New System.Drawing.Point(48, 273)
        Me.textControlOutput.Name = "textControlOutput"
        Me.textControlOutput.Size = New System.Drawing.Size(0, 13)
        Me.textControlOutput.TabIndex = 7
        '
        'publicVariableOutput
        '
        Me.publicVariableOutput.AutoSize = True
        Me.publicVariableOutput.Location = New System.Drawing.Point(48, 231)
        Me.publicVariableOutput.Name = "publicVariableOutput"
        Me.publicVariableOutput.Size = New System.Drawing.Size(0, 13)
        Me.publicVariableOutput.TabIndex = 6
        '
        'formattedPublicVariableOutput
        '
        Me.formattedPublicVariableOutput.Location = New System.Drawing.Point(48, 324)
        Me.formattedPublicVariableOutput.Name = "formattedPublicVariableOutput"
        Me.formattedPublicVariableOutput.ReadOnly = True
        Me.formattedPublicVariableOutput.Size = New System.Drawing.Size(228, 20)
        Me.formattedPublicVariableOutput.TabIndex = 8
        '
        'loginForm
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(330, 356)
        Me.Controls.Add(Me.formattedPublicVariableOutput)
        Me.Controls.Add(Me.textControlOutput)
        Me.Controls.Add(Me.publicVariableOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb_LName)
        Me.Controls.Add(Me.txb_FName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txb_FName As TextBox
    Friend WithEvents txb_LName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textControlOutput As Label
    Friend WithEvents publicVariableOutput As Label
    Friend WithEvents formattedPublicVariableOutput As TextBox
End Class
