using Common;
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
using static Personnely.ClsPersonBase;

namespace Salary.Forms
{
    public partial class FrmManagePayroll : Permission.ClsMyForms
    {
        ClsPayroll Pay = new ClsPayroll();
        ClsPersonel Person = new ClsPersonel();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        Kargah Kargah = new Kargah();
        public FrmManagePayroll()
        {
            InitializeComponent();
        }

        private void FrmManagePayroll_Load(object sender, EventArgs e)
        {
            FillCmb();
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
                //══════════ 2 ══════════
                ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
                this.CmbMahalleKhedmat.DisplayMember = "Name";
                this.CmbMahalleKhedmat.ValueMember = "ID";
                this.CmbMahalleKhedmat.DataSource =  MK.GetAll();
                //══════════ 3 ══════════
                ClsGeneral.Company Cmp = new ClsGeneral.Company();
                this.CmbCompany.DisplayMember = "Name";
                this.CmbCompany.ValueMember = "ID";
                this.CmbCompany.DataSource = Cmp.GetAll();
                //══════════ 4 ══════════
                this.CmbKargah.DisplayMember = "Name";
                this.CmbKargah.ValueMember = "ID";
                //this.CmbKargah.DataSource = Kargah.GetAll()
                //══════════ 5 ══════════
                this.CmbKargahEx.DisplayMember = "Name";
                this.CmbKargahEx.ValueMember = "ID";
                //this.CmbKargahEx.DataSource = Kargah.GetAll();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری اطلاعات  سال مالی و ماه ها با خطا مواجه شد", ex.Message);
            }
        }

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                short Year = (short)this.CmbYear.SelectedValue;

                this.CmbMonthA.DataSource = null;
                this.CmbMonthA.ValueMember = "ID_Month";
                this.CmbMonthA.DisplayMember = "MonthName";
                this.CmbMonthA.DataSource = MY.GetAll(Year);
                this.CmbMonthA.SelectedIndex = 0;

