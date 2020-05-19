<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.SoftwareLabel = New System.Windows.Forms.Label()
        Me.SerialLabel2 = New System.Windows.Forms.Label()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.WebsiteLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(110, 104)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'SoftwareLabel
        '
        Me.SoftwareLabel.AutoSize = True
        Me.SoftwareLabel.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SoftwareLabel.Location = New System.Drawing.Point(149, 12)
        Me.SoftwareLabel.Name = "SoftwareLabel"
        Me.SoftwareLabel.Size = New System.Drawing.Size(50, 25)
        Me.SoftwareLabel.TabIndex = 1
        Me.SoftwareLabel.Text = "简言"
        '
        'SerialLabel2
        '
        Me.SerialLabel2.AutoSize = True
        Me.SerialLabel2.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.SerialLabel2.Location = New System.Drawing.Point(151, 47)
        Me.SerialLabel2.Name = "SerialLabel2"
        Me.SerialLabel2.Size = New System.Drawing.Size(53, 17)
        Me.SerialLabel2.TabIndex = 2
        Me.SerialLabel2.Text = "版本 1.0"
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.AuthorLabel.Location = New System.Drawing.Point(151, 64)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(74, 17)
        Me.AuthorLabel.TabIndex = 3
        Me.AuthorLabel.Text = "作者 Wu"
        '
        'WebsiteLabel
        '
        Me.WebsiteLabel.AutoSize = True
        Me.WebsiteLabel.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.WebsiteLabel.Location = New System.Drawing.Point(151, 90)
        Me.WebsiteLabel.Name = "WebsiteLabel"
        Me.WebsiteLabel.Size = New System.Drawing.Size(138, 17)
        Me.WebsiteLabel.TabIndex = 4
        Me.WebsiteLabel.Text = "Dreamcreator108.com"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("微软雅黑", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(138, 110)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(161, 16)
        Me.EmailLabel.TabIndex = 5
        Me.EmailLabel.Text = "support@dreamcreator108.com"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 148)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.WebsiteLabel)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.SerialLabel2)
        Me.Controls.Add(Me.SoftwareLabel)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "关于"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SoftwareLabel As System.Windows.Forms.Label
    Friend WithEvents SerialLabel2 As System.Windows.Forms.Label
    Friend WithEvents AuthorLabel As System.Windows.Forms.Label
    Friend WithEvents WebsiteLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
End Class
