<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payments))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DelightButton2 = New Room_Delight.DelightButton()
        Me.DelightButton1 = New Room_Delight.DelightButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.roomChargeLabel = New System.Windows.Forms.Label()
        Me.miscellaneousServices = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.daysSpent = New System.Windows.Forms.Label()
        Me.transactionID = New System.Windows.Forms.Label()
        Me.transactDate = New System.Windows.Forms.Label()
        Me.transactBy = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.totalPaymentLabel14 = New System.Windows.Forms.Label()
        Me.amountChange = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 66)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Brush Script MT", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 64)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payments"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DelightButton2)
        Me.Panel2.Controls.Add(Me.DelightButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(9, 550)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 55)
        Me.Panel2.TabIndex = 1
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
        Me.DelightButton2.Location = New System.Drawing.Point(360, 9)
        Me.DelightButton2.Name = "DelightButton2"
        Me.DelightButton2.Size = New System.Drawing.Size(103, 37)
        Me.DelightButton2.TabIndex = 1
        Me.DelightButton2.TabStop = False
        Me.DelightButton2.Text = "Cancel"
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
        Me.DelightButton1.Location = New System.Drawing.Point(251, 9)
        Me.DelightButton1.Name = "DelightButton1"
        Me.DelightButton1.Size = New System.Drawing.Size(103, 37)
        Me.DelightButton1.TabIndex = 0
        Me.DelightButton1.TabStop = False
        Me.DelightButton1.Text = "Pay"
        Me.DelightButton1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.transactionID)
        Me.Panel3.Controls.Add(Me.transactDate)
        Me.Panel3.Controls.Add(Me.transactBy)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.totalPaymentLabel14)
        Me.Panel3.Controls.Add(Me.amountChange)
        Me.Panel3.Controls.Add(Me.NumericUpDown1)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(9, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 475)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.roomChargeLabel)
        Me.GroupBox1.Controls.Add(Me.miscellaneousServices)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.daysSpent)
        Me.GroupBox1.Font = New System.Drawing.Font("Brush Script MT", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 198)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bill Details"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(190, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 26)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "<customerName>"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(190, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 26)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "<customerName>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(190, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 26)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "<customerName>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 26)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Miscellaneous Services:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 26)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Room Charge:"
        '
        'roomChargeLabel
        '
        Me.roomChargeLabel.AutoSize = True
        Me.roomChargeLabel.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomChargeLabel.ForeColor = System.Drawing.Color.White
        Me.roomChargeLabel.Location = New System.Drawing.Point(190, 33)
        Me.roomChargeLabel.Name = "roomChargeLabel"
        Me.roomChargeLabel.Size = New System.Drawing.Size(39, 26)
        Me.roomChargeLabel.TabIndex = 25
        Me.roomChargeLabel.Text = "450"
        '
        'miscellaneousServices
        '
        Me.miscellaneousServices.AutoSize = True
        Me.miscellaneousServices.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miscellaneousServices.ForeColor = System.Drawing.Color.White
        Me.miscellaneousServices.Location = New System.Drawing.Point(190, 59)
        Me.miscellaneousServices.Name = "miscellaneousServices"
        Me.miscellaneousServices.Size = New System.Drawing.Size(41, 26)
        Me.miscellaneousServices.TabIndex = 27
        Me.miscellaneousServices.Text = "300"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 26)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Servces Included:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 26)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Days Spent:"
        '
        'daysSpent
        '
        Me.daysSpent.AutoSize = True
        Me.daysSpent.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysSpent.ForeColor = System.Drawing.Color.White
        Me.daysSpent.Location = New System.Drawing.Point(190, 164)
        Me.daysSpent.Name = "daysSpent"
        Me.daysSpent.Size = New System.Drawing.Size(41, 26)
        Me.daysSpent.TabIndex = 32
        Me.daysSpent.Text = "300"
        '
        'transactionID
        '
        Me.transactionID.AutoSize = True
        Me.transactionID.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionID.ForeColor = System.Drawing.Color.White
        Me.transactionID.Location = New System.Drawing.Point(154, 32)
        Me.transactionID.Name = "transactionID"
        Me.transactionID.Size = New System.Drawing.Size(138, 26)
        Me.transactionID.TabIndex = 45
        Me.transactionID.Text = "<transactionID>"
        '
        'transactDate
        '
        Me.transactDate.AutoSize = True
        Me.transactDate.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactDate.ForeColor = System.Drawing.Color.White
        Me.transactDate.Location = New System.Drawing.Point(154, 63)
        Me.transactDate.Name = "transactDate"
        Me.transactDate.Size = New System.Drawing.Size(129, 26)
        Me.transactDate.TabIndex = 45
        Me.transactDate.Text = "<transactDate>"
        '
        'transactBy
        '
        Me.transactBy.AutoSize = True
        Me.transactBy.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactBy.ForeColor = System.Drawing.Color.White
        Me.transactBy.Location = New System.Drawing.Point(152, 94)
        Me.transactBy.Name = "transactBy"
        Me.transactBy.Size = New System.Drawing.Size(115, 26)
        Me.transactBy.TabIndex = 44
        Me.transactBy.Text = "<transactBy>"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(152, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 26)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "<customerName>"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(12, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 26)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Customer Name:"
        '
        'totalPaymentLabel14
        '
        Me.totalPaymentLabel14.AutoSize = True
        Me.totalPaymentLabel14.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPaymentLabel14.ForeColor = System.Drawing.Color.White
        Me.totalPaymentLabel14.Location = New System.Drawing.Point(152, 380)
        Me.totalPaymentLabel14.Name = "totalPaymentLabel14"
        Me.totalPaymentLabel14.Size = New System.Drawing.Size(132, 26)
        Me.totalPaymentLabel14.TabIndex = 41
        Me.totalPaymentLabel14.Text = "<totalPayment>"
        '
        'amountChange
        '
        Me.amountChange.AutoSize = True
        Me.amountChange.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountChange.ForeColor = System.Drawing.Color.White
        Me.amountChange.Location = New System.Drawing.Point(157, 439)
        Me.amountChange.Name = "amountChange"
        Me.amountChange.Size = New System.Drawing.Size(141, 26)
        Me.amountChange.TabIndex = 40
        Me.amountChange.Text = "<amountChange>"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NumericUpDown1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown1.Location = New System.Drawing.Point(157, 409)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(216, 25)
        Me.NumericUpDown1.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(17, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 26)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Amount Change:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(17, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 26)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Amount Paid:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 26)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Total Payment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 26)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Transact by"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 26)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Transaction Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Brush Script MT", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transaction ID"
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(498, 614)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Payments"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payments"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents roomChargeLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents miscellaneousServices As System.Windows.Forms.Label
    Friend WithEvents amountChange As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents daysSpent As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents totalPaymentLabel14 As System.Windows.Forms.Label
    Friend WithEvents DelightButton2 As Room_Delight.DelightButton
    Friend WithEvents DelightButton1 As Room_Delight.DelightButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents transactionID As System.Windows.Forms.Label
    Friend WithEvents transactDate As System.Windows.Forms.Label
    Friend WithEvents transactBy As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
