Public NotInheritable Class DelightDialogBox
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub DelightDialogBox_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Point(Label1.Width + 170, Label1.Height + 200)
        DelightButton1.Location = New System.Drawing.Point(((Me.Width / 2) - 55) - 9, 6)
    End Sub

    Private Sub DelightButton1_Click_1(sender As Object, e As EventArgs) Handles DelightButton1.Click
        Me.Close()
    End Sub
End Class
