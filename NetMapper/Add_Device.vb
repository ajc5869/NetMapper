Imports System.IO
Imports System.Xml

Public Class Add_Device
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If String.IsNullOrWhiteSpace(TextBox1.Text) Then
        '    MessageBox.Show("Please Enter the EITMS ID for Item You Wish to Add" & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    If String.IsNullOrWhiteSpace(TextBox5.Text) Then
        '        MessageBox.Show("Please Enter a Hostname for Item " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        Me.Close()
        '    End If
        'End If


        If String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please Enter a Hostname", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If My.Computer.FileSystem.FileExists(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp") Then
                MessageBox.Show("A Device with the Hostname '" & TextBox5.Text & "' Already Exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dim DevicePicBoxFinal As New PictureBox
                Dim ExportedDeviceImage As New Bitmap(PictureBoxHolder.Width, PictureBoxHolder.Height)
                Dim GoToPoint As Point = New Point(Form1.MousePanelPositionX, Form1.MousePanelPositionY)
                PictureBoxHolder.DrawToBitmap(ExportedDeviceImage, PictureBoxHolder.ClientRectangle)
                ExportedDeviceImage.Save(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")

                Form1.SAVED_EITMS_ID = TextBox1.Text
                Form1.SAVED_Row_Rack = TextBox2.Text
                Form1.SAVED_Telnet_Info = TextBox3.Text
                Form1.SAVED_C_Name = TextBox4.Text
                Form1.SAVED_Hostname = TextBox5.Text

                'DevicePicBoxFinal.Image = Image.FromFile(Form1.CurrentTopologyDirectory & "\Devices\" & TextBox5.Text & ".bmp")
                'DevicePicBoxFinal.Visible = True
                'DevicePicBoxFinal.SizeMode = PictureBoxSizeMode.AutoSize
                'DevicePicBoxFinal.BorderStyle = BorderStyle.None
                Form1.CurrentAddedDeviceImage = TextBox5.Text & ".bmp"
                Form1.CurrentAddedDeviceXML = TextBox5.Text & ".xml"
                Me.Close()


                Dim g As Graphics = Graphics.FromImage(ExportedDeviceImage)

                Dim ptrCur As IntPtr = ExportedDeviceImage.GetHicon
                Dim cur As Cursor
                cur = New Cursor(ptrCur)

                Form1.Cursor = cur
                ExportedDeviceImage.Dispose()

                'Form1.Cursor = Cursors.Cross
            End If
        End If
        'Form1.Panel1.Controls.Add(DevicePicBoxFinal)
        'DevicePicBoxFinal.Location = GoToPoint


    End Sub

    Private Sub Add_Device_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        Me.Text = "Add " & Form1.GetDeviceButtonText & " to Topology"
        PictureBoxHolder.SendToBack()
        PictureBoxHolder.BackColor = Color.LightBlue
        Panel1.BackColor = Color.White
        PictureBox1.Image = Image.FromFile("C:\Program Files\NetMapper\Device_Icons\" & Form1.TypeOfDeviceAdded & ".jpg")
        PictureBoxHolder.SendToBack()
        Hostname_Label.Text = ""
        EITMS_Rack_Row_Label.Text = TextBox2.Text & "-" & TextBox1.Text
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please Enter the EITMS ID to Retrieve Device Information " & TextBox1.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        EITMS_Rack_Row_Label.Text = TextBox2.Text & "-" & TextBox1.Text
    End Sub

    Private Sub Add_Class_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Hostname_Label.Text = ""
        EITMS_Rack_Row_Label.Text = ""
        Form1.GetDeviceButtonText = ""
        'Form1.TypeOfDeviceToLoadInDeviceConfig = ""
    End Sub
End Class