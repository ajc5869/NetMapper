Public Class Preferences

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.WelcomeScreen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.WelcomeScreen = CheckBox1.Checked
        Me.Close()
    End Sub
End Class