using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Personnely;
using System.Threading;
using UserControls;
namespace Salary.Forms
{
    public partial  class FrmHourlyMission :  Permission.ClsMyForms
    {
        ClsMission Mission = new ClsMission() ;
        ClsPersonel Person = new  ClsPersonel() ;
        ClsDialog Dialog = new ClsDialog();
        long _IDMission = 0;
        public FrmHourlyMission()
        {
            InitializeComponent();
        }
        public FrmHourlyMission(long IDMission )
        {
            _IDMission = IDMission;
            InitializeComponent();
        }
        private void FrmMission_Load(object sender, EventArgs e)
        {
            this.UcDatePicker.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
            FillCmb();
            if (_IDMission > 0)
            {
                LoadMission();
                this.BtnBrows.Enabled = false;
                this.TxtCodePr.Enabled = false ;                  
            }
        }
        private void LoadMission()
        {
            try
            {
                DataTable DtMission = new DataTable();
                DtMission = Mission.GetMission(_IDMission);
                this.TxtCodePr.Text = DtMission.Rows[0]["ID_Personel"].ToString();
                this.UcDatePicker.txt = DtMission.Rows[0]["Date"].ToString();
                this.ucTimePicker1.Txt = DtMission.Rows[0]["FromTime"].ToString();
                this.ucTimePicker2.Txt = DtMission.Rows[0]["ToTime"].ToString();
                this.CmbTypes.SelectedValue = DtMission.Rows[0]["ID_Type"];
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات نمیباشد", ex.Message);
            }
        }
        private void FillCmb()
        { 
            this.CmbTypes.ValueMember  = "ID" ;
            this.CmbTypes.DisplayMember = "Name" ;
            this.CmbTypes.DataSource =  Mission.GetAllTypes() ;
        }
        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString() ; 
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    if ( _IDMission == 0 )
                    {
                        Save();
                    }
                    else if (_IDMission > 0)
                    {
                        DoUpdate();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidData()
        {
            try
            {
                if  (string.IsNullOrEmpty(this.TxtCodePr.Text))
                {
                    Dialog.ShowInfo("لطفا کد پرسنلی را وارد کنید");
                    this.TxtCodePr.Focus();
                    return false;
                }
                if (this.UcDatePicker.TxtInt <=0)
                {
                    Dialog.ShowInfo("تاریخ نا معتبر است");
                    this.UcDatePicker.Focus();
                    return false;
                }
                if (this.ucTimePicker1.Txt == "00:00")
                {
                     Dialog.ShowInfo("ساعت شروع نا معتبر است");
                    this.ucTimePicker1.Focus();
                    return false;
                }
                if (this.ucTimePicker2.Txt == "00:00")
                {
                    Dialog.ShowInfo("ساعت خاتمه نا معتبر است");
                    this.ucTimePicker2.Focus();
                    return false;
                }
                if ( byte.Parse( CmbTypes.SelectedValue.ToString()) == 0)
                {
                    Dialog.ShowInfo("لطفا نوع ماموریت را انتخاب کنید");
                    this.ucTimePicker2.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        private void Save()
        {
            try
            {
                ClsMission Mission = new ClsMission();
                Mission.ID_Personel = Person.ID;
                Mission.Type = byte.Parse(CmbTypes.SelectedValue.ToString());
                Mission.StartTime = this.ucTimePicker1.Txt;
                Mission.EndTime = this.ucTimePicker2.Txt;
                Mission.Date = this.UcDatePicker.TxtInt;
                if (IsOverlap(Mission))
                {
                    return;
                }
                if (Mission.AddMission(Mission) > 0)
                {
                    Dialog.ShowOK("اطلاعات با موفقیت ثبت شد") ;
                    this.Close();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه اطلاعاتی ثبت نشد"); 
                }

            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("مشکلی در ذخیره اطلاعات جاری بوجود آمد", ex.Message);
                throw ex ;
            }
        }
        private void DoUpdate()
        {
            try
            {
                ClsMission Mission = new ClsMission();
                Mission.ID = _IDMission;
                Mission.ID_Personel = this.Person.ID;
                Mission.Type = byte.Parse(CmbTypes.SelectedValue.ToString());
                Mission.StartTime = this.ucTimePicker1.Txt;
                Mission.EndTime = this.ucTimePicker2.Txt;
                Mission.Date = this.UcDatePicker.TxtInt;
                if (IsOverlap(Mission))
                {
                    return;
                }
                if (Mission.UpdateMission(Mission) > 0)
                {
                    Dialog.ShowOK("اطلاعات با موفقیت ویرایش شد");
                    this.Close();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه اطلاعاتی ویرایش نشد");
                }

            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("مشکلی در ذخیره اطلاعات ویرایش شده بوجود آمد", ex.Message);
                throw ex ;
            }
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
        bool IsOverlap(ClsMission InputMiss)
        {
            try
            {
                ClsMission  Miss= new ClsMission();
                Miss = InputMiss.getOverlap(InputMiss);
                if (Miss.ID == null)
                {
                    return false;
                }
                else
                {
                    string Msg = string.Format("اطلاعات وارد شده تداخل دارد."+System.Environment.NewLine+"قبلا یک ماموریت ساعتی  به همین تاریخ در بازه زمانی'{0}' تا '{1}' ثبت شده است", Miss.StartTime , Miss.EndTime) ;
                    Dialog.ShowInfo(Msg);
                    return true;
                }
               
            }
            catch (Exception ex)
            {
                
                throw ex ;
            }
        }

         
    }
}
