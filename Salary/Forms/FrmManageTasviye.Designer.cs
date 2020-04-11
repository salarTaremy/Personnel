namespace Salary.Forms
{
    partial class FrmManageTasviye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageTasviye));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnDetail = new Telerik.WinControls.UI.RadButton();
            this.BtnAdd = new Telerik.WinControls.UI.RadButton();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            this.BtnDel = new Telerik.WinControls.UI.RadButton();
            this.BtnEdit = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnSearch = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodePr = new UserControls.RadTextBoxLimited();
            this.TxtNamePr = new UserControls.RadTextBox();
            this.BtnBrows = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnDetail);
            this.radGroupBox3.Controls.Add(this.BtnAdd);
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Controls.Add(this.BtnDel);
            this.radGroupBox3.Controls.Add(this.BtnEdit);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 514);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(754, 52);
            this.radGroupBox3.TabIndex = 23;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnDetail
            // 
            this.BtnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDetail.Image = global::Salary.Properties.Resources.Detail;
            this.BtnDetail.Location = new System.Drawing.Point(172, 16);
            this.BtnDetail.Name = "BtnDetail";
            this.BtnDetail.Size = new System.Drawing.Size(110, 31);
            this.BtnDetail.TabIndex = 10;
            this.BtnDetail.Text = "      مشاهده جزئیات";
            this.BtnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDetail.GetChildAt(0))).Image = global::Salary.Properties.Resources.Detail;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDetail.GetChildAt(0))).Text = "      مشاهده جزئیات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDetail.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(404, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 31);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAdd.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAdd.GetChildAt(0))).Text = "اضافه";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnReport.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnReport.Location = new System.Drawing.Point(288, 16);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(110, 31);
            this.BtnReport.TabIndex = 9;
            this.BtnReport.Text = "گزارشات";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Text = "گزارشات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDel.Image = global::Salary.Properties.Resources.BtnDelete_Image;
            this.BtnDel.Location = new System.Drawing.Point(520, 16);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(110, 31);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDel.GetChildAt(0))).Image = global::Salary.Properties.Resources.BtnDelete_Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDel.GetChildAt(0))).Text = "حذف";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(636, 16);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(110, 31);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnEdit.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnEdit.GetChildAt(0))).Text = "ویرایش";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.BtnSearch);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.TxtCodePr);
            this.radGroupBox1.Controls.Add(this.TxtNamePr);
            this.radGroupBox1.Controls.Add(this.BtnBrows);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیلتر ها";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(754, 76);
            this.radGroupBox1.TabIndex = 21;
            this.radGroupBox1.Text = "فیلتر ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSearch.Image = global::Salary.Properties.Resources.Blue__35_;
            this.BtnSearch.Location = new System.Drawing.Point(5, 40);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(110, 31);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSearch.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__35_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSearch.GetChildAt(0))).Text = "جستجو";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel5.Location = new System.Drawing.Point(685, 46);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(56, 17);
            this.radLabel5.TabIndex = 15;
            this.radLabel5.Text = "نام کارمند:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtCodePr
            // 
            this.TxtCodePr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodePr.FocusColor = System.Drawing.Color.Azure;
            this.TxtCodePr.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtCodePr.IsRequierd = false;
            this.TxtCodePr.Location = new System.Drawing.Point(557, 20);
            this.TxtCodePr.MaxLength = 6;
            this.TxtCodePr.Name = "TxtCodePr";
            this.TxtCodePr.Name_Farsi = null;
            this.TxtCodePr.NextObject = null;
            this.TxtCodePr.NullText = "فقط عدد";
            this.TxtCodePr.Size = new System.Drawing.Size(123, 19);
            this.TxtCodePr.TabIndex = 1;
            this.TxtCodePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodePr.ValidCharacters = "0123456789";
            this.TxtCodePr.TextChanged += new System.EventHandler(this.TxtCodePr_TextChanged);
            // 
            // TxtNamePr
            // 
            this.TxtNamePr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNamePr.FocusColor = System.Drawing.Color.Azure;
            this.TxtNamePr.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtNamePr.IsRequierd = false;
            this.TxtNamePr.Location = new System.Drawing.Point(468, 45);
            this.TxtNamePr.Name = "TxtNamePr";
            this.TxtNamePr.Name_Farsi = null;
            this.TxtNamePr.NextObject = null;
            this.TxtNamePr.NullText = "کد پرسنلی  کارمند را وارد کنید";
            this.TxtNamePr.ReadOnly = true;
            this.TxtNamePr.Size = new System.Drawing.Size(211, 19);
            this.TxtNamePr.TabIndex = 7;
            this.TxtNamePr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtNamePr.GetChildAt(0).GetChildAt(0))).NullText = "کد پرسنلی  کارمند را وارد کنید";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtNamePr.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtNamePr.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 8.25F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtNamePr.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TxtNamePr.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.White;
            // 
            // BtnBrows
            // 
            this.BtnBrows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrows.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnBrows.Image = global::Salary.Properties.Resources.Search_icon;
            this.BtnBrows.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnBrows.Location = new System.Drawing.Point(532, 20);
            this.BtnBrows.Name = "BtnBrows";
            this.BtnBrows.Size = new System.Drawing.Size(19, 19);
            this.BtnBrows.TabIndex = 6;
            this.BtnBrows.Click += new System.EventHandler(this.BtnBrows_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnBrows.GetChildAt(0))).Image = global::Salary.Properties.Resources.Search_icon;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnBrows.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(16, 16);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnBrows.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(16, 16);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(686, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 17);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "کد کارمند:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.ucRadGridViewTools1);
            this.radGroupBox2.Controls.Add(this.Grd);
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "لیست وام ها";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 94);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(754, 414);
            this.radGroupBox2.TabIndex = 22;
            this.radGroupBox2.Text = "لیست وام ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // ucRadGridViewTools1
            // 
            this.ucRadGridViewTools1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools1.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucRadGridViewTools1.GridView = this.Grd;
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 367);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(744, 42);
            this.ucRadGridViewTools1.TabIndex = 3;
            // 
            // Grd
            // 
            this.Grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Grd.Location = new System.Drawing.Point(5, 21);
            // 
            // 
            // 
            this.Grd.MasterTemplate.AllowAddNewRow = false;
            this.Grd.MasterTemplate.EnableAlternatingRowColor = true;
            this.Grd.MasterTemplate.EnableGrouping = false;
            this.Grd.MasterTemplate.MultiSelect = true;
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(744, 340);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            // 
            // FrmManageTasviye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 578);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "FrmManageTasviye";
            this.Text = "مدیریت تسویه پرسنلی";
            this.Load += new System.EventHandler(this.FrmManageTasviye_Load);
            this.Shown += new System.EventHandler(this.FrmManageTasviye_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnDetail;
        private Telerik.WinControls.UI.RadButton BtnAdd;
        private Telerik.WinControls.UI.RadButton BtnReport;
        private Telerik.WinControls.UI.RadButton BtnDel;
        private Telerik.WinControls.UI.RadButton BtnEdit;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton BtnSearch;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private UserControls.RadTextBoxLimited TxtCodePr;
        private UserControls.RadTextBox TxtNamePr;
        private Telerik.WinControls.UI.RadButton BtnBrows;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
        private UserControls.RadGridView Grd;
    }
}