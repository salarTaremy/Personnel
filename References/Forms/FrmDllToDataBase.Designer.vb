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
        Me.ChkRef = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkUc = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkExe = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ChkGetExe = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkRes = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.BtnSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelectPath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkUc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkExe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.ChkGetExe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSend
        '
        Me.BtnSend.Location = New System.Drawing.Point(49, 178)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(110, 32)
        Me.BtnSend.TabIndex = 0
        Me.BtnSend.Text = "Start"
        '
        'TxtPath
        '
        Me.TxtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPath.Location = New System.Drawing.Point(49, 12)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.NextObject = Nothing
        Me.TxtPath.ReadOnly = True
        Me.TxtPath.Size = New System.Drawing.Size(400, 19)
        Me.TxtPath.TabIndex = 1
        Me.TxtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSelectPath
        '
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
        'ChkRef
        '
        Me.ChkRef.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRef.Location = New System.Drawing.Point(5, 45)
        Me.ChkRef.Name = "ChkRef"
        Me.ChkRef.Size = New System.Drawing.Size(89, 18)
        Me.ChkRef.TabIndex = 3
        Me.ChkRef.Text = "References.dll"
        Me.ChkRef.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'ChkUc
        '
        Me.ChkUc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkUc.Location = New System.Drawing.Point(5, 69)
        Me.ChkUc.Name = "ChkUc"
        Me.ChkUc.Size = New System.Drawing.Size(99, 18)
        Me.ChkUc.TabIndex = 4
        Me.ChkUc.Text = "UserControls.dll"
        Me.ChkUc.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
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
        Me.RadGroupBox1.Controls.Add(Me.ChkRes)
        Me.RadGroupBox1.Controls.Add(Me.ChkExe)
        Me.RadGroupBox1.Controls.Add(Me.ChkRef)
        Me.RadGroupBox1.Controls.Add(Me.ChkUc)
        Me.RadGroupBox1.HeaderText = "Send "
        Me.RadGroupBox1.Location = New System.Drawing.Point(49, 37)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(206, 135)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Text = "Send "
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.ChkGetExe)
        Me.RadGroupBox2.HeaderText = "Receive"
        Me.RadGroupBox2.Location = New System.Drawing.Point(261, 37)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(188, 95)
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
        'ChkRes
        '
        Me.ChkRes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRes.Location = New System.Drawing.Point(5, 93)
        Me.ChkRes.Name = "ChkRes"
        Me.ChkRes.Size = New System.Drawing.Size(82, 18)
        Me.ChkRes.TabIndex = 6
        Me.ChkRes.Text = "ReSource.dll"
        Me.ChkRes.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'FrmDllToDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(508, 222)
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
        CType(Me.ChkRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkUc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkExe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.ChkGetExe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSend As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPath As UserControls.RadTextBox
    Friend WithEvents BtnSelectPath As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ChkRef As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkUc As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkExe As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents ChkGetExe As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkRes As Telerik.WinControls.UI.RadCheckBox
End Class
