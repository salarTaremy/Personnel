using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Permission;
using Personnely;
using Salary.Classes;

namespace Salary.Forms
{
    public partial class FrmNewLoan : ClsMyForms
    {
        Boolean Flag1= true;
        Boolean Flag2 = true;
        ClsPersonel Person = new ClsPersonel();
        ClsLoan Loan = new ClsLoan();
        Common.ClsClander Cl = new Common.ClsClander();
        public FrmNewLoan()
        {
            InitializeComponent();
        }

        private void FrmNewLoan_Load(object sender, EventArgs e)
        {
            this.UcDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
            FillCmb();
        }
        private void FillCmb()
        {
            this.CmbMonth.ValueMember = "ID";
            this.CmbMonth.DisplayMember = "Pr_Name";
            this.CmbMonth.DataSource = Cl.GetMonthNames();
            this.CmbLoanTypes.ValueMember = "ID";
            this.CmbLoanTypes.DisplayMember = "Name";
            this.CmbLoanTypes.DataSource = Loan.GetAllTypes();
        }
        private void TxtTedad_ValueChanged(object sender, EventArgs e)
        {
            if (Flag2 ==true && ChkAutoCalc.Checked)
            {
                Flag1 = false;
                long Val = long.Parse(TxtTotalRls.Text.Replace(",", "").Trim());
                long Val2 = (long)TxtTedad.Value;
                if (Val2>0)
                {
                    Val = Val / Val2;
                }
                else
                {
                    Val = 0;
                }
                TxtGhest.Text = Val.ToString();
                Flag1 = true;
            }
        }
        private void TxtGhest_TextChanged(object sender, EventArgs e)
        {
            if (Flag1 == true && ChkAutoCalc.Checked)
            {
                Flag2 = false;
                long Val = long.Parse(TxtTotalRls.Text.Replace(",", "").Trim());
                long Val2 = long.Parse(TxtGhest.Text.Trim().Replace(",", "").Trim());
                if (Val2>0)
                {
                    Val = Val / Val2;
                }
                else
                {
                    Val = 0;
                }
                TxtTedad.Value = Val;
                Flag2 = true;
            }
        }
        private void TxtTotalRls_TextChanged(object sender, EventArgs e)
        {
            Flag1 = Flag2 = false;
            TxtGhest.Value = 0;
            TxtTedad.Value = 0;
            Flag1 = Flag2 = true;
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() == false)
                {
                    return;
                }

                Calculate();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خطا در محاسبات", Ex.Message);
            }
        }
        private bool IsValidData()
        {
            if (this.TxtTedad.Value <= 0 )
            {
                Global.Dialog.ShowInfo("تعداد اقساط باید بزرگتر از 0 باشد");
                return false;
            }
            if ( this.TxtGhest.Rls <=0 )
            {
                Global.Dialog.ShowInfo("لطفا مبلغ معتبری برای هر  قسط وارد کنید");
                return false;
            }
            return true;
        }
        private DataTable GetDtItems()
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt.Columns.Add("R", typeof(int));
                Dt.Columns.Add("Name", typeof(string));
                Dt.Columns.Add("Rls", typeof(long));
                return Dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Calculate()
        {
            try
            {
                DataTable Dt = GetDtItems();
                DataRow Dr;
                string Name = null;
                long tedad = (long)this.TxtTedad.Value;
                for (int i = 1; i <= tedad; i++)
                {
                    Dr = Dt.NewRow();
                    Name = "قسط " + Global.Tools.NumberToString(i.ToString());
                    Dr["R"] = i;
                    Dr["Name"] = Name;
                    Dr["Rls"] = TxtGhest.Rls;
                    Dt.Rows.Add(Dr);
                }
                long total = Dt.AsEnumerable().Sum(x => x.Field<long>("Rls"));
                long rest = this.TxtTotalRls.Rls - total;
                if (rest > 0  &&  this.ChkAutoCalc.Checked)
                {
                    Dr = Dt.NewRow();
                    int Max = Dt.AsEnumerable().Max(x => x.Field<int>("R"));
                    Max += 1;
                    Name = "قسط " + Global.Tools.NumberToString(Max.ToString());
                    Dr["R"] = Max;
                    Dr["Name"] = Name;
                    Dr["Rls"] = rest;
                    Dt.Rows.Add(Dr);
                }
                
                this.Grd.DataSource = Dt;
                FormatGrid();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void FormatGrid()
        {
            try
            {
                this.Grd.Columns["R"].ReadOnly = true;
                this.Grd.Columns["Name"].ReadOnly = true;
                this.Grd.Columns["Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";

                this.Grd.Columns["R"].HeaderText = "ردیف";
                this.Grd.Columns["Name"].HeaderText = "شرح";
                this.Grd.Columns["Rls"].HeaderText = "مبلغ";

                this.Grd.Columns["R"].Width = 100;
                this.Grd.Columns["Name"].Width = 250;
                this.Grd.Columns["Rls"].Width = 200;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData() == false)
                {
                    return;
                }

                ClsLoan Loan = new ClsLoan();
                foreach (var item in this.Grd.Rows)
                {
                    Loan.items.Add(new LoanItems { Amount = (long)item.Cells["Rls"].Value, Priority = Convert.ToInt16(item.Cells["R"].Value) });
                }
                Loan.BorrowingDate = this.UcDate.TxtInt;
                Loan.Detail = this.TxtDetail.Text;
                Loan.ID_Person = this.Person.ID;
                Loan.ID_Type = (byte)this.CmbLoanTypes.SelectedValue;
                Loan.IsActive = this.ChkActive.Checked;
                Loan.StartMonth = (byte)this.CmbMonth.SelectedValue;
                Loan.StartYear = (short)this.TxtYear.Value;
                Loan.TotalAmount = this.TxtTotalRls.Rls;
                Loan.Warranty = this.Txtzemanat.Text;
                int RowAffect = Loan.Save(Loan);
                if (Convert.ToBoolean(RowAffect))
                {
                    Global.Dialog.ShowOK($"وام مورد نظر شما با موفقیت ذخیره شد");
                    this.Close();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه اطلاعات ذخیره نشد");
                }
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خطایی در هنگام ذخیره اطلاعات بوجود آمد", Ex.Message);
                throw Ex ;
            }
        }
        private bool isValidData()
        {
            long Sum = 0;
            foreach (var item in this.Grd.Rows)
            {
                Sum += (long)item.Cells["Rls"].Value;
            }
            if (Sum != this.TxtTotalRls.Rls)
            {
                Global.Dialog.ShowInfo($"مجموع مبلغ اقساط  ({Sum})  ریال میباشد و با مبلغ کلی وام برابر نیست. لطفا مبالغ را اصلاح کنید");
                return false;
            }
            if (this.Person.Exists == false)
            {
                Global.Dialog.ShowInfo("لطفا کارمند معتبری را انتخاب کنید");
                return false; 
            }

            return true;
        }
        private void BtnAddNewRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.Rows.Count == 0 || this.Grd.DataSource == null )
                {
                    this.Grd.DataSource = this.GetDtItems();
                    FormatGrid();
                }
                this.Grd.Rows.AddNew();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("اجرای برنامه با خطا مواجه شد", Ex.Message);
            }
        }
        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.Rows.Count <=  0 )
                {
                    return; 
                }
                if (this.Grd.CurrentRow == null  )
                {
                    return;
                }
                this.Grd.CurrentRow.Delete();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("اجرای برنامه با خطا مواجه شد", Ex.Message);
            }
        }
    }
}

