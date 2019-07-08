Public Class Data

    Private TASKS As Integer

    Public Sub ShowDialogInBackupMode()
        Me.Text = "Back Up Database"
        Me.Button_Action.Text = "Back Up"
        TASKS = 1
        Me.ShowDialog()
    End Sub
    Public Sub ShowDialogInRestoreMode()
        Me.Text = "Restore Database"
        Me.Button_Action.Text = "Restore"
        TASKS = 2
        Me.ShowDialog()
    End Sub
    Public Sub ShowDialogInDeployNewDatabaseMode()
        Me.Text = "Deploy New Database"
        Me.Button_Action.Text = "Deploy"
        TASKS = 3
        Me.ShowDialog()
    End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TASKS = 1 Then
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox2.Text = FolderBrowserDialog1.SelectedPath
            Else

            End If
        ElseIf TASKS = 2 Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox2.Text = FolderBrowserDialog1.SelectedPath
            Else

            End If
        ElseIf TASKS = 3 Then
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox2.Text = FolderBrowserDialog1.SelectedPath
            Else

            End If
        Else

        End If
        
    End Sub

    Private Sub DelightButton2_Click(sender As Object, e As EventArgs) Handles DelightButton2.Click
        Me.Close()
    End Sub

End Class
