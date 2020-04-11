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
using System.Threading;
using System.Windows.Forms;
using static Personnely.ClsPersonBase;

namespace Salary.Forms
{
    public partial class FrmWorkPerMonth : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        DataTable DtResource = new DataTable();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        Kargah Kargah = new Kargah();
        public FrmWorkPerMonth()
        {
            InitializeComponent();
        }

        private void FrmWorkPerMonth_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void FillCmb()
        {
            Common.SalMali SalMali = new Common.SalMali();
            CmbSalMaliA.ValueMember = "ID";
            CmbSalMaliA.DisplayMember = "Name";
            CmbSalMaliA.DataSource = SalMali.GetSalMali();
            CmbSalMaliA.SelectedValue = Global.SalMali;
            //══════════ 2 ══════════
            ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
            this.CmbMahalleKhedmat.DisplayMember = "Name";
            this.CmbMahalleKhedmat.ValueMember = "ID";
            this.CmbMahalleKhedmat.DataSource = MK.GetAll();
            //══════════ 3 ══════════
            ClsGeneral.Company company = new ClsGeneral.Company();
            this.CmbCompany.ValueMember = "ID";
            this.CmbCompany.DisplayMember = "Name";
            this.CmbCompany.DataSource = company.GetAll();
            //══════════ 4 ══════════
            this.CmbKargah.DisplayMember = "Name";
            this.CmbKargah.ValueMember = "ID";
            //this.CmbKargah.DataSource = Kargah.GetAll()
        }


