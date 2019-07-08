Imports System.Drawing
Imports System.Windows.Forms
Public Class DelightRoomControl
    'Delight Room Control
    'Created By John Kenneth Saez
    'A Custom Control used in Room Browser Module
    Inherits Windows.Forms.Panel
    Private Pict As System.Windows.Forms.PictureBox
    Private label As System.Windows.Forms.Label
    Dim rName As String
    Dim rStat As String
    Dim rTimeChkin As String
    Dim rCust As String
    Public Sub New()
        Me.Size = New System.Drawing.Point(180, 155)
        Me.Cursor = Cursors.Hand
        Me.BackgroundImage = My.Resources.RoomTypeBackground
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackColor = Color.Transparent
        InitializeComponent()
    End Sub
    Private Sub InitializeComponent()
        Me.Pict = New System.Windows.Forms.PictureBox()
        Me.label = New System.Windows.Forms.Label()
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pict
        '
        Me.Pict.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pict.Location = New System.Drawing.Point(0, 0)
        Me.Pict.Name = "Pict"
        Me.Pict.Size = New System.Drawing.Size(200, 119)
        Me.Pict.TabIndex = 1
        Me.Pict.TabStop = False
        '
        'label
        '
        Me.label.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.label.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(0, 72)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(200, 28)
        Me.label.TabIndex = 0
        Me.label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DelightRoomControl
        '
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Pict)
        CType(Me.Pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    'Encapsulation of Needed data to a room browser

    'Function Getters
    Public Sub SetPic(ByVal img As Image)

        Me.Pict.BackgroundImage = img
        Me.Pict.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Public Sub SetRoomLabel(ByVal lbl As String)
        Me.label.Text = lbl
    End Sub
    'Function Setters
    Public Sub setRoomName(ByVal name As String)
        rName = name
    End Sub
    Public Sub setRoomStatus(ByVal stat As String)
        rStat = stat
    End Sub
    Public Sub setRoomTimeCheckIn(ByVal chkin As String)
        rTimeChkin = chkin
    End Sub
    Public Sub setRoomCustomerName(ByVal cust As String)
        rCust = cust
    End Sub
    Public Function RoomName() As String
        Return rName
    End Function
    Public Function RoomStatus() As String
        Return rStat
    End Function
    Public Function RoomTimeToCheckIn() As String
        Return rTimeChkin
    End Function
    Public Function RoomCustomer() As String
        Return rCust
    End Function
End Class
