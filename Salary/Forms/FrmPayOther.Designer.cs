namespace Salary.Forms
{
    partial class FrmPayOther
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox4 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnDeleteRow = new Telerik.WinControls.UI.RadButton();
            this.BtnAddNewRow = new Telerik.WinControls.UI.RadButton();
            this.Grd = new UserControls.RadGridView();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.TxtDescription = new UserControls.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSharh = new UserControls.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.UcDate = new UserControls.UcDatePicker();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).BeginInit();
            this.radGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddNewRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSharh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox4
            // 
            this.radGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox4.Controls.Add(this.ucRadGridViewTools1);
            this.radGroupBox4.Controls.Add(this.BtnDeleteRow);
            this.radGroupBox4.Controls.Add(this.BtnAddNewRow);
            this.radGroupBox4.Controls.Add(this.Grd);
            this.radGroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox4.HeaderText = "سایر پارامتر ها";
            this.radGroupBox4.Location = new System.Drawing.Point(12, 119);
            this.radGroupBox4.Name = "radGroupBox4";
            this.radGroupBox4.Size = new System.Drawing.Size(757, 373);
            this.radGroupBox4.TabIndex = 19;
            this.radGroupBox4.Text = "سایر پارامتر ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox4.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox4.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnDeleteRow
            // 
            this.BtnDeleteRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDeleteRow.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnDeleteRow.Image = global::Salary.Properties.Resources._1075;
            this.BtnDeleteRow.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeleteRow.Location = new System.Drawing.Point(698, 21);
            this.BtnDeleteRow.Name = "BtnDeleteRow";
            this.BtnDeleteRow.Size = new System.Drawing.Size(19, 19);
            this.BtnDeleteRow.TabIndex = 30;
            this.BtnDeleteRow.Click += new System.EventHandler(this.BtnDeleteRow_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDeleteRow.GetChildAt(0))).Image = global::Salary.Properties.Resources._1075;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnDeleteRow.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeleteRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeleteRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeleteRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(16, 16);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnDeleteRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(16, 16);
            // 
            // BtnAddNewRow
            // 
            this.BtnAddNewRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddNewRow.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnAddNewRow.Image = global::Salary.Properties.Resources._1104;
            this.BtnAddNewRow.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAddNewRow.Location = new System.Drawing.Point(723, 21);
            this.BtnAddNewRow.Name = "BtnAddNewRow";
            this.BtnAddNewRow.Size = new System.Drawing.Size(19, 19);
            this.BtnAddNewRow.TabIndex = 29;
            this.BtnAddNewRow.Click += new System.EventHandler(this.BtnAddNewRow_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAddNewRow.GetChildAt(0))).Image = global::Salary.Properties.Resources._1104;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAddNewRow.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAddNewRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAddNewRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAddNewRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(16, 16);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnAddNewRow.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(16, 16);
            // 
            // Grd
            // 
            this.Grd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd.EnterKeyMode = Telerik.WinControls.UI.RadGridViewEnterKeyMode.EnterMovesToNextRow;
            this.Grd.Location = new System.Drawing.Point(5, 46);
            // 
            // 
            // 
            this.Grd.MasterTemplate.AllowAddNewRow = false;
            this.Grd.MasterTemplate.AllowDeleteRow = false;
            this.Grd.MasterTemplate.EnableAlternatingRowColor = true;
            this.Grd.MasterTemplate.EnableGrouping = false;
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.Size = new System.Drawing.Size(747, 274);
            this.Grd.TabIndex = 0;
            this.Grd.ValidChar = null;
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnSave);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزار ها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 498);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(757, 57);
            this.radGroupBox3.TabIndex = 18;
            this.radGroupBox3.Text = "ابزار ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSave.Image = global::Salary.Properties.Resources.BtnSave;
            this.BtnSave.Location = new System.Drawing.Point(5, 21);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 31);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Image = global::Salary.Properties.Resources.BtnSave;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Text = "ذخیره";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel8);
            this.radGroupBox1.Controls.Add(this.TxtDescription);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.TxtSharh);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.UcDate);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "مشخصات ماه حقوقی";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(757, 101);
            this.radGroupBox1.TabIndex = 17;
            this.radGroupBox1.Text = "مشخصات ماه حقوقی";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radLabel8
            // 
            this.radLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel8.Location = new System.Drawing.Point(674, 48);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(51, 17);
            this.radLabel8.TabIndex = 40;
            this.radLabel8.Text = "توضیحات:";
            this.radLabel8.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.AutoSize = false;
            this.TxtDescription.FocusColor = System.Drawing.Color.Azure;
            this.TxtDescription.IsRequierd = false;
            this.TxtDescription.Location = new System.Drawing.Point(5, 46);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Name_Farsi = null;
            this.TxtDescription.NextObject = null;
            this.TxtDescription.Size = new System.Drawing.Size(663, 46);
            this.TxtDescription.TabIndex = 39;
            this.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel7
            // 
            this.radLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel7.Location = new System.Drawing.Point(449, 22);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(70, 17);
            this.radLabel7.TabIndex = 38;
            this.radLabel7.Text = "شرح پرداخت:";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtSharh
            // 
            this.TxtSharh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSharh.FocusColor = System.Drawing.Color.Azure;
            this.TxtSharh.IsRequierd = false;
            this.TxtSharh.Location = new System.Drawing.Point(5, 21);
            this.TxtSharh.Name = "TxtSharh";
            this.TxtSharh.Name_Farsi = null;
            this.TxtSharh.NextObject = null;
            this.TxtSharh.Size = new System.Drawing.Size(438, 19);
            this.TxtSharh.TabIndex = 37;
            this.TxtSharh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel6.Location = new System.Drawing.Point(674, 21);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(69, 17);
            this.radLabel6.TabIndex = 32;
            this.radLabel6.Text = "تاریخ پرداخت:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcDate
            // 
            this.UcDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UcDate.Location = new System.Drawing.Point(520, 20);
            this.UcDate.Name = "UcDate";
            this.UcDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UcDate.Size = new System.Drawing.Size(148, 19);
            this.UcDate.TabIndex = 31;
            this.UcDate.txt = "";
            this.UcDate.TxtInt = 0;
            // 
            // ucRadGridViewTools1
            // 
            this.ucRadGridViewTools1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucRadGridViewTools1.BackColor = System.Drawing.Color.Transparent;
            this.ucRadGridViewTools1.GridView = this.Grd;
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 326);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(747, 42);
            this.ucRadGridViewTools1.TabIndex = 31;
            // 
            // FrmPayOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 567);
            this.Controls.Add(this.radGroupBox4);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmPayOther";
            this.Text = " پرداخت متفرقه";
            this.Load += new System.EventHandler(this.FrmPayOther_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox4)).EndInit();
            this.radGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddNewRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSharh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox4;
        private Telerik.WinControls.UI.RadButton BtnDeleteRow;
        private Telerik.WinControls.UI.RadButton BtnAddNewRow;
        private UserControls.RadGridView Grd;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnSave;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private UserControls.RadTextBox TxtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private UserControls.RadTextBox TxtSharh;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        internal UserControls.UcDatePicker UcDate;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
    }
}