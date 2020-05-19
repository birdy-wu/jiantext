Imports System.IO
Imports System.Drawing.Printing
Public Class Main
    Public Declare Function SkinH_Attach Lib "SkinH_VB6.dll" () As Long      'SkinH_Attach函数声明
    Public Declare Function SkinH_Detach Lib "SkinH_VB6.dll" () As Long      'SkinH_Detach函数声明
    Dim Loc As String                                                        'Loc作为保存过程中的变量'
    Dim CharactersAllowed As String                                         '储存字典字符的变量
    Dim i As Integer
    Dim j As Integer
    Private PrintPageSettings As New PageSettings
    Private StringToPrint As String
    Private PrintFont As New Font("Arial", 10)
    '加载程序当前目录下的文件名skinh.she进行换肤
    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SkinH_Attach()
    End Sub
    '如果程序关闭，检查是否已经保存
    Private Sub Main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If Oldfile(sender, e) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    '以下对应各个菜单按钮的功能
    '一、文件
    '保存检测函数
    Function Oldfile(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        Dim result As String
        If RichTextBox.Modified = True Then
            result = MessageBox.Show("              文件内容已经改变！" & Chr(13) & "               需要保存文件吗？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            Select Case result
                Case Windows.Forms.DialogResult.Yes
                    保存ToolStripMenuItem_Click(sender, e)
                    Return True
                Case Windows.Forms.DialogResult.No
                    Return True
                Case Windows.Forms.DialogResult.Cancel
                    Return False
            End Select
        End If
        Return True
    End Function
    '1.新建
    Private Sub 新建ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem.Click
        If Oldfile(sender, e) Then
            Me.Text = "无标题" & " - 简言"
            Me.RichTextBox.Clear()
            loc = Nothing
        End If
    End Sub
    '2.打开
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        If Oldfile(sender, e) Then
            Try        '异常处理结构
                Dim opf, filename, filetitle() As String
                OpenFileDialog1.Filter = "(*.jtxt)|*.jtxt|所有文件(*.*)|*.*"      '指定打开的格式
                OpenFileDialog1.ShowDialog()
                opf = OpenFileDialog1.FileName
                filename = OpenFileDialog1.SafeFileName
                filetitle = Split(filename, ".")
                RichTextBox.LoadFile(opf, RichTextBoxStreamType.PlainText)       '加载文件内容
                Me.Text = filetitle(0) & " - 简言"                                '更改标题
                loc = opf
            Catch ex As Exception
            End Try
        End If
    End Sub
    '3.保存
    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Try        '异常处理结构
            Dim saf As String
            SaveFileDialog.Filter = "(*.jtxt)|*.jtxt|(*.txt)|*.txt"        '保存文档的格式
            If loc Is Nothing Then                                          '如果这是一个已经打开的文件，就不要再显示选择文件路径的对话框
                SaveFileDialog.FileName = "无标题"
                Me.SaveFileDialog.ShowDialog()
                saf = SaveFileDialog.FileName
            Else
                saf = loc
            End If
            Me.RichTextBox.SaveFile(saf, RichTextBoxStreamType.PlainText)
            loc = saf
        Catch ex As Exception
        End Try
    End Sub
    '4.另存为
    Private Sub 另存为ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 另存为ToolStripMenuItem.Click
        Try        '异常处理结构
            SaveFileDialog.Filter = "(*.jtxt)|*.jtxt|(*.txt)|*.txt"        '保存文档的格式
            Me.SaveFileDialog.ShowDialog()
            Dim safas As String
            safas = SaveFileDialog.FileName
            Me.RichTextBox.SaveFile(safas, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
        End Try
    End Sub
    '5.页面设置
    Private Sub 页面设置ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 页面设置ToolStripMenuItem.Click
        Try        '异常处理结构
            PageSetupDialog1.PageSettings = PrintPageSettings
            PageSetupDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '6.打印预览
    Private Sub 打印预览ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 打印预览ToolStripMenuItem.Click
        Try '页面预览  
            PrintDocument1.DefaultPageSettings = PrintPageSettings
            StringToPrint = RichTextBox.Text
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '7.打印
    Private Sub 打印ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 打印ToolStripMenuItem.Click
        Try
            StringToPrint = Me.RichTextBox.Text
            PrintDocument1.DefaultPageSettings = PrintPageSettings '设置打印默认页面设置
            PrintDialog1.Document = PrintDocument1
            Dim results As DialogResult = PrintDialog1.ShowDialog()
            If results = DialogResult.OK Then
                PrintDocument1.Print()                '打印 
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Chnum, Linum As Integer         '字符数、行数
        Dim curstr As String                '当前页面字符串，current strings
        Dim strFormat As New StringFormat
        '定义打印区域 
        Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
        '确定页面可容纳文本
        Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))
        '换行不破坏单词完整性 
        strFormat.Trimming = StringTrimming.Word
        '用MeasureString计算出可容纳的字符串个数Chum和行数Linum 
        e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, Chnum, Linum)
        '计算出适应页面的字符串  
        curstr = StringToPrint.Substring(0, Chnum)
        '（逻辑上）在当前页打印字符串  
        e.Graphics.DrawString(curstr, PrintFont, Brushes.Black, rectDraw, strFormat)
        '若还有需要打印的文本，则继续处理剩下的页面  
        If Chnum < StringToPrint.Length Then
            '删除已经打印的字符串  
            StringToPrint = StringToPrint.Substring(Chnum)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            StringToPrint = RichTextBox.Text
        End If
    End Sub
    '8.退出
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub
    '二、字典 【特色模块】
    '1.不过滤
    Private Sub 不过滤ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 不过滤ToolStripMenuItem.Click
        不过滤ToolStripMenuItem.Checked = True
        字ToolStripMenuItem.Checked = False
        字ToolStripMenuItem1.Checked = False
        字ToolStripMenuItem2.Checked = False
        字ToolStripMenuItem3.Checked = False
        自定义ToolStripMenuItem.Checked = False
    End Sub
    '2.300字
    Private Sub 字ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 字ToolStripMenuItem.Click
        不过滤ToolStripMenuItem.Checked = False
        字ToolStripMenuItem.Checked = True
        字ToolStripMenuItem1.Checked = False
        字ToolStripMenuItem2.Checked = False
        字ToolStripMenuItem3.Checked = False
        自定义ToolStripMenuItem.Checked = False
        Try
            Using sr As New StreamReader("300.txt")       '用 stream reader 读取文件
                CharactersAllowed = sr.ReadToEnd() & Charexc.Charexcstr        '将文件中的字符赋给字符过滤字典，加上用户设置的例外字符
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '3.500字
    Private Sub 字ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 字ToolStripMenuItem1.Click
        不过滤ToolStripMenuItem.Checked = False
        字ToolStripMenuItem.Checked = False
        字ToolStripMenuItem1.Checked = True
        字ToolStripMenuItem2.Checked = False
        字ToolStripMenuItem3.Checked = False
        自定义ToolStripMenuItem.Checked = False
        Try
            Using sr As New StreamReader("500.txt")       '用 stream reader 读取文件
                CharactersAllowed = sr.ReadToEnd() & Charexc.Charexcstr
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '4.1000字
    Private Sub 字ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 字ToolStripMenuItem2.Click
        不过滤ToolStripMenuItem.Checked = False
        字ToolStripMenuItem.Checked = False
        字ToolStripMenuItem1.Checked = False
        字ToolStripMenuItem2.Checked = True
        字ToolStripMenuItem3.Checked = False
        自定义ToolStripMenuItem.Checked = False
        Try
            Using sr As New StreamReader("1000.txt")       ' 用 stream reader 读取文件
                CharactersAllowed = sr.ReadToEnd() & Charexc.Charexcstr
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '5.2500字
    Private Sub 字ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 字ToolStripMenuItem3.Click
        不过滤ToolStripMenuItem.Checked = False
        字ToolStripMenuItem.Checked = False
        字ToolStripMenuItem1.Checked = False
        字ToolStripMenuItem2.Checked = False
        字ToolStripMenuItem3.Checked = True
        自定义ToolStripMenuItem.Checked = False
        Try
            Using sr As New StreamReader("2500.txt")       ' 用 stream reader 读取文件
                CharactersAllowed = sr.ReadToEnd() & Charexc.Charexcstr
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '6.用户自定义字典
    Private Sub 自定义ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 自定义ToolStripMenuItem.Click
        Try
            Dim Cusfile As String
            MsgBox("请选择一个以UTF-8编码的TXT文本文件", vbOKOnly, "注意")
            OpenFileDialog2.Filter = "文本文件(*.txt)|*.txt"      '指定打开的格式
            OpenFileDialog2.ShowDialog()
            Cusfile = OpenFileDialog2.FileName
            Using sr As New StreamReader(Cusfile)
                CharactersAllowed = sr.ReadToEnd() & Charexc.Charexcstr
            End Using
            不过滤ToolStripMenuItem.Checked = False
            字ToolStripMenuItem.Checked = False
            字ToolStripMenuItem1.Checked = False
            字ToolStripMenuItem2.Checked = False
            字ToolStripMenuItem3.Checked = False
            自定义ToolStripMenuItem.Checked = True
        Catch ex As Exception
        End Try
    End Sub
    '7.添加例外字符
    Private Sub 添加例外字符ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加例外字符ToolStripMenuItem.Click
        Charexc.Top = Me.Top + 80
        Charexc.Left = Me.Left + 30
        Charexc.ShowDialog()
        CharactersAllowed = CharactersAllowed & Charexc.Charexcstr
    End Sub
    '8.截止过滤
    Private Sub 截止过滤ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 截止过滤ToolStripMenuItem.Click
        截止过滤ToolStripMenuItem.Checked = True
        筛选过滤ToolStripMenuItem.Checked = False
    End Sub
    '9.筛选过滤
    Private Sub 筛选过滤ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 筛选过滤ToolStripMenuItem.Click
        截止过滤ToolStripMenuItem.Checked = False
        筛选过滤ToolStripMenuItem.Checked = True
    End Sub
    '10.模式判断
    Private Sub 不过滤ToolStripMenuItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 不过滤ToolStripMenuItem.CheckedChanged
        If 不过滤ToolStripMenuItem.Checked = False Then                      '判断是否在向过滤模式转换
            If 跟随系统皮肤ToolStripMenuItem.Checked = False Then
                SkinH_Detach()                                               '过滤模式中禁止自定义的皮肤
                跟随系统皮肤ToolStripMenuItem.Checked = True
            End If
            跟随系统皮肤ToolStripMenuItem.Enabled = False
            添加例外字符ToolStripMenuItem.Enabled = True
            RichTextBox.Modified = True            '修正重载皮肤后退出无验证的问题
            MsgBox("过滤模式下将禁用皮肤！", vbOKOnly, "提示")
        Else
            SkinH_Attach()                                                   '普通模式加载自定义皮肤
            跟随系统皮肤ToolStripMenuItem.Checked = False
            跟随系统皮肤ToolStripMenuItem.Enabled = True
            添加例外字符ToolStripMenuItem.Enabled = False
            RichTextBox.Modified = True            '修正重载皮肤后退出无验证的问题
        End If
    End Sub
    '11.过滤检测
    Private Sub RichTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBox.TextChanged
        If 不过滤ToolStripMenuItem.Checked = False Then
            '     If Char.IsNumber(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Then   '退格应该允许。     
            'Return
            '  Else
            ' MsgBox("请输入数字")
            ' e.Handled = False
            ' End If
            ' e.Handled = True

            '  InStr(RichTextBox1.Text, "F***")

            'If (e.KeyChar >= Chr(Asc("0")) And e.KeyChar <= Chr(Asc("9"))) Or e.KeyChar = Chr(8) Then Exit Sub
            'e.KeyChar = Chr(0)

            'If e.KeyChar < Chr(Asc("0")) Or e.KeyChar = Chr(8) Then Exit Sub
            'e.KeyChar = Chr(0)
            Dim Uncheckedtext As String = RichTextBox.Text
            Dim Character As String
            Dim SelectionIndex As Integer = RichTextBox.SelectionStart
            Dim Change As Integer
            For x As Integer = 0 To RichTextBox.Text.Length - 1        '逐字符校验
                Character = RichTextBox.Text.Substring(x, 1)
                If CharactersAllowed.Contains(Character) = False Then
                    If 筛选过滤ToolStripMenuItem.Checked = True Then
                        Uncheckedtext = Uncheckedtext.Replace(Character, String.Empty)     '仅清除非法字符
                    Else
                        Uncheckedtext = Strings.Left(Uncheckedtext, x)                     '截止清除非法字符
                        If 关闭过滤提示音ToolStripMenuItem.Checked = False Then
                            Beep()
                        End If
                        If 关闭过滤抖动ToolStripMenuItem.Checked = False Then
                            i = 6
                            j = 6
                            Timer1.Enabled = True
                        End If
                        Exit For
                    End If
                    Change = 1
                End If
            Next
            RichTextBox.Text = Uncheckedtext
            RichTextBox.Select(SelectionIndex - Change, 0)             '令光标在插入非法字符之前的位置上
            RichTextBox.Modified = True
        End If
    End Sub
    '10.动画效果
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i > 0 Then
            Call WindowMoveLeft()
            i = i - 1
        Else
            If j > 0 Then
                Call WindowMoveRight()
                j = j - 1
            Else
                Timer1.Enabled = False
            End If
        End If
    End Sub
    Sub WindowMoveLeft()
        Me.Left = Me.Left - 1
    End Sub
    Sub WindowMoveRight()
        Me.Left = Me.Left + 1
    End Sub
    '三、编辑
    '1.撤销
    Private Sub 撤销ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 撤销ToolStripMenuItem.Click
        Me.RichTextBox.Undo()
    End Sub
    '2.剪切
    Private Sub 剪切ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 剪切ToolStripMenuItem.Click
        Me.RichTextBox.Cut()
    End Sub
    '3.复制
    Private Sub 复制ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem.Click
        Me.RichTextBox.Copy()
    End Sub
    '4.粘贴
    Private Sub 粘贴ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 粘贴ToolStripMenuItem.Click
        Me.RichTextBox.Paste()
    End Sub
    '5.全选
    Private Sub 全选ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem.Click
        Me.RichTextBox.SelectAll()
    End Sub
    '6.清空
    Private Sub 清空ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 清空ToolStripMenuItem.Click
        Me.RichTextBox.Clear()
    End Sub
    '7.查找与替换
    Private Sub 查找与替换ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查找与替换ToolStripMenuItem.Click
        SkinH_Detach()
        跟随系统皮肤ToolStripMenuItem.Checked = True
        跟随系统皮肤ToolStripMenuItem.Enabled = False
        Search.Top = Me.Top + 150
        Search.Left = Me.Left + 300
        Search.Show()
    End Sub
    '8.插入时间日期
    Private Sub 插入时间日期ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 插入时间日期ToolStripMenuItem.Click
        If 跟随系统皮肤ToolStripMenuItem.Checked = False Then
            SkinH_Detach()                          '装载皮肤对Strings.Left函数功能产生影响
        End If
        Dim Cstart As Integer
        Dim Textl, Textr As String
        Cstart = Me.RichTextBox.SelectionStart
        Textl = Strings.Left(Me.RichTextBox.Text, Cstart)                               '选中文本左侧的文字
        Textr = Strings.Right(Me.RichTextBox.Text, Len(Me.RichTextBox.Text) - Cstart)  '选中文本右侧的文字
        Me.RichTextBox.Text = Textl + Now.ToShortTimeString + " " + Now.ToShortDateString + Textr
        Me.RichTextBox.SelectionStart = Me.RichTextBox.Text.Length - Len(Textr)
        If 跟随系统皮肤ToolStripMenuItem.Checked = False Then
            SkinH_Attach()
            RichTextBox.Modified = True            '修正重载皮肤后退出无验证的问题
        End If
    End Sub
    '8.控件可用条件
    Private Sub MenuStrip1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuStrip1.MouseHover
        If RichTextBox.Text = "" Then
            '菜单栏
            全选ToolStripMenuItem.Enabled = False
        Else
            ' 菜单栏()
            全选ToolStripMenuItem.Enabled = True
        End If
        If RichTextBox.SelectedText <> "" Then
            '菜单栏
            剪切ToolStripMenuItem.Enabled = True
            复制ToolStripMenuItem.Enabled = True
        Else
            '菜单栏
            剪切ToolStripMenuItem.Enabled = False
            复制ToolStripMenuItem.Enabled = False
        End If
    End Sub
    '三、格式
    '1.自动换行
    Private Sub 自动换行ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 自动换行ToolStripMenuItem.Click
        RichTextBox.WordWrap = Not RichTextBox.WordWrap
    End Sub
    '2.字色
    Private Sub 字色ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 字色ToolStripMenuItem.Click
        Me.FontColorDialog.ShowDialog()
        Me.RichTextBox.SelectionColor = Me.FontColorDialog.Color
    End Sub
    '3.字体
    Private Sub 字体ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 字体ToolStripMenuItem.Click
        Me.FontDialog.ShowDialog()
        Me.RichTextBox.SelectionFont = Me.FontDialog.Font
    End Sub
    '4.背景色
    Private Sub 背景色ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 背景色ToolStripMenuItem.Click
        Me.ColorDialog.ShowDialog()
        Me.RichTextBox.SelectionColor = Me.ColorDialog.Color
    End Sub
    '5.透明度
    Private Sub 透明度ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 透明度ToolStripMenuItem.Click
        Transparent.Top = Me.Top + 80
        Transparent.Left = Me.Left + 30
        Transparent.ShowDialog()
    End Sub
    '6.跟随系统皮肤
    Private Sub 跟随系统皮肤ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 跟随系统皮肤ToolStripMenuItem.Click
        If 跟随系统皮肤ToolStripMenuItem.Checked Then
            SkinH_Detach()
        Else
            SkinH_Attach()
        End If
        RichTextBox.Modified = True            '修正重载皮肤后退出无验证的问题
    End Sub
    '7.夜间模式
    Private Sub 夜间模式ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 夜间模式ToolStripMenuItem.Click
        If 夜间模式ToolStripMenuItem.Checked Then
            RichTextBox.BackColor = Color.FromArgb(28, 28, 28)
            RichTextBox.ForeColor = Color.FromArgb(208, 208, 208)
        Else
            RichTextBox.BackColor = Color.White
            RichTextBox.ForeColor = Color.Black
        End If
    End Sub
    '四、帮助
    '1.查看帮助
    Private Sub 查看帮助ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 查看帮助ToolStripMenuItem.Click
        HelpBrowser.ShowDialog()
        'System.Diagnostics.Process.Start("http://dreamcreator108.droppages.com/help")
    End Sub
    '2.反馈意见
    Private Sub 反馈意见ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 反馈意见ToolStripMenuItem.Click
        Feedback.Top = Me.Top + 100
        Feedback.Left = Me.Left + 50
        Feedback.ShowDialog()
    End Sub
    '3.查看讨论
    Private Sub 查看讨论ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 查看讨论ToolStripMenuItem.Click
        DiscussBrowser.ShowDialog()
        'System.Diagnostics.Process.Start("http://dreamcreator108.droppages.com/feedback")
    End Sub
    '4.检查更新
    Private Sub 检查更新ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 检查更新ToolStripMenuItem.Click
        CheckUpdate.Top = Me.Top + 120
        CheckUpdate.Left = Me.Left + 150
        CheckUpdate.ShowDialog()
    End Sub
    '5.关于
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        About.Top = Me.Top + 150
        About.Left = Me.Left + 300
        About.ShowDialog()
    End Sub
    '五、空白处菜单
    '1.剪切
    Private Sub 剪切ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪切ToolStripMenuItem1.Click
        If Me Is Nothing Then Exit Sub
        RichTextBox.Cut()
    End Sub
    '2.复制
    Private Sub 复制ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem1.Click
        If Me Is Nothing Then Exit Sub
        RichTextBox.Copy()
    End Sub
    '3.粘贴
    Private Sub 粘贴ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 粘贴ToolStripMenuItem1.Click
        If Me Is Nothing Then Exit Sub
        RichTextBox.Paste()
    End Sub
    '4.控件可用条件
    Private Sub ContextMenuStrip1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuStrip1.MouseHover
        If RichTextBox.SelectedText <> "" Then
            剪切ToolStripMenuItem1.Enabled = True
            复制ToolStripMenuItem1.Enabled = True
        Else
            剪切ToolStripMenuItem1.Enabled = False
            复制ToolStripMenuItem1.Enabled = False
        End If
    End Sub
End Class
