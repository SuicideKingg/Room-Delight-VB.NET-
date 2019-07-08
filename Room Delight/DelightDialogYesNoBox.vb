Public NotInheritable Class DelightDialogYesNoBox

    Dim q As MsgStyles.DelightYesNo
    Public Function ShowYesNo(ByVal question As String) As MsgStyles.DelightYesNo
        Label1.Text = question
        Me.ShowDialog()
        Return q
    End Function
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        q = MsgStyles.DelightYesNo.YES
        Me.Close()
    End Sub
    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        q = MsgStyles.DelightYesNo.NO
        Me.Close()
    End Sub
End Class
