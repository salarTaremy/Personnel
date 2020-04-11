namespace Salary.Forms
{
    partial class FrmMonthlyList
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CmbKargahEx = new UserControls.RadDropDownList();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.CmbCompany = new UserControls.RadDropDownList();
            this.CmbYear = new UserControls.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CmbMonthA = new UserControls.RadDropDownList();
            this.CmbMahalleKhedmat = new UserControls.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnView = new Telerik.WinControls.UI.RadButton();
            this.CmbKargah = new UserControls.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            this.ChkAdamPardakht = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargahEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMonthA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMahalleKhedmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkAdamPardakht)).BeginInit();
            this.SuspendLayout();
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
            this.radGroupBox2.HeaderText = "لیست فیش های حقوقی";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 117);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(853, 402);
            this.radGroupBox2.TabIndex = 23;
            this.radGroupBox2.Text = "لیست فیش های حقوقی";
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
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 355);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(843, 42);
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
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(843, 328);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ChkAdamPardakht);
            this.radGroupBox1.Controls.Add(this.CmbKargahEx);
            this.radGroupBox1.Controls.Add(this.radLabel8);
            this.radGroupBox1.Controls.Add(this.CmbCompany);
            this.radGroupBox1.Controls.Add(this.CmbYear);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.CmbMonthA);
            this.radGroupBox1.Controls.Add(this.CmbMahalleKhedmat);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.BtnView);
            this.radGroupBox1.Controls.Add(this.CmbKargah);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیتر";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(853, 99);
            this.radGroupBox1.TabIndex = 22;
            this.radGroupBox1.Text = "فیتر";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // CmbKargahEx
            // 
            this.CmbKargahEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbKargahEx.DefaultItemsCountInDropDown = 15;
            this.CmbKargahEx.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbKargahEx.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CmbKargahEx.Location = new System.Drawing.Point(634, 66);
            this.CmbKargahEx.Name = "CmbKargahEx";
            this.CmbKargahEx.Size = new System.Drawing.Size(148, 19);
            this.CmbKargahEx.TabIndex = 77;
            // 
            // radLabel8
            // 
            this.radLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel8.ForeColor = System.Drawing.Color.Red;
            this.radLabel8.Location = new System.Drawing.Point(788, 67);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(63, 17);
            this.radLabel8.TabIndex = 78;
            this.radLabel8.Text = "غیراز کارگاه:";
            this.radLabel8.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // CmbCompany
            // 
            this.CmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCompany.DefaultItemsCountInDropDown = 15;
            this.CmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbCompany.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CmbCompany.Location = new System.Drawing.Point(393, 16);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(148, 19);
            this.CmbCompany.TabIndex = 41;
            this.CmbCompany.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // CmbYear
            // 
            this.CmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbYear.DefaultItemsCountInDropDown = 15;
            this.CmbYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbYear.Location = new System.Drawing.Point(634, 16);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(148, 19);
            this.CmbYear.TabIndex = 30;
            this.CmbYear.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbYear_SelectedIndexChanged);
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel6.Location = new System.Drawing.Point(788, 42);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(25, 17);
            this.radLabel6.TabIndex = 33;
            this.radLabel6.Text = "ماه:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(547, 17);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(42, 17);
            this.radLabel2.TabIndex = 42;
            this.radLabel2.Text = "شرکت:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // CmbMonthA
            // 
            this.CmbMonthA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMonthA.DefaultItemsCountInDropDown = 15;
            this.CmbMonthA.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbMonthA.Location = new System.Drawing.Point(634, 41);
            this.CmbMonthA.Name = "CmbMonthA";
            this.CmbMonthA.Size = new System.Drawing.Size(148, 19);
            this.CmbMonthA.TabIndex = 32;
            // 
            // CmbMahalleKhedmat
            // 
            this.CmbMahalleKhedmat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMahalleKhedmat.DefaultItemsCountInDropDown = 15;
            this.CmbMahalleKhedmat.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbMahalleKhedmat.Location = new System.Drawing.Point(393, 66);
            this.CmbMahalleKhedmat.Name = "CmbMahalleKhedmat";
            this.CmbMahalleKhedmat.Size = new System.Drawing.Size(148, 19);
            this.CmbMahalleKhedmat.TabIndex = 39;
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel4.Location = new System.Drawing.Point(788, 17);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(59, 17);
            this.radLabel4.TabIndex = 31;
            this.radLabel4.Text = "سال مالی:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel3.Location = new System.Drawing.Point(547, 67);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 17);
            this.radLabel3.TabIndex = 40;
            this.radLabel3.Text = "محل خدمت:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnView
            // 
            this.BtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnView.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnView.Image = global::Salary.Properties.Resources._1037;
            this.BtnView.Location = new System.Drawing.Point(5, 63);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(110, 31);
            this.BtnView.TabIndex = 38;
            this.BtnView.Text = "       نمایش لیست";
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnView.GetChildAt(0))).Image = global::Salary.Properties.Resources._1037;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnView.GetChildAt(0))).Text = "       نمایش لیست";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // CmbKargah
            // 
            this.CmbKargah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbKargah.DefaultItemsCountInDropDown = 15;
            this.CmbKargah.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbKargah.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CmbKargah.Location = new System.Drawing.Point(393, 41);
            this.CmbKargah.Name = "CmbKargah";
            this.CmbKargah.Size = new System.Drawing.Size(148, 19);
            this.CmbKargah.TabIndex = 36;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(547, 42);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(37, 17);
            this.radLabel1.TabIndex = 37;
            this.radLabel1.Text = "کارگاه:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 525);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(853, 52);
            this.radGroupBox3.TabIndex = 21;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnReport.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnReport.Location = new System.Drawing.Point(738, 16);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(110, 31);
            this.BtnReport.TabIndex = 9;
            this.BtnReport.Text = "  گزارشات";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Text = "  گزارشات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // ChkAdamPardakht
            // 
            this.ChkAdamPardakht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkAdamPardakht.Location = new System.Drawing.Point(32, 17);
            this.ChkAdamPardakht.Name = "ChkAdamPardakht";
            this.ChkAdamPardakht.Size = new System.Drawing.Size(355, 18);
            this.ChkAdamPardakht.TabIndex = 79;
            this.ChkAdamPardakht.Text = "نمایش همه(افرادی که در لیست عدم پرداخت قرار دارند نمایش داده شوند)";
            // 
            // FrmMonthlyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 589);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox3);
            this.Name = "FrmMonthlyList";
            this.Text = "لیست ماهانه حقوق ";
            this.Load += new System.EventHandler(this.FrmMonthlyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargahEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMonthA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMahalleKhedmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkAdamPardakht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
        private UserControls.RadGridView Grd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton BtnView;
        internal UserControls.RadDropDownList CmbKargah;
        private UserControls.RadDropDownList CmbYear;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        internal Telerik.WinControls.UI.RadLabel radLabel1;
        private UserControls.RadDropDownList CmbMonthA;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnReport;
        private UserControls.RadDropDownList CmbMahalleKhedmat;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        internal UserControls.RadDropDownList CmbCompany;
        internal Telerik.WinControls.UI.RadLabel radLabel2;
        internal UserControls.RadDropDownList CmbKargahEx;
        internal Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadCheckBox ChkAdamPardakht;
    }
}