Public Class ExportBMP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) And Not String.IsNullOrWhiteSpace(TextBox2.Text) Then

            If Not My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".bmp") Then
                Dim DiagramExport As New Bitmap(Form1.Panel1.Width, Form1.Panel1.Height)
                Form1.Panel1.DrawToBitmap(DiagramExport, Form1.Panel1.ClientRectangle)
                DiagramExport.Save(TextBox1.Text & "\" & TextBox2.Text & ".bmp")

                If My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".bmp") Then
                    MessageBox.Show("'" & TextBox2.Text & ".bmp' was successfully exported to " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There was an error exporting your file. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim result As Integer = MessageBox.Show("'" & TextBox2.Text & ".bmp' already exists in " & TextBox1.Text & ". Would you like to overwrite the file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Dim DiagramExport As New Bitmap(Form1.Panel1.Width, Form1.Panel1.Height)
                    Form1.Panel1.DrawToBitmap(DiagramExport, Form1.Panel1.ClientRectangle)
                    DiagramExport.Save(TextBox1.Text & "\" & TextBox2.Text & ".bmp")

                    If My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".bmp") Then
                        MessageBox.Show("'" & TextBox2.Text & ".bmp' was successfully exported to " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("There was an error exporting your file. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End If
            End If
        Else
            MessageBox.Show("Please Enter a Filename and Destination", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub ExportBMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
        TextBox1.Text = Form1.CurrentTopologyDirectory & "\" & "Exported_Diagrams"
    End Sub

    Private Sub ExportBMP_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class