using Personnely;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using Telerik.WinControls.UI;
using System.Threading.Tasks;
using Salary.Classes;

namespace Salary.Forms
{
    public partial class FrmMonthlyList : Permission.ClsMyForms
    {
        Personnely.ClsPersonBase.Kargah Kargah = new Personnely.ClsPersonBase.Kargah();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        public FrmMonthlyList()
        {
            InitializeComponent();
        }
        private void FrmMonthlyList_Load(object sender, EventArgs e)
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

            ClsGeneral.Company company = new ClsGeneral.Company();
            this.CmbCompany.ValueMember = "ID";
            this.CmbCompany.DisplayMember = "Name";
            this.CmbCompany.DataSource = company.GetAll();

            this.CmbKargah.DisplayMember = "Name";
            this.CmbKargah.ValueMember = "ID";
            //this.CmbKargah.DataSource = Kargah.GetAll()

            //══════════ 2 ══════════
            ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
            this.CmbMahalleKhedmat.DisplayMember = "Name";
            this.CmbMahalleKhedmat.ValueMember = "ID";
            this.CmbMahalleKhedmat.DataSource = MK.GetAll();
            //══════════ 4 ══════════
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
            DataTable DtYear = MY.GetAll(Year);
            this.CmbMonthA.DataSource = DtYear;
            //Common.ClsInformation inf = new Common.ClsInformation();
            //byte CurrentMonth =  byte.Parse(inf.PersianMonth.ToString());
            //short SelectedValue = short.Parse(DtYear.AsEnumerable().Where(c => c.Field<byte>("ID_Month") == CurrentMonth).FirstOrDefault()["id"].ToString());
            //this.CmbMonthA.SelectedValue = SelectedValue;




        }
        private void FillGrd()
        {
            ClsPayroll Py = new ClsPayroll();
            long ID_Kargah = long.Parse(this.CmbKargah.SelectedValue.ToString().Trim());
            long ID_KargahEx = long.Parse(this.CmbKargahEx.SelectedValue.ToString().Trim());
            short ID_MonthOfSalary = short.Parse(this.CmbMonthA.SelectedValue.ToString().Trim());
            short ID_MahaleKhedamt = (short)this.CmbMahalleKhedmat.SelectedValue;
            byte ID_Company = byte.Parse(this.CmbCompany.SelectedValue.ToString().Trim());
            DataTable DtResource;
            bool Flag = this.ChkAdamPardakht.Checked;

            if (ID_MahaleKhedamt !=0)
            {
                if (ID_Kargah == 0 )
                {
                    DtResource = Py.GetMonthlyList( ID_MonthOfSalary, ID_MahaleKhedamt, ID_Company, Flag);
                }
                else
                {
                    DtResource = Py.GetMonthlyList(ID_Kargah, ID_MonthOfSalary, ID_MahaleKhedamt, ID_Company, Flag);
                }

            }
            else
            {
                if (ID_Kargah == 0)
                {
                    DtResource = Py.GetMonthlyList( ID_MonthOfSalary, ID_Company, Flag);
                }
                else
                {
                    DtResource = Py.GetMonthlyList(ID_Kargah, ID_MonthOfSalary, ID_Company, Flag);
                }
            }

            var result = DtResource.AsEnumerable().Where(c => c.Field<long>("ID_Kargah") != ID_KargahEx);

            DataTable tblClone = DtResource.Clone();
            foreach (DataRow dr in result)
                tblClone.ImportRow(dr);



            this.Grd.DataSource = tblClone;

            foreach (var Col in this.Grd.Columns)
            {
                Col.Width = 100;
                if  (Col.Name  == "ID_Person" | Col.Name == "ID_Hokm"  | Col.Name == "Counter" )
                {
                    continue;
                }
                Col.FormatString =   "{0:#,###,##0;(#,###,0)}";
                Col.TextAlignment = ContentAlignment.MiddleLeft;
            }

            this.Grd.Columns["Counter"].IsVisible = false;
            this.Grd.Columns["CreateDate"].IsVisible = false;
            this.Grd.Columns["HOST_NAME"].IsVisible = false;
            this.Grd.Columns["APP_NAME"].IsVisible = false;
            this.Grd.Columns["ID"].IsVisible = false;
            this.Grd.Columns["ID_WorkPerMonth"].IsVisible = false;
            this.Grd.Columns["ID_MonthOfSalary"].IsVisible = false;
            this.Grd.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
            this.Grd.Columns["Kargah"].HeaderText = "کارگاه";
            this.Grd.Columns["MahalKhedmat"].HeaderText = "محل خدمت";
            this.Grd.Columns["OldAccountingCode"].HeaderText = "کد قدیم";
            this.Grd.Columns["Counter"].HeaderText = "Counter";
            this.Grd.Columns["CreateDate"].HeaderText = "CreateDate";
            this.Grd.Columns["HOST_NAME"].HeaderText = "HOST_NAME";
            this.Grd.Columns["APP_NAME"].HeaderText = "APP_NAME";
            this.Grd.Columns["ID"].HeaderText = "ID";
            this.Grd.Columns["ID_WorkPerMonth"].HeaderText = "ID_WorkPerMonth";
            this.Grd.Columns["ID_MonthOfSalary"].HeaderText = "ID_MonthOfSalary";
            this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
            this.Grd.Columns["ID_Hokm"].HeaderText = "شماره حکم";
            this.Grd.Columns["DayCount"].HeaderText = "کارکرد";
            this.Grd.Columns["MonthlySalary_Rls"].HeaderText = "پایه حقوق ماهانه";
            this.Grd.Columns["DailySalary_Rls"].HeaderText = "پایه حقوق روزانه";
            this.Grd.Columns["OverTime_Rls"].HeaderText = "مبلغ اضافه کار";
            this.Grd.Columns["Delay_Rls"].HeaderText = " مبلغ تاخیر";
            this.Grd.Columns["NightWork_Rls"].HeaderText = "مبلغ شب کاری";
            this.Grd.Columns["HolidayWork_Rls"].HeaderText = "مبلغ تعطیل کاری";
            this.Grd.Columns["OverTime_Min"].HeaderText = "اضافه کار(دقیقه)";
            this.Grd.Columns["Delay_Min"].HeaderText = "تاخیر(دقیقه)";
            this.Grd.Columns["NightWork_Min"].HeaderText = "شبکاری(دقیقه)";
            this.Grd.Columns["HolidayWork_Min"].HeaderText = "تعطیل کاری(دقیقه)";
            this.Grd.Columns["MaskanRls"].HeaderText = "حق مسکن";
            this.Grd.Columns["Olad_Rls"].HeaderText = "حق اولاد";
            this.Grd.Columns["Bon_Rls"].HeaderText = "بن کارگری";
            this.Grd.Columns["Bonus"].HeaderText = "پاداش";
            this.Grd.Columns["Advance"].HeaderText = "مساعده";
            this.Grd.Columns["Loan"].HeaderText = "وام";
            this.Grd.Columns["OtherAddition"].HeaderText = "سایر اضافات";
            this.Grd.Columns["OtherDiscount"].HeaderText = "سایر کسورات";
            this.Grd.Columns["DailyMission_Day"].HeaderText = "ماموریت روزانه";
            this.Grd.Columns["HourlyMission_Min"].HeaderText = "ماموریت ساعتی(دقیقه)";
            this.Grd.Columns["DailyMission_Rls"].HeaderText = "مبلغ ماموریت روزانه";
            this.Grd.Columns["HourlyMission_Rls"].HeaderText = "مبلغ ماموریت ساعتی";
            this.Grd.Columns["TotalSalary"].HeaderText = "جمع کل حقوق مزایا";
            this.Grd.Columns["TotalSalaryInsurable"].HeaderText = "جمع حقوق مزایا مشمول بیمه";
            this.Grd.Columns["TotalSalaryTaxable"].HeaderText = "جمع حقوق مزایا مشمول مالیات";
            this.Grd.Columns["TotalTaxable"].HeaderText = "ماموریت(ساعت)";
            this.Grd.Columns["InsurableEmployer"].HeaderText = "حق بیمه سهم کارفرما";
            this.Grd.Columns["Insurable"].HeaderText = "حق بیمه سهم بیمه شده";
            this.Grd.Columns["Tax"].HeaderText = "مالیات";
            this.Grd.Columns["Continuous"].HeaderText = "مستمر";
            this.Grd.Columns["NonContinuous"].HeaderText = "غیر مستمر";
            this.Grd.Columns["Discount"].HeaderText = "کسورات";
            this.Grd.Columns["NetSalary"].HeaderText = "خالص پرداختی";
            this.Grd.Columns["Buy"].HeaderText = "خرید پرسنلی";
            this.Grd.Columns["Rounding"].HeaderText = "روند ماه قبل";
            this.Grd.Columns["OverTime_Hour"].HeaderText = "اضافه کار(ساعت)";
            this.Grd.Columns["Delay_Hour"].HeaderText = "تاخیر(ساعت)";
            this.Grd.Columns["NightWork_Hour"].HeaderText = "شبکاری(ساعت)";
            this.Grd.Columns["HolidayWork_Hour"].HeaderText = "نعطیل کاری(ساعت)";
            this.Grd.Columns["HourlyMission_Hour"].HeaderText = "ماموریت(ساعت)";
            this.Grd.Columns["PayeSanavat"].HeaderText = "پایه سنوات";
            this.Grd.Columns["Eydi"].HeaderText = "ذخیره عیدی";
            this.Grd.Columns["Sanavat"].HeaderText = "ذخیره سنوات";
            this.Grd.Columns["ID_Payroll"].HeaderText = "شماره فیش حقوقی";
            this.Grd.Columns["AccNo1"].HeaderText = "شماره ملت";
            this.Grd.Columns["AccNo3"].HeaderText = "شماره سپه";
            this.Grd.Columns["BlackListDescryption"].HeaderText = "توضیحات";


            


            this.Grd.Columns["ID_Kargah"].IsVisible = false;
            //this.Grd.Columns["AccNo1"].IsVisible = false;
            //this.Grd.Columns["AccNo3"].IsVisible = false;

            this.Grd.Columns["FullName"].Width = 200;
            this.Grd.Columns["Kargah"].Width = 100;
            this.Grd.Columns["MahalKhedmat"].Width = 152;
            this.Grd.Columns["Counter"].Width = 100;
            this.Grd.Columns["CreateDate"].Width = 100;
            this.Grd.Columns["HOST_NAME"].Width = 100;
            this.Grd.Columns["APP_NAME"].Width = 100;
            this.Grd.Columns["ID"].Width = 100;
            this.Grd.Columns["ID_WorkPerMonth"].Width = 100;
            this.Grd.Columns["ID_MonthOfSalary"].Width = 100;
            this.Grd.Columns["ID_Person"].Width = 77;
            this.Grd.Columns["ID_Hokm"].Width = 74;
            this.Grd.Columns["DayCount"].Width = 54;
            this.Grd.Columns["MonthlySalary_Rls"].Width = 100;
            this.Grd.Columns["DailySalary_Rls"].Width = 100;
            this.Grd.Columns["OverTime_Rls"].Width = 94;
            this.Grd.Columns["Delay_Rls"].Width = 100;
            this.Grd.Columns["NightWork_Rls"].Width = 100;
            this.Grd.Columns["HolidayWork_Rls"].Width = 100;
            this.Grd.Columns["OverTime_Min"].Width = 100;
            this.Grd.Columns["Delay_Min"].Width = 100;
            this.Grd.Columns["NightWork_Min"].Width = 100;
            this.Grd.Columns["HolidayWork_Min"].Width = 100;
            this.Grd.Columns["MaskanRls"].Width = 100;
            this.Grd.Columns["Olad_Rls"].Width = 100;
            this.Grd.Columns["Bon_Rls"].Width = 100;
            this.Grd.Columns["Bonus"].Width = 100;
            this.Grd.Columns["Advance"].Width = 100;
            this.Grd.Columns["Loan"].Width = 100;
            this.Grd.Columns["OtherAddition"].Width = 100;
            this.Grd.Columns["OtherDiscount"].Width = 100;
            this.Grd.Columns["DailyMission_Day"].Width = 100;
            this.Grd.Columns["HourlyMission_Min"].Width = 137;
            this.Grd.Columns["DailyMission_Rls"].Width = 100;
            this.Grd.Columns["HourlyMission_Rls"].Width = 127;
            this.Grd.Columns["TotalSalary"].Width = 100;
            this.Grd.Columns["TotalSalaryInsurable"].Width = 159;
            this.Grd.Columns["TotalSalaryTaxable"].Width = 170;
            this.Grd.Columns["TotalTaxable"].Width = 100;
            this.Grd.Columns["InsurableEmployer"].Width = 129;
            this.Grd.Columns["Insurable"].Width = 140;
            this.Grd.Columns["Tax"].Width = 100;
            this.Grd.Columns["Continuous"].Width = 100;
            this.Grd.Columns["NonContinuous"].Width = 100;
            this.Grd.Columns["Discount"].Width = 100;
            this.Grd.Columns["NetSalary"].Width = 100;
            this.Grd.Columns["Buy"].Width = 100;
            this.Grd.Columns["Rounding"].Width = 100;
            this.Grd.Columns["OverTime_Hour"].Width = 100;
            this.Grd.Columns["Delay_Hour"].Width = 100;
            this.Grd.Columns["NightWork_Hour"].Width = 100;
            this.Grd.Columns["HolidayWork_Hour"].Width = 139;
            this.Grd.Columns["HourlyMission_Hour"].Width = 100;
            this.Grd.Columns["PayeSanavat"].Width = 100;
            this.Grd.Columns["ID_Payroll"].Width = 145;
            this.Grd.Columns["AccNo1"].Width = 100;
            this.Grd.Columns["AccNo3"].Width = 100;
            this.Grd.Columns["BlackListDescryption"].Width = 130;

        }


