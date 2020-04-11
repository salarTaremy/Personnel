using Personnely;
using Salary.Classes;
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
    public partial class FrmAddPersonToBlackList : Permission.ClsMyForms
    {
        public ClsPersonel Person { get; set; }
        public FrmAddPersonToBlackList()
        {

            InitializeComponent();
        }

        private void FrmAddPersonToBlackList_Load(object sender, EventArgs e)
        {
            this.Person = new ClsPersonel();
            FillCmb();
        }
        private void FillCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = short.Parse(Common.SalMali.Value);
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("بارگذاری اطلاعات  سال مالی و ماه ها با خطا مواجه شد", ex.Message);
            }
        }
        private void BtnCancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.Person.Exists)
                {
                    Global.Dialog.ShowInfo("کارمند معتبری انتخاب نشده است");
                    return;
                }

                ClsBlackListPerson Bl = new ClsBlackListPerson();
                short IdMonthOfSalary = (short)this.Cmb_Month.SelectedValue;
                bool IsAdd = Bl.AddToBlackList(this.Person.ID, IdMonthOfSalary);
                if (IsAdd)
                {
                    this.DialogResult = DialogResult.OK;
                    Global.Dialog.ShowOK("اطلاعات با موفقیت ذخیره شد");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه خطایی در ذخیره اطلاعات کارمند جاری بوجود آمد", ex.Message);
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
        private void CmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ClsMonthOfSalary M = new ClsMonthOfSalary();
                this.Cmb_Month.DataSource = null;
                this.Cmb_Month.ValueMember = "ID";
                this.Cmb_Month.DisplayMember = "MonthName";
                this.Cmb_Month.DataSource = M.GetAll((short)this.CmbYear.SelectedValue);
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن اطلاعات ماه های حقوقی با خطا مواجه شد", ex.Message);
            }
        }

        private void BtnBrows_Click(object sender, EventArgs e)
        {
            this.TxtCodePr.Text = this.Person.SelectPersonID().ToString();
        }
    }
}
