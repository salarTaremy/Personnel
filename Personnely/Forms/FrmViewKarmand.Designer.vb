<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewKarmand
    Inherits Permission.ClsMyForms

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewKarmand))
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.Grd = New UserControls.RadGridView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ChkPhoto = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtAzID_TH = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtTaID_TH = New Telerik.WinControls.UI.RadSpinEditor()
        Me.TxtTaCodePr = New UserControls.RadTextBoxLimited()
        Me.TxtName = New UserControls.RadTextBox()
        Me.TxtCode_melli = New UserControls.RadTextBoxLimited()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtAzCodePr = New UserControls.RadTextBoxLimited()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnReport = New Telerik.WinControls.UI.RadButton()
        Me.BtnSelect = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.CmbCompany = New UserControls.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.CmbKargah = New UserControls.RadDropDownList()
        Me.chkAll = New Telerik.WinControls.UI.RadCheckBox()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.ChkPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAzID_TH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTaID_TH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTaCodePr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCode_melli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAzCodePr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKargah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.chkAll)
        Me.RadGroupBox1.Controls.Add(Me.UcRadGridViewTools1)
        Me.RadGroupBox1.Controls.Add(Me.Grd)
        Me.RadGroupBox1.Controls.Add(Me.ChkPhoto)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "لیست کارمندان"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(941, 309)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.Text = "لیست کارمندان"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'UcRadGridViewTools1
        '
        Me.UcRadGridViewTools1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools1.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools1.GridView = Me.Grd
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(5, 262)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(931, 42)
        Me.UcRadGridViewTools1.TabIndex = 14
        '
        'Grd
        '
        Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd.AutoSizeRows = True
        Me.Grd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Grd.Location = New System.Drawing.Point(5, 44)
        '
        '
        '
        Me.Grd.MasterTemplate.AllowAddNewRow = False
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.ProgressBar = Nothing
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(931, 212)
        Me.Grd.TabIndex = 0
        Me.Grd.ValidChar = Nothing
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox2.Controls.Add(Me.CmbKargah)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox2.Controls.Add(Me.CmbCompany)
        Me.RadGroupBox2.Controls.Add(Me.TxtAzID_TH)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.TxtTaID_TH)
        Me.RadGroupBox2.Controls.Add(Me.TxtTaCodePr)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox2.Controls.Add(Me.TxtAzCodePr)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.TxtCode_melli)
        Me.RadGroupBox2.Controls.Add(Me.TxtName)
        Me.RadGroupBox2.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox2.HeaderText = "جستجو بر اساس"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox2.Size = New System.Drawing.Size(941, 81)
        Me.RadGroupBox2.TabIndex = 2
        Me.RadGroupBox2.Text = "جستجو بر اساس"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'ChkPhoto
        '
        Me.ChkPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPhoto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPhoto.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkPhoto.Location = New System.Drawing.Point(605, 21)
        Me.ChkPhoto.Name = "ChkPhoto"
        Me.ChkPhoto.Size = New System.Drawing.Size(122, 17)
        Me.ChkPhoto.TabIndex = 8
        Me.ChkPhoto.Text = "نمایش تصویر پرسنلی"
        Me.ChkPhoto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadLabel8
        '
        Me.RadLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel8.Location = New System.Drawing.Point(858, 48)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(74, 17)
        Me.RadLabel8.TabIndex = 16
        Me.RadLabel8.Text = "تا کد پرسنلی:"
        Me.RadLabel8.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtAzID_TH
        '
        Me.TxtAzID_TH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAzID_TH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtAzID_TH.Location = New System.Drawing.Point(564, 22)
        Me.TxtAzID_TH.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.TxtAzID_TH.Name = "TxtAzID_TH"
        Me.TxtAzID_TH.Size = New System.Drawing.Size(83, 19)
        Me.TxtAzID_TH.TabIndex = 2
        Me.TxtAzID_TH.TabStop = False
        Me.TxtAzID_TH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(650, 23)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(90, 17)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "ازکد طرف حساب:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(650, 48)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(93, 17)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "تا کد طرف حساب:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtTaID_TH
        '
        Me.TxtTaID_TH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTaID_TH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTaID_TH.Location = New System.Drawing.Point(564, 47)
        Me.TxtTaID_TH.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtTaID_TH.Name = "TxtTaID_TH"
        Me.TxtTaID_TH.Size = New System.Drawing.Size(83, 19)
        Me.TxtTaID_TH.TabIndex = 3
        Me.TxtTaID_TH.TabStop = False
        Me.TxtTaID_TH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTaCodePr
        '
        Me.TxtTaCodePr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTaCodePr.FocusColor = System.Drawing.Color.Azure
        Me.TxtTaCodePr.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTaCodePr.IsRequierd = False
        Me.TxtTaCodePr.Location = New System.Drawing.Point(751, 47)
        Me.TxtTaCodePr.Name = "TxtTaCodePr"
        Me.TxtTaCodePr.Name_Farsi = Nothing
        Me.TxtTaCodePr.NextObject = Me.TxtName
        Me.TxtTaCodePr.NullText = "فقط عدد"
        Me.TxtTaCodePr.Size = New System.Drawing.Size(101, 19)
        Me.TxtTaCodePr.TabIndex = 1
        Me.TxtTaCodePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTaCodePr.ValidCharacters = "0123456789"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.FocusColor = System.Drawing.Color.Azure
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.IsRequierd = False
        Me.TxtName.Location = New System.Drawing.Point(376, 22)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Name_Farsi = Nothing
        Me.TxtName.NextObject = Me.TxtCode_melli
        Me.TxtName.Size = New System.Drawing.Size(127, 19)
        Me.TxtName.TabIndex = 6
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCode_melli
        '
        Me.TxtCode_melli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCode_melli.FocusColor = System.Drawing.Color.Azure
        Me.TxtCode_melli.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtCode_melli.IsRequierd = False
        Me.TxtCode_melli.Location = New System.Drawing.Point(376, 47)
        Me.TxtCode_melli.MaxLength = 10
        Me.TxtCode_melli.Name = "TxtCode_melli"
        Me.TxtCode_melli.Name_Farsi = Nothing
        Me.TxtCode_melli.NextObject = Nothing
        Me.TxtCode_melli.NullText = "فقط عدد"
        Me.TxtCode_melli.Size = New System.Drawing.Size(127, 19)
        Me.TxtCode_melli.TabIndex = 7
        Me.TxtCode_melli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCode_melli.ValidCharacters = "0123456789"
        '
        'RadLabel7
        '
        Me.RadLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel7.Location = New System.Drawing.Point(858, 23)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(74, 17)
        Me.RadLabel7.TabIndex = 14
        Me.RadLabel7.Text = "از کد پرسنلی:"
        Me.RadLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtAzCodePr
        '
        Me.TxtAzCodePr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAzCodePr.BackColor = System.Drawing.Color.White
        Me.TxtAzCodePr.FocusColor = System.Drawing.Color.Azure
        Me.TxtAzCodePr.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtAzCodePr.IsRequierd = False
        Me.TxtAzCodePr.Location = New System.Drawing.Point(751, 22)
        Me.TxtAzCodePr.Name = "TxtAzCodePr"
        Me.TxtAzCodePr.Name_Farsi = Nothing
        Me.TxtAzCodePr.NextObject = Me.TxtTaCodePr
        Me.TxtAzCodePr.NullText = "فقط عدد"
        Me.TxtAzCodePr.Size = New System.Drawing.Size(101, 19)
        Me.TxtAzCodePr.TabIndex = 0
        Me.TxtAzCodePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAzCodePr.ValidCharacters = "0123456789"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(509, 48)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(43, 17)
        Me.RadLabel3.TabIndex = 8
        Me.RadLabel3.Text = "کدملی:"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(509, 23)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(23, 17)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "نام:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(15, 23)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 31)
        Me.BtnSearch.TabIndex = 9
        Me.BtnSearch.Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(30, 30)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(30, 30)
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.BtnReport)
        Me.RadGroupBox3.Controls.Add(Me.BtnSelect)
        Me.RadGroupBox3.Controls.Add(Me.BtnAdd)
        Me.RadGroupBox3.Controls.Add(Me.BtnDelete)
        Me.RadGroupBox3.Controls.Add(Me.BtnEdit)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox3.HeaderText = "ابزارها"
        Me.RadGroupBox3.Location = New System.Drawing.Point(12, 414)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(941, 53)
        Me.RadGroupBox3.TabIndex = 4
        Me.RadGroupBox3.Text = "ابزارها"
        '
        'BtnReport
        '
        Me.BtnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReport.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnReport.Image = Global.Personnely.My.Resources.Resources.Blue__1_
        Me.BtnReport.Location = New System.Drawing.Point(478, 17)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(110, 31)
        Me.BtnReport.TabIndex = 57
        Me.BtnReport.Text = "گزارشات"
        CType(Me.BtnReport.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__1_
        CType(Me.BtnReport.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "گزارشات"
        CType(Me.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnSelect
        '
        Me.BtnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(5, 17)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(110, 31)
        Me.BtnSelect.TabIndex = 10
        Me.BtnSelect.Text = "تایید"
        Me.BtnSelect.Visible = False
        CType(Me.BtnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "تایید"
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAdd.Image = Global.Personnely.My.Resources.Resources.Blue__17_
        Me.BtnAdd.Location = New System.Drawing.Point(594, 17)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 31)
        Me.BtnAdd.TabIndex = 13
        Me.BtnAdd.Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__17_
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(710, 17)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = Global.Personnely.My.Resources.Resources.Blue__33_
        Me.BtnEdit.Location = New System.Drawing.Point(826, 17)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 31)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__33_
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'RadLabel9
        '
        Me.RadLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel9.Location = New System.Drawing.Point(310, 23)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(59, 17)
        Me.RadLabel9.TabIndex = 50
        Me.RadLabel9.Text = "نام شرکت:"
        Me.RadLabel9.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'CmbCompany
        '
        Me.CmbCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCompany.DefaultItemsCountInDropDown = 15
        Me.CmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbCompany.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbCompany.Location = New System.Drawing.Point(163, 22)
        Me.CmbCompany.Name = "CmbCompany"
        Me.CmbCompany.Size = New System.Drawing.Size(141, 19)
        Me.CmbCompany.TabIndex = 49
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel5.Location = New System.Drawing.Point(310, 48)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(37, 17)
        Me.RadLabel5.TabIndex = 52
        Me.RadLabel5.Text = "کارگاه:"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'CmbKargah
        '
        Me.CmbKargah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbKargah.DefaultItemsCountInDropDown = 15
        Me.CmbKargah.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbKargah.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbKargah.Location = New System.Drawing.Point(163, 47)
        Me.CmbKargah.Name = "CmbKargah"
        Me.CmbKargah.Size = New System.Drawing.Size(141, 19)
        Me.CmbKargah.TabIndex = 51
        '
        'chkAll
        '
        Me.chkAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAll.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.chkAll.Location = New System.Drawing.Point(810, 21)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(122, 17)
        Me.chkAll.TabIndex = 9
        Me.chkAll.Text = "نمایش افراد فاقد حکم"
        Me.chkAll.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'FrmViewKarmand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 479)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.DefaultTextBox = Me.TxtAzCodePr
        Me.Name = "FrmViewKarmand"
        Me.Text = "نمایش وتغییر کارمندان"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.ChkPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAzID_TH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTaID_TH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTaCodePr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCode_melli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAzCodePr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKargah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtCode_melli As UserControls.RadTextBoxLimited
    Public WithEvents TxtName As UserControls.RadTextBox
    Friend WithEvents TxtTaID_TH As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtAzID_TH As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnSelect As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtAzCodePr As UserControls.RadTextBoxLimited
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtTaCodePr As UserControls.RadTextBoxLimited
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
    Friend WithEvents ChkPhoto As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents BtnReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CmbCompany As UserControls.RadDropDownList
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CmbKargah As UserControls.RadDropDownList
    Friend WithEvents chkAll As Telerik.WinControls.UI.RadCheckBox
End Class
