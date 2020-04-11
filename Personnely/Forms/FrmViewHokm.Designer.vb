<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewHokm
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
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewHokm))
        Me.Grd = New UserControls.RadGridView()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.CmbCompany = New UserControls.RadDropDownList()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.CmbMahalleKhedmat = New UserControls.RadDropDownList()
        Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.ChkActiveHokm = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtPrCode = New UserControls.RadTextBox()
        Me.TxtPrName = New UserControls.RadTextBox()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.BtnBrows = New Telerik.WinControls.UI.RadButton()
        Me.TxtPrID = New UserControls.RadTextBoxLimited()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.BtnDeLapse = New Telerik.WinControls.UI.RadButton()
        Me.BtnLapse = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnReport = New Telerik.WinControls.UI.RadButton()
        Me.CmbKargah = New UserControls.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbMahalleKhedmat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkActiveHokm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.BtnDeLapse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLapse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbKargah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grd
        '
        Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Grd.Location = New System.Drawing.Point(5, 21)
        '
        '
        '
        Me.Grd.MasterTemplate.AllowAddNewRow = False
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.Grd.Name = "Grd"
        Me.Grd.ProgressBar = Nothing
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(913, 311)
        Me.Grd.TabIndex = 0
        Me.Grd.ValidChar = Nothing
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(864, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(54, 17)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "کد کارمند:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.CmbKargah)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.CmbCompany)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.CmbMahalleKhedmat)
        Me.RadGroupBox1.Controls.Add(Me.radLabel3)
        Me.RadGroupBox1.Controls.Add(Me.ChkActiveHokm)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.TxtPrCode)
        Me.RadGroupBox1.Controls.Add(Me.TxtPrName)
        Me.RadGroupBox1.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox1.Controls.Add(Me.BtnBrows)
        Me.RadGroupBox1.Controls.Add(Me.TxtPrID)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "فیلتر"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(923, 103)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.Text = "فیلتر"
        '
        'CmbCompany
        '
        Me.CmbCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCompany.DefaultItemsCountInDropDown = 15
        Me.CmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbCompany.Location = New System.Drawing.Point(333, 21)
        Me.CmbCompany.Name = "CmbCompany"
        Me.CmbCompany.Size = New System.Drawing.Size(148, 19)
        Me.CmbCompany.TabIndex = 65
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(487, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel4.TabIndex = 66
        Me.RadLabel4.Text = "شرکت:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'CmbMahalleKhedmat
        '
        Me.CmbMahalleKhedmat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMahalleKhedmat.DefaultItemsCountInDropDown = 15
        Me.CmbMahalleKhedmat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbMahalleKhedmat.Location = New System.Drawing.Point(333, 71)
        Me.CmbMahalleKhedmat.Name = "CmbMahalleKhedmat"
        Me.CmbMahalleKhedmat.Size = New System.Drawing.Size(148, 19)
        Me.CmbMahalleKhedmat.TabIndex = 63
        '
        'radLabel3
        '
        Me.radLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.radLabel3.Location = New System.Drawing.Point(487, 72)
        Me.radLabel3.Name = "radLabel3"
        Me.radLabel3.Size = New System.Drawing.Size(65, 17)
        Me.radLabel3.TabIndex = 64
        Me.radLabel3.Text = "محل خدمت:"
        Me.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'ChkActiveHokm
        '
        Me.ChkActiveHokm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkActiveHokm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActiveHokm.Location = New System.Drawing.Point(676, 70)
        Me.ChkActiveHokm.Name = "ChkActiveHokm"
        Me.ChkActiveHokm.Size = New System.Drawing.Size(182, 18)
        Me.ChkActiveHokm.TabIndex = 62
        Me.ChkActiveHokm.Text = "فقط احکام فعال  نمایش داده شوند"
        Me.ChkActiveHokm.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(664, 21)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 17)
        Me.RadLabel2.TabIndex = 61
        Me.RadLabel2.Text = "کد پرسنلی:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtPrCode
        '
        Me.TxtPrCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrCode.FocusColor = System.Drawing.Color.Azure
        Me.TxtPrCode.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrCode.IsRequierd = False
        Me.TxtPrCode.Location = New System.Drawing.Point(560, 20)
        Me.TxtPrCode.Name = "TxtPrCode"
        Me.TxtPrCode.Name_Farsi = Nothing
        Me.TxtPrCode.NextObject = Nothing
        Me.TxtPrCode.NullText = "----------"
        Me.TxtPrCode.ReadOnly = True
        Me.TxtPrCode.Size = New System.Drawing.Size(98, 19)
        Me.TxtPrCode.TabIndex = 60
        Me.TxtPrCode.TabStop = False
        Me.TxtPrCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtPrCode.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtPrCode.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtPrCode.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TxtPrName
        '
        Me.TxtPrName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrName.FocusColor = System.Drawing.Color.Azure
        Me.TxtPrName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrName.IsRequierd = False
        Me.TxtPrName.Location = New System.Drawing.Point(560, 45)
        Me.TxtPrName.Name = "TxtPrName"
        Me.TxtPrName.Name_Farsi = Nothing
        Me.TxtPrName.NextObject = Nothing
        Me.TxtPrName.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtPrName.ReadOnly = True
        Me.TxtPrName.Size = New System.Drawing.Size(298, 19)
        Me.TxtPrName.TabIndex = 59
        Me.TxtPrName.TabStop = False
        Me.TxtPrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtPrName.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtPrName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtPrName.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(5, 67)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 31)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(30, 30)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(30, 30)
        '
        'BtnBrows
        '
        Me.BtnBrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows.Image = Global.Personnely.My.Resources.Resources.Search_icon
        Me.BtnBrows.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows.Location = New System.Drawing.Point(839, 20)
        Me.BtnBrows.Name = "BtnBrows"
        Me.BtnBrows.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows.TabIndex = 1
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Search_icon
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = ""
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(16, 16)
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(16, 16)
        '
        'TxtPrID
        '
        Me.TxtPrID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrID.FocusColor = System.Drawing.Color.Azure
        Me.TxtPrID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrID.IsRequierd = False
        Me.TxtPrID.Location = New System.Drawing.Point(734, 20)
        Me.TxtPrID.Name = "TxtPrID"
        Me.TxtPrID.Name_Farsi = Nothing
        Me.TxtPrID.NextObject = Nothing
        Me.TxtPrID.NullText = "فقط عدد"
        Me.TxtPrID.Size = New System.Drawing.Size(99, 19)
        Me.TxtPrID.TabIndex = 0
        Me.TxtPrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPrID.ValidCharacters = "0123456789"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.UcRadGridViewTools1)
        Me.RadGroupBox2.Controls.Add(Me.Grd)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox2.HeaderText = "لیست احکام"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(923, 385)
        Me.RadGroupBox2.TabIndex = 3
        Me.RadGroupBox2.Text = "لیست احکام"
        '
        'UcRadGridViewTools1
        '
        Me.UcRadGridViewTools1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools1.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools1.GridView = Me.Grd
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(5, 338)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(913, 42)
        Me.UcRadGridViewTools1.TabIndex = 1
        '
        'BtnDeLapse
        '
        Me.BtnDeLapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeLapse.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDeLapse.Image = Global.Personnely.My.Resources.Resources.Blue__16_
        Me.BtnDeLapse.Location = New System.Drawing.Point(361, 512)
        Me.BtnDeLapse.Name = "BtnDeLapse"
        Me.BtnDeLapse.Size = New System.Drawing.Size(110, 31)
        Me.BtnDeLapse.TabIndex = 7
        Me.BtnDeLapse.Text = "عدم ابطال"
        CType(Me.BtnDeLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__16_
        CType(Me.BtnDeLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "عدم ابطال"
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnLapse
        '
        Me.BtnLapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLapse.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnLapse.Image = Global.Personnely.My.Resources.Resources.Blue__15_
        Me.BtnLapse.Location = New System.Drawing.Point(477, 512)
        Me.BtnLapse.Name = "BtnLapse"
        Me.BtnLapse.Size = New System.Drawing.Size(110, 31)
        Me.BtnLapse.TabIndex = 6
        Me.BtnLapse.Text = "ابطال"
        CType(Me.BtnLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__15_
        CType(Me.BtnLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ابطال"
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAdd.Image = Global.Personnely.My.Resources.Resources.Blue__17_
        Me.BtnAdd.Location = New System.Drawing.Point(593, 512)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 31)
        Me.BtnAdd.TabIndex = 5
        Me.BtnAdd.Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__17_
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = Global.Personnely.My.Resources.Resources.Blue__33_
        Me.BtnEdit.Location = New System.Drawing.Point(825, 512)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 31)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__33_
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(709, 512)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnReport
        '
        Me.BtnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReport.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnReport.Image = Global.Personnely.My.Resources.Resources.Blue__1_
        Me.BtnReport.Location = New System.Drawing.Point(245, 512)
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
        'CmbKargah
        '
        Me.CmbKargah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbKargah.DefaultItemsCountInDropDown = 15
        Me.CmbKargah.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbKargah.Location = New System.Drawing.Point(333, 46)
        Me.CmbKargah.Name = "CmbKargah"
        Me.CmbKargah.Size = New System.Drawing.Size(148, 19)
        Me.CmbKargah.TabIndex = 67
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel5.Location = New System.Drawing.Point(487, 47)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(37, 17)
        Me.RadLabel5.TabIndex = 68
        Me.RadLabel5.Text = "کارگاه:"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'FrmViewHokm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 555)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnDeLapse)
        Me.Controls.Add(Me.BtnLapse)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.DefaultButton = Me.BtnBrows
        Me.Name = "FrmViewHokm"
        Me.Text = "مشاهده و تغییر احکام"
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbMahalleKhedmat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkActiveHokm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.BtnDeLapse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLapse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbKargah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TxtPrID As UserControls.RadTextBoxLimited
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnBrows As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrName As UserControls.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtPrCode As UserControls.RadTextBox
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDeLapse As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnLapse As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReport As Telerik.WinControls.UI.RadButton
    Friend WithEvents ChkActiveHokm As Telerik.WinControls.UI.RadCheckBox
    Private WithEvents CmbMahalleKhedmat As UserControls.RadDropDownList
    Private WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
    Private WithEvents CmbCompany As UserControls.RadDropDownList
    Private WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Private WithEvents CmbKargah As UserControls.RadDropDownList
    Private WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
End Class
