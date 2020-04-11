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
    public partial class FrmSyncLeave : Permission.ClsMyForms
    {
        ClsMission Ms = new ClsMission();
        ClsPersonel Person = new ClsPersonel();
        public FrmSyncLeave()
        {
            InitializeComponent();
        }

        private void FrmSyncLeave_Load(object sender, EventArgs e)
        {
            this.UcDatePicker1.SetDate(UserControls.UcDatePicker.FirstDay.FirstDayOfMonth);
            this.UcDatePicker2.SetDate(UserControls.UcDatePicker.FirstDay.LastDayOfMonth);
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

                string Msg;
                Msg = "کلیه مرخصی های سیستمی (در صورت وجود داشتن) از تاریخ '{0}' تا تاریخ '{1}' حذف و مجدادا بر مبنای کارکرد باز نویسی میشوند .";
                Msg = string.Format(Msg, this.UcDatePicker1.txt, this.UcDatePicker2.txt);
                if (this.Person.Exists)
                {
                    Msg = Msg + Environment.NewLine + " پرسنل :" + this.TxtNamePr.Text;
                }
                Msg = Msg + Environment.NewLine + "آیا مطمئن هستید ؟";
                if (Global.Dialog.ShowQuestion(Msg) == false)
                {
                    return;
                }
                int RowAffect = Ms.DoSync(this.UcDatePicker1.TxtInt, this.UcDatePicker2.TxtInt, this.Person.CodePersoneli);

                if (RowAffect > 0)
                {
                    Msg = string.Format("تعداد '{0}' مرخصی ساعتی با موفقیت ثبت شد", RowAffect);
                    Global.Dialog.ShowOK(Msg);
                    this.Close();
                }
                else
                {
                    Msg = "متاسفانه هیچ  مرخصی ثبت نشد";
                    Global.Dialog.ShowOK(Msg);
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خطا در انجام عملیات", ex.Message);
            }
        }
    }
}
