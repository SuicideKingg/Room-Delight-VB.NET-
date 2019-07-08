<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button_Action = New Room_Delight.DelightButton()
        Me.DelightButton2 = New Room_Delight.DelightButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(328, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 27)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(106, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 25)
        Me.TextBox2.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Directory"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button_Action
        '
        Me.Button_Action.BackColor = System.Drawing.Color.Transparent
        Me.Button_Action.BackgroundImage = CType(resources.GetObject("Button_Action.BackgroundImage"), System.Drawing.Image)
        Me.Button_Action.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_Action.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Action.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button_Action.FlatAppearance.BorderSize = 0
        Me.Button_Action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button_Action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button_Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Action.Font = New System.Drawing.Font("Brush Script MT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Action.ForeColor = System.Drawing.Color.White
        Me.Button_Action.Location = New System.Drawing.Point(74, 172)
        Me.Button_Action.Name = "Button_Action"
        Me.Button_Action.Size = New System.Drawing.Size(134, 37)
        Me.Button_Action.TabIndex = 32
        Me.Button_Action.TabStop = False
        Me.Button_Action.Text = "Default String"
        Me.Button_Action.UseVisualStyleBackColor = False
        '
        'DelightButton2
        '
        Me.DelightButton2.BackColor = System.Drawing.Color.Transparent
        Me.DelightButton2.BackgroundImage = CType(resources.GetObject("DelightButton2.BackgroundImage"), System.Drawing.Image)
        Me.DelightButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelightButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelightButton2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.DelightButton2.FlatAppearance.BorderSize = 0
        Me.DelightButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DelightButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DelightButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelightButton2.Font = New System.Drawing.Font("Brush Script MT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelightButton2.ForeColor = System.Drawing.Color.White
        Me.DelightButton2.Location = New System.Drawing.Point(214, 172)
        Me.DelightButton2.Name = "DelightButton2"
        Me.DelightButton2.Size = New System.Drawing.Size(134, 37)
        Me.DelightButton2.TabIndex = 33
        Me.DelightButton2.TabStop = False
        Me.DelightButton2.Text = "Cancel"
        Me.DelightButton2.UseVisualStyleBackColor = False
        '
        'Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(453, 220)
        Me.Controls.Add(Me.DelightButton2)
        Me.Controls.Add(Me.Button_Action)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Data"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button_Action As Room_Delight.DelightButton
    Friend WithEvents DelightButton2 As Room_Delight.DelightButton

End Class
