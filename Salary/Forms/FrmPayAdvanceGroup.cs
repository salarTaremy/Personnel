using Common;
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
using System.Windows.Forms;
using Telerik.WinControls.UI;
using static Personnely.ClsPersonBase;

namespace Salary.Forms
{
    public partial class FrmPayAdvanceGroup : ClsMyForms
    {
        Personnely.ClsPersonel Pr = new Personnely.ClsPersonel();
        ClsAdvance Adv = new ClsAdvance();
        Common.ClsInformation Inf = new Common.ClsInformation();
        Kargah kargah = new Kargah();
        public FrmPayAdvanceGroup()
        {
            InitializeComponent();
        }

        private void FrmPayAdvanceGroup_Load(object sender, EventArgs e)
        {
            try
            {
                UcDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
                UcDate.txt = Inf.PersianToday.Substring(0, 8) + "15";
                Application.DoEvents();
                FillCmb();
                Application.DoEvents();
                FillGRd();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در بارگذاری فرم پرداخت مساعده", ex.Message);
            }
        }

        private void FillCmb()
        {
            try
            {
                this.CmbFormul.DisplayMember = "Name";
                this.CmbFormul.ValueMember = "Value";
                this.CmbFormul.DataSource = Adv.GetAllFormula();
                //══════════ 2 ══════════
                ClsGeneral.Company Cmp = new ClsGeneral.Company();
                this.CmbCompany.DisplayMember = "Name";
                this.CmbCompany.ValueMember = "ID";
                this.CmbCompany.DataSource = Cmp.GetAll();
                //══════════  ══════════
                this.CheckCmbKargah.DisplayMember = "Name";
                this.CheckCmbKargah.ValueMember = "ID";
                //this.CheckCmbKargah.DataSource = kargah.GetAll();
                this.CheckCmbKargah.SetCheck(true);
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
                string ValidKarghah = GetSelectedKArgah();


                byte ID_Company = (byte)this.CmbCompany.SelectedValue;
                DataTable DtSource = Adv.GetValidPersonList(ID_Company , ValidKarghah);
                DtSource.Columns.Add("Rls",typeof(long));
                this.Grd.DataSource = DtSource;

                this.Grd.Columns["Chk"].HeaderText = "انتخاب";
                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["Name"].HeaderText = "نام";
                this.Grd.Columns["Famil"].HeaderText = "نام خانوادگی";
                this.Grd.Columns["ID_Hokm"].HeaderText = "شماره حکم";
                this.Grd.Columns["CodePersoneli"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["ShomarehBime"].HeaderText = "شماره بیمه";
                this.Grd.Columns["ID_TarafHesab"].HeaderText = "کد طرف حساب";
                this.Grd.Columns["NameKargah"].HeaderText = "کارگاه";
                this.Grd.Columns["Rls"].HeaderText = "مبلغ مساعده";

                this.Grd.Columns["Chk"].ReadOnly = false;
                this.Grd.Columns["Famil"].ReadOnly = true;
                this.Grd.Columns["CodePersoneli"].ReadOnly = true;
                this.Grd.Columns["ShomarehBime"].ReadOnly = true;
                this.Grd.Columns["ID_TarafHesab"].ReadOnly = true;
                this.Grd.Columns["NameKargah"].ReadOnly = true;

                this.Grd.Columns["ID_TarafHesab"].IsVisible = false;

                this.Grd.Columns["Chk"].Width = 54;
                this.Grd.Columns["ID"].Width = 69;
                this.Grd.Columns["Name"].Width = 103;
                this.Grd.Columns["Famil"].Width = 205;
                this.Grd.Columns["ID_Hokm"].Width = 70;
                this.Grd.Columns["CodePersoneli"].Width = 70;
                this.Grd.Columns["ShomarehBime"].Width = 108;
                this.Grd.Columns["NameKargah"].Width = 154;
                this.Grd.Columns["ID_TarafHesab"].Width = 79;
                this.Grd.Columns["Rls"].Width = 165;

                this.Grd.Columns["Rls"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["Rls"].TextAlignment = ContentAlignment.MiddleLeft;

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در خواندن لیست کارمندان", ex.Message);
            }
        }

        private void RadFormul_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On )
            {
                this.CmbFormul.Enabled = true;
            }
            else
            {
                this.CmbFormul.Enabled = false;
            }
        }

