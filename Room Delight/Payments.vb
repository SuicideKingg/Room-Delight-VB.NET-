Public Class Payments

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        Receipt.ShowDialog()
    End Sub

    Private Sub Payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
