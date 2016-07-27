<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZIPFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitFeedbackBugReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNetMapperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ASA_Icon = New System.Windows.Forms.Button()
        Me.Layer3Switch_Icon = New System.Windows.Forms.Button()
        Me.Workstation_Icon = New System.Windows.Forms.Button()
        Me.WorkgroupSwitch_Icon = New System.Windows.Forms.Button()
        Me.Hub_Icon = New System.Windows.Forms.Button()
        Me.IPPhone_Icon = New System.Windows.Forms.Button()
        Me.WirelessRouter_Icon = New System.Windows.Forms.Button()
        Me.RouterWFirewall_Icon = New System.Windows.Forms.Button()
        Me.Router_Icon = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeviceContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfigureDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TelnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddInterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.DeviceContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.NewToolStripMenuItem, Me.ExportToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.OpenToolStripMenuItem.Text = "Open Topology"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NewToolStripMenuItem.Text = "New Topology"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZIPFileToolStripMenuItem, Me.BMPToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExportToolStripMenuItem.Text = "Export To"
        Me.ExportToolStripMenuItem.Visible = False
        '
        'ZIPFileToolStripMenuItem
        '
        Me.ZIPFileToolStripMenuItem.Name = "ZIPFileToolStripMenuItem"
        Me.ZIPFileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ZIPFileToolStripMenuItem.Text = "ZIP File"
        '
        'BMPToolStripMenuItem
        '
        Me.BMPToolStripMenuItem.Name = "BMPToolStripMenuItem"
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BMPToolStripMenuItem.Text = "BMP"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        Me.ViewToolStripMenuItem.Visible = False
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.RedToolStripMenuItem, Me.GreenToolStripMenuItem, Me.BlueToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.SubmitFeedbackBugReportToolStripMenuItem, Me.AboutNetMapperToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.HelpToolStripMenuItem1.Text = "NetMapper Help"
        '
        'SubmitFeedbackBugReportToolStripMenuItem
        '
        Me.SubmitFeedbackBugReportToolStripMenuItem.Name = "SubmitFeedbackBugReportToolStripMenuItem"
        Me.SubmitFeedbackBugReportToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SubmitFeedbackBugReportToolStripMenuItem.Text = "Submit Feedback"
        '
        'AboutNetMapperToolStripMenuItem
        '
        Me.AboutNetMapperToolStripMenuItem.Name = "AboutNetMapperToolStripMenuItem"
        Me.AboutNetMapperToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutNetMapperToolStripMenuItem.Text = "About NetMapper"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Location = New System.Drawing.Point(177, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 510)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ASA_Icon)
        Me.Panel2.Controls.Add(Me.Layer3Switch_Icon)
        Me.Panel2.Controls.Add(Me.Workstation_Icon)
        Me.Panel2.Controls.Add(Me.WorkgroupSwitch_Icon)
        Me.Panel2.Controls.Add(Me.Hub_Icon)
        Me.Panel2.Controls.Add(Me.IPPhone_Icon)
        Me.Panel2.Controls.Add(Me.WirelessRouter_Icon)
        Me.Panel2.Controls.Add(Me.RouterWFirewall_Icon)
        Me.Panel2.Controls.Add(Me.Router_Icon)
        Me.Panel2.Location = New System.Drawing.Point(9, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(159, 509)
        Me.Panel2.TabIndex = 3
        '
        'ASA_Icon
        '
        Me.ASA_Icon.Enabled = False
        Me.ASA_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASA_Icon.Image = Global.NetMapper.My.Resources.Resources.cisco_asa_5500
        Me.ASA_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ASA_Icon.Location = New System.Drawing.Point(3, 591)
        Me.ASA_Icon.Name = "ASA_Icon"
        Me.ASA_Icon.Size = New System.Drawing.Size(136, 92)
        Me.ASA_Icon.TabIndex = 5
        Me.ASA_Icon.Text = "ASA"
        Me.ASA_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ASA_Icon.UseVisualStyleBackColor = True
        '
        'Layer3Switch_Icon
        '
        Me.Layer3Switch_Icon.Enabled = False
        Me.Layer3Switch_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Layer3Switch_Icon.Image = Global.NetMapper.My.Resources.Resources.layer_3_switch
        Me.Layer3Switch_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Layer3Switch_Icon.Location = New System.Drawing.Point(3, 395)
        Me.Layer3Switch_Icon.Name = "Layer3Switch_Icon"
        Me.Layer3Switch_Icon.Size = New System.Drawing.Size(136, 92)
        Me.Layer3Switch_Icon.TabIndex = 4
        Me.Layer3Switch_Icon.Text = "Layer 3 Switch"
        Me.Layer3Switch_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Layer3Switch_Icon.UseVisualStyleBackColor = True
        '
        'Workstation_Icon
        '
        Me.Workstation_Icon.Enabled = False
        Me.Workstation_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Workstation_Icon.Image = Global.NetMapper.My.Resources.Resources.workstation
        Me.Workstation_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Workstation_Icon.Location = New System.Drawing.Point(3, 787)
        Me.Workstation_Icon.Name = "Workstation_Icon"
        Me.Workstation_Icon.Size = New System.Drawing.Size(136, 92)
        Me.Workstation_Icon.TabIndex = 5
        Me.Workstation_Icon.Text = "Workstation"
        Me.Workstation_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Workstation_Icon.UseVisualStyleBackColor = True
        '
        'WorkgroupSwitch_Icon
        '
        Me.WorkgroupSwitch_Icon.Enabled = False
        Me.WorkgroupSwitch_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkgroupSwitch_Icon.Image = Global.NetMapper.My.Resources.Resources.workgroup_switch
        Me.WorkgroupSwitch_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WorkgroupSwitch_Icon.Location = New System.Drawing.Point(3, 297)
        Me.WorkgroupSwitch_Icon.Name = "WorkgroupSwitch_Icon"
        Me.WorkgroupSwitch_Icon.Size = New System.Drawing.Size(136, 92)
        Me.WorkgroupSwitch_Icon.TabIndex = 3
        Me.WorkgroupSwitch_Icon.Text = "Layer 2 Switch"
        Me.WorkgroupSwitch_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WorkgroupSwitch_Icon.UseVisualStyleBackColor = True
        '
        'Hub_Icon
        '
        Me.Hub_Icon.Enabled = False
        Me.Hub_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hub_Icon.Image = Global.NetMapper.My.Resources.Resources.small_hub
        Me.Hub_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Hub_Icon.Location = New System.Drawing.Point(3, 493)
        Me.Hub_Icon.Name = "Hub_Icon"
        Me.Hub_Icon.Size = New System.Drawing.Size(136, 92)
        Me.Hub_Icon.TabIndex = 6
        Me.Hub_Icon.Text = "Hub"
        Me.Hub_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Hub_Icon.UseVisualStyleBackColor = True
        '
        'IPPhone_Icon
        '
        Me.IPPhone_Icon.Enabled = False
        Me.IPPhone_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IPPhone_Icon.Image = Global.NetMapper.My.Resources.Resources.ip_phone
        Me.IPPhone_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IPPhone_Icon.Location = New System.Drawing.Point(3, 689)
        Me.IPPhone_Icon.Name = "IPPhone_Icon"
        Me.IPPhone_Icon.Size = New System.Drawing.Size(136, 92)
        Me.IPPhone_Icon.TabIndex = 4
        Me.IPPhone_Icon.Text = "IP Phone"
        Me.IPPhone_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.IPPhone_Icon.UseVisualStyleBackColor = True
        '
        'WirelessRouter_Icon
        '
        Me.WirelessRouter_Icon.Enabled = False
        Me.WirelessRouter_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WirelessRouter_Icon.Image = Global.NetMapper.My.Resources.Resources.wireless_router
        Me.WirelessRouter_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WirelessRouter_Icon.Location = New System.Drawing.Point(3, 199)
        Me.WirelessRouter_Icon.Name = "WirelessRouter_Icon"
        Me.WirelessRouter_Icon.Size = New System.Drawing.Size(136, 92)
        Me.WirelessRouter_Icon.TabIndex = 2
        Me.WirelessRouter_Icon.Text = "Wireless Router"
        Me.WirelessRouter_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.WirelessRouter_Icon.UseVisualStyleBackColor = True
        '
        'RouterWFirewall_Icon
        '
        Me.RouterWFirewall_Icon.Enabled = False
        Me.RouterWFirewall_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RouterWFirewall_Icon.Image = Global.NetMapper.My.Resources.Resources.router_firewall
        Me.RouterWFirewall_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RouterWFirewall_Icon.Location = New System.Drawing.Point(3, 101)
        Me.RouterWFirewall_Icon.Name = "RouterWFirewall_Icon"
        Me.RouterWFirewall_Icon.Size = New System.Drawing.Size(136, 92)
        Me.RouterWFirewall_Icon.TabIndex = 1
        Me.RouterWFirewall_Icon.Text = "Router w/ Firewall"
        Me.RouterWFirewall_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RouterWFirewall_Icon.UseVisualStyleBackColor = True
        '
        'Router_Icon
        '
        Me.Router_Icon.AllowDrop = True
        Me.Router_Icon.Enabled = False
        Me.Router_Icon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Router_Icon.Image = Global.NetMapper.My.Resources.Resources.router
        Me.Router_Icon.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Router_Icon.Location = New System.Drawing.Point(3, 3)
        Me.Router_Icon.Name = "Router_Icon"
        Me.Router_Icon.Size = New System.Drawing.Size(136, 92)
        Me.Router_Icon.TabIndex = 0
        Me.Router_Icon.Text = "Router"
        Me.Router_Icon.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Router_Icon.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(241, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        Me.Button5.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DeviceContextMenu
        '
        Me.DeviceContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigureDeviceToolStripMenuItem, Me.TelnetToolStripMenuItem, Me.AddInterfaceToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.DeviceContextMenu.Name = "DeviceContextMenu"
        Me.DeviceContextMenu.Size = New System.Drawing.Size(146, 92)
        '
        'ConfigureDeviceToolStripMenuItem
        '
        Me.ConfigureDeviceToolStripMenuItem.Name = "ConfigureDeviceToolStripMenuItem"
        Me.ConfigureDeviceToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ConfigureDeviceToolStripMenuItem.Text = "Configure"
        '
        'TelnetToolStripMenuItem
        '
        Me.TelnetToolStripMenuItem.Name = "TelnetToolStripMenuItem"
        Me.TelnetToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TelnetToolStripMenuItem.Text = "Telnet"
        '
        'AddInterfaceToolStripMenuItem
        '
        Me.AddInterfaceToolStripMenuItem.Name = "AddInterfaceToolStripMenuItem"
        Me.AddInterfaceToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AddInterfaceToolStripMenuItem.Text = "Add Interface"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetMapper"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.DeviceContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutNetMapperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IPPhone_Icon As System.Windows.Forms.Button
    Friend WithEvents WorkgroupSwitch_Icon As System.Windows.Forms.Button
    Friend WithEvents WirelessRouter_Icon As System.Windows.Forms.Button
    Friend WithEvents RouterWFirewall_Icon As System.Windows.Forms.Button
    Friend WithEvents Router_Icon As System.Windows.Forms.Button
    Friend WithEvents Workstation_Icon As System.Windows.Forms.Button
    Friend WithEvents Hub_Icon As System.Windows.Forms.Button
    Friend WithEvents Layer3Switch_Icon As System.Windows.Forms.Button
    Friend WithEvents ASA_Icon As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZIPFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DeviceContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConfigureDeviceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TelnetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubmitFeedbackBugReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddInterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
