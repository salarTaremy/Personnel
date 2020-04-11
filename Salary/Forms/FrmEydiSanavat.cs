using Common;
using Ef.Entities;
using EF.Classes;
using Permission;
using Personnely;
using Salary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personnely.ClsPersonBase;

namespace Salary.Forms
{
    public partial class FrmEydiSanavat : ClsMyForms
    {
        Personnely.ClsPersonel Pr = new Personnely.ClsPersonel();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        Common.ClsInformation Inf = new Common.ClsInformation();
        ClsPersonBase.Kargah kargah = new ClsPersonBase.Kargah();
        ClsOtherPayment Pay = new ClsOtherPayment();
        Byte ID_Type;
        int FromDate = 0;
        int ToDate = 0;

        public FrmEydiSanavat( Byte ID_Type)
        {
            //Type:1 => eydi
            //Type:2 => sanavat
            InitializeComponent();
            this.ID_Type = ID_Type;
        }
        //private string GetSelectedKArgah()
        //{
        //    try
        //    {
        //        StringBuilder Sb = new StringBuilder();
        //        foreach (var item in this.CheckCmbKargah.CheckedItems.ToList())
        //        {
        //            if (Sb.ToString().Trim() == "")
        //            {
        //                Sb.Append(item.Value);
        //            }
        //            else
        //            {
        //                Sb.Append("," + item.Value);
        //            }
        //        }
        //        return Sb.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        private void FrmEydiSanavat_Load(object sender, EventArgs e)
        {
            UcDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
            UcDate.txt = Inf.PersianToday.Substring(0, 8) + "15";
            Application.DoEvents();
            FillCmb();
            Application.DoEvents();
            FillGRd();
            SetHeaderText();
        }

