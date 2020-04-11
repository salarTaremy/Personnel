namespace Salary.Forms
{
    partial class FrmBlackListPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlackListPerson));
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CmbYear = new UserControls.RadDropDownList();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.CmbMonthA = new UserControls.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnAdd = new Telerik.WinControls.UI.RadButton();
            this.BtnDel = new Telerik.WinControls.UI.RadButton();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMonthA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
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
            this.radGroupBox2.Controls.Add(this.ucRadGridViewTools1);
            this.radGroupBox2.Controls.Add(this.Grd);
            this.radGroupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox2.HeaderText = "لیست فیش های حقوقی";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 90);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(853, 429);
            this.radGroupBox2.TabIndex = 26;
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
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 382);
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
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(843, 355);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.CmbYear);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.CmbMonthA);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیتر";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(853, 72);
            this.radGroupBox1.TabIndex = 25;
            this.radGroupBox1.Text = "فیتر";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
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
            // CmbMonthA
            // 
            this.CmbMonthA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbMonthA.DefaultItemsCountInDropDown = 15;
            this.CmbMonthA.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbMonthA.Location = new System.Drawing.Point(634, 41);
            this.CmbMonthA.Name = "CmbMonthA";
            this.CmbMonthA.Size = new System.Drawing.Size(148, 19);
            this.CmbMonthA.TabIndex = 32;
            this.CmbMonthA.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbMonthA_SelectedIndexChanged);
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
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnAdd);
            this.radGroupBox3.Controls.Add(this.BtnDel);
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 525);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(853, 52);
            this.radGroupBox3.TabIndex = 24;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(622, 16);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 31);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "اضافه";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAdd.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.BtnDel.Location = new System.Drawing.Point(738, 16);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(110, 31);
            this.BtnDel.TabIndex = 7;
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
            this.BtnReport.Location = new System.Drawing.Point(506, 16);
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
            // FrmBlackListPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 589);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox3);
            this.Name = "FrmBlackListPerson";
            this.Text = "لیست عدم پرداخت";
            this.Load += new System.EventHandler(this.FrmBlackListPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMonthA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
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
        private UserControls.RadDropDownList CmbYear;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private UserControls.RadDropDownList CmbMonthA;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnReport;
        private Telerik.WinControls.UI.RadButton BtnAdd;
        private Telerik.WinControls.UI.RadButton BtnDel;
    }
}