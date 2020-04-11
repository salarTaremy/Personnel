using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class FrmTax : Permission.ClsMyForms
    {
        ClsTax Tax = new ClsTax();
        public FrmTax()
        {
            InitializeComponent();
        }

        private void FrmTax_Load(object sender, EventArgs e)
        {
            try
            {
                FillCmb();
                FillGrd();
                AddColumn();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("مشکلی در بار گذ‌اری فرم بوجود آمده",ex.Message);
            }
        }
        private void AddColumn()
        {
            Telerik.WinControls.UI.GridViewCommandColumn Col = new Telerik.WinControls.UI.GridViewCommandColumn();
            Col.DefaultText = "";
            Col.ImageLayout = ImageLayout.Stretch; 
            Col.HeaderText = "حذف";
            Col.Name = "BtnRemoveRow";
            Col.IsPinned = true;
            Col.ImageAlignment = ContentAlignment.MiddleCenter;
            Col.Image = global::Salary.Properties.Resources._24;
            Col.Width = 45;
            this.Grd.Columns.Add(Col);   
        }
        private void FillCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                CmbSalMaliA.ValueMember = "ID";
                CmbSalMaliA.DisplayMember = "Name";
                CmbSalMaliA.DataSource = SalMali.GetSalMali();
                CmbSalMaliA.SelectedValue = Global.SalMali;
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("مشکلی در  خواندن اطلاعات سال مالی بوجود آمده است",ex.Message);
            }
        }
        private void FillGrd()
        {
            this.Grd.DataSource = Tax.GetTax( (short)this.CmbSalMaliA.SelectedValue);
            this.Grd.Columns["StartRange"].HeaderText = "از بازه(حقوق ماهانه)";
            this.Grd.Columns["EndRange"].HeaderText = "تا بازه (حقوق ماهانه)";
            this.Grd.Columns["PerCent"].HeaderText = "درصد مالیات";
            this.Grd.Columns["StartRange"].FormatString= "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["EndRange"].FormatString= "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["PerCent"].FormatString = "{0:#,###,##0.00;(#,###,0.00)}";
            this.Grd.Columns["StartRange"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["EndRange"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["PerCent"].TextAlignment = ContentAlignment.MiddleCenter;
            this.Grd.Columns["StartRange"].Width = 170;
            this.Grd.Columns["EndRange"].Width = 170;
            this.Grd.Columns["PerCent"].Width = 170;
            if (this.Grd.Columns.Contains("BtnRemoveRow"))
	            {
		             this.Grd.Columns["BtnRemoveRow"].Width = 45;
	            }
        }

        private void CmbSalMaliA_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بار گذاری اطلاعات در گرید با خطا مواجه شد",ex.Message);
            }
        }
        private void Grd_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Name == "BtnRemoveRow")
                {
                    this.Grd.Rows.Remove(this.Grd.Rows[e.RowIndex]);
                }
            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr(ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                int RowAffect  = this.Tax.Save((short)this.CmbSalMaliA.SelectedValue, GetDt() );
                if (RowAffect == 0)
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ  اطلاعاتی ذخیره نشد");
                }
                else
                {
                    Global.Dialog.ShowOK(string.Format("تعداد {0} ردیف با موفقیت ثبت شد", RowAffect));
                }

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در ذخیره اطلاعات" ,ex.Message);
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() == false)
                {
                    return;
                }
                else
                {
                    Add();
                }

            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("افزودن اطلاعات با خطا مواجه  شد" ,ex.Message);
            }
        }
        bool IsValidData()
        {
            if (this.TxtFrom.Rls >+ this.TxtTo.Rls)
            {
                Global.Dialog.ShowInfo("مقادیر نا معتبر است. مقدار بازه شروع باید از مقدار بازه خاتمه کمتر باشد");
                return false;
            }
            //if (this.TxtPerCent.Value == 0 )
            //{
            //    Global.Dialog.ShowInfo("درصد نا معتبر است");
            //    return false;
            //}
            if (this.TxtTo.Rls == 0 )
            {
                Global.Dialog.ShowInfo("مقدار بازه پایانی نا معتبر است");
                return false;
            }
            return true;
        }
        private void Add()
        { 
            this.Grd.Rows.AddNew() ;
            int Index = this.Grd.Rows.Count - 1;
            this.Grd.Rows[Index].Cells["StartRange"].Value = this.TxtFrom.Rls;
            this.Grd.Rows[Index].Cells["EndRange"].Value = this.TxtTo.Rls;
            this.Grd.Rows[Index].Cells["Percent"].Value = this.TxtPerCent.Value;
            this.Grd.CurrentRow = this.Grd.Rows[Index];
            Clear();
        }
        private void Clear()
        {
            this.TxtFrom.Text = "";
            this.TxtTo.Text = "";
            this.TxtPerCent.Value = 0;
        }
        private DataTable GetDt()
        {
            DataTable ReturnDt = new DataTable();
            DataRow Dr ;
            ReturnDt.Columns.Add("StartRange" ,typeof(long) );
            ReturnDt.Columns.Add("EndRange", typeof(long));
            ReturnDt.Columns.Add("Percent", typeof(decimal));
            for (int i = 0; i < this.Grd.Rows.Count; i++)
			{
			    Dr = ReturnDt.NewRow();
                Dr["StartRange"] = this.Grd.Rows[i].Cells["StartRange"].Value.ToString() ;
                Dr["EndRange"] = this.Grd.Rows[i].Cells["EndRange"].Value.ToString() ;
                Dr["Percent"] = this.Grd.Rows[i].Cells["Percent"].Value.ToString() ;
                ReturnDt.Rows.Add(Dr);
			}
            return ReturnDt;
        }

    }
}