                //this.CmbMonthB.DataSource = null;
                //this.CmbMonthB.ValueMember = "ID_Month";
                //this.CmbMonthB.DisplayMember = "MonthName";
                //this.CmbMonthB.DataSource = MY.GetAll(Year);
                //this.CmbMonthB.SelectedIndex = this.CmbMonthB.Items.Count - 1;
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات Combo Box با خطا مواجه شد", ex.Message);
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                 FillGrid();
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("خطایی در خواندن اطلاعات بوجود آمد", ex.Message);
            }
   
        }
        private void FillGrid()
        {
            try
            {
                long? ID_Pr = null;
                byte? ID_Company = (byte?)this.CmbCompany.SelectedValue;
                long? ID_Kargah = (long?)this.CmbKargah.SelectedValue;
                long? ID_KargahEx = (long?)this.CmbKargahEx.SelectedValue;
                if (ID_Kargah == 0 )
                {
                    ID_Kargah = null;
                }
                if (this.Person.Exists )
            {
                ID_Pr = Person.ID;
            }
                this.Grd.DataSource = Pay.GetAll((short)this.CmbYear.SelectedValue, ID_Pr, (byte)this.CmbMonthA.SelectedValue, (byte)this.CmbMonthA.SelectedValue , (short)this.CmbMahalleKhedmat.SelectedValue ,ID_Company, ID_Kargah , ID_KargahEx, this.ChkAdamPardakht.Checked ,ChkShowZero.Checked);
                this.Grd.Columns["ID"].HeaderText = "شماره فیش";
                this.Grd.Columns["Year"].HeaderText = "سال";
                this.Grd.Columns["MonthName"].HeaderText = "ماه";
                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["Name"].HeaderText = "نام";
                this.Grd.Columns["MonthlySalary_Rls"].HeaderText = "حقوق ماهانه";
                this.Grd.Columns["DailySalary_Rls"].HeaderText = "حقوق روزانه";
                this.Grd.Columns["OverTime_Rls"].HeaderText = "اضافه کاری";
                this.Grd.Columns["Delay_Rls"].HeaderText = "تاخیر و کسر کار";
                this.Grd.Columns["NightWork_Rls"].HeaderText = "شب کاری";
                this.Grd.Columns["HolidayWork_Rls"].HeaderText = "تعطیل کاری";
                this.Grd.Columns["MaskanRls"].HeaderText = "حق مسکن";
                this.Grd.Columns["Olad_Rls"].HeaderText = "حق اولاد";
                this.Grd.Columns["Bon_Rls"].HeaderText = "بن کارگری";
                this.Grd.Columns["Bonus"].HeaderText = "پاداش";
                this.Grd.Columns["Advance"].HeaderText = "مساعده";
                this.Grd.Columns["Loan"].HeaderText = "وام";
                this.Grd.Columns["DailyMission_Rls"].HeaderText = "حق ماموریت روزانه";
                this.Grd.Columns["HourlyMission_Rls"].HeaderText = "حق ماموریت ساعتی";
                this.Grd.Columns["TotalSalary"].HeaderText = "جمع حقوق و مزایا";
                this.Grd.Columns["TotalSalaryTaxable"].HeaderText = "جمع مزایای مشمول مالیات";
                this.Grd.Columns["TotalSalaryInsurable"].HeaderText = "جمع مزایای مشمول بیمه";
                this.Grd.Columns["Discount"].HeaderText = "کسورات";
                this.Grd.Columns["Tax"].HeaderText = "مالیات";
                this.Grd.Columns["Insurable"].HeaderText = "بیمه سهم کارگر";
                this.Grd.Columns["InsurableEmployer"].HeaderText = "بیمه سهم کار فرما";
                this.Grd.Columns["Buy"].HeaderText = "خرید پرسنلی";
                this.Grd.Columns["OtherAddition"].HeaderText = "سایر اضافات";
                this.Grd.Columns["OtherDiscount"].HeaderText = "سایر کسور";
                this.Grd.Columns["AccontNo3"].HeaderText = "حساب سپه";
                this.Grd.Columns["AccontNo1"].HeaderText = "حساب ملت";
                this.Grd.Columns["NetSalary"].HeaderText = "خالص دریافتی";


                this.Grd.Columns["ID_Payroll"].IsVisible = false;

                this.Grd.Columns["ID"].Width = 66;
                this.Grd.Columns["Year"].Width = 33;
                this.Grd.Columns["MonthName"].Width = 65;
                this.Grd.Columns["ID_Person"].Width = 62;
                this.Grd.Columns["Name"].Width = 104;
                this.Grd.Columns["MonthlySalary_Rls"].Width = 78;
                this.Grd.Columns["DailySalary_Rls"].Width = 65;
                this.Grd.Columns["OverTime_Rls"].Width = 60;
                this.Grd.Columns["Delay_Rls"].Width = 81;
                this.Grd.Columns["NightWork_Rls"].Width = 69;
                this.Grd.Columns["HolidayWork_Rls"].Width = 63;
                this.Grd.Columns["MaskanRls"].Width = 62;
                this.Grd.Columns["Olad_Rls"].Width = 67;
                this.Grd.Columns["Bon_Rls"].Width = 74;
                this.Grd.Columns["Bonus"].Width = 75;
                this.Grd.Columns["Advance"].Width = 79;
                this.Grd.Columns["Loan"].Width = 80;
                this.Grd.Columns["DailyMission_Rls"].Width = 96;
                this.Grd.Columns["HourlyMission_Rls"].Width = 107;
                this.Grd.Columns["TotalSalary"].Width = 92;
                this.Grd.Columns["TotalSalaryTaxable"].Width = 135;
                this.Grd.Columns["TotalSalaryInsurable"].Width = 127;
                this.Grd.Columns["ID_Payroll"].Width = 103;
                this.Grd.Columns["TotalSalaryInsurable"].Width = 127;
                this.Grd.Columns["Discount"].Width = 97;
                this.Grd.Columns["Tax"].Width = 83;
                this.Grd.Columns["Insurable"].Width = 99;
                this.Grd.Columns["InsurableEmployer"].Width = 135;
                this.Grd.Columns["Buy"].Width = 110;
                this.Grd.Columns["OtherAddition"].Width = 110;
                this.Grd.Columns["OtherDiscount"].Width = 110;

                this.Grd.Columns["MonthlySalary_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["DailySalary_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["OverTime_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Delay_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["NightWork_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["HolidayWork_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["MaskanRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Olad_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Bon_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Bonus"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Advance"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Loan"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["DailyMission_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["HourlyMission_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["TotalSalary"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["TotalSalaryTaxable"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["TotalSalaryInsurable"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Discount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Tax"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Insurable"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["InsurableEmployer"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Buy"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["OtherAddition"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["OtherDiscount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["NetSalary"].FormatString = "{0:#,###,##0;(#,###,0)}";

                this.Grd.Columns["MonthlySalary_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["DailySalary_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["OverTime_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Delay_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["NightWork_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["HolidayWork_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["MaskanRls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Olad_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Bon_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Bonus"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Advance"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Loan"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["DailyMission_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["HourlyMission_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["TotalSalary"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["TotalSalaryTaxable"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["TotalSalaryInsurable"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Discount"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Tax"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Insurable"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["InsurableEmployer"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["Buy"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["OtherAddition"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["OtherDiscount"].TextAlignment = ContentAlignment.MiddleLeft;

                Global.Tools.Grd_SetPivotHeaderText(this.Grd, "Pr.AvmeleHokmi", "Name", "{0:#,###,##0;(#,###,0)}", ContentAlignment.MiddleRight ,150);

                SetColor();


            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void SetColor()
        {
            for (int i = 0; i < this.Grd.Rows.Count; i++)
            {
                bool IsBlack = this.Grd.Rows[i].Cells["IsBlack"].Value.ToString() == "1";
                if (IsBlack)
                {
                    this.Grd.Rows[i].Cells["IsBlack"].Style.ForeColor = Color.Red;
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (this.Grd.SelectedRows.Count == 0 )
	            {
	                Global.Dialog.ShowInfo ("هیچ  فیش حقوقی ای انتخاب نشده است")	  ;
                    return ;
	            }
            else if (this.Grd.SelectedRows.Count == 1)
            {
                String MSg = string.Format("آیا برای حذف فیش حقوقی '{0}' ماه '{1}' اطمینان دارید ?", this.Grd.CurrentRow.Cells["Name"].Value.ToString(), this.Grd.CurrentRow.Cells["MonthName"].Value.ToString());
                if (Global.Dialog.ShowQuestion(MSg) == false)
                {
                    return;
                }

                int RowAffect = Pay.Delete((int)this.Grd.CurrentRow.Cells["ID"].Value);
                if (RowAffect == 0)
                {
                    Global.Dialog.ShowInfo("متاسفانه عملیات انجام نشد");
                }
                else
                {
                    MSg = string.Format(" فیش حقوقی با موفقیت حذف شد");
                    Global.Dialog.ShowOK(MSg);
                    BtnSave_Click(null, null);
                }
            }
            else if (this.Grd.SelectedRows.Count > 1)
            {
                string Msg = null;
                 Msg = $"آیا برای حذف {this.Grd.SelectedRows.Count} مورد فیش حقوقی مطمئن هستید ؟";
                if (Global.Dialog.ShowQuestion(Msg) == false)
                {
                    return;
                }
                int RowAffect = 0;
                foreach (var item in this.Grd.SelectedRows)
                {
                    RowAffect += Pay.Delete((int)item.Cells["ID"].Value);
                }
                if (RowAffect == 0)
                {
                    Global.Dialog.ShowInfo("متاسفانه عملیات انجام نشد");
                }
                else
                {
                    Msg = string.Format(" فیش حقوقی با موفقیت حذف شد");
                    Global.Dialog.ShowOK(Msg);
                    BtnSave_Click(null, null);
                }
            }
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.SelectedRows.Count == 0)
                {
                    Global.Dialog.ShowInfo("لطفا یکی از موارد را انتخاب کنید");
                    return;
                }


                DataTable DtID = new DataTable();
                DtID = GetDtID();
                DataSet DsPayroll = Pay.Get(DtID);
                if (DsPayroll.Tables[3].Rows.Count == 0 )
                {
                    Global.Dialog.ShowInfo("هیچ جزئیات حقوقی برای این فیش وجود ندارد");
                    return;
                }
                //string StringSalary = DsPayroll.Tables[0].Rows[0]["NetSalary"].ToString();
                //StringSalary = Global.Tools.NumberToString(StringSalary);
                Common.StiReport Rep = new Common.StiReport();
                //Rep.AddVariable("StringSalary", StringSalary, "مبلغ به حروف");
                Rep.AddDatasource(DsPayroll.Tables[0],"InC");
                Rep.AddDatasource(DsPayroll.Tables[1], "DeC");
                Rep.AddDatasource(DsPayroll.Tables[2], "Master");
                Rep.AddDatasource(DsPayroll.Tables[3], "Detail");
                Rep.Show();

            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("مشکلی در روند اجرای گزارش بجود آمده است", ex.Message);
            }
        }
        private DataTable GetDtID()
        {
            int ID = 0;
            DataRow Dr ;
            DataTable ReturnDt = new DataTable() ;
            ReturnDt.Columns.Add("Value",typeof(int) );
            for (int i = 0; i < this.Grd.SelectedRows.Count; i++)
            {
                ID = (int)this.Grd.SelectedRows[i].Cells["ID"].Value; 
                Dr = ReturnDt.NewRow() ;
                Dr[0] = ID ;
                ReturnDt.Rows.Add(Dr);
            }
            return ReturnDt;
        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.CmbKargahEx.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
        }

        private void BtnDisket_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClsAccontNO> LstAccNo = new List<ClsAccontNO>();
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if (this.Grd.Rows[i].Cells["AccontNo1"].Value != DBNull.Value)
                    {
                        LstAccNo.Add(new ClsAccontNO
                        {
                            ID_Person = (long)this.Grd.Rows[i].Cells["ID_Person"].Value,
                            AccontNo = this.Grd.Rows[i].Cells["AccontNo1"].Value.ToString(),
                            Balance = (long?)this.Grd.Rows[i].Cells["NetSalary"].Value,
                            Bank = ClsAccontNO.EnumBank.Mellat
                        });
                    }
                }
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if (this.Grd.Rows[i].Cells["AccontNo3"].Value != DBNull.Value)
                    {
                        LstAccNo.Add(new ClsAccontNO
                        {
                            ID_Person = (long)this.Grd.Rows[i].Cells["ID_Person"].Value,
                            AccontNo = this.Grd.Rows[i].Cells["AccontNo3"].Value.ToString(),
                            Balance = (long?)this.Grd.Rows[i].Cells["NetSalary"].Value,
                            Bank = ClsAccontNO.EnumBank.Sepah
                        });
                    }
                }
                FrmDisketBank frmDisketBank = new FrmDisketBank(LstAccNo);
                frmDisketBank.ShowDialog();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("ساخت دیسکت با خطا مواجه شد", ex.Message);
            }
        
        }
    }
}
