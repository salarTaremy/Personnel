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
using System.IO;

namespace Salary.Forms
{
    public partial class FrmInsuranceList : Permission.ClsMyForms
    {
        Personnely.ClsPersonBase.Kargah Kargah = new Personnely.ClsPersonBase.Kargah();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        ClsInsurance Insurance;
        short IDMonthOfSalary;
        byte IDCompany;
        long IDKargah;
        long IDKargahEx;
        short IDMahalKHedmat;
        public FrmInsuranceList()
        {
            InitializeComponent();
        }

        private void FrmInsuranceList_Load(object sender, EventArgs e)
        {
            FillAllCmb();
        }
        private void FillAllCmb()
        {
            Common.SalMali SalMali = new Common.SalMali();
            this.CmbYear.ValueMember = "ID";
            this.CmbYear.DisplayMember = "Name";
            this.CmbYear.DataSource = SalMali.GetSalMali();
            this.CmbYear.SelectedValue = Global.SalMali;
            //══════════ 2 ══════════
            ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
            this.CmbMahalleKhedmat.DisplayMember = "Name";
            this.CmbMahalleKhedmat.ValueMember = "ID";
            this.CmbMahalleKhedmat.DataSource = MK.GetAll();
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

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            short Year = (short)this.CmbYear.SelectedValue;

            this.CmbMonthA.DataSource = null;
            this.CmbMonthA.ValueMember = "ID";
            this.CmbMonthA.DisplayMember = "MonthName";
            this.CmbMonthA.DataSource = MY.GetAll(Year);
            this.CmbMonthA.SelectedIndex = 0;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid() == false)
                {
                    return;
                }
                this.IDMonthOfSalary = short.Parse(this.CmbMonthA.SelectedValue.ToString());
                this.IDCompany = (byte)this.CmbCompany.SelectedValue;
                this.IDKargah = long.Parse(this.CmbKargah.SelectedValue.ToString());
                this.IDKargahEx = long.Parse(this.CmbKargahEx.SelectedValue.ToString());
                this.IDMahalKHedmat = (short)this.CmbMahalleKhedmat.SelectedValue;
                if (IDMahalKHedmat == 0)
                {
                    Insurance = new ClsInsurance(IDCompany, IDKargah, IDMonthOfSalary,IDKargahEx);
                }
                else
                {
                    Insurance = new ClsInsurance(IDCompany, IDKargah, IDMahalKHedmat, IDMonthOfSalary, IDKargahEx);
                }

