<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change
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
        Me.old = New System.Windows.Forms.TextBox()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nouveau = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'old
        '
        Me.old.Location = New System.Drawing.Point(126, 33)
        Me.old.Name = "old"
        Me.old.Size = New System.Drawing.Size(327, 20)
        Me.old.TabIndex = 8
        '
        'newpass
        '
        Me.newpass.Location = New System.Drawing.Point(126, 108)
        Me.newpass.Name = "newpass"
        Me.newpass.Size = New System.Drawing.Size(327, 20)
        Me.newpass.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(238, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "changer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "the Old One"
        '
        'nouveau
        '
        Me.nouveau.AutoSize = True
        Me.nouveau.Location = New System.Drawing.Point(35, 111)
        Me.nouveau.Name = "nouveau"
        Me.nouveau.Size = New System.Drawing.Size(76, 13)
        Me.nouveau.TabIndex = 12
        Me.nouveau.Text = "new Password"
        '
        'change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 261)
        Me.Controls.Add(Me.nouveau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.newpass)
        Me.Controls.Add(Me.old)
        Me.Name = "change"
        Me.Text = "change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents old As TextBox
    Friend WithEvents newpass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nouveau As Label
End Class
