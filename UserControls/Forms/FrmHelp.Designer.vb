<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.TxtInfo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnSee = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblInfo = New Telerik.WinControls.UI.RadLabel()
        CType(Me.TxtInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.BtnSee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtInfo
        '
        Me.TxtInfo.AutoSize = False
        Me.TxtInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInfo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtInfo.Location = New System.Drawing.Point(2, 18)
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ReadOnly = True
        Me.TxtInfo.Size = New System.Drawing.Size(437, 248)
        Me.TxtInfo.TabIndex = 0
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.TxtInfo)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "جزئیات:"
        Me.RadGroupBox1.Location = New System.Drawing.Point(6, 144)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(441, 268)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.Text = "جزئیات:"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'BtnSee
        '
        Me.BtnSee.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSee.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSee.Image = Global.UserControls.My.Resources.Resources.Ok
        Me.BtnSee.Location = New System.Drawing.Point(172, 419)
        Me.BtnSee.Name = "BtnSee"
        Me.BtnSee.Size = New System.Drawing.Size(110, 31)
        Me.BtnSee.TabIndex = 29
        Me.BtnSee.Text = "متوجه شدم"
        Me.BtnSee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.BtnSee.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.UserControls.My.Resources.Resources.Ok
        CType(Me.BtnSee.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        CType(Me.BtnSee.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "متوجه شدم"
        CType(Me.BtnSee.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSee.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSee.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSee.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UserControls.My.Resources.Resources.Ok
        Me.PictureBox1.Location = New System.Drawing.Point(319, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 126)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = False
        Me.LblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.Location = New System.Drawing.Point(8, 50)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(305, 88)
        Me.LblInfo.TabIndex = 30
        Me.LblInfo.Text = "اطلاعات"
        Me.LblInfo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 462)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnSee)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHelp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "سیستم راهنمای نرم افزار"
        CType(Me.TxtInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.BtnSee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtInfo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSee As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblInfo As Telerik.WinControls.UI.RadLabel
End Class
