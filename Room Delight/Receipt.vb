Public NotInheritable Class Receipt

  
    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font, Brushes.Black, 100, 100)



    End Sub

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
