using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Permission;
using Salary.Classes;

namespace Salary.Forms
{
    public partial class FrmBlackListPerson :  ClsMyForms
    {
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        ClsBlackListPerson Bl = new ClsBlackListPerson();
        public FrmBlackListPerson()
        {
            InitializeComponent();
        }

        private void FrmBlackListPerson_Load(object sender, EventArgs e)
        {
            try
            {
                FillAllCmb();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در بارگذاری فرم", ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                if (this.CmbMonthA.SelectedValue != null)
                {
                    short ID_MonthOfSalary = (short)this.CmbMonthA.SelectedValue;
                    this.Grd.DataSource = Bl.GetAll(ID_MonthOfSalary);

                    this.Grd.Columns["ID"].HeaderText = "ID";
                    this.Grd.Columns["ID_Pr"].HeaderText = "کد پرسنلی";
                    this.Grd.Columns["ID_MonthOfSalary"].HeaderText = "ID_MonthOfSalary";
                    this.Grd.Columns["Name"].HeaderText = "نام";
                    this.Grd.Columns["Year"].HeaderText = "سال";
                    this.Grd.Columns["Month"].HeaderText = "ماه";

                    this.Grd.Columns["ID"].IsVisible = false;
                    this.Grd.Columns["ID_MonthOfSalary"].IsVisible = false;

                    this.Grd.Columns["ID"].Width = 330;
                    this.Grd.Columns["ID_Pr"].Width = 80;
                    this.Grd.Columns["ID_MonthOfSalary"].Width = 410;
                    this.Grd.Columns["Name"].Width = 290;
                    this.Grd.Columns["Year"].Width = 70;
                    this.Grd.Columns["Month"].Width = 65;

                    this.Grd.Columns["ID"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["ID_Pr"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["ID_MonthOfSalary"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Name"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Year"].TextAlignment = ContentAlignment.MiddleCenter;
                    this.Grd.Columns["Month"].TextAlignment = ContentAlignment.MiddleCenter;
                }

            }
            catch (Exception ex)
            {

                throw ex ;
            }

        }

        private void FillAllCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = Global.SalMali;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            short Year = (short)this.CmbYear.SelectedValue;
            this.CmbMonthA.DataSource = null;
            this.CmbMonthA.ValueMember = "ID";
            this.CmbMonthA.DisplayMember = "MonthName";
            DataTable DtYear = MY.GetAll(Year);
            this.CmbMonthA.DataSource = DtYear;
        }

        private void CmbMonthA_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("خطایی درخواندن اطلاعات بوجود آمد", ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow == null)
                {
                    return;
                }
                if (Global.Dialog.ShowQuestion("آیا برای حذف مطمئن هستید ؟") != true  )
                {
                    return; 
                }
                int ID = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                if (Bl.Delete(ID))
                {
                     Global.Dialog.ShowOK("حذف با موفقیت انجام شد");
                    FillGrd();
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطایی در حذف اطلاعات بوجود آمد", ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddPersonToBlackList Frm = new FrmAddPersonToBlackList();
                Frm.ShowDialog();
                if (Frm.DialogResult == DialogResult.OK)
                {
                    FillGrd();
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطایی در افزودن اطلاعات بوجود آمد", ex.Message);
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                Common.StiReport Rep = new Common.StiReport();
                Rep.AddDatasource((DataTable)this.Grd.DataSource);
                Rep.AddVariable("year", this.CmbYear.Text);
                Rep.AddVariable("Month", this.CmbMonthA.Text);
                Rep.Show();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("گزارش گیری با خطا مواجه شد", ex.Message);
            }
        }
    }
}
