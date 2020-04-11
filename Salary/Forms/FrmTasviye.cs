using Ef.Entities;
using EF.Classes;
using Permission;
using Personnely;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary.Forms
{
    public partial class FrmTasviye : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        long BasicSalaryPerDay = 0;
        long BasicSalaryPerMonth = 0;
        long _ID_Pony;
        private long ID_Pony = 0 ;

        public FrmTasviye()
        {
            InitializeComponent();
        }

        public FrmTasviye(long ID_Pony)
        {
            InitializeComponent();
            this.ID_Pony = ID_Pony;
        }

        private void FrmTasviye_Load(object sender, EventArgs e)
        {
            this.ucDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
        }

        private void fillCmbCompnay(long iD_Person)
        {
            Personnely.ClsHokm Hokms = new ClsHokm();
            DataTable DtHokm =  Hokms.GetEndHokm(iD_Person);
            if (DtHokm.Rows.Count == 0 )
            {
                Global.Dialog.ShowInfo("هیچ حکم پایان کاری برای این کارمند وجود ندارد. لطقا ابتدا حکم پایان کار برای این فرد ثبت نمایید.");
                EmptyTextBoxs();
                return;
            } 
            else if (DtHokm.Rows.Count == 1)
            {

            }
            else if (DtHokm.Rows.Count > 1)
            {
                Global.Dialog.ShowInfo("برای این فرد بیشتر از یک حکم خاتمه به کار وجود دارد .لطفا از قسمت نام شرکت حکم مربوطه را انتخاب کنید.");
            }
            this.CmbCompany.DisplayMember = "CompanyName";
            this.CmbCompany.ValueMember = "ID";
            this.CmbCompany.DataSource = DtHokm;

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
                fillCmbCompnay(Person.ID);
            }
            else
            {
                TxtNamePr.Text = null;
                this.CmbCompany.DataSource = null;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidData())
                {
                    return;
                }
                if (Save())
                {
                    Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه اطلاعات ذخیره نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در ذخیره اطلاعات", ex.InnerException.Message);
            }
        }

        private bool Save()
        {
            try
            {
                int RowAffect = 0;
                PonyForms pn;
                if (this.ID_Pony == 0 )
                {
                     pn = new PonyForms()
                    {
                        BasicSalaryPerDay = this.TxtBasicSalaryPerDay.Rls,
                        BasicSalaryPerMonth = this.TxtBasicSalaryPerMonth.Rls,
                        Date = this.ucDate.TxtInt,
                        DayCount = (int)this.TxtDayCount.Rls,
                        Eydi = this.TxtEydi.Rls,
                        FromDate = ucDatePicker1.TxtInt,
                        ToDate = ucDatePicker2.TxtInt,
                        ID_Pr = this.Person.ID,
                        ID_Hokm = long.Parse(this.TxtHokmNo.Text.Replace(",", "")),
                        LeaveDay = (int)this.TxtAdDay.Rls,
                        LeaveHour = (int)this.TxtAdHour.Rls,
                        LeaveMin = (int)this.TxtAdMinute.Rls,
                        Sanavat = this.TxtSanavat.Rls,
                        LeaveRls = this.TxtAdvRls.Rls,
                        OtherAdditions = this.TxtSayerBes.Rls,
                        OtherDeductions = this.TxtSayerBed.Rls
                    };
                    using (Context Ctx = new Context())
                    {
                        Ctx.PonyForms.Add(pn);
                        RowAffect = Ctx.SaveChanges();
                    }
                }
                else
                {
                    using (Context Ctx = new Context())
                    {
                        pn = Ctx.PonyForms.Find(this.ID_Pony);
                        pn.BasicSalaryPerDay = this.TxtBasicSalaryPerDay.Rls;
                        pn.BasicSalaryPerMonth = this.TxtBasicSalaryPerMonth.Rls;
                        pn.Date = this.ucDate.TxtInt;
                        pn.DayCount = (int)this.TxtDayCount.Rls;
                        pn.Eydi = this.TxtEydi.Rls;
                        pn.FromDate = ucDatePicker1.TxtInt;
                        pn.ToDate = ucDatePicker2.TxtInt;
                        pn.ID_Pr = this.Person.ID;
                        pn.ID_Hokm = long.Parse(this.TxtHokmNo.Text.Replace(",", ""));
                        pn.LeaveDay = (int)this.TxtAdDay.Rls;
                        pn.LeaveHour = (int)this.TxtAdHour.Rls;
                        pn.LeaveMin = (int)this.TxtAdMinute.Rls;
                        pn.Sanavat = this.TxtSanavat.Rls;
                        pn.LeaveRls = this.TxtAdvRls.Rls;
                        pn.OtherAdditions = this.TxtSayerBes.Rls;
                        pn.OtherDeductions = this.TxtSayerBed.Rls;                                                                                     
                        RowAffect = Ctx.SaveChanges();
                    }

                }
                return RowAffect != 0;
            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }

        private bool isValidData()
        {
            if (this.Person.Exists == false )
            {
                Global.Dialog.ShowInfo("لطفا کارمند معتیری انتخاب کنید");
                return false; 
            }
            if (this.CmbCompany.SelectedIndex == -1  )
            {
                Global.Dialog.ShowInfo("هیچ شرکتی برای این کارمند انتخاب نشده است");
                return false;
            }


            if (TxtSumMajaya.Rls <= 0  )
            {
                if (Global.Dialog.ShowQuestion($" مبلغ {TxtSumMajaya.Text} ریال است . آیا مطمئن هستید ؟") == false )
                {
                    return false;
                }
            }
            if (this.ID_Pony ==  0)
            {
                using (Context Ctx = new Context())
                {
                    var x = Ctx.PonyForms.Where(p => p.ID_Pr == this.Person.ID).FirstOrDefault();
                    if (x != null)
                    {
                        Global.Dialog.ShowInfo("قبلا برای این کارمند دستور تسویه حساب صادر شده است");
                        return false;
                    }
                }
            }



            return true;
        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            Personnely.ClsHokm H = new ClsHokm();
            EmptyTextBoxs();
            if (this.CmbCompany.SelectedValue == null)
            {
                return;
            }
            long ID = (long)this.CmbCompany.SelectedValue;
            DataTable DtHokm =  H.GetByID(ID);
            this.BasicSalaryPerMonth = (long)DtHokm.Rows[0]["BasicSalaryPerMonthRls"];
            this.BasicSalaryPerDay = (this.BasicSalaryPerMonth / 30);
            this.TxtBasicSalaryPerMonth.Text = this.BasicSalaryPerMonth.ToString();
            this.TxtBasicSalaryPerDay.Text = this.BasicSalaryPerDay.ToString();
            this.TxtHokmNo.Text = DtHokm.Rows[0]["ID"].ToString();
            this.ucDatePicker1.TxtInt = (int)DtHokm.Rows[0]["DateEstekhdam"];
            this.ucDatePicker2.TxtInt = (int)DtHokm.Rows[0]["DateEnd"];
            Common.ClsClander.PersianDate cl = new Common.ClsClander.PersianDate();
            int DayCount = cl.GetDiff( this.ucDatePicker2.TxtInt, this.ucDatePicker1.TxtInt);
            this.TxtDayCount.Text = DayCount.ToString();
            
           
        }

        private void EmptyTextBoxs()
        {
            this.TxtBasicSalaryPerDay.Text = "0";
            this.TxtBasicSalaryPerMonth.Text = "0";
            this.TxtDayCount.Text = "0";
            this.TxtHokmNo.Text = "0";

            this.TxtAdDay.Text = "0";
            this.TxtAdHour.Text = "0";
            this.TxtAdMinute.Text = "0";

            this.TxtSayerBed.Text = "0";
            this.TxtSayerBes.Text = "0";
            this.TxtEydi.Text = "0";
            this.TxtSanavat.Text = "0";
        }

        private void CamputeAdv()
        {
            long DayCount   = long.Parse(this.TxtDayCount.Value.ToString().Replace(",", ""));
            long Ad_D       = long.Parse(this.TxtAdDay.Value.ToString().Replace(",", ""));       
            long Ad_H       = long.Parse(this.TxtAdHour.Value.ToString().Replace(",", ""));        
            long Ad_M       = long.Parse(this.TxtAdMinute.Value.ToString().Replace(",", ""));        
            long Ad_Rls     = (Ad_D * this.BasicSalaryPerDay) + (long)(Ad_H * this.BasicSalaryPerDay / 7.333) + (long)(Ad_M * this.BasicSalaryPerDay / 7.333 / 60);
            this.TxtAdvRls.Text = Ad_Rls.ToString();
            CamputeAll();

        }
        private void TxtAdDay_ValueChanged(object sender, EventArgs e)
        {
            CamputeAdv();
        }

        private void TxtAdHour_ValueChanged(object sender, EventArgs e)
        {
            CamputeAdv();
        }

        private void TxtAdMinute_ValueChanged(object sender, EventArgs e)
        {
            CamputeAdv();
        }
        private void CamputeAll()
        {
            long Sanavat = this.TxtSanavat.Rls;
            long EydiPadash = this.TxtEydi.Rls;
            long Bed = this.TxtSayerBed.Rls;
            long Bes = this.TxtSayerBes.Rls;
            long Adv = this.TxtAdvRls.Rls;
            this.TxtSumMajaya.Text = (Sanavat + EydiPadash - Bed + Bes + Adv).ToString();
        }
        private void TxtSayerBes_TextChanged(object sender, EventArgs e)
        {
            CamputeAll();
        }

        private void TxtEydi_TextChanged(object sender, EventArgs e)
        {
            CamputeAll();
        }

        private void TxtSanavat_TextChanged(object sender, EventArgs e)
        {
            CamputeAll();
        }

        private void TxtSayerBed_TextChanged(object sender, EventArgs e)
        {
            CamputeAll();
        }

        private void FrmTasviye_Shown(object sender, EventArgs e)
        {
            if (this.ID_Pony >  0 )
            {
                using (Context Ctx = new Context())
                {
                     PonyForms pn =  Ctx.PonyForms.Find(this.ID_Pony);
                    this.TxtCodePr.Text = pn.ID_Pr.ToString();
                    this.CmbCompany.SelectedValue = pn.ID_Hokm;
                    this.TxtBasicSalaryPerDay.Text = pn.BasicSalaryPerDay.ToString();
                    this.TxtBasicSalaryPerMonth.Text = pn.BasicSalaryPerMonth.ToString();
                    this.ucDate.TxtInt = pn.Date;
                    this.TxtDayCount.Text = pn.DayCount.ToString();
                    this.TxtEydi.Text = pn.Eydi.ToString();
                    this.ucDatePicker1.TxtInt = pn.FromDate;
                    this.ucDatePicker2.TxtInt = pn.ToDate;
                    this.TxtHokmNo.Text = pn.ID_Hokm.ToString();
                    this.TxtAdDay.Text = pn.LeaveDay.ToString();
                    this.TxtAdHour.Text = pn.LeaveHour.ToString();
                    this.TxtAdMinute.Text = pn.LeaveMin.ToString();
                    this.TxtSanavat.Text = pn.Sanavat.ToString();
                    this.TxtAdvRls.Text = pn.LeaveRls.ToString();
                    this.TxtSayerBes.Text = pn.OtherAdditions.ToString();
                    this.TxtSayerBed.Text = pn.OtherDeductions.ToString();

                }
            }
        }
    }
}
