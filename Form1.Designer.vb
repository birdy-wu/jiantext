<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckUpdate
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
        Me.下载更新Button = New System.Windows.Forms.Button()
        Me.当前版本Label = New System.Windows.Forms.Label()
        Me.当前版本号Label = New System.Windows.Forms.Label()
        Me.最新版本Label = New System.Windows.Forms.Label()
        Me.最新版本号Label = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.已是最新Label = New System.Windows.Forms.Label()
        Me.查询状态Label = New System.Windows.Forms.Label()
        Me.最新版功能Label = New System.Windows.Forms.Label()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        '下载更新Button
        '
        Me.下载更新Button.Location = New System.Drawing.Point(52, 106)
        Me.下载更新Button.Name = "下载更新Button"
        Me.下载更新Button.Size = New System.Drawing.Size(75, 23)
        Me.下载更新Button.TabIndex = 0
        Me.下载更新Button.Text = "下载更新"
        Me.下载更新Button.UseVisualStyleBackColor = True
        Me.下载更新Button.Visible = False
        '
        '当前版本Label
        '
        Me.当前版本Label.AutoSize = True
        Me.当前版本Label.Location = New System.Drawing.Point(23, 30)
        Me.当前版本Label.Name = "当前版本Label"
        Me.当前版本Label.Size = New System.Drawing.Size(56, 17)
        Me.当前版本Label.TabIndex = 1
        Me.当前版本Label.Text = "当前版本"
        '
        '当前版本号Label
        '
        Me.当前版本号Label.AutoSize = True
        Me.当前版本号Label.Location = New System.Drawing.Point(104, 30)
        Me.当前版本号Label.Name = "当前版本号Label"
        Me.当前版本号Label.Size = New System.Drawing.Size(25, 17)
        Me.当前版本号Label.TabIndex = 2
        Me.当前版本号Label.Text = "1.0"
        '
        '最新版本Label
        '
        Me.最新版本Label.AutoSize = True
        Me.最新版本Label.Location = New System.Drawing.Point(23, 67)
        Me.最新版本Label.Name = "最新版本Label"
        Me.最新版本Label.Size = New System.Drawing.Size(56, 17)
        Me.最新版本Label.TabIndex = 3
        Me.最新版本Label.Text = "最新版本"
        '
        '最新版本号Label
        '
        Me.最新版本号Label.AutoSize = True
        Me.最新版本号Label.Location = New System.Drawing.Point(104, 67)
        Me.最新版本号Label.Name = "最新版本号Label"
        Me.最新版本号Label.Size = New System.Drawing.Size(65, 17)
        Me.最新版本号Label.TabIndex = 4
        Me.最新版本号Label.Text = "正在查询..."
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.已是最新Label)
        Me.GroupBox.Controls.Add(Me.查询状态Label)
        Me.GroupBox.Controls.Add(Me.下载更新Button)
        Me.GroupBox.Controls.Add(Me.当前版本号Label)
        Me.GroupBox.Controls.Add(Me.最新版本Label)
        Me.GroupBox.Controls.Add(Me.最新版本号Label)
        Me.GroupBox.Controls.Add(Me.当前版本Label)
        Me.GroupBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(200, 151)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "版本号"
        '
        '已是最新Label
        '
        Me.已是最新Label.AutoSize = True
        Me.已是最新Label.Location = New System.Drawing.Point(40, 109)
        Me.已是最新Label.Name = "已是最新Label"
        Me.已是最新Label.Size = New System.Drawing.Size(104, 17)
        Me.已是最新Label.TabIndex = 6
        Me.已是最新Label.Text = "简言已是最新版本"
        Me.已是最新Label.Visible = False
        '
        '查询状态Label
        '
        Me.查询状态Label.AutoSize = True
        Me.查询状态Label.Location = New System.Drawing.Point(32, 109)
        Me.查询状态Label.Name = "查询状态Label"
        Me.查询状态Label.Size = New System.Drawing.Size(137, 17)
        Me.查询状态Label.TabIndex = 5
        Me.查询状态Label.Text = "正在检查是否有新版本..."
        '
        '最新版功能Label
        '
        Me.最新版功能Label.AutoSize = True
        Me.最新版功能Label.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.最新版功能Label.Location = New System.Drawing.Point(238, 21)
        Me.最新版功能Label.Name = "最新版功能Label"
        Me.最新版功能Label.Size = New System.Drawing.Size(80, 17)
        Me.最新版功能Label.TabIndex = 6
        Me.最新版功能Label.Text = "最新版功能："
        '
        'RichTextBox
        '
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox.Enabled = False
        Me.RichTextBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RichTextBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RichTextBox.Location = New System.Drawing.Point(241, 41)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(144, 131)
        Me.RichTextBox.TabIndex = 7
        Me.RichTextBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "           正在加载..."
        '
        'CheckUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 192)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.最新版功能Label)
        Me.Controls.Add(Me.GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "检查更新"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 下载更新Button As System.Windows.Forms.Button
    Friend WithEvents 当前版本Label As System.Windows.Forms.Label
    Friend WithEvents 当前版本号Label As System.Windows.Forms.Label
    Friend WithEvents 最新版本Label As System.Windows.Forms.Label
    Friend WithEvents 最新版本号Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents 查询状态Label As System.Windows.Forms.Label
    Friend WithEvents 最新版功能Label As System.Windows.Forms.Label
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents 已是最新Label As System.Windows.Forms.Label
End Class
