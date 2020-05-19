<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transparent
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
        Me.确认Button = New System.Windows.Forms.Button()
        Me.不透明RadioButton = New System.Windows.Forms.RadioButton()
        Me.低透明度RadioButton = New System.Windows.Forms.RadioButton()
        Me.中透明度RadioButton = New System.Windows.Forms.RadioButton()
        Me.高透明度RadioButton = New System.Windows.Forms.RadioButton()
        Me.应用Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '确认Button
        '
        Me.确认Button.Location = New System.Drawing.Point(139, 67)
        Me.确认Button.Name = "确认Button"
        Me.确认Button.Size = New System.Drawing.Size(75, 23)
        Me.确认Button.TabIndex = 5
        Me.确认Button.Text = "确认"
        Me.确认Button.UseVisualStyleBackColor = True
        '
        '不透明RadioButton
        '
        Me.不透明RadioButton.AutoSize = True
        Me.不透明RadioButton.Location = New System.Drawing.Point(34, 31)
        Me.不透明RadioButton.Name = "不透明RadioButton"
        Me.不透明RadioButton.Size = New System.Drawing.Size(59, 16)
        Me.不透明RadioButton.TabIndex = 6
        Me.不透明RadioButton.TabStop = True
        Me.不透明RadioButton.Text = "不透明"
        Me.不透明RadioButton.UseVisualStyleBackColor = True
        '
        '低透明度RadioButton
        '
        Me.低透明度RadioButton.AutoSize = True
        Me.低透明度RadioButton.Checked = True
        Me.低透明度RadioButton.Location = New System.Drawing.Point(139, 31)
        Me.低透明度RadioButton.Name = "低透明度RadioButton"
        Me.低透明度RadioButton.Size = New System.Drawing.Size(71, 16)
        Me.低透明度RadioButton.TabIndex = 7
        Me.低透明度RadioButton.TabStop = True
        Me.低透明度RadioButton.Text = "低透明度"
        Me.低透明度RadioButton.UseVisualStyleBackColor = True
        '
        '中透明度RadioButton
        '
        Me.中透明度RadioButton.AutoSize = True
        Me.中透明度RadioButton.Location = New System.Drawing.Point(254, 31)
        Me.中透明度RadioButton.Name = "中透明度RadioButton"
        Me.中透明度RadioButton.Size = New System.Drawing.Size(71, 16)
        Me.中透明度RadioButton.TabIndex = 8
        Me.中透明度RadioButton.TabStop = True
        Me.中透明度RadioButton.Text = "中透明度"
        Me.中透明度RadioButton.UseVisualStyleBackColor = True
        '
        '高透明度RadioButton
        '
        Me.高透明度RadioButton.AutoSize = True
        Me.高透明度RadioButton.Location = New System.Drawing.Point(370, 31)
        Me.高透明度RadioButton.Name = "高透明度RadioButton"
        Me.高透明度RadioButton.Size = New System.Drawing.Size(71, 16)
        Me.高透明度RadioButton.TabIndex = 9
        Me.高透明度RadioButton.TabStop = True
        Me.高透明度RadioButton.Text = "高透明度"
        Me.高透明度RadioButton.UseVisualStyleBackColor = True
        '
        '应用Button
        '
        Me.应用Button.Location = New System.Drawing.Point(254, 67)
        Me.应用Button.Name = "应用Button"
        Me.应用Button.Size = New System.Drawing.Size(75, 23)
        Me.应用Button.TabIndex = 10
        Me.应用Button.Text = "应用"
        Me.应用Button.UseVisualStyleBackColor = True
        '
        'Transparent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 115)
        Me.Controls.Add(Me.应用Button)
        Me.Controls.Add(Me.高透明度RadioButton)
        Me.Controls.Add(Me.中透明度RadioButton)
        Me.Controls.Add(Me.低透明度RadioButton)
        Me.Controls.Add(Me.不透明RadioButton)
        Me.Controls.Add(Me.确认Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transparent"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "更改透明度"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 确认Button As System.Windows.Forms.Button
    Friend WithEvents 不透明RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents 低透明度RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents 中透明度RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents 高透明度RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents 应用Button As System.Windows.Forms.Button
End Class