        private Task SetColorForAccCode()
        {
            try
            {
                return Task.Run(() =>
                {
                    int Cnt = 0;
                    string str = null;
                    for (int i = 0; i < this.Grd.Rows.Count; i++)
                    {
                        if (this.Grd.Rows[i].Cells["AccNo3"].Value == System.DBNull.Value && this.Grd.Rows[i].Cells["AccNo1"].Value == System.DBNull.Value)
                        {
                            Cnt += 1;
                            str +=   this.Grd.Rows[i].Cells["FullName"].Value +" با کد پرسنلی: "+ this.Grd.Rows[i].Cells["ID_Person"].Value  + Environment.NewLine;
                            this.Grd.SetRowBackColor(i, Color.Red);
                            this.Grd.SetRowForeColor(i, Color.Yellow);
                        }
                    }
                    if (Cnt>0)
                    {
                        Global.Dialog.ShowInfo (  $"{Cnt} نفر از کارمندان موجود در لیست فاقد شماره حساب میباشند.لطفا قبل از  گرفتن هر نوع گزارش نسبت به اصلاح مشخصات این کارمندان اقدام فرمایید." + Environment.NewLine + "این افراد در لیست با رنگ قرمز نشان داده شده اند." + System.Environment.NewLine + System.Environment.NewLine + str);
                    }
                }
                );
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private  async void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
                await SetColorForAccCode();
                await SetColorForZeroPrice();
            }
            catch (Exception ex)
            {
                   Global.Dialog.ShowErorr("متاسفانه نمایش لیست جاری با مشکل مواجه شد", ex.Message);
            }

        }

