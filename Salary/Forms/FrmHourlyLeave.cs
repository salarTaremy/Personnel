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
    public partial class FrmHourlyLeave : Permission.ClsMyForms
    {
        
        ClsLeave LV = new ClsLeave();
        ClsPersonel Person = new ClsPersonel();
        ClsDialog Dialog = new ClsDialog();
        long _IDLeave = 0;
        public FrmHourlyLeave()
        {
            InitializeComponent();
        }
           public FrmHourlyLeave(long IDLeave)
        {
            _IDLeave = IDLeave;
            InitializeComponent();
        }
     

        private void FrmLeave_Load(object sender, EventArgs e)
        {
            this.UcDatePicker.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
            FillCmb();
            if (_IDLeave > 0)
            {
                LoadLeave();
                this.BtnBrows.Enabled = false;
                this.TxtCodePr.Enabled = false;
            }
        }
        private void FillCmb()
        {
            this.CmbTypes.ValueMember = "ID";
            this.CmbTypes.DisplayMember = "Name";
            this.CmbTypes.DataSource = LV.GetAllTypes();
        }
        private void LoadLeave()
        {
            try
            {
                DataTable DtLeave = new DataTable();
                DtLeave = LV.GetLeave(_IDLeave);
                this.TxtCodePr.Text = DtLeave.Rows[0]["ID_Personel"].ToString();
                this.UcDatePicker.txt = DtLeave.Rows[0]["Date"].ToString();
                this.ucTimePicker1.Txt = DtLeave.Rows[0]["FromTime"].ToString();
                this.ucTimePicker2.Txt = DtLeave.Rows[0]["ToTime"].ToString();
                this.CmbTypes.SelectedValue = DtLeave.Rows[0]["ID_Type"];
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات نمیباشد", ex.Message);
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    if (_IDLeave == 0)
                    {
                        Save();
                    }
                    else if (_IDLeave > 0)
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
                if (string.IsNullOrEmpty(this.TxtCodePr.Text))
                {
                    Dialog.ShowInfo("لطفا کد پرسنلی را وارد کنید");
                    this.TxtCodePr.Focus();
                    return false;
                }
                if (this.UcDatePicker.TxtInt <= 0)
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
                if (byte.Parse(CmbTypes.SelectedValue.ToString()) == 0)
                {
                    Dialog.ShowInfo("لطفا نوع مرخصی را انتخاب کنید");
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
                ClsLeave Leave = new ClsLeave();
                Leave.ID_Personel = Person.ID;
                Leave.Type = byte.Parse(CmbTypes.SelectedValue.ToString());
                Leave.StartTime = this.ucTimePicker1.Txt;
                Leave.EndTime = this.ucTimePicker2.Txt;
                Leave.Date = this.UcDatePicker.TxtInt;
                if (IsOverlap(Leave))
                {
                    return;
                }
                if (Leave.AddLeave(Leave) > 0)
                {
                    Dialog.ShowOK("اطلاعات با موفقیت ثبت شد");
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
                ClsLeave Leave = new ClsLeave();
                Leave.ID = _IDLeave;
                Leave.ID_Personel = this.Person.ID;
                Leave.Type = byte.Parse(CmbTypes.SelectedValue.ToString());
                Leave.StartTime = this.ucTimePicker1.Txt;
                Leave.EndTime = this.ucTimePicker2.Txt;
                Leave.Date = this.UcDatePicker.TxtInt;
                if (IsOverlap(Leave))
                {
                    return;
                }
                if (Leave.UpdateLeave(Leave) > 0)
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
        bool IsOverlap(ClsLeave InputLeave)
        {
            try
            {
                ClsLeave Leave = new ClsLeave();
                Leave = InputLeave.getOverlap(InputLeave);
                if (Leave.ID == null)
                {
                    return false;
                }
                else
                {
                    string Msg = string.Format("اطلاعات وارد شده تداخل دارد." + System.Environment.NewLine + "قبلا یک مرخصی ساعتی  به همین تاریخ در بازه زمانی'{0}' تا '{1}' ثبت شده است", Leave.StartTime, Leave.EndTime);
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
