Imports System.Xml

Public Class New_Diagram


    Private Sub New_Diagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please Enter a Save Location For Your Topology", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
                My.Computer.FileSystem.CreateDirectory(TextBox1.Text & "\" & "Devices")
                My.Computer.FileSystem.CreateDirectory(TextBox1.Text & "\" & "Cables")
                My.Computer.FileSystem.CreateDirectory(TextBox1.Text & "\" & "Interfaces")
                My.Computer.FileSystem.CreateDirectory(TextBox1.Text & "\" & "Exported_Diagrams")
                My.Computer.FileSystem.CreateDirectory(TextBox1.Text & "\" & "Device_Configs")



                Dim settings As New XmlWriterSettings()
                settings.Indent = True

                ' Initialize the XmlWriter.
                Dim XmlWrt As XmlWriter = XmlWriter.Create(TextBox1.Text & "\" & "TopologyPreferences.xml", settings)

                With XmlWrt

                    ' Write the Xml declaration.
                    .WriteStartDocument()

                    ' Write a comment.
                    .WriteComment(TextBox1.Text & "_Config")

                    ' Write the root element.
                    .WriteStartElement("Data")

                    ' Start our first device.
                    .WriteStartElement("Config")

                    ' The device nodes.

                    .WriteStartElement("Background_Color")
                    .WriteString(SystemColors.Info.ToArgb)
                    .WriteEndElement()

                    ' The end of this device.
                    .WriteEndElement()

                    ' Close the XmlTextWriter.
                    .WriteEndDocument()
                    .Close()
                End With


                MessageBox.Show("Your Topology " & TextBox1.Text & " was Successfully Created", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Form1.CurrentTopologyDirectory = TextBox1.Text
                Me.Close()

            Else
                MessageBox.Show("The Topology You are Trying to Create is Invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub New_Diagram_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
    End Sub

End Class