<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Charexc
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
        Me.CharexcTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CharexcTextBox
        '
        Me.CharexcTextBox.Location = New System.Drawing.Point(12, 36)
        Me.CharexcTextBox.Name = "CharexcTextBox"
        Me.CharexcTextBox.Size = New System.Drawing.Size(227, 23)
        Me.CharexcTextBox.TabIndex = 1
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(85, 82)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "确定"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Charexc
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 126)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CharexcTextBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Charexc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "添加例外"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CharexcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
End Class
