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
    public partial class FrmPayAdvance : Permission.ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        ClsAdvance Adv = new ClsAdvance();
        public FrmPayAdvance()
        {
            InitializeComponent();
        }

        private void FrmPayAdvance_Load(object sender, EventArgs e)
        {
            this.UcDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsValidData()
        {
            try
            {
                if (this.Person.Exists != true)
                {
                    Global.Dialog.ShowInfo("لطفا کارمند معتبری را انتخاب کنید");
                    return false;
                }
                if (TxtAmount.Rls <= 0 )
                {
                    Global.Dialog.ShowInfo("لطفا مبلغ معتبری را وارد کنید");
                    return false;
                }
                String Msg = $"پرداخت {TxtAmount.Text} ریاب به {TxtNamePr.Text} . آیا مطمئن هستید ؟؟";
                if ( Global.Dialog.ShowQuestion(Msg) == false)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData() != true)
                {
                    return; 
                }
                ClsAdvance Adv = new ClsAdvance();
                Adv.Date = this.UcDate.TxtInt;
                Adv.ID_Person = this.Person.ID;
                Adv.Amount = this.TxtAmount.Rls;
                Adv.IsManual = true;
                if (this.TxtDetail.Text.Trim().Length > 0 )
                {
                    Adv.Detail = this.TxtDetail.Text;
                }
                if (this.Adv.AddAdvance(Adv))
                {
                    Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد");
                    this.Close();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه هیچ اطلاعاتی ذخیره نشد");
                }
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
    }
}
