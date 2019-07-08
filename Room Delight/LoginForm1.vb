Public Class LoginForm1

    Public SWITCH As Integer = 0
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        SWITCH = 1
        Login(UsernameTextBox.Text, PasswordTextBox.Text)
        If Login(UsernameTextBox.Text, PasswordTextBox.Text) Then
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Form1.LoadInitials()
            Me.Close()
        Else
            DelightMsgBox("Login Failed", MsgStyles.DelightMsgStyle.CRITICAL)
        End If
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        SWITCH = 0
        Me.Close()
    End Sub
End Class