        private Task SetColorForZeroPrice()
        {
            try
            {
                return Task.Run(() =>
                {
                    int Cnt = 0;
                    string str = null;
                    for (int i = 0; i < this.Grd.Rows.Count; i++)
                    {

                    
                        if (checked((long)this.Grd.Rows[i].Cells["NetSalary"].Value) <=  0)
                        {
                            Cnt += 1;
                            str += this.Grd.Rows[i].Cells["FullName"].Value + " با کد پرسنلی: " + this.Grd.Rows[i].Cells["ID_Person"].Value + Environment.NewLine;
                            this.Grd.SetRowBackColor(i, Color.Yellow);
                            this.Grd.SetRowForeColor(i, Color.Red);
                        }
                    }
                    if (Cnt > 0)
                    {
                        Global.Dialog.ShowInfo($"مبلغ فیش حقوقی {Cnt} نفر از کارمندان موجود در لیست منفی یا صفر شده است .لطفا قبل از  گرفتن هر نوع گزارش نسبت به اصلاح حقوق این کارمندان اقدام فرمایید." + Environment.NewLine + "این افراد در لیست با رنگ زرد نشان داده شده اند." + System.Environment.NewLine + System.Environment.NewLine + str);
                    }
                }
                );
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.Rows.Count == 0 )
                {
                    Global.Dialog.ShowInfo("هیچ موردی در گرید(جدول) بالا وجود ندارد");
                    return;
                }
                Personnely.ClsPersonel.Propertes propertes = new Personnely.ClsPersonel.Propertes();
                Common.StiReport Rep = new Common.StiReport();
                //ClsBlackListPerson Bl = new ClsBlackListPerson();
                //short IdMonth = short.Parse(this.CmbMonthA.SelectedValue.ToString());
                //DataTable DtBl = Bl.GetAll(IdMonth);
                //DataTable DtSource = new DataTable();
                //DtSource = (DataTable)this.Grd.DataSource;

                //for (int i = 0; i < DtSource.Rows.Count; i++)
                //{
                //    for (int j = 0; j < DtBl.Rows.Count; j++)
                //    {
                //        if (DtSource.Rows[i]["ID"].ToString() == DtBl.Rows[j]["ID_Person"].ToString())
                //        {
                //            DtSource.Rows[i].Delete();
                //        }

                //    }
                //}
                Rep.AddDatasource((DataTable)this.Grd.DataSource);
                Rep.AddDatasource(propertes.GetAllWithValue(1),"mellat");
                Rep.AddDatasource(propertes.GetAllWithValue(3),"Sepah");
                Rep.AddVariable("kargah", CmbKargah.SelectedItem.ToString());
                Rep.AddVariable("Year", CmbYear.SelectedItem.ToString());
                Rep.AddVariable("Month", CmbMonthA.SelectedItem.ToString());
                Rep.AddVariable("Company",  CmbCompany.SelectedItem.ToString());
                Rep.Show();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات گزارش گیری با خطا مواجه شد", ex.Message);
                //fdgdrgdrtgreter ert ert ert erter 
            }
        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.CmbKargahEx.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات گزارش گیری با خطا مواجه شد", ex.Message);
            }
        }
    }
}
