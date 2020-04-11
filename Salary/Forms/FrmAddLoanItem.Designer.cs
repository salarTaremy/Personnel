namespace Salary.Forms
{
    partial class FrmAddLoanItem
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
            this.TxtAmount = new UserControls.RadMaskedTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnClose = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAmount
            // 
            this.TxtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAmount.Location = new System.Drawing.Point(18, 21);
            this.TxtAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.NextObject = null;
            this.TxtAmount.Size = new System.Drawing.Size(160, 19);
            this.TxtAmount.TabIndex = 1;
            this.TxtAmount.TabStop = false;
            this.TxtAmount.Text = "0";
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Location = new System.Drawing.Point(184, 22);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(60, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "مبلغ قسط :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnClose.Image = global::Salary.Properties.Resources.Arrow_back;
            this.BtnClose.Location = new System.Drawing.Point(134, 46);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(110, 31);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "بازگشت";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnClose.GetChildAt(0))).Image = global::Salary.Properties.Resources.Arrow_back;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnClose.GetChildAt(0))).Text = "بازگشت";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClose.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClose.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClose.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClose.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.radButton2);
            this.radGroupBox3.Controls.Add(this.TxtAmount);
            this.radGroupBox3.Controls.Add(this.BtnClose);
            this.radGroupBox3.Controls.Add(this.radLabel1);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزار ها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(257, 91);
            this.radGroupBox3.TabIndex = 19;
            this.radGroupBox3.Text = "ابزار ها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // radButton2
            // 
            this.radButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radButton2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radButton2.Image = global::Salary.Properties.Resources.BtnSave;
            this.radButton2.Location = new System.Drawing.Point(18, 46);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 31);
            this.radButton2.TabIndex = 0;
            this.radButton2.Text = "ذخیره";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Image = global::Salary.Properties.Resources.BtnSave;
            ((Telerik.WinControls.UI.RadButtonElement)(this.radButton2.GetChildAt(0))).Text = "ذخیره";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.radButton2.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // FrmAddLoanItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 115);
            this.Controls.Add(this.radGroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddLoanItem";
            this.Text = "افزودن قسط جدید";
            this.Load += new System.EventHandler(this.FrmAddLoanItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.RadMaskedTextBox TxtAmount;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton BtnClose;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}