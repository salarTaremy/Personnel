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
    public partial class FrmAdvanceBlacklist : Permission.ClsMyForms
    {
        public FrmAdvanceBlacklist()
        {
            InitializeComponent();
        }
        ClsAdvance Adv = new ClsAdvance();
        private void FrmAdvanceBlacklist_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
            }
            catch (Exception Ex)
            {
                Global.Dialog.ShowErorr("خطایی در بارگذاری فرم جاری رخ داد", Ex.Message);
            }
        }

        private void FillGrd()
        {
            try
            {
                this.Grd.DataSource = this.Adv.GetBlackList();
                this.Grd.Columns["Chk"].HeaderText = "انتخاب";
                this.Grd.Columns["ID"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام و نام خانوادگی";
                this.Grd.Columns["Chk"].Width = 46;
                this.Grd.Columns["ID"].Width = 100;
                this.Grd.Columns["FullName"].Width = 448;
                this.Grd.Columns["ID"].ReadOnly = true;
                this.Grd.Columns["FullName"].ReadOnly = true;
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                DT.Columns.Add("Value", typeof(long));
                DataRow Dr;
                for (int i = 0; i < this.Grd.Rows.Count; i++)
                {
                    if (Convert.ToBoolean( this.Grd.Rows[i].Cells["Chk"].Value))
                    {
                        Dr = DT.NewRow();
                        Dr["Value"] = (long)this.Grd.Rows[i].Cells["ID"].Value;
                        DT.Rows.Add(Dr);
                    }
                }
                int RowAffect = this.Adv.AddBlackList(DT);
                if (RowAffect > 0 )
                {
                    Global.Dialog.ShowOK($"تعداد{RowAffect} نفر با موفقیت ثبت شد");
                }
                else
                {
                    Global.Dialog.ShowInfo("هیچ فردی به لیست عدم پرداخت  اضافه نشد");
                }

            }
            catch (Exception Ex )
            {
                Global.Dialog.ShowErorr("خطایی در  ذخیره اطلاعات  لیست پرسنل رخ داد", Ex.Message);
            }
        }

        private void ChkAll_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            for (int i = 0; i < this.Grd.Rows.Count; i++)
            {
                this.Grd.Rows[i].Cells["Chk"].Value = this.ChkAll.Checked;
            }
        }
    }
}
