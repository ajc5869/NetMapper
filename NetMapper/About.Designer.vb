<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AppTitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppDateLabel = New System.Windows.Forms.Label()
        Me.AppCopyrightLabel = New System.Windows.Forms.Label()
        Me.AppVersionLabel = New System.Windows.Forms.Label()
        Me.MoreRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppTitleLabel
        '
        Me.AppTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppTitleLabel.Location = New System.Drawing.Point(56, 12)
        Me.AppTitleLabel.Name = "AppTitleLabel"
        Me.AppTitleLabel.Size = New System.Drawing.Size(326, 16)
        Me.AppTitleLabel.TabIndex = 10
        Me.AppTitleLabel.Text = "NetMapper"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 2)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AppDateLabel
        '
        Me.AppDateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDateLabel.Location = New System.Drawing.Point(8, 80)
        Me.AppDateLabel.Name = "AppDateLabel"
        Me.AppDateLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppDateLabel.TabIndex = 16
        Me.AppDateLabel.Text = "Build Date: 2014-10-26"
        '
        'AppCopyrightLabel
        '
        Me.AppCopyrightLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppCopyrightLabel.Location = New System.Drawing.Point(8, 100)
        Me.AppCopyrightLabel.Name = "AppCopyrightLabel"
        Me.AppCopyrightLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppCopyrightLabel.TabIndex = 15
        Me.AppCopyrightLabel.Text = "Copyright © 2014, Andrew Cozzetta"
        '
        'AppVersionLabel
        '
        Me.AppVersionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppVersionLabel.Location = New System.Drawing.Point(8, 60)
        Me.AppVersionLabel.Name = "AppVersionLabel"
        Me.AppVersionLabel.Size = New System.Drawing.Size(378, 16)
        Me.AppVersionLabel.TabIndex = 14
        Me.AppVersionLabel.Text = "Version: 1.0"
        '
        'MoreRichTextBox
        '
        Me.MoreRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoreRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MoreRichTextBox.Location = New System.Drawing.Point(8, 124)
        Me.MoreRichTextBox.Name = "MoreRichTextBox"
        Me.MoreRichTextBox.ReadOnly = True
        Me.MoreRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.MoreRichTextBox.Size = New System.Drawing.Size(378, 105)
        Me.MoreRichTextBox.TabIndex = 17
        Me.MoreRichTextBox.Text = "Software Engineer: Andrew Cozzetta"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BackgroundImage = Global.NetMapper.My.Resources.Resources.ID_100271289
        Me.ImagePictureBox.Location = New System.Drawing.Point(12, 12)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(32, 32)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.ImagePictureBox.TabIndex = 12
        Me.ImagePictureBox.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 241)
        Me.Controls.Add(Me.MoreRichTextBox)
        Me.Controls.Add(Me.AppDateLabel)
        Me.Controls.Add(Me.AppCopyrightLabel)
        Me.Controls.Add(Me.AppVersionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.AppTitleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About NetMapper"
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Private WithEvents AppTitleLabel As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents AppDateLabel As System.Windows.Forms.Label
    Private WithEvents AppCopyrightLabel As System.Windows.Forms.Label
    Private WithEvents AppVersionLabel As System.Windows.Forms.Label
    Friend WithEvents MoreRichTextBox As System.Windows.Forms.RichTextBox
End Class
