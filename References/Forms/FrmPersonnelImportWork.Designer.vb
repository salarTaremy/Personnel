<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonnelImportWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPersonnelImportWork))
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
        Me.BtnOpenFile = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.Grd = New UserControls.RadGridView()
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
        CType(Me.BtnOpenFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadGroupBox2.Controls.Add(Me.BtnOpenFile)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.HeaderText = "فیلتر ها"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 15)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(855, 73)
        Me.RadGroupBox2.TabIndex = 43
        Me.RadGroupBox2.Text = "فیلتر ها"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'TxtName2
        '
        Me.TxtName2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName2.Location = New System.Drawing.Point(121, 46)
        Me.TxtName2.Name = "TxtName2"
        Me.TxtName2.NextObject = Nothing
        Me.TxtName2.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtName2.ReadOnly = True
        Me.TxtName2.Size = New System.Drawing.Size(335, 19)
        Me.TxtName2.TabIndex = 10
        Me.TxtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName2.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'BtnBrows2
        '
        Me.BtnBrows2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows2.Image = Global.References.My.Resources.Resources.Find_User16
        Me.BtnBrows2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows2.Location = New System.Drawing.Point(568, 46)
        Me.BtnBrows2.Name = "BtnBrows2"
        Me.BtnBrows2.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows2.TabIndex = 4
        CType(Me.BtnBrows2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.References.My.Resources.Resources.Find_User16
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
        Me.TxtPrID2.Location = New System.Drawing.Point(462, 46)
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
        Me.RadLabel6.Location = New System.Drawing.Point(590, 47)
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
        Me.TxtName1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName1.Location = New System.Drawing.Point(121, 21)
        Me.TxtName1.Name = "TxtName1"
        Me.TxtName1.NextObject = Nothing
        Me.TxtName1.NullText = "کد پرسنلی  کارمند را وارد کنید"
        Me.TxtName1.ReadOnly = True
        Me.TxtName1.Size = New System.Drawing.Size(335, 19)
        Me.TxtName1.TabIndex = 9
        Me.TxtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName1.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'BtnBrows1
        '
        Me.BtnBrows1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows1.Image = Global.References.My.Resources.Resources.Find_User16
        Me.BtnBrows1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows1.Location = New System.Drawing.Point(568, 21)
        Me.BtnBrows1.Name = "BtnBrows1"
        Me.BtnBrows1.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows1.TabIndex = 2
        CType(Me.BtnBrows1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.References.My.Resources.Resources.Find_User16
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
        Me.TxtPrID1.Location = New System.Drawing.Point(462, 21)
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
        Me.RadLabel4.Location = New System.Drawing.Point(590, 22)
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
        Me.RadLabel2.Location = New System.Drawing.Point(800, 46)
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
        Me.UcDatePicker2.Location = New System.Drawing.Point(663, 46)
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
        Me.RadLabel1.Location = New System.Drawing.Point(800, 21)
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
        Me.UcDatePicker1.Location = New System.Drawing.Point(663, 21)
        Me.UcDatePicker1.Name = "UcDatePicker1"
        Me.UcDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UcDatePicker1.Size = New System.Drawing.Size(131, 19)
        Me.UcDatePicker1.TabIndex = 0
        Me.UcDatePicker1.txt = "1396/03/11"
        Me.UcDatePicker1.TxtInt = 13960311
        '
        'BtnOpenFile
        '
        Me.BtnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenFile.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnOpenFile.Image = CType(resources.GetObject("BtnOpenFile.Image"), System.Drawing.Image)
        Me.BtnOpenFile.Location = New System.Drawing.Point(5, 24)
        Me.BtnOpenFile.Name = "BtnOpenFile"
        Me.BtnOpenFile.Size = New System.Drawing.Size(110, 31)
        Me.BtnOpenFile.TabIndex = 6
        Me.BtnOpenFile.Text = "انتخاب فایل"
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
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 94)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(854, 351)
        Me.RadGroupBox1.TabIndex = 38
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
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(11, 304)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(844, 42)
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
        Me.Grd.Size = New System.Drawing.Size(844, 277)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "RadGridView1"
        Me.Grd.ValidChar = Nothing
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(757, 451)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
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
        Me.BtnSave.Location = New System.Drawing.Point(12, 451)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'FrmPersonnelImportWork
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 494)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "FrmPersonnelImportWork"
        Me.Text = "ثبت کارکرد کارمند"
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
        CType(Me.BtnOpenFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnOpenFile As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker2 As UserControls.UcDatePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents UcDatePicker1 As UserControls.UcDatePicker
    Friend WithEvents TxtName1 As UserControls.RadTextBox
    Friend WithEvents BtnBrows1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrID1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TxtName2 As UserControls.RadTextBox
    Friend WithEvents BtnBrows2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPrID2 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
End Class
