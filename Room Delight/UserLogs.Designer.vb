<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogs))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SearchByCustomerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByReservationIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByDisplayNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPaidOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCheckoutOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCureentlyCheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(729, 71)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User's Logs"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DelightButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(9, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(729, 57)
        Me.Panel2.TabIndex = 1
        '
        'DelightButton1
        '
        Me.DelightButton1.BackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.BackgroundImage = CType(resources.GetObject("DelightButton1.BackgroundImage"), System.Drawing.Image)
        Me.DelightButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelightButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelightButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DelightButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.DelightButton1.FlatAppearance.BorderSize = 0
        Me.DelightButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DelightButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelightButton1.Font = New System.Drawing.Font("Brush Script MT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelightButton1.ForeColor = System.Drawing.Color.White
        Me.DelightButton1.Location = New System.Drawing.Point(615, 9)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(105, 39)
        Me.DelightButton1.TabIndex = 0
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Close"
        Me.DelightButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(9, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(729, 231)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Controls.Add(Me.ToolStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(729, 231)
        Me.Panel5.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(729, 205)
        Me.DataGridView1.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(729, 26)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Brush Script MT", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 23)
        Me.ToolStripLabel1.Text = "Search:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.ForeColor = System.Drawing.Color.White
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 26)
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByCustomerNameToolStripMenuItem, Me.SearchByReservationIDToolStripMenuItem, Me.SearchByDisplayNameToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = Global.Room_Delight.My.Resources.Resources.SearchButtonDelight
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 23)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.ToolTipText = "Search Options"
        '
        'SearchByCustomerNameToolStripMenuItem
        '
        Me.SearchByCustomerNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchByCustomerNameToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByCustomerNameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchByCustomerNameToolStripMenuItem.Name = "SearchByCustomerNameToolStripMenuItem"
        Me.SearchByCustomerNameToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SearchByCustomerNameToolStripMenuItem.Text = "Search By User ID"
        '
        'SearchByReservationIDToolStripMenuItem
        '
        Me.SearchByReservationIDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchByReservationIDToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByReservationIDToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchByReservationIDToolStripMenuItem.Name = "SearchByReservationIDToolStripMenuItem"
        Me.SearchByReservationIDToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SearchByReservationIDToolStripMenuItem.Text = "Search By User Name"
        '
        'SearchByDisplayNameToolStripMenuItem
        '
        Me.SearchByDisplayNameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchByDisplayNameToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchByDisplayNameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SearchByDisplayNameToolStripMenuItem.Name = "SearchByDisplayNameToolStripMenuItem"
        Me.SearchByDisplayNameToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.SearchByDisplayNameToolStripMenuItem.Text = "Search By Display Name"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.ViewPaidOnlyToolStripMenuItem, Me.ViewCheckoutOnlyToolStripMenuItem, Me.ViewCureentlyCheckInToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Room_Delight.My.Resources.Resources.ViewButtonDelight
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 23)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.ToolTipText = "View Option"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewAllToolStripMenuItem.Checked = True
        Me.ViewAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewAllToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAllToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'ViewPaidOnlyToolStripMenuItem
        '
        Me.ViewPaidOnlyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewPaidOnlyToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPaidOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewPaidOnlyToolStripMenuItem.Name = "ViewPaidOnlyToolStripMenuItem"
        Me.ViewPaidOnlyToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ViewPaidOnlyToolStripMenuItem.Text = "View All Administrators"
        '
        'ViewCheckoutOnlyToolStripMenuItem
        '
        Me.ViewCheckoutOnlyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewCheckoutOnlyToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCheckoutOnlyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewCheckoutOnlyToolStripMenuItem.Name = "ViewCheckoutOnlyToolStripMenuItem"
        Me.ViewCheckoutOnlyToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ViewCheckoutOnlyToolStripMenuItem.Text = "View All Executives"
        '
        'ViewCureentlyCheckInToolStripMenuItem
        '
        Me.ViewCureentlyCheckInToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewCureentlyCheckInToolStripMenuItem.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCureentlyCheckInToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewCureentlyCheckInToolStripMenuItem.Name = "ViewCureentlyCheckInToolStripMenuItem"
        Me.ViewCureentlyCheckInToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ViewCureentlyCheckInToolStripMenuItem.Text = "View All operators"
        '
        'UserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(747, 377)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserLogs"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.Text = "User's Logs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SearchByCustomerNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchByReservationIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchByDisplayNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPaidOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCheckoutOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCureentlyCheckInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
