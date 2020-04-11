<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRadGridViewTools
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcRadGridViewTools))
        Me.BtnExcel = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnVisibleC = New Telerik.WinControls.UI.RadButton()
        Me.BtnHeaderTextC = New Telerik.WinControls.UI.RadButton()
        Me.BtnHeaderText = New Telerik.WinControls.UI.RadButton()
        Me.BtnColumnSizeC = New Telerik.WinControls.UI.RadButton()
        Me.BtnColumnSize = New Telerik.WinControls.UI.RadButton()
        Me.BtnResize = New Telerik.WinControls.UI.RadButton()
        Me.BtnFilter = New Telerik.WinControls.UI.RadToggleButton()
        Me.BtnGroup = New Telerik.WinControls.UI.RadToggleButton()
        Me.BtnSearch = New Telerik.WinControls.UI.RadToggleButton()
        Me.BtnSum = New Telerik.WinControls.UI.RadToggleButton()
        Me.LblChildCount = New Telerik.WinControls.UI.RadLabel()
        Me.LblCount = New Telerik.WinControls.UI.RadLabel()
        Me.BtnVisible = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.BtnHtml = New Telerik.WinControls.UI.RadButton()
        Me.BtnPdf = New Telerik.WinControls.UI.RadButton()
        Me.BtnCsv = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.BtnExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.BtnVisibleC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHeaderTextC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHeaderText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColumnSizeC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnColumnSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnResize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblChildCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHtml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCsv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExcel
        '
        Me.BtnExcel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExcel.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnExcel.Enabled = False
        Me.BtnExcel.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnExcel.Location = New System.Drawing.Point(2, 2)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnExcel.Size = New System.Drawing.Size(38, 38)
        Me.BtnExcel.TabIndex = 0
        Me.BtnExcel.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnExcel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnExcel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnExcel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnExcel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnExcel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        CType(Me.BtnExcel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnExcel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnExcel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnExcel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.BtnVisible)
        Me.RadGroupBox1.Controls.Add(Me.BtnVisibleC)
        Me.RadGroupBox1.Controls.Add(Me.BtnHeaderTextC)
        Me.RadGroupBox1.Controls.Add(Me.BtnHeaderText)
        Me.RadGroupBox1.Controls.Add(Me.BtnColumnSizeC)
        Me.RadGroupBox1.Controls.Add(Me.BtnColumnSize)
        Me.RadGroupBox1.Controls.Add(Me.BtnResize)
        Me.RadGroupBox1.Controls.Add(Me.BtnFilter)
        Me.RadGroupBox1.Controls.Add(Me.BtnGroup)
        Me.RadGroupBox1.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox1.Controls.Add(Me.BtnSum)
        Me.RadGroupBox1.Controls.Add(Me.LblChildCount)
        Me.RadGroupBox1.Controls.Add(Me.LblCount)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.BtnHtml)
        Me.RadGroupBox1.Controls.Add(Me.BtnPdf)
        Me.RadGroupBox1.Controls.Add(Me.BtnCsv)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.MinimumSize = New System.Drawing.Size(40, 42)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RadGroupBox1.RootElement.MinSize = New System.Drawing.Size(40, 42)
        Me.RadGroupBox1.Size = New System.Drawing.Size(583, 42)
        Me.RadGroupBox1.TabIndex = 1
        '
        'BtnVisibleC
        '
        Me.BtnVisibleC.Location = New System.Drawing.Point(174, 21)
        Me.BtnVisibleC.Name = "BtnVisibleC"
        Me.BtnVisibleC.Size = New System.Drawing.Size(50, 19)
        Me.BtnVisibleC.TabIndex = 5
        Me.BtnVisibleC.Text = "C#_Visible"
        Me.BtnVisibleC.Visible = False
        '
        'BtnHeaderTextC
        '
        Me.BtnHeaderTextC.Location = New System.Drawing.Point(225, 21)
        Me.BtnHeaderTextC.Name = "BtnHeaderTextC"
        Me.BtnHeaderTextC.Size = New System.Drawing.Size(41, 19)
        Me.BtnHeaderTextC.TabIndex = 3
        Me.BtnHeaderTextC.Text = "C#_Txt"
        Me.BtnHeaderTextC.Visible = False
        '
        'BtnHeaderText
        '
        Me.BtnHeaderText.Location = New System.Drawing.Point(225, 2)
        Me.BtnHeaderText.Name = "BtnHeaderText"
        Me.BtnHeaderText.Size = New System.Drawing.Size(41, 19)
        Me.BtnHeaderText.TabIndex = 1
        Me.BtnHeaderText.Text = "VB_Txt"
        Me.BtnHeaderText.Visible = False
        '
        'BtnColumnSizeC
        '
        Me.BtnColumnSizeC.Location = New System.Drawing.Point(267, 21)
        Me.BtnColumnSizeC.Name = "BtnColumnSizeC"
        Me.BtnColumnSizeC.Size = New System.Drawing.Size(48, 19)
        Me.BtnColumnSizeC.TabIndex = 2
        Me.BtnColumnSizeC.Text = "C#_Size"
        Me.BtnColumnSizeC.Visible = False
        '
        'BtnColumnSize
        '
        Me.BtnColumnSize.Location = New System.Drawing.Point(267, 2)
        Me.BtnColumnSize.Name = "BtnColumnSize"
        Me.BtnColumnSize.Size = New System.Drawing.Size(48, 19)
        Me.BtnColumnSize.TabIndex = 0
        Me.BtnColumnSize.Text = "VB_Size"
        Me.BtnColumnSize.Visible = False
        '
        'BtnResize
        '
        Me.BtnResize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnResize.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnResize.Enabled = False
        Me.BtnResize.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnResize.Image = CType(resources.GetObject("BtnResize.Image"), System.Drawing.Image)
        Me.BtnResize.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnResize.Location = New System.Drawing.Point(220, 2)
        Me.BtnResize.Name = "BtnResize"
        Me.BtnResize.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnResize.Size = New System.Drawing.Size(38, 38)
        Me.BtnResize.TabIndex = 8
        Me.BtnResize.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnResize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnResize.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnResize.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnResize.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnResize.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnResize.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        CType(Me.BtnResize.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnResize.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnResize.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnResize.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnFilter
        '
        Me.BtnFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFilter.Enabled = False
        Me.BtnFilter.Image = CType(resources.GetObject("BtnFilter.Image"), System.Drawing.Image)
        Me.BtnFilter.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnFilter.Location = New System.Drawing.Point(352, 2)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(38, 38)
        Me.BtnFilter.TabIndex = 5
        Me.BtnFilter.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnFilter.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        CType(Me.BtnFilter.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnFilter.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnFilter.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnFilter.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = ""
        CType(Me.BtnFilter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnFilter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnFilter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Tahoma", 8.25!)
        CType(Me.BtnFilter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnFilter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnGroup
        '
        Me.BtnGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGroup.Enabled = False
        Me.BtnGroup.Image = CType(resources.GetObject("BtnGroup.Image"), System.Drawing.Image)
        Me.BtnGroup.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnGroup.Location = New System.Drawing.Point(264, 2)
        Me.BtnGroup.Name = "BtnGroup"
        Me.BtnGroup.Size = New System.Drawing.Size(38, 38)
        Me.BtnGroup.TabIndex = 7
        Me.BtnGroup.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnGroup.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        CType(Me.BtnGroup.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnGroup.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnGroup.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnGroup.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnGroup.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnGroup.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Tahoma", 8.25!)
        CType(Me.BtnGroup.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnGroup.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.Enabled = False
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSearch.Location = New System.Drawing.Point(308, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(38, 38)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = ""
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Tahoma", 8.25!)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnSum
        '
        Me.BtnSum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSum.Enabled = False
        Me.BtnSum.Image = CType(resources.GetObject("BtnSum.Image"), System.Drawing.Image)
        Me.BtnSum.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSum.Location = New System.Drawing.Point(396, 2)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(38, 38)
        Me.BtnSum.TabIndex = 4
        Me.BtnSum.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnSum.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        CType(Me.BtnSum.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnSum.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnSum.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnSum.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSum.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSum.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Font = New System.Drawing.Font("Tahoma", 8.25!)
        CType(Me.BtnSum.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSum.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'LblChildCount
        '
        Me.LblChildCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblChildCount.AutoSize = False
        Me.LblChildCount.BorderVisible = True
        Me.LblChildCount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblChildCount.ForeColor = System.Drawing.Color.Blue
        Me.LblChildCount.Location = New System.Drawing.Point(438, 21)
        Me.LblChildCount.Name = "LblChildCount"
        Me.LblChildCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblChildCount.Size = New System.Drawing.Size(78, 19)
        Me.LblChildCount.TabIndex = 451
        Me.LblChildCount.Text = "0"
        Me.LblChildCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblChildCount.TextWrap = False
        CType(Me.LblChildCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
        CType(Me.LblChildCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.LblChildCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "0"
        CType(Me.LblChildCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.LblChildCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.LblChildCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'LblCount
        '
        Me.LblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCount.AutoSize = False
        Me.LblCount.BorderVisible = True
        Me.LblCount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblCount.ForeColor = System.Drawing.Color.Blue
        Me.LblCount.Location = New System.Drawing.Point(438, 2)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblCount.Size = New System.Drawing.Size(78, 19)
        Me.LblCount.TabIndex = 450
        Me.LblCount.Text = "0"
        Me.LblCount.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblCount.TextWrap = False
        CType(Me.LblCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).BorderVisible = True
        CType(Me.LblCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.LblCount.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "0"
        CType(Me.LblCount.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        CType(Me.LblCount.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Blue
        CType(Me.LblCount.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.LblCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.LblCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.LblCount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'BtnVisible
        '
        Me.BtnVisible.Location = New System.Drawing.Point(174, 2)
        Me.BtnVisible.Name = "BtnVisible"
        Me.BtnVisible.Size = New System.Drawing.Size(48, 19)
        Me.BtnVisible.TabIndex = 4
        Me.BtnVisible.Text = "VB_Visible"
        Me.BtnVisible.Visible = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.ForeColor = System.Drawing.Color.Blue
        Me.RadLabel1.Location = New System.Drawing.Point(522, 20)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadLabel1.Size = New System.Drawing.Size(58, 17)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "فیلتر شده:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'BtnHtml
        '
        Me.BtnHtml.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnHtml.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnHtml.Enabled = False
        Me.BtnHtml.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnHtml.Image = CType(resources.GetObject("BtnHtml.Image"), System.Drawing.Image)
        Me.BtnHtml.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnHtml.Location = New System.Drawing.Point(134, 2)
        Me.BtnHtml.Name = "BtnHtml"
        Me.BtnHtml.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnHtml.Size = New System.Drawing.Size(38, 38)
        Me.BtnHtml.TabIndex = 3
        Me.BtnHtml.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnHtml.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnHtml.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        CType(Me.BtnHtml.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnHtml.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnHtml.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnHtml.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        CType(Me.BtnHtml.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnHtml.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnHtml.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnHtml.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnPdf
        '
        Me.BtnPdf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPdf.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnPdf.Enabled = False
        Me.BtnPdf.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnPdf.Image = CType(resources.GetObject("BtnPdf.Image"), System.Drawing.Image)
        Me.BtnPdf.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPdf.Location = New System.Drawing.Point(90, 2)
        Me.BtnPdf.Name = "BtnPdf"
        Me.BtnPdf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnPdf.Size = New System.Drawing.Size(38, 38)
        Me.BtnPdf.TabIndex = 2
        Me.BtnPdf.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnPdf.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        CType(Me.BtnPdf.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnPdf.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnPdf.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnPdf.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        CType(Me.BtnPdf.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnPdf.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnPdf.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnPdf.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnCsv
        '
        Me.BtnCsv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCsv.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnCsv.Enabled = False
        Me.BtnCsv.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnCsv.Image = CType(resources.GetObject("BtnCsv.Image"), System.Drawing.Image)
        Me.BtnCsv.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCsv.Location = New System.Drawing.Point(46, 2)
        Me.BtnCsv.Name = "BtnCsv"
        Me.BtnCsv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnCsv.Size = New System.Drawing.Size(38, 38)
        Me.BtnCsv.TabIndex = 1
        Me.BtnCsv.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnCsv.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        CType(Me.BtnCsv.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnCsv.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnCsv.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnCsv.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        CType(Me.BtnCsv.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnCsv.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnCsv.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnCsv.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.ForeColor = System.Drawing.Color.Blue
        Me.RadLabel2.Location = New System.Drawing.Point(522, 2)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadLabel2.Size = New System.Drawing.Size(55, 17)
        Me.RadLabel2.TabIndex = 5
        Me.RadLabel2.Text = "تعداد(کل):"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'UcRadGridViewTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BtnExcel)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.MinimumSize = New System.Drawing.Size(540, 42)
        Me.Name = "UcRadGridViewTools"
        Me.Size = New System.Drawing.Size(583, 42)
        CType(Me.BtnExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.BtnVisibleC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHeaderTextC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHeaderText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColumnSizeC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnColumnSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnResize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblChildCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHtml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCsv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnExcel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnHtml As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPdf As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnCsv As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LblChildCount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LblCount As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnSum As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents BtnGroup As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents BtnFilter As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents BtnResize As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnHeaderText As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnColumnSize As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnHeaderTextC As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnColumnSizeC As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnVisibleC As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnVisible As Telerik.WinControls.UI.RadButton
End Class
