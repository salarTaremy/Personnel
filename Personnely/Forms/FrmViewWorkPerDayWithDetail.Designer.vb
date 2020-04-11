<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewWorkPerDayWithDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewWorkPerDayWithDetail))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnBrows = New Telerik.WinControls.UI.RadButton()
        Me.TxtPrID = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools2 = New UserControls.UcRadGridViewTools()
        Me.Grd = New UserControls.RadGridView()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.ChkViewLapse = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkViewLeave = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkViewMission = New Telerik.WinControls.UI.RadCheckBox()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtName1 = New UserControls.RadTextBox()
        Me.UcDatePicker2 = New UserControls.UcDatePicker()
        Me.UcDatePicker1 = New UserControls.UcDatePicker()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnLapse = New Telerik.WinControls.UI.RadButton()
        Me.BtnDeLapse = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnDeleteAll = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnReport = New Telerik.WinControls.UI.RadButton()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.ChkViewLapse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkViewLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkViewMission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLapse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDeLapse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(746, 17)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnBrows
        '
        Me.BtnBrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows.Image = Global.Personnely.My.Resources.Resources.Search_icon
        Me.BtnBrows.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows.Location = New System.Drawing.Point(697, 21)
        Me.BtnBrows.Name = "BtnBrows"
        Me.BtnBrows.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows.TabIndex = 2
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
        Me.TxtPrID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrID.Location = New System.Drawing.Point(591, 21)
        Me.TxtPrID.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtPrID.Name = "TxtPrID"
        Me.TxtPrID.Size = New System.Drawing.Size(100, 19)
        Me.TxtPrID.TabIndex = 3
        Me.TxtPrID.TabStop = False
        Me.TxtPrID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(722, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(54, 17)
        Me.RadLabel4.TabIndex = 32
        Me.RadLabel4.Text = "کد کارمند:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.UcRadGridViewTools2)
        Me.RadGroupBox1.Controls.Add(Me.UcRadGridViewTools1)
        Me.RadGroupBox1.Controls.Add(Me.Grd)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "نمایش پیش فرض فایل انتخابی"
        Me.RadGroupBox1.Location = New System.Drawing.Point(11, 91)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(984, 394)
        Me.RadGroupBox1.TabIndex = 48
        Me.RadGroupBox1.Text = "نمایش پیش فرض فایل انتخابی"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'UcRadGridViewTools2
        '
        Me.UcRadGridViewTools2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools2.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools2.GridView = Me.Grd
        Me.UcRadGridViewTools2.Location = New System.Drawing.Point(5, 347)
        Me.UcRadGridViewTools2.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools2.MinimumSize = New System.Drawing.Size(540, 42)
        Me.UcRadGridViewTools2.Name = "UcRadGridViewTools2"
        Me.UcRadGridViewTools2.Size = New System.Drawing.Size(974, 42)
        Me.UcRadGridViewTools2.TabIndex = 12
        '
        'Grd
        '
        Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd.Location = New System.Drawing.Point(5, 21)
        '
        '
        '
        Me.Grd.MasterTemplate.AllowAddNewRow = False
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.MultiSelect = True
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(974, 320)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "RadGridView1"
        Me.Grd.ValidChar = Nothing
        '
        'UcRadGridViewTools1
        '
        Me.UcRadGridViewTools1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools1.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools1.GridView = Me.Grd
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(5, 495)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(974, 42)
        Me.UcRadGridViewTools1.TabIndex = 11
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(929, 47)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel2.TabIndex = 31
        Me.RadLabel2.Text = "تا تاریخ:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(929, 22)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel1.TabIndex = 29
        Me.RadLabel1.Text = "از تاریخ:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.ChkViewLapse)
        Me.RadGroupBox2.Controls.Add(Me.ChkViewLeave)
        Me.RadGroupBox2.Controls.Add(Me.ChkViewMission)
        Me.RadGroupBox2.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.TxtName1)
        Me.RadGroupBox2.Controls.Add(Me.BtnBrows)
        Me.RadGroupBox2.Controls.Add(Me.TxtPrID)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.UcDatePicker2)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.UcDatePicker1)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.HeaderText = "فیلتر ها"
        Me.RadGroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(984, 73)
        Me.RadGroupBox2.TabIndex = 51
        Me.RadGroupBox2.Text = "فیلتر ها"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'ChkViewLapse
        '
        Me.ChkViewLapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkViewLapse.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkViewLapse.Location = New System.Drawing.Point(353, 22)
        Me.ChkViewLapse.Name = "ChkViewLapse"
        Me.ChkViewLapse.Size = New System.Drawing.Size(167, 17)
        Me.ChkViewLapse.TabIndex = 4
        Me.ChkViewLapse.Text = "نمایش همه موارد (باطل شده )"
        '
        'ChkViewLeave
        '
        Me.ChkViewLeave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkViewLeave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkViewLeave.Location = New System.Drawing.Point(240, 47)
        Me.ChkViewLeave.Name = "ChkViewLeave"
        Me.ChkViewLeave.Size = New System.Drawing.Size(107, 17)
        Me.ChkViewLeave.TabIndex = 38
        Me.ChkViewLeave.Text = "نمایش مرخصی ها"
        '
        'ChkViewMission
        '
        Me.ChkViewMission.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkViewMission.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkViewMission.Location = New System.Drawing.Point(240, 22)
        Me.ChkViewMission.Name = "ChkViewMission"
        Me.ChkViewMission.Size = New System.Drawing.Size(107, 17)
        Me.ChkViewMission.TabIndex = 37
        Me.ChkViewMission.Text = "نمایش ماموریت ها"
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(5, 32)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 31)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(30, 30)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(30, 30)
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(722, 47)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(56, 17)
        Me.RadLabel3.TabIndex = 36
        Me.RadLabel3.Text = "نام کارمند:"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtName1
        '
        Me.TxtName1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName1.FocusColor = System.Drawing.Color.Azure
        Me.TxtName1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName1.IsRequierd = False
        Me.TxtName1.Location = New System.Drawing.Point(353, 46)
        Me.TxtName1.Name = "TxtName1"
        Me.TxtName1.Name_Farsi = Nothing
        Me.TxtName1.NextObject = Nothing
        Me.TxtName1.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtName1.ReadOnly = True
        Me.TxtName1.Size = New System.Drawing.Size(363, 19)
        Me.TxtName1.TabIndex = 35
        Me.TxtName1.TabStop = False
        Me.TxtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'UcDatePicker2
        '
        Me.UcDatePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDatePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcDatePicker2.Location = New System.Drawing.Point(792, 46)
        Me.UcDatePicker2.Name = "UcDatePicker2"
        Me.UcDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcDatePicker2.Size = New System.Drawing.Size(131, 19)
        Me.UcDatePicker2.TabIndex = 1
        Me.UcDatePicker2.txt = ""
        Me.UcDatePicker2.TxtInt = 0
        '
        'UcDatePicker1
        '
        Me.UcDatePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDatePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcDatePicker1.Location = New System.Drawing.Point(792, 21)
        Me.UcDatePicker1.Name = "UcDatePicker1"
        Me.UcDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcDatePicker1.Size = New System.Drawing.Size(131, 19)
        Me.UcDatePicker1.TabIndex = 0
        Me.UcDatePicker1.txt = ""
        Me.UcDatePicker1.TxtInt = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAdd.Image = Global.Personnely.My.Resources.Resources.Blue__17_
        Me.BtnAdd.Location = New System.Drawing.Point(514, 17)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 31)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__17_
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnLapse
        '
        Me.BtnLapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLapse.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnLapse.Image = Global.Personnely.My.Resources.Resources.Blue__15_
        Me.BtnLapse.Location = New System.Drawing.Point(398, 17)
        Me.BtnLapse.Name = "BtnLapse"
        Me.BtnLapse.Size = New System.Drawing.Size(110, 31)
        Me.BtnLapse.TabIndex = 9
        Me.BtnLapse.Text = "ابطال"
        CType(Me.BtnLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__15_
        CType(Me.BtnLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ابطال"
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnDeLapse
        '
        Me.BtnDeLapse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeLapse.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDeLapse.Image = Global.Personnely.My.Resources.Resources.Blue__16_
        Me.BtnDeLapse.Location = New System.Drawing.Point(282, 17)
        Me.BtnDeLapse.Name = "BtnDeLapse"
        Me.BtnDeLapse.Size = New System.Drawing.Size(110, 31)
        Me.BtnDeLapse.TabIndex = 10
        Me.BtnDeLapse.Text = "عدم ابطال"
        CType(Me.BtnDeLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__16_
        CType(Me.BtnDeLapse.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "عدم ابطال"
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDeLapse.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = Global.Personnely.My.Resources.Resources.Blue__33_
        Me.BtnEdit.Location = New System.Drawing.Point(863, 17)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 31)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Personnely.My.Resources.Resources.Blue__33_
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDeleteAll.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDeleteAll.Image = CType(resources.GetObject("BtnDeleteAll.Image"), System.Drawing.Image)
        Me.BtnDeleteAll.Location = New System.Drawing.Point(630, 17)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(110, 31)
        Me.BtnDeleteAll.TabIndex = 52
        Me.BtnDeleteAll.Text = "حذف کلی"
        CType(Me.BtnDeleteAll.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        CType(Me.BtnDeleteAll.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف کلی"
        CType(Me.BtnDeleteAll.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDeleteAll.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDeleteAll.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDeleteAll.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.BtnReport)
        Me.RadGroupBox3.Controls.Add(Me.BtnDeLapse)
        Me.RadGroupBox3.Controls.Add(Me.BtnDeleteAll)
        Me.RadGroupBox3.Controls.Add(Me.BtnDelete)
        Me.RadGroupBox3.Controls.Add(Me.BtnEdit)
        Me.RadGroupBox3.Controls.Add(Me.BtnAdd)
        Me.RadGroupBox3.Controls.Add(Me.BtnLapse)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.HeaderText = "ابزارهای مدیریت کارکردها"
        Me.RadGroupBox3.Location = New System.Drawing.Point(11, 491)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(984, 53)
        Me.RadGroupBox3.TabIndex = 53
        Me.RadGroupBox3.Text = "ابزارهای مدیریت کارکردها"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'BtnReport
        '
        Me.BtnReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReport.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnReport.Image = Global.Personnely.My.Resources.Resources.Blue__1_
        Me.BtnReport.Location = New System.Drawing.Point(166, 17)
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
        'FrmViewWorkPerDayWithDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 556)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Name = "FrmViewWorkPerDayWithDetail"
        Me.Text = "مشاهده کارکرد روزانه"
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.ChkViewLapse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkViewLeave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkViewMission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLapse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDeLapse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.BtnReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtName1 As UserControls.RadTextBox
    Friend WithEvents BtnBrows As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrID As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker2 As UserControls.UcDatePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker1 As UserControls.UcDatePicker
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnLapse As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDeLapse As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents ChkViewLapse As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents BtnDeleteAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents UcRadGridViewTools2 As UserControls.UcRadGridViewTools
    Friend WithEvents ChkViewLeave As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkViewMission As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents BtnReport As Telerik.WinControls.UI.RadButton
End Class
