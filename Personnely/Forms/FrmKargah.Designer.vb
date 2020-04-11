<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKargah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKargah))
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Grd = New UserControls.RadGridView()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.CmbCompany = New UserControls.RadDropDownList()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtRadifPeyman = New UserControls.RadTextBoxLimited()
        Me.TxtName = New UserControls.RadTextBox()
        Me.TxtDetail = New UserControls.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtCode = New UserControls.RadTextBoxLimited()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRadifPeyman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.Grd)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "لیست کارگاه ها"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 109)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(890, 344)
        Me.RadGroupBox1.TabIndex = 3
        Me.RadGroupBox1.Text = "لیست کارگاه ها"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
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
        Me.Grd.MasterTemplate.AllowDeleteRow = False
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableFiltering = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.Size = New System.Drawing.Size(880, 318)
        Me.Grd.TabIndex = 0
        Me.Grd.ValidChar = Nothing
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(12, 459)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(792, 459)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 31)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnDelete.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.CmbCompany)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel10)
        Me.RadGroupBox2.Controls.Add(Me.TxtRadifPeyman)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.TxtCode)
        Me.RadGroupBox2.Controls.Add(Me.BtnAdd)
        Me.RadGroupBox2.Controls.Add(Me.RadDropDownList2)
        Me.RadGroupBox2.Controls.Add(Me.RadDropDownList1)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.TxtName)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.TxtDetail)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadGroupBox2.HeaderText = "مشخصات کارگاه"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 4)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(890, 99)
        Me.RadGroupBox2.TabIndex = 21
        Me.RadGroupBox2.Text = "مشخصات کارگاه"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'CmbCompany
        '
        Me.CmbCompany.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCompany.DefaultItemsCountInDropDown = 15
        Me.CmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbCompany.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbCompany.Location = New System.Drawing.Point(368, 46)
        Me.CmbCompany.Name = "CmbCompany"
        Me.CmbCompany.Size = New System.Drawing.Size(193, 19)
        Me.CmbCompany.TabIndex = 4
        '
        'RadLabel10
        '
        Me.RadLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel10.Location = New System.Drawing.Point(567, 47)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(42, 17)
        Me.RadLabel10.TabIndex = 47
        Me.RadLabel10.Text = "کارفرما:"
        Me.RadLabel10.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtRadifPeyman
        '
        Me.TxtRadifPeyman.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRadifPeyman.BackColor = System.Drawing.Color.White
        Me.TxtRadifPeyman.FocusColor = System.Drawing.Color.Azure
        Me.TxtRadifPeyman.IsRequierd = False
        Me.TxtRadifPeyman.Location = New System.Drawing.Point(626, 46)
        Me.TxtRadifPeyman.Name = "TxtRadifPeyman"
        Me.TxtRadifPeyman.Name_Farsi = Nothing
        Me.TxtRadifPeyman.NextObject = Me.TxtName
        Me.TxtRadifPeyman.NullText = "فقط عدد"
        Me.TxtRadifPeyman.Size = New System.Drawing.Size(193, 19)
        Me.TxtRadifPeyman.TabIndex = 2
        Me.TxtRadifPeyman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRadifPeyman.ValidCharacters = "0123456789"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.FocusColor = System.Drawing.Color.Azure
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.IsRequierd = False
        Me.TxtName.Location = New System.Drawing.Point(368, 21)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Name_Farsi = Nothing
        Me.TxtName.NextObject = Me.TxtDetail
        Me.TxtName.Size = New System.Drawing.Size(193, 19)
        Me.TxtName.TabIndex = 3
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDetail
        '
        Me.TxtDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDetail.FocusColor = System.Drawing.Color.Azure
        Me.TxtDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDetail.IsRequierd = False
        Me.TxtDetail.Location = New System.Drawing.Point(135, 71)
        Me.TxtDetail.Name = "TxtDetail"
        Me.TxtDetail.Name_Farsi = Nothing
        Me.TxtDetail.NextObject = Nothing
        Me.TxtDetail.Size = New System.Drawing.Size(684, 19)
        Me.TxtDetail.TabIndex = 5
        Me.TxtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(825, 47)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(61, 17)
        Me.RadLabel1.TabIndex = 29
        Me.RadLabel1.Text = "ردیف پیمان:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtCode
        '
        Me.TxtCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCode.BackColor = System.Drawing.Color.White
        Me.TxtCode.FocusColor = System.Drawing.Color.Azure
        Me.TxtCode.IsRequierd = False
        Me.TxtCode.Location = New System.Drawing.Point(626, 21)
        Me.TxtCode.MaxLength = 10
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Name_Farsi = Nothing
        Me.TxtCode.NextObject = Me.TxtName
        Me.TxtCode.NullText = "فقط عدد"
        Me.TxtCode.Size = New System.Drawing.Size(193, 19)
        Me.TxtCode.TabIndex = 0
        Me.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCode.ValidCharacters = "0123456789"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.Location = New System.Drawing.Point(5, 63)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(110, 31)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "اضافه"
        '
        'RadDropDownList2
        '
        Me.RadDropDownList2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList2.Location = New System.Drawing.Point(135, 45)
        Me.RadDropDownList2.Name = "RadDropDownList2"
        Me.RadDropDownList2.Size = New System.Drawing.Size(155, 20)
        Me.RadDropDownList2.TabIndex = 7
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList1.Location = New System.Drawing.Point(134, 20)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(155, 20)
        Me.RadDropDownList1.TabIndex = 6
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel5.Location = New System.Drawing.Point(296, 47)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(55, 17)
        Me.RadLabel5.TabIndex = 24
        Me.RadLabel5.Text = "کد تفضیل:"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel6.Location = New System.Drawing.Point(295, 22)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(64, 17)
        Me.RadLabel6.TabIndex = 23
        Me.RadLabel6.Text = "گروه تفضیل:"
        Me.RadLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(563, 22)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(54, 17)
        Me.RadLabel2.TabIndex = 22
        Me.RadLabel2.Text = "نام کارگاه:"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(825, 72)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(36, 17)
        Me.RadLabel3.TabIndex = 20
        Me.RadLabel3.Text = "آدرس:"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(825, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(52, 17)
        Me.RadLabel4.TabIndex = 19
        Me.RadLabel4.Text = "کد کارگاه:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'FrmKargah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 502)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.DefaultTextBox = Me.TxtCode
        Me.Name = "FrmKargah"
        Me.Text = "کارگاه های بیمه"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.CmbCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRadifPeyman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadDropDownList2 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents TxtName As UserControls.RadTextBox
    Friend WithEvents TxtDetail As UserControls.RadTextBox
    Friend WithEvents TxtCode As UserControls.RadTextBoxLimited
    Friend WithEvents TxtRadifPeyman As UserControls.RadTextBoxLimited
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents CmbCompany As UserControls.RadDropDownList
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
End Class
