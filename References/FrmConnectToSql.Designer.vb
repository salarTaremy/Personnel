<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConnectToSql
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
        Me.CmbType = New System.Windows.Forms.ComboBox()
        Me.CmbAuthentication = New System.Windows.Forms.ComboBox()
        Me.CmbName = New System.Windows.Forms.ComboBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnHelp = New System.Windows.Forms.Button()
        Me.BtnOptions = New System.Windows.Forms.Button()
        Me.CmbLogin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CmbType
        '
        Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbType.FormattingEnabled = True
        Me.CmbType.Items.AddRange(New Object() {"Database Engine"})
        Me.CmbType.Location = New System.Drawing.Point(149, 78)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(250, 21)
        Me.CmbType.TabIndex = 0
        '
        'CmbAuthentication
        '
        Me.CmbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAuthentication.FormattingEnabled = True
        Me.CmbAuthentication.Items.AddRange(New Object() {"SQL Server Authentication"})
        Me.CmbAuthentication.Location = New System.Drawing.Point(149, 132)
        Me.CmbAuthentication.Name = "CmbAuthentication"
        Me.CmbAuthentication.Size = New System.Drawing.Size(250, 21)
        Me.CmbAuthentication.TabIndex = 2
        '
        'CmbName
        '
        Me.CmbName.FormattingEnabled = True
        Me.CmbName.Location = New System.Drawing.Point(149, 105)
        Me.CmbName.Name = "CmbName"
        Me.CmbName.Size = New System.Drawing.Size(250, 21)
        Me.CmbName.TabIndex = 1
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(163, 185)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(236, 20)
        Me.TxtPass.TabIndex = 4
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(73, 249)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnConnect.TabIndex = 6
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(154, 249)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnHelp
        '
        Me.BtnHelp.Location = New System.Drawing.Point(235, 249)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(75, 23)
        Me.BtnHelp.TabIndex = 8
        Me.BtnHelp.Text = "Help"
        Me.BtnHelp.UseVisualStyleBackColor = True
        '
        'BtnOptions
        '
        Me.BtnOptions.Enabled = False
        Me.BtnOptions.Location = New System.Drawing.Point(316, 249)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(83, 23)
        Me.BtnOptions.TabIndex = 9
        Me.BtnOptions.Text = "Options >>"
        Me.BtnOptions.UseVisualStyleBackColor = True
        '
        'CmbLogin
        '
        Me.CmbLogin.FormattingEnabled = True
        Me.CmbLogin.Location = New System.Drawing.Point(163, 158)
        Me.CmbLogin.Name = "CmbLogin"
        Me.CmbLogin.Size = New System.Drawing.Size(236, 21)
        Me.CmbLogin.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Server type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ServerName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Authentication:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Login:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Password:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(163, 211)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Remember password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmConnectToSql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.References.My.Resources.Resources.Connect_to_sql1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(411, 284)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbLogin)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.CmbName)
        Me.Controls.Add(Me.CmbAuthentication)
        Me.Controls.Add(Me.CmbType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConnectToSql"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect To Server"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbAuthentication As System.Windows.Forms.ComboBox
    Friend WithEvents CmbName As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents BtnConnect As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnHelp As System.Windows.Forms.Button
    Friend WithEvents BtnOptions As System.Windows.Forms.Button
    Friend WithEvents CmbLogin As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
