using Common;
using Permission;
using Personnely;
using Salary.Classes;
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
    public partial class FrmEntryWork : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        //public bool ISForEdit { get; set; }
        int ID_MonthlyWork;
        DataTable Dt = new DataTable();
        public FrmEntryWork()
        {
            InitializeComponent();
        }
        public FrmEntryWork(int ID_MonthlyWork )
        {
            try
            {
                InitializeComponent();
                ClsMonthlyWork Mw = new ClsMonthlyWork();
               
                Dt = Mw.GetMonthlyWork(ID_MonthlyWork);
                if (Dt.Rows.Count == 0)
                {
                    this.Close();
                }
                else
                {
                    //this.ISForEdit = true;
                    this.ID_MonthlyWork = ID_MonthlyWork;
                    this.CmbYear.Enabled = false;
                    this.Cmb_Month.Enabled = false;
                    this.TxtCodePr.Enabled = false;
                    this.BtnBrows.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("مشکلی در بارگذاری اطلاعات بوجود آمد",ex.Message);
            }
        }
        void SetItems(DataTable Dt)
        {
            this.TxtCodePr.Text             = Dt.Rows[0]["ID_Person"].ToString();
            this.CmbYear.SelectedValue      = Dt.Rows[0]["Year"]	;
            this.Cmb_Month.SelectedValue     = Dt.Rows[0]["ID_MonthOfSalary"]	;
            this.TxtWork.Value              = (byte) Dt.Rows[0]["DayCount"]	;
            this.TxtDailyMission.Value      = (byte)Dt.Rows[0]["DailyMission"];
            this.UcHourlyMission.Txt        =  Dt.Rows[0]["HourlyMission_H"].ToString() +":"	+ Dt.Rows[0]["HourlyMission_M"]	.ToString();
            this.TxtdailyLeave.Value        = (byte)Dt.Rows[0]["DailyLeave"];
            this.UcHourlyLeave.Txt          = Dt.Rows[0]["HourlyLeave_H"].ToString() +":"	+ Dt.Rows[0]["HourlyLeave_M"]	.ToString(); 	
            this.UcAbsence.Txt              = Dt.Rows[0]["Absence_H"].ToString() +":"	+ Dt.Rows[0]["Absence_M"]	.ToString(); 
            this.UcOverTime.Txt             = Dt.Rows[0]["OverTime_H"].ToString() +":"	+ Dt.Rows[0]["OverTime_M"]	.ToString(); 
            this.UcOverTime1.Txt            = Dt.Rows[0]["OvertimeLastYear_H"].ToString() + ":" + Dt.Rows[0]["OvertimeLastYear_M"].ToString();
            this.UcNightWork.Txt            = Dt.Rows[0]["NightWork_H"].ToString() +":"	+ Dt.Rows[0]["NightWork_M"]	.ToString(); 
            this.UcHolidayWork.Txt          = Dt.Rows[0]["HolidayWork_H"].ToString() +":"	+ Dt.Rows[0]["HolidayWork_M"]	.ToString();
            this.TxtLoan.Text               = Dt.Rows[0]["Loan"].ToString();
            this.TxtAdvance.Text            = Dt.Rows[0]["Advance"].ToString();
            this.TxtBonus.Text              = Dt.Rows[0]["Bonus"].ToString();
            this.TxtBuy.Text                = Dt.Rows[0]["Buy"].ToString();
            this.TxtDiscount.Text           = Dt.Rows[0]["OtherDiscount"].ToString();
            this.TxtAddition.Text           = Dt.Rows[0]["OtherAddition"].ToString();
            this.TxtOverTimeRls.Text        = Dt.Rows[0]["OvertimeLastYearRlsPerHour"].ToString();
            this.CmbCompany.SelectedValue   = (byte)Dt.Rows[0]["ID_Company"];
        }
        private void FrmEntryWork_Load(object sender, EventArgs e)
        {
            FillCmb();
        }
        private void FillGrid()
        { 
            ClsPayroll Py = new ClsPayroll() ;
            this.Grd.DataSource = Py.GetAmel(this.ID_MonthlyWork);
            this.Grd.Columns["ID"].IsVisible = false;
            this.Grd.Columns["Coefficient"].IsVisible = false;
            this.Grd.Columns["Name"].HeaderText = "شرح";
            this.Grd.Columns["Name"].ReadOnly = true;
            this.Grd.Columns["Rls"].HeaderText = "مقدار";
            this.Grd.Columns["Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Rls"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Name"].Width = 230;
            this.Grd.Columns["Rls"].Width = 180;
            for (int i = 0; i < this.Grd.Rows.Count ; i++)
            {
                if ((short)this.Grd.Rows[i].Cells["Coefficient"].Value < 0 )
                {
                    this.Grd.Rows[i].Cells["Name"].Style.ForeColor = Color.Red;
                    this.Grd.Rows[i].Cells["Rls"].Style.ForeColor = Color.Red;   
                }
                else
                {
                    this.Grd.Rows[i].Cells["Name"].Style.ForeColor = Color.Blue;
                    this.Grd.Rows[i].Cells["Rls"].Style.ForeColor = Color.Blue;   
                }
            }
        }
        private void FillCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = short.Parse(Common.SalMali.Value);
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری اطلاعات  سال مالی و ماه ها با خطا مواجه شد", ex.Message);
            }
        }
        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString(); 
        }
        private void TxtCodePr_TextChanged(object sender, EventArgs e)
        {
            try
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
                    FillCmbVompany((long?)Person.ID);
                }
                else
                {
                    TxtNamePr.Text = null;
                }
                CamputeAdvanceAndLoan();
            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("متاسفانه خطایی در خواندن اطلاعات کارمند جاری بوجود آمد", ex.Message);
            }
        }

        private void FillCmbVompany(long? ID_Person )
        {
            try
            {
                if (ID_Person == null)
                {

                    this.CmbCompany.DataSource = null;
                }
                else
                {
                    ClsCompany cmp = new ClsCompany();
                    this.CmbCompany.ValueMember = "ID";
                    this.CmbCompany.DisplayMember = "Name";
                    this.CmbCompany.DataSource = cmp.GetAllPerPersonel((long)ID_Person);
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool IsValidData()
        {
            if (this.Person.Exists == false)
            {
                Global.Dialog.ShowInfo("لطفا یک کارمند معتبر انتخاب کنید");
                return false;
            }
            if (this.Cmb_Month.SelectedValue == null)
            {
                Global.Dialog.ShowInfo("لطفا یک سال مالی معتبر انتخاب کنید");
                return false;
            }
            if (this.TxtWork.Value < 15 )
            {
                if (Global.Dialog.ShowQuestion("کارکرد روزانه کمتر از 15 روز است. آیا مطئمن هستید مقادیر به درستی وارد شده است ؟") == false  )
                {
                    return false;
                }
            }
            if (this.TxtdailyLeave.Value > 10)
            {
                if (Global.Dialog.ShowQuestion("مرخصی روزانه بیشتر از 10 روز است . آیا مطمئن هستید که مقادیر به درستی وارد شده است ؟  ") == false)
                {
                    return false;
                }
            }
            if (this.TxtDailyMission.Value > 10)
            {
                if (Global.Dialog.ShowQuestion("ماموریت روزانه بیشتر از 10 روز است . آیا مطمئن هستید که مقادیر به درستی وارد شده است ؟  ") == false)
                {
                    return false;
                }
            }
            if ((short)this.UcOverTime1.ToMinute() >0  && this.TxtOverTimeRls.Rls <=0  )
            {
                Global.Dialog.ShowInfo("لطفا مبلغ هر ساعت اضافه کار را برای سال قبل وارد کنید");
                return false;
            }
            if (this.TxtOverTimeRls.Rls > 0 && (short)this.UcOverTime1.ToMinute() <= 0)
            {
                Global.Dialog.ShowInfo("لطفا  ساعت اضافه کار سال قبل وارد کنید و یا نرخ اضافه کار سال قبل را برابر 0 قرار دهید");
                return false;
            }
            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() == false )
                {
                    return; 
                }
                ClsMonthlyWork Mw = new ClsMonthlyWork() ;
                Mw.Person = this.Person;
                Mw.ID_Company = (byte)this.CmbCompany.SelectedValue;
                Mw.MonthOfSalary = new ClsMonthOfSalary((short)this.Cmb_Month.SelectedValue);
                Mw.DayCount = (byte)this.TxtWork.Value;
                Mw.DailyMission = (byte)this.TxtDailyMission.Value;
                Mw.DailyLeave = (byte)this.TxtdailyLeave.Value;
                Mw.HourlyMission = (short)UcHourlyMission.ToMinute();
                Mw.HourlyLeave = (short)this.UcHourlyLeave.ToMinute();
                Mw.Absence = (short)this.UcAbsence.ToMinute();
                Mw.OverTime = (short)this.UcOverTime.ToMinute();
                Mw.OvertimeLastYear = (short)this.UcOverTime1.ToMinute();
                Mw.OvertimeLastYearRlsPerHour = this.TxtOverTimeRls.Rls;
                Mw.NightWork = (short)this.UcNightWork.ToMinute();
                Mw.HolidayWork = (short)this.UcHolidayWork.ToMinute();
                Mw.Advance = (long)this.TxtAdvance.Rls;
                Mw.Loan = (long)this.TxtLoan.Rls;
                Mw.Bonus = (long)this.TxtBonus.Rls;
                Mw.Buy = (long)this.TxtBuy.Rls;
                Mw.OtherAddition = (long)this.TxtAddition.Rls;
                Mw.OtherDiscount = (long)this.TxtDiscount.Rls;
                Mw.Detail = this.Grd.ToDatatable("ID", "Rls");
                int RowAffect = 0;
                if  (this.ID_MonthlyWork == 0)
	            {
                    RowAffect = Mw.Save(Mw);
	            }
                else
                {
                    RowAffect = Mw.Update(Mw, ID_MonthlyWork);
                }
                if (RowAffect > 0 )
                {
                    Global.Dialog.ShowOK("عملیات با موفقیت انجام  شد");
                    if (this.ID_MonthlyWork != 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        ClearAllText();
                    }

                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی ثبت نشد");
                }
            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("خطایی در ثبت کارکرد بوجود آمده است", ex.Message);
            }
       
        }
        private void ClearAllText()
        {
            try
            {
                this.TxtCodePr.Text = null;
                this.TxtWork.Value = 0;
                this.TxtDailyMission.Value = 0;
                this.TxtdailyLeave.Value = 0;
                this.UcAbsence.Txt = "00:00";
                this.UcHourlyLeave.Txt = "00:00";
                this.UcHourlyMission.Txt = "00:00";
                this.UcOverTime.Txt = "00:00";
                this.UcNightWork.Txt = "00:00";
                this.UcHolidayWork.Txt = "00:00";
                this.UcOverTime1.Txt = "00:00";
                this.TxtBonus.Text = "";
                this.TxtAdvance .Text = "";
                this.TxtLoan.Text = "";
                this.TxtBuy.Text = "";
                this.TxtAddition.Text = "";
                this.TxtDiscount.Text = "";

                for (int i = 0; i < Grd.Rows.Count; i++)
                {
                    this.Grd.Rows[i].Cells["Rls"].Value = 0;
                }

               
            }
            catch (Exception ex)
            {
                
              Global.Dialog.ShowErorr("پاک کردن مقادیر با خطا مواجه شد", ex.Message);
            }
        }
        private void CmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClsMonthOfSalary M = new ClsMonthOfSalary();
                this.Cmb_Month.DataSource = null;
                this.Cmb_Month.ValueMember = "ID";
                this.Cmb_Month.DisplayMember = "MonthName";
                this.Cmb_Month.DataSource = M.GetAll((short)this.CmbYear.SelectedValue);
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات ماه های حقوقی با خطا مواجه شد", ex.Message);
            }

        }

        private void FrmEntryWork_Shown(object sender, EventArgs e)
        {

            if (this.ID_MonthlyWork != 0)
            {
                SetItems(Dt);
                FillGrid();
            }
            else
            {
                FillGrid();
            }
        }

        private void BtnGetAdvance_Click(object sender, EventArgs e)
        {
        }

        private void BtnGetLoan_Click(object sender, EventArgs e)
        {
        }
        private  void CamputeAdvanceAndLoan( )
        {
            try
            {
                if (this.Person.Exists == false)
                {
                    this.TxtLoan.Text = "";
                    this.TxtAdvance.Text = "";
                    return;
                }
                Salary.ClsLoan  loan = new ClsLoan();
                DataSet Ds = loan.GetLoanAndAdvanceFull(this.Person.ID,Convert.ToByte( this.Cmb_Month.SelectedValue));
                DataTable DtLoan = Ds.Tables[0];
                DataTable DtAdvance = Ds.Tables[1];
                //══════════════════════════════════════════════════════════════════
                if (DtLoan.Rows.Count == 0)
                {
                    this.TxtLoan.Text = "";
                }
                else
                {
                    long SumLoan = DtLoan.AsEnumerable().Sum(x => x.Field<long>("Amount"));
                    this.TxtLoan.Text = SumLoan.ToString();
                }
                //══════════════════════════════════════════════════════════════════
                if (DtAdvance.Rows.Count == 0)
                {
                    this.TxtAdvance.Text = "";
                }
                else
                {
                    long SumAdvance = DtAdvance.AsEnumerable().Sum(x => x.Field<long>("Amount"));
                    this.TxtAdvance.Text = SumAdvance.ToString();
                }

            }
            catch (Exception ex)
            {
                throw ex ;
            }

        }

        private void Cmb_Month_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                CamputeAdvanceAndLoan();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه خطایی در خواندن اطلاعات کارمند جاری بوجود آمد", ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }

}
