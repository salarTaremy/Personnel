<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.BtnBrows = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtFamil = New UserControls.RadTextBox()
        Me.TxtName = New UserControls.RadTextBox()
        Me.TxtThID = New Telerik.WinControls.UI.RadSpinEditor()
        Me.ChkAdmin = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TxtUser = New UserControls.RadTextBoxLimited()
        Me.TxtPass = New UserControls.RadTextBoxLimited()
        Me.TxtPass2 = New UserControls.RadTextBoxLimited()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Grd = New UserControls.RadGridView()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFamil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtThID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPass2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(5, 17)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.Controls.Add(Me.BtnEdit)
        Me.RadGroupBox3.Controls.Add(Me.BtnSave)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox3.HeaderText = "ابزارها"
        Me.RadGroupBox3.Location = New System.Drawing.Point(12, 373)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(979, 53)
        Me.RadGroupBox3.TabIndex = 8
        Me.RadGroupBox3.Text = "ابزارها"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = Global.Main.My.Resources.Resources.Blue__14_
        Me.BtnEdit.Location = New System.Drawing.Point(864, 17)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(110, 31)
        Me.BtnEdit.TabIndex = 2
        Me.BtnEdit.Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Main.My.Resources.Resources.Blue__14_
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.BtnSearch)
        Me.RadGroupBox2.Controls.Add(Me.RadButton1)
        Me.RadGroupBox2.Controls.Add(Me.BtnBrows)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox2.Controls.Add(Me.TxtFamil)
        Me.RadGroupBox2.Controls.Add(Me.TxtName)
        Me.RadGroupBox2.Controls.Add(Me.TxtThID)
        Me.RadGroupBox2.Controls.Add(Me.ChkAdmin)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox2.Controls.Add(Me.TxtUser)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox2.Controls.Add(Me.TxtPass2)
        Me.RadGroupBox2.Controls.Add(Me.TxtPass)
        Me.RadGroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox2.HeaderText = "جستجو بر اساس"
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox2.Size = New System.Drawing.Size(979, 81)
        Me.RadGroupBox2.TabIndex = 7
        Me.RadGroupBox2.Text = "جستجو بر اساس"
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        CType(Me.RadGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(5, 41)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(110, 31)
        Me.BtnSearch.TabIndex = 10
        Me.BtnSearch.Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnSearch.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "جستجو"
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(30, 30)
        CType(Me.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(30, 30)
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.Location = New System.Drawing.Point(121, 40)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 31)
        Me.RadButton1.TabIndex = 9
        Me.RadButton1.Text = "اضافه"
        '
        'BtnBrows
        '
        Me.BtnBrows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBrows.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnBrows.Image = Global.Main.My.Resources.Resources.Find_User16
        Me.BtnBrows.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnBrows.Location = New System.Drawing.Point(869, 46)
        Me.BtnBrows.Name = "BtnBrows"
        Me.BtnBrows.Size = New System.Drawing.Size(19, 19)
        Me.BtnBrows.TabIndex = 18
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.Main.My.Resources.Resources.Find_User16
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnBrows.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = ""
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(16, 16)
        CType(Me.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(16, 16)
        '
        'RadLabel5
        '
        Me.RadLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel5.Location = New System.Drawing.Point(405, 46)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(71, 17)
        Me.RadLabel5.TabIndex = 17
        Me.RadLabel5.Text = "نام خانوادگی:"
        Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel6.Location = New System.Drawing.Point(404, 22)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(23, 17)
        Me.RadLabel6.TabIndex = 16
        Me.RadLabel6.Text = "نام:"
        Me.RadLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtFamil
        '
        Me.TxtFamil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFamil.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtFamil.Location = New System.Drawing.Point(242, 45)
        Me.TxtFamil.Name = "TxtFamil"
        Me.TxtFamil.NextObject = Nothing
        Me.TxtFamil.NullText = "کد طرف حساب نامعتبر"
        Me.TxtFamil.ReadOnly = True
        Me.TxtFamil.Size = New System.Drawing.Size(160, 19)
        Me.TxtFamil.TabIndex = 8
        Me.TxtFamil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtFamil.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "کد طرف حساب نامعتبر"
        CType(Me.TxtFamil.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtFamil.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Tahoma", 8.25!)
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.Location = New System.Drawing.Point(242, 21)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.NextObject = Nothing
        Me.TxtName.NullText = "کد طرف حساب نامعتبر"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(160, 19)
        Me.TxtName.TabIndex = 7
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtName.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(215, Byte), Integer))
        CType(Me.TxtName.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.TxtName.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'TxtThID
        '
        Me.TxtThID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtThID.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtThID.Location = New System.Drawing.Point(781, 46)
        Me.TxtThID.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.TxtThID.Name = "TxtThID"
        Me.TxtThID.Size = New System.Drawing.Size(82, 19)
        Me.TxtThID.TabIndex = 2
        Me.TxtThID.TabStop = False
        Me.TxtThID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkAdmin
        '
        Me.ChkAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkAdmin.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkAdmin.Location = New System.Drawing.Point(696, 45)
        Me.ChkAdmin.Name = "ChkAdmin"
        Me.ChkAdmin.Size = New System.Drawing.Size(79, 17)
        Me.ChkAdmin.TabIndex = 3
        Me.ChkAdmin.Text = "مدیرسیستم"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(891, 46)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(83, 17)
        Me.RadLabel1.TabIndex = 12
        Me.RadLabel1.Text = "کد طرف حساب:"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(894, 22)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 17)
        Me.RadLabel2.TabIndex = 10
        Me.RadLabel2.Text = "نام کاربری :"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TxtUser
        '
        Me.TxtUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUser.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtUser.Location = New System.Drawing.Point(702, 21)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.NextObject = Me.TxtPass
        Me.TxtUser.NullText = "بصورت لاتین"
        Me.TxtUser.Size = New System.Drawing.Size(186, 19)
        Me.TxtUser.TabIndex = 0
        Me.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUser.ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz_@#$%^&*()_+"
        '
        'TxtPass
        '
        Me.TxtPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPass.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPass.Location = New System.Drawing.Point(482, 21)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.NextObject = Me.TxtPass2
        Me.TxtPass.NullText = "بصورت لاتین یا عددی"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(160, 19)
        Me.TxtPass.TabIndex = 5
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPass.ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz_@#$%^&*()_+"
        '
        'TxtPass2
        '
        Me.TxtPass2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPass2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPass2.Location = New System.Drawing.Point(482, 45)
        Me.TxtPass2.Name = "TxtPass2"
        Me.TxtPass2.NextObject = Nothing
        Me.TxtPass2.NullText = "بصورت لاتین یا عددی"
        Me.TxtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass2.Size = New System.Drawing.Size(160, 19)
        Me.TxtPass2.TabIndex = 6
        Me.TxtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPass2.ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz_@#$%^&*()_+"
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(645, 46)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(34, 17)
        Me.RadLabel3.TabIndex = 8
        Me.RadLabel3.Text = "تکرار :"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(644, 22)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(52, 17)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "رمز عبور :"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.Grd)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadGroupBox1.HeaderText = "لیست طرف حسابها"
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadGroupBox1.Size = New System.Drawing.Size(979, 268)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Text = "لیست طرف حسابها"
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
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableFiltering = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(969, 242)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "1"
        Me.Grd.ValidChar = Nothing
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1003, 438)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.DefaultTextBox = Me.TxtUser
        Me.Name = "FrmUsers"
        Me.Text = "کاربران سیستم"
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBrows, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFamil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtThID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPass2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ChkAdmin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents TxtThID As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnBrows As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPass2 As UserControls.RadTextBoxLimited
    Friend WithEvents TxtPass As UserControls.RadTextBoxLimited
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents TxtUser As UserControls.RadTextBoxLimited
    Friend WithEvents TxtFamil As UserControls.RadTextBox
    Friend WithEvents TxtName As UserControls.RadTextBox
End Class
