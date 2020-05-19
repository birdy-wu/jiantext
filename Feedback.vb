Public Class Feedback
    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        If RichTextBox.Text = "" Or UsernameTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MsgBox("均为必填项！", vbOKOnly, "提示")
            Exit Sub
        End If
        Try
            SubmitButton.Visible = False
            ToolStripStatusLabel.Text = "正在提交..."
            WebBrowser.Document.GetElementsByTagName("textarea")(0).InnerText = RichTextBox.Text         '向textarea标签填写richtextbox中的内容
            WebBrowser.Document.GetElementsByTagName("button")(0).InvokeMember("click")                   '点击发布
            ToolStripStatusLabel.Text = "填写用户信息..."
            WebBrowser.Document.GetElementById("ds-dialog-name").InnerText = UsernameTextBox.Text         '获取标签id，填写用户名和邮箱
            WebBrowser.Document.GetElementById("ds-dialog-email").InnerText = EmailTextBox.Text
            WebBrowser.Document.GetElementsByTagName("button")(1).InvokeMember("click")                   '点击发布
            ToolStripStatusLabel.Text = "完成。感谢你的反馈！你可以在讨论区查看回复。"
            ExitButton.Visible = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Feedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser.Navigate("http://dreamcreator108.droppages.com/feedback")
        If WebBrowser.IsOffline = False Then
            ToolStripStatusLabel.Text = "就绪"
        Else
            ToolStripStatusLabel.Text = "脱机状态：反馈不可用"
            SubmitButton.Visible = False
            ExitButton.Visible = True
        End If
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class