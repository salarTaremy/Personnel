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
    public partial class FrmPayOther :  Permission.ClsMyForms
    {
        public FrmPayOther()
        {
            InitializeComponent();
        }

        private void BtnAddNewRow_Click(object sender, EventArgs e)
        {
            FrmAddPersonToPayList Frm = new FrmAddPersonToPayList();
            Frm.ShowDialog();
            if (Frm.DialogResult == DialogResult.OK)
            {
                AddNewRow(Frm.Result);
            }
        }
        private void FormatGrid()
        {
            try
            {
                this.Grd.Columns["ID_MorePay"].ReadOnly = true;
                this.Grd.Columns["ID_Person"].ReadOnly = true;
                this.Grd.Columns["Price"].ReadOnly = true;
                this.Grd.Columns["Description"].ReadOnly = true;

                this.Grd.Columns["ID_MorePay"].IsVisible = false;
                this.Grd.Columns["Price"].FormatString = "{0:#,###,##0;(#,###,0)}";

                this.Grd.Columns["ID_MorePay"].HeaderText = "شماره پرداخت";
                this.Grd.Columns["ID_Person"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["Price"].HeaderText = "مبلغ";
                this.Grd.Columns["Description"].HeaderText = "توضیحات";

                this.Grd.Columns["ID_MorePay"].Width = 95;
                this.Grd.Columns["ID_Person"].Width = 135;
                this.Grd.Columns["Price"].Width = 115;
                this.Grd.Columns["Description"].Width = 470;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void AddNewRow(FrmAddPersonToPayList.PayResult Obj )
        {
            try
            {
                if (this.Grd.Rows.Count == 0 || this.Grd.DataSource == null)
                {
                    this.Grd.DataSource = this.GetDtItems();
                    FormatGrid();
                }
                int Index = this.Grd.Rows.Count;
                this.Grd.Rows.AddNew();
                this.Grd.Rows[Index].Cells["ID_MorePay"].Value = Obj.ID_MorePay;
                this.Grd.Rows[Index].Cells["ID_Person"].Value = Obj.ID_Person;
                this.Grd.Rows[Index].Cells["Price"].Value = Obj.Price;
                this.Grd.Rows[Index].Cells["Description"].Value = Obj.Description;

            }
            catch (Exception ex )
            {

                throw ex ;
            }
        }
        private DataTable GetDtItems()
        {
            try
            {


                DataTable Dt = new DataTable();
                Dt.Columns.Add("ID_MorePay", typeof(int));
                Dt.Columns.Add("ID_Person", typeof(long));
                Dt.Columns.Add("Price", typeof(long));
                Dt.Columns.Add("Description", typeof(string));
                return Dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmPayOther_Load(object sender, EventArgs e)
        {
            this.UcDate.SetDate(UserControls.UcDatePicker.FirstDay.ToDay);
        }

        private void BtnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.Rows.Count <= 0)
                {
                    return;
                }
                if (this.Grd.CurrentRow == null)
                {
                    return;
                }
                this.Grd.CurrentRow.Delete();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr(" حذف با خطا مواجه شد", Ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr(" ذخیره  با خطا مواجه شد", ex.Message);
            }
        }

        private void Save()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
