<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelightDialogBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DelightDialogBox))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.NotifPic = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.NotifPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(439, 20)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.DelightButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(439, 47)
        Me.Panel3.TabIndex = 2
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
        Me.DelightButton1.Location = New System.Drawing.Point(156, 6)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(110, 38)
        Me.DelightButton1.TabIndex = 0
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Okay"
        Me.DelightButton1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.NotifPic)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 118)
        Me.Panel5.TabIndex = 4
        '
        'NotifPic
        '
        Me.NotifPic.BackgroundImage = Global.Room_Delight.My.Resources.Resources.InfoMsgStyle
        Me.NotifPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NotifPic.Location = New System.Drawing.Point(12, 6)
        Me.NotifPic.Name = "NotifPic"
        Me.NotifPic.Size = New System.Drawing.Size(69, 71)
        Me.NotifPic.TabIndex = 1
        Me.NotifPic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message"
        '
        'DelightDialogBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(439, 185)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DelightDialogBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Delight"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.NotifPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton
    Friend WithEvents NotifPic As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
