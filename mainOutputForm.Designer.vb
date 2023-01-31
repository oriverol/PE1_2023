<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainOutputForm
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
        Me.outputFormPublic = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'outputFormPublic
        '
        Me.outputFormPublic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputFormPublic.ForeColor = System.Drawing.Color.Red
        Me.outputFormPublic.Location = New System.Drawing.Point(59, 51)
        Me.outputFormPublic.Name = "outputFormPublic"
        Me.outputFormPublic.Size = New System.Drawing.Size(339, 164)
        Me.outputFormPublic.TabIndex = 1
        Me.outputFormPublic.Text = ""
        '
        'mainOutputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 281)
        Me.Controls.Add(Me.outputFormPublic)
        Me.Name = "mainOutputForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainInputForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents outputFormPublic As RichTextBox
End Class
