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
    public partial class FrmLoanDetail : Permission.ClsMyForms
    {
        ClsLoan Loan = new ClsLoan();
        DataTable DtLoan;
        int ID_Loan;
        int TdToltal, TdPardakhti, TdMandeh;
        long RlsToltal, RlsPardakhti, RlsMandeh;

        private Boolean IsValidData()
        {
            if (this.Grd.CurrentRow is null)
            {

                Global.Dialog.ShowInfo("لطفا یک مورد را انتخاب کنید");
                return false;
            }
            if (this.Grd.CurrentRow.Cells["ID_Payroll"].Value != DBNull.Value)
            {
                Global.Dialog.ShowInfo("شما برای ثبت و یا عدم ثبت تسویه بصورت دستی،باید مواردی را انتخاب کنید که قبلا در فیش حقوقی  لحاظ نشده باشند.این مورد قبلا در فیش حقوقی  اعمال شده است و حتما باید ابتدا نسبت به حذف فیش حقوقی اقدام نمایید");
                return false;
            }
            return true;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() == false)
                {
                    return;
                }
                short Priority = (short)this.Grd.CurrentRow.Cells["Priority"].Value;
                if (Loan.CheckOut(this.ID_Loan,Priority))
                {
                    Global.Dialog.ShowOK("قسط مورد نظر شما با موفقیت تسویه شد");
                    FillGrd();
                    SetVariable();
                    SetColor();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه قسط  مورد نظر شما  تسویه نشد");
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnUnClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() == false)
                {
                    return;
                }
                short Priority = (short)this.Grd.CurrentRow.Cells["Priority"].Value;
                if (Loan.CheckOut(this.ID_Loan, Priority , false))
                {
                    Global.Dialog.ShowOK("قسط مورد نظر شما با موفقیت به حساب بدهکاری منتقل شد ");
                    FillGrd();
                    SetVariable();
                    SetColor();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه قسط  مورد نظر شما با  برگشت از  تسویه نشد ");
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmLoanDetail(int ID_Loan)
        {
            InitializeComponent();
            this.ID_Loan = ID_Loan;
        }

        private void FrmLoanDetail_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
                SetVariable();
                SetColor();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("بار کذاری فرم مشاهده جزئیات وام با خطا مواجه شد", Ex.Message);
            }
        }

        private void SetColor()
        {
            try
            {
                foreach (var item in this.Grd.Rows)
                {
                    if ((bool)item.Cells["IsCleared"].Value )
                    {
                        SetRowColor(item.Index, Color.Green);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        private void SetRowColor(int Index, Color Color)
        {
            try
            {
                for (int i = 0; i < this.Grd.Columns.Count; i++)
                {
                    this.Grd.Rows[Index].Cells[i].Style.ForeColor = Color;
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void SetVariable()
        {
            try
            {
                this.TdToltal =         this.DtLoan.AsEnumerable().Count();
                this.TdPardakhti =      this.DtLoan.AsEnumerable().Where(x => (Boolean)x["IsCleared"] == true).Count();
                this.TdMandeh  =        this.DtLoan.AsEnumerable().Where(x => (Boolean)x["IsCleared"] == false).Count();

                this.RlsToltal =        this.DtLoan.AsEnumerable().Sum(x => x.Field<long>("Amount"));
                this.RlsPardakhti =     this.DtLoan.AsEnumerable().Where(r => (Boolean)r["IsCleared"] == true).Sum(x => x.Field<long>("Amount"));
                this.RlsMandeh =        this.DtLoan.AsEnumerable().Where(r => (Boolean)r["IsCleared"] == false).Sum(x => x.Field<long>("Amount"));

                this.TxtTotal.Text =   this.TdToltal.ToString();
                this.Txtpardakhti.Text = this.TdPardakhti.ToString();
                this.TxtMandeh.Text = this.TdMandeh.ToString();

                this.TxtTotalRls.Text =  this.RlsToltal.ToString();
                this.TxtpardakhtiRls.Text = this.RlsPardakhti.ToString();
                this.TxtMandehRls.Text = this.RlsMandeh.ToString();


            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void FillGrd()
        {
            try
            {
                   this.DtLoan = this.Loan.GetLoanDetail(this.ID_Loan);
                this.Grd.DataSource = DtLoan;
                this.Grd.Columns["Description"].HeaderText = "شرح";
                this.Grd.Columns["Priority"].HeaderText = "اولویت";
                this.Grd.Columns["Amount"].HeaderText = "مبلغ قسط";
                this.Grd.Columns["MonthToCleared"].HeaderText = "ماه کسر شده";
                this.Grd.Columns["ID_Payroll"].HeaderText = "شماره فیش حقوقی";
                this.Grd.Columns["ManualCheckOut"].HeaderText = "تسویه دستی";
                this.Grd.Columns["IsCleared"].HeaderText = "پرداخت شده";

                this.Grd.Columns["Description"].Width = 184;
                this.Grd.Columns["Priority"].Width = 46;
                this.Grd.Columns["Amount"].Width = 103;
                this.Grd.Columns["ID_Payroll"].Width = 105;
                this.Grd.Columns["ManualCheckOut"].Width = 82;
                this.Grd.Columns["IsCleared"].Width = 89;

                this.Grd.Columns["Amount"].FormatString = "{0:#,###,##0;(#,###,0)}";
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
    }
}
