Public Class InputForm_Room

    Private RUNTIME_ID As String
    Private MODE As SHOW_DIALOG_MODE

    Public Sub ShowDialogInAddMode()
        MODE = SHOW_DIALOG_MODE.AddMode
        Me.ShowDialog()
    End Sub

    Public Sub ShowDialogInEditMode(ByVal id As String)
        MODE = SHOW_DIALOG_MODE.EditMode
        RUNTIME_ID = id
        Me.ShowDialog()
    End Sub
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs) Handles DelightButton1.Click
        Me.Close()
    End Sub

    Private Sub InputForm_Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MODE = SHOW_DIALOG_MODE.AddMode Then
            Me.Text = "Add New Room"
        ElseIf MODE = SHOW_DIALOG_MODE.EditMode Then
            Me.Text = "Edit Room"
            Me.roomNo.Value = CInt(GetSpecificValue("Room", "RoomNo", "RoomID", RUNTIME_ID))
            Me.roomSize.Value = CInt(GetSpecificValue("Room", "RoomSize", "RoomID", RUNTIME_ID))
            Me.roomType.Text = GetSpecificValue("Room", "RoomType", "RoomID", RUNTIME_ID)
            Me.roomStory.Value = CInt(GetSpecificValue("Room", "RoomStory", "RoomID", RUNTIME_ID))
            Me.telNo.Text = GetSpecificValue("Room", "RoomTelephoneNo", "RoomID", RUNTIME_ID)
        Else
            'do nothing
        End If
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click

        If MODE = SHOW_DIALOG_MODE.AddMode Then
            AddNewRoom(Me.roomNo.Value, Me.roomSize.Value, Me.roomType.Text, Me.roomStory.Value, Me.telNo.Text)
        ElseIf MODE = SHOW_DIALOG_MODE.EditMode Then
            UpdateRoom(Me.RUNTIME_ID, Me.roomNo.Value, Me.roomSize.Value, Me.roomType.Text, Me.roomStory.Value, Me.telNo.Text)
        Else
            'do nothing
        End If

    End Sub
End Class
