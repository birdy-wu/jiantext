Public Class Search
    Private Index As Integer = 0
    '1.查找
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Index = Main.RichTextBox.Find(TextBox1.Text, Index, RichTextBoxFinds.None)
        If Index = -1 Then
            MessageBox.Show("没有找到与 " & TextBox1.Text & " 相关的内容")
            Main.RichTextBox.Select(Main.RichTextBox.TextLength, 0)
            Index = 0
        Else
            Index += 1
        End If
    End Sub
    '2.替换
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim k%, i%, Ls$
        i = InStr(Main.RichTextBox.Text, TextBox1.Text)
        k = i + Len(TextBox1.Text)
        Ls = Microsoft.VisualBasic.Left(Main.RichTextBox.Text, i - 1)
        Main.RichTextBox.Text = Ls + TextBox2.Text + Mid(Main.RichTextBox.Text, k)
    End Sub
    '3.全部替换
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main.RichTextBox.Text = Replace(Main.RichTextBox.Text, TextBox1.Text, TextBox2.Text)
    End Sub
    '4.显示高亮
    Private Sub Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.RichTextBox.HideSelection = False
    End Sub
    '5.退出
    Private Sub Search_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.SkinH_Attach()
        Main.RichTextBox.Modified = True
        Main.跟随系统皮肤ToolStripMenuItem.Checked = False
        Main.跟随系统皮肤ToolStripMenuItem.Enabled = True
    End Sub
End Class