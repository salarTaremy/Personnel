namespace Salary.Forms
{
    partial class FrmResidEydiSanavat
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CmbYear = new UserControls.RadDropDownList();
            this.radLabel10 = new Telerik.WinControls.UI.RadLabel();
            this.BtnSearch = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodePr = new UserControls.RadTextBoxLimited();
            this.TxtNamePr = new UserControls.RadTextBox();
            this.BtnBrows = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.CmbKargah = new UserControls.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CmbCompany = new UserControls.RadDropDownList();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 514);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(754, 52);
            this.radGroupBox3.TabIndex = 26;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnReport.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnReport.Location = new System.Drawing.Point(639, 16);
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
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.CmbKargah);
            this.radGroupBox1.Controls.Add(this.BtnBrows);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.CmbYear);
            this.radGroupBox1.Controls.Add(this.TxtNamePr);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.TxtCodePr);
            this.radGroupBox1.Controls.Add(this.radLabel10);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.CmbCompany);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.BtnSearch);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیلتر ها";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(754, 104);
            this.radGroupBox1.TabIndex = 24;
            this.radGroupBox1.Text = "فیلتر ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // CmbYear
            // 
            this.CmbYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbYear.DefaultItemsCountInDropDown = 15;
            this.CmbYear.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbYear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CmbYear.Location = new System.Drawing.Point(534, 21);
            this.CmbYear.Name = "CmbYear";
            this.CmbYear.Size = new System.Drawing.Size(148, 19);
            this.CmbYear.TabIndex = 86;
            // 
            // radLabel10
            // 
            this.radLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel10.Location = new System.Drawing.Point(688, 22);
            this.radLabel10.Name = "radLabel10";
            this.radLabel10.Size = new System.Drawing.Size(59, 17);
            this.radLabel10.TabIndex = 87;
            this.radLabel10.Text = "سال مالی:";
            this.radLabel10.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSearch.Image = global::Salary.Properties.Resources.Blue__35_;
            this.BtnSearch.Location = new System.Drawing.Point(5, 68);
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
            this.radLabel5.Location = new System.Drawing.Point(466, 47);
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
            this.TxtCodePr.Location = new System.Drawing.Point(338, 21);
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
            this.TxtNamePr.Location = new System.Drawing.Point(249, 46);
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
            this.BtnBrows.Location = new System.Drawing.Point(313, 21);
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
            this.radLabel1.Location = new System.Drawing.Point(467, 22);
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
            this.radGroupBox2.Location = new System.Drawing.Point(12, 122);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(754, 386);
            this.radGroupBox2.TabIndex = 25;
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
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 339);
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
            this.Grd.Size = new System.Drawing.Size(744, 312);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            // 
            // CmbKargah
            // 
            this.CmbKargah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbKargah.DefaultItemsCountInDropDown = 15;
            this.CmbKargah.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbKargah.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CmbKargah.Location = new System.Drawing.Point(534, 73);
            this.CmbKargah.Name = "CmbKargah";
            this.CmbKargah.Size = new System.Drawing.Size(148, 19);
            this.CmbKargah.TabIndex = 94;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(688, 74);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 17);
            this.radLabel2.TabIndex = 95;
            this.radLabel2.Text = "کارگاه:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // CmbCompany
            // 
            this.CmbCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCompany.DefaultItemsCountInDropDown = 15;
            this.CmbCompany.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CmbCompany.Location = new System.Drawing.Point(534, 47);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(148, 19);
            this.CmbCompany.TabIndex = 92;
            this.CmbCompany.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel7.Location = new System.Drawing.Point(688, 48);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(42, 17);
            this.radLabel7.TabIndex = 93;
            this.radLabel7.Text = "کارفرما:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmResidEydiSanavat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(778, 578);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "FrmResidEydiSanavat";
            this.Text = "رسید سالانه";
            this.Load += new System.EventHandler(this.FrmResidEydiSanavat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel10)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.CmbKargah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnReport;
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
        private UserControls.RadDropDownList CmbYear;
        private Telerik.WinControls.UI.RadLabel radLabel10;
        internal UserControls.RadDropDownList CmbKargah;
        internal Telerik.WinControls.UI.RadLabel radLabel2;
        private UserControls.RadDropDownList CmbCompany;
        private Telerik.WinControls.UI.RadLabel radLabel7;
    }
}