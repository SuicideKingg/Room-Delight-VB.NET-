Public Class MyAccount

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        New_or_Renew_Password.ShowDialogInEditPasswordMode()
    End Sub

    Private Sub MyAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.nameTxtbx.Text = GetSpecificValue("SysUser", "Name", "UserID", Runtime_UserID)
        Me.userName.Text = GetSpecificValue("SysUser", "UserName", "UserID", Runtime_UserID)
        Me.accessLevel.Text = GetSpecificValue("SysUser", "AccessLevel", "UserID", Runtime_UserID)
        Me.userID.Text = Runtime_UserID
        Me.PictureBox1.BackgroundImage = Image.FromFile(App_Path() & "\Database and Settings Runtime\Users\" & GetSpecificValue("SysUser", "AcountPicture", "UserID", Runtime_UserID))
    End Sub
End Class
