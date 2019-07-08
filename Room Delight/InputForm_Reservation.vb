Public NotInheritable Class InputForm_Reservation

  

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        DelightMsgBox("Reservation Saved Succesfully", MsgStyles.DelightMsgStyle.INFORMATION)
        Me.Close()
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TextBox14.Text = Room_Browser.GetRoom
    End Sub
End Class
