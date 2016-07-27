Imports System.IO
Imports System.Xml

Public Class Open_Diagram

    Private Sub Open_Diagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.ShowNewFolderButton = False
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Open_Diagram_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        TextBox1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please Select a Path To Your Topology", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & "Devices") Or Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & "Cables") Or Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & "Interfaces") Or Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & "Exported_Diagrams") Or Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text & "\" & "Device_Configs") Then
                MessageBox.Show("The Directory You Have Chosen is Not A Valid Topology Directory", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim panelControl As System.Windows.Forms.Control
                For Each panelControl In Form1.Panel1.Controls
                    panelControl.Dispose()
                Next
                Form1.Panel1.Controls.Clear()

                Form1.CurrentTopologyDirectory = TextBox1.Text
                Form1.MainFormTitle = "NetMapper: " & TextBox1.Text
                Form1.Text = Form1.MainFormTitle
                Form1.ExportToolStripMenuItem.Visible = True
                Form1.ViewToolStripMenuItem.Visible = True
                Me.Close()

                Dim files() As String = IO.Directory.GetFiles(Form1.CurrentTopologyDirectory & "\Devices")

                For Each file As String In files

                    Dim filename As String = Path.GetFileNameWithoutExtension(file.ToString)
                    Dim doc As New XmlDocument
                    doc.Load(Form1.CurrentTopologyDirectory & "\Device_Configs\" & filename & ".xml")
                    Dim X_Coor As String = doc.SelectSingleNode("Data/Device/X_Coordinate").InnerText
                    Dim Y_Coor As String = doc.SelectSingleNode("Data/Device/Y_Coordinate").InnerText


                    Dim GoToPoint As Point = New Point(X_Coor, Y_Coor)
                    Dim DroppedDevice As New PictureBox
                    DroppedDevice.Name = filename & ".bmp"
                    AddHandler DroppedDevice.MouseDoubleClick, AddressOf Form1.DoubleClickDevice
                    'AddHandler DroppedDevice.Click, AddressOf Form1.GetDeviceName
                    AddHandler DroppedDevice.MouseDown, AddressOf Form1.RightClickDevice
                    AddHandler DroppedDevice.MouseDown, AddressOf Form1.picboxMouseDown
                    AddHandler DroppedDevice.MouseMove, AddressOf Form1.picboxMouseMove



                    DroppedDevice.Image = Image.FromFile(Form1.CurrentTopologyDirectory & "\Devices\" & filename & ".bmp")
                    DroppedDevice.Visible = True
                    DroppedDevice.SizeMode = PictureBoxSizeMode.AutoSize
                    DroppedDevice.BorderStyle = BorderStyle.None
                    'MsgBox("Device:" & DroppedDevice.Name & " was added at position:" & X_Coor & ":" & Y_Coor)
                    Form1.Panel1.Controls.Add(DroppedDevice)

                    DroppedDevice.Location = GoToPoint
                Next

                Form1.Router_Icon.Enabled = True
                Form1.RouterWFirewall_Icon.Enabled = True
                Form1.WirelessRouter_Icon.Enabled = True
                Form1.WorkgroupSwitch_Icon.Enabled = True
                Form1.Layer3Switch_Icon.Enabled = True
                Form1.Hub_Icon.Enabled = True
                Form1.ASA_Icon.Enabled = True
                Form1.IPPhone_Icon.Enabled = True
                Form1.Workstation_Icon.Enabled = True


                Dim topo_preferences As New XmlDocument
                topo_preferences.Load(Form1.CurrentTopologyDirectory & "\TopologyPreferences.xml")

                Form1.Panel1.BackColor = Color.FromArgb(topo_preferences.SelectSingleNode("Data/Config/Background_Color").InnerText)

            End If
        End If

    End Sub
End Class