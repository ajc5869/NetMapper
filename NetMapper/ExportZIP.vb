Public Class ExportZIP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) And Not String.IsNullOrWhiteSpace(TextBox2.Text) Then
            If Not My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".zip") Then
                Me.Cursor = Cursors.WaitCursor
                Dim Export_ZIP As ProcessStartInfo = New ProcessStartInfo
                Dim start As Process = New Process
                Export_ZIP.CreateNoWindow = True
                Export_ZIP.WindowStyle = ProcessWindowStyle.Hidden

                Export_ZIP.FileName = "C:\Program Files\NetMapper\7z.exe"
                Export_ZIP.Arguments = "a " + TextBox1.Text + "\" + TextBox2.Text + ".zip" + " " + Form1.CurrentTopologyDirectory
                Export_ZIP.UseShellExecute = False
                start = Process.Start(Export_ZIP)
                start.WaitForExit()
                'Threading.Thread.Sleep(3000)
                Me.Cursor = Cursors.Default


                If My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".zip") Then
                    MessageBox.Show("'" & TextBox2.Text & ".zip' was successfully exported to " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There was an error exporting your file. Please try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                Dim result As Integer = MessageBox.Show("'" & TextBox2.Text & ".zip' already exists in " & TextBox1.Text & ". Would you like to overwrite the file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor
                    My.Computer.FileSystem.DeleteFile(TextBox1.Text & "\" & TextBox2.Text & ".zip")
                    Dim Export_ZIP As ProcessStartInfo = New ProcessStartInfo
                    Dim start As Process = New Process
                    Export_ZIP.CreateNoWindow = True
                    Export_ZIP.WindowStyle = ProcessWindowStyle.Hidden

                    Export_ZIP.FileName = "C:\Program Files\NetMapper\7z.exe"
                    Export_ZIP.Arguments = "a " + TextBox1.Text + "\" + TextBox2.Text + ".zip" + " " + Form1.CurrentTopologyDirectory
                    Export_ZIP.UseShellExecute = False
                    start = Process.Start(Export_ZIP)
                    start.WaitForExit()
                    'Threading.Thread.Sleep(3000)
                    Me.Cursor = Cursors.Default

                    If My.Computer.FileSystem.FileExists(TextBox1.Text & "\" & TextBox2.Text & ".zip") Then
                        MessageBox.Show("'" & TextBox2.Text & ".zip' was successfully exported to " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub ExportZIP_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub ExportZIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
        TextBox1.Text = Form1.CurrentTopologyDirectory & "\" & "Exported_Diagrams"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class