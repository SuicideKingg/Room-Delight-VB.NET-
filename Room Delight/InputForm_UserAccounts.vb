Imports System.IO
Public Class InputForm_UserAccounts
    Private showMode As String
    Private accessLevel As String
    Private userID As String
    Private accountPic As String
    Private picToBeChanged As Boolean = False
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        If showMode = "EDIT" Then
            If picToBeChanged Then
                FileCopy(accountPic, App_Path() & "\Database and Settings Runtime\Users\" & Me.displayname.Text & "\" & Path.GetFileName(accountPic))
            End If
            UpdateUser(CInt(userID), Me.userName.Text, accessLevel, Me.displayname.Text, address1.Text, Me.address2.Text, Me.contactNo.Text, Me.email.Text, Me.displayname.Text & "\" & Path.GetFileName(accountPic))
        Else
            AddNewUser(Me.userName.Text, Me.TemporaryPasswordTextBox.Text, accessLevel, Me.displayname.Text, Me.address1.Text, Me.address2.Text, contactNo.Text, email.Text, Me.displayname.Text & "\" & Path.GetFileName(accountPic))
            FolderCreate(App_Path() & "\Database and Settings Runtime\Users\" & Me.displayname.Text)
            FileCreate(App_Path() & "\Database and Settings Runtime\Users\" & Me.displayname.Text & "\Logs.txt")
            FileCopy(accountPic, App_Path() & "\Database and Settings Runtime\Users\" & Me.displayname.Text & "\" & Path.GetFileName(accountPic))
        End If
        Me.Close()
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TemporaryPasswordTextBox.UseSystemPasswordChar = False
        Else
            TemporaryPasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            accountPic = OpenFileDialog1.FileName
            picToBeChanged = True
        Else

        End If
    End Sub
    Public Sub ShowDialogInAddMode()
        showMode = "ADD"
        Me.Text = "Add New User"
        Me.ShowDialog()
    End Sub

    Public Sub ShowDialogInEditMode(ByVal id As String)
        showMode = "EDIT"
        userID = id

        Me.displayname.Text = GetSpecificValue("SysUser", "Name", "UserID", id)
        Me.userName.Text = GetSpecificValue("SysUser", "UserName", "UserID", id)
        Me.address1.Text = GetSpecificValue("SysUser", "Address1", "UserID", id)
        Me.address2.Text = GetSpecificValue("SysUser", "Address2", "UserID", id)
        Me.contactNo.Text = GetSpecificValue("SysUser", "ContactNo", "UserID", id)
        Me.email.Text = GetSpecificValue("SysUser", "PersonalEmail", "UserID", id)
        accountPic = App_Path() & "\Database and Settings Runtime\Users\" & GetSpecificValue("SysUser", "AcountPicture", "UserID", id)
        Me.PictureBox1.BackgroundImage = Image.FromFile(accountPic)
        If GetSpecificValue("SysUser", "AccessLevel", "UserID", id) = "Administrator" Then
            RadioButton1.Checked = True
            accessLevel = "Administrator"
        ElseIf GetSpecificValue("SysUser", "AccessLevel", "UserID", id) = "Executive" Then
            RadioButton2.Checked = True
            accessLevel = "Executive"
        ElseIf GetSpecificValue("SysUser", "AccessLevel", "UserID", id) = "Operator" Then
            accessLevel = "Operator"
            RadioButton3.Checked = True
        Else
            'do nothing
        End If
        Me.Text = "Edit User"
        Me.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        accessLevel = "Administrator"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        accessLevel = "Executive"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        accessLevel = "Operator"
    End Sub

    Private Sub InputForm_UserAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
