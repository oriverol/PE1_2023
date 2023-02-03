<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainInputForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_other = New System.Windows.Forms.RadioButton()
        Me.rb_male = New System.Windows.Forms.RadioButton()
        Me.rb_female = New System.Windows.Forms.RadioButton()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_cs = New System.Windows.Forms.CheckBox()
        Me.cb_ph = New System.Windows.Forms.CheckBox()
        Me.cb_mt = New System.Windows.Forms.CheckBox()
        Me.cb_bi = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(520, 346)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(425, 346)
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
        Me.formattedPublicVariableOutput.Location = New System.Drawing.Point(51, 181)
        Me.formattedPublicVariableOutput.Name = "formattedPublicVariableOutput"
        Me.formattedPublicVariableOutput.ReadOnly = True
        Me.formattedPublicVariableOutput.Size = New System.Drawing.Size(228, 20)
        Me.formattedPublicVariableOutput.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_other)
        Me.GroupBox1.Controls.Add(Me.rb_male)
        Me.GroupBox1.Controls.Add(Me.rb_female)
        Me.GroupBox1.Location = New System.Drawing.Point(330, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 118)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'rb_other
        '
        Me.rb_other.AutoSize = True
        Me.rb_other.Location = New System.Drawing.Point(19, 77)
        Me.rb_other.Name = "rb_other"
        Me.rb_other.Size = New System.Drawing.Size(51, 17)
        Me.rb_other.TabIndex = 2
        Me.rb_other.TabStop = True
        Me.rb_other.Text = "Other"
        Me.rb_other.UseVisualStyleBackColor = True
        '
        'rb_male
        '
        Me.rb_male.AutoSize = True
        Me.rb_male.Location = New System.Drawing.Point(19, 50)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(48, 17)
        Me.rb_male.TabIndex = 1
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "Male"
        Me.rb_male.UseVisualStyleBackColor = True
        '
        'rb_female
        '
        Me.rb_female.AutoSize = True
        Me.rb_female.Location = New System.Drawing.Point(19, 20)
        Me.rb_female.Name = "rb_female"
        Me.rb_female.Size = New System.Drawing.Size(59, 17)
        Me.rb_female.TabIndex = 0
        Me.rb_female.TabStop = True
        Me.rb_female.Text = "Female"
        Me.rb_female.UseVisualStyleBackColor = True
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(336, 188)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(0, 13)
        Me.lblSex.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_bi)
        Me.GroupBox2.Controls.Add(Me.cb_mt)
        Me.GroupBox2.Controls.Add(Me.cb_ph)
        Me.GroupBox2.Controls.Add(Me.cb_cs)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 139)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Majors"
        '
        'cb_cs
        '
        Me.cb_cs.AutoSize = True
        Me.cb_cs.Location = New System.Drawing.Point(9, 29)
        Me.cb_cs.Name = "cb_cs"
        Me.cb_cs.Size = New System.Drawing.Size(113, 17)
        Me.cb_cs.TabIndex = 0
        Me.cb_cs.Text = "Computer Science"
        Me.cb_cs.UseVisualStyleBackColor = True
        '
        'cb_ph
        '
        Me.cb_ph.AutoSize = True
        Me.cb_ph.Location = New System.Drawing.Point(9, 53)
        Me.cb_ph.Name = "cb_ph"
        Me.cb_ph.Size = New System.Drawing.Size(62, 17)
        Me.cb_ph.TabIndex = 1
        Me.cb_ph.Text = "Physics"
        Me.cb_ph.UseVisualStyleBackColor = True
        '
        'cb_mt
        '
        Me.cb_mt.AutoSize = True
        Me.cb_mt.Location = New System.Drawing.Point(9, 77)
        Me.cb_mt.Name = "cb_mt"
        Me.cb_mt.Size = New System.Drawing.Size(86, 17)
        Me.cb_mt.TabIndex = 2
        Me.cb_mt.Text = "Mathematics"
        Me.cb_mt.UseVisualStyleBackColor = True
        '
        'cb_bi
        '
        Me.cb_bi.AutoSize = True
        Me.cb_bi.Location = New System.Drawing.Point(9, 101)
        Me.cb_bi.Name = "cb_bi"
        Me.cb_bi.Size = New System.Drawing.Size(60, 17)
        Me.cb_bi.TabIndex = 3
        Me.cb_bi.Text = "Biology"
        Me.cb_bi.UseVisualStyleBackColor = True
        '
        'mainInputForm
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(607, 381)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.formattedPublicVariableOutput)
        Me.Controls.Add(Me.textControlOutput)
        Me.Controls.Add(Me.publicVariableOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txb_LName)
        Me.Controls.Add(Me.txb_FName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "mainInputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_other As RadioButton
    Friend WithEvents rb_male As RadioButton
    Friend WithEvents rb_female As RadioButton
    Friend WithEvents lblSex As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_bi As CheckBox
    Friend WithEvents cb_mt As CheckBox
    Friend WithEvents cb_ph As CheckBox
    Friend WithEvents cb_cs As CheckBox
End Class
