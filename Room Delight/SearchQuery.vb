Public Class SearchQuery

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        Else
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub
End Class