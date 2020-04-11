using Salary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Salary.Classes.ClsAccontNO;

namespace Salary.Forms
{
    public partial class FrmDisketBank : Permission.ClsMyForms
    {

        List<ClsAccontNO> _AccLst;
        public FrmDisketBank( List<ClsAccontNO> Lst     ) 
        {
            this._AccLst = Lst;
            InitializeComponent();
        }

        private void FrmDisketBank_Load(object sender, EventArgs e)
        {

        }

        private string GetFilterDialog()
        {
            try
            {
                if (this.RadMellat.Checked)
                {
                     return "فایل بانک ملت (*.PAY)|*.Pay";
                }
                if (this.RadMelli.Checked)
                {
                    return "همه فایلها(*.*)|*.*";
                }
                if (this.RadSepah.Checked)
                {
                    return "فایل بانک سپه (*.FD)|*.FD";
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void BtnOKClick(object sender, EventArgs e)
        {
            try
            {
                string StrFile = GetStringFile();
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = GetFilterDialog();
                    sfd.FilterIndex = 2;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, StrFile, Encoding.ASCII);
                        this.Close();
                    }
                }
            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("ذخیره فایل با خطا مواجه شد", ex.Message);
            }
        }

        private string GetStringFile()
        {
            try
            {
                string BankNoSepah = "02358000395030000000000+1";
                int AccLen;
                int balanceLen;
                StringBuilder StrFile;
                if (this.RadMellat.Checked)
                {
                    StrFile = new StringBuilder();
                    AccLen = 10;
                    balanceLen = 15;
                    long sum = 0;
                    int count = 0;
                    foreach (var Acc in _AccLst)
                    {
                        if (Acc.Bank == EnumBank.Mellat)
                        {
                            sum += (long)Acc.Balance;
                            count += 1;
                            StrFile.Append($"{Acc.AccontNo.PadLeft(AccLen, '0')}{Acc.Balance.ToString().PadLeft(balanceLen, '0')}");
                            StrFile.AppendLine();
                        }
                    }
                    return count.ToString().PadLeft(AccLen, '0') + sum.ToString().PadLeft(balanceLen, '0') + Environment.NewLine + StrFile;
                }
                if (this.RadMelli.Checked)
                {

                }
                if (this.RadSepah.Checked)
                {
                    StrFile = new StringBuilder();
                    StrFile.Append(BankNoSepah);
                    StrFile.AppendLine();
                    AccLen = 13;
                    balanceLen = 10;
                    foreach (var Acc in _AccLst)
                    {
                        if (Acc.Bank == EnumBank.Sepah)
                        {
                            StrFile.Append($"{Acc.AccontNo.PadLeft(AccLen, '0')}{Acc.Balance.ToString().PadLeft(balanceLen, '0')}");
                            StrFile.Append("+1");
                            StrFile.AppendLine();
                        }
                    }
                    return StrFile.ToString();
                }
                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
