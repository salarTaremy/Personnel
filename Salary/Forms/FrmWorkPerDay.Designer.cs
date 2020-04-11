namespace Salary.Forms
{
    partial class FrmWorkPerDay
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.UcDatePicker2 = new UserControls.UcDatePicker();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.UcDatePicker1 = new UserControls.UcDatePicker();
            this.TxtCodePr = new UserControls.RadTextBoxLimited();
            this.TxtNamePr = new UserControls.RadTextBox();
            this.BtnBrows = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnDeConfirm = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.BtnSave);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.UcDatePicker2);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.UcDatePicker1);
            this.radGroupBox1.Controls.Add(this.TxtCodePr);
            this.radGroupBox1.Controls.Add(this.TxtNamePr);
            this.radGroupBox1.Controls.Add(this.BtnBrows);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "فیلتر های کارکرد";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(737, 74);
            this.radGroupBox1.TabIndex = 9;
            this.radGroupBox1.Text = "فیلتر های کارکرد";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSave.Image = global::Salary.Properties.Resources.Blue__35_;
            this.BtnSave.Location = new System.Drawing.Point(5, 32);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 31);
            this.BtnSave.TabIndex = 20;
            this.BtnSave.Text = "جستجو";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__35_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Text = "جستجو";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(289, 46);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(63, 17);
            this.radLabel2.TabIndex = 19;
            this.radLabel2.Text = "تاریخ خاتمه:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcDatePicker2
            // 
            this.UcDatePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcDatePicker2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UcDatePicker2.Location = new System.Drawing.Point(135, 46);
            this.UcDatePicker2.Name = "UcDatePicker2";
            this.UcDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UcDatePicker2.Size = new System.Drawing.Size(148, 19);
            this.UcDatePicker2.TabIndex = 18;
            this.UcDatePicker2.txt = "";
            this.UcDatePicker2.TxtInt = 0;
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel6.Location = new System.Drawing.Point(289, 23);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(63, 17);
            this.radLabel6.TabIndex = 17;
            this.radLabel6.Text = "تاریخ شروع:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel5.Location = new System.Drawing.Point(663, 48);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(56, 17);
            this.radLabel5.TabIndex = 15;
            this.radLabel5.Text = "نام کارمند:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcDatePicker1
            // 
            this.UcDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcDatePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UcDatePicker1.Location = new System.Drawing.Point(135, 21);
            this.UcDatePicker1.Name = "UcDatePicker1";
            this.UcDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UcDatePicker1.Size = new System.Drawing.Size(148, 19);
            this.UcDatePicker1.TabIndex = 0;
            this.UcDatePicker1.txt = "";
            this.UcDatePicker1.TxtInt = 0;
            // 
            // TxtCodePr
            // 
            this.TxtCodePr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodePr.FocusColor = System.Drawing.Color.Azure;
            this.TxtCodePr.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtCodePr.IsRequierd = false;
            this.TxtCodePr.Location = new System.Drawing.Point(509, 21);
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
            this.TxtNamePr.Location = new System.Drawing.Point(362, 46);
            this.TxtNamePr.Name = "TxtNamePr";
            this.TxtNamePr.Name_Farsi = null;
            this.TxtNamePr.NextObject = null;
            this.TxtNamePr.NullText = "کد پرسنلی  کارمند را وارد کنید";
            this.TxtNamePr.ReadOnly = true;
            this.TxtNamePr.Size = new System.Drawing.Size(295, 19);
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
            this.BtnBrows.Location = new System.Drawing.Point(638, 21);
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
            this.radLabel1.Location = new System.Drawing.Point(663, 23);
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
            this.radGroupBox2.HeaderText = "نمایش کارکرد";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 92);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(737, 416);
            this.radGroupBox2.TabIndex = 10;
            this.radGroupBox2.Text = "نمایش کارکرد";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // ucRadGridViewTools1
            // 
            this.ucRadGridViewTools1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools1.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools1.GridView = this.Grd;
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 369);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(727, 42);
            this.ucRadGridViewTools1.TabIndex = 3;
            // 
            // Grd
            // 
            this.Grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(727, 342);
            this.Grd.TabIndex = 2;
            this.Grd.Text = "radGridView1";
            this.Grd.ValidChar = null;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnDeConfirm);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 514);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(737, 52);
            this.radGroupBox3.TabIndex = 11;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnDeConfirm
            // 
            this.BtnDeConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeConfirm.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDeConfirm.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnDeConfirm.Location = new System.Drawing.Point(622, 16);
            this.BtnDeConfirm.Name = "BtnDeConfirm";
            this.BtnDeConfirm.Size = new System.Drawing.Size(110, 31);
            this.BtnDeConfirm.TabIndex = 12;
            this.BtnDeConfirm.Text = "گزارشات";
            this.BtnDeConfirm.Click += new System.EventHandler(this.BtnDeConfirm_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDeConfirm.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDeConfirm.GetChildAt(0))).Text = "گزارشات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeConfirm.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeConfirm.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeConfirm.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeConfirm.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // FrmWorkPerDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 578);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmWorkPerDay";
            this.Text = "کارکرد روزانه";
            this.Load += new System.EventHandler(this.FrmWorkPerDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeConfirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        internal UserControls.UcDatePicker UcDatePicker2;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        internal UserControls.UcDatePicker UcDatePicker1;
        private UserControls.RadTextBoxLimited TxtCodePr;
        private UserControls.RadTextBox TxtNamePr;
        private Telerik.WinControls.UI.RadButton BtnBrows;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadButton BtnSave;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
        private UserControls.RadGridView Grd;
        private Telerik.WinControls.UI.RadButton BtnDeConfirm;
    }
}