        private void SetHeaderText()
        {
            if (this.ID_Type == 1 )
            {
                this.Text = "پرداخت عیدی";
            }
            else
            {
                this.Text = "پرداخت سنوات";
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
                //══════════ 1 ══════════
                this.CmbFormul.DisplayMember = "Name";
                this.CmbFormul.ValueMember = "ID";
                this.CmbFormul.DataSource = Pay.GetAllFormula(this.ID_Type);
                //══════════ 2 ══════════
                ClsGeneral.Company Cmp = new ClsGeneral.Company();
                this.CmbCompany.DisplayMember = "Name";
                this.CmbCompany.ValueMember = "ID";
                this.CmbCompany.DataSource = Cmp.GetAll();
                //══════════  ══════════
                this.CmbKargah.DisplayMember = "Name";
                this.CmbKargah.ValueMember = "ID";
                //this.CheckCmbKargah.DataSource = kargah.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void FillGRd()
        {
            try
            {
                long kargah = (long)this.CmbKargah.SelectedValue;
                byte ID_Company = (byte)this.CmbCompany.SelectedValue;
                short MonthA = short.Parse(this.CmbMonthA.SelectedValue.ToString());
                short MonthB = short.Parse(this.CmbMonthB.SelectedValue.ToString());
                DataTable DtSource = Pay.GetValidPersonList(ID_Company, kargah, MonthA,MonthB);
                DtSource.Columns.Add("Rls", typeof(long));
                DtSource.Columns.Add(new DataColumn { ColumnName = "LeaveMinusRls", DataType = typeof(long) });
                DtSource.Columns.Add(new DataColumn { ColumnName = "LeavePlusRls", DataType = typeof(long) });
                DtSource.Columns.Add(new DataColumn { ColumnName = "DelayedSalaryRls", DataType = typeof(long) });
                DtSource.Columns.Add(new DataColumn { ColumnName = "MoreDiscountRls", DataType = typeof(long) });


                this.Grd.DataSource = DtSource;
                this.Grd.Columns["Chk"].HeaderText = "انتخاب";
                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["Name"].HeaderText = "نام";
                this.Grd.Columns["Famil"].HeaderText = "نام خانوادگی";
                this.Grd.Columns["CodePersoneli"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["ShomarehBime"].HeaderText = "شماره بیمه";
                this.Grd.Columns["ID_TarafHesab"].HeaderText = "کد طرف حساب";
                this.Grd.Columns["NameKargah"].HeaderText = "کارگاه";
                this.Grd.Columns["Rls"].HeaderText = "مبلغ  محاسبه شده";
                this.Grd.Columns["DayCount"].HeaderText = "تعداد روز";
                this.Grd.Columns["ID_Hokm"].HeaderText = "شماره حکم مبنا";
                this.Grd.Columns["BasicSalaryPerDayRls"].HeaderText = "پایه حقوق روزانه";
               

                if (this.ID_Type == 2)
                {
                    this.Grd.Columns["LeaveMinusRls"].HeaderText = "کسری مرخصی" + Environment.NewLine + "(ساعت)";
                    this.Grd.Columns["LeavePlusRls"].HeaderText = "طلب مرخصی" +Environment.NewLine + "(ساعت)" ;
                    this.Grd.Columns["DelayedSalaryRls"].HeaderText = "حقوق معوقه";
                    this.Grd.Columns["MoreDiscountRls"].HeaderText = "سایر کسورات";
                    this.Grd.Columns["LeaveMinusRls"].Width = 90;
                    this.Grd.Columns["LeavePlusRls"].Width = 90;
                    this.Grd.Columns["DelayedSalaryRls"].Width = 90;
                    this.Grd.Columns["MoreDiscountRls"].Width = 90;
                }
                else if (this.ID_Type == 1)
                {

                    this.Grd.Columns["LeaveMinusRls"].IsVisible = false;
                    this.Grd.Columns["LeavePlusRls"].IsVisible = false;
                    //this.Grd.Columns["DelayedSalaryRls"].IsVisible = false;
                    //this.Grd.Columns["MoreDiscountRls"].IsVisible = false;
                    this.Grd.Columns["DelayedSalaryRls"].HeaderText = "سایر اضافات";
                    this.Grd.Columns["MoreDiscountRls"].HeaderText = "سایر کسورات";
                }



                this.Grd.Columns["Chk"].ReadOnly = false;
                this.Grd.Columns["Famil"].ReadOnly = true;
                this.Grd.Columns["CodePersoneli"].ReadOnly = true;
                this.Grd.Columns["ShomarehBime"].ReadOnly = true;
                this.Grd.Columns["ID_TarafHesab"].ReadOnly = true;
                this.Grd.Columns["NameKargah"].ReadOnly = true;
                //this.Grd.Columns["DayCount"].ReadOnly = true;
                this.Grd.Columns["ID_Hokm"].ReadOnly = true;

                this.Grd.Columns["ID_TarafHesab"].IsVisible = false;

                this.Grd.Columns["Chk"].Width = 54;
                this.Grd.Columns["ID"].Width = 69;
                this.Grd.Columns["Name"].Width = 103;
                this.Grd.Columns["Famil"].Width = 205;
                this.Grd.Columns["CodePersoneli"].Width = 80;
                this.Grd.Columns["ShomarehBime"].Width = 108;
                this.Grd.Columns["NameKargah"].Width = 154;
                this.Grd.Columns["ID_TarafHesab"].Width = 79;
                this.Grd.Columns["Rls"].Width = 165;
                this.Grd.Columns["DayCount"].Width = 90;
                this.Grd.Columns["ID_Hokm"].Width = 90;
                this.Grd.Columns["BasicSalaryPerDayRls"].Width = 140;

                this.Grd.Columns["Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Rls"].TextAlignment = ContentAlignment.MiddleLeft;
                this.Grd.Columns["BasicSalaryPerDayRls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["BasicSalaryPerDayRls"].TextAlignment = ContentAlignment.MiddleLeft;


            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در خواندن لیست کارمندان", ex.Message);
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillGRd();
        }

        private void BtnCampute_Click(object sender, EventArgs e)
        {
            try
            {
                SetAmountZero();
                CalculateWithFormul();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("محاسبه با خطا مواجه شد", Ex.Message);
            }
        }
        private void CalculateWithFormul()
        {
            try
            {
                byte ID_Formul = (byte)this.CmbFormul.SelectedValue;
                long ID_Person = 0;
                int DayCount = 0;
                int Year = int.Parse(this.CmbYear.SelectedValue.ToString());
                byte ID_Company = (byte)this.CmbCompany.SelectedValue;
                this.ProgressBar.Value1 = 0;
                this.ProgressBar.Maximum = this.Grd.Rows.Count;
                this.ProgressBar.Visible = true;

                foreach (var item in this.Grd.Rows)
                {
                    if ((bool)item.Cells["Chk"].Value == true)
                    {
                        ID_Person = long.Parse(item.Cells["ID"].Value.ToString());
                        DayCount = int.Parse(item.Cells["DayCount"].Value.ToString());

                        using (DataTable Dt = this.Pay.GetPriceWithFormula(ID_Formul, ID_Person, ID_Company, DayCount,Year)) 
                        {
                            item.Cells["Rls"].Value = Dt.Rows[0]["Value"].ToString();
                            item.Cells["DayCount"].Value = (int)Dt.Rows[0]["DayCount"];
                            item.Cells["ID_Hokm"].Value = (long)Dt.Rows[0]["ID_Hokm"];
                        }
                    }
                    this.ProgressBar.Value1 = item.Index + 1;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.ProgressBar.Visible = false;
            }
        }
        private void SetAmountZero()
        {
            try
            {
                foreach (var item in this.Grd.Rows)
                {
                    item.Cells["Rls"].Value = null;
                }
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }
        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.Grd.DataSource = null;
        }
        private void ChkSelectAll_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            for (int i = 0; i < this.Grd.ChildRows.Count; i++)
            {
                this.Grd.ChildRows[i].Cells["Chk"].Value = this.ChkSelectAll.Checked;
            }
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                List<long> Lst_Id = new List<long>();
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if ((bool)Grd.Rows[i].Cells["Chk"].Value)
                    {
                        if (Grd.Rows[i].Cells["Rls"].Value == System.DBNull.Value)
                        {
                            Global.Dialog.ShowInfo("لطفا برای تمام پرسنل انتخابی مبلغ  معتبری وارد کنید ");
                            return;
                        }
                        Lst_Id.Add(long.Parse(Grd.Rows[i].Cells["CodePersoneli"].Value.ToString()));
                    }
                }
                using (Context Ctx = new Context())
                {
                    EydiSanavat NewItem = new EydiSanavat()
                    {
                        Date = UcDate.TxtInt,
                        FromDate = this.FromDate,
                        ToDate = this.ToDate,
                        ID_Type = this.ID_Type,
                        Description = this.TxtDescription.Text.Trim() + " " + this.CmbCompany.Text + " کارگاه : " + this.CmbKargah.Text 
                    };
                    Ctx.EydiSanavat.Add(NewItem);
                    var Tran = Ctx.Database.BeginTransaction();
                    Ctx.SaveChanges();
                    SetNullValues();
                    List<EydiSanavatDetail> Lst = new List<EydiSanavatDetail>();
                    foreach (var item in this.Grd.Rows)
                    {
                        if ((bool)item.Cells["Chk"].Value)
                        {
                            Lst.Add(new EydiSanavatDetail
                            {
                                ID_EydiSanavat = NewItem.ID,
                                ID_Person = (long)item.Cells["ID"].Value,
                                Amount = (long)item.Cells["Rls"].Value,
                                DayCount = (int)item.Cells["DayCount"].Value,
                                ID_Hokm = (long)item.Cells["ID_Hokm"].Value,
                                LeaveMinusRls = (long)item.Cells["LeaveMinusRls"].Value,
                                LeavePlusRls = (long)item.Cells["LeavePlusRls"].Value,
                                DelayedSalaryRls = (long)item.Cells["DelayedSalaryRls"].Value,
                                MoreDiscountRls = (long)item.Cells["MoreDiscountRls"].Value,
                            });
                        }
                    }
                    foreach (var item in Lst)
                    {
                        Ctx.EydiSanavatDetail.Add(item);
                    }
                    int RowAffect = Ctx.SaveChanges();
                    Tran.Commit();
                    if (RowAffect > 0)
                    {
                        Global.Dialog.ShowOK($"تعداد {RowAffect} رکورد با موفقیت ثبت شد");
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه رکوردی ثبت نشد");
                    }
                }
            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("خطای ذخیره داده ها", ex.Message);
            }
        }

        private void SetNullValues()
        {
            for (int i = 0; i < Grd.RowCount; i++)
            {
                if (this.Grd.Rows[i].Cells["LeaveMinusRls"].Value == DBNull.Value)
                {
                    this.Grd.Rows[i].Cells["LeaveMinusRls"].Value = 0;
                }
                if (this.Grd.Rows[i].Cells["LeavePlusRls"].Value == DBNull.Value)
                {
                    this.Grd.Rows[i].Cells["LeavePlusRls"].Value = 0;
                }
                if (this.Grd.Rows[i].Cells["DelayedSalaryRls"].Value == DBNull.Value)
                {
                    this.Grd.Rows[i].Cells["DelayedSalaryRls"].Value = 0;
                }
                if (this.Grd.Rows[i].Cells["MoreDiscountRls"].Value == DBNull.Value)
                {
                    this.Grd.Rows[i].Cells["MoreDiscountRls"].Value = 0;
                }
            }
        }

        private void radLabel9_Click(object sender, EventArgs e)
        {

        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            short Year = (short)this.CmbYear.SelectedValue;

            this.CmbMonthA.DataSource = null;
            this.CmbMonthA.ValueMember = "ID";
            this.CmbMonthA.DisplayMember = "MonthName";
            this.CmbMonthA.DataSource = MY.GetAll(Year);
            this.CmbMonthA.SelectedIndex = 0;

            this.CmbMonthB.DataSource = null;
            this.CmbMonthB.ValueMember = "ID";
            this.CmbMonthB.DisplayMember = "MonthName";
            this.CmbMonthB.DataSource = MY.GetAll(Year);
            this.CmbMonthB.SelectedIndex = this.CmbMonthB.Items.Count - 1;

        }
        private void CmbMonthA_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if(this.CmbMonthA.SelectedValue == null)
            {
                return;
            }
            short ID = short.Parse(this.CmbMonthA.SelectedValue.ToString());      
            var ms = MY.GetByID(ID);
            String StrDay = "01";
            String StrMonth = ms.ID_Month.ToString();
            if (StrMonth.Length == 1 )
            {
                StrMonth = "0" + StrMonth; 
            }
            this.FromDate = int.Parse(ms.Year.ToString() + StrMonth + StrDay);
        }
        private void CmbMonthB_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (this.CmbMonthB.SelectedValue == null)
            {
                return;
            }
            short ID = short.Parse(this.CmbMonthB.SelectedValue.ToString());
            var ms = MY.GetByID(ID);

            int DayCount = MY.GetDayCount(ID);

            //String StrDay ;
            String StrMonth = ms.ID_Month.ToString();
            if (StrMonth.Length == 1)
            {
                StrMonth = "0" + StrMonth;
            }
            //if (ms.ID_Month <= 6)
            //{
            //    StrDay = "31";
            //}
            //else {
            //    StrDay = "30";
            //}
            this.ToDate = int.Parse(ms.Year.ToString() + StrMonth + DayCount.ToString());
        }
    }
}
