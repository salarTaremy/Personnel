namespace Salary.Forms
{
    partial class FrmLoanDetail
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
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ucRadGridViewTools1 = new UserControls.UcRadGridViewTools();
            this.Grd = new UserControls.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.TxtMandehRls = new UserControls.RadMaskedTextBox();
            this.TxtpardakhtiRls = new UserControls.RadMaskedTextBox();
            this.TxtTotalRls = new UserControls.RadMaskedTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.TxtMandeh = new UserControls.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotal = new UserControls.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.Txtpardakhti = new UserControls.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnUnClear = new Telerik.WinControls.UI.RadButton();
            this.BtnClear = new Telerik.WinControls.UI.RadButton();
            this.BtnOk = new Telerik.WinControls.UI.RadButton();
            this.BtnReport = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMandehRls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtpardakhtiRls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalRls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMandeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpardakhti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox3.Controls.Add(this.BtnUnClear);
            this.radGroupBox3.Controls.Add(this.BtnClear);
            this.radGroupBox3.Controls.Add(this.BtnOk);
            this.radGroupBox3.Controls.Add(this.BtnReport);
            this.radGroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox3.HeaderText = "ابزارها";
            this.radGroupBox3.Location = new System.Drawing.Point(12, 514);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(831, 52);
            this.radGroupBox3.TabIndex = 22;
            this.radGroupBox3.Text = "ابزارها";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
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
            this.radGroupBox2.HeaderText = "لیست اقساط";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 130);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(831, 378);
            this.radGroupBox2.TabIndex = 21;
            this.radGroupBox2.Text = "لیست اقساط";
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
            this.ucRadGridViewTools1.Location = new System.Drawing.Point(5, 331);
            this.ucRadGridViewTools1.MaximumSize = new System.Drawing.Size(3000, 42);
            this.ucRadGridViewTools1.MinimumSize = new System.Drawing.Size(540, 42);
            this.ucRadGridViewTools1.Name = "ucRadGridViewTools1";
            this.ucRadGridViewTools1.Size = new System.Drawing.Size(821, 42);
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
            this.Grd.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.Grd.Name = "Grd";
            this.Grd.ProgressBar = null;
            this.Grd.ReadOnly = true;
            this.Grd.Size = new System.Drawing.Size(821, 304);
            this.Grd.TabIndex = 2;
            this.Grd.ValidChar = null;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.TxtMandehRls);
            this.radGroupBox1.Controls.Add(this.TxtpardakhtiRls);
            this.radGroupBox1.Controls.Add(this.TxtTotalRls);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.TxtMandeh);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.TxtTotal);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.Txtpardakhti);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radGroupBox1.HeaderText = "سایر اطلاعات";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(826, 112);
            this.radGroupBox1.TabIndex = 23;
            this.radGroupBox1.Text = "سایر اطلاعات";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // TxtMandehRls
            // 
            this.TxtMandehRls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMandehRls.Location = new System.Drawing.Point(246, 71);
            this.TxtMandehRls.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.TxtMandehRls.Name = "TxtMandehRls";
            this.TxtMandehRls.NextObject = null;
            this.TxtMandehRls.Size = new System.Drawing.Size(211, 19);
            this.TxtMandehRls.TabIndex = 25;
            this.TxtMandehRls.TabStop = false;
            this.TxtMandehRls.Text = "0";
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.TxtMandehRls.GetChildAt(0))).Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtMandehRls.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtMandehRls.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // TxtpardakhtiRls
            // 
            this.TxtpardakhtiRls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtpardakhtiRls.Location = new System.Drawing.Point(246, 46);
            this.TxtpardakhtiRls.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.TxtpardakhtiRls.Name = "TxtpardakhtiRls";
            this.TxtpardakhtiRls.NextObject = null;
            this.TxtpardakhtiRls.Size = new System.Drawing.Size(211, 19);
            this.TxtpardakhtiRls.TabIndex = 24;
            this.TxtpardakhtiRls.TabStop = false;
            this.TxtpardakhtiRls.Text = "0";
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.TxtpardakhtiRls.GetChildAt(0))).Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtpardakhtiRls.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtpardakhtiRls.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // TxtTotalRls
            // 
            this.TxtTotalRls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalRls.Location = new System.Drawing.Point(246, 21);
            this.TxtTotalRls.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.TxtTotalRls.Name = "TxtTotalRls";
            this.TxtTotalRls.NextObject = null;
            this.TxtTotalRls.Size = new System.Drawing.Size(211, 19);
            this.TxtTotalRls.TabIndex = 23;
            this.TxtTotalRls.TabStop = false;
            this.TxtTotalRls.Text = "0";
            ((Telerik.WinControls.UI.RadMaskedEditBoxElement)(this.TxtTotalRls.GetChildAt(0))).Text = "0";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtTotalRls.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtTotalRls.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel4.Location = new System.Drawing.Point(464, 71);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(58, 17);
            this.radLabel4.TabIndex = 21;
            this.radLabel4.Text = "مبلغ مانده:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel6
            // 
            this.radLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel6.Location = new System.Drawing.Point(721, 71);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(56, 17);
            this.radLabel6.TabIndex = 20;
            this.radLabel6.Text = "تعداد مانده";
            this.radLabel6.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtMandeh
            // 
            this.TxtMandeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMandeh.FocusColor = System.Drawing.Color.Azure;
            this.TxtMandeh.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtMandeh.IsRequierd = false;
            this.TxtMandeh.Location = new System.Drawing.Point(579, 70);
            this.TxtMandeh.Name = "TxtMandeh";
            this.TxtMandeh.Name_Farsi = null;
            this.TxtMandeh.NextObject = null;
            this.TxtMandeh.ReadOnly = true;
            this.TxtMandeh.Size = new System.Drawing.Size(136, 19);
            this.TxtMandeh.TabIndex = 19;
            this.TxtMandeh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtMandeh.GetChildAt(0).GetChildAt(0))).NullText = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtMandeh.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtMandeh.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 8.25F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtMandeh.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TxtMandeh.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.White;
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel3.Location = new System.Drawing.Point(464, 46);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(94, 17);
            this.radLabel3.TabIndex = 17;
            this.radLabel3.Text = "مبلغ پرداخت شده:";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel2.Location = new System.Drawing.Point(464, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(94, 17);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "مبلغ کل تسهیلات:";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.FocusColor = System.Drawing.Color.Azure;
            this.TxtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TxtTotal.IsRequierd = false;
            this.TxtTotal.Location = new System.Drawing.Point(579, 21);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Name_Farsi = null;
            this.TxtTotal.NextObject = null;
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(136, 19);
            this.TxtTotal.TabIndex = 16;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtTotal.GetChildAt(0).GetChildAt(0))).NullText = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtTotal.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.TxtTotal.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 8.25F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.TxtTotal.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.TxtTotal.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.White;
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel5.Location = new System.Drawing.Point(721, 46);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(97, 17);
            this.radLabel5.TabIndex = 15;
            this.radLabel5.Text = "تعداد پرداخت شده:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txtpardakhti
            // 
            this.Txtpardakhti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtpardakhti.FocusColor = System.Drawing.Color.Azure;
            this.Txtpardakhti.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Txtpardakhti.IsRequierd = false;
            this.Txtpardakhti.Location = new System.Drawing.Point(579, 45);
            this.Txtpardakhti.Name = "Txtpardakhti";
            this.Txtpardakhti.Name_Farsi = null;
            this.Txtpardakhti.NextObject = null;
            this.Txtpardakhti.ReadOnly = true;
            this.Txtpardakhti.Size = new System.Drawing.Size(136, 19);
            this.Txtpardakhti.TabIndex = 7;
            this.Txtpardakhti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.Txtpardakhti.GetChildAt(0).GetChildAt(0))).NullText = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.Txtpardakhti.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.Txtpardakhti.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 8.25F);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Txtpardakhti.GetChildAt(0).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(215)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.Txtpardakhti.GetChildAt(0).GetChildAt(2))).BackColor = System.Drawing.Color.White;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(722, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(84, 17);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "تعداد کل اقساط:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnUnClear
            // 
            this.BtnUnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnClear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnUnClear.Image = global::Salary.Properties.Resources.cortana_icon_6;
            this.BtnUnClear.Location = new System.Drawing.Point(484, 16);
            this.BtnUnClear.Name = "BtnUnClear";
            this.BtnUnClear.Size = new System.Drawing.Size(110, 31);
            this.BtnUnClear.TabIndex = 12;
            this.BtnUnClear.Text = "    عدم تسویه";
            this.BtnUnClear.Click += new System.EventHandler(this.BtnUnClear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnUnClear.GetChildAt(0))).Image = global::Salary.Properties.Resources.cortana_icon_6;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnUnClear.GetChildAt(0))).Text = "    عدم تسویه";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnUnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnUnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnUnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnUnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnClear.Image = global::Salary.Properties.Resources.cortana_icon_5;
            this.BtnClear.Location = new System.Drawing.Point(600, 16);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(110, 31);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "        تسویه قسط";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnClear.GetChildAt(0))).Image = global::Salary.Properties.Resources.cortana_icon_5;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnClear.GetChildAt(0))).Text = "        تسویه قسط";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnOk.Image = global::Salary.Properties.Resources.Blue__32_;
            this.BtnOk.Location = new System.Drawing.Point(5, 16);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(110, 31);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "تایید";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOk.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__32_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnOk.GetChildAt(0))).Text = "تایید";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnOk.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnReport.Image = global::Salary.Properties.Resources.Blue__1_;
            this.BtnReport.Location = new System.Drawing.Point(716, 16);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(110, 31);
            this.BtnReport.TabIndex = 9;
            this.BtnReport.Text = "گزارشات";
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Image = global::Salary.Properties.Resources.Blue__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnReport.GetChildAt(0))).Text = "گزارشات";
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit;
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MinSize = new System.Drawing.Size(32, 32);
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.BtnReport.GetChildAt(0).GetChildAt(1).GetChildAt(0))).MaxSize = new System.Drawing.Size(32, 32);
            // 
            // FrmLoanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 578);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox3);
            this.Controls.Add(this.radGroupBox2);
            this.Name = "FrmLoanDetail";
            this.Text = "مشاهده  جزئیات وام";
            this.Load += new System.EventHandler(this.FrmLoanDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grd.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMandehRls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtpardakhtiRls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalRls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMandeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpardakhti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadButton BtnReport;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private UserControls.UcRadGridViewTools ucRadGridViewTools1;
        private UserControls.RadGridView Grd;
        private Telerik.WinControls.UI.RadButton BtnOk;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private UserControls.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private UserControls.RadTextBox Txtpardakhti;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private UserControls.RadTextBox TxtMandeh;
        private UserControls.RadMaskedTextBox TxtMandehRls;
        private UserControls.RadMaskedTextBox TxtpardakhtiRls;
        private UserControls.RadMaskedTextBox TxtTotalRls;
        private Telerik.WinControls.UI.RadButton BtnClear;
        private Telerik.WinControls.UI.RadButton BtnUnClear;
    }
}