        private void BtnDeConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Common.StiReport Rep = new Common.StiReport();
                Rep.AddDatasource(this.DtResource);
                Rep.AddVariable("CodePersonel", this.TxtCodePr.Text);
                Rep.AddVariable("NamePersonel", this.TxtNamePr.Text);
                Rep.AddVariable("Year1", this.CmbSalMaliA.SelectedItem.ToString());
                Rep.AddVariable("Month1", this.CmbMonth.SelectedItem.ToString());
                Rep.Show();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("عملیات گزارش گیری با خطا مواجه شد", ex.Message);
            }
        }

        bool IsValidData()
        {
            //if (this.Person.Exists == false)
            //{
            //    Global.Dialog.ShowInfo("لطفا یک  کارمند معتبر انتخاب کنید");
            //    return false;
            //}
            if (this.CmbMonth.SelectedValue == null)
            {
                Global.Dialog.ShowInfo("ماه به درستی انتخاب نشده است");
                return false;
            }
            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidData() == false)
                {
                    return;
                }
                FillGrid();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات از دیتابیس با خطا مواجه شد", ex.Message);
            }
        }
        private void FillGrid()
        {
            try
            {
                short ID_MahaleKhedmat = (short)this.CmbMahalleKhedmat.SelectedValue;
                byte? ID_Company = (byte)this.CmbCompany.SelectedValue;
                long? ID_kargah = (long?)this.CmbKargah.SelectedValue;
                if (ID_kargah == 0)
                {
                    ID_kargah = null;
                }

                ClsMonthlyWork M = new ClsMonthlyWork();
                if (this.Person.Exists)
                {
                    if (ID_MahaleKhedmat != 0)
                    {
                        this.Grd.DataSource = M.GetMonthlyWork(this.Person.ID, (short)this.CmbSalMaliA.SelectedValue, (byte)CmbMonth.SelectedValue, (byte)CmbMonth.SelectedValue, ID_MahaleKhedmat, ID_Company, ID_kargah);
                    }
                    else
                    {
                        this.Grd.DataSource = M.GetMonthlyWork(this.Person.ID, (short)this.CmbSalMaliA.SelectedValue, (byte)CmbMonth.SelectedValue, (byte)CmbMonth.SelectedValue, null, ID_Company, ID_kargah);
                    }
                }
                else
                {
                    if (ID_MahaleKhedmat != 0)
                    {
                        this.Grd.DataSource = M.GetMonthlyWork((short)this.CmbSalMaliA.SelectedValue, (byte)CmbMonth.SelectedValue, (byte)CmbMonth.SelectedValue, ID_MahaleKhedmat, ID_Company, ID_kargah);
                    }
                    else
                    {
                        this.Grd.DataSource = M.GetMonthlyWork((short)this.CmbSalMaliA.SelectedValue, (byte)CmbMonth.SelectedValue, (byte)CmbMonth.SelectedValue, null, ID_Company, ID_kargah);
                    }
                }


                Telerik.WinControls.UI.ColumnGroupsViewDefinition View = new Telerik.WinControls.UI.ColumnGroupsViewDefinition();
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("مشخصات کارمند"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("کارکرد"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("مرخصی"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("ماموریت"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("کسر کار"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("اضافه کار"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("شبکاری"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("تعطیل کاری"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("‍‍‍‍‍‍‍‍‍اضافات"));
                View.ColumnGroups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("‍‍‍‍‍‍‍‍‍کسورات"));




                View.ColumnGroups[2].Groups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("روزانه"));
                View.ColumnGroups[2].Groups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("ساعتی"));
                View.ColumnGroups[3].Groups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("روزانه"));
                View.ColumnGroups[3].Groups.Add(new Telerik.WinControls.UI.GridViewColumnGroup("ساعتی"));

                View.ColumnGroups[0].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[0].Rows[0].Columns.Add(this.Grd.Columns["ID"]);
                View.ColumnGroups[0].Rows[0].Columns.Add(this.Grd.Columns["ID_Person"]);
                View.ColumnGroups[0].Rows[0].Columns.Add(this.Grd.Columns["Name"]);
                View.ColumnGroups[0].Rows[0].Columns.Add(this.Grd.Columns["ID_Payroll"]);

                View.ColumnGroups[1].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[1].Rows[0].Columns.Add(this.Grd.Columns["Year"]);
                View.ColumnGroups[1].Rows[0].Columns.Add(this.Grd.Columns["MonthName"]);
                View.ColumnGroups[1].Rows[0].Columns.Add(this.Grd.Columns["ID_MonthOfSalary"]);
                View.ColumnGroups[1].Rows[0].Columns.Add(this.Grd.Columns["DayCount"]);

                View.ColumnGroups[2].Groups[0].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[2].Groups[0].Rows[0].Columns.Add(this.Grd.Columns["DailyLeave"]);
                View.ColumnGroups[2].Groups[1].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[2].Groups[1].Rows[0].Columns.Add(this.Grd.Columns["HourlyLeave_H"]);
                View.ColumnGroups[2].Groups[1].Rows[0].Columns.Add(this.Grd.Columns["HourlyLeave_M"]);

                View.ColumnGroups[3].Groups[0].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[3].Groups[0].Rows[0].Columns.Add(this.Grd.Columns["DailyMission"]);
                View.ColumnGroups[3].Groups[1].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[3].Groups[1].Rows[0].Columns.Add(this.Grd.Columns["HourlyMission_H"]);
                View.ColumnGroups[3].Groups[1].Rows[0].Columns.Add(this.Grd.Columns["HourlyMission_M"]);

                View.ColumnGroups[4].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[4].Rows[0].Columns.Add(this.Grd.Columns["Absence_H"]);
                View.ColumnGroups[4].Rows[0].Columns.Add(this.Grd.Columns["Absence_M"]);

                View.ColumnGroups[5].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[5].Rows[0].Columns.Add(this.Grd.Columns["OverTime_H"]);
                View.ColumnGroups[5].Rows[0].Columns.Add(this.Grd.Columns["OverTime_M"]);

                View.ColumnGroups[6].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[6].Rows[0].Columns.Add(this.Grd.Columns["NightWork_H"]);
                View.ColumnGroups[6].Rows[0].Columns.Add(this.Grd.Columns["NightWork_M"]);

                View.ColumnGroups[7].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[7].Rows[0].Columns.Add(this.Grd.Columns["HolidayWork_H"]);
                View.ColumnGroups[7].Rows[0].Columns.Add(this.Grd.Columns["HolidayWork_M"]);

                View.ColumnGroups[8].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[8].Rows[0].Columns.Add(this.Grd.Columns["Bonus"]);
                View.ColumnGroups[8].Rows[0].Columns.Add(this.Grd.Columns["OtherAddition"]);

                View.ColumnGroups[9].Rows.Add(new Telerik.WinControls.UI.GridViewColumnGroupRow());
                View.ColumnGroups[9].Rows[0].Columns.Add(this.Grd.Columns["Loan"]);
                View.ColumnGroups[9].Rows[0].Columns.Add(this.Grd.Columns["Advance"]);
                View.ColumnGroups[9].Rows[0].Columns.Add(this.Grd.Columns["Buy"]);
                View.ColumnGroups[9].Rows[0].Columns.Add(this.Grd.Columns["OtherDiscount"]);



                this.Grd.ViewDefinition = View;

                this.Grd.Columns["ID"].Width = 63;
                this.Grd.Columns["ID_Payroll"].Width = 127;
                this.Grd.Columns["ID_Person"].Width = 86;
                this.Grd.Columns["Name"].Width = 156;
                this.Grd.Columns["Year"].Width = 57;
                this.Grd.Columns["MonthName"].Width = 67;
                this.Grd.Columns["ID_MonthOfSalary"].Width = 126;
                this.Grd.Columns["DayCount"].Width = 89;
                this.Grd.Columns["DailyMission"].Width = 57;
                this.Grd.Columns["HourlyMission_H"].Width = 57;
                this.Grd.Columns["HourlyMission_M"].Width = 52;
                this.Grd.Columns["DailyLeave"].Width = 57;
                this.Grd.Columns["HourlyLeave_H"].Width = 57;
                this.Grd.Columns["HourlyLeave_M"].Width = 52;
                this.Grd.Columns["Absence_H"].Width = 64;
                this.Grd.Columns["Absence_M"].Width = 58;
                this.Grd.Columns["OverTime_H"].Width = 64;
                this.Grd.Columns["OverTime_M"].Width = 58;
                this.Grd.Columns["NightWork_H"].Width = 64;
                this.Grd.Columns["NightWork_M"].Width = 58;
                this.Grd.Columns["HolidayWork_H"].Width = 64;
                this.Grd.Columns["HolidayWork_M"].Width = 58;
                this.Grd.Columns["Loan"].Width = 75;
                this.Grd.Columns["Advance"].Width = 72;
                this.Grd.Columns["Bonus"].Width = 88;
                this.Grd.Columns["Buy"].Width = 66;
                this.Grd.Columns["OtherAddition"].Width = 77;
                this.Grd.Columns["OtherDiscount"].Width = 40;


                this.Grd.Columns["ID"].HeaderText = "شماره";
                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["ID_Payroll"].HeaderText = "شماره فیش حقوقی";
                this.Grd.Columns["Name"].HeaderText = "نام و نام خانوادگی";
                this.Grd.Columns["Year"].HeaderText = "سال";
                this.Grd.Columns["MonthName"].HeaderText = "ماه";
                this.Grd.Columns["ID_MonthOfSalary"].HeaderText = "عدد ماه";
                this.Grd.Columns["DayCount"].HeaderText = "کارکرد روزانه";
                this.Grd.Columns["DailyMission"].HeaderText = "روز";
                this.Grd.Columns["HourlyMission_H"].HeaderText = "ساعت";
                this.Grd.Columns["HourlyMission_M"].HeaderText = "دقیقه";
                this.Grd.Columns["DailyLeave"].HeaderText = "روز";
                this.Grd.Columns["HourlyLeave_H"].HeaderText = "ساعت";
                this.Grd.Columns["HourlyLeave_M"].HeaderText = "دقیقه";
                this.Grd.Columns["Absence_H"].HeaderText = "ساعت";
                this.Grd.Columns["Absence_M"].HeaderText = "دقیقه";
                this.Grd.Columns["OverTime_H"].HeaderText = "ساعت";
                this.Grd.Columns["OverTime_M"].HeaderText = "دقیقه";
                this.Grd.Columns["NightWork_H"].HeaderText = "ساعت";
                this.Grd.Columns["NightWork_M"].HeaderText = "دقیقه";
                this.Grd.Columns["HolidayWork_H"].HeaderText = "ساعت";
                this.Grd.Columns["HolidayWork_M"].HeaderText = "دقیقه";
                this.Grd.Columns["Advance"].HeaderText = "مساعده";
                this.Grd.Columns["Loan"].HeaderText = "وام";
                this.Grd.Columns["Bonus"].HeaderText = "پاداش";
                this.Grd.Columns[25].HeaderText = "خریدپرسنل";
                this.Grd.Columns["OtherAddition"].HeaderText = "سایر";
                this.Grd.Columns["OtherDiscount"].HeaderText = "سایر";


                this.Grd.Columns["ID_MonthOfSalary"].IsVisible = false;
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString();
        }

        private void BtnBrows_TextChanged(object sender, EventArgs e)
        {

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

        private void CmbSalMaliA_SelectedIndexChanged_1(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                short Year = (short)this.CmbSalMaliA.SelectedValue;

                this.CmbMonth.DataSource = null;
                this.CmbMonth.ValueMember = "ID_Month";
                this.CmbMonth.DisplayMember = "MonthName";
                this.CmbMonth.DataSource = MY.GetAll(Year);
                this.CmbMonth.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات Combo Box با خطا مواجه شد", ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEntryWork EW = new FrmEntryWork();
                EW.ShowDialog();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("افزودن کارکرد جدید  با خطا مواجه شد", ex.Message);
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow == null)
                {
                    Global.Dialog.ShowInfo("شما هیچ گزینه ای را انتخاب نکرده اید");
                    return;
                }

                if (this.Grd.CurrentRow.Cells["ID_Payroll"].Value.ToString().Trim() != "")
                {
                    Global.Dialog.ShowInfo("برای کارکرد این ماه کارمندفوق فیش حقوقی صادر شده. شما مجاز به ویرایش  کارکردی که فیش حقوقی آن صادر شده است نمی باشید. شما میتوانید فیش حقوقی این ماه کارمند فوق را حذف نموده و سپس  به ویرایش کارکرد جاری اقدام نمایید");
                    return;
                }
                int ID_MonthlyWork = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                FrmEntryWork EW = new FrmEntryWork(ID_MonthlyWork);
                EW.ShowDialog();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("ویرایش کارکرد مورد نظر با خطا مواجه شد", ex.Message);
            }
        }

        private bool DeleteData()
        {
            if (this.Grd.SelectedRows.Count == 0)
            {
                Global.Dialog.ShowInfo("هیچ کارکردی انتخاب نشده است");
                return false;
            }
            if (this.Grd.CurrentRow.Cells["ID_Payroll"].Value.ToString().Trim() != "")
            {
                Global.Dialog.ShowInfo("برای کارکرد این ماه کارمندفوق فیش حقوقی صادر شده. شما مجاز به حذف  کارکردی که فیش حقوقی آن صادر شده است نمی باشید");
                return false;
            }

            string Str = string.Format("آیا برای حذف کارکرد ' {0} ' مطمئن هستید", this.Grd.CurrentRow.Cells["Name"].Value.ToString());
            Str += System.Environment.NewLine + this.Grd.CurrentRow.Cells["Year"].Value.ToString();
            Str += System.Environment.NewLine + this.Grd.CurrentRow.Cells["MonthName"].Value.ToString();
            if (Global.Dialog.ShowQuestion(Str) != true)
            {
                return false;
            }
            return true;
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteData() != true)
                {
                    return;
                }
                int ID_MonthlyWork = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                ClsMonthlyWork Mw = new ClsMonthlyWork();
                int RowAffect = Mw.Delete(ID_MonthlyWork);
                if (RowAffect != 0)
                {
                    Global.Dialog.ShowOK("کارکرد مورد نظر شما با موفقیت حذف شد");
                    BtnSave_Click(null, null);
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی حذف نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("حذف کارکرد مورد نظر با خطا مواجه شد", ex.Message);
            }
        }
        private Boolean IsValid()
        {
            if (this.Grd.CurrentRow == null)
            {
                Global.Dialog.ShowInfo("شما هیچ گزینه ای را انتخاب نکرده اید");
                return false;
            }
            if (this.Grd.SelectedRows.Count == 0)
            {
                Global.Dialog.ShowInfo("شما هیچ گزینه ای را انتخاب نکرده اید");
                return false;
            }
            return true;
        }

        private void BtnAddFish_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid() != true)
                {
                    return;
                }

                if (this.Grd.SelectedRows.Count == 1)
                {
                    if (this.Grd.CurrentRow.Cells["ID_Payroll"].Value.ToString() != "")
                    {
                        Global.Dialog.ShowInfo("برای این گزینه قبلا فیش حقوقی ثبت شده است");
                        return;
                    }
                    int ID = (int)this.Grd.CurrentRow.Cells["ID"].Value;

                    if (AddSinglePayroll(ID))
                    {
                        Global.Dialog.ShowOK("فیش حقوقی مورد نظر شما با موفقیت ثبت شد");
                        BtnSave_Click(null, null);
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی ثبت نشد");
                    }
                }
                else
                {
                    int Count = 0;
                    Count = AddMultiPayroll();
                    if (Count > 0)
                    {
                        Global.Dialog.ShowOK($"تعداد {Count} فقره فیش حقوقی با موفقیت ثبت شد");
                        BtnSave_Click(null, null);
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی ثبت نشد");
                    }

                }

            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات با خطا مواجه شد", Ex.Message);
            }
        }
        private int AddMultiPayroll()
        {
            this.Grd.Enabled = false;
            int RowAffect = 0;
            this.Grd.ShowProgressBar(this.Grd.SelectedRows.Count);
            foreach (var item in this.Grd.SelectedRows)
            {
                if (item.Cells["ID_Payroll"].Value.ToString() == "")
                {
                    int ID = (int)item.Cells["ID"].Value;
                    if (AddSinglePayroll(ID))
                    {
                        RowAffect += 1;
                    }
                    this.Grd.ProgressBar.Value1 += 1;

                    Application.DoEvents();
                }
            }
            this.Grd.ProgressBar.Visible = false;
            this.Grd.Enabled = true;
            return RowAffect;
        }

        private bool AddSinglePayroll(int ID)
        {
            ClsPayroll Pay = new ClsPayroll();
            int RowAffect = Pay.AddPayroll(ID);
            return Convert.ToBoolean(RowAffect);

        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
        }
    }
}
