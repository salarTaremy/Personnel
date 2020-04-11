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
    public partial class FrmFormulEydiSanavat : Permission.ClsMyForms
    {
        ClsOtherPayment Payment = new ClsOtherPayment();

        public FrmFormulEydiSanavat()
        {
            InitializeComponent();
        }

        private void FrmFormulEydiSanavat_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    FillGrd();
                }
                catch (Exception Ex)
                {
                    Global.Dialog.ShowErorr("بار گذاری فرم جاری با خطا مواجه شد", Ex.Message);
                }
            }
        }

        private void FillGrd()
        {
            try
            {
                this.Grd.DataSource = Payment.GetAllFormula();
                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["Name"].HeaderText = "نام";
                this.Grd.Columns["Value"].HeaderText = "فرمول";
                this.Grd.Columns["Name"].Width = 150;
                this.Grd.Columns["Value"].Width = 500;
            }
            catch (Exception EX)
            {

                throw EX;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow == null | this.Grd.Rows.Count == 0)
                {
                    Global.Dialog.ShowInfo("شما هیچ گزینه ای انتخاب نکرده اید");
                    return;
                }
                byte ID;
                ID = (byte)this.Grd.CurrentRow.Cells["ID"].Value;
                FrmAddEditFormulEydiSanavat Frm = new FrmAddEditFormulEydiSanavat(ID);
                Frm.ShowDialog();
                FillGrd();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در بارگذاری فرم  برای ویرایش فرمول جدید", ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow == null | this.Grd.Rows.Count == 0)
                {
                    Global.Dialog.ShowInfo("شما هیچ گزینه ای انتخاب نکرده اید");
                    return;
                }
                string Str = this.Grd.CurrentRow.Cells["Name"].Value.ToString();
                Str = $"آیا برای حذف {Str } مطمئن هستید";
                if (Global.Dialog.ShowQuestion(Str) == false)
                {
                    return;
                }
                byte ID;
                ID = (byte)this.Grd.CurrentRow.Cells["ID"].Value;
                if (this.Payment.DeleteFormula(ID) == true)
                {
                    Global.Dialog.ShowOK("حذف با موفقیت انجا م شد");
                    FillGrd();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه عیچ داده ای حذف نشد");
                }
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("عملیات حذف با خطا مواجه شد", Ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddEditFormulEydiSanavat Frm = new FrmAddEditFormulEydiSanavat();
                Frm.ShowDialog();
                FillGrd();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در بارگذاری فرم  برای افزودن فرمول جدید", ex.Message);
            }
        }
    }
}
