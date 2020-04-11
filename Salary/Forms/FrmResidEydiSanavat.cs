using Common;
using Permission;
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
    public partial class FrmResidEydiSanavat : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        ClsPersonBase.Kargah kargah = new ClsPersonBase.Kargah();
        public FrmResidEydiSanavat()
        {
            InitializeComponent();
        }

        private void FrmResidEydiSanavat_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void FillCmb()
        {
            Common.SalMali SalMali = new Common.SalMali();
            this.CmbYear.DisplayMember = "Name";
            this.CmbYear.ValueMember = "ID";
            this.CmbYear.DataSource = SalMali.GetSalMali();
            this.CmbYear.SelectedValue = short.Parse(Common.SalMali.Value);
            //══════════ 2 ══════════
            ClsGeneral.Company Cmp = new ClsGeneral.Company();
            this.CmbCompany.DisplayMember = "Name";
            this.CmbCompany.ValueMember = "ID";
            this.CmbCompany.DataSource = Cmp.GetAll();
            //══════════  ══════════
            this.CmbKargah.DisplayMember = "Name";
            this.CmbKargah.ValueMember = "ID";
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


        private DataTable GetDtID()
        {
            DataRow Dr;
            DataTable ReturnDt = new DataTable();
            ReturnDt.Columns.Add("ID_Person", typeof(long));
            ReturnDt.Columns.Add("FullName", typeof(string));
            ReturnDt.Columns.Add("RlsEydi", typeof(long));
            ReturnDt.Columns.Add("RlsSanavat", typeof(long));
            for (int i = 0; i < this.Grd.SelectedRows.Count; i++)
            {
  
                Dr = ReturnDt.NewRow();
                Dr[0] = (long)this.Grd.SelectedRows[i].Cells["ID_Person"].Value;
                Dr[1] = (string)this.Grd.SelectedRows[i].Cells["FullName"].Value;
                Dr[2] = (long)this.Grd.SelectedRows[i].Cells["RlsEydi"].Value;
                Dr[3] = (long)this.Grd.SelectedRows[i].Cells["RlsSanavat"].Value;
                ReturnDt.Rows.Add(Dr);
            }
            return ReturnDt;
        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
            if (this.Grd.SelectedRows.Count == 0)
            {
                Global.Dialog.ShowInfo("لطفا یکی از موارد را انتخاب کنید");
                return;
            }
            DataTable DtSelected = new DataTable();
            DtSelected = GetDtID();

            StiReport Rep = new Common.StiReport();


            Rep.AddVariable("Year", this.CmbYear.SelectedValue.ToString());
            Rep.AddVariable("Company", this.CmbCompany.SelectedText);

            Rep.AddDatasource(this.Grd.DataSource,"Total");
            Rep.AddDatasource(DtSelected,"Selected");
            Rep.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            FillGrd();
        }

        private void FillGrd()
        {
            try
            {
                ClsEydiSanavat Ed = new ClsEydiSanavat();
                DataTable dt;
                short Year = (short)this.CmbYear.SelectedValue;
                long ID_Kargah = (long)this.CmbKargah.SelectedValue;

                if (this.Person.Exists)
                {
                    dt = Ed.GetKholase(Year, ID_Kargah, Person.ID);
                }
                else
                {
                    dt = Ed.GetKholase(Year, ID_Kargah);
                }

                this.Grd.DataSource = dt;



                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام  کارمند";
                this.Grd.Columns["RlsEydi"].HeaderText = "دریافتی عیدی";
                this.Grd.Columns["RlsSanavat"].HeaderText = "دریافتی سنوات";
                this.Grd.Columns["CountEydi"].HeaderText = "تعداد دریافت عیدی";
                this.Grd.Columns["CountSanavat"].HeaderText = "تعداد دریافت سنوات";
                this.Grd.Columns["DayCountEydi"].HeaderText = "تعداد روز  عیدی";
                this.Grd.Columns["DayCountSanavat"].HeaderText = "تعداد روز سنوات";

                this.Grd.Columns["ID_Person"].Width = 65;
                this.Grd.Columns["FullName"].Width = 290;
                this.Grd.Columns["RlsEydi"].Width = 160;
                this.Grd.Columns["RlsSanavat"].Width = 160;
                this.Grd.Columns["CountEydi"].Width = 135;
                this.Grd.Columns["CountSanavat"].Width = 135;
                this.Grd.Columns["DayCountEydi"].Width = 115;
                this.Grd.Columns["DayCountSanavat"].Width = 115;

                this.Grd.Columns["RlsEydi"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["RlsSanavat"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["CountEydi"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["CountSanavat"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["DayCountEydi"].FormatString = "{0:#,###,##0;(#,###,0)}";
                this.Grd.Columns["DayCountSanavat"].FormatString = "{0:#,###,##0;(#,###,0)}";




            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("خطا در خواندن اطلاعات", ex.Message);
            }
        }

        private void CmbCompany_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.CmbKargah.DataSource = kargah.GetAll((byte)this.CmbCompany.SelectedValue);
            this.Grd.DataSource = null;
        }
    }
}

