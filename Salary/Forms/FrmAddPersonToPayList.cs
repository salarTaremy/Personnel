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
    public partial class FrmAddPersonToPayList : Permission.ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        public PayResult Result { get; set; }
        public int MyProperty { get; set; }

        public bool IsValidData()
        {
            if (this.Person.Exists == false)
            {
                Global.Dialog.ShowInfo("کامند نا معتبر است");
                return false;
            }
            if (this.TxtAmount.Rls <= 0 )
            {
                Global.Dialog.ShowInfo("مبلغ نا معتبر است");
                return false;
            }
            return true;
        }

        public FrmAddPersonToPayList()
        {
            InitializeComponent();
        }

        private void FrmAddPersonToPayList_Load(object sender, EventArgs e)
        {

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (!IsValidData())
            {
                return;
            }
            Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Save()
        {
            try
            {
                this.Result = new PayResult { Description = this.TxtDetail.Text, ID_Person = this.Person.ID, Price = this.TxtAmount.Rls };

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public class PayResult
        {
            public long? ID_MorePay { get; set; }
            public long ID_Person { get; set; }
            public long Price { get; set; }
            public string Description { get; set; }

        }

    }
}
