'File Name: RoomDelightUtiliy
'Designed By: John Kenneth Saez
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Module RoomDelightUtility
    Private RUNTIME_USER As String
    Public Runtime_UserID As Integer
    Private sqlconn As New OleDb.OleDbConnection
    Private sqlquery As New OleDb.OleDbCommand
    Private connString As String
    Enum SHOW_DIALOG_MODE
        EditMode
        AddMode
    End Enum
    Enum SQL_JOINS
        INNER_JOIN
        LEFT_JOIN
        RIGHT_JOIN
        FULL_JOIN
    End Enum
    '------------------------------------------------------------------------------------------------------------------
    'DelightMsgBox Configuration
    Public Sub DelightMsgBox(ByVal msg As String, ByVal infoType As MsgStyles.DelightMsgStyle)
        DelightDialogBox.Label1.Text = msg

        If infoType = MsgStyles.DelightMsgStyle.INFORMATION Then
            DelightDialogBox.NotifPic.BackgroundImage = My.Resources.InfoMsgStyle
            My.Computer.Audio.Play(App_Path() & "\Sounds\Notif.wav")
        ElseIf infoType = MsgStyles.DelightMsgStyle.CRITICAL Then
            DelightDialogBox.NotifPic.BackgroundImage = My.Resources.CriticalMsgStyle
            My.Computer.Audio.Play(App_Path() & "\Sounds\Critical.wav")
        ElseIf infoType = MsgStyles.DelightMsgStyle.WARNING Then
            DelightDialogBox.NotifPic.BackgroundImage = My.Resources.WarningMsgStyle
            My.Computer.Audio.Play(App_Path() & "\Sounds\Notif.wav")
        Else
            DelightDialogBox.NotifPic.BackgroundImage = My.Resources.InfoMsgStyle
            My.Computer.Audio.Play(App_Path() & "\Sounds\Notif.wav")
        End If
        DelightDialogBox.ShowDialog()
    End Sub
    'End of DelightMsgBox Configuration
    '------------------------------------------------------------------------------------------------------------------
    'Database Startup
    Public Sub InitiateDatabase()
        ' Try
        connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & App_Path() & "\Database and Settings Runtime\ROOM DELIGHT.accdb"
        sqlconn.ConnectionString = connString
        sqlquery.Connection = sqlconn
        'Catch ex As Exception
        'DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        'End Try
    End Sub
    'End of database startup
    '------------------------------------------------------------------------------------------------------------------
    'Insert New Rcord Functions
    Public Sub AddNewUser(ByVal userName As String, ByVal userPassword As String, ByVal accessLevel As String,
                          ByVal name As String, ByVal address1 As String, ByVal address2 As String, ByVal contactNo As String,
                          ByVal emailAdd As String, ByVal accountPicture As String)
        'Try
        sqlconn.Open()

        sqlquery.CommandText = "INSERT INTO SysUser(UserName, UPassword, Name, Address1, Address2, PersonalEmail, ContactNo, AccessLevel, AcountPicture, UTemporary, DateCreated, CreatedBy)" &
                                         " VALUES(@UserName, @Password, @Name, @Address1, @Address2, @PersonalEmail, @ContactNo, @AccessLevel, @AcountPicture, @Temporary, @DateCreated, @CreatedBy)"
        sqlquery.Parameters.AddWithValue("@UserName", userName)
        sqlquery.Parameters.AddWithValue("@UPassword", userPassword)
        sqlquery.Parameters.AddWithValue("@Name", name)
        sqlquery.Parameters.AddWithValue("@Address1", address1)
        sqlquery.Parameters.AddWithValue("@Address2", address2)
        sqlquery.Parameters.AddWithValue("@PersonalEmail", emailAdd)
        sqlquery.Parameters.AddWithValue("@ContactNo", contactNo)
        sqlquery.Parameters.AddWithValue("@AccessLevel", accessLevel)
        sqlquery.Parameters.AddWithValue("@AcountPicture", accountPicture)
        sqlquery.Parameters.AddWithValue("@UTemporary", "Yes")
        sqlquery.Parameters.AddWithValue("@DateCreated", Date.Now)
        sqlquery.Parameters.AddWithValue("@CreatedBy", RunningUser)
        sqlquery.ExecuteNonQuery()
        sqlconn.Close()
        DelightMsgBox("User Added Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        'Catch ex As Exception
        'DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        'End Try
    End Sub

    Public Sub AddNewCustomer(ByVal CustomerName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal ContactNo As String, ByVal EmailAdd As String,
                              ByVal PersonalId As String, ByVal IDType As String, ByVal Company As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Customer(CustomerName,Address1,Address2,ContactNo,EmailAdd,PersonalID,IDType,Company)" &
                                            " VALUES(@CustomerName,@Address1,@Address2,@ContactNo,@EmailAdd,@PersonalID,@IDType,@Company)"
            sqlquery.Parameters.AddWithValue("@CustomerName", CustomerName)
            sqlquery.Parameters.AddWithValue("@Address1", Address1)
            sqlquery.Parameters.AddWithValue("@Address2", Address2)
            sqlquery.Parameters.AddWithValue("@ContactNo", ContactNo)
            sqlquery.Parameters.AddWithValue("@EmailAdd", EmailAdd)
            sqlquery.Parameters.AddWithValue("@PersonalID", PersonalId)
            sqlquery.Parameters.AddWithValue("@IDType", IDType)
            sqlquery.Parameters.AddWithValue("@Company", Company)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub

    Public Sub AddNewReservation(ByVal ReservationDate As String, ByVal RoomReserved As String, ByVal TimeToCheckIn As String, ByVal DaysToSpend As String,
                                 ByVal Kitchen As String, ByVal Laundry As String, ByVal Internet As String,
                                 ByVal status As String, ByVal CustomerID As Integer, ByVal ReservedBy As String)
        Try

            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Reservation(ReservationDate,RoomReserved,TimetoCheckIn,DaysToSpend,KitchenService,LaundryService,InternetService,Status,CustomerID,ReservedBy)" &
                                            " VALUES(@ReservationDate,@RoomReserved,@TimetoCheckIn,@DaysToSpend,@KitchenService,@LaundryService,@InternetService,@Status,@CustomerID,@ReservedBy)"
            sqlquery.Parameters.AddWithValue("@ReservationDate", ReservationDate)
            sqlquery.Parameters.AddWithValue("@RoomReserved", RoomReserved)
            sqlquery.Parameters.AddWithValue("@TimetoCheckIn", TimeToCheckIn)
            sqlquery.Parameters.AddWithValue("@DaysToSpend", DaysToSpend)
            sqlquery.Parameters.AddWithValue("@KitchenService", Kitchen)
            sqlquery.Parameters.AddWithValue("@LaundryService", Laundry)
            sqlquery.Parameters.AddWithValue("@InternetService", Internet)
            sqlquery.Parameters.AddWithValue("@Status", status)
            sqlquery.Parameters.AddWithValue("@CustomerID", CustomerID)
            sqlquery.Parameters.AddWithValue("@ReservedBy", ReservedBy)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Reservation Added Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub AddNewRoom(ByVal roomNo As String, ByVal RoomSize As String, ByVal roomType As String, ByVal roomStory As String, ByVal roomTelNo As String)
        Try

            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Room(RoomNo,RoomSize,RoomType,RoomStory,RoomTelephoneNo,Status)" &
                                    " VALUES(@RoomNo,@RoomSize,@RoomType,@RoomStory,@RoomTelephoneNo,@Status)"
            sqlquery.Parameters.AddWithValue("@RoomNo", roomNo)
            sqlquery.Parameters.AddWithValue("@RoomSize", RoomSize)
            sqlquery.Parameters.AddWithValue("@RoomType", roomType)
            sqlquery.Parameters.AddWithValue("@RoomStory", roomStory)
            sqlquery.Parameters.AddWithValue("@RoomTelephoneNo", roomTelNo)
            sqlquery.Parameters.AddWithValue("@Status", "Available")
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Room Added Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try

    End Sub
    Public Sub AddNewInvoice(ByVal CustomerID As Integer, ByVal ReservationID As Integer, ByVal TotalPayment As String,
                             ByVal AmountPaid As String,
                             ByVal AmountChange As String, ByVal TransactionDate As String, ByVal TransactBy As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Invoice(CustomerID,ReservationID,TotalPayment,AmountPaid,AmountChange,TransactionDate,TransactBy)" &
                                    "VALUES(@CustomerID,@ReservationID,@TotalPayment,@AmountPaid,@AmountChange,@TransactionDate,@TransactBy)"
            sqlquery.Parameters.AddWithValue("@CustomerID", CustomerID)
            sqlquery.Parameters.AddWithValue("@ReservationID", ReservationID)
            sqlquery.Parameters.AddWithValue("@TotalPayment", TotalPayment)
            sqlquery.Parameters.AddWithValue("@AmountPaid", AmountPaid)
            sqlquery.Parameters.AddWithValue("@AmountChange", AmountChange)
            sqlquery.Parameters.AddWithValue("@TransactionDate", TransactionDate)
            sqlquery.Parameters.AddWithValue("@TransactBy", TransactBy)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Transaction Saved", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try

    End Sub
    Public Sub AddNewUserLog(ByVal UserName As String, ByVal DisplayName As String, ByVal TimeLogin As String, ByVal TimeLogout As String, ByVal UserID As String, ByVal Udate As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO UserLogs(UserName,DisplayName,TimeLogin,TimeLogout,UserID,UDate)" &
                                    " VALUES(@UserName,@DisplayName,@TimeLogin,@TimeLogout,@UserID,@UDate)"
            sqlquery.Parameters.AddWithValue("@UserName", UserName)
            sqlquery.Parameters.AddWithValue("@DisplayName", DisplayName)
            sqlquery.Parameters.AddWithValue("@TimeLogin", TimeLogin)
            sqlquery.Parameters.AddWithValue("@TimeLogout", TimeLogout)
            sqlquery.Parameters.AddWithValue("@UserID", UserID)
            sqlquery.Parameters.AddWithValue("@UDate", Udate)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    'End Of Records Insertion
    '------------------------------------------------------------------------------------------------------------------
    'Load Data from Database
    Public Sub LoadTable(ByVal Table As String, ByVal datagrid As Windows.Forms.DataGridView)
        'Try

        Dim y As Integer = 0
        Dim x As Integer = 0

        sqlconn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM " & Table, sqlconn)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()
        Dim textHeader(20) As String
        datagrid.Columns.Clear()
        datagrid.Rows.Clear()
        If Table = "Customer" Then

            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "Customer ID"
            textHeader(1) = "Customer Name"
            textHeader(2) = "Customer ID"
            textHeader(3) = "Contact No"
            textHeader(4) = "Email Add"
            'Column Headers
            While y < 5
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0) 'CustomerID
                datagrid.Item(1, x).Value = reader(1) 'CustomerName
                datagrid.Item(2, x).Value = reader(2) 'RoomReserved
                datagrid.Item(3, x).Value = reader(4) 'ContactNo
                datagrid.Item(4, x).Value = reader(5) 'EmailAdd
                x = x + 1
            End While
        ElseIf Table = "Invoice" Then
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "Transaction ID"
            textHeader(1) = "Customer ID"
            textHeader(2) = "Reservation ID"
            textHeader(3) = "Total Payment"
            textHeader(4) = "Amount Paid"
            textHeader(5) = "Amount Change"
            textHeader(6) = "Transaction Date"
            textHeader(7) = "Transaction By"
            'Column Headers
            While y < 8
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0) 'TransactionID
                datagrid.Item(1, x).Value = reader(1) 'CustomerID
                datagrid.Item(2, x).Value = reader(2) 'ReservationID
                datagrid.Item(3, x).Value = reader(3) 'TotalPayment
                datagrid.Item(4, x).Value = reader(4) 'AmountPaid
                datagrid.Item(5, x).Value = reader(5) 'AmountChange
                datagrid.Item(6, x).Value = reader(6) 'TransactionDate
                datagrid.Item(7, x).Value = reader(7) 'TransactBy
                x = x + 1
            End While
        ElseIf Table = "Reservation" Then
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "Reservation ID"
            textHeader(1) = "Reservation Date"
            textHeader(2) = "Room Reserved"
            textHeader(3) = "Total Payment"
            textHeader(4) = "Amount Paid"
            textHeader(5) = "Amount Change"
            textHeader(6) = "Transaction Date"
            textHeader(7) = "Transact By"
            'Column Headers
            While y < 8
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0) 'ReservationID
                datagrid.Item(1, x).Value = reader(1) 'ReservationDate
                datagrid.Item(2, x).Value = reader(2) 'RoomReserved
                datagrid.Item(3, x).Value = reader(3) 'TimetoCheckIn
                datagrid.Item(4, x).Value = reader(4) 'DaysToSpend
                datagrid.Item(5, x).Value = reader(7) 'Status
                datagrid.Item(6, x).Value = reader(9) 'ReservedBy
                datagrid.Item(7, x).Value = reader(8) 'CustomerID
                x = x + 1
            End While
        ElseIf Table = "Room" Then
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "Room ID"
            textHeader(1) = "Room No"
            textHeader(2) = "Room Size"
            textHeader(3) = "Room Type"
            textHeader(4) = "Room Story"
            textHeader(5) = "RoomTelephoneNo"
            'Column Headers
            While y < 6
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0) 'RoomID
                datagrid.Item(1, x).Value = reader(1) 'RoomNo
                datagrid.Item(2, x).Value = reader(2) 'RoomSize
                datagrid.Item(3, x).Value = reader(3) 'RoomType
                datagrid.Item(4, x).Value = reader(4) 'RoomStory
                datagrid.Item(5, x).Value = reader(5) 'RoomTelephoneNo
                x = x + 1
            End While
        ElseIf Table = "SysUser" Then
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "User ID"
            textHeader(1) = "User Name"
            textHeader(2) = "Display Name"
            textHeader(3) = "Personal Email"
            textHeader(4) = "Access Level"
            textHeader(5) = "Date Created"
            textHeader(6) = "Created By"
            'Column Headers
            While y < 7
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0)  'UserID
                datagrid.Item(1, x).Value = reader(1)  'UserName
                datagrid.Item(2, x).Value = reader(3)  'DisplayName
                datagrid.Item(3, x).Value = reader(4)  'PersonalEmail
                datagrid.Item(4, x).Value = reader(8)  'AccessLevel
                datagrid.Item(5, x).Value = reader(11) 'DateCreated
                datagrid.Item(6, x).Value = reader(12) 'CreatedBy
                x = x + 1
            End While
        ElseIf Table = "UserLogs" Then
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            textHeader(0) = "User Log No."
            textHeader(1) = "User Name"
            textHeader(2) = "DisplayName"
            textHeader(3) = "Time Login"
            textHeader(4) = "Time Logout"
            textHeader(5) = "Date"
            'Column Headers
            While y < 6
                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = textHeader(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While
            'Row Configurations
            While (reader.Read())
                datagrid.Rows.Add()
                datagrid.Item(0, x).Value = reader(0)  'UserLogID
                datagrid.Item(1, x).Value = reader(1)  'Username
                datagrid.Item(2, x).Value = reader(2)  'DisplayName
                datagrid.Item(3, x).Value = reader(3)  'TimeLogin
                datagrid.Item(4, x).Value = reader(4)  'TimeLogout 
                datagrid.Item(5, x).Value = reader(6)  'UDate
                x = x + 1
            End While

        Else
            'do nothing
        End If
        sqlconn.Close()
        'Catch ex As Exception
        'DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        'End Try
    End Sub
    Public Sub LoadTableWithCondition(ByVal Table As String, ByVal Condtion As String, ByVal datagrid As Windows.Forms.DataGridView)
        Try
            Dim y As Integer = 0
            Dim x As Integer = 0
            sqlconn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM " & Table & " " & Condtion, sqlconn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            Dim textHeader(20) As String
            datagrid.Columns.Clear()
            datagrid.Rows.Clear()
            If Table = "Customer" Then

                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "Customer ID"
                textHeader(1) = "Customer Name"
                textHeader(2) = "Customer ID"
                textHeader(3) = "Contact No"
                textHeader(4) = "Email Add"
                'Column Headers
                While y < 5
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0) 'CustomerID
                    datagrid.Item(1, x).Value = reader(1) 'CustomerName
                    datagrid.Item(2, x).Value = reader(2) 'RoomReserved
                    datagrid.Item(3, x).Value = reader(4) 'ContactNo
                    datagrid.Item(4, x).Value = reader(5) 'EmailAdd
                    x = x + 1
                End While
            ElseIf Table = "Invoice" Then
                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "Transaction ID"
                textHeader(1) = "Customer ID"
                textHeader(2) = "Reservation ID"
                textHeader(3) = "Total Payment"
                textHeader(4) = "Amount Paid"
                textHeader(5) = "Amount Change"
                textHeader(6) = "Transaction Date"
                textHeader(7) = "Transaction By"
                'Column Headers
                While y < 8
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0) 'TransactionID
                    datagrid.Item(1, x).Value = reader(1) 'CustomerID
                    datagrid.Item(2, x).Value = reader(2) 'ReservationID
                    datagrid.Item(3, x).Value = reader(3) 'TotalPayment
                    datagrid.Item(4, x).Value = reader(4) 'AmountPaid
                    datagrid.Item(5, x).Value = reader(5) 'AmountChange
                    datagrid.Item(6, x).Value = reader(6) 'TransactionDate
                    datagrid.Item(7, x).Value = reader(7) 'TransactBy
                    x = x + 1
                End While
            ElseIf Table = "Reservation" Then
                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "Reservation ID"
                textHeader(1) = "Reservation Date"
                textHeader(2) = "Room Reserved"
                textHeader(3) = "Total Payment"
                textHeader(4) = "Amount Paid"
                textHeader(5) = "Amount Change"
                textHeader(6) = "Transaction Date"
                textHeader(7) = "Transact By"
                'Column Headers
                While y < 8
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0) 'ReservationID
                    datagrid.Item(1, x).Value = reader(1) 'ReservationDate
                    datagrid.Item(2, x).Value = reader(2) 'RoomReserved
                    datagrid.Item(3, x).Value = reader(3) 'TimetoCheckIn
                    datagrid.Item(4, x).Value = reader(4) 'DaysToSpend
                    datagrid.Item(5, x).Value = reader(7) 'Status
                    datagrid.Item(6, x).Value = reader(9) 'ReservedBy
                    datagrid.Item(7, x).Value = reader(8) 'CustomerID
                    x = x + 1
                End While
            ElseIf Table = "Room" Then
                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "Room ID"
                textHeader(1) = "Room No"
                textHeader(2) = "Room Size"
                textHeader(3) = "Room Type"
                textHeader(4) = "Room Story"
                textHeader(5) = "RoomTelephoneNo"
                'Column Headers
                While y < 6
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0) 'RoomID
                    datagrid.Item(1, x).Value = reader(1) 'RoomNo
                    datagrid.Item(2, x).Value = reader(2) 'RoomSize
                    datagrid.Item(3, x).Value = reader(3) 'RoomType
                    datagrid.Item(4, x).Value = reader(4) 'RoomStory
                    datagrid.Item(5, x).Value = reader(5) 'RoomTelephoneNo
                    x = x + 1
                End While
            ElseIf Table = "SysUser" Then
                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "User ID"
                textHeader(1) = "User Name"
                textHeader(2) = "Display Name"
                textHeader(3) = "Personal Email"
                textHeader(4) = "Access Level"
                textHeader(5) = "Date Created"
                textHeader(6) = "Created By"
                'Column Headers
                While y < 7
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0)  'UserID
                    datagrid.Item(1, x).Value = reader(1)  'UserName
                    datagrid.Item(2, x).Value = reader(3)  'DisplayName
                    datagrid.Item(3, x).Value = reader(4)  'PersonalEmail
                    datagrid.Item(4, x).Value = reader(8)  'AccessLevel
                    datagrid.Item(5, x).Value = reader(11) 'DateCreated
                    datagrid.Item(6, x).Value = reader(12) 'CreatedBy
                    x = x + 1
                End While
            ElseIf Table = "UserLogs" Then
                Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
                textHeader(0) = "User Log No."
                textHeader(1) = "User Name"
                textHeader(2) = "DisplayName"
                textHeader(3) = "Time Login"
                textHeader(4) = "Time Logout"
                textHeader(5) = "Date"
                'Column Headers
                While y < 6
                    columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                    Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                    datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                    columnHeader(y).HeaderText = textHeader(y)
                    columnHeader(y).Width = 200
                    datagrid.Columns.Add(columnHeader(y))
                    y = y + 1
                End While
                'Row Configurations
                While (reader.Read())
                    datagrid.Rows.Add()
                    datagrid.Item(0, x).Value = reader(0)  'UserLogID
                    datagrid.Item(1, x).Value = reader(1)  'Username
                    datagrid.Item(2, x).Value = reader(2)  'DisplayName
                    datagrid.Item(3, x).Value = reader(3)  'TimeLogin
                    datagrid.Item(4, x).Value = reader(4)  'TimeLogout 
                    datagrid.Item(5, x).Value = reader(6)  'UDate
                    x = x + 1
                End While

            Else
                'do nothing
            End If
            sqlconn.Close()
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub LoadJoinedTable(ByVal table1 As String, ByVal table2 As String, ByVal columns() As String, ByVal primaryKey As String, ByVal foreignKey As String, ByVal JoinType As SQL_JOINS, ByVal datagrid As Windows.Forms.DataGridView)
        Try

            'Local Variables
            Dim cmd As OleDbCommand
            Dim reader As OleDbDataReader
            Dim x As Integer = 0
            Dim y As Integer = 0
            Dim columnHeader(20) As Windows.Forms.DataGridViewTextBoxColumn
            Dim joinStr As String = ""
            Dim columnsToBeJoined As String = ""
            'columnsToBeJoined = columnsToBeJoined + columns(0)

            'For Joining Table
            While x < columns.Length

                columnsToBeJoined = columnsToBeJoined + columns(x)
                x = x + 1
            End While

            'For Column Headers
            datagrid.Rows.Clear()
            datagrid.Columns.Clear()

            While y < columns.Length - 1

                columnHeader(y) = New Windows.Forms.DataGridViewTextBoxColumn
                Dim DataGridCellStyle As DataGridViewCellStyle = New DelightDataGridCellStyle
                datagrid.ColumnHeadersDefaultCellStyle = DataGridCellStyle
                columnHeader(y).HeaderText = columns(y)
                columnHeader(y).Width = 200
                datagrid.Columns.Add(columnHeader(y))
                y = y + 1
            End While

            'SQL Join Configuration
            If JoinType = SQL_JOINS.INNER_JOIN Then
                joinStr = " INNER JOIN "
            ElseIf JoinType = SQL_JOINS.FULL_JOIN Then
                joinStr = " FULL JOIN "
            ElseIf JoinType = SQL_JOINS.LEFT_JOIN Then
                joinStr = " LEFT JOIN "
            ElseIf JoinType = SQL_JOINS.RIGHT_JOIN Then
                joinStr = " RIGHT JOIN "
            Else
                'do nothing
            End If
            DelightMsgBox("SELECT " & columnsToBeJoined & " FROM " & table1 & vbNewLine & joinStr & table2 & " ON " & primaryKey & " = " & foreignKey, MsgStyles.DelightMsgStyle.INFORMATION)
            'SQL Execution
            sqlconn.Open()
            cmd = New OleDbCommand("SELECT " & columnsToBeJoined & " FROM " & table1 & joinStr & table2 & " ON " & primaryKey & " = " & foreignKey, sqlconn)
            reader = cmd.ExecuteReader()
            x = 0
            y = 0
            While (reader.Read())
                While y < columns.Length - 1
                    datagrid.Rows.Add()
                    datagrid.Item(y, x).Value = reader(y)
                    y = y + 1
                End While
                x = x + 1
                y = 0
            End While

            'Configuration on table filling
            sqlconn.Close()
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    'End of Load Data from Database
    '------------------------------------------------------------------------------------------------------------------
    'Update Table
    Public Sub UpdateUser(ByVal IDValue As String, ByVal userName As String, ByVal accessLevel As String,
                          ByVal name As String, ByVal address1 As String, ByVal address2 As String,
                          ByVal contactNo As String, ByVal emailAdd As String, ByVal accountPicture As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "UPDATE SysUser SET UserName = '" & userName & "'," &
                                    "Name = '" & name & "'," &
                                    "Address1 = '" & address1 & "'," &
                                    "Address2 = '" & address2 & "'," &
                                    "PersonalEmail = '" & emailAdd & "'," &
                                    "ContactNo = '" & contactNo & "'," &
                                    "AccessLevel = '" & accessLevel & "'," &
                                    "AcountPicture = '" & accountPicture & "' " &
                                    "WHERE UserID = " & IDValue
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("User Updated Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub UpdateCustomer(ByVal IDValue As VariantType, ByVal CustomerName As String, ByVal Address1 As String, ByVal Address2 As String, ByVal ContactNo As String, ByVal EmailAdd As String,
                              ByVal PersonalId As String, ByVal IDType As String, ByVal Company As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "UPDATE Customer SET CustomerName = '" & CustomerName & "'," &
                                    "Address1 = '" & Address1 & "'," &
                                    "Address2 = '" & Address2 & "'," &
                                    "ContactNo = '" & ContactNo & "'," &
                                    "EmailAdd = '" & EmailAdd & "'," &
                                    "PersonalID = '" & PersonalId & "'," &
                                    "IDType = '" & IDType & "'," &
                                    "Company = '" & Company & "' " &
                                    "WHERE CustomerID = '" & IDValue & "'"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Customer Updated Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub UpdateRoom(ByVal IDValue As VariantType, ByVal roomNo As String, ByVal RoomSize As String, ByVal roomType As String, ByVal roomStory As String, ByVal roomTel As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "UPDATE Room SET RoomNo = '" & roomNo & "'," &
                                    "RoomSize = '" & RoomSize & "'," &
                                    "RoomType = '" & roomType & "'," &
                                    "RoomStory = '" & roomStory & "'," &
                                    "RoomTelephoneNo = '" & roomType & "'" &
                                    "WHERE RoomID = '" & IDValue & "'"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Room Updated Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub UpdateReservation(ByVal IDValue As String, ByVal ReservationDate As String, ByVal RoomReserved As String, ByVal TimeToCheckIn As String, ByVal DaysToSpend As String,
                                 ByVal Kitchen As String, ByVal Laundry As String, ByVal Internet As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "UPDATE Reservation SET ReservationDate = '" & ReservationDate & "'," &
                                    "RoomReserved = " & RoomReserved & "'," &
                                    "TimetoCheckIn = " & TimeToCheckIn & "'," &
                                    "DaysToSpend = " & DaysToSpend & "'," &
                                    "KitchenService = " & Kitchen & "'," &
                                    "LaundryService = " & Laundry & "'," &
                                    "InternetService = " & Internet & "'" &
                                    "WHERE ReservationID = '" & IDValue & "'"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Reservation Updated Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub Delete(ByVal Table As String, ByVal IDValue As String, ByVal ColumnID As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "DELETE FROM " & Table & " WHERE " & ColumnID & " = '" & IDValue & "'"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            DelightMsgBox("Delete Successfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    'End of Update Table
    '------------------------------------------------------------------------------------------------------------------
    'Custom Functions
    Public Sub CustomUpdate(ByVal table As String, ByVal IDValue As Integer, ByVal columnID As String, ByVal column As String, ByVal value As String)
        Try
            sqlconn.Open()
            sqlquery.CommandText = "UPDATE " & table & " SET " & column & " = '" & value & "'" & " WHERE " & columnID & " = " & IDValue
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    Public Sub OpenConnection()
        sqlconn.Open()
    End Sub
    Public Sub CloseConnection()
        sqlconn.Close()
    End Sub
    Public Sub RunSQL(ByVal cmd As String)
        Try
            sqlquery.CommandText = cmd
            sqlquery.ExecuteNonQuery()
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    'Login Function
    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean
        Dim IsLoginSuccess As Boolean = False
        Try

            sqlconn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM SysUser WHERE UserName = '" & Username & "' AND UPassword = '" & Password & "'", sqlconn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            If Reader.Read Then
                IsLoginSuccess = True
                SetRunningUser(Reader("Name").ToString)
                Runtime_UserID = Reader("UserID")
            Else
                IsLoginSuccess = False
            End If
            sqlconn.Close()
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
        Return IsLoginSuccess
    End Function
    'End Of Custom Functions
    '------------------------------------------------------------------------------------------------------------------
    'Get Value From a table
    Public Function GetSpecificValue(ByVal table As String, ByVal column As String, ByVal ColumnID As String, ByVal valueToCompare As String) As String
        Dim cmd As OleDbCommand
        Dim reader As OleDbDataReader
        Dim ret As String
        sqlconn.Open()
        cmd = New OleDbCommand("SELECT * FROM " & table & " WHERE " & ColumnID & " = " & valueToCompare, sqlconn)
        reader = cmd.ExecuteReader()
        reader.Read()
        ret = reader(column).ToString
        sqlconn.Close()
        Return ret
    End Function
    'End of Get Value From a table
    '------------------------------------------------------------------------------------------------------------------
    'Encapsulation of Run Time Usernn
    Public Sub SetRunningUser(runUser As String)
        RUNTIME_USER = runUser
    End Sub
    Public Function RunningUser() As String
        Return RUNTIME_USER
    End Function
    'End Of Encapsulation
    '------------------------------------------------------------------------------------------------------------------


    'Specifies Application Path
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function

    '------------------------------------------------------------------------------------------------------------------
    'File Function
    Public Sub FileCopy(ByVal directoryNgFileNaKokopyahin As String, ByVal directoryKungSaanIlalagayYungFile As String)
        My.Computer.FileSystem.CopyFile(directoryNgFileNaKokopyahin, directoryKungSaanIlalagayYungFile)
    End Sub

    Public Sub FileCreate(ByVal FileName As String)
        Dim F As FileStream = File.Create(FileName)
    End Sub

    Public Sub FolderCreate(ByVal folderName As String)
        Try
            ' Determine whether the directory exist
            If Directory.Exists(folderName) Then
                Console.WriteLine("That path exists already.")
                Return
            End If

            ' Try to create the directory.
            Dim di As DirectoryInfo = Directory.CreateDirectory(folderName)
        Catch ex As Exception
            DelightMsgBox(ex.Message, MsgStyles.DelightMsgStyle.CRITICAL)
        End Try
    End Sub
    'End Of File Function
    '------------------------------------------------------------------------------------------------------------------
    'Database Configuration
    Public Sub BackUpDatabase(ByVal directory As String)

    End Sub
    Public Sub RestoreDatabase(ByVal directory As String)

    End Sub
    Public Sub DeployDatabase(ByVal directory As String)

    End Sub
    'End Of Database Configuration
    'Settings
    Public Sub UpdateSettings()

    End Sub

End Module