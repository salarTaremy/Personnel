using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Salary.Classes;

namespace Salary.Forms
{
    public partial class FrmAddEditAdvance : Permission.ClsMyForms
    {
        public byte? ID { get; set; }
        ClsAdvance Adv = new ClsAdvance();
        public FrmAddEditAdvance()
        {
            InitializeComponent();
        }
        public FrmAddEditAdvance(byte ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void FrmAddEditAdvance_Load(object sender, EventArgs e)
        {
            try
            {
                FillGrd();
                LoadAdv();
            }
            catch (Exception ex)
            {

                throw ex ;
            }
        }
        private void FillGrd()
        {
            this.Grd.DataSource = this.Adv.GetAllField();
            this.Grd.Columns["ID"].IsVisible = false;
            this.Grd.Columns["FieldName"].Width = 200;
            this.Grd.Columns["PersianFieldName"].Width = 200;
            this.Grd.Columns["FieldName"].HeaderText = "فیلد";
            this.Grd.Columns["PersianFieldName"].HeaderText = "شرح فارسی";
        }
        private void LoadAdv()
        {
            try
            {
                if (this.ID != null)
                {
                    DataTable DtAdv =  Adv.GetAllFormula ((byte) ID);
                    this.TxtFormula.Text =  DtAdv.Rows[0]["Value"].ToString();
                    this.TxtNameFormul.Text =  DtAdv.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ISValidData() == false)
                {
                    return;
                }
                Save();
            }
            catch (Exception ex )
            {

                Global.Dialog.ShowErorr("متاسفانه ذخیره اطلاعات  با خطا مواجه شد", ex.Message);
            }
        }
        private bool ISValidData()
        {
            if (this.TxtFormula.Text == "")
            {
                Global.Dialog.ShowInfo("لطفا فرمول صحیحی وارد کنید");
                return false;
            }
            if (this.TxtNameFormul.Text.Trim() == "")
            {
                Global.Dialog.ShowInfo("لطفا نام فرمول را وارد کنید");
                return false;
            }
            return true;
        }
        private void Save()
        {
            try
            {
                if (ID == null)
                {
                    ClsAdvance NewAdv = new ClsAdvance()
                    {
                        Formula = this.TxtFormula.Text.Trim(),
                        FormulName = this.TxtNameFormul.Text.Trim()
                    };
                    if (Adv.AddFormula(NewAdv) == true)
                    {
                        Global.Dialog.ShowOK("فرمول جدیدی با موفقیت اضافه شد");
                        this.Close();
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه فرمول اضافه نشد");
                    }
                }
                else
                {
                    ClsAdvance NewAdv = new ClsAdvance()
                    {
                        ID = (byte)ID,
                        Formula = this.TxtFormula.Text.Trim(),
                        FormulName = this.TxtNameFormul.Text.Trim()
                    };
                    if (Adv.EditFormula(NewAdv) == true)
                    {
                        Global.Dialog.ShowOK("ویرایش با موفقیت انجام شد");
                        this.Close();
                    }
                    else
                    {
                        Global.Dialog.ShowInfo("متاسفانه ویرایش انجام نشد");
                    }
                }


            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("متاسفانه ذخیره اطلاعات  با خطا مواجه شد", ex.Message);

            }
        }

        private void Grd_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            string Str = this.Grd.Rows[e.Row.Index].Cells["FieldName"].Value.ToString().Trim();
            this.TxtFormula.Text = TxtFormula.Text + Str;
        }
    }
}