                FillGrd(Insurance);
            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("مشکلی در محاسبه لیست بیمه بوجودآمده است", ex.Message);
            }
        }
        private bool IsValid()
        {
            //if (this.CmbKargah.SelectedIndex == 0)
            //{
            //    Global.Dialog.ShowInfo("لطفا کارگاه را انتخاب کنید.برای لیست بیمه  انتخاب کارگاه الزامی است");
            //    return false;
            //}
            return true;
        }
        private void FillGrd(ClsInsurance Insurance)
        {
      
            if (Insurance == null)
            {
                return;
            }
            this.Grd.DataSource = Insurance.List;
            this.Grd.Columns["BimeNo"].HeaderText = "شماره بیمه";
            this.Grd.Columns["Name"].HeaderText = "نام و نام خانوادگی";
            this.Grd.Columns["JobName"].HeaderText = "شغل";
            this.Grd.Columns["SSN"].HeaderText = "کد ملی";
            this.Grd.Columns["Sh_Sh"].HeaderText = "شماره شناسنامه";
            this.Grd.Columns["NamePedar"].HeaderText = "نام پدر";
            this.Grd.Columns["ShoroKar"].HeaderText = "شروع کار";
            this.Grd.Columns["TarkKar"].HeaderText = "ترک کار";
            this.Grd.Columns["DayCount"].HeaderText = "کارکرد";
            this.Grd.Columns["DastmozdRoz"].HeaderText = "دستمزد روزانه";
            this.Grd.Columns["DastmozdMah"].HeaderText = "دستمزد ماهانه";
            this.Grd.Columns["Mazaya"].HeaderText = "مزایای ماهانه";
            this.Grd.Columns["Mashmool"].HeaderText = "دستمزد و مزایا مشمول";
            this.Grd.Columns["MashmoolVaGheir"].HeaderText = "مشمول و غیر مشمول";
            this.Grd.Columns["EmpolyeeInsure"].HeaderText = "حق بیمه سهم بیمه شده";
            this.Grd.Columns["EmployerInsure"].HeaderText = "حق بیمه سهم کارفرما";
            this.Grd.Columns["NetSalary"].HeaderText = "خالص";
            this.Grd.Columns["IsMale"].HeaderText = "مرد";
            this.Grd.Columns["IsFemale"].HeaderText = "زن";
            this.Grd.Columns["Taxable"].HeaderText = "مبلغ مشمول مالیات";
            this.Grd.Columns["MaskanRls"].HeaderText = "حق مسکن";
            this.Grd.Columns["Olad_Rls"].HeaderText = "حق اولاد";
            this.Grd.Columns["Bon_Rls"].HeaderText = "بن";
            this.Grd.Columns["Advance"].HeaderText = "مساعده";
            this.Grd.Columns["Tax"].HeaderText = "مالیات";
            this.Grd.Columns["Discount"].HeaderText = "کسورات";
            this.Grd.Columns["Buy"].HeaderText = "خرید پرسنلی";
            this.Grd.Columns["Continuous"].HeaderText = "مزایای مشمول";
            this.Grd.Columns["NonContinuous"].HeaderText = "مزایای غیر مشمول";
            this.Grd.Columns["TotalTaxable"].HeaderText = "مبلغ مشمول مالیات";
            this.Grd.Columns["ZakhirePoursent"].HeaderText = "ذخیره پورسانت";

            this.Grd.Columns["IsMale"].IsVisible = false;
            this.Grd.Columns["IsFemale"].IsVisible = false;
            this.Grd.Columns["Taxable"].IsVisible = false;
            this.Grd.Columns["sos"].IsVisible = false;

            this.Grd.Columns["BimeNo"].Width = 100;
            this.Grd.Columns["Name"].Width = 174;
            this.Grd.Columns["IsMale"].Width = 63;
            this.Grd.Columns["IsFemale"].Width = 75;
            this.Grd.Columns["JobName"].Width = 93;
            this.Grd.Columns["SSN"].Width = 98;
            this.Grd.Columns["Sh_Sh"].Width = 102;
            this.Grd.Columns["NamePedar"].Width = 122;
            this.Grd.Columns["ShoroKar"].Width = 90;
            this.Grd.Columns["TarkKar"].Width = 89;
            this.Grd.Columns["DayCount"].Width = 45;
            this.Grd.Columns["DastmozdRoz"].Width = 84;
            this.Grd.Columns["DastmozdMah"].Width = 86;
            this.Grd.Columns["Mazaya"].Width = 82;
            this.Grd.Columns["Mashmool"].Width = 130;
            this.Grd.Columns["MashmoolVaGheir"].Width = 122;
            this.Grd.Columns["EmpolyeeInsure"].Width = 132;
            this.Grd.Columns["EmployerInsure"].Width = 122;
            this.Grd.Columns["Taxable"].Width = 65;
            this.Grd.Columns["NetSalary"].Width = 93;
            this.Grd.Columns["Tax"].Width = 75;
            this.Grd.Columns["Olad_Rls"].Width = 82;
            this.Grd.Columns["MaskanRls"].Width = 74;
            this.Grd.Columns["Bon_Rls"].Width = 78;
            this.Grd.Columns["Advance"].Width = 78;
            this.Grd.Columns["Buy"].Width = 82;
            this.Grd.Columns["Discount"].Width = 69;
            this.Grd.Columns["Continuous"].Width = 130;
            this.Grd.Columns["NonContinuous"].Width = 130;
            this.Grd.Columns["TotalTaxable"].Width = 130;

            this.Grd.Columns["DastmozdRoz"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["DastmozdMah"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Mazaya"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Mashmool"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["MashmoolVaGheir"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["EmpolyeeInsure"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["EmployerInsure"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["NetSalary"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["MaskanRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Olad_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Bon_Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Advance"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Tax"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Discount"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Buy"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["Continuous"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["NonContinuous"].FormatString = "{0:#,###,##0;(#,###,0)}";
            this.Grd.Columns["TotalTaxable"].FormatString = "{0:#,###,##0;(#,###,0)}";

            this.Grd.Columns["DastmozdRoz"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["DastmozdMah"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Mazaya"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Mashmool"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["MashmoolVaGheir"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["EmpolyeeInsure"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["EmployerInsure"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["NetSalary"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["MaskanRls"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Olad_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Bon_Rls"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Advance"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Tax"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Discount"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Buy"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["Continuous"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["NonContinuous"].TextAlignment = ContentAlignment.MiddleLeft;
            this.Grd.Columns["TotalTaxable"].TextAlignment = ContentAlignment.MiddleLeft;

        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                Personnely.ClsPersonBase.Kargah Kargah = new Personnely.ClsPersonBase.Kargah(long.Parse(this.CmbKargah.SelectedValue.ToString()));
                Common.StiReport Rep = new Common.StiReport();
                Rep.AddDatasource( (DataTable) this.Grd.DataSource);
                Common.ClsDateTime DateTime = new Common.ClsDateTime();
                Rep.AddVariable("Year", this.CmbYear.SelectedValue);
                Rep.AddVariable("Month", this.CmbMonthA.Text);
                Rep.AddVariable("Name", Kargah.Name);
                Rep.AddVariable("CodeKargah", Kargah.CodeKargah);
                Rep.AddVariable("CompanyName", Kargah.CompanyName);
                Rep.AddVariable("RadifPeyman", Kargah.RadifPeyman);
                Rep.AddVariable("Detail", Kargah.Detail);

                Rep.Show();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("عملیات گزارش گیری با خطا مواجه شد", ex.Message);
            }
        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.CmbKargahEx.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            var Obj = Insurance.List;
            ClsTax.CsvGenerator cv = new ClsTax.CsvGenerator();
            var PersonelCsv = "";
            var SalarySummaryCsv = "";
            var SalaryDetail = "";

            for (int i = 0; i < Grd.Rows.Count; i++)
            {
                PersonelCsv += cv.Personel(
                    nationality:(ClsTax.Nationality) Grd.Rows[i].Cells["Melliat"].Value,//inf.Melliat
                    isNewRecord: true,
                    nationalCode: Grd.Rows[i].Cells["SSN"].Value.ToString(),
                    name: Grd.Rows[i].Cells["fname"].Value.ToString(), //fnamr
                    Family: Grd.Rows[i].Cells["lname"].Value.ToString(),  //lname
                    EdDegree:(ClsTax.EducationalDegree) Grd.Rows[i].Cells["MadrakTahsili"].Value,  //inf.MadrakTahsili
                    position: Grd.Rows[i].Cells["JobName"].Value.ToString(),  //[JobName]
                    InsurType: (ClsTax.InssuranceType) Grd.Rows[i].Cells["IdInsuranceType"].Value, //  IdInsuranceType  تامین اجتماعی
                    dateOfEnrol: (int) Grd.Rows[i].Cells["DateEstekhdam"].Value,    //[DateEstekhdam] 
                    empType:(ClsTax.EmploymentType) Grd.Rows[i].Cells["IdEstekhdam"].Value,    //IdEstekhdam
                    placeOfContract: Grd.Rows[i].Cells["VahedKhedmat"].Value.ToString(),    //VahedKhedmat
                    workpStatus: ClsTax.WorkPlaceStatus.Normal,//constant
                    typeOfContract: (ClsTax.TypeOfContract)  Grd.Rows[i].Cells["IdContractType"].Value,  //IdContractType
                    empStatus: (ClsTax.EmployeeStatus)  Grd.Rows[i].Cells["IdStatus"].Value//[IdStatus]
                                                                                                      //,country:
                    , empCode:   Grd.Rows[i].Cells["ID_Person"].Value.ToString()  //[ID_Person]
                    //,insurName:
                    //,insurNumber:
                    //,homeZipCode: 
                    //,homeAddress:
                    //,dateOfEndContract: 
                    //,cellphone:
                    //,emailAddress:
                    );



                SalaryDetail += cv.SalaryDetail(
                    nationalCode: Grd.Rows[i].Cells["SSN"].Value.ToString(),
                    typeOfPayment: ClsTax.TypeOfPayment.BankTransfer, // az mohandes ??
                    WorkMonthsThisYear: (int) Grd.Rows[i].Cells["CountOfMonthlyWorkPerCurrentYear"].Value,   //[CountOfMonthlyWorkPerCurrentYear]  //نیاز به اصلاح دارد
                    dateOfWorkStart: (int)Grd.Rows[i].Cells["DateEstekhdam"].Value,    //[DateEstekhdam]
                    empStatus: (ClsTax.EmployeeStatus) Grd.Rows[i].Cells["IdStatus"].Value, //[IdStatus]
                    workPlaceStatus: ClsTax.WorkPlaceStatus.Normal,   // constant
                    Tax: 32,
                    totalTax: 2
                    //,isLastMonth:
                    //,dateOfWorkEnd:
                    //,netSalary: 
                    //,paymentWithoutTax:
                    //,housingType:
                    //,houseRentCost:
                    //,vehicleType: 
                    //,vehicleRentCost:
                    //,nonCashBenefits:
                    //,healthCareCost:
                    //,inssuranceCost:
                    //,hosusingLoan:
                    //,otherExceptions:
                    //,extraHoursPayments:
                    //,otherPayments:
                    //,bounus: 
                    //,delayedPayment: 
                    //,nonRecurringDeductions:
                    //,nonRecurringBonus:
                    //,newYearReward:
                    //,leaveRedemption:
                    //,deductionException:
                    //,freeZoneDeduction:
                    //,overTaxingDeduction:
                    );
            }


            SalarySummaryCsv = cv.SalarySummary(
                dateOfRegistrationInJournal: 13900101
                //,year: 129 
                //,month: 1 
                //,currentMonthDebt: 3 
                //,lastMonthDebt:
                //,typeOfPayment: 
                //,checkSerialNumber:
                //,checkDueDate:
                //,bankName:
                //,bankBranchName:
                //,bankAccountNumber:
                //,checkAmount:
                //,treasuryPaymentDate:
                //,treasuryPaymentAmount:
                );
            FolderBrowserDialog dlgFolderBrowser = new FolderBrowserDialog();
            if (dlgFolderBrowser.ShowDialog(this) == DialogResult.OK)
            {
                MessageBox.Show("saves in " + dlgFolderBrowser.SelectedPath);
                var FilePersonelPath = Path.Combine(dlgFolderBrowser.SelectedPath, "WP.TXT");
                var FileSalarySummaryPath = Path.Combine(dlgFolderBrowser.SelectedPath, string.Format("WH{0}.TXT", "139801"));
                var FileSalaryDetailPath = Path.Combine(dlgFolderBrowser.SelectedPath, string.Format("WK{0}.TXT", "139801"));

                if (File.Exists(FilePersonelPath) || File.Exists(FileSalarySummaryPath) || File.Exists(FileSalarySummaryPath))
                {
                    MessageBox.Show("در دایرکتوری انتخاب شده فایلهای مالیات وجود دارد ، لطفاً یک دایرکتوری دیگر انتخاب کنید");
                    return;
                }

                File.WriteAllText(FilePersonelPath, PersonelCsv);
                File.WriteAllText(FileSalarySummaryPath, SalarySummaryCsv);
                File.WriteAllText(FileSalaryDetailPath, SalaryDetail);

            }

        }

    }
}
