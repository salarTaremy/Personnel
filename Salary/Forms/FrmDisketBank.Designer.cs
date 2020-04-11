namespace Salary.Forms
{
    partial class FrmDisketBank
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.RadSepah = new System.Windows.Forms.RadioButton();
            this.RadMelli = new System.Windows.Forms.RadioButton();
            this.RadMellat = new System.Windows.Forms.RadioButton();
            this.BtnCancel = new Telerik.WinControls.UI.RadButton();
            this.BtnOk = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.RadSepah);
            this.radGroupBox1.Controls.Add(this.RadMelli);
            this.radGroupBox1.Controls.Add(this.RadMellat);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "نوع بانک";
            this.radGroupBox1.Location = new System.Drawing.Point(14, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(224, 101);
            this.radGroupBox1.TabIndex = 16;
            this.radGroupBox1.Text = "نوع بانک";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // RadSepah
            // 
            this.RadSepah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadSepah.AutoSize = true;
            this.RadSepah.Location = new System.Drawing.Point(117, 67);
            this.RadSepah.Name = "RadSepah";
            this.RadSepah.Size = new System.Drawing.Size(91, 17);
            this.RadSepah.TabIndex = 2;
            this.RadSepah.TabStop = true;
            this.RadSepah.Text = "فایل بانک سپه";
            this.RadSepah.UseVisualStyleBackColor = true;
            // 
            // RadMelli
            // 
            this.RadMelli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadMelli.AutoSize = true;
            this.RadMelli.Enabled = false;
            this.RadMelli.Location = new System.Drawing.Point(117, 44);
            this.RadMelli.Name = "RadMelli";
            this.RadMelli.Size = new System.Drawing.Size(91, 17);
            this.RadMelli.TabIndex = 1;
            this.RadMelli.TabStop = true;
            this.RadMelli.Text = "فایل بانک ملی";
            this.RadMelli.UseVisualStyleBackColor = true;
            // 
            // RadMellat
            // 
            this.RadMellat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RadMellat.AutoSize = true;
            this.RadMellat.Location = new System.Drawing.Point(117, 21);
            this.RadMellat.Name = "RadMellat";
            this.RadMellat.Size = new System.Drawing.Size(90, 17);
            this.RadMellat.TabIndex = 0;
            this.RadMellat.TabStop = true;
            this.RadMellat.Text = "فایل بانک ملت";
            this.RadMellat.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnCancel.Image = global::Salary.Properties.Resources.undo_yellow;
            this.BtnCancel.Location = new System.Drawing.Point(131, 125);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 31);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "خروج";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCancel.GetChildAt(0))).Image = global::Salary.Properties.Resources.undo_yellow;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCancel.GetChildAt(0))).Text = "خروج";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnCancel.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOk.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnOk.Image = global::Salary.Properties.Resources.Blue__32_;
            this.BtnOk.Location = new System.Drawing.Point(12, 125);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(110, 31);
            this.BtnOk.TabIndex = 20;
            this.BtnOk.Text = "تایید";
            this.BtnOk.Click += new System.EventHandler(this.BtnOKClick);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOk.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__32_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOk.GetChildAt(0))).Text = "تایید";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // FrmDisketBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 168);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.BtnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDisketBank";
            this.Text = "تهیه دیسک بانک";
            this.Load += new System.EventHandler(this.FrmDisketBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RadioButton RadSepah;
        private System.Windows.Forms.RadioButton RadMelli;
        private System.Windows.Forms.RadioButton RadMellat;
        private Telerik.WinControls.UI.RadButton BtnOk;
        private Telerik.WinControls.UI.RadButton BtnCancel;
    }
}