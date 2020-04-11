using EF.Classes;
using Permission;
using Salary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Data;

namespace Salary.Forms
{
    public partial class FrmManageEydiSanavat : ClsMyForms
    {
        Byte ID_Type;
        ClsOtherPayment Pay = new ClsOtherPayment();
        public FrmManageEydiSanavat(Byte ID_Type)
        {
            InitializeComponent();
            this.ID_Type = ID_Type;
        }

        private void FrmManageEydiSanavat_Load(object sender, EventArgs e)
        {
            ucDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfYear);
            ucDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfYear);
            Application.DoEvents();
            FillGRd();
            SetHeaderText();
            SetButtonStatus();
            if (this.ID_Type == 1)
            {
                this.Text = "مدیریت عیدی سالانه";
            } else if (this.ID_Type == 2)
            {
                this.Text = "مدیریت سنوات";
            }
            if (this.Grd.CurrentRow  != null)
            {
                int ID = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                FillGrdDetail(ID);
            }
            else
            {

            }

        }

        private void FillGRd()
        {
            try
            {
                DataTable DtSource = Pay.GetEydiSanavat(this.ucDatePicker1.TxtInt  , this.ucDatePicker2.TxtInt , this.ID_Type);
                this.Grd.DataSource = DtSource;
                this.Grd.Columns["ID"].HeaderText = "شماره پرداخت";
                this.Grd.Columns["Date"].HeaderText = "تاریخ";
                this.Grd.Columns["FromDate"].HeaderText = "از تاریخ";
                this.Grd.Columns["ToDate"].HeaderText = "تا تاریخ";
                this.Grd.Columns["Description"].HeaderText = "شرح";
                this.Grd.Columns["TypeName"].HeaderText = "نوع پرداخت";




                this.Grd.Columns["ID"].Width = 90;
                this.Grd.Columns["Date"].Width = 73;
                this.Grd.Columns["FromDate"].Width = 75;
                this.Grd.Columns["ToDate"].Width = 79;
                this.Grd.Columns["Description"].Width = 367;
                this.Grd.Columns["TypeName"].Width = 73;

            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void SetHeaderText()
        {
            if (this.ID_Type == 1)
            {
                this.Text = "پرداخت عیدی";
            }
            else
            {
                this.Text = "پرداخت سنوات";
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillGRd();
        }

        private void Grd_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            FillDetail();
        }

        private void FillDetail()
        {
            if (this.Grd.CurrentRow is null)
            {
                return;
            }
            if (this.Grd.CurrentRow != null && this.Grd.CurrentRow.Cells["ID"].Value != null)
            {
                int ID = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                FillGrdDetail(ID);
            }
            else
            {
                this.GrdDetail.DataSource = null;
            }
        }

        private void FillGrdDetail(int ID)
        {
            try
            {
                DataTable DtSource = Pay.GetEydiSanavatDetail(ID);
                this.GrdDetail.DataSource = DtSource;

                this.GrdDetail.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.GrdDetail.Columns["FullName"].HeaderText = "نام ";
                this.GrdDetail.Columns["Amount"].HeaderText = "مبلغ";
                this.GrdDetail.Columns["DayCount"].HeaderText = "تعداد روز";
                this.GrdDetail.Columns["ID_Hokm"].HeaderText = "شماره حکم";
                this.GrdDetail.Columns["ID_EydiSanavat"].HeaderText = "شماره پرداخت";
                this.GrdDetail.Columns["BasicSalaryPerDayRls"].HeaderText = "پایه حقوق روزانه";
                this.GrdDetail.Columns["Net1"].HeaderText = "خالص مبلغ";
                this.GrdDetail.Columns["Net"].HeaderText = "قابل پرداخت";



                this.GrdDetail.Columns["EydiCount"].HeaderText = "تعداد عیدی";
                this.GrdDetail.Columns["TotalAmount"].HeaderText = "جمع عیدی ها";
                this.GrdDetail.Columns["TotalSalaryTaxable"].HeaderText = "جمع درآمد سالانه مشمول";
                this.GrdDetail.Columns["Tax"].HeaderText = "مالیات کسر شده";
                this.GrdDetail.Columns["MonthCount"].HeaderText = "تعداد ماه";
                this.GrdDetail.Columns["YearlyTax"].HeaderText = "مالیات عیدی";
                this.GrdDetail.Columns["Net"].HeaderText = "قابل پرداخت";

                this.GrdDetail.Columns["EydiCount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["TotalAmount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["TotalSalaryTaxable"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["Tax"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["MonthCount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["YearlyTax"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["Net"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["Net1"].FormatString = "{0:#,###,##0;(#,###,0)}";



                if (ID_Type == 2)
                {
                    this.GrdDetail.Columns["LeaveMinusRls"].HeaderText = "کسری مرخصی";
                    this.GrdDetail.Columns["LeavePlusRls"].HeaderText = "طلب مرخصی";
                    this.GrdDetail.Columns["LeaveMinusRlsTotal"].HeaderText = "مبلغ کسری مرخصی";
                    this.GrdDetail.Columns["LeavePlusRlsTotal"].HeaderText = "مبلغ طلب مرخصی";
                    this.GrdDetail.Columns["DelayedSalaryRls"].HeaderText = "حقوق معوقه";
                    this.GrdDetail.Columns["MoreDiscountRls"].HeaderText = "سایر کسورات";


                    this.GrdDetail.Columns["LeaveMinusRls"].Width = 100;
                    this.GrdDetail.Columns["LeavePlusRls"].Width = 100;
                    this.GrdDetail.Columns["DelayedSalaryRls"].Width = 100;
                    this.GrdDetail.Columns["MoreDiscountRls"].Width = 100;
                    this.GrdDetail.Columns["LeaveMinusRlsTotal"].Width = 100;
                    this.GrdDetail.Columns["LeavePlusRlsTotal"].Width = 100;


                    this.GrdDetail.Columns["LeaveMinusRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                    this.GrdDetail.Columns["LeavePlusRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                    this.GrdDetail.Columns["DelayedSalaryRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                    this.GrdDetail.Columns["MoreDiscountRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                    this.GrdDetail.Columns["LeaveMinusRlsTotal"].FormatString = "{0:#,###,##0;(#,###,0)}";
                    this.GrdDetail.Columns["LeavePlusRlsTotal"].FormatString = "{0:#,###,##0;(#,###,0)}";



                    this.GrdDetail.Columns["EydiCount"].IsVisible = false;
                    this.GrdDetail.Columns["TotalAmount"].IsVisible = false;
                    this.GrdDetail.Columns["TotalSalaryTaxable"].IsVisible = false;
                    this.GrdDetail.Columns["Tax"].IsVisible = false;
                    this.GrdDetail.Columns["MonthCount"].IsVisible = false;
                    this.GrdDetail.Columns["YearlyTax"].IsVisible = false;






                }
                else if (ID_Type == 1) {

                    this.GrdDetail.Columns["LeaveMinusRls"].IsVisible = false;
                    this.GrdDetail.Columns["LeavePlusRls"].IsVisible = false;
                    //this.GrdDetail.Columns["DelayedSalaryRls"].IsVisible = false;
                    //this.GrdDetail.Columns["MoreDiscountRls"].IsVisible = false;
                    this.GrdDetail.Columns["LeaveMinusRlsTotal"].IsVisible = false;
                    this.GrdDetail.Columns["LeavePlusRlsTotal"].IsVisible = false;
                    this.GrdDetail.Columns["DelayedSalaryRls"].HeaderText = "سایر اضافات";
                    this.GrdDetail.Columns["MoreDiscountRls"].HeaderText = "سایر کسورات";





                }









                this.GrdDetail.Columns["AccontNo1"].IsVisible = false;
                this.GrdDetail.Columns["AccontNo3"].IsVisible = false;
                this.GrdDetail.Columns["ID"].IsVisible = false;

                this.GrdDetail.Columns["ID_Person"].Width = 72;
                this.GrdDetail.Columns["FullName"].Width = 300;
                this.GrdDetail.Columns["Amount"].Width = 105;
                this.GrdDetail.Columns["DayCount"].Width = 76;
                this.GrdDetail.Columns["ID_Hokm"].Width = 77;
                this.GrdDetail.Columns["ID_EydiSanavat"].Width = 90;
                this.GrdDetail.Columns["BasicSalaryPerDayRls"].Width = 110;
                this.GrdDetail.Columns["Net"].Width = 110;

                this.GrdDetail.Columns["BasicSalaryPerDayRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["Amount"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.GrdDetail.Columns["Net"].FormatString = "{0:#,###,##0;(#,###,0)}";
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
            SetButtonStatus();
        }

        private void SetButtonStatus()
        {
            try
            {
                if (radPageView1.SelectedPage == radPageViewPage1)
                {
                    this.BtnEdit.Enabled = false;
                    this.BtnAdd.Enabled = true;
                    this.BtnDisk.Enabled = false;
                    this.BtnReport.Enabled = false;
                }

                if (radPageView1.SelectedPage == radPageViewPage2)
                {
                    this.BtnEdit.Enabled = true;
                    this.BtnAdd.Enabled = false;
                    //this.BtnDel.Enabled = false;
                    this.BtnDisk.Enabled = true;
                    this.BtnReport.Enabled = true;
                }

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

                if (this.GrdDetail.RowCount <=0)
                {
                    Global.Dialog.ShowInfo("شما هیچ ایتمی انتخاب نکرده اید");
                    return; 
                }
                Common.StiReport Rep = new Common.StiReport();


                 Rep.AddVariable("ID", this.Grd.CurrentRow.Cells["ID"].Value.ToString());
                 Rep.AddVariable("Date", this.Grd.CurrentRow.Cells["Date"].Value.ToString());
                 Rep.AddVariable("FromDate", this.Grd.CurrentRow.Cells["FromDate"].Value.ToString());
                 Rep.AddVariable("ToDate", this.Grd.CurrentRow.Cells["ToDate"].Value.ToString());
                 Rep.AddVariable("Description", this.Grd.CurrentRow.Cells["Description"].Value.ToString());
                   Rep.AddVariable("TypeName", this.Grd.CurrentRow.Cells["TypeName"].Value.ToString());





                //Rep.AddVariable("FromDate", this.ucDatePicker1.txt);
                //Rep.AddVariable("ToDate", this.ucDatePicker2.txt);
                //Rep.AddDatasource((DataTable)this.Grd.DataSource, "HeaderSource");
                Rep.AddDatasource((DataTable)this.GrdDetail.DataSource, "MainSource");
                Rep.AddVariable("ToDate", this.ucDatePicker2.txt);
                Rep.AddVariable("ToDate", this.ucDatePicker2.txt);

                Rep.Show();
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }

        private void BtnDisk_Click(object sender, EventArgs e)
        {

            List<ClsAccontNO> LstAccNo = new List<ClsAccontNO>();
            for (int i = 0; i < this.GrdDetail.Rows.Count; i++)
            {
                if (this.GrdDetail.Rows[i].Cells["AccontNo1"].Value != DBNull.Value)
                {
                    LstAccNo.Add(new ClsAccontNO
                    {
                        ID_Person = (long)this.GrdDetail.Rows[i].Cells["ID_Person"].Value,
                        AccontNo = this.GrdDetail.Rows[i].Cells["AccontNo1"].Value.ToString(),
                        Balance = Convert.ToInt64( this.GrdDetail.Rows[i].Cells["Net"].Value),
                        Bank = ClsAccontNO.EnumBank.Mellat
                    });;
                }
            }
            for (int i = 0; i < this.GrdDetail.Rows.Count; i++)
            {
                if (this.GrdDetail.Rows[i].Cells["AccontNo3"].Value != DBNull.Value)
                {
                    LstAccNo.Add(new ClsAccontNO
                    {
                        ID_Person = (long)this.GrdDetail.Rows[i].Cells["ID_Person"].Value,
                        AccontNo = this.GrdDetail.Rows[i].Cells["AccontNo3"].Value.ToString(),
                        Balance = Convert.ToInt64(this.GrdDetail.Rows[i].Cells["Net"].Value),
                        Bank = ClsAccontNO.EnumBank.Sepah
                    });
                }
            }
            FrmDisketBank frmDisketBank = new FrmDisketBank(LstAccNo);
            frmDisketBank.ShowDialog();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmEydiSanavat Frm = new FrmEydiSanavat(this.ID_Type);
            Frm.ShowDialog();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (radPageView1.SelectedPage == radPageViewPage1)
                {
                    if (Global.Dialog.ShowQuestion("آیا برای حذف کل لیست مطمئن هستید ؟") == false)
                    {
                        return;
                    }
                    int id = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                    if (Pay.Delete(id) > 0)
                    {
                        Global.Dialog.ShowOK("حذف با موفقیت انجام شد");
                        FillGRd();
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("هیچ داده ای حذف نشد");
                    }
                }

                if (radPageView1.SelectedPage == radPageViewPage2)
                {
                    string Name = this.GrdDetail.CurrentRow.Cells["FullName"].Value.ToString();
                    if (Global.Dialog.ShowQuestion($"آیا برای حذف {Name} مطمئن هستید ؟") == false)
                    {
                        return;
                    }

                    long id = (long)this.GrdDetail.CurrentRow.Cells["ID"].Value;
                    if (Pay.DeleteItem(id) > 0)
                    {
                        Global.Dialog.ShowOK("حذف با موفقیت انجام شد");
                        if (this.Grd.CurrentRow is null)
                        {
                            return;
                        }
                        int ID = (int)this.Grd.CurrentRow.Cells["ID"].Value;
                        FillGrdDetail(ID);
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("هیچ داده ای حذف نشد");
                    }
                }

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در حذف  اطلاعات", ex.Message);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (radPageView1.SelectedPage == radPageViewPage2)
            {
                long ID = (long)this.GrdDetail.CurrentRow.Cells["ID"].Value;

                FrmEditEydiSanavat frm = new FrmEditEydiSanavat(ID);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    FillDetail();
                }
            }

        }
    }
}
