using Common;
using Personnely;
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

namespace Salary.Forms
{
    public partial class FrmTaxList : Permission.ClsMyForms
    {

        Personnely.ClsPersonBase.Kargah Kargah = new Personnely.ClsPersonBase.Kargah();
        ClsMonthOfSalary MY = new ClsMonthOfSalary();
        short IDMonthOfSalary;
        byte IDCompany;
        long IDKargah;
        long IDKargahEx;
        short IDMahalKHedmat;
        public FrmTaxList()
        {
            InitializeComponent();
        }

        private void FrmTaxList_Load(object sender, EventArgs e)
        {
            FillAllCmb();
        }
        private void FillAllCmb()
        {
            Common.SalMali SalMali = new Common.SalMali();
            this.CmbYear.ValueMember = "ID";
            this.CmbYear.DisplayMember = "Name";
            this.CmbYear.DataSource = SalMali.GetSalMali();
            this.CmbYear.SelectedValue = Global.SalMali;
            //══════════ 2 ══════════
            ClsPersonBase.MahaleKhedmat MK = new ClsPersonBase.MahaleKhedmat();
            this.CmbMahalleKhedmat.DisplayMember = "Name";
            this.CmbMahalleKhedmat.ValueMember = "ID";
            this.CmbMahalleKhedmat.DataSource = MK.GetAll();
            //══════════ 3 ══════════
            ClsGeneral.Company Cmp = new ClsGeneral.Company();
            this.CmbCompany.DisplayMember = "Name";
            this.CmbCompany.ValueMember = "ID";
            this.CmbCompany.DataSource = Cmp.GetAll();
            //══════════ 4 ══════════
            this.CmbKargah.DisplayMember = "Name";
            this.CmbKargah.ValueMember = "ID";
            //this.CmbKargah.DataSource = Kargah.GetAll()
            //══════════ 5 ══════════
            this.CmbKargahEx.DisplayMember = "Name";
            this.CmbKargahEx.ValueMember = "ID";
            //this.CmbKargahEx.DataSource = Kargah.GetAll();

        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.CmbKargahEx.DataSource = Kargah.GetAll((byte)this.CmbCompany.SelectedValue);
        }

        private void CmbYear_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!(CmbMonthA.SelectedItem is null || CmbYear.SelectedItem is null))
            {
                BtnDisket.Text = BtnDisket.Tag + Environment.NewLine + CmbMonthA.SelectedItem.ToString() + " ماه " + CmbYear.SelectedItem.ToString();

            }
            short Year = (short)this.CmbYear.SelectedValue;

            this.CmbMonthA.DataSource = null;
            this.CmbMonthA.ValueMember = "ID";
            this.CmbMonthA.DisplayMember = "MonthName";
            this.CmbMonthA.DataSource = MY.GetAll(Year);
            this.CmbMonthA.SelectedIndex = 0;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid() == false)
                {
                    return;
                }
                setVariable();

                //this.IDKargahEx = long.Parse(this.CmbKargahEx.SelectedValue.ToString());
                //this.IDMahalKHedmat = (short)this.CmbMahalleKhedmat.SelectedValue;
                FillGrd();
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("مشکلی در محاسبه لیست بیمه بوجودآمده است", ex.Message);
            }
        }

        private void setVariable()
        {
            this.IDMonthOfSalary = short.Parse(this.CmbMonthA.SelectedValue.ToString());
            this.IDCompany = (byte)this.CmbCompany.SelectedValue;
            this.IDKargah = long.Parse(this.CmbKargah.SelectedValue.ToString());
        }

        private void FillGrd()
        {
            try
            {
                ClsTax tax = new ClsTax();
                DataSet DsTax = tax.GetList(this.IDMonthOfSalary, this.IDCompany, this.IDKargah);
                this.Grd_WP.DataSource = DsTax.Tables[0];
                this.Grd_WH.DataSource = DsTax.Tables[1];
                this.Grd_WK.DataSource = DsTax.Tables[2];
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        private bool IsValid()
        {
            return true;
        }

        private void BtnDisket_Click(object sender, EventArgs e)
        {
            try
            {
                setVariable();

                //string WP = DtToString((DataTable)this.Grd_WP.DataSource);
                //string WH = DtToString((DataTable)this.Grd_WH.DataSource);
                //string WK = DtToString((DataTable)this.Grd_WK.DataSource);
                short ID_MonthOfSalary = (short)this.CmbMonthA.SelectedValue;
                ClsMonthOfSalary Ms = new ClsMonthOfSalary(ID_MonthOfSalary);
                string Year = this.CmbYear.SelectedValue.ToString();
                string Month =   String.Concat("0", Ms.ID_Month.ToString());
                Month = Month.Substring(Month.Length - 2);
                string FileExtension = $"{Year}{Month}.txt";
                ClsTax tax = new ClsTax();
                DataTable taxGroups = tax.GetDisketeGroups();

                Boolean hasSavedFiles = false;

                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();


                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {

                        for (int i = 0; i < taxGroups.Rows.Count; i++)
                        {
                            string dirForGroup = Path.Combine(fbd.SelectedPath, taxGroups.Rows[i]["En_NameKargah"].ToString());
                            if(Directory.Exists(dirForGroup)==false)
                            {
                                Directory.CreateDirectory(dirForGroup);
                            }


                            DataSet DsTax = tax.GetListTotal(this.IDMonthOfSalary,byte.Parse( taxGroups.Rows[i]["id_company"].ToString()) , taxGroups.Rows[i]["csv_Group_Folder"].ToString());
                            //this.Grd_WP.DataSource = DsTax.Tables[0];
                            //this.Grd_WH.DataSource = DsTax.Tables[1];
                            //this.Grd_WK.DataSource = DsTax.Tables[2];

                            Directory.CreateDirectory(System.IO.Path.Combine(fbd.SelectedPath, ""));
                            File.WriteAllText(Path.Combine(dirForGroup ,"WP" + FileExtension), DtToString(DsTax.Tables[0]), Encoding.UTF8);
                            File.WriteAllText(Path.Combine(dirForGroup ,"WH" + FileExtension), DtToString(DsTax.Tables[1]), Encoding.UTF8);
                            File.WriteAllText(Path.Combine(dirForGroup ,"WK" + FileExtension), DtToString(DsTax.Tables[2]), Encoding.UTF8);
                            hasSavedFiles = true;
                        }
                    }
                }
                if (hasSavedFiles)
                {
                    Global.Dialog.ShowOK("فایلهای مربوط به مالیات به تفکیک مراکز در فولدر انتخاب شده قرار گرفت");
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("ذخیره فایل با خطا مواجه شد", ex.Message);
            }
        }

        private string DtToString(DataTable dt ,bool WithColumnName = false)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (WithColumnName)
                {
                    IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                  Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));
                }
                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(",", fields));
                }
                return sb.ToString();
                //File.WriteAllText("test.csv", sb.ToString());
            }
            catch (Exception ex )
            {
                throw ex;
            }
            
            
        }

        private void CmbMonthA_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!(CmbMonthA.SelectedItem is null || CmbYear.SelectedItem is null))
            {
                BtnDisket.Text = BtnDisket.Tag + " " + CmbMonthA.SelectedItem.ToString() + " ماه " + CmbYear.SelectedItem.ToString();

            }
        }

        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {

        }
    }
}
