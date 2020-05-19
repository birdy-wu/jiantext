Public Class Transparent
    Dim preopa As Double
    Dim opa As Double = Main.Opacity
    Private Sub 不透明RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 不透明RadioButton.CheckedChanged
        preopa = 1
    End Sub
    Private Sub 低透明度RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 低透明度RadioButton.CheckedChanged
        preopa = 0.95
    End Sub

    Private Sub 中透明度RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 中透明度RadioButton.CheckedChanged
        preopa = 0.9
    End Sub
    Private Sub 高透明度RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 高透明度RadioButton.CheckedChanged
        preopa = 0.85
    End Sub
    Private Sub 应用Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 应用Button.Click
        Main.Opacity = preopa
    End Sub
    Private Sub 确认Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 确认Button.Click
        opa = preopa
        Me.Close()
    End Sub
    Private Sub Transparent_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Main.Opacity = opa
    End Sub
End Class