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
    public partial class FrmWorkPerDay : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        DataTable DtResource = new DataTable();
        public FrmWorkPerDay()
        {
            InitializeComponent();
        }

        private void FrmWorkPerDay_Load(object sender, EventArgs e)
        {
            this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth);
            this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth);
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
                if (IsValidData() == false)
                {
                    return;
                }
                ClsPersonnelOutput Otp = new ClsPersonnelOutput();
                    DtResource = Otp.GetPerDay(this.Person, this.UcDatePicker1.TxtInt, this.UcDatePicker2.TxtInt);
                    this.Grd.DataSource = DtResource;
                    this.Grd.Columns["Pr_Name"].HeaderText = "روز";
                    this.Grd.Columns["Pr_DateDisplay"].HeaderText = "تاریخ";
                    this.Grd.Columns["Delay"].HeaderText = "تاخیر";
                    this.Grd.Columns["EffectiveOverTimeAfterTime"].HeaderText = "اضافه کاری"  + Environment.NewLine + "(ابتدای وقت)" ;
                    this.Grd.Columns["EffectiveOverTimeBeforeTime"].HeaderText = "اضافه کاری" + Environment.NewLine + "(آخر وقت)" ;
                    this.Grd.Columns["Ready"].HeaderText = "کل حضور";
                    this.Grd.Columns["Mission"].HeaderText = "ماموریت";
                    this.Grd.Columns["Leave"].HeaderText = "مرخصی";
                    this.Grd.Columns["Absence"].HeaderText = "غیبت";
                    this.Grd.Columns["Pr_Name"].Width = 115;
                    this.Grd.Columns["Pr_DateDisplay"].Width = 85;
                    this.Grd.Columns["Delay"].Width = 75;
                    this.Grd.Columns["EffectiveOverTimeAfterTime"].Width = 75;
                    this.Grd.Columns["EffectiveOverTimeBeforeTime"].Width = 75;
                    this.Grd.Columns["Ready"].Width = 75;
                    this.Grd.Columns["Mission"].Width = 75;
                    this.Grd.Columns["Leave"].Width = 75;
                    this.Grd.Columns["Absence"].Width = 75;
                    this.Grd.Columns["Pr_DateDisplay"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Delay"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["EffectiveOverTimeAfterTime"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["EffectiveOverTimeBeforeTime"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Ready"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Mission"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Leave"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Absence"].TextAlignment = ContentAlignment.MiddleCenter;
            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات کارکرد روزانه با خطا مواجه شد", ex.Message);
            }
        }

        private void BtnDeConfirm_Click(object sender, EventArgs e)
        {
            Common.StiReport Rep = new Common.StiReport();
            Rep.AddDatasource(this.DtResource);
            Rep.AddVariable("FromDate", this.UcDatePicker1.txt);
            Rep.AddVariable("ToDate", this.UcDatePicker2.txt);
            Rep.AddVariable("PrCode", this.TxtCodePr.Text);
            Rep.AddVariable("PrName", this.TxtNamePr.Text);
            Rep.Show();
        }
        bool IsValidData()
        {
            try
            {
                if (this.Person.Exists == false )
                {
                    Global.Dialog.ShowInfo("لطفا کارمند معتبری انتخاب کنید");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }

    }
}
