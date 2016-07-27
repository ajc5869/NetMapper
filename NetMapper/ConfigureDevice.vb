Imports System.Xml

Public Class ConfigureDevice

    Public ImportedXVal As String
    Public ImportedYVal As String
    Public BeforeHostnameEdit As String
    Public BeforeEITMSEdit As String
    Public BeforeRowRackEdit As String

    Private Sub ConfigureDevice_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Hostname_Label.Text = ""
        EITMS_Rack_Row_Label.Text = ""
    End Sub

    Private Sub ConfigureDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Form1.CurrentSelectedDeviceNameNoBMPExtension & " Configuration"

        Dim filename As String = Form1.CurrentSelectedDeviceNameNoBMPExtension & ".xml"
        Dim doc As New XmlDocument
        doc.Load(Form1.CurrentTopologyDirectory & "\Device_Configs\" & filename)
        BeforeHostnameEdit = doc.SelectSingleNode("Data/Device/Hostname").InnerText
        BeforeEITMSEdit = doc.SelectSingleNode("Data/Device/EITMS_ID").InnerText
        BeforeRowRackEdit = doc.SelectSingleNode("Data/Device/Row_Rack").InnerText


        Dim document As XmlReader = New XmlTextReader(Form1.CurrentTopologyDirectory & "\Device_Configs\" & Form1.CurrentSelectedDeviceNameNoBMPExtension & ".xml")
        While (document.Read())

            Dim type = document.NodeType

            If (type = XmlNodeType.Element) Then

                If (document.Name = "EITMS_ID") Then
                    TextBox1.Text = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "Row_Rack") Then
                    TextBox2.Text = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "Telnet_Info") Then
                    TextBox3.Text = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "C_Name") Then
                    TextBox4.Text = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "Hostname") Then
                    TextBox5.Text = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "X_Coordinate") Then
                    ImportedXVal = document.ReadInnerXml.ToString()
                End If


                If (document.Name = "Y_Coordinate") Then
                    ImportedYVal = document.ReadInnerXml.ToString()
                End If



                If (document.Name = "TypeOfDevice") Then
                    Form1.TypeOfDeviceToLoadInDeviceConfig = document.ReadInnerXml.ToString()
                End If

            End If
        End While
        document.Close()


        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = ""
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.Text = ""
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            TextBox3.Text = ""
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            TextBox4.Text = ""
        End If



        Hostname_Label.Text = TextBox5.Text
        EITMS_Rack_Row_Label.Text = TextBox2.Text & "-" & TextBox1.Text
        PictureBoxHolder.SendToBack()
        PictureBoxHolder.BackColor = Color.LightBlue
        Panel1.BackColor = Color.White
        'MsgBox("C:\Program Files\NetMapper\Device_Icons\" & Form1.TypeOfDeviceToLoadInDeviceConfig & ".jpg")
        PictureBox1.Image = Image.FromFile("C:\Program Files\NetMapper\Device_Icons\" & Form1.TypeOfDeviceToLoadInDeviceConfig & ".jpg")
        PictureBoxHolder.SendToBack()
        TextBox1.Select()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please Enter a Hostname", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If TextBox5.Text = BeforeHostnameEdit Then
                'MsgBox("Names are the same!")
                Dim settings As New XmlWriterSettings()
                settings.Indent = True
                Dim XmlWrt As XmlWriter = XmlWriter.Create(Form1.CurrentTopologyDirectory & "\Device_Configs\" & Form1.CurrentSelectedDeviceNameNoBMPExtension & ".xml", settings)

                With XmlWrt

                    ' Write the Xml declaration.
                    .WriteStartDocument()

                    ' Write a comment.
                    .WriteComment(Form1.CurrentSelectedDeviceNameNoBMPExtension & "_Config")

                    ' Write the root element.
                    .WriteStartElement("Data")

                    ' Start our first device.
                    .WriteStartElement("Device")

                    ' The device nodes.

                    .WriteStartElement("EITMS_ID")
                    .WriteString(TextBox1.Text)
                    .WriteEndElement()

                    .WriteStartElement("Row_Rack")
                    .WriteString(TextBox2.Text)
                    .WriteEndElement()

                    .WriteStartElement("Telnet_Info")
                    .WriteString(TextBox3.Text)
                    .WriteEndElement()

                    .WriteStartElement("C_Name")
                    .WriteString(TextBox4.Text)
                    .WriteEndElement()

                    .WriteStartElement("Hostname")
                    .WriteString(TextBox5.Text)
                    .WriteEndElement()

                    .WriteStartElement("X_Coordinate")
                    .WriteString(ImportedXVal)
                    .WriteEndElement()

                    .WriteStartElement("Y_Coordinate")
                    .WriteString(ImportedYVal)
                    .WriteEndElement()

                    .WriteStartElement("TypeOfDevice")
                    .WriteString(Form1.TypeOfDeviceToLoadInDeviceConfig)
                    .WriteEndElement()

                    ' The end of this device.
                    .WriteEndElement()

                    ' Close the XmlTextWriter.
                    .WriteEndDocument()
                    .Close()
                End With
                ''''''Do it!!!!''''''
                Dim originalImage As PictureBox
                For Each originalImage In Form1.Panel1.Controls
                    'MsgBox(cntrl.Name)
                    If originalImage.Name = BeforeHostnameEdit & ".bmp" Then


                        Dim ExportedDeviceImage As New Bitmap(PictureBoxHolder.Width, PictureBoxHolder.Height)
                        PictureBoxHolder.DrawToBitmap(ExportedDeviceImage, PictureBoxHolder.ClientRectangle)
                        originalImage.Image.Dispose()
                        ExportedDeviceImage.Save(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")


                        'My.Computer.FileSystem.CopyFile(Form1.CurrentTopologyDirectory & "\Devices\" & originalImage.Name, Form1.CurrentTopologyDirectory & "\Devices\temp.bmp")
                        'originalImage.Image.Dispose()
                        'MsgBox(BeforeHostnameEdit)
                        'My.Computer.FileSystem.DeleteFile(Form1.CurrentTopologyDirectory & "\Devices\" & BeforeHostnameEdit & ".bmp")
                        'My.Computer.FileSystem.RenameFile(Form1.CurrentTopologyDirectory & "\Devices\temp.bmp", TextBox5.Text & ".bmp")
                        originalImage.Image = Image.FromFile(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")
                        originalImage.Name = TextBox5.Text & ".bmp"
                    End If
                Next

            Else

                Dim settings As New XmlWriterSettings()
                settings.Indent = True
                Dim XmlWrt As XmlWriter = XmlWriter.Create(Form1.CurrentTopologyDirectory & "\Device_Configs\" & Form1.CurrentSelectedDeviceNameNoBMPExtension & ".xml", settings)

                With XmlWrt

                    ' Write the Xml declaration.
                    .WriteStartDocument()

                    ' Write a comment.
                    .WriteComment(Form1.CurrentSelectedDeviceNameNoBMPExtension & "_Config")

                    ' Write the root element.
                    .WriteStartElement("Data")

                    ' Start our first device.
                    .WriteStartElement("Device")

                    ' The device nodes.

                    .WriteStartElement("EITMS_ID")
                    .WriteString(TextBox1.Text)
                    .WriteEndElement()

                    .WriteStartElement("Row_Rack")
                    .WriteString(TextBox2.Text)
                    .WriteEndElement()

                    .WriteStartElement("Telnet_Info")
                    .WriteString(TextBox3.Text)
                    .WriteEndElement()

                    .WriteStartElement("C_Name")
                    .WriteString(TextBox4.Text)
                    .WriteEndElement()

                    .WriteStartElement("Hostname")
                    .WriteString(TextBox5.Text)
                    .WriteEndElement()

                    .WriteStartElement("X_Coordinate")
                    .WriteString(ImportedXVal)
                    .WriteEndElement()

                    .WriteStartElement("Y_Coordinate")
                    .WriteString(ImportedYVal)
                    .WriteEndElement()

                    .WriteStartElement("TypeOfDevice")
                    .WriteString(Form1.TypeOfDeviceToLoadInDeviceConfig)
                    .WriteEndElement()

                    ' The end of this device.
                    .WriteEndElement()

                    ' Close the XmlTextWriter.
                    .WriteEndDocument()
                    .Close()
                End With
                My.Computer.FileSystem.RenameFile(Form1.CurrentTopologyDirectory & "\Device_Configs\" & Form1.CurrentSelectedDeviceNameNoBMPExtension & ".xml", TextBox5.Text & ".xml")
                ''''''Do it!!!!''''''
                Dim originalImage As PictureBox
                For Each originalImage In Form1.Panel1.Controls
                    'MsgBox(cntrl.Name)
                    If originalImage.Name = BeforeHostnameEdit & ".bmp" Then


                        Dim ExportedDeviceImage As New Bitmap(PictureBoxHolder.Width, PictureBoxHolder.Height)
                        PictureBoxHolder.DrawToBitmap(ExportedDeviceImage, PictureBoxHolder.ClientRectangle)
                        ExportedDeviceImage.Save(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")


                        'My.Computer.FileSystem.CopyFile(Form1.CurrentTopologyDirectory & "\Devices\" & originalImage.Name, Form1.CurrentTopologyDirectory & "\Devices\temp.bmp")
                        originalImage.Image.Dispose()
                        'MsgBox(BeforeHostnameEdit)
                        My.Computer.FileSystem.DeleteFile(Form1.CurrentTopologyDirectory & "\Devices\" & BeforeHostnameEdit & ".bmp")
                        'My.Computer.FileSystem.RenameFile(Form1.CurrentTopologyDirectory & "\Devices\temp.bmp", TextBox5.Text & ".bmp")
                        originalImage.Image = Image.FromFile(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")
                        originalImage.Name = TextBox5.Text & ".bmp"
                    End If
                Next

            End If
            
            Me.Close()
        End If
    End Sub


    Private Sub UpdateHostname(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Hostname_Label.Text = ""
        Hostname_Label.Text = TextBox5.Text
    End Sub

    Private Sub UpdateEITMS_EITMS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        EITMS_Rack_Row_Label.Text = TextBox2.Text & "-" & TextBox1.Text
    End Sub


    Private Sub UpdateEITMS_RackRow(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        EITMS_Rack_Row_Label.Text = TextBox2.Text & "-" & TextBox1.Text
    End Sub

End Class