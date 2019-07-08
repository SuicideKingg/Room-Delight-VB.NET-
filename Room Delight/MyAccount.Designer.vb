<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyAccount))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userID = New System.Windows.Forms.Label()
        Me.accessLevel = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.nameTxtbx = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(133, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(175, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 26)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "User ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(177, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 26)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Access Level:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(177, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(175, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 26)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Name:"
        '
        'userID
        '
        Me.userID.AutoSize = True
        Me.userID.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userID.ForeColor = System.Drawing.Color.White
        Me.userID.Location = New System.Drawing.Point(278, 123)
        Me.userID.Name = "userID"
        Me.userID.Size = New System.Drawing.Size(80, 26)
        Me.userID.TabIndex = 45
        Me.userID.Text = "User ID:"
        '
        'accessLevel
        '
        Me.accessLevel.AutoSize = True
        Me.accessLevel.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessLevel.ForeColor = System.Drawing.Color.White
        Me.accessLevel.Location = New System.Drawing.Point(280, 175)
        Me.accessLevel.Name = "accessLevel"
        Me.accessLevel.Size = New System.Drawing.Size(106, 26)
        Me.accessLevel.TabIndex = 44
        Me.accessLevel.Text = "Access Level:"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userName.ForeColor = System.Drawing.Color.White
        Me.userName.Location = New System.Drawing.Point(280, 149)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(86, 26)
        Me.userName.TabIndex = 43
        Me.userName.Text = "Username:"
        '
        'nameTxtbx
        '
        Me.nameTxtbx.AutoSize = True
        Me.nameTxtbx.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTxtbx.ForeColor = System.Drawing.Color.White
        Me.nameTxtbx.Location = New System.Drawing.Point(278, 97)
        Me.nameTxtbx.Name = "nameTxtbx"
        Me.nameTxtbx.Size = New System.Drawing.Size(58, 26)
        Me.nameTxtbx.TabIndex = 42
        Me.nameTxtbx.Text = "Name:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(24, 225)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 17)
        Me.LinkLabel1.TabIndex = 46
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Password"
        '
        'DelightButton1
        '
        Me.DelightButton1.BackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.BackgroundImage = CType(resources.GetObject("DelightButton1.BackgroundImage"), System.Drawing.Image)
        Me.DelightButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelightButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelightButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.DelightButton1.FlatAppearance.BorderSize = 0
        Me.DelightButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelightButton1.Font = New System.Drawing.Font("Brush Script MT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelightButton1.ForeColor = System.Drawing.Color.White
        Me.DelightButton1.Location = New System.Drawing.Point(150, 268)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(133, 35)
        Me.DelightButton1.TabIndex = 47
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Close"
        Me.DelightButton1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BackgroundImage = Global.Room_Delight.My.Resources.Resources._Single
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(9, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 140)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'MyAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(476, 315)
        Me.Controls.Add(Me.DelightButton1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.userID)
        Me.Controls.Add(Me.accessLevel)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.nameTxtbx)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyAccount"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "My Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents userID As System.Windows.Forms.Label
    Friend WithEvents accessLevel As System.Windows.Forms.Label
    Friend WithEvents userName As System.Windows.Forms.Label
    Friend WithEvents nameTxtbx As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton

End Class
