using EF.Classes;
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
    public partial class FrmManageTasviye : ClsMyForms
    {
        ClsPersonel Person = new ClsPersonel();
        public FrmManageTasviye()
        {
            InitializeComponent();
        }

        private void FrmManageTasviye_Load(object sender, EventArgs e)
        {

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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmTasviye Frm = new FrmTasviye();
            Frm.ShowDialog();
            if (Frm.DialogResult == DialogResult.OK)
            {
                FillGrd();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("خطا در خواندن اطلاعات", ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                DataTable DtPony;
                if (this.Person.Exists)
                {
                    DtPony = ClsPony.GetAll(this.Person.ID);
                }
                else {
                    DtPony = ClsPony.GetAll();
                }
                this.Grd.DataSource = DtPony;
                this.Grd.Columns["ID_Pony"].HeaderText = "شماره تسویه";
                this.Grd.Columns["ID_Pr"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام ونام خانوادگی";
                this.Grd.Columns["ID_Hokm"].HeaderText = "شماره حکم مبنا";
                this.Grd.Columns["Date"].HeaderText = "تاریخ";
                this.Grd.Columns["FromDate"].HeaderText = "از تاریخ";
                this.Grd.Columns["ToDate"].HeaderText = "تا تاریخ";
                this.Grd.Columns["BasicSalaryPerDay"].HeaderText = "حقوق پایه روزانه";
                this.Grd.Columns["BasicSalaryPerMonth"].HeaderText = "حقوق پایه ماهانه";
                this.Grd.Columns["DayCount"].HeaderText = "کارکرد روزانه";
                this.Grd.Columns["LeaveDay"].HeaderText = "مرخصی-روز";
                this.Grd.Columns["LeaveHour"].HeaderText = "مرخصی- ساعت";
                this.Grd.Columns["LeaveMin"].HeaderText = "مرخصی -دقیقه";
                this.Grd.Columns["LeaveRls"].HeaderText = "مبلغ باز خرید مرخصی";
                this.Grd.Columns["OtherAdditions"].HeaderText = "سایر بستانکاری ها ";
                this.Grd.Columns["OtherDeductions"].HeaderText = "سایر بدهی ها";
                this.Grd.Columns["Eydi"].HeaderText = "عیدی پاداش";
                this.Grd.Columns["Sanavat"].HeaderText = "باز خرید سنوات";
                this.Grd.Columns["Company"].HeaderText = "نام شرکت";
                this.Grd.Columns["NameKargah"].HeaderText = "نام کارگاه";

                this.Grd.Columns["ID_Pony"].Width = 88;
                this.Grd.Columns["ID_Pr"].Width = 75;
                this.Grd.Columns["FullName"].Width = 110;
                this.Grd.Columns["ID_Hokm"].Width = 102;
                this.Grd.Columns["Date"].Width = 76;
                this.Grd.Columns["Fromdate"].Width = 77;
                this.Grd.Columns["ToDate"].Width = 73;
                this.Grd.Columns["BasicSalaryPerDay"].Width = 124;
                this.Grd.Columns["BasicSalaryPerMonth"].Width = 139;
                this.Grd.Columns["DayCount"].Width = 95;
                this.Grd.Columns["LeaveDay"].Width = 95;
                this.Grd.Columns["LeaveHour"].Width = 106;
                this.Grd.Columns["LeaveMin"].Width = 93;
                this.Grd.Columns["LeaveRls"].Width = 126;
                this.Grd.Columns["OtherAdditions"].Width = 120;
                this.Grd.Columns["OtherDeductions"].Width = 130;
                this.Grd.Columns["Eydi"].Width = 67;
                this.Grd.Columns["Sanavat"].Width = 86;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FrmManageTasviye_Shown(object sender, EventArgs e)
        {
            FillGrd();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.DataSource == null)
                {
                    return;
                }
                if (this.Grd.Rows.Count == 0)
                {
                    return;
                }
                if (this.Grd.CurrentRow == null)
                {
                    return;
                }
                if (Global.Dialog.ShowQuestion("برای حذف مطمئن هستید ؟؟") == false )
                {
                    return; 
                }


                long ID_Pony = (long)this.Grd.CurrentRow.Cells["ID_Pony"].Value;
                int RowAffect = 0;
                using (Context ctx = new Context())
                {
                    var x = ctx.PonyForms.Find(ID_Pony);
                    ctx.PonyForms.Remove(x);
                    RowAffect = ctx.SaveChanges();
                }
                if (RowAffect > 0 )
                {
                    Global.Dialog.ShowOK("اطلاعات با موفقیت حذف شد");
                    FillGrd();
                }
                else
                {
                    Global.Dialog.ShowInfo("هیچ داده ای حذف نشد");
                }

            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("خطا در حذف اطلاعات", ex.Message);
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.Grd.DataSource == null)
            {
                return;
            }
            if (this.Grd.Rows.Count == 0)
            {
                return;
            }
            if (this.Grd.CurrentRow == null)
            {
                return;
            }
            long ID_Pony = (long)this.Grd.CurrentRow.Cells["ID_Pony"].Value;
            FrmTasviye Frm = new FrmTasviye(  ID_Pony );
            Frm.ShowDialog();
            if (Frm.DialogResult == DialogResult.OK)
            {
                FillGrd();
            }
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            if (this.Grd.DataSource == null)
            {
                return;
            }
            if (this.Grd.Rows.Count == 0)
            {
                return;
            }
            if (this.Grd.CurrentRow == null)
            {
                return;
            }
            long ID_Pony = (long)this.Grd.CurrentRow.Cells["ID_Pony"].Value;
            FrmTasviye Frm = new FrmTasviye(ID_Pony);
            Frm.BtnSave.Enabled = false;
            Frm.BtnBrows.Enabled = false;
            Frm.TxtCodePr.Enabled = false;
            Frm.ShowDialog();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Common.StiReport Rep = new Common.StiReport();
            for (int i = 0; i < Grd.Columns.Count; i++)
            {
                string ColName = this.Grd.CurrentRow.Cells[i].ColumnInfo.Name;
                string Value = this.Grd.CurrentRow.Cells[i].Value.ToString();
                Rep.AddVariable(ColName, Value);
            }
            Rep.AddDatasource(this.Grd.DataSource);
            Rep.Show();
        }
    }

}
