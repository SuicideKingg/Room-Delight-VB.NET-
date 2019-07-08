<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DelightButton3 = New Room_Delight.DelightButton()
        Me.DelightButton2 = New Room_Delight.DelightButton()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomReserved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfReservation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SearchByCustomerNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByReservationIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPaidOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCheckoutOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCureentlyCheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 20, 20, 20)
        Me.Panel1.Size = New System.Drawing.Size(562, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "<Default String>"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(9, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 48)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DelightButton3)
        Me.Panel4.Controls.Add(Me.DelightButton2)
        Me.Panel4.Controls.Add(Me.DelightButton1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(193, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(369, 48)
        Me.Panel4.TabIndex = 2
        '
        'DelightButton3
        '
        Me.DelightButton3.BackColor = System.Drawing.Color.Transparent
        Me.DelightButton3.BackgroundImage = CType(resources.GetObject("DelightButton3.BackgroundImage"), System.Drawing.Image)
        Me.DelightButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DelightButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DelightButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.DelightButton3.FlatAppearance.BorderSize = 0
        Me.DelightButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.DelightButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.DelightButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DelightButton3.Font = New System.Drawing.Font("Brush Script MT", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelightButton3.ForeColor = System.Drawing.Color.White
        Me.DelightButton3.Location = New System.Drawing.Point(114, 3)
        Me.DelightButton3.Name = "DelightButton3"
        Me.DelightButton3.Size = New System.Drawing.Size(105, 41)
        Me.DelightButton3.TabIndex = 2
        Me.DelightButton3.TabStop = False
        Me.DelightButton3.Text = "Review"
        Me.ToolTip1.SetToolTip(Me.DelightButton3, "Review")
        Me.DelightButton3.UseVisualStyleBackColor = False
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
        Me.DelightButton2.Location = New System.Drawing.Point(225, 3)
        Me.DelightButton2.Name = "DelightButton2"
        Me.DelightButton2.Size = New System.Drawing.Size(105, 41)
        Me.DelightButton2.TabIndex = 1
        Me.DelightButton2.TabStop = False
        Me.DelightButton2.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.DelightButton2, "Close")
        Me.DelightButton2.UseVisualStyleBackColor = False
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
        Me.DelightButton1.Location = New System.Drawing.Point(3, 3)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(105, 41)
        Me.DelightButton1.TabIndex = 0
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Export"
        Me.ToolTip1.SetToolTip(Me.DelightButton1, "Export to an Spreadsheet File")
        Me.DelightButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.ToolStrip1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(9, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(562, 289)
        Me.Panel3.TabIndex = 2
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationID, Me.CustomerName, Me.RoomReserved, Me.DateOfReservation, Me.Payment, Me.Status})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.Size = New System.Drawing.Size(562, 263)
        Me.DataGridView1.TabIndex = 2
        '
        'ReservationID
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Brush Script MT", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservationID.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReservationID.HeaderText = "Reservation ID"
        Me.ReservationID.Name = "ReservationID"
        Me.ReservationID.Width = 200
        '
        'CustomerName
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerName.DefaultCellStyle = DataGridViewCellStyle4
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 170
        '
        'RoomReserved
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RoomReserved.DefaultCellStyle = DataGridViewCellStyle5
        Me.RoomReserved.HeaderText = "Room Reserved"
        Me.RoomReserved.Name = "RoomReserved"
        Me.RoomReserved.Width = 200
        '
        'DateOfReservation
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DateOfReservation.DefaultCellStyle = DataGridViewCellStyle6
        Me.DateOfReservation.HeaderText = "Date Of Reservation"
        Me.DateOfReservation.Name = "DateOfReservation"
        Me.DateOfReservation.Width = 250
        '
        'Payment
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Payment.DefaultCellStyle = DataGridViewCellStyle7
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.Width = 122
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(562, 26)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 3
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
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByCustomerNameToolStripMenuItem, Me.SearchByReservationIDToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = Global.Room_Delight.My.Resources.Resources.SearchButtonDelight
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 23)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton2"
        '
        'SearchByCustomerNameToolStripMenuItem
        '
        Me.SearchByCustomerNameToolStripMenuItem.Name = "SearchByCustomerNameToolStripMenuItem"
        Me.SearchByCustomerNameToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SearchByCustomerNameToolStripMenuItem.Text = "Search By Customer Name"
        '
        'SearchByReservationIDToolStripMenuItem
        '
        Me.SearchByReservationIDToolStripMenuItem.Name = "SearchByReservationIDToolStripMenuItem"
        Me.SearchByReservationIDToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.SearchByReservationIDToolStripMenuItem.Text = "Search By Reservation ID"
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
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Checked = True
        Me.ViewAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'ViewPaidOnlyToolStripMenuItem
        '
        Me.ViewPaidOnlyToolStripMenuItem.Name = "ViewPaidOnlyToolStripMenuItem"
        Me.ViewPaidOnlyToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ViewPaidOnlyToolStripMenuItem.Text = "View Paid Only"
        '
        'ViewCheckoutOnlyToolStripMenuItem
        '
        Me.ViewCheckoutOnlyToolStripMenuItem.Name = "ViewCheckoutOnlyToolStripMenuItem"
        Me.ViewCheckoutOnlyToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ViewCheckoutOnlyToolStripMenuItem.Text = "View Checkout Only"
        '
        'ViewCureentlyCheckInToolStripMenuItem
        '
        Me.ViewCureentlyCheckInToolStripMenuItem.Name = "ViewCureentlyCheckInToolStripMenuItem"
        Me.ViewCureentlyCheckInToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ViewCureentlyCheckInToolStripMenuItem.Text = "View Cureently Check In"
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(580, 437)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReportForm"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.Text = "ReportForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DelightButton2 As Room_Delight.DelightButton
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DelightButton3 As Room_Delight.DelightButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReservationID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomReserved As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfReservation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SearchByCustomerNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchByReservationIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ViewAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPaidOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCheckoutOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCureentlyCheckInToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
