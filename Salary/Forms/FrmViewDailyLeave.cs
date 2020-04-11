using Personnely;
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
    public partial class FrmViewDailyLeave : Permission.ClsMyForms
    {

        ClsDailyLeave DL = new ClsDailyLeave();
        ClsPersonel Person = new ClsPersonel();
        public FrmViewDailyLeave()
        {
            InitializeComponent();
        }
        private void FrmViewDailyLeave_Load(object sender, EventArgs e)
        {
            this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth);
            this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                this.Grd.DataSource = DL.GetAll(Person, this.UcDatePicker1.TxtInt, this.UcDatePicker2.TxtInt);
                this.Grd.Columns["ID"].HeaderText = "ID";
                this.Grd.Columns["FromDate"].HeaderText = "از تاریخ";
                this.Grd.Columns["ToDate"].HeaderText = "تا تاریخ";
                this.Grd.Columns["ID_Type"].HeaderText = "کد نوع ماموریت";
                this.Grd.Columns["ID_Personel"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام";
                this.Grd.Columns["DayCount"].HeaderText = "تعداد روز";
                this.Grd.Columns["Name_Type"].HeaderText = "شرح";
                this.Grd.Columns["IsConfirm"].HeaderText = "تایید";

                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["ID_Type"].IsVisible = false;
                this.Grd.Columns["ID"].Width = 50;
                this.Grd.Columns["FromDate"].Width = 70;
                this.Grd.Columns["ToDate"].Width = 70;
                this.Grd.Columns["ID_Type"].Width = 195;
                this.Grd.Columns["ID_Personel"].Width = 105;
                this.Grd.Columns["FullName"].Width = 235;
                this.Grd.Columns["DayCount"].Width = 65;
                this.Grd.Columns["Name_Type"].Width = 165;
                this.Grd.Columns["IsConfirm"].Width = 70;


            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("هنگام باز کردن صفحه  افزودن ماموریت روزانه مشکلی به وجود آمد  ", Ex.Message);
            }
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString();
        }

        private void TxtCodePr_TextChanged(object sender, EventArgs e)
        {
            string Code = this.TxtCodePr.Text;
            if (string.IsNullOrEmpty(Code))
            {
                Code = "0";
            }
            Person = new ClsPersonel(Code);
            if (Person.Exists)
            {
                TxtNamePr.Text = Person.Name + " " + Person.Famil;
            }
            else
            {
                TxtNamePr.Text = null;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grd.SelectedRows.Count == 0)
                {
                    Global.Dialog.ShowInfo("لطفا یک مورد جهت ویرایش انتخاب کنبد");
                    return;
                }
                FrmDailyLeave Frm = new FrmDailyLeave((long)this.Grd.CurrentRow.Cells["ID"].Value);
                Frm.ShowDialog();
                FillGrid();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه مشکلی در روند ویرایش بوجود آمد", ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.SelectedRows.Count == 0)
                {
                    return;
                }

                string Msg = string.Format("آیا برای حذف مرخصی مورخه'{0}' تا '{1}'  مربوط به '{2}' مطمئن هستید ؟", (string)this.Grd.CurrentRow.Cells["FromDate"].Value, (string)this.Grd.CurrentRow.Cells["Todate"].Value, (string)this.Grd.CurrentRow.Cells["fullName"].Value);
                if (Global.Dialog.ShowQuestion(Msg) == false)
                {
                    return;
                }
                long ID = (long)this.Grd.CurrentRow.Cells["ID"].Value;
                if (DL.Delete(ID) > 0)
                {
                    Global.Dialog.ShowOK("حذف مرخصی با موفقیت انجام شد");
                    FillGrid();
                }
                else
                {
                    Global.Dialog.ShowOK("متاسفانه رکوردی حذف نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه مشکلی در روند حذف بوجود آمد", ex.Message);
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = DL.SetConfirm(true, Grd.GetSelectedItems("ID"));
                if (RowAffect > 0)
                {
                    Global.Dialog.ShowOK(string.Format("تعداد  {0} ردیف با موفقیت تایید شد", RowAffect));
                    FillGrid();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ موردی تایید نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات تایید با خطا مواجه شد");
            }
        }

        private void BtnDeConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = DL.SetConfirm(false, Grd.GetSelectedItems("ID"));
                if (RowAffect > 0)
                {
                    Global.Dialog.ShowOK(string.Format("تعداد  {0} ردیف با موفقیت از تایید خارج شد", RowAffect));
                    FillGrid();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ موردی از تایید خارج نشد ");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات عدم تایید با خطا مواجه شد");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDailyLeave Frm = new FrmDailyLeave();
                Frm.ShowDialog();
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("هنگام باز کردن صفحه  افزودن ماموریت روزانه مشکلی به وجود آمد  ", Ex.Message);
            }
        }
    }
}
