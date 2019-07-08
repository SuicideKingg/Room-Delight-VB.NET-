Public Class Room_Browser
    Enum MODE
        SELECT_ROOM
        LIST_OF_ROOM
    End Enum
    Private m As MODE
    Private SelectedRoom As String

    Public Function GetRoom() As String
        m = MODE.SELECT_ROOM
        Me.DelightButton2.Text = "Select"
        Me.ShowDialog()
        Return SelectedRoom
    End Function

    Public Sub ShowDialogInListOfRoomMode()
        m = MODE.LIST_OF_ROOM
        Me.ShowDialog()
    End Sub

    Private Sub Room_Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        Me.Close()
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click

        If m = MODE.SELECT_ROOM Then

        ElseIf m = MODE.LIST_OF_ROOM Then

        Else
            'do nothing
        End If

    End Sub
End Class