        private void RadManual_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                this.TxtPrice.Enabled = true;
            }
            else
            {
                this.TxtPrice.Enabled =  false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SetAmountZero();
                if (this.RadFormul.IsChecked)
                {
                    CalculateWithFormul();
                }
                else if (this.RadManual.IsChecked)
                {
                    CalculateStaticAmount();
                }
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("محاسبه مساعده ها با خطا مواجه شد", Ex.Message);
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

        private void CalculateStaticAmount()
        {
            try
            {
                foreach (var item in this.Grd.Rows)
                {
                    if ((bool)item.Cells["Chk"].Value == true)
                    {
                        item.Cells["Rls"].Value = this.TxtPrice.Rls; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        private void CalculateWithFormul()
        {
            try
            {
                string Formul = this.CmbFormul.SelectedValue.ToString().Trim();
                long ID_Person = 0;
                byte ID_Company =  (byte)this.CmbCompany.SelectedValue;
                this.ProgressBar.Value1 = 0;
                this.ProgressBar.Maximum = this.Grd.Rows.Count;
                this.ProgressBar.Visible = true;

                foreach (var item in this.Grd.Rows)
                {
                    if ((bool)item.Cells["Chk"].Value == true)
                    {
                        ID_Person = long.Parse(item.Cells["ID"].Value.ToString());
                        item.Cells["Rls"].Value = this.Adv.GetPriceWithFormula(Formul, ID_Person , this.UcDate.TxtInt, ID_Company);
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
                Save();
                SetAmountZero();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("مشکلی در ذخیره اطلاعات بوجود آمد", Ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                DataTable Dt = new DataTable();
                Dt.Columns.Add("ID_Person", typeof(long)  );
                Dt.Columns.Add("Amount", typeof(long));
                Dt.Columns.Add("ID_Hokm", typeof(long));
                DataRow dr;
                
                foreach (var item in this.Grd.Rows)
                {
                    if  ((bool)item.Cells[0].Value == true)
                    {
                        dr = Dt.NewRow();
                        dr["ID_Person"] =  item.Cells["CodePersoneli"].Value;
                        dr["Amount"] = item.Cells["Rls"].Value;
                        dr["ID_Hokm"] = item.Cells["ID_Hokm"].Value;
                        Dt.Rows.Add(dr);
                    }
                }

                int RowAffect = Adv.AddGroup(Dt, this.UcDate.TxtInt);
                if (RowAffect > 0 )
                {
                    Global.Dialog.ShowOK($"تعداد {RowAffect} ردیف با موفقیت ثبت شد");
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی ثبت نشد");
                }


            }
            catch (Exception ex)
            {
                throw ex ;
            }
        }

        private void BtnPardakhtTaki_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPayAdvance Frm = new FrmPayAdvance();
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnBlackList_Click(object sender, EventArgs e)
        {
            
             try
            {
                FrmAdvanceBlacklist Frm = new FrmAdvanceBlacklist();
                Frm.ShowDialog();
                FillGRd();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CheckCmbKargah.DataSource = kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.CheckCmbKargah.SetCheck(true);
            this.Grd.DataSource = null;
        }

        private void CheckCmbKargah_CheckAllItemCheckedChanged(object sender, RadCheckedListDataItemEventArgs e)
        {
      
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {     
            FillGRd();
        }

        private string GetSelectedKArgah()
        {
            try
            {
                StringBuilder Sb = new StringBuilder();
                foreach (var item in this.CheckCmbKargah.CheckedItems.ToList())
                {
                    if (Sb.ToString().Trim() == "")
                    {
                        Sb.Append(item.Value);
                    }
                    else
                    {
                        Sb.Append("," + item.Value);
                    }
                }
                return Sb.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
