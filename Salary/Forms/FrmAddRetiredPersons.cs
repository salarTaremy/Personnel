using Ef.Entities;
using EF.Classes;
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
    public partial class FrmAddRetiredPersons : Permission.ClsMyForms
    {
        public ClsPersonel Person { get; set; }
        RetiredPersons RetiredPersons;
        public FrmAddRetiredPersons()
        {
            InitializeComponent();
            this.UcDate1.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
        }
        public FrmAddRetiredPersons(RetiredPersons RetiredPersons)
        {
            InitializeComponent();
            this.RetiredPersons = RetiredPersons;
            this.TxtCodePr.Text = RetiredPersons.ID_Pr.ToString();
            this.UcDate1.TxtInt = RetiredPersons.DateOfRetired;
            this.TxtDetail.Text = RetiredPersons.Description;
            this.TxtCodePr.Enabled = false;
            this.BtnBrows.Enabled = false;
        }

        private void FrmAddRetiredPersons_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Person.Exists)
                {
                    Global.Dialog.ShowInfo("کارمند معتبری انتخاب نشده است");
                    return;
                }
                if (Save())
                {
                    Global.Dialog.ShowOK("اطلاعات با موفقیت اصلاح  شد");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Global.Dialog.ShowInfo("متاسفانه اطلاعاتی ذخیره نشد");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("ذخیره با خطا مواجه شد", ex.Message);
            }

        }

        private Boolean Save()
        {
            try
            {
                if (this.RetiredPersons == null )
                {
                    this.RetiredPersons = new RetiredPersons() 
                    { ID_Pr = long.Parse(  this.TxtCodePr.Text) , DateOfRetired = this.UcDate1.TxtInt, Description = this.TxtDetail.Text };
                    using (Context ctx = new Context())
                    {
                        ctx.RetiredPersons.Add(this.RetiredPersons);
                         return  ctx.SaveChanges()!= 0 ;
                    }
                }
                else
                {
                    using (Context ctx = new Context())
                    {
                        RetiredPersons pr = ctx.RetiredPersons.Find(this.RetiredPersons.ID);
                        pr.DateOfRetired = this.UcDate1.TxtInt;
                        pr.Description = this.TxtDetail.Text;
                        return ctx.SaveChanges() != 0;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtCodePr_TextChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه خطایی در خواندن اطلاعات کارمند جاری بوجود آمد", ex.Message);
            }
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel ;
            this.Close();
        }
    }
}
