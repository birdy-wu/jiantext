<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(29, 212)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(284, 23)
        Me.WebBrowser.TabIndex = 0
        Me.WebBrowser.Visible = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(74, 18)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.UsernameTextBox.TabIndex = 1
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(250, 18)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(157, 23)
        Me.EmailTextBox.TabIndex = 2
        '
        'RichTextBox
        '
        Me.RichTextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox.Location = New System.Drawing.Point(29, 50)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(378, 142)
        Me.RichTextBox.TabIndex = 3
        Me.RichTextBox.Text = ""
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(26, 18)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(32, 17)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "昵称"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(197, 18)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 17)
        Me.EmailLabel.TabIndex = 5
        Me.EmailLabel.Text = "邮箱"
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(332, 212)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "提交"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 252)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(437, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel.Text = "状态栏"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(332, 213)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "退出"
        Me.ExitButton.UseVisualStyleBackColor = True
        Me.ExitButton.Visible = False
        '
        'Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 274)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.WebBrowser)
        Me.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Feedback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "提交反馈"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
