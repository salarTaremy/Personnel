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
using static Personnely.ClsPersonBase;

namespace Salary.Forms
{
    public partial class FrmManageAdvance : Permission.ClsMyForms
    {

        ClsPersonel Person = new ClsPersonel();
        Common.ClsGeneral.Company Cmp = new Common.ClsGeneral.Company();
        Kargah Kargah = new Kargah();


        public FrmManageAdvance()
        {
            InitializeComponent();
        }

        private void FrmManageAdvance_Load(object sender, EventArgs e)
        {
            this.UcDateA.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth);
            this.UcDateB.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth);
            FillCmb();
        }

        private void FillCmb()
        {
            try
            {
                this.CmbEmployer.DisplayMember = "Name";
                this.CmbEmployer.ValueMember = "ID";
                this.CmbEmployer.DataSource =  Cmp.GetAll();
                //══════════ 2 ══════════
                ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
                this.CheckCmbKargah.DisplayMember = "Name";
                this.CheckCmbKargah.ValueMember = "ID";
                this.CheckCmbKargah.DataSource = MK.GetAll();
                //══════════ 4 ══════════
                this.CmbKargah.DisplayMember = "Name";
                this.CmbKargah.ValueMember = "ID";
                //this.CmbKargah.DataSource = Kargah.GetAll()
                //══════════ 4 ══════════
                this.CmbKargahEx.DisplayMember = "Name";
                this.CmbKargahEx.ValueMember = "ID";
                //this.CmbKargahEx.DataSource = Kargah.GetAll();

            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خطا در خواندن اطلاعات ", Ex.Message);
            }
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خطا در خواندن اطلاعات از سرور", Ex.Message);
            }

        }

        private void FillGrd()
        {
            try
            {
                ClsAdvance Adv;

                bool Bol1 = this.ChkAll.Checked;
                bool Bol2 = this.ChkBazneshasteh.Checked;

                if ((long)this.CmbKargahEx.SelectedValue != 0)
                {
                    Adv = new ClsAdvance((long)this.CmbKargahEx.SelectedValue);
                }
                else
                {
                    Adv = new ClsAdvance();
                }
                byte ID_Company = (byte)this.CmbEmployer.SelectedValue;
                long ID_Kargah = (long)this.CmbKargah.SelectedValue;
                short ID_MahalKHedmat = (short)this.CheckCmbKargah.SelectedValue;
                if (this.Person.Exists)
                {
                    if (ID_Kargah == 0 )
                    {
                        if (ID_MahalKHedmat == 0)
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, this.UcDateA.TxtInt, this.UcDateB.TxtInt, this.Person.ID,Bol1,Bol2);
                        }
                        else
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company,ID_MahalKHedmat, this.UcDateA.TxtInt, this.UcDateB.TxtInt, this.Person.ID, Bol1, Bol2);
                        }
                    }
                    else
                    {
                        if (ID_MahalKHedmat == 0)
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, ID_Kargah, this.UcDateA.TxtInt, this.UcDateB.TxtInt, this.Person.ID, Bol1, Bol2);
                        }
                        else
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, ID_Kargah,ID_MahalKHedmat, this.UcDateA.TxtInt, this.UcDateB.TxtInt, this.Person.ID, Bol1, Bol2);
                        }
                    }  
                }
                else
                {
                    if (ID_Kargah == 0)
                    {
                        if (ID_MahalKHedmat == 0)
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, this.UcDateA.TxtInt, this.UcDateB.TxtInt, Bol1, Bol2);
                        }
                        else
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company,ID_MahalKHedmat, this.UcDateA.TxtInt, this.UcDateB.TxtInt, Bol1, Bol2);
                        }
                    }
                    else
                    {
                        if (ID_MahalKHedmat == 0)
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, ID_Kargah, this.UcDateA.TxtInt, this.UcDateB.TxtInt, Bol1, Bol2);
                        }
                        else
                        {
                            this.Grd.DataSource = Adv.GetAllWithDetail(ID_Company, ID_Kargah,ID_MahalKHedmat, this.UcDateA.TxtInt, this.UcDateB.TxtInt, Bol1, Bol2);
                        }
                    }
                }
                SetHeaderText();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void SetHeaderText()
        {
            try
            {
                
                this.Grd.Columns["Pr_DateDisplay"].HeaderText = "تاریخ";
                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
                this.Grd.Columns["OldAccountingCode"].HeaderText = "کد قدیم";
                this.Grd.Columns["Amount"].HeaderText = "مبلغ مساعده";
                this.Grd.Columns["Caption"].HeaderText = "ماه کسر از حقوق(فیش حقوقی)";
                this.Grd.Columns["Detail"].HeaderText = "توضیحات";
                this.Grd.Columns["Mellat"].HeaderText = "شماره ملت";
                this.Grd.Columns["Sepah"].HeaderText = "شماره سپه";
  

                

                this.Grd.Columns["ID"].Width = 42;
                this.Grd.Columns["Pr_DateDisplay"].Width = 80;
                this.Grd.Columns["ID_Person"].Width = 80;
                this.Grd.Columns["FullName"].Width = 348;
                this.Grd.Columns["Amount"].Width = 85;
                this.Grd.Columns["Caption"].Width = 162;
                this.Grd.Columns["ID_MonthOfSalary"].Width = 140;

                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["IsBazneshasteh"].IsVisible = false;
                this.Grd.Columns["ID_MonthOfSalary"].IsVisible = false;
                this.Grd.Columns["Amount"].FormatString = "{0:#,###,##0;(#,###,0)}";

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                List<long> IDList= new List<long>();
                foreach (var item in this.Grd.SelectedRows)
                {
                    IDList.Add((long)item.Cells["ID"].Value);
                }
                if (Global.Dialog.ShowQuestion($"آیا برای حذف {IDList.Count} ردیف مطمئن هستید ؟") != true  )
                {
                    return;
                }
                ClsAdvance Adv = new ClsAdvance();
                int RowAffect =Adv.Delete(IDList);
                if (RowAffect > 0 )
                {
                    Global.Dialog.ShowOK($"تعداد {RowAffect} ردیف با موفقیت حذف شد");
                    BtnSearch_Click(null, null);
                }
                else
                {
                    Global.Dialog.ShowInfo("هیچ رکوردی حذف نشد");
                }
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات حذف با خطا مواجه شد", Ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPayAdvanceGroup Frm = new FrmPayAdvanceGroup();
                Frm.ShowDialog();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("متاسفانه عملیات حذف با خطا مواجه شد", Ex.Message);
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {

            ClsBank Bank = new ClsBank();
            int CompanyID =   Convert.ToInt16( CmbEmployer.SelectedValue) ;
            int ID = 0 ;
            string NameBank = null;
            //if (CompanyID == 10)
            //{
            //    ID = 1;
            //    NameBank = "سپه";
            //}
            //else if (CompanyID == 11)
            //{
            //    ID = 3;
            //    NameBank = "ملت";
            //}
            //if (  int.Parse(CmbKargah.SelectedValue.ToString()) ==   (int) 5 )
            //{
            //    ID = 1;
            //    NameBank = "سپه";
            //}


            ID = 1;
            NameBank = "سپه";
            if (CompanyID == 10 && int.Parse(CmbKargah.SelectedValue.ToString()) == (int)6)
            {
                ID = 3;
                NameBank = "ملت";
            }
            if (CompanyID == 10 && int.Parse(CmbKargah.SelectedValue.ToString()) == (int)4)
            {
                ID = 3;
                NameBank = "ملت";
            }
            if (CompanyID == 11 && int.Parse(CmbKargah.SelectedValue.ToString()) == (int)5)
            {
                ID = 3;
                NameBank = "ملت";
            }



            DataTable Dt_ShomarehHesab = Bank.GetAllAccontNo(ID);
            Common.StiReport Rep = new Common.StiReport();
            Rep.AddDatasource((DataTable)this.Grd.DataSource);
            Rep.AddDatasource(Dt_ShomarehHesab,"ShomarehHesab" );
            Rep.AddVariable("DateA", this.UcDateA.txt, "از تاریخ");
            Rep.AddVariable("DateB", this.UcDateB.txt, "تا تاریخ");
            Rep.AddVariable("NameBank", NameBank, "نام بانک");
            Rep.AddVariable("EmployerName",this.CmbEmployer.Text);
            Rep.Show();
        }

        private void BtnBlackList_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAdvanceBlacklist Frm = new FrmAdvanceBlacklist();
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void CmbEmployer_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbEmployer.SelectedValue);
            this.CmbKargahEx.DataSource = Kargah.GetAll((byte)this.CmbEmployer.SelectedValue);
        }

        private void BtnDisk_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClsAccontNO> LstAccNo = new List<ClsAccontNO>();
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if (this.Grd.Rows[i].Cells["Mellat"].Value != DBNull.Value)
                    {
                        LstAccNo.Add(new ClsAccontNO
                        {
                            ID_Person = (long)this.Grd.Rows[i].Cells["ID_Person"].Value,
                            AccontNo = this.Grd.Rows[i].Cells["Mellat"].Value.ToString(),
                            Balance = (long?)this.Grd.Rows[i].Cells["Amount"].Value,
                            Bank = ClsAccontNO.EnumBank.Mellat
                        });
                    }
                }
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if (this.Grd.Rows[i].Cells["Sepah"].Value != DBNull.Value)
                    {
                        LstAccNo.Add(new ClsAccontNO
                        {
                            ID_Person = (long)this.Grd.Rows[i].Cells["ID_Person"].Value,
                            AccontNo = this.Grd.Rows[i].Cells["Sepah"].Value.ToString(),
                            Balance = (long?)this.Grd.Rows[i].Cells["Amount"].Value,
                            Bank = ClsAccontNO.EnumBank.Sepah
                        });
                    }
                }
                FrmDisketBank frmDisketBank = new FrmDisketBank(LstAccNo);
                frmDisketBank.ShowDialog();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("ساخت دیسکت با خطا مواجه شد", ex.Message);
            }
        }
    }
}
