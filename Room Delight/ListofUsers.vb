Public Class ListofUsers
    Private RUNTIME_ID As Integer
    Private ConditionBy As String = "Name"
    Private RuntimeAccessLevel As String = ""
    Private Sub DelightButton3_Click(sender As Object, e As EventArgs) Handles DelightButton3.Click
        Me.Close()
    End Sub
    Private Sub DelightButton1_Click(sender As Object, e As EventArgs)
        InputForm_UserAccounts.ShowDialog()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        InputForm_UserAccounts.ShowDialogInAddMode()
    End Sub
    Private Sub ListofUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable("SysUser", DataGridView1)
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        RUNTIME_ID = CInt(selectedRow.Cells(0).Value.ToString)
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        InputForm_UserAccounts.ShowDialogInEditMode(RUNTIME_ID)
    End Sub
    Private Sub ReviewThisUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviewThisUserToolStripMenuItem.Click
        LoadTable("SysUser", DataGridView1)
    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        InputForm_UserAccounts.ShowDialogInAddMode()
    End Sub

    
    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'", DataGridView1)
    End Sub

    Private Sub SearchByCustomerNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByCustomerNameToolStripMenuItem.Click
        ConditionBy = "UserID"
        SearchByDisplayNameToolStripMenuItem.Checked = True
        SearchByReservationIDToolStripMenuItem.Checked = False
        SearchByDisplayNameToolStripMenuItem.Checked = False
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'", DataGridView1)
    End Sub

    Private Sub SearchByReservationIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByReservationIDToolStripMenuItem.Click
        ConditionBy = "UserName"
        SearchByReservationIDToolStripMenuItem.Checked = True
        SearchByDisplayNameToolStripMenuItem.Checked = False
        SearchByDisplayNameToolStripMenuItem.Checked = False
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'", DataGridView1)
    End Sub

    Private Sub SearchByDisplayNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByDisplayNameToolStripMenuItem.Click
        ConditionBy = "Name"
        SearchByReservationIDToolStripMenuItem.Checked = False
        SearchByDisplayNameToolStripMenuItem.Checked = False
        SearchByDisplayNameToolStripMenuItem.Checked = True
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'", DataGridView1)
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        RuntimeAccessLevel = ""
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'" & RuntimeAccessLevel, DataGridView1)
        ViewAllToolStripMenuItem.Checked = True
        ViewPaidOnlyToolStripMenuItem.Checked = False
        ViewCheckoutOnlyToolStripMenuItem.Checked = False
        ViewCureentlyCheckInToolStripMenuItem.Checked = False
    End Sub

    Private Sub ViewPaidOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPaidOnlyToolStripMenuItem.Click
        RuntimeAccessLevel = " AND AccessLevel = Administrator"
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'" & RuntimeAccessLevel, DataGridView1)
        ViewAllToolStripMenuItem.Checked = False
        ViewPaidOnlyToolStripMenuItem.Checked = True
        ViewCheckoutOnlyToolStripMenuItem.Checked = False
        ViewCureentlyCheckInToolStripMenuItem.Checked = False
    End Sub

    Private Sub ViewCheckoutOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCheckoutOnlyToolStripMenuItem.Click
        RuntimeAccessLevel = " AND AccessLevel = Executive"
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'" & RuntimeAccessLevel, DataGridView1)
        ViewAllToolStripMenuItem.Checked = False
        ViewPaidOnlyToolStripMenuItem.Checked = False
        ViewCheckoutOnlyToolStripMenuItem.Checked = True
        ViewCureentlyCheckInToolStripMenuItem.Checked = False
    End Sub

    Private Sub ViewCureentlyCheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCureentlyCheckInToolStripMenuItem.Click
        RuntimeAccessLevel = " AND AccessLevel = Operator"
        LoadTableWithCondition("SysUser", " WHERE " & ConditionBy & " LIKE '" & ToolStripTextBox1.Text & "%'" & RuntimeAccessLevel, DataGridView1)
        ViewAllToolStripMenuItem.Checked = False
        ViewPaidOnlyToolStripMenuItem.Checked = False
        ViewCheckoutOnlyToolStripMenuItem.Checked = False
        ViewCureentlyCheckInToolStripMenuItem.Checked = True
    End Sub

End Class