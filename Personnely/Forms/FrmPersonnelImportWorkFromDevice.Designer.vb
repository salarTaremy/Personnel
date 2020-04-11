<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonnelImportWorkFromDevice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPersonnelImportWorkFromDevice))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.TxtName2 = New UserControls.RadTextBox()
        Me.BtnBrows2 = New Telerik.WinControls.UI.RadButton()
        Me.TxtPrID2 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtName1 = New UserControls.RadTextBox()
        Me.BtnBrows1 = New Telerik.WinControls.UI.RadButton()
        Me.TxtPrID1 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.UcDatePicker2 = New UserControls.UcDatePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.UcDatePicker1 = New UserControls.UcDatePicker()
        Me.BtnReadFromDevice = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.Grd = New UserControls.RadGridView()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.BtnConnect = New Telerik.WinControls.UI.RadButton()
        Me.TxtServer = New UserControls.RadTextBox()
        Me.CmbDbName = New UserControls.RadDropDownList()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.TxtName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBrows2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBrows1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReadFromDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CmbDbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.TxtName2)
        Me.RadGroupBox2.Controls.Add(Me.BtnBrows2)
        Me.RadGroupBox2.Controls.Add(Me.TxtPrID2)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.Controls.Add(Me.TxtName1)
        Me.RadGroupBox2.Controls.Add(Me.BtnBrows1)
        Me.RadGroupBox2.Controls.Add(Me.TxtPrID1)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.UcDatePicker2)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.UcDatePicker1)
        Me.RadGroupBox2.Controls.Add(Me.BtnReadFromDevice)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.HeaderText = "فیلتر ها"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 67)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(887, 73)
        Me.RadGroupBox2.TabIndex = 47
        Me.RadGroupBox2.Text = "فیلتر ها"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'TxtName2
        '
        Me.TxtName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName2.FocusColor = System.Drawing.Color.Azure
        Me.TxtName2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName2.IsRequierd = False
        Me.TxtName2.Location = New System.Drawing.Point(121, 46)
        Me.TxtName2.Name = "TxtName2"
        Me.TxtName2.Name_Farsi = Nothing
        Me.TxtName2.NextObject = Nothing
        Me.TxtName2.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtName2.ReadOnly = True
        Me.TxtName2.Size = New System.Drawing.Size(367, 19)
        Me.TxtName2.TabIndex = 40
        Me.TxtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName2.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'BtnBrows2
        '
        Me.BtnBrows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows2.Image = CType(resources.GetObject("BtnBrows2.Image"), System.Drawing.Image)
        Me.BtnBrows2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows2.Location = New System.Drawing.Point(600, 46)
        Me.BtnBrows2.Name = "BtnBrows2"
        Me.BtnBrows2.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows2.TabIndex = 4
        CType(Me.BtnBrows2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnBrows2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnBrows2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = ""
        CType(Me.BtnBrows2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnBrows2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnBrows2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(16, 16)
        CType(Me.BtnBrows2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(16, 16)
        '
        'TxtPrID2
        '
        Me.TxtPrID2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrID2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrID2.Location = New System.Drawing.Point(494, 46)
        Me.TxtPrID2.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtPrID2.Name = "TxtPrID2"
        Me.TxtPrID2.Size = New System.Drawing.Size(100, 19)
        Me.TxtPrID2.TabIndex = 5
        Me.TxtPrID2.TabStop = False
        Me.TxtPrID2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel6.Location = New System.Drawing.Point(622, 47)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(64, 17)
        Me.RadLabel6.TabIndex = 37
        Me.RadLabel6.Text = "تا کد کارمند:"
        Me.RadLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtName1
        '
        Me.TxtName1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName1.FocusColor = System.Drawing.Color.Azure
        Me.TxtName1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName1.IsRequierd = False
        Me.TxtName1.Location = New System.Drawing.Point(121, 21)
        Me.TxtName1.Name = "TxtName1"
        Me.TxtName1.Name_Farsi = Nothing
        Me.TxtName1.NextObject = Nothing
        Me.TxtName1.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtName1.ReadOnly = True
        Me.TxtName1.Size = New System.Drawing.Size(367, 19)
        Me.TxtName1.TabIndex = 35
        Me.TxtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'BtnBrows1
        '
        Me.BtnBrows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows1.Image = CType(resources.GetObject("BtnBrows1.Image"), System.Drawing.Image)
        Me.BtnBrows1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows1.Location = New System.Drawing.Point(600, 21)
        Me.BtnBrows1.Name = "BtnBrows1"
        Me.BtnBrows1.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows1.TabIndex = 2
        CType(Me.BtnBrows1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnBrows1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnBrows1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = ""
        CType(Me.BtnBrows1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnBrows1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnBrows1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(16, 16)
        CType(Me.BtnBrows1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(16, 16)
        '
        'TxtPrID1
        '
        Me.TxtPrID1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrID1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPrID1.Location = New System.Drawing.Point(494, 21)
        Me.TxtPrID1.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtPrID1.Name = "TxtPrID1"
        Me.TxtPrID1.Size = New System.Drawing.Size(100, 19)
        Me.TxtPrID1.TabIndex = 3
        Me.TxtPrID1.TabStop = False
        Me.TxtPrID1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(622, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(65, 17)
        Me.RadLabel4.TabIndex = 32
        Me.RadLabel4.Text = "از کد کارمند:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(832, 46)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel2.TabIndex = 31
        Me.RadLabel2.Text = "تا تاریخ:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'UcDatePicker2
        '
        Me.UcDatePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDatePicker2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcDatePicker2.Location = New System.Drawing.Point(695, 46)
        Me.UcDatePicker2.Name = "UcDatePicker2"
        Me.UcDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcDatePicker2.Size = New System.Drawing.Size(131, 19)
        Me.UcDatePicker2.TabIndex = 1
        Me.UcDatePicker2.txt = "1396/03/11"
        Me.UcDatePicker2.TxtInt = 13960311
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(832, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel1.TabIndex = 29
        Me.RadLabel1.Text = "از تاریخ:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'UcDatePicker1
        '
        Me.UcDatePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcDatePicker1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.UcDatePicker1.Location = New System.Drawing.Point(695, 21)
        Me.UcDatePicker1.Name = "UcDatePicker1"
        Me.UcDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcDatePicker1.Size = New System.Drawing.Size(131, 19)
        Me.UcDatePicker1.TabIndex = 0
        Me.UcDatePicker1.txt = "1396/03/11"
        Me.UcDatePicker1.TxtInt = 13960311
        '
        'BtnReadFromDevice
        '
        Me.BtnReadFromDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReadFromDevice.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnReadFromDevice.Image = CType(resources.GetObject("BtnReadFromDevice.Image"), System.Drawing.Image)
        Me.BtnReadFromDevice.Location = New System.Drawing.Point(5, 22)
        Me.BtnReadFromDevice.Name = "BtnReadFromDevice"
        Me.BtnReadFromDevice.Size = New System.Drawing.Size(110, 31)
        Me.BtnReadFromDevice.TabIndex = 6
        Me.BtnReadFromDevice.Text = "نمایش اطلاعات "
        Me.BtnReadFromDevice.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReadFromDevice.TextWrap = True
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.UcRadGridViewTools1)
        Me.RadGroupBox1.Controls.Add(Me.Grd)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "نمایش پیش فرض فایل انتخابی"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 146)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(887, 304)
        Me.RadGroupBox1.TabIndex = 44
        Me.RadGroupBox1.Text = "نمایش پیش فرض فایل انتخابی"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'UcRadGridViewTools1
        '
        Me.UcRadGridViewTools1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools1.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools1.GridView = Me.Grd
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(5, 257)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(877, 42)
        Me.UcRadGridViewTools1.TabIndex = 1
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
        Me.Grd.Size = New System.Drawing.Size(877, 230)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "RadGridView1"
        Me.Grd.ValidChar = Nothing
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox3.Controls.Add(Me.BtnConnect)
        Me.RadGroupBox3.Controls.Add(Me.TxtServer)
        Me.RadGroupBox3.Controls.Add(Me.CmbDbName)
        Me.RadGroupBox3.Enabled = False
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox3.HeaderText = "تنظیمات اتصال به سرور  PwKara"
        Me.RadGroupBox3.Location = New System.Drawing.Point(12, 3)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(887, 58)
        Me.RadGroupBox3.TabIndex = 48
        Me.RadGroupBox3.Text = "تنظیمات اتصال به سرور  PwKara"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel5.Location = New System.Drawing.Point(793, 22)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(81, 17)
        Me.RadLabel5.TabIndex = 51
        Me.RadLabel5.Text = "پایگاه های داده:"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(494, 23)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(35, 17)
        Me.RadLabel3.TabIndex = 50
        Me.RadLabel3.Text = "سرور:"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'BtnConnect
        '
        Me.BtnConnect.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnConnect.Image = CType(resources.GetObject("BtnConnect.Image"), System.Drawing.Image)
        Me.BtnConnect.Location = New System.Drawing.Point(5, 15)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(110, 31)
        Me.BtnConnect.TabIndex = 49
        Me.BtnConnect.Text = "برقراری ارتباط  "
        Me.BtnConnect.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnConnect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        CType(Me.BtnConnect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnConnect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "برقراری ارتباط  "
        CType(Me.BtnConnect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnConnect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnConnect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnConnect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'TxtServer
        '
        Me.TxtServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtServer.FocusColor = System.Drawing.Color.Azure
        Me.TxtServer.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtServer.IsRequierd = False
        Me.TxtServer.Location = New System.Drawing.Point(121, 21)
        Me.TxtServer.Name = "TxtServer"
        Me.TxtServer.Name_Farsi = Nothing
        Me.TxtServer.NextObject = Nothing
        Me.TxtServer.NullText = "به هیچ سروری متصل نمیباشید"
        Me.TxtServer.ReadOnly = True
        Me.TxtServer.Size = New System.Drawing.Size(367, 19)
        Me.TxtServer.TabIndex = 35
        Me.TxtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtServer.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtServer.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtServer.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'CmbDbName
        '
        Me.CmbDbName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbDbName.DefaultItemsCountInDropDown = 15
        Me.CmbDbName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbDbName.Enabled = False
        Me.CmbDbName.Location = New System.Drawing.Point(535, 22)
        Me.CmbDbName.Name = "CmbDbName"
        Me.CmbDbName.Size = New System.Drawing.Size(252, 19)
        Me.CmbDbName.TabIndex = 41
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(790, 456)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(12, 456)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'FrmPersonnelImportWorkFromDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 499)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmPersonnelImportWorkFromDevice"
        Me.Text = "انتقال اطلاعات از دستگاه به پایگاه داده"
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.TxtName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBrows2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBrows1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReadFromDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CmbDbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TxtName2 As UserControls.RadTextBox
    Friend WithEvents BtnBrows2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrID2 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtName1 As UserControls.RadTextBox
    Friend WithEvents BtnBrows1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrID1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker2 As UserControls.UcDatePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker1 As UserControls.UcDatePicker
    Friend WithEvents BtnReadFromDevice As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents TxtServer As UserControls.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnConnect As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CmbDbName As UserControls.RadDropDownList
End Class
