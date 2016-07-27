Imports System.Net.Mail

Public Class Feedback

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = RITHubMain.TextBox1.Text + "@rit.edu"
    End Sub

    Private Sub determinecheckstatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, RichTextBox1.TextChanged
        Dim text_thingy As String = String.Empty

        If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
            text_thingy += "Checkbox Comments:"
        End If

        If CheckBox1.Checked = True Then
            text_thingy += Environment.NewLine
            text_thingy += "* This Software Rocks!"
        End If
        If CheckBox2.Checked = True Then
            text_thingy += Environment.NewLine
            text_thingy += "* This Software Sucks!"
        End If
        If CheckBox3.Checked = True Then
            text_thingy += Environment.NewLine
            text_thingy += "* I Would Like to Contribute to this Project"
        End If
        RichTextBox2.Text = text_thingy
        RichTextBox3.Text = "User Comments:" & Environment.NewLine & RichTextBox1.Text & Environment.NewLine & Environment.NewLine & RichTextBox2.Text
        RichTextBox4.Text = "User Comments: " & Environment.NewLine & "* None" & Environment.NewLine & Environment.NewLine & RichTextBox2.Text
        RichTextBox5.Text = "User Comments:" & Environment.NewLine & RichTextBox1.Text & Environment.NewLine & Environment.NewLine & "Checkbox Comments:" & Environment.NewLine & "* None"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'THIS METHOD OF FEEDBACK IS INSECURE!! PLAIN TEXT PASSWORDS WOULD BE IN CODE!! SECURITY RISK!! NEED TO USE ANOTHER METHOD OF PROVIDING FEEDBACK!! AHH!
        Dim Mail As New MailMessage
        If RichTextBox1.Text = "" And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MessageBox.Show("To Submit Feedback Please Fill in At Least One of The Above Forms", "Forms Not Filled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Mail.Subject = "Feedback from: " & TextBox1.Text & ", IP:" & System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).GetValue(0).ToString() & ", Hostname:" & My.Computer.Name
                Mail.To.Add("email@email.com")
                Mail.From = New MailAddress("email@email.com")
                If RichTextBox1.Text = "" And RichTextBox2.Text <> "" Then
                    Mail.Body = RichTextBox4.Text
                End If

                If RichTextBox1.Text <> "" And RichTextBox2.Text = "" Then
                    Mail.Body = RichTextBox5.Text
                End If

                If RichTextBox1.Text <> "" And RichTextBox2.Text <> "" Then
                    Mail.Body = RichTextBox3.Text
                End If


                Dim SMTP As New SmtpClient("smtp.mail.com")
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("username", "password")
                SMTP.Port = "587"
                SMTP.Send(Mail)
                MessageBox.Show("Your Email Was Successfully Sent. Thank You For Your Feedback!", "Feedback Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Your Email Was Not Successfully Sent. Please Check Your Internet Connection and Try Again.", "Feedback Not Sent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
End Class