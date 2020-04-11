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
    public partial class FrmManageLoan : Permission.ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        ClsLoan Loan = new ClsLoan();
        public FrmManageLoan()
        {
            InitializeComponent();
        }

        private void FrmManageLoan_Load(object sender, EventArgs e)
        {

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("خواندن اطلاعات از پایگاه داده با خطا مواجه شد", Ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                if (this.Person.Exists)
                {
                    this.Grd.DataSource = this.Loan.GetAllLoan( this.Person.ID);
                }
                else
                {
                    this.Grd.DataSource = this.Loan.GetAllLoan();
                }
                SetHeaderText();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void SetHeaderText()
        {
            try
            {
                this.Grd.Columns["ID"].HeaderText = "شماره وام";
                this.Grd.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["TypeName"].HeaderText = "نوع وام";
                this.Grd.Columns["BorrowingDate"].HeaderText = "تاریخ دریافت";
                this.Grd.Columns["StartDate"].HeaderText = "شروع اقساط";
                this.Grd.Columns["TotalAmount"].HeaderText = "مبلغ وام";
                this.Grd.Columns["IsActive"].HeaderText = "فعال";
                this.Grd.Columns["Warranty"].HeaderText = "اوراق ضمانت";
                this.Grd.Columns["Detail"].HeaderText = "توضیحات";
                this.Grd.Columns["TotalCount"].HeaderText = "تعداد اقساط";

                this.Grd.Columns["ID"].Width = 60;
                this.Grd.Columns["FullName"].Width = 163;
                this.Grd.Columns["ID_Person"].Width = 68;
                this.Grd.Columns["TypeName"].Width = 86;
                this.Grd.Columns["BorrowingDate"].Width = 78;
                this.Grd.Columns["StartDate"].Width = 76;
                this.Grd.Columns["TotalAmount"].Width = 93;
                this.Grd.Columns["TotalCount"].Width = 76;
                this.Grd.Columns["IsActive"].Width = 44;
                this.Grd.Columns["Warranty"].Width = 153;
                this.Grd.Columns["Detail"].Width = 120;

                this.Grd.Columns["TypeID"].IsVisible = false;

                this.Grd.Columns["TotalAmount"].FormatString = "{0:#,###,##0;(#,###,0)}";
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmNewLoan FrmLoan = new FrmNewLoan();
                FrmLoan.ShowDialog();
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("مشکی درسیستم بوجود آمد", Ex.Message);
            }

        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData() == false )
                {
                    return;
                }
                int ID_Loan = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                FrmLoanDetail loanDetail = new FrmLoanDetail(ID_Loan);
                loanDetail.ShowDialog();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("نمایش جزئیات وام با خطا مواجه شد", Ex.Message);
            }

        }

        private bool ValidData()
        {
            try
            {
                if (this.Grd.Rows.Count == 0)
                {
                    Global.Dialog.ShowInfo("لیست وام ها خالی است . از گزینه جستجو جهت نمایش لیست وام ها استفاده کنید");
                    return false;
                }
                if (this.Grd.CurrentRow is null || this.Grd.CurrentRow.Cells["ID"].Value is null)
                {
                    Global.Dialog.ShowInfo("لطفا یکی از وام ها را  انتخاب کنید");
                    return false;
                }

                return true; 
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("مشکی در گزارش گیری بوجود آمد", Ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData() == false)
                {
                    return;
                }
                int ID_Loan = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                if (this.Loan.DeleteLoan(ID_Loan))
                {
                    Global.Dialog.ShowOK(" وام مورد نظر با موفقیت حذف شد");
                    FillGrd();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه وام مورد نظر حذف نشد");
                }
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("مشکی در گزارش گیری بوجود آمد", Ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData() == false)
                {
                    return;
                }
                int ID_Loan = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                FrmEditLoan Frm = new FrmEditLoan(ID_Loan);
                Frm.ShowDialog();
                if (Frm.DialogResult == DialogResult.OK)
                {
                    FillGrd();
                }
            }
            catch (Exception Ex)
            {

                Global.Dialog.ShowErorr("عملیلت با خطا مواجه شد", Ex.Message);
            }
        }
    }
}
