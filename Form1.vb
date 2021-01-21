Public Class Form1
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lblMsg.Text = "Welcome to Visual Basic!"
        If lblMsg.Visible = True Then
            lblMsg.Visible = False
        ElseIf lblMsg.visible = False Then
            lblMsg.Visible = True
        End If
    End Sub
End Class
