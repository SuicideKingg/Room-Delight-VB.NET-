Public Class Form1
    Public Sub LoadInitials()
        usernameLabel.Text = RunningUser()
        logintimelabel.Text = TimeOfDay
        Dim d As DateTime = Now
        dateLabel.Text = d.ToString("yyyy-mm-dd")
        PictureBox2.BackgroundImage = Image.FromFile(App_Path() & "Database and Settings Runtime\Users\" & GetSpecificValue("SysUser", "AcountPicture", "UserID", Runtime_UserID))

        'For Temporary
        If GetSpecificValue("SysUser", "UTemporary", "UserID", Runtime_UserID) = "Yes" Then
            DelightMsgBox("The User is a new User created by Administrator" & vbNewLine & "You must update your Password to set as Regular User", MsgStyles.DelightMsgStyle.INFORMATION)
            New_or_Renew_Password.ShowDialogInNewPasswordMode()
            CustomUpdate("SysUser", Runtime_UserID, "UserID", "UTemporary", "No")
        Else
            'do nothing
        End If

        Shell.ShowDialog()
        'For Access Level
        If GetSpecificValue("SysUser", "AccessLevel", "UserID", Runtime_UserID) = "Administrator" Then
            Me.Panel1.Visible = True
            Me.Panel2.Visible = True
            Me.Panel3.Visible = True
            Me.Panel4.Visible = True
            Me.Panel5.Visible = True
            Me.LogoutToolStripMenuItem.Visible = True
            Me.ReportsToolStripMenuItem.Visible = True
            Me.FileToolStripMenuItem.Visible = True
            Me.DataToolStripMenuItem.Visible = True
            Me.ConfigurationToolStripMenuItem.Visible = True
            Me.TransactionToolStripMenuItem.Visible = True
            Me.HelpToolStripMenuItem.Visible = True

        ElseIf GetSpecificValue("SysUser", "AccessLevel", "UserID", Runtime_UserID) = "Executive" Then
            Me.Panel3.Visible = False
            Me.Panel1.Visible = True
            Me.Panel2.Visible = True
            Me.Panel4.Visible = True
            Me.Panel5.Visible = True
            Me.LogoutToolStripMenuItem.Visible = True
            Me.ReportsToolStripMenuItem.Visible = True
            Me.FileToolStripMenuItem.Visible = False
            Me.TransactionToolStripMenuItem.Visible = False
            Me.DataToolStripMenuItem.Visible = False
            Me.ConfigurationToolStripMenuItem.Visible = False
            Me.HelpToolStripMenuItem.Visible = True

        ElseIf GetSpecificValue("SysUser", "AccessLevel", "UserID", Runtime_UserID) = "Operator" Then
            Me.Panel1.Visible = True
            Me.Panel2.Visible = True
            Me.Panel3.Visible = True
            Me.Panel4.Visible = True
            Me.Panel5.Visible = True
            Me.HelpToolStripMenuItem.Visible = True
            Me.LogoutToolStripMenuItem.Visible = True
            Me.ReportsToolStripMenuItem.Visible = True
            Me.FileToolStripMenuItem.Visible = False
            Me.DataToolStripMenuItem.Visible = False
            Me.ConfigurationToolStripMenuItem.Visible = False
            Me.TransactionToolStripMenuItem.Visible = True
        Else

        End If

    End Sub
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        InputForm_Reservation.ShowDialog()
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Room_Browser.ShowDialog()
    End Sub

    Public Sub ExitSystem()
        Dim d As DateTime = Now
        AddNewUserLog(GetSpecificValue("SysUser", "UserName", "UserID", Runtime_UserID), Me.usernameLabel.Text, Me.logintimelabel.Text, TimeOfDay, Runtime_UserID, d.ToString("yyyy-mm-dd"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiateDatabase()
        LoginForm1.ShowDialog()
        If LoginForm1.SWITCH = 0 Then
            Me.Close()
        Else
            'do nothing
        End If

    End Sub

    Private Sub DelightButton5_Click(sender As Object, e As EventArgs) Handles DelightButton5.Click
        MyAccount.ShowDialog()
    End Sub

    Private Sub DelightButton6_Click(sender As Object, e As EventArgs) Handles DelightButton6.Click

        If DelightDialogYesNoBox.ShowYesNo("Are you sure you want to logout?") = MsgStyles.DelightYesNo.YES Then
            'ExitSystem()
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            Me.HelpToolStripMenuItem.Visible = False
            Me.LogoutToolStripMenuItem.Visible = False
            Me.ReportsToolStripMenuItem.Visible = False
            Me.FileToolStripMenuItem.Visible = False
            Me.TransactionToolStripMenuItem.Visible = False
            Me.DataToolStripMenuItem.Visible = False
            Me.ConfigurationToolStripMenuItem.Visible = False
            Me.BackColor = Color.Black
            LoginForm1.ShowDialog()
            Me.BackColor = Color.Maroon
        Else
            'do nothing
        End If


    End Sub

    Private Sub ListOfUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfUsersToolStripMenuItem.Click
        ListofUsers.ShowDialog()
    End Sub

    Private Sub UserssLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserssLogsToolStripMenuItem.Click
        UserLogs.ShowDialog()
    End Sub

    Private Sub DelightButton4_Click(sender As Object, e As EventArgs) Handles DelightButton4.Click
        Payments.ShowDialog()
    End Sub

    Private Sub SearchQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchQueryToolStripMenuItem.Click
        SearchQuery.ShowDialog()
    End Sub
    Private Sub BackUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpToolStripMenuItem.Click
        Data.ShowDialogInBackupMode()
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Data.ShowDialogInRestoreMode()
    End Sub

    Private Sub SwitchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToolStripMenuItem.Click
        Data.ShowDialogInDeployNewDatabaseMode()
    End Sub

    Private Sub NewReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewReservationToolStripMenuItem.Click

    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicesToolStripMenuItem.Click
        ReportForm.ShowDialog()
    End Sub

    Private Sub DelightButton3_Click(sender As Object, e As EventArgs) Handles DelightButton3.Click

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        If DelightDialogYesNoBox.ShowYesNo("Are you sure you want to logout?") = MsgStyles.DelightYesNo.YES Then
            'ExitSystem()
            Me.Panel1.Visible = False
            Me.Panel2.Visible = False
            Me.Panel3.Visible = False
            Me.Panel4.Visible = False
            Me.Panel5.Visible = False
            Me.HelpToolStripMenuItem.Visible = False
            Me.LogoutToolStripMenuItem.Visible = False
            Me.ReportsToolStripMenuItem.Visible = False
            Me.FileToolStripMenuItem.Visible = False
            Me.TransactionToolStripMenuItem.Visible = False
            Me.DataToolStripMenuItem.Visible = False
            Me.ConfigurationToolStripMenuItem.Visible = False
            Me.BackColor = Color.Black
            LoginForm1.ShowDialog()
            If LoginForm1.SWITCH = 0 Then
                Me.Close()
            Else
                'do nothing
            End If
            Me.BackColor = Color.Maroon
        Else
            'do nothing
        End If

        
    End Sub

    Private Sub LogoutAndCloseTheSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutAndCloseTheSystemToolStripMenuItem.Click
        If DelightDialogYesNoBox.ShowYesNo("Are you sure you want to Close the system?") = MsgStyles.DelightYesNo.YES Then
            'ExitSystem()
            Me.Close()
        Else
            'do nothing
        End If
        
    End Sub

    Private Sub AddNewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRoomToolStripMenuItem.Click
        InputForm_Room.ShowDialogInAddMode()
    End Sub
End Class
