Imports System.Xml
Imports System.Threading
Public Class CheckUpdate
    '检测鼠标移动，开始检查更新（等待鼠标移动一定程度上解决点开等待渲染、加载不美观的问题）
    Private Sub CheckUpdate_MouseMove(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseMove
        Dim url As String = "http://7xptwy.com1.z0.glb.clouddn.com/jiantext/rss.xml"
        Me.loadxmltocache(url)
        Me.loadinfo()
        查询状态Label.Visible = False
        If 最新版本号Label.Text = 当前版本号Label.Text Then
            已是最新Label.Visible = True
        Else
            下载更新Button.Visible = True
        End If
    End Sub
    '读RSS文件并缓存 
    Private Sub loadxmltocache(ByVal URL As String)
        Dim xmldocument As New XmlDocument
        xmldocument.Load(URL)
        xmldocument.Save(Application.StartupPath & "~doc.xml")
    End Sub
    '读RSS中网页的title和description 作为版本号和功能介绍
    Private Sub loadinfo()
        Dim xmlDocument As New XmlDocument
        xmlDocument.Load(Application.StartupPath & "~doc.xml")
        Dim mynodelist As XmlNodeList
        mynodelist = xmlDocument.SelectNodes("/rss/channel")
        最新版本号Label.Text = Trim(mynodelist(0).Item("title").InnerText())
        RichTextBox.Text = Trim(mynodelist(0).Item("description").InnerText())
    End Sub
    '下载更新
    Private Sub 下载更新Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 下载更新Button.Click
        System.Diagnostics.Process.Start("http://7xptwy.com1.z0.glb.clouddn.com/jiantext/lastest.rar")
    End Sub

End Class