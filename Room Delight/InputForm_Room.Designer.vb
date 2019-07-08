<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputForm_Room
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputForm_Room))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.roomNo = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.roomSize = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.roomType = New System.Windows.Forms.ComboBox()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.DelightButton2 = New Room_Delight.DelightButton()
        Me.telNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.roomStory = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.roomNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roomSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roomStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(16, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 26)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Room No."
        '
        'roomNo
        '
        Me.roomNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.roomNo.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!)
        Me.roomNo.ForeColor = System.Drawing.Color.White
        Me.roomNo.Location = New System.Drawing.Point(192, 87)
        Me.roomNo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.roomNo.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.roomNo.Name = "roomNo"
        Me.roomNo.Size = New System.Drawing.Size(216, 25)
        Me.roomNo.TabIndex = 43
        Me.roomNo.ThousandsSeparator = True
        Me.roomNo.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 26)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Room Size"
        '
        'roomSize
        '
        Me.roomSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.roomSize.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!)
        Me.roomSize.ForeColor = System.Drawing.Color.White
        Me.roomSize.Location = New System.Drawing.Point(192, 118)
        Me.roomSize.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.roomSize.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.roomSize.Name = "roomSize"
        Me.roomSize.Size = New System.Drawing.Size(216, 25)
        Me.roomSize.TabIndex = 45
        Me.roomSize.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 26)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Room Type"
        '
        'roomType
        '
        Me.roomType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.roomType.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomType.ForeColor = System.Drawing.Color.White
        Me.roomType.FormattingEnabled = True
        Me.roomType.Items.AddRange(New Object() {"Single", "Couple", "Group"})
        Me.roomType.Location = New System.Drawing.Point(192, 149)
        Me.roomType.Name = "roomType"
        Me.roomType.Size = New System.Drawing.Size(216, 25)
        Me.roomType.TabIndex = 49
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
        Me.DelightButton1.Location = New System.Drawing.Point(298, 247)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(101, 33)
        Me.DelightButton1.TabIndex = 50
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Cancel"
        Me.DelightButton1.UseVisualStyleBackColor = False
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
        Me.DelightButton2.Location = New System.Drawing.Point(191, 247)
        Me.DelightButton2.Name = "DelightButton2"
        Me.DelightButton2.Size = New System.Drawing.Size(101, 33)
        Me.DelightButton2.TabIndex = 51
        Me.DelightButton2.TabStop = False
        Me.DelightButton2.Text = "Save"
        Me.DelightButton2.UseVisualStyleBackColor = False
        '
        'telNo
        '
        Me.telNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.telNo.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telNo.ForeColor = System.Drawing.Color.White
        Me.telNo.Location = New System.Drawing.Point(191, 211)
        Me.telNo.Name = "telNo"
        Me.telNo.Size = New System.Drawing.Size(216, 25)
        Me.telNo.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 26)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Telephone No."
        '
        'roomStory
        '
        Me.roomStory.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.roomStory.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!)
        Me.roomStory.ForeColor = System.Drawing.Color.White
        Me.roomStory.Location = New System.Drawing.Point(192, 180)
        Me.roomStory.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.roomStory.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.roomStory.Name = "roomStory"
        Me.roomStory.Size = New System.Drawing.Size(216, 25)
        Me.roomStory.TabIndex = 56
        Me.roomStory.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 26)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Room Story"
        '
        'InputForm_Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(469, 306)
        Me.Controls.Add(Me.roomStory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telNo)
        Me.Controls.Add(Me.DelightButton2)
        Me.Controls.Add(Me.DelightButton1)
        Me.Controls.Add(Me.roomType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.roomSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.roomNo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputForm_Room"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InputForm_Room"
        CType(Me.roomNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roomSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roomStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents roomNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents roomSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents roomType As System.Windows.Forms.ComboBox
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton
    Friend WithEvents DelightButton2 As Room_Delight.DelightButton
    Friend WithEvents telNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents roomStory As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
