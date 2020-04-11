<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewTarafHEsab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmViewTarafHEsab))
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.UcRadGridViewTools1 = New UserControls.UcRadGridViewTools()
        Me.Grd = New UserControls.RadGridView()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtCode_melli = New UserControls.RadTextBox()
        Me.TxtName = New UserControls.RadTextBox()
        Me.TxtTaID = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtAzID = New Telerik.WinControls.UI.RadSpinEditor()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnSelect = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCode_melli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTaID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAzID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RadGroupBox1.HeaderText = "لیست طرف حسابها"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(625, 267)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "لیست طرف حسابها"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'UcRadGridViewTools1
        '
        Me.UcRadGridViewTools1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UcRadGridViewTools1.BackColor = System.Drawing.Color.Transparent
        Me.UcRadGridViewTools1.GridView = Me.Grd
        Me.UcRadGridViewTools1.Location = New System.Drawing.Point(5, 220)
        Me.UcRadGridViewTools1.MaximumSize = New System.Drawing.Size(3000, 42)
        Me.UcRadGridViewTools1.MinimumSize = New System.Drawing.Size(0, 42)
        Me.UcRadGridViewTools1.Name = "UcRadGridViewTools1"
        Me.UcRadGridViewTools1.Size = New System.Drawing.Size(615, 42)
        Me.UcRadGridViewTools1.TabIndex = 9
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
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(615, 193)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "Grd"
        Me.Grd.ValidChar = Nothing
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.TxtCode_melli)
        Me.RadGroupBox2.Controls.Add(Me.TxtName)
        Me.RadGroupBox2.Controls.Add(Me.TxtTaID)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.TxtAzID)
        Me.RadGroupBox2.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox2.HeaderText = "جستجو بر اساس"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox2.Size = New System.Drawing.Size(625, 81)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.Text = "جستجو بر اساس"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(325, 49)
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
        Me.RadLabel4.Location = New System.Drawing.Point(324, 24)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(98, 17)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "نام یا نام خانوادگی:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCode_melli
        '
        Me.TxtCode_melli.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCode_melli.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtCode_melli.Location = New System.Drawing.Point(136, 48)
        Me.TxtCode_melli.Name = "TxtCode_melli"
        Me.TxtCode_melli.NextObject = Nothing
        Me.TxtCode_melli.Size = New System.Drawing.Size(186, 19)
        Me.TxtCode_melli.TabIndex = 3
        Me.TxtCode_melli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.Location = New System.Drawing.Point(136, 23)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.NextObject = Me.TxtCode_melli
        Me.TxtName.Size = New System.Drawing.Size(186, 19)
        Me.TxtName.TabIndex = 2
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTaID
        '
        Me.TxtTaID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTaID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTaID.Location = New System.Drawing.Point(434, 48)
        Me.TxtTaID.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtTaID.Name = "TxtTaID"
        Me.TxtTaID.Size = New System.Drawing.Size(83, 19)
        Me.TxtTaID.TabIndex = 1
        Me.TxtTaID.TabStop = False
        Me.TxtTaID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(520, 48)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(93, 17)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "تا کد طرف حساب:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(520, 23)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(90, 17)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "ازکد طرف حساب:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtAzID
        '
        Me.TxtAzID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAzID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtAzID.Location = New System.Drawing.Point(434, 23)
        Me.TxtAzID.Name = "TxtAzID"
        Me.TxtAzID.Size = New System.Drawing.Size(83, 19)
        Me.TxtAzID.TabIndex = 0
        Me.TxtAzID.TabStop = False
        Me.TxtAzID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(15, 23)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 31)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(30, 30)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(30, 30)
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(510, 17)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 31)
        Me.BtnEdit.TabIndex = 6
        Me.BtnEdit.Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.BtnSelect)
        Me.RadGroupBox3.Controls.Add(Me.BtnAdd)
        Me.RadGroupBox3.Controls.Add(Me.BtnDelete)
        Me.RadGroupBox3.Controls.Add(Me.BtnEdit)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox3.HeaderText = "ابزارها"
        Me.RadGroupBox3.Location = New System.Drawing.Point(12, 372)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(625, 53)
        Me.RadGroupBox3.TabIndex = 3
        Me.RadGroupBox3.Text = "ابزارها"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'BtnSelect
        '
        Me.BtnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(5, 17)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(110, 31)
        Me.BtnSelect.TabIndex = 5
        Me.BtnSelect.Text = "تایید"
        Me.BtnSelect.Visible = False
        CType(Me.BtnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
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
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(278, 17)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 31)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
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
        Me.BtnDelete.Location = New System.Drawing.Point(394, 17)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 7
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'FrmViewTarafHEsab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 437)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.DefaultTextBox = Me.TxtName
        Me.Name = "FrmViewTarafHEsab"
        Me.Text = "مشاهده و تغیر طرف حساب ها"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCode_melli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTaID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAzID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtAzID As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents TxtTaID As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSelect As Telerik.WinControls.UI.RadButton
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents TxtCode_melli As UserControls.RadTextBox
    Public WithEvents TxtName As UserControls.RadTextBox
    Friend WithEvents UcRadGridViewTools1 As UserControls.UcRadGridViewTools
End Class
