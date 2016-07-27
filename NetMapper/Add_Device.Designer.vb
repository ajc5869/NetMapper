<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Device
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxHolder = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EITMS_Rack_Row_Label = New System.Windows.Forms.Label()
        Me.Hostname_Label = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBoxHolder.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EITMS ID:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(75, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Retrieve Device Info"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Row/Rack:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 56)
        Me.TextBox2.MaxLength = 5
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telnet Info:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 82)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "C Name:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 108)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(169, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(355, 43)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Add to Diagram"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "*Hostname:"
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(75, 134)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(169, 20)
        Me.TextBox5.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxHolder
        '
        Me.PictureBoxHolder.BackColor = System.Drawing.Color.White
        Me.PictureBoxHolder.Controls.Add(Me.Panel1)
        Me.PictureBoxHolder.Location = New System.Drawing.Point(250, 54)
        Me.PictureBoxHolder.Name = "PictureBoxHolder"
        Me.PictureBoxHolder.Size = New System.Drawing.Size(120, 114)
        Me.PictureBoxHolder.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EITMS_Rack_Row_Label)
        Me.Panel1.Controls.Add(Me.Hostname_Label)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 104)
        Me.Panel1.TabIndex = 18
        '
        'EITMS_Rack_Row_Label
        '
        Me.EITMS_Rack_Row_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EITMS_Rack_Row_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EITMS_Rack_Row_Label.Location = New System.Drawing.Point(-4, 88)
        Me.EITMS_Rack_Row_Label.Name = "EITMS_Rack_Row_Label"
        Me.EITMS_Rack_Row_Label.Size = New System.Drawing.Size(122, 13)
        Me.EITMS_Rack_Row_Label.TabIndex = 17
        Me.EITMS_Rack_Row_Label.Text = "EITMS_Rack_Row_Label"
        Me.EITMS_Rack_Row_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Hostname_Label
        '
        Me.Hostname_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Hostname_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hostname_Label.Location = New System.Drawing.Point(-6, 1)
        Me.Hostname_Label.Name = "Hostname_Label"
        Me.Hostname_Label.Size = New System.Drawing.Size(122, 13)
        Me.Hostname_Label.TabIndex = 16
        Me.Hostname_Label.Text = "Hostname_Label"
        Me.Hostname_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Device Preview"
        '
        'Add_Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 240)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBoxHolder)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Device"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Device to Topology"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBoxHolder.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxHolder As System.Windows.Forms.Panel
    Friend WithEvents Hostname_Label As System.Windows.Forms.Label
    Friend WithEvents EITMS_Rack_Row_Label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
