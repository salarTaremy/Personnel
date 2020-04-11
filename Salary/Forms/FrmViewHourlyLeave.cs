using Personnely;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserControls;
namespace Salary.Forms
{
    public partial class FrmViewHourlyLeave : Permission.ClsMyForms
    {
        ClsLeave Le = new ClsLeave();
        ClsPersonel Person = new ClsPersonel();
        ClsDialog Dialog = new ClsDialog();
        public FrmViewHourlyLeave()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
        private void FillGrid()
        {
            try
            {
                this.Grd.DataSource = Le.GetAllLeave  (Person, this.UcDatePicker1.TxtInt, this.UcDatePicker2.TxtInt);
                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["DayName"].HeaderText = "روز";
                this.Grd.Columns["Date"].HeaderText = "تاریخ";
                this.Grd.Columns["ID_Personel"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["fullName"].HeaderText = "نام";
                this.Grd.Columns["FromTime"].HeaderText = "از ساعت";
                this.Grd.Columns["ToTime"].HeaderText = "تا ساعت";
                this.Grd.Columns["Type"].HeaderText = "نوع مرخصی";
                this.Grd.Columns["IsConfirm"].HeaderText = "تایید شده";
                this.Grd.Columns["IsHoliday"].HeaderText = "تعطیل";
                this.Grd.Columns["ID"].Width = 255;
                this.Grd.Columns["DayName"].Width = 66;
                this.Grd.Columns["Date"].Width = 72;
                this.Grd.Columns["ID_Personel"].Width = 62;
                this.Grd.Columns["fullName"].Width = 255;
                this.Grd.Columns["FromTime"].Width = 60;
                this.Grd.Columns["ToTime"].Width = 60;
                this.Grd.Columns["Type"].Width = 163;
                this.Grd.Columns["IsConfirm"].Width = 64;
                this.Grd.Columns["IsHoliday"].Width = 130;
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("بارگذاری اطلاعات با خطا مواجه شد", ex.Message);
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

        private void FrmViewLeave_Load(object sender, EventArgs e)
        {
            this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfYear);
            this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grd.SelectedRows.Count == 0)
                {
                    Dialog.ShowInfo("لطفا یک مورد جهت ویرایش انتخاب کنبد");
                    return;
                }
                FrmHourlyLeave Frm = new FrmHourlyLeave((long)this.Grd.CurrentRow.Cells["ID"].Value);
                Frm.ShowDialog();
                FillGrid();
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("متاسفانه مشکلی در روند ویرایش بوجود آمد", ex.Message);
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
                else if (this.Grd.SelectedRows.Count > 1)
                {
                    Dialog.ShowInfo("عملیات حذف مرخصی ها فقط بصورت تک ایتمی امکان پذیر میباشد" + Environment.NewLine + "لطفا فقط یک گزینه را انتخاب نمایید");
                    return;
                }
                long ID = (long)this.Grd.CurrentRow.Cells["ID"].Value;
                string Msg = string.Format("آیا برای حذف مرخصی مورخه{0} مربوط به {1} مطمئن هستید ؟" + Environment.NewLine + "از ساعت '{2}' تا '{3}'", (string)this.Grd.CurrentRow.Cells["Date"].Value, (string)this.Grd.CurrentRow.Cells["fullName"].Value, this.Grd.CurrentRow.Cells["FromTime"].Value.ToString(), this.Grd.CurrentRow.Cells["ToTime"].Value.ToString());
                if (Dialog.ShowQuestion(Msg) == false)
                {
                    return;
                }
                if (Le.Delete(ID) > 0 )
                {
                    Dialog.ShowOK("حذف مرخصی با موفقیت انجام شد");
                    FillGrid();
                }
                else
                {
                    Dialog.ShowOK("متاسفانه رکوردی حذف نشد");
                }

            }
            catch (Exception Ex )
            {
                Dialog.ShowErorr("متاسفانه عملیات حذف با خطا مواجه شد" , Ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmHourlyLeave Frm = new FrmHourlyLeave();
            Frm.ShowDialog();
            FillGrid();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = Le.SetConfirm(true, Grd.GetSelectedItems("ID"));
                if (RowAffect > 0)
                {
                    Dialog.ShowOK(string.Format("تعداد  {0} ردیف با موفقیت تایید شد", RowAffect));
                    FillGrid();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه هیچ موردی تایید نشد");
                }
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("متاسفانه عملیات تایید با خطا مواجه شد");
            }
        }

        private void BtnDeConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = Le.SetConfirm(false, Grd.GetSelectedItems("ID"));
                if (RowAffect > 0)
                {
                    Dialog.ShowOK(string.Format("تعداد  {0} ردیف با موفقیت از حالت تایید خارج  شد", RowAffect));
                    FillGrid();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه هیچ موردی برگشت از تایید نشد");
                }
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("متاسفانه عملیات عدم تایید با خطا مواجه شد");
            }
        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
