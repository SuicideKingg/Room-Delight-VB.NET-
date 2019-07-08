Public Class New_or_Renew_Password
    Private NewPass As Boolean = False
    Public Sub ShowDialogInNewPasswordMode()
        NewPass = True
        Me.ShowDialog()
    End Sub
    Public Sub ShowDialogInEditPasswordMode()
        NewPass = False
        Me.ShowDialog()
    End Sub
    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = GetSpecificValue("SysUser", "UPassword", "UserID", Runtime_UserID) Then
            My.Computer.Audio.Play(App_Path() & "\Sounds\Notif.wav")
            Label1.Visible = True
            Label3.Visible = True
            TextBox1.Visible = True
            TextBox3.Visible = True
            DelightButton1.Visible = True
            TextBox2.Enabled = False
            Button1.Enabled = False
        Else
            My.Computer.Audio.Play(App_Path() & "\Sounds\Critical.wav")
            Label4.Text = "Incorrect Password"
        End If
        
    End Sub

    Private Sub New_or_Renew_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Enabled = True
        TextBox2.Enabled = True

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Visible = False
        TextBox3.Visible = False

        DelightButton1.Visible = False
        Label1.Visible = False
        Label3.Visible = False

        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        If TextBox1.Text = TextBox3.Text Then
            Dim msg As String
            If NewPass Then
                msg = "Are you sure for this new Password?" & vbNewLine & "You Can modify it by clicking No"
            Else
                msg = "Are you sure you want to Set your password?"
            End If
            If DelightDialogYesNoBox.ShowYesNo(msg) = MsgStyles.DelightYesNo.YES Then
                CustomUpdate("SysUser", Runtime_UserID, "UserID", "UPassword", TextBox1.Text)
                DelightMsgBox("Your Password is Set", MsgStyles.DelightMsgStyle.INFORMATION)
                Me.Close()
            Else
                'do nothing
            End If
        Else
            Label6.Text = "Password Doesn't Match"
            My.Computer.Audio.Play(App_Path() & "\Sounds\Critical.wav")

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label6.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label4.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text).Length < 8 Then
            Label5.Text = "Too Short"
        Else
            Label5.Text = "Much Better"
        End If
    End Sub
End Class
