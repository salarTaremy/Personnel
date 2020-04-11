using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserControls;

namespace Salary.Forms
{
    public partial class FrmMissionType : Permission.ClsMyForms
    {
        ClsMission Ms = new ClsMission();
        ClsDialog Dialog = new ClsDialog();
        public FrmMissionType()
        {
            InitializeComponent();
        }

        private void FrmMissionType_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            try
            {
                this.Grd.DataSource = Ms.GetAllTypes();
                this.Grd.Columns["Name"].HeaderText = "شرح";
                this.Grd.Columns["ID"].IsVisible = false;
                this.Grd.Columns["Name"].Width = 380;
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("سیستم قادر به خواندن اطلاعات نمیباشد", ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grd.SelectedRows.Count == 0)
                {
                    return;
                }
                string Msg = string.Format("آیا برای حذف نوع '{0}'  مطمئن هستید ؟؟",this.Grd.CurrentRow.Cells["Name"].Value.ToString().Trim());
                if (Dialog.ShowQuestion(Msg) == false)
                {
                    return;
                }
                int ID = int.Parse(this.Grd.CurrentRow.Cells["ID"].Value.ToString());
                if (ID == 0)
                {
                    Dialog.ShowInfo("شما مجاز به حذف و ویرایش نوع های پیش فرض نمیباشد");
                    return;
                }
                if (Ms.DeleteType( ID)> 0)
                {
                    Dialog.ShowOK("عملیات حذف با موفقیت انجام شد");
                    FillGrid();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه رکوردی حذف نشد");
                }
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("عملیات حذف با خطا مواجه شد", ex.Message);
            } 
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.TxtName.Text.Trim()))
                {
                    Dialog.ShowInfo("لطفا شرح مناسبی برای نوع جدید اضافه کنید");
                    this.TxtName.Focus();
                        return ;
                }
                int RowAffect = Ms.AddMissionType(TxtName.Text.Trim());
                if (RowAffect > 0)
                {
                    Dialog.ShowOK("عملیات با موفقیت انجام شد");
                    FillGrid();
                    this.TxtName.Text = null;
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه اطلاعاتی درج نشد");
                }
            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("عملیات درج رکورد جدید با خطا مواجه شد", ex.Message);
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtName.Text.Trim()))
            {
                this.BtnAdd.Enabled = false;
            }
            else
            {
                this.BtnAdd.Enabled = true ;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect  =  Ms.UpdateMissionType((DataTable)this.Grd.DataSource);
                if (RowAffect > 0)
                {
                    Dialog.ShowOK("عملیات به روز رسانی با موفقیت موفقیت انجام شد");
                    FillGrid();
                }
                else
                {
                    Dialog.ShowInfo("متاسفانه هیج اطلاعاتی  تغییر نکرد");
                }

            }
            catch (Exception ex)
            {
                Dialog.ShowErorr("عملیات درج رکورد جدید با خطا مواجه شد", ex.Message);
            }

        }
    }
}
