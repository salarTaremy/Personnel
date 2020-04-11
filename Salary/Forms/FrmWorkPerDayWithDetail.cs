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
    public partial class FrmWorkPerDayWithDetail : ClsMyForms
        
    {
        ClsPersonel Person = new ClsPersonel();
        DataSet DsResource = new DataSet();
        public FrmWorkPerDayWithDetail()
        {
            InitializeComponent();
        }

        private void FrmWorkPerDayWithDetail_Load(object sender, EventArgs e)
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
		             return ;
	            }
                ClsPersonnelOutput IO = new ClsPersonnelOutput();
                this.DsResource = IO.GetPerDayWithDetail(this.Person, this.UcDatePicker1.TxtInt, this.UcDatePicker2.TxtInt);
                FillGrid();
                FillItems();
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
  
                this.Grd.DataSource = this.DsResource.Tables[0];
                this.Grd.Columns["Pr_Name"].HeaderText = "روز";
                this.Grd.Columns["Pr_DateDisplay"].HeaderText = "تاریخ";
                this.Grd.Columns["Ready"].HeaderText = "حضور";
                this.Grd.Columns["EffectiveOverTimeBeforeTime"].HeaderText = "اضافه کاری قبل از وقت";
                this.Grd.Columns["EffectiveOverTimeAfterTime"].HeaderText = "اضافه کاری بعد از وقت";
                this.Grd.Columns["Entry1"].HeaderText = "ورود";
                this.Grd.Columns["Quit1"].HeaderText = "خروج";
                this.Grd.Columns["Entry2"].HeaderText = "ورود";
                this.Grd.Columns["Quit2"].HeaderText = "خروج";
                this.Grd.Columns["Entry3"].HeaderText = "ورود";
                this.Grd.Columns["Quit3"].HeaderText = "خروج";
                this.Grd.Columns["Entry4"].HeaderText = "ورود";
                this.Grd.Columns["Quit4"].HeaderText = "خروج";

                this.Grd.Columns["Pr_Name"].Width = 135;
                this.Grd.Columns["Pr_DateDisplay"].Width = 95;
                this.Grd.Columns["Ready"].Width = 80;
                this.Grd.Columns["EffectiveOverTimeBeforeTime"].Width = 120;
                this.Grd.Columns["EffectiveOverTimeAfterTime"].Width = 120;
                this.Grd.Columns["Entry1"].Width = 70;
                this.Grd.Columns["Quit1"].Width = 70;
                this.Grd.Columns["Entry2"].Width = 70;
                this.Grd.Columns["Quit2"].Width = 70;
                this.Grd.Columns["Entry3"].Width = 70;
                this.Grd.Columns["Quit3"].Width = 70;
                this.Grd.Columns["Entry4"].Width = 70;

                this.Grd.Columns["Pr_DateDisplay"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Ready"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["EffectiveOverTimeBeforeTime"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["EffectiveOverTimeAfterTime"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Entry1"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Quit1"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Entry2"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Quit2"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Entry3"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Quit3"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Entry4"].TextAlignment = ContentAlignment.MiddleCenter;
                this.Grd.Columns["Quit4"].TextAlignment = ContentAlignment.MiddleCenter;




            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }
        private void FillItems()
        {
            try
            {
                this.TxtReady.Text = this.DsResource.Tables[1].Rows[0]["Ready"].ToString();
                this.TxtMissionPerHoure.Text = this.DsResource.Tables[1].Rows[0]["Mission"].ToString();
                this.TxtLeavePerHoure.Text = this.DsResource.Tables[1].Rows[0]["Leave"].ToString();
                this.TxtAbsencePerHoure .Text = this.DsResource.Tables[1].Rows[0]["Absence"].ToString();
                this.TxtReady.Text = this.DsResource.Tables[2].Rows[0]["CountOFDay"].ToString();
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        bool IsValidData()
        { 
            if (this.Person.Exists ==false)
	        {
                Global.Dialog.ShowInfo("لطفا  کارمند معتبری انتخاب کنید");
		         return false ;
	        }
                    return true; 

         }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDeConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Common.StiReport Rep = new Common.StiReport();
                Rep.AddDatasource(this.DsResource.Tables[0]);
                Rep.AddDatasource(this.DsResource.Tables[1]);
                Rep.AddDatasource(this.DsResource.Tables[2]);
                Rep.AddVariable("Date1", UcDatePicker1.txt);
                Rep.AddVariable("Date2", UcDatePicker2.txt);
                Rep.AddVariable("PrCode", TxtCodePr.Text);
                Rep.AddVariable("PrName", TxtNamePr.Text );
                Rep.Show();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("مشکلی در روند اجرای گزارش بوجود آمده است", ex.Message);
            }

        }
       }
}
