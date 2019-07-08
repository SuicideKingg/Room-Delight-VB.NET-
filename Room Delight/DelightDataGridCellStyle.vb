Imports System.Windows.Forms

Public Class DelightDataGridCellStyle
    Inherits Windows.Forms.DataGridViewCellStyle
    Public Sub New()
        Me.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Font = New System.Drawing.Font("Lucida Calligraphy", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.SelectionForeColor = System.Drawing.Color.Black
        Me.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    End Sub
End Class
