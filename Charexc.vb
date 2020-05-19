Public Class Charexc
    Public Shared Charexcstr As String
    Private Sub Charexc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CharexcTextBox.Text = Charexcstr
    End Sub
    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Charexcstr = CharexcTextBox.Text
        Me.Close()
    End Sub
End Class