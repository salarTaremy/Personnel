using Permission;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Salary.Forms
{
    public partial class FrmEditLoan : ClsMyForms
    {
        int _ID_Loan ;
        DataTable DtLoan;
        DataTable DtLoanDetail;
        ClsLoan Loan = new ClsLoan();
        public FrmEditLoan(int ID_Loan) 
        {
            InitializeComponent();
            this._ID_Loan = ID_Loan;
        }

        private void FrmEditLoan_Load(object sender, EventArgs e)
        {
            try
            {
                FillCmb();
                Fill();
                FillGrd();
                CamputeCleared();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("بارگذاری فرم با خطا مواجه شد", Ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                this.DtLoanDetail = this.Loan.GetLoanDetail(this._ID_Loan);
                this.Grd.DataSource = DtLoanDetail;
                this.Grd.Columns["Description"].HeaderText = "شرح";
                this.Grd.Columns["Priority"].HeaderText = "اولویت";
                this.Grd.Columns["Amount"].HeaderText = "مبلغ قسط";
                this.Grd.Columns["ID_Payroll"].HeaderText = "شماره فیش حقوقی";
                this.Grd.Columns["ManualCheckOut"].HeaderText = "تسویه دستی";
                this.Grd.Columns["IsCleared"].HeaderText = "تسویه شده";
                this.Grd.Columns["MonthToCleared"].HeaderText = "ماه تسویه";

                this.Grd.Columns["Description"].Width = 184;
                this.Grd.Columns["Priority"].Width = 46;
                this.Grd.Columns["Amount"].Width = 103;
                this.Grd.Columns["ID_Payroll"].Width = 105;
                this.Grd.Columns["ManualCheckOut"].Width = 82;
                this.Grd.Columns["IsCleared"].Width = 89;

                this.Grd.Columns["ID_LoanDetail"].IsVisible = false;
                this.Grd.Columns["Amount"].FormatString = "{0:#,###,##0;(#,###,0)}";
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        private void FillCmb()
        {
            this.CmbLoanTypes.ValueMember = "ID";
            this.CmbLoanTypes.DisplayMember = "Name";
            this.CmbLoanTypes.DataSource = Loan.GetAllTypes();
        }
        private void Fill()
        {
            try
            {
                this.DtLoan = this.Loan.GetAllLoan(this._ID_Loan);
                this.TxtPersonName.Text = DtLoan.Rows[0]["FullName"].ToString();
                this.TxtPersonCode.Text = DtLoan.Rows[0]["ID_Person"].ToString();
                this.TxtMabVam.Text = DtLoan.Rows[0]["TotalAmount"].ToString();
                this.TxtCount.Text = DtLoan.Rows[0]["TotalCount"].ToString();
                this.Txtzemanat.Text = DtLoan.Rows[0]["Warranty"].ToString();
                this.TxtDetail.Text = DtLoan.Rows[0]["Detail"].ToString();
                this.ChkActive.Checked = Convert.ToBoolean(DtLoan.Rows[0]["IsActive"].ToString());
                this.CmbLoanTypes.SelectedValue = DtLoan.Rows[0]["TypeID"];
                this.UcDate.txt = DtLoan.Rows[0]["BorrowingDate"].ToString();
                this.TxtStart.Text = DtLoan.Rows[0]["StartDate"].ToString();       
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow == null )
                {
                    return;
                }
                if (this.Grd.CurrentRow.Cells["IsCleared"].Value != System.DBNull.Value &&  Convert.ToBoolean( this.Grd.CurrentRow.Cells["IsCleared"].Value) == true )
                {
                    Global.Dialog.ShowInfo("این ردیف قابل ویرایش و یا حذف نمیباشد");
                    return;
                }
                this.Grd.CurrentRow.Delete();
                CamputePriority();
                CamputeCleared();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnAddNewRow_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddLoanItem Frm = new FrmAddLoanItem();
                Frm.ShowDialog();
                if (Frm.DialogResult != DialogResult.OK )
                {
                    return;
                }
                this.Grd.Rows.AddNew();
                this.Grd.Rows[this.Grd.Rows.Count - 1].Cells["Amount"].Value = Frm.Amount;
                CamputePriority();
                CamputeCleared();

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در افزودن قسط جدید", ex.Message);
            }
        }
        private void BtnEditRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow is null )
                {
                    return;
                }
                if (this.Grd.CurrentRow.Cells["IsCleared"].Value != System.DBNull.Value &&  Convert.ToBoolean(this.Grd.CurrentRow.Cells["IsCleared"].Value) == true)
                {
                    Global.Dialog.ShowInfo("این ردیف قابل ویرایش و یا حذف نمیباشد");
                    return;
                }
                string Amount = this.Grd.CurrentRow.Cells["Amount"].Value.ToString().Trim();
                FrmAddLoanItem Frm = new FrmAddLoanItem( Amount);
                Frm.ShowDialog();
                if (Frm.DialogResult != DialogResult.OK)
                {
                    return;
                }
                this.Grd.CurrentRow.Cells["Amount"].Value = Frm.Amount;
                CamputeCleared();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در ویرایش ردیف", ex.Message);
            }
        }
        private void CamputePriority()
        {
            for (int i = 0; i < Grd.Rows.Count; i++)
            {
                Name = "قسط " + Global.Tools.NumberToString((i+1).ToString());
                this.Grd.Rows[i].Cells["Description"].Value = Name;
                this.Grd.Rows[i].Cells["Priority"].Value = i + 1;
            }
        }
        private void CamputeCleared()
        {
            long Cleared = 0;
            long Mandeh = 0;
            for (int i = 0; i < Grd.Rows.Count; i++)
            {
                if (this.Grd.Rows[i].Cells["IsCleared"].Value != System.DBNull.Value && Convert.ToBoolean(this.Grd.Rows[i].Cells["IsCleared"].Value) == true)
                {
                    Cleared += Convert.ToInt64( this.Grd.Rows[i].Cells["Amount"].Value);
                }
                else
                {
                    Mandeh += Convert.ToInt64(this.Grd.Rows[i].Cells["Amount"].Value);
                }
            }
            if (Cleared+Mandeh == this.TxtMabVam.Rls )
            {
                this.TxtSumMandeh.ForeColor = Color.Black;
            }
            else
            {
                this.TxtSumMandeh.ForeColor = Color.Red;
            }

            this.TxtSumCleared.Text = Cleared.ToString();
            this.TxtSumMandeh.Text = Mandeh.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (! IsValid())
                {
                    return;
                }

                ClsLoan loan = new ClsLoan();
                Loan.ID = this._ID_Loan;
                Loan.ID_Type = (byte)this.CmbLoanTypes.SelectedValue;
                Loan.BorrowingDate = this.UcDate.TxtInt;
                Loan.TotalAmount = this.TxtMabVam.Rls;
                Loan.IsActive = this.ChkActive.Checked;
                Loan.Warranty = this.Txtzemanat.Text;
                Loan.Detail = this.TxtDetail.Text;
                DataTable DtItems = GetDtItems();
                if (Loan.Update(Loan, DtItems))
                {
                    Global.Dialog.ShowOK("وام مورد نظر شما با موفقیت اصلاح شد");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else{
                    Global.Dialog.ShowInfo("متاسفانه اطلاعات بدرستی ذخیره نشدند");
                }


            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در ذخیره اطلاعات", ex.Message);
            }
        }

        private bool IsValid()
        {
            try
            {
                if (this.TxtMabVam.Rls != (TxtSumCleared.Rls + TxtSumMandeh.Rls)  )
                {
                    Common.ClsParametrs Param = new Common.ClsParametrs();
                    //string AllowEditTotalAmount = Param.GetValue(10);
                    bool AllowEditTotalAmount = Param.GetValue(10) == "1";
                    if (AllowEditTotalAmount)
                    {
                        bool Confirm = Global.Dialog.ShowQuestion("مبلغ اقساط با اصل مبلغ وام مغایرت دارد.آیا تمایل به تغییر دادن اصل مبلغ وام میباشید ؟؟");
                        if (!Confirm)
                        {
                            return false;
                        }
                           
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("مبلغ اقساط با اصل مبلغ وام مغایرت  دارد.در صورت نیاز به تغییر اصل مبلغ وام با مدیر سیستم هماهنگ  کنید");
                        return false;
                    }

                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private DataTable GetDtItems()
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt.Columns.Add("ID", typeof(long));
                Dt.Columns.Add("PRIORITY", typeof(short));
                Dt.Columns.Add("Amount", typeof(long));
                DataRow dr;

                foreach (var item in Grd.Rows)
                {
                    dr = Dt.NewRow();
                    dr["ID"] = item.Cells["ID_LoanDetail"].Value;
                    dr["PRIORITY"] = item.Cells["Priority"].Value;
                    dr["Amount"] = item.Cells["Amount"].Value;
                    Dt.Rows.Add(dr);
                }
                return Dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
