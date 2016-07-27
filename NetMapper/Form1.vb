Imports System.IO
Imports System.Xml

Public Class Form1

    Public MousePanelPositionX As Integer
    Public MousePanelPositionY As Integer
    Public TypeOfDeviceAdded As String
    Public TypeOfDeviceToLoadInDeviceConfig As String
    Public MainFormTitle As String
    Public CurrentTopologyDirectory As String
    Public CurrentAddedDeviceImage As String
    Public CurrentSelectedDeviceName As String
    Public CurrentSelectedDeviceNameNoBMPExtension As String
    Public GetDeviceButtonText As String
    Public CurrentAddedDeviceXML As String
    Public CurrentSelectedDeviceXMLNoExten As String

    Public SAVED_EITMS_ID As String
    Public SAVED_Row_Rack As String
    Public SAVED_Telnet_Info As String
    Public SAVED_C_Name As String
    Public SAVED_Hostname As String
    Public X_Y_COORDINATE As Integer

    Dim offset As Point
    Dim point As New Point


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open_Diagram.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.DoubleBuffered = True
        If My.Settings.WelcomeScreen = False Then
            Welcome_Begin.ShowDialog()
        Else
            Return
        End If

        GetDeviceButtonText = ""
        MainFormTitle = Me.Text
        Me.AllowDrop = True
        Panel1.AutoScroll = True
        Panel2.AutoScroll = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim RouterPicBox As New PictureBox
        RouterPicBox.Image = Image.FromFile("C:\Program Files\NetMapper\Device_Icons\Router_Icon.jpg")

        RouterPicBox.Visible = True
        Panel1.Controls.Add(RouterPicBox)
    End Sub

    'Obtains the X and Y coordinates of the mouse pointer in the panel.
    'Private Sub Panel1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
    '    TextBox1.Text = e.X
    '    TextBox2.Text = e.Y
    'End Sub


    'Obtains the X and Y coordinates of the mouse pointer in the panel after a mouse button down event.
    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        CurrentSelectedDeviceName = ""
        CurrentSelectedDeviceNameNoBMPExtension = ""
        CurrentSelectedDeviceXMLNoExten = ""
        'MsgBox("Hello World!!")
        MousePanelPositionX = e.X
        MousePanelPositionY = e.Y
        'MsgBox("The X Coordinate is " & MousePanelPositionX)
        'MsgBox("The Y Coordinate is " & MousePanelPositionY)
        If Not CurrentAddedDeviceImage = "" Then
            'MsgBox("You are holding onto a device!")
            If Not e.Button = Windows.Forms.MouseButtons.Left Then
                'MsgBox("Discarded Device")
                Me.Cursor.Dispose()
                Me.Cursor = Cursors.Default

                My.Computer.FileSystem.DeleteFile(CurrentTopologyDirectory & "\Devices\" & CurrentAddedDeviceImage)
                'My.Computer.FileSystem.DeleteFile(CurrentTopologyDirectory & "\Device_Configs\" & CurrentAddedDeviceXML)
                CurrentAddedDeviceImage = ""
                CurrentAddedDeviceXML = ""

                SAVED_EITMS_ID = ""
                SAVED_Row_Rack = ""
                SAVED_Telnet_Info = ""
                SAVED_C_Name = ""
                SAVED_Hostname = ""
                TypeOfDeviceToLoadInDeviceConfig = ""
            Else
                Me.Cursor = Cursors.Default
                Dim GoToPoint As Point = New Point(MousePanelPositionX - (Add_Device.PictureBoxHolder.Width / 2), MousePanelPositionY - (Add_Device.PictureBoxHolder.Height / 2))
                Dim DroppedDevice As New PictureBox
                DroppedDevice.Name = CurrentAddedDeviceImage
                AddHandler DroppedDevice.MouseDoubleClick, AddressOf DoubleClickDevice
                AddHandler DroppedDevice.Click, AddressOf GetDeviceName
                AddHandler DroppedDevice.Click, AddressOf RightClickDevice
                AddHandler DroppedDevice.MouseDown, AddressOf picboxMouseDown
                AddHandler DroppedDevice.MouseMove, AddressOf picboxMouseMove
                'AddHandler DroppedDevice.MouseUp, AddressOf picboxMouseUp

                DroppedDevice.Image = Image.FromFile(CurrentTopologyDirectory & "\Devices\" & CurrentAddedDeviceImage)
                DroppedDevice.Visible = True
                DroppedDevice.SizeMode = PictureBoxSizeMode.AutoSize
                DroppedDevice.BorderStyle = BorderStyle.None
                Panel1.Controls.Add(DroppedDevice)
                DroppedDevice.Location = GoToPoint


                Dim settings As New XmlWriterSettings()
                settings.Indent = True

                ' Initialize the XmlWriter.
                Dim XmlWrt As XmlWriter = XmlWriter.Create(CurrentTopologyDirectory & "\Device_Configs\" & SAVED_Hostname & ".xml", settings)

                With XmlWrt

                    ' Write the Xml declaration.
                    .WriteStartDocument()

                    ' Write a comment.
                    .WriteComment(SAVED_Hostname & "_Config")

                    ' Write the root element.
                    .WriteStartElement("Data")

                    ' Start our first device.
                    .WriteStartElement("Device")

                    ' The device nodes.

                    .WriteStartElement("EITMS_ID")
                    .WriteString(SAVED_EITMS_ID)
                    .WriteEndElement()

                    .WriteStartElement("Row_Rack")
                    .WriteString(SAVED_Row_Rack)
                    .WriteEndElement()

                    .WriteStartElement("Telnet_Info")
                    .WriteString(SAVED_Telnet_Info)
                    .WriteEndElement()

                    .WriteStartElement("C_Name")
                    .WriteString(SAVED_C_Name)
                    .WriteEndElement()

                    .WriteStartElement("Hostname")
                    .WriteString(SAVED_Hostname)
                    .WriteEndElement()

                    .WriteStartElement("X_Coordinate")
                    .WriteString(MousePanelPositionX - (Add_Device.PictureBoxHolder.Width / 2))
                    .WriteEndElement()

                    .WriteStartElement("Y_Coordinate")
                    .WriteString(MousePanelPositionY - (Add_Device.PictureBoxHolder.Height / 2))
                    .WriteEndElement()

                    .WriteStartElement("TypeOfDevice")
                    .WriteString(TypeOfDeviceToLoadInDeviceConfig)
                    .WriteEndElement()

                    ' The end of this device.
                    .WriteEndElement()

                    ' Close the XmlTextWriter.
                    .WriteEndDocument()
                    .Close()
                End With

                CurrentAddedDeviceImage = ""
                CurrentAddedDeviceXML = ""
                SAVED_EITMS_ID = ""
                SAVED_Row_Rack = ""
                SAVED_Telnet_Info = ""
                SAVED_C_Name = ""
                SAVED_Hostname = ""
                TypeOfDeviceToLoadInDeviceConfig = ""

            End If
        End If
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        'MsgBox("Hello World!!")
        'MousePanelPositionX = e.X
        'MousePanelPositionY = e.Y
        'MsgBox("The X Coordinate is " & MousePanelPositionX)
        'MsgBox("The Y Coordinate is " & MousePanelPositionY)
    End Sub

    Private Sub Router_Icon_Click(sender As Object, e As EventArgs) Handles Router_Icon.Click
        TypeOfDeviceAdded = Router_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = Router_Icon.Name
        GetDeviceButtonText = Router_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub RouterWFirewall_Icon_Click(sender As Object, e As EventArgs) Handles RouterWFirewall_Icon.Click
        TypeOfDeviceAdded = RouterWFirewall_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = RouterWFirewall_Icon.Name
        GetDeviceButtonText = RouterWFirewall_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub WirelessRouter_Icon_Click(sender As Object, e As EventArgs) Handles WirelessRouter_Icon.Click
        TypeOfDeviceAdded = WirelessRouter_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = WirelessRouter_Icon.Name
        GetDeviceButtonText = WirelessRouter_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub WorkgroupSwitch_Icon_Click(sender As Object, e As EventArgs) Handles WorkgroupSwitch_Icon.Click
        TypeOfDeviceAdded = WorkgroupSwitch_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = WorkgroupSwitch_Icon.Name
        GetDeviceButtonText = WorkgroupSwitch_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Layer3Switch_Icon.Click
        TypeOfDeviceAdded = Layer3Switch_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = Layer3Switch_Icon.Name
        GetDeviceButtonText = Layer3Switch_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Hub_Icon.Click
        TypeOfDeviceAdded = Hub_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = Hub_Icon.Name
        GetDeviceButtonText = Hub_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ASA_Icon.Click
        TypeOfDeviceAdded = ASA_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = ASA_Icon.Name
        GetDeviceButtonText = ASA_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub IPPhone_Icon_Click(sender As Object, e As EventArgs) Handles IPPhone_Icon.Click
        TypeOfDeviceAdded = IPPhone_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = IPPhone_Icon.Name
        GetDeviceButtonText = IPPhone_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub Workstation_Icon_Click(sender As Object, e As EventArgs) Handles Workstation_Icon.Click
        TypeOfDeviceAdded = Workstation_Icon.Name
        TypeOfDeviceToLoadInDeviceConfig = Workstation_Icon.Name
        GetDeviceButtonText = Workstation_Icon.Text
        Add_Device.ShowDialog()
    End Sub

    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click
        ExportBMP.ShowDialog()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        New_Diagram.ShowDialog()
    End Sub

    Public Sub DoubleClickDevice(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Left
                Dim filename As String = CurrentSelectedDeviceNameNoBMPExtension & ".xml"
                Dim telnet_info As String
                Dim doc As New XmlDocument
                doc.Load(CurrentTopologyDirectory & "\Device_Configs\" & filename)
                telnet_info = doc.SelectSingleNode("Data/Device/Telnet_Info").InnerText
                If Not telnet_info = "" Then
                    If Not My.Computer.FileSystem.FileExists("C:\Program Files (x86)\PuTTY\putty.exe") Then
                        MessageBox.Show("Putty must be installed to initiate a telnet session.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim telnet_start As ProcessStartInfo = New ProcessStartInfo
                        Dim start As Process = New Process
                        telnet_start.CreateNoWindow = True
                        telnet_start.WindowStyle = ProcessWindowStyle.Hidden

                        telnet_start.FileName = "C:\Program Files (x86)\PuTTY\putty.exe"
                        telnet_start.Arguments = "telnet://" + telnet_info
                        telnet_start.UseShellExecute = False
                        start = Process.Start(telnet_start)
                    End If
                Else
                    MessageBox.Show("Telnet access for '" & CurrentSelectedDeviceNameNoBMPExtension & "' is not configured", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
        End Select
    End Sub


    Public Sub RightClickDevice(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Select Case e.Button
            Case Windows.Forms.MouseButtons.Right
                Dim pbClicked = CType(sender, PictureBox)

                Dim txt As String = pbClicked.Name.ToString
                CurrentSelectedDeviceName = txt
                CurrentSelectedDeviceNameNoBMPExtension = CurrentSelectedDeviceName.Substring(0, CurrentSelectedDeviceName.Length - 4)
                CurrentSelectedDeviceXMLNoExten = CurrentSelectedDeviceNameNoBMPExtension
                DeviceContextMenu.Show(Control.MousePosition.X, Control.MousePosition.Y)

                'MsgBox("You Right Clicked the Device!")
        End Select
    End Sub


    Public Sub picboxMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim pbClicked = CType(sender, PictureBox)
        offset = New Point(-e.X, -e.Y)
    End Sub


    Public Sub picboxMouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim pbClicked = CType(sender, PictureBox)
        If e.Button = Windows.Forms.MouseButtons.Left Then

            Dim Pos As Point = Me.PointToClient(MousePosition)
            'CurrentSelectedDeviceNameNoBMPExtension = pbClicked.Name
            Pos.Offset(offset.X - 177, offset.Y - 38)
            pbClicked.Location = Pos

            Dim current_selected_name_with_bmp As String
            current_selected_name_with_bmp = pbClicked.Name

            Dim current_selected_name_without_bmp As String
            current_selected_name_without_bmp = current_selected_name_with_bmp.Substring(0, current_selected_name_with_bmp.Length - 4)


            Dim doc As New XmlDocument
            'MsgBox(current_selected_name_without_bmp)
            doc.Load(CurrentTopologyDirectory & "\Device_Configs\" & current_selected_name_without_bmp & ".xml")
            doc.SelectSingleNode("Data/Device/X_Coordinate").InnerText = Pos.X.ToString
            doc.SelectSingleNode("Data/Device/Y_Coordinate").InnerText = Pos.Y.ToString
            doc.Save(CurrentTopologyDirectory & "\Device_Configs\" & current_selected_name_without_bmp & ".xml")

        End If
    End Sub


    Public Sub picboxMouseUp(ByVal senser As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        MsgBox("You moused up!")
    End Sub


    Public Sub GetDeviceName(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim pbClicked = CType(sender, PictureBox)

        Dim txt As String = pbClicked.Name.ToString
        CurrentSelectedDeviceName = txt
        CurrentSelectedDeviceNameNoBMPExtension = CurrentSelectedDeviceName.Substring(0, CurrentSelectedDeviceName.Length - 4)
        CurrentSelectedDeviceXMLNoExten = CurrentSelectedDeviceNameNoBMPExtension
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Current Selected Device Name is:" & CurrentSelectedDeviceName)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim cntrl As PictureBox

        For Each cntrl In Panel1.Controls
            If cntrl.Name = CurrentSelectedDeviceName Then
                cntrl.Image.Dispose()
                cntrl.Dispose()
                My.Computer.FileSystem.DeleteFile(CurrentTopologyDirectory & "\Devices\" & CurrentSelectedDeviceName)
                My.Computer.FileSystem.DeleteFile(CurrentTopologyDirectory & "\Device_Configs\" & CurrentSelectedDeviceXMLNoExten & ".xml")
                CurrentSelectedDeviceName = ""
                CurrentSelectedDeviceNameNoBMPExtension = ""
            End If
        Next
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        MsgBox("Without BMP extension is: " & CurrentSelectedDeviceNameNoBMPExtension)
        MsgBox("Current XML File is:" & CurrentSelectedDeviceXMLNoExten)
    End Sub

    Private Sub TelnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TelnetToolStripMenuItem.Click
        Dim filename As String = CurrentSelectedDeviceNameNoBMPExtension & ".xml"
        Dim telnet_info As String
        Dim doc As New XmlDocument
        doc.Load(CurrentTopologyDirectory & "\Device_Configs\" & filename)
        telnet_info = doc.SelectSingleNode("Data/Device/Telnet_Info").InnerText
        If Not telnet_info = "" Then
            If Not My.Computer.FileSystem.FileExists("C:\Program Files (x86)\PuTTY\putty.exe") Then
                MessageBox.Show("Putty must be installed to initiate a telnet session.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim telnet_start As ProcessStartInfo = New ProcessStartInfo
                Dim start As Process = New Process
                telnet_start.CreateNoWindow = True
                telnet_start.WindowStyle = ProcessWindowStyle.Hidden

                telnet_start.FileName = "C:\Program Files (x86)\PuTTY\putty.exe"
                telnet_start.Arguments = "telnet://" + telnet_info
                telnet_start.UseShellExecute = False
                start = Process.Start(telnet_start)
            End If
        Else
            MessageBox.Show("Telnet access for '" & CurrentSelectedDeviceNameNoBMPExtension & "' is not configured", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ConfigureDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureDeviceToolStripMenuItem.Click
        ConfigureDevice.ShowDialog()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        MsgBox(CurrentSelectedDeviceName)
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Panel1.BackColor = SystemColors.Info

        Dim doc As New XmlDocument

        doc.Load(CurrentTopologyDirectory & "\TopologyPreferences.xml")
        doc.SelectSingleNode("Data/Config/Background_Color").InnerText = Panel1.BackColor.ToArgb
        doc.Save(CurrentTopologyDirectory & "\TopologyPreferences.xml")

    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Panel1.BackColor = Color.Red
        Dim doc As New XmlDocument

        doc.Load(CurrentTopologyDirectory & "\TopologyPreferences.xml")
        doc.SelectSingleNode("Data/Config/Background_Color").InnerText = Panel1.BackColor.ToArgb
        doc.Save(CurrentTopologyDirectory & "\TopologyPreferences.xml")



    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Panel1.BackColor = Color.Blue
        Dim doc As New XmlDocument

        doc.Load(CurrentTopologyDirectory & "\TopologyPreferences.xml")
        doc.SelectSingleNode("Data/Config/Background_Color").InnerText = Panel1.BackColor.ToArgb
        doc.Save(CurrentTopologyDirectory & "\TopologyPreferences.xml")
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Panel1.BackColor = Color.Green
        Dim doc As New XmlDocument

        doc.Load(CurrentTopologyDirectory & "\TopologyPreferences.xml")
        doc.SelectSingleNode("Data/Config/Background_Color").InnerText = Panel1.BackColor.ToArgb
        doc.Save(CurrentTopologyDirectory & "\TopologyPreferences.xml")
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = Panel1.BackColor

        If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Panel1.BackColor = colorDialog.Color
        End If
        Dim doc As New XmlDocument

        doc.Load(CurrentTopologyDirectory & "\TopologyPreferences.xml")
        doc.SelectSingleNode("Data/Config/Background_Color").InnerText = Panel1.BackColor.ToArgb
        doc.Save(CurrentTopologyDirectory & "\TopologyPreferences.xml")
    End Sub

    Private Sub AboutNetMapperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNetMapperToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub SubmitFeedbackBugReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitFeedbackBugReportToolStripMenuItem.Click
        Feedback.ShowDialog()
    End Sub

    Private Sub ZIPFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZIPFileToolStripMenuItem.Click
        ExportZIP.ShowDialog()
    End Sub
End Class
