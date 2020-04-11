using Permission;
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
    public partial class FrmAddMonthOfSalary : ClsMyForms
    {
        
        public short? ID { get; set; } 
        public FrmAddMonthOfSalary()
        {
            InitializeComponent();
        }
        public FrmAddMonthOfSalary(short ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        
        private void FrmAddMonthOfSalary_Load(object sender, EventArgs e)
        {
            try
            { 
                FillCmb();
                if (this.ID == null)
                {
                    this.UcDate1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth);
                    this.UcDate2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth);   
                }
                else
                {
                    ClsMonthOfSalary MonthOfSalary = new ClsMonthOfSalary();
                    MonthOfSalary = MonthOfSalary.GetByID(this.ID ?? 0);
                    this.UcDate1.TxtInt =MonthOfSalary.From;
                    this.UcDate2.TxtInt = MonthOfSalary.To;
                    this.CmbYear.SelectedValue = (int)MonthOfSalary.Year;
                    this.CmbMonth.SelectedValue = MonthOfSalary.ID_Month;
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری اطلاعات  سال مالی و ماه ها با خطا مواجه شد", ex.Message);
                throw ex ;
            }   
        }

        private void FillCmb()
        {
            try
            {
                Common.SalMali SalMali = new  Common.SalMali();
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = short.Parse(Common.SalMali.Value );
                //------------------------------------------------
                Common.ClsClander Cl = new Common.ClsClander();
                this.CmbMonth.DisplayMember = "Pr_Name";
                this.CmbMonth.ValueMember = "ID";
                this.CmbMonth.DataSource = Cl.GetMonthNames();


            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری اطلاعات  سال مالی و ماه ها با خطا مواجه شد",ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClsMonthOfSalary MonthOfSalary = new ClsMonthOfSalary();
                MonthOfSalary.ID_Month = (byte)this.CmbMonth.SelectedValue;
                MonthOfSalary.Year = short.Parse(this.CmbYear.SelectedValue.ToString());
                MonthOfSalary.From = this.UcDate1.TxtInt;
                MonthOfSalary.To = this.UcDate2.TxtInt;
                if (this.ID != null)
                {
                    MonthOfSalary.ID = this.ID;
                    if (MonthOfSalary.Update(MonthOfSalary) > 0)
                    {
                        Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد");
                        this.Close();
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی ذخیره نشد");
                    }
                    
                }
                else
                {
                    if (MonthOfSalary.Add(MonthOfSalary) > 0 )
                    {
                         Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد")     ;
                         this.Close();
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی ذخیره نشد");
                    }
                   
                }

            }
            catch (Exception EX)
            {
                Global.Dialog.ShowErorr("عملیات ذخیره اطلاعات با خطا مواجه شد", EX.Message);
            }
        }
    }
}
