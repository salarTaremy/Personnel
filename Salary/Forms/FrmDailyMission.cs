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
    public partial class FrmDailyMission : Permission.ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        ClsMission Mission = new ClsMission();
        long? _ID_DailyMission = null;
        public FrmDailyMission()
        {
            InitializeComponent();
        }
        public FrmDailyMission(long? ID_DailyMission)
        {
            InitializeComponent();
            this._ID_DailyMission = ID_DailyMission;
        }

        private void FrmDailyMission_Load(object sender, EventArgs e)
        {
            try
            {
                FillCmb();
                if (_ID_DailyMission == null)
                {
                    this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
                    this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
                    this.CmbTypes.SelectedValue = 0;
                }
                else
                {
                    BtnBrows.Enabled = false;
                    TxtCodePr.Enabled = false;
                    ClsDailyMission Dm = new ClsDailyMission();
                    Dm = Dm.Get(_ID_DailyMission);
                    this.CmbTypes.SelectedValue = Dm.ID_Type;
                    this.UcDatePicker1.TxtInt = Dm.FromDate;
                    this.UcDatePicker2.TxtInt = Dm.ToDate;
                    this.Person = Dm.Person;
                    this.TxtNamePr.Text  = Dm.Person.Name +' ' + Dm.Person.Famil ;
                }
            }
            catch (Exception ex)
            {
                   Global.Dialog.ShowErorr("بارکذاری فرم جاری با مشکل مواجه شد ", ex.Message)  ;
            }
           
        }

        private void FillCmb()
        {
            try
            {
                this.CmbTypes.ValueMember = "ID";
                this.CmbTypes.DisplayMember = "Name";
                this.CmbTypes.DataSource = Mission.GetAllTypes();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارکذاری فرم جاری با مشکل مواجه شد ", ex.Message);
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
                Global.Dialog.ShowInfo("نوع ماموریت را انتخاب کنید");
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
                    SaveMiss();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("خطا در ذخیره اطلاعات", ex.Message);
            }
        }

             private void SaveMiss()
        {
            try
            {
                ClsDailyMission Dm = new ClsDailyMission();
                Dm.ID = _ID_DailyMission;
                Dm.ID_Type = (byte)this.CmbTypes.SelectedValue;
                Dm.FromDate = this.UcDatePicker1.TxtInt;
                Dm.ToDate = this.UcDatePicker2.TxtInt;
                Dm.Person = this.Person;
                if (Dm.Save(Dm) > 0)
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
