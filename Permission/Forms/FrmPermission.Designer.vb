<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermission
    Inherits ClsMyForms

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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPermission))
        Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.SplitPanel3 = New Telerik.WinControls.UI.SplitPanel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.GrdPermission = New UserControls.RadGridView()
        Me.SplitPanel4 = New Telerik.WinControls.UI.SplitPanel()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.GrdUser = New UserControls.RadGridView()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.ChkSelectAll = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer2.SuspendLayout()
        CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitPanel3.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.GrdPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdPermission.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitPanel4.SuspendLayout()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.GrdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdUser.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadSplitContainer2
        '
        Me.RadSplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadSplitContainer2.Controls.Add(Me.SplitPanel3)
        Me.RadSplitContainer2.Controls.Add(Me.SplitPanel4)
        Me.RadSplitContainer2.Location = New System.Drawing.Point(9, 9)
        Me.RadSplitContainer2.Name = "RadSplitContainer2"
        '
        '
        '
        Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer2.Size = New System.Drawing.Size(941, 424)
        Me.RadSplitContainer2.TabIndex = 6
        Me.RadSplitContainer2.TabStop = False
        '
        'SplitPanel3
        '
        Me.SplitPanel3.Controls.Add(Me.RadGroupBox2)
        Me.SplitPanel3.Location = New System.Drawing.Point(0, 0)
        Me.SplitPanel3.Name = "SplitPanel3"
        '
        '
        '
        Me.SplitPanel3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.SplitPanel3.Size = New System.Drawing.Size(606, 424)
        Me.SplitPanel3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.1467449!, 0!)
        Me.SplitPanel3.SizeInfo.SplitterCorrection = New System.Drawing.Size(141, 0)
        Me.SplitPanel3.TabIndex = 0
        Me.SplitPanel3.TabStop = False
        Me.SplitPanel3.Text = "SplitPanel3"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.GrdPermission)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox2.HeaderText = "حق دسترسی ها"
        Me.RadGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox2.Size = New System.Drawing.Size(606, 424)
        Me.RadGroupBox2.TabIndex = 4
        Me.RadGroupBox2.Text = "حق دسترسی ها"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'GrdPermission
        '
        Me.GrdPermission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdPermission.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdPermission.Location = New System.Drawing.Point(2, 18)
        '
        '
        '
        Me.GrdPermission.MasterTemplate.AllowAddNewRow = False
        Me.GrdPermission.MasterTemplate.EnableAlternatingRowColor = True
        Me.GrdPermission.MasterTemplate.EnableFiltering = True
        Me.GrdPermission.MasterTemplate.EnableGrouping = False
        Me.GrdPermission.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GrdPermission.Name = "GrdPermission"
        Me.GrdPermission.ProgressBar = Nothing
        Me.GrdPermission.Size = New System.Drawing.Size(602, 404)
        Me.GrdPermission.TabIndex = 1
        Me.GrdPermission.ValidChar = Nothing
        '
        'SplitPanel4
        '
        Me.SplitPanel4.Controls.Add(Me.RadGroupBox3)
        Me.SplitPanel4.Location = New System.Drawing.Point(610, 0)
        Me.SplitPanel4.Name = "SplitPanel4"
        '
        '
        '
        Me.SplitPanel4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.SplitPanel4.Size = New System.Drawing.Size(331, 424)
        Me.SplitPanel4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1467449!, 0!)
        Me.SplitPanel4.SizeInfo.SplitterCorrection = New System.Drawing.Size(-141, 0)
        Me.SplitPanel4.TabIndex = 1
        Me.SplitPanel4.TabStop = False
        Me.SplitPanel4.Text = "SplitPanel4"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.GrdUser)
        Me.RadGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox3.HeaderText = "لیست کاربران"
        Me.RadGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox3.Size = New System.Drawing.Size(331, 424)
        Me.RadGroupBox3.TabIndex = 5
        Me.RadGroupBox3.Text = "لیست کاربران"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'GrdUser
        '
        Me.GrdUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdUser.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdUser.Location = New System.Drawing.Point(2, 18)
        '
        '
        '
        Me.GrdUser.MasterTemplate.AllowAddNewRow = False
        Me.GrdUser.MasterTemplate.EnableAlternatingRowColor = True
        Me.GrdUser.MasterTemplate.EnableFiltering = True
        Me.GrdUser.MasterTemplate.EnableGrouping = False
        Me.GrdUser.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GrdUser.Name = "GrdUser"
        Me.GrdUser.ProgressBar = Nothing
        Me.GrdUser.ReadOnly = True
        Me.GrdUser.Size = New System.Drawing.Size(327, 404)
        Me.GrdUser.TabIndex = 0
        Me.GrdUser.ValidChar = Nothing
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(12, 439)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'ChkSelectAll
        '
        Me.ChkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSelectAll.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkSelectAll.Location = New System.Drawing.Point(128, 446)
        Me.ChkSelectAll.Name = "ChkSelectAll"
        Me.ChkSelectAll.Size = New System.Drawing.Size(75, 17)
        Me.ChkSelectAll.TabIndex = 7
        Me.ChkSelectAll.Text = "انتخاب همه"
        '
        'FrmPermission
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(959, 479)
        Me.Controls.Add(Me.ChkSelectAll)
        Me.Controls.Add(Me.RadSplitContainer2)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmPermission"
        Me.ShowSettingButton = False
        Me.Text = "حق دسترسی کاربران"
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer2.ResumeLayout(False)
        CType(Me.SplitPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitPanel3.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.GrdPermission.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdPermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitPanel4.ResumeLayout(False)
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.GrdUser.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents SplitPanel1 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents SplitPanel2 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents GrdUser As UserControls.RadGridView
    Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents SplitPanel3 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents SplitPanel4 As Telerik.WinControls.UI.SplitPanel
    Friend WithEvents GrdPermission As UserControls.RadGridView
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents ChkSelectAll As Telerik.WinControls.UI.RadCheckBox
End Class
