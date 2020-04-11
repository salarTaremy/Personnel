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
    public partial class FrmAddLoanItem : Permission.ClsMyForms
    {
        public FrmAddLoanItem()
        {
            InitializeComponent();
        }
        public FrmAddLoanItem(string DefaultAmount)
        {
            InitializeComponent();
            this.TxtAmount.Text = DefaultAmount;
        }

        public long Amount { get; set; }
        private void FrmAddLoanItem_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            if (! IsValidData())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private Boolean IsValidData()
        {
            if (this.TxtAmount.Rls <= 0)
            {
                Global.Dialog.ShowInfo("مبلغ وام نامعتبر است");
                return false;
            }
            return true;
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            this.Amount = this.TxtAmount.Rls;
        }
    }
}
