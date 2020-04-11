namespace Salary.Forms
{
    partial class FrmSyncMission
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
            this.BtnSave = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.UcDatePicker2 = new UserControls.UcDatePicker();
            this.radCheckBox2 = new Telerik.WinControls.UI.RadCheckBox();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.UcDatePicker1 = new UserControls.UcDatePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCodePr = new UserControls.RadTextBoxLimited();
            this.TxtNamePr = new UserControls.RadTextBox();
            this.BtnBrows = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSave.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnSave.Image = global::Salary.Properties.Resources.BtnSave;
            this.BtnSave.Location = new System.Drawing.Point(12, 169);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 31);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "تایید";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Image = global::Salary.Properties.Resources.BtnSave;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnSave.GetChildAt(0))).Text = "تایید";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.UcDatePicker2);
            this.radGroupBox1.Controls.Add(this.radCheckBox2);
            this.radGroupBox1.Controls.Add(this.radCheckBox1);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.UcDatePicker1);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.TxtCodePr);
            this.radGroupBox1.Controls.Add(this.TxtNamePr);
            this.radGroupBox1.Controls.Add(this.BtnBrows);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "مشخصات ماموریت";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(389, 151);
            this.radGroupBox1.TabIndex = 8;
            this.radGroupBox1.Text = "مشخصات ماموریت";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(315, 50);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(42, 17);
            this.radLabel2.TabIndex = 21;
            this.radLabel2.Text = "تا تاریخ:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcDatePicker2
            // 
            this.UcDatePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcDatePicker2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UcDatePicker2.Location = new System.Drawing.Point(161, 46);
            this.UcDatePicker2.Name = "UcDatePicker2";
            this.UcDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UcDatePicker2.Size = new System.Drawing.Size(148, 19);
            this.UcDatePicker2.TabIndex = 20;
            this.UcDatePicker2.txt = "";
            this.UcDatePicker2.TxtInt = 0;
            // 
            // radCheckBox2
            // 
            this.radCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox2.Enabled = false;
            this.radCheckBox2.Location = new System.Drawing.Point(83, 121);
            this.radCheckBox2.Name = "radCheckBox2";
            this.radCheckBox2.Size = new System.Drawing.Size(112, 18);
            this.radCheckBox2.TabIndex = 19;
            this.radCheckBox2.Text = "ماموریت های روزانه";
            this.radCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.radCheckBox1.Enabled = false;
            this.radCheckBox1.Location = new System.Drawing.Point(196, 121);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(119, 18);
            this.radCheckBox1.TabIndex = 18;
            this.radCheckBox1.Text = "ماموریت های ساعتی";
            this.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel6.Location = new System.Drawing.Point(315, 25);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(42, 17);
            this.radLabel6.TabIndex = 17;
            this.radLabel6.Text = "از تاریخ:";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // UcDatePicker1
            // 
            this.UcDatePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcDatePicker1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.UcDatePicker1.Location = new System.Drawing.Point(161, 21);
            this.UcDatePicker1.Name = "UcDatePicker1";
            this.UcDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UcDatePicker1.Size = new System.Drawing.Size(148, 19);
            this.UcDatePicker1.TabIndex = 0;
            this.UcDatePicker1.txt = "";
            this.UcDatePicker1.TxtInt = 0;
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel5.Location = new System.Drawing.Point(315, 98);
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
            this.TxtCodePr.Location = new System.Drawing.Point(161, 71);
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
            this.TxtNamePr.Location = new System.Drawing.Point(14, 96);
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
            this.BtnBrows.Location = new System.Drawing.Point(290, 71);
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
            this.radLabel1.Location = new System.Drawing.Point(315, 73);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 17);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "کد کارمند:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSyncMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 212);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSyncMission";
            this.Text = "ثبت خودکار ماموریت ها";
            this.Load += new System.EventHandler(this.FrmSyncMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNamePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBrows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnSave;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        internal UserControls.UcDatePicker UcDatePicker1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private UserControls.RadTextBoxLimited TxtCodePr;
        private UserControls.RadTextBox TxtNamePr;
        private Telerik.WinControls.UI.RadButton BtnBrows;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        internal UserControls.UcDatePicker UcDatePicker2;
    }
}