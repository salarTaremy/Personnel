using Permission;
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
    public partial class FrmMonthOfSalary :  ClsMyForms
    {
        ClsMonthOfSalary MonthOfSalary = new ClsMonthOfSalary();
        public FrmMonthOfSalary()
        {
            InitializeComponent();
        }
        private void FrmMonthOfSalary_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                    this.Grd.DataSource = MonthOfSalary.GetAll();
                    this.Grd.Columns["Year"].HeaderText = "سال مالی";
                    this.Grd.Columns["MonthName"].HeaderText = "ماه";
                    this.Grd.Columns["From"].HeaderText = "شروع بازه محاسبات";
                    this.Grd.Columns["To"].HeaderText = "خاتمه بازه محاسبات";
                    this.Grd.Columns["Year"].Width = 70 ;
                    this.Grd.Columns["MonthName"].Width = 240;
                    this.Grd.Columns["From"].Width = 145;
                    this.Grd.Columns["To"].Width = 145;
                    this.Grd.Columns["ID"].IsVisible = false;
                    this.Grd.Columns["ID_MOnth"].IsVisible = false;
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات ماه ها از پایگاه داده با مشکل واجه شد", Ex.Message);
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.SelectedRows.Count == 0 )
	                {
                        Global.Dialog.ShowInfo("شما هیچ ایتمی  جهت حذف کردن انتخاب نکرده اید");
                        return;
	                }
                string Msg = "آیا برای حذف ماه  {0} از سال {1} مطمئن هستید ؟";
                Msg = string.Format(Msg, Grd.CurrentRow.Cells["MonthName"].Value, Grd.CurrentRow.Cells["Year"].Value);
                if (Global.Dialog.ShowQuestion(Msg) == false)
                {
                    return ;
                }

                int RowAffect = MonthOfSalary.Delete((short)Grd.CurrentRow.Cells["ID"].Value);
                if (RowAffect > 0)
                {
                    Global.Dialog.ShowOK("حذف با موفقیت انجام شد");
                    FillGrid();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی حذف نشد");
                }
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("عملیا ت حذف با خطا مواجه شد", Ex.Message);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddMonthOfSalary FrmAddMonthOfSalary = new FrmAddMonthOfSalary();
                FrmAddMonthOfSalary.ShowDialog();
                FillGrid();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("عملیا ت بار گذاری فرم با خطا مواجه شد", Ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.SelectedRows.Count  == 0 )
	            {
                    Global.Dialog.ShowInfo("یکی از ماه ها را برای ویرایش انتخاب کنید");
                    return;
	            }
                short ID = (short)Grd.CurrentRow.Cells["ID"].Value;
                FrmAddMonthOfSalary FrmAddMonthOfSalary = new FrmAddMonthOfSalary(ID);
                FrmAddMonthOfSalary.ShowDialog();
                FillGrid();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("عملیا ت بار گذاری فرم ویرایش با خطا مواجه شد", Ex.Message);
            }
        }

        private void Grd_Click(object sender, EventArgs e)
        {

        }
    }
}
