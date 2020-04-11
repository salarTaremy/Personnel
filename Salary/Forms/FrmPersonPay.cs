using Salary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class FrmPersonPay : Permission.ClsMyForms
    {
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        public FrmPersonPay()
        {
            InitializeComponent();
        }

        private void FrmPersonPay_Load(object sender, EventArgs e)
        {
            try
            {
                FillAllCmb();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در بارگذاری فرم", ex.Message);
            }
        }
        private void FillAllCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = Global.SalMali;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            short Year = (short)this.CmbYear.SelectedValue;
            this.CmbMonthA.DataSource = null;
            this.CmbMonthA.ValueMember = "ID";
            this.CmbMonthA.DisplayMember = "MonthName";
            DataTable DtYear = MY.GetAll(Year);
            this.CmbMonthA.DataSource = DtYear;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات نمیباشد", ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                ClsPersonPay PersonPay = new ClsPersonPay();
                short IDMonthOfSalary = 0;
                if (this.CmbMonthA.SelectedValue != null)
                {
                    IDMonthOfSalary = (short)this.CmbMonthA.SelectedValue;
                }
                else
                {
                    return;
                }
                this.Grd.DataSource = PersonPay.Get(IDMonthOfSalary);
                this.Grd.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
                this.Grd.Columns["ID"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["Code_melli"].HeaderText = "کد ملی";
                this.Grd.Columns["Price"].HeaderText = "مبلغ";
                this.Grd.Columns["Cnt"].HeaderText = "تعداد درخواست";
                this.Grd.Columns["Description"].HeaderText = "توضیحات";
                this.Grd.Columns["FullName"].Width = 238;
                this.Grd.Columns["ID"].Width = 83;
                this.Grd.Columns["Code_melli"].Width = 86;
                this.Grd.Columns["Price"].Width = 114;
                this.Grd.Columns["Cnt"].Width = 108;
                this.Grd.Columns["Description"].Width = 399;
                this.Grd.Columns["Price"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Price"].TextAlignment = ContentAlignment.MiddleLeft;
                for (int i = 0; i < Grd.Columns.Count ; i++)
                {
                    if (Grd.Columns[i].Name != "Price")
                    {
                        Grd.Columns[i].ReadOnly = true;
                    }
                }
                for (int i = 0; i < Grd.Rows.Count; i++)
                {
                    if (this.Grd.Rows[i].Cells["ID"].Value  == DBNull.Value  )
                    {
                        this.Grd.SetRowForeColor(i, Color.Red);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void CmbMonthA_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            FillGrd();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClsPersonPay pay = new ClsPersonPay();
            string Message = ""; 
            short ID_MonthOfSalary = (short)this.CmbMonthA.SelectedValue; ;
            long ID_pr;
            long Price;
            this.ProgressBar.Maximum = this.Grd.Rows.Count;
            this.ProgressBar.Visible = true;
            for (int i = 0; i < this.Grd.Rows.Count; i++)
            {
                ProgressBar.Value1 = i;
                Application.DoEvents();
                if (this.Grd.Rows[i].Cells["ID"].Value == DBNull.Value )
                {
                    continue;
                }
                ID_pr = (long)this.Grd.Rows[i].Cells["ID"].Value;
                Price = (long)this.Grd.Rows[i].Cells["Price"].Value;
                Message= pay.AddBuyToPayroll(ID_MonthOfSalary,ID_pr,Price);
                this.Grd.Rows[i].Cells["Description"].Value = Message;
            }
            this.ProgressBar.Value1 = 0;
            this.ProgressBar.Visible = false;
        }
    }
}
