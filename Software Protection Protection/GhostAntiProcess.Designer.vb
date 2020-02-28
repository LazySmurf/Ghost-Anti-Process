<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GhostAntiProcess
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GhostAntiProcess))
        Me.Header = New System.Windows.Forms.Label()
        Me.MainParagraph = New System.Windows.Forms.Label()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SearchAndDestroy = New System.Windows.Forms.Timer(Me.components)
        Me.SettingCheck = New System.Windows.Forms.Timer(Me.components)
        Me.DevLink = New System.Windows.Forms.LinkLabel()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.CheckTime = New System.Windows.Forms.Timer(Me.components)
        Me.LogGroupBox = New System.Windows.Forms.GroupBox()
        Me.HideShowLogButton = New System.Windows.Forms.Button()
        Me.SearchIndexCheck = New System.Windows.Forms.CheckBox()
        Me.SearchFilterHostCheck = New System.Windows.Forms.CheckBox()
        Me.SearchUICheck = New System.Windows.Forms.CheckBox()
        Me.PhotosCheck = New System.Windows.Forms.CheckBox()
        Me.KMSCheck = New System.Windows.Forms.CheckBox()
        Me.SettingsCheck = New System.Windows.Forms.CheckBox()
        Me.ExitNormal = New System.Windows.Forms.PictureBox()
        Me.ExitHover = New System.Windows.Forms.PictureBox()
        Me.MinNormal = New System.Windows.Forms.PictureBox()
        Me.MinHover = New System.Windows.Forms.PictureBox()
        Me.BGTaskHostCheck = New System.Windows.Forms.CheckBox()
        Me.SettingSyncHostCheck = New System.Windows.Forms.CheckBox()
        Me.TopMostCheck = New System.Windows.Forms.CheckBox()
        Me.LogGroupBox.SuspendLayout()
        CType(Me.ExitNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitHover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinHover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(45, 28)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(195, 30)
        Me.Header.TabIndex = 0
        Me.Header.Text = "Ghost Anti-Process"
        '
        'MainParagraph
        '
        Me.MainParagraph.Location = New System.Drawing.Point(24, 58)
        Me.MainParagraph.Name = "MainParagraph"
        Me.MainParagraph.Size = New System.Drawing.Size(237, 201)
        Me.MainParagraph.TabIndex = 1
        Me.MainParagraph.Text = resources.GetString("MainParagraph.Text")
        Me.MainParagraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HideButton
        '
        Me.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideButton.Location = New System.Drawing.Point(27, 257)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(92, 23)
        Me.HideButton.TabIndex = 2
        Me.HideButton.Text = "Hide Window"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'TrayIcon
        '
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Ghost Anti-Process"
        Me.TrayIcon.Visible = True
        '
        'SearchAndDestroy
        '
        Me.SearchAndDestroy.Enabled = True
        Me.SearchAndDestroy.Interval = 250
        '
        'SettingCheck
        '
        Me.SettingCheck.Interval = 1
        '
        'DevLink
        '
        Me.DevLink.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.DevLink.AutoSize = True
        Me.DevLink.LinkColor = System.Drawing.Color.White
        Me.DevLink.Location = New System.Drawing.Point(78, 314)
        Me.DevLink.Name = "DevLink"
        Me.DevLink.Size = New System.Drawing.Size(129, 13)
        Me.DevLink.TabIndex = 3
        Me.DevLink.TabStop = True
        Me.DevLink.Text = "LazySmurf Development"
        Me.DevLink.VisitedLinkColor = System.Drawing.Color.White
        '
        'LogBox
        '
        Me.LogBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogBox.ForeColor = System.Drawing.Color.White
        Me.LogBox.Location = New System.Drawing.Point(3, 18)
        Me.LogBox.Multiline = True
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogBox.Size = New System.Drawing.Size(291, 200)
        Me.LogBox.TabIndex = 5
        '
        'CheckTime
        '
        Me.CheckTime.Enabled = True
        Me.CheckTime.Interval = 1000
        '
        'LogGroupBox
        '
        Me.LogGroupBox.Controls.Add(Me.LogBox)
        Me.LogGroupBox.ForeColor = System.Drawing.Color.White
        Me.LogGroupBox.Location = New System.Drawing.Point(285, 12)
        Me.LogGroupBox.Name = "LogGroupBox"
        Me.LogGroupBox.Size = New System.Drawing.Size(297, 221)
        Me.LogGroupBox.TabIndex = 6
        Me.LogGroupBox.TabStop = False
        Me.LogGroupBox.Text = "Application Log"
        '
        'HideShowLogButton
        '
        Me.HideShowLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideShowLogButton.Location = New System.Drawing.Point(169, 257)
        Me.HideShowLogButton.Name = "HideShowLogButton"
        Me.HideShowLogButton.Size = New System.Drawing.Size(92, 23)
        Me.HideShowLogButton.TabIndex = 7
        Me.HideShowLogButton.Text = "Hide Log"
        Me.HideShowLogButton.UseVisualStyleBackColor = True
        '
        'SearchIndexCheck
        '
        Me.SearchIndexCheck.AutoSize = True
        Me.SearchIndexCheck.Location = New System.Drawing.Point(285, 239)
        Me.SearchIndexCheck.Name = "SearchIndexCheck"
        Me.SearchIndexCheck.Size = New System.Drawing.Size(101, 17)
        Me.SearchIndexCheck.TabIndex = 8
        Me.SearchIndexCheck.Text = "Search Indexer"
        Me.SearchIndexCheck.UseVisualStyleBackColor = True
        '
        'SearchFilterHostCheck
        '
        Me.SearchFilterHostCheck.AutoSize = True
        Me.SearchFilterHostCheck.Location = New System.Drawing.Point(285, 262)
        Me.SearchFilterHostCheck.Name = "SearchFilterHostCheck"
        Me.SearchFilterHostCheck.Size = New System.Drawing.Size(110, 17)
        Me.SearchFilterHostCheck.TabIndex = 9
        Me.SearchFilterHostCheck.Text = "SearchFilterHost"
        Me.SearchFilterHostCheck.UseVisualStyleBackColor = True
        '
        'SearchUICheck
        '
        Me.SearchUICheck.AutoSize = True
        Me.SearchUICheck.Location = New System.Drawing.Point(285, 285)
        Me.SearchUICheck.Name = "SearchUICheck"
        Me.SearchUICheck.Size = New System.Drawing.Size(116, 17)
        Me.SearchUICheck.TabIndex = 10
        Me.SearchUICheck.Text = "SearchUI/Cortana"
        Me.SearchUICheck.UseVisualStyleBackColor = True
        '
        'PhotosCheck
        '
        Me.PhotosCheck.AutoSize = True
        Me.PhotosCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PhotosCheck.Location = New System.Drawing.Point(496, 239)
        Me.PhotosCheck.Name = "PhotosCheck"
        Me.PhotosCheck.Size = New System.Drawing.Size(86, 17)
        Me.PhotosCheck.TabIndex = 11
        Me.PhotosCheck.Text = "Photos App"
        Me.PhotosCheck.UseVisualStyleBackColor = True
        '
        'KMSCheck
        '
        Me.KMSCheck.AutoSize = True
        Me.KMSCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KMSCheck.Location = New System.Drawing.Point(496, 262)
        Me.KMSCheck.Name = "KMSCheck"
        Me.KMSCheck.Size = New System.Drawing.Size(86, 17)
        Me.KMSCheck.TabIndex = 12
        Me.KMSCheck.Text = "KMS Service"
        Me.KMSCheck.UseVisualStyleBackColor = True
        '
        'SettingsCheck
        '
        Me.SettingsCheck.AutoSize = True
        Me.SettingsCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingsCheck.Location = New System.Drawing.Point(479, 285)
        Me.SettingsCheck.Name = "SettingsCheck"
        Me.SettingsCheck.Size = New System.Drawing.Size(103, 17)
        Me.SettingsCheck.TabIndex = 13
        Me.SettingsCheck.Text = "SystemSettings"
        Me.SettingsCheck.UseVisualStyleBackColor = True
        '
        'ExitNormal
        '
        Me.ExitNormal.BackgroundImage = CType(resources.GetObject("ExitNormal.BackgroundImage"), System.Drawing.Image)
        Me.ExitNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitNormal.Location = New System.Drawing.Point(7, 6)
        Me.ExitNormal.Name = "ExitNormal"
        Me.ExitNormal.Size = New System.Drawing.Size(20, 20)
        Me.ExitNormal.TabIndex = 14
        Me.ExitNormal.TabStop = False
        '
        'ExitHover
        '
        Me.ExitHover.BackgroundImage = CType(resources.GetObject("ExitHover.BackgroundImage"), System.Drawing.Image)
        Me.ExitHover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitHover.Location = New System.Drawing.Point(7, 6)
        Me.ExitHover.Name = "ExitHover"
        Me.ExitHover.Size = New System.Drawing.Size(20, 20)
        Me.ExitHover.TabIndex = 15
        Me.ExitHover.TabStop = False
        Me.ExitHover.Visible = False
        '
        'MinNormal
        '
        Me.MinNormal.BackgroundImage = CType(resources.GetObject("MinNormal.BackgroundImage"), System.Drawing.Image)
        Me.MinNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MinNormal.Location = New System.Drawing.Point(26, 6)
        Me.MinNormal.Name = "MinNormal"
        Me.MinNormal.Size = New System.Drawing.Size(20, 20)
        Me.MinNormal.TabIndex = 16
        Me.MinNormal.TabStop = False
        '
        'MinHover
        '
        Me.MinHover.BackgroundImage = CType(resources.GetObject("MinHover.BackgroundImage"), System.Drawing.Image)
        Me.MinHover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MinHover.Location = New System.Drawing.Point(26, 6)
        Me.MinHover.Name = "MinHover"
        Me.MinHover.Size = New System.Drawing.Size(20, 20)
        Me.MinHover.TabIndex = 17
        Me.MinHover.TabStop = False
        Me.MinHover.Visible = False
        '
        'BGTaskHostCheck
        '
        Me.BGTaskHostCheck.AutoSize = True
        Me.BGTaskHostCheck.Location = New System.Drawing.Point(285, 307)
        Me.BGTaskHostCheck.Name = "BGTaskHostCheck"
        Me.BGTaskHostCheck.Size = New System.Drawing.Size(134, 17)
        Me.BGTaskHostCheck.TabIndex = 18
        Me.BGTaskHostCheck.Text = "BackgroundTaskHost"
        Me.BGTaskHostCheck.UseVisualStyleBackColor = True
        '
        'SettingSyncHostCheck
        '
        Me.SettingSyncHostCheck.AutoSize = True
        Me.SettingSyncHostCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SettingSyncHostCheck.Location = New System.Drawing.Point(472, 307)
        Me.SettingSyncHostCheck.Name = "SettingSyncHostCheck"
        Me.SettingSyncHostCheck.Size = New System.Drawing.Size(110, 17)
        Me.SettingSyncHostCheck.TabIndex = 19
        Me.SettingSyncHostCheck.Text = "SettingSyncHost"
        Me.SettingSyncHostCheck.UseVisualStyleBackColor = True
        '
        'TopMostCheck
        '
        Me.TopMostCheck.AutoSize = True
        Me.TopMostCheck.Location = New System.Drawing.Point(94, 290)
        Me.TopMostCheck.Name = "TopMostCheck"
        Me.TopMostCheck.Size = New System.Drawing.Size(102, 17)
        Me.TopMostCheck.TabIndex = 20
        Me.TopMostCheck.Text = "Always On Top"
        Me.TopMostCheck.UseVisualStyleBackColor = True
        '
        'GhostAntiProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(594, 336)
        Me.Controls.Add(Me.TopMostCheck)
        Me.Controls.Add(Me.SettingSyncHostCheck)
        Me.Controls.Add(Me.BGTaskHostCheck)
        Me.Controls.Add(Me.MinHover)
        Me.Controls.Add(Me.MinNormal)
        Me.Controls.Add(Me.ExitHover)
        Me.Controls.Add(Me.ExitNormal)
        Me.Controls.Add(Me.SettingsCheck)
        Me.Controls.Add(Me.KMSCheck)
        Me.Controls.Add(Me.PhotosCheck)
        Me.Controls.Add(Me.SearchUICheck)
        Me.Controls.Add(Me.SearchFilterHostCheck)
        Me.Controls.Add(Me.SearchIndexCheck)
        Me.Controls.Add(Me.HideShowLogButton)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.LogGroupBox)
        Me.Controls.Add(Me.DevLink)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.MainParagraph)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GhostAntiProcess"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ghost Anti-Process"
        Me.LogGroupBox.ResumeLayout(False)
        Me.LogGroupBox.PerformLayout()
        CType(Me.ExitNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitHover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinNormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinHover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents MainParagraph As Label
    Friend WithEvents HideButton As Button
    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents SearchAndDestroy As Timer
    Friend WithEvents SettingCheck As Timer
    Friend WithEvents DevLink As LinkLabel
    Friend WithEvents LogBox As TextBox
    Friend WithEvents CheckTime As Timer
    Friend WithEvents LogGroupBox As GroupBox
    Friend WithEvents HideShowLogButton As Button
    Friend WithEvents SearchIndexCheck As CheckBox
    Friend WithEvents SearchFilterHostCheck As CheckBox
    Friend WithEvents SearchUICheck As CheckBox
    Friend WithEvents PhotosCheck As CheckBox
    Friend WithEvents KMSCheck As CheckBox
    Friend WithEvents SettingsCheck As CheckBox
    Friend WithEvents ExitNormal As PictureBox
    Friend WithEvents ExitHover As PictureBox
    Friend WithEvents MinNormal As PictureBox
    Friend WithEvents MinHover As PictureBox
    Friend WithEvents BGTaskHostCheck As CheckBox
    Friend WithEvents SettingSyncHostCheck As CheckBox
    Friend WithEvents TopMostCheck As CheckBox
End Class
