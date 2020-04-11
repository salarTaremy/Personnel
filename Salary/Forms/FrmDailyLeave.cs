using Personnely;
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
    public partial class FrmDailyLeave :Permission.ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        ClsLeave Leave = new ClsLeave();
        long? _ID_DailyLeave = null;
        public FrmDailyLeave()
        {
            InitializeComponent();
        }
        public FrmDailyLeave(long?  ID_DailyLeave)
        {
            InitializeComponent();
            this._ID_DailyLeave = ID_DailyLeave;
        }
        private void FormDailyMissiom_Load(object sender, EventArgs e)
        {
            try
            {
                FillCmb();
                if (_ID_DailyLeave == null)
                {
                    this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
                    this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
                    this.CmbTypes.SelectedValue = 0;
                }
                else
                {
                    BtnBrows.Enabled = false;
                    TxtCodePr.Enabled = false;
                    ClsDailyLeave DL = new ClsDailyLeave();
                    DL = DL.Get(_ID_DailyLeave);
                    this.CmbTypes.SelectedValue = DL.ID_Type;
                    this.UcDatePicker1.TxtInt = DL.FromDate;
                    this.UcDatePicker2.TxtInt = DL.ToDate;
                    this.Person = DL.Person;
                    this.TxtNamePr.Text = DL.Person.Name + ' ' + DL.Person.Famil;
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارکذاری فرم جاری با مشکل مواجه شد ", ex.Message);

            }
        }

        
                   private void FillCmb()
        {
            try
            {
                this.CmbTypes.ValueMember = "ID";
                this.CmbTypes.DisplayMember = "Name";
                this.CmbTypes.DataSource = Leave.GetAllTypes();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری فرم جاری با مشکل مواجه شد ", ex.Message);
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

                private Boolean ValidData()
        {
            if (int.Parse(this.CmbTypes.SelectedValue.ToString()) == 0)
            {
                Global.Dialog.ShowInfo("نوع مرخصی را انتخاب کنید");
                return false;
            }
            if (Person.Exists == false)
            {
                 Global.Dialog.ShowInfo("لطفا کارمند معتبری را انتخاب کنید");
                return false;
            }
            return  true ;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {   
            try
            {
                if (ValidData() == false)
                {
                    return;
                }
                else
                {
                    SaveLeave();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("خطا در ذخیره اطلاعات", ex.Message);
            }
        
        }

        private void SaveLeave()
        {
 	           try
            {
                ClsDailyLeave DL = new ClsDailyLeave();
                DL.ID = _ID_DailyLeave;
                DL.ID_Type = (byte)this.CmbTypes.SelectedValue;
                DL.FromDate = this.UcDatePicker1.TxtInt;
                DL.ToDate = this.UcDatePicker2.TxtInt;
                DL.Person = this.Person;
                if (DL.Save(DL) > 0)
                {
                    Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد");
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ رکوردی ذخیره نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارکذاری فرم جاری با مشکل مواجه شد ", ex.Message);
            }
        }


    }
}
