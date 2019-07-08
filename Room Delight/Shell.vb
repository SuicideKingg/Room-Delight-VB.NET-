Public Class Shell

    Private Sub Shell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(App_Path() & "\Sounds\Notif.wav")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class