Public Class Welcome_Begin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Open_Diagram.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        New_Diagram.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Welcome_Begin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.WelcomeScreen
    End Sub

    Private Sub Welcome_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Settings.WelcomeScreen = CheckBox1.Checked()
    End Sub

End Class