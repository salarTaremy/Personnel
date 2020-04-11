<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDllToDataBase
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
        Me.BtnSend = New Telerik.WinControls.UI.RadButton()
        Me.TxtPath = New UserControls.RadTextBox()
        Me.BtnSelectPath = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ChkDal = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkCom = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkExe = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ChkSal = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkPr = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkTH = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkUc = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkPrm = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkMain = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ChkGetExe = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkEF = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelectPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkDal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkCom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkExe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.ChkSal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkTH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkUc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPrm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.ChkGetExe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.Location = New System.Drawing.Point(378, 147)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(123, 32)
        Me.BtnSend.TabIndex = 0
        Me.BtnSend.Text = "Start"
        '
        'TxtPath
        '
        Me.TxtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPath.FocusColor = System.Drawing.Color.Azure
        Me.TxtPath.IsRequierd = False
        Me.TxtPath.Location = New System.Drawing.Point(49, 12)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Name_Farsi = Nothing
        Me.TxtPath.NextObject = Nothing
        Me.TxtPath.ReadOnly = True
        Me.TxtPath.Size = New System.Drawing.Size(400, 19)
        Me.TxtPath.TabIndex = 1
        Me.TxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSelectPath
        '
        Me.BtnSelectPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectPath.Location = New System.Drawing.Point(455, 12)
        Me.BtnSelectPath.Name = "BtnSelectPath"
        Me.BtnSelectPath.Size = New System.Drawing.Size(44, 19)
        Me.BtnSelectPath.TabIndex = 2
        Me.BtnSelectPath.Text = "..."
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Path:"
        '
        'ChkDal
        '
        Me.ChkDal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDal.Location = New System.Drawing.Point(5, 45)
        Me.ChkDal.Name = "ChkDal"
        Me.ChkDal.Size = New System.Drawing.Size(55, 18)
        Me.ChkDal.TabIndex = 3
        Me.ChkDal.TabStop = False
        Me.ChkDal.Text = "DAL.dll"
        Me.ChkDal.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkCom
        '
        Me.ChkCom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCom.Location = New System.Drawing.Point(5, 69)
        Me.ChkCom.Name = "ChkCom"
        Me.ChkCom.Size = New System.Drawing.Size(81, 18)
        Me.ChkCom.TabIndex = 4
        Me.ChkCom.Text = "Common.dll"
        Me.ChkCom.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkExe
        '
        Me.ChkExe.Location = New System.Drawing.Point(5, 21)
        Me.ChkExe.Name = "ChkExe"
        Me.ChkExe.Size = New System.Drawing.Size(37, 18)
        Me.ChkExe.TabIndex = 5
        Me.ChkExe.Text = "Exe"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.ChkEF)
        Me.RadGroupBox1.Controls.Add(Me.ChkSal)
        Me.RadGroupBox1.Controls.Add(Me.ChkPr)
        Me.RadGroupBox1.Controls.Add(Me.ChkTH)
        Me.RadGroupBox1.Controls.Add(Me.ChkUc)
        Me.RadGroupBox1.Controls.Add(Me.ChkPrm)
        Me.RadGroupBox1.Controls.Add(Me.ChkMain)
        Me.RadGroupBox1.Controls.Add(Me.ChkExe)
        Me.RadGroupBox1.Controls.Add(Me.ChkDal)
        Me.RadGroupBox1.Controls.Add(Me.ChkCom)
        Me.RadGroupBox1.HeaderText = "Send "
        Me.RadGroupBox1.Location = New System.Drawing.Point(49, 37)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(318, 146)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Text = "Send "
        '
        'ChkSal
        '
        Me.ChkSal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSal.Location = New System.Drawing.Point(5, 117)
        Me.ChkSal.Name = "ChkSal"
        Me.ChkSal.Size = New System.Drawing.Size(64, 18)
        Me.ChkSal.TabIndex = 11
        Me.ChkSal.Text = "Salary.dll"
        Me.ChkSal.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkPr
        '
        Me.ChkPr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPr.Location = New System.Drawing.Point(150, 93)
        Me.ChkPr.Name = "ChkPr"
        Me.ChkPr.Size = New System.Drawing.Size(89, 18)
        Me.ChkPr.TabIndex = 10
        Me.ChkPr.Text = "Personnely.dll"
        Me.ChkPr.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkTH
        '
        Me.ChkTH.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTH.Location = New System.Drawing.Point(5, 93)
        Me.ChkTH.Name = "ChkTH"
        Me.ChkTH.Size = New System.Drawing.Size(91, 18)
        Me.ChkTH.TabIndex = 9
        Me.ChkTH.Text = "TarafHesab.dll"
        Me.ChkTH.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkUc
        '
        Me.ChkUc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUc.Location = New System.Drawing.Point(150, 69)
        Me.ChkUc.Name = "ChkUc"
        Me.ChkUc.Size = New System.Drawing.Size(99, 18)
        Me.ChkUc.TabIndex = 8
        Me.ChkUc.Text = "UserControls.dll"
        Me.ChkUc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkPrm
        '
        Me.ChkPrm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPrm.Location = New System.Drawing.Point(150, 45)
        Me.ChkPrm.Name = "ChkPrm"
        Me.ChkPrm.Size = New System.Drawing.Size(89, 18)
        Me.ChkPrm.TabIndex = 7
        Me.ChkPrm.Text = "Permission.dll"
        Me.ChkPrm.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkMain
        '
        Me.ChkMain.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMain.Location = New System.Drawing.Point(150, 21)
        Me.ChkMain.Name = "ChkMain"
        Me.ChkMain.Size = New System.Drawing.Size(60, 18)
        Me.ChkMain.TabIndex = 6
        Me.ChkMain.Text = "Main.dll"
        Me.ChkMain.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.ChkGetExe)
        Me.RadGroupBox2.HeaderText = "Receive"
        Me.RadGroupBox2.Location = New System.Drawing.Point(373, 37)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(126, 104)
        Me.RadGroupBox2.TabIndex = 7
        Me.RadGroupBox2.Text = "Receive"
        '
        'ChkGetExe
        '
        Me.ChkGetExe.Location = New System.Drawing.Point(5, 21)
        Me.ChkGetExe.Name = "ChkGetExe"
        Me.ChkGetExe.Size = New System.Drawing.Size(37, 18)
        Me.ChkGetExe.TabIndex = 6
        Me.ChkGetExe.Text = "Exe"
        '
        'ChkEF
        '
        Me.ChkEF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEF.Location = New System.Drawing.Point(150, 117)
        Me.ChkEF.Name = "ChkEF"
        Me.ChkEF.Size = New System.Drawing.Size(46, 18)
        Me.ChkEF.TabIndex = 12
        Me.ChkEF.Text = "EF.dll"
        Me.ChkEF.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'FrmDllToDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(511, 196)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.BtnSelectPath)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.BtnSend)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmDllToDataBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Dll To Database"
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelectPath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkDal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkCom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkExe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.ChkSal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkTH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkUc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPrm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.ChkGetExe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSend As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPath As UserControls.RadTextBox
    Friend WithEvents BtnSelectPath As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ChkDal As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkCom As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkExe As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents ChkGetExe As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkMain As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkUc As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkPrm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkPr As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkTH As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkSal As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkEF As Telerik.WinControls.UI.RadCheckBox
End Class
