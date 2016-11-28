<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingnUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SingnUp))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SignUp = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1014, 458)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Font = New System.Drawing.Font("Mistral", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 38)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Prenom :"
        '
        'SignUp
        '
        Me.SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignUp.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUp.Location = New System.Drawing.Point(716, 380)
        Me.SignUp.Name = "SignUp"
        Me.SignUp.Size = New System.Drawing.Size(145, 65)
        Me.SignUp.TabIndex = 4
        Me.SignUp.Text = "Quiter"
        Me.SignUp.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(507, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 65)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SignUp"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(266, 84)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(327, 20)
        Me.nom.TabIndex = 6
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(266, 227)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(327, 20)
        Me.prenom.TabIndex = 7
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(266, 329)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(327, 20)
        Me.pass.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(628, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(275, 267)
        Me.DataGridView1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(629, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(274, 65)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Liste des Etulisateur"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(300, 377)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 65)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Changer PassWord"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SingnUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 456)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SignUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SingnUp"
        Me.Text = "SingnUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SignUp As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents nom As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
