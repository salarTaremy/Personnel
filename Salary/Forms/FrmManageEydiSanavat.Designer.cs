namespace Salary.Forms
{
    partial class FrmManageEydiSanavat
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageEydiSanavat));
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.ucRadGridViewTools2 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.radPageViewPage2 = new Telerik.WinControls.UI.RadPageViewPage();
            this.ucRadGridViewTools3 = new UserControls.UcRadGridViewTools();
            this.GrdDetail = new UserControls.RadGridView();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.ucDatePicker2 = new UserControls.UcDatePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ucDatePicker1 = new UserControls.UcDatePicker();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnSearch = new Telerik.WinControls.UI.RadButton();
            this.BtnDisk = new Telerik.WinControls.UI.RadButton();
            this.BtnEdit = new Telerik.WinControls.UI.RadButton();
            this.BtnAdd = new Telerik.WinControls.UI.RadButton();
            this.BtnDel = new Telerik.WinControls.UI.RadButton();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            this.radPageViewPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetail.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.radPageView1);
            this.radGroupBox2.Controls.Add(this.ucRadGridViewTools1);
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "نمایش پرداخت ها";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 94);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(830, 396);
            this.radGroupBox2.TabIndex = 22;
            this.radGroupBox2.Text = "نمایش پرداخت ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage2);
            this.radPageView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPageView1.Location = new System.Drawing.Point(2, 18);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(826, 376);
            this.radPageView1.TabIndex = 82;
            this.radPageView1.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.UI.RadPageViewContentAreaElement)(this.radPageView1.GetChildAt(0).GetChildAt(1))).BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(153)))), ((int)(((byte)(210)))));
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.ucRadGridViewTools2);
            this.radPageViewPage1.Controls.Add(this.Grd);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(89F, 24F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 33);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(805, 332);
            this.radPageViewPage1.Text = "لیست پرداخت ها";
            // 
            // ucRadGridViewTools2
            // 
            this.ucRadGridViewTools2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools2.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucRadGridViewTools2.GridView = this.Grd;
            this.ucRadGridViewTools2.Location = new System.Drawing.Point(0, 287);
            this.ucRadGridViewTools2.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools2.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools2.Name = "ucRadGridViewTools2";
            this.ucRadGridViewTools2.Size = new System.Drawing.Size(802, 42);
            this.ucRadGridViewTools2.TabIndex = 4;
            // 
            // Grd
            // 
            this.Grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.Grd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Grd.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.Grd.MasterTemplate.AllowAddNewRow = false;
            this.Grd.MasterTemplate.EnableAlternatingRowColor = true;
            this.Grd.MasterTemplate.EnableGrouping = false;
            this.Grd.MasterTemplate.MultiSelect = true;
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(799, 278);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            this.Grd.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Grd_CellClick);
            // 
            // radPageViewPage2
            // 
            this.radPageViewPage2.Controls.Add(this.ucRadGridViewTools3);
            this.radPageViewPage2.Controls.Add(this.GrdDetail);
            this.radPageViewPage2.ItemSize = new System.Drawing.SizeF(93F, 24F);
            this.radPageViewPage2.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage2.Name = "radPageViewPage2";
            this.radPageViewPage2.Size = new System.Drawing.Size(805, 328);
            this.radPageViewPage2.Text = "جزئیات پرداخت ها";
            // 
            // ucRadGridViewTools3
            // 
            this.ucRadGridViewTools3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools3.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucRadGridViewTools3.GridView = this.GrdDetail;
            this.ucRadGridViewTools3.Location = new System.Drawing.Point(3, 283);
            this.ucRadGridViewTools3.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools3.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools3.Name = "ucRadGridViewTools3";
            this.ucRadGridViewTools3.Size = new System.Drawing.Size(799, 42);
            this.ucRadGridViewTools3.TabIndex = 5;
            // 
            // GrdDetail
            // 
            this.GrdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdDetail.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.GrdDetail.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.GrdDetail.Location = new System.Drawing.Point(3, 3);
            // 
            // 
            // 
            this.GrdDetail.MasterTemplate.AllowAddNewRow = false;
            this.GrdDetail.MasterTemplate.EnableAlternatingRowColor = true;
            this.GrdDetail.MasterTemplate.EnableGrouping = false;
            this.GrdDetail.MasterTemplate.MultiSelect = true;
            this.GrdDetail.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.GrdDetail.Name = "GrdDetail";
            this.GrdDetail.ProgressBar = null;
            this.GrdDetail.ReadOnly = true;
            this.GrdDetail.Size = new System.Drawing.Size(799, 274);
            this.GrdDetail.TabIndex = 3;
            this.GrdDetail.ValidChar = null;
            // 
            // ucRadGridViewTools1
            // 
            this.ucRadGridViewTools1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools1.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucRadGridViewTools1.GridView = this.Grd;
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 349);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(820, 42);
            this.ucRadGridViewTools1.TabIndex = 3;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.ucDatePicker2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.ucDatePicker1);
            this.radGroupBox1.Controls.Add(this.BtnSearch);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیلتر";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(830, 76);
            this.radGroupBox1.TabIndex = 21;
            this.radGroupBox1.Text = "فیلتر";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(739, 47);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(80, 17);
            this.radLabel2.TabIndex = 81;
            this.radLabel2.Text = "تا تاریخ پرداخت:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucDatePicker2
            // 
            this.ucDatePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDatePicker2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucDatePicker2.Location = new System.Drawing.Point(585, 46);
            this.ucDatePicker2.Name = "ucDatePicker2";
            this.ucDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucDatePicker2.Size = new System.Drawing.Size(148, 19);
            this.ucDatePicker2.TabIndex = 80;
            this.ucDatePicker2.txt = "";
            this.ucDatePicker2.TxtInt = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(739, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(80, 17);
            this.radLabel1.TabIndex = 79;
            this.radLabel1.Text = "از تاریخ پرداخت:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucDatePicker1
            // 
            this.ucDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDatePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ucDatePicker1.Location = new System.Drawing.Point(585, 21);
            this.ucDatePicker1.Name = "ucDatePicker1";
            this.ucDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ucDatePicker1.Size = new System.Drawing.Size(148, 19);
            this.ucDatePicker1.TabIndex = 78;
            this.ucDatePicker1.txt = "";
            this.ucDatePicker1.TxtInt = 0;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnDisk);
            this.radGroupBox3.Controls.Add(this.BtnEdit);
            this.radGroupBox3.Controls.Add(this.BtnAdd);
            this.radGroupBox3.Controls.Add(this.BtnDel);
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 496);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(830, 52);
            this.radGroupBox3.TabIndex = 23;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSearch.Image = global::Salary.Properties.Resources.Blue__35_;
            this.BtnSearch.Location = new System.Drawing.Point(5, 40);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(110, 31);
            this.BtnSearch.TabIndex = 77;
            this.BtnSearch.Text = "جستجو";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSearch.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__35_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSearch.GetChildAt(0))).Text = "جستجو";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSearch.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnDisk
            // 
            this.BtnDisk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisk.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDisk.Image = global::Salary.Properties.Resources.Blue__16_;
            this.BtnDisk.Location = new System.Drawing.Point(253, 16);
            this.BtnDisk.Name = "BtnDisk";
            this.BtnDisk.Size = new System.Drawing.Size(110, 31);
            this.BtnDisk.TabIndex = 28;
            this.BtnDisk.Text = "دیسکت بانک";
            this.BtnDisk.Click += new System.EventHandler(this.BtnDisk_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDisk.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__16_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDisk.GetChildAt(0))).Text = "دیسکت بانک";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDisk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDisk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDisk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDisk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Enabled = false;
            this.BtnEdit.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(717, 16);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(110, 31);
            this.BtnEdit.TabIndex = 24;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnEdit.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnEdit.GetChildAt(0))).Text = "ویرایش";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(485, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 31);
            this.BtnAdd.TabIndex = 26;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAdd.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAdd.GetChildAt(0))).Text = "اضافه";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDel.Image = global::Salary.Properties.Resources.BtnDelete_Image;
            this.BtnDel.Location = new System.Drawing.Point(601, 16);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(110, 31);
            this.BtnDel.TabIndex = 25;
            this.BtnDel.Text = "حذف";
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDel.GetChildAt(0))).Image = global::Salary.Properties.Resources.BtnDelete_Image;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDel.GetChildAt(0))).Text = "حذف";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnReport.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnReport.Location = new System.Drawing.Point(369, 16);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(110, 31);
            this.BtnReport.TabIndex = 27;
            this.BtnReport.Text = "گزارشات";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Text = "گزارشات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // FrmManageEydiSanavat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(854, 560);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox3);
            this.Name = "FrmManageEydiSanavat";
            this.Load += new System.EventHandler(this.FrmManageEydiSanavat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            this.radPageViewPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetail.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
        private UserControls.RadGridView Grd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        internal UserControls.UcDatePicker ucDatePicker2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        internal UserControls.UcDatePicker ucDatePicker1;
        private Telerik.WinControls.UI.RadButton BtnSearch;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnDisk;
        private Telerik.WinControls.UI.RadButton BtnEdit;
        private Telerik.WinControls.UI.RadButton BtnAdd;
        private Telerik.WinControls.UI.RadButton BtnDel;
        private Telerik.WinControls.UI.RadButton BtnReport;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage2;
        private UserControls.RadGridView GrdDetail;
        private UserControls.UcRadGridViewTools ucRadGridViewTools2;
        private UserControls.UcRadGridViewTools ucRadGridViewTools3;
    }
}