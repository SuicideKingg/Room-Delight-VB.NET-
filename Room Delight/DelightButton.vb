Imports System.Drawing
Imports System.Windows.Forms

Public Class DelightButton
    Inherits Windows.Forms.Button
    Public Sub New()
        Me.Size = New System.Drawing.Point(90, 25)
        Me.TabStop = False
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.BackgroundImage = Room_Delight.My.Resources.Button
        Me.BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
        Me.BackColor = Drawing.Color.Transparent
        Me.Font = New System.Drawing.Font("Brush Script MT", 16, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = Color.White
        Me.Cursor = Cursors.Hand
        Me.FlatAppearance.BorderColor = Drawing.Color.Gray
        Me.FlatAppearance.MouseDownBackColor = Drawing.Color.Transparent
        Me.FlatAppearance.MouseOverBackColor = Drawing.Color.Transparent
        Me.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub MyButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.BackgroundImage = Room_Delight.My.Resources.Mouse_Down
    End Sub

    Private Sub MyButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        Me.BackgroundImage = Room_Delight.My.Resources.Hovered
    End Sub

    Private Sub MyButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = Room_Delight.My.Resources.Button
    End Sub

    Private Sub MyButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.BackgroundImage = Room_Delight.My.Resources.Hovered
    End Sub


End Class
