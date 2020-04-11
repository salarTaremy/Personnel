using Ef.Entities;
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
    public partial class FrmEditEydiSanavat : ClsMyForms
    {
        long ID;
        private EydiSanavatDetail detail;
        private EydiSanavat header;
        private long BasicSalaryPerDayRls;
        private byte ID_Company;
        private byte ID_Formul;
        ClsOtherPayment Pay = new ClsOtherPayment();

        public FrmEditEydiSanavat( long ID_EydiSanavatDetail)
        {
            InitializeComponent();
            this.ID = ID_EydiSanavatDetail;
        }

        private void FrmEditEydiSanavat_Load(object sender, EventArgs e)
        {
            FillCmb();
            Fill();
        }
        private void FillCmb()
        {
            try
            {
                Common.SalMali SalMali = new Common.SalMali();
                this.CmbYear.DisplayMember = "Name";
                this.CmbYear.ValueMember = "ID";
                this.CmbYear.DataSource = SalMali.GetSalMali();
                this.CmbYear.SelectedValue = short.Parse(Common.SalMali.Value);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ReCampute() {

            int DayCount = (int)this.TxtDayCount.Rls;
            int Year = int.Parse( CmbYear.SelectedValue.ToString());

            using (DataTable Dt = this.Pay.GetPriceWithFormula(ID_Formul , detail.ID_Person, ID_Company, DayCount, Year))
            {
                this.TxtRls.Text = Dt.Rows[0]["Value"].ToString();
                //item.Cells["DayCount"].Value = (int)Dt.Rows[0]["DayCount"];
                //item.Cells["ID_Hokm"].Value = (long)Dt.Rows[0]["ID_Hokm"];
            }

        }



        private void Fill()
        {
            try
            {

                using (Context Ctx = new Context())
                {

                    this.detail = Ctx.EydiSanavatDetail.Find(this.ID);
                    this.header = Ctx.EydiSanavat.Find(detail.ID_EydiSanavat);
                    if (header.ID_Type == 1)
                    {
                        //Eydi

                        this.ID_Formul = 7;

                        this.TxtLeaveAddRls.Enabled = false;
                        this.TxtLeaveDissRls.Enabled = false;

                        this.TxtLeaveAddDay.Enabled = false;
                        this.TxtLeaveDissDay.Enabled = false;

                        this.RadLabel20.Text = "سایر اضافات:";
                    }
                    else
                    {

                        this.ID_Formul = 8;
                        this.RadLabel20.Text = "حقوق معوقه:";

                    }
                }

                ClsHokm h = new ClsHokm();
                ClsPersonel personel = new ClsPersonel(detail.ID_Person.ToString());
                var hokm = h.GetByID(detail.ID_Hokm);
                this.TxtNamePr.Text = personel.Name +" "+ personel.Famil;
                this.BasicSalaryPerDayRls = (long)hokm.Rows[0]["BasicSalaryPerDayRls"];
                this.ID_Company = (byte)hokm.Rows[0]["ID_Company"];
                this.TxtDastmozd.Text = BasicSalaryPerDayRls.ToString();
                this.TxtDayCount.Text = detail.DayCount.ToString();
                this.TxtRls.Text = detail.Amount.ToString();

                this.TxtLeaveAddRls.Text =  Math.Round(detail.LeavePlusRls * (this.BasicSalaryPerDayRls / 7.333)).ToString();
                this.TxtLeaveDissRls.Text = Math.Round(detail.LeaveMinusRls * (this.BasicSalaryPerDayRls / 7.333)).ToString();

                this.TxtLeaveAddDay.Text = detail.LeavePlusRls.ToString();
                this.TxtLeaveDissDay.Text = detail.LeaveMinusRls.ToString();

                this.TxtOtherAdd.Text = detail.DelayedSalaryRls.ToString();
                this.TxtOtherDiss.Text = detail.MoreDiscountRls.ToString();

            }
            catch (Exception ex )
            {
                Global.Dialog.ShowErorr("باز ", ex.Message);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (Context Ctx = new Context())
                {
                    var x = Ctx.EydiSanavatDetail.Find(ID);
                    x.LeaveMinusRls = this.TxtLeaveDissDay.Rls;
                    x.LeavePlusRls = this.TxtLeaveAddDay.Rls;
                    x.DelayedSalaryRls = this.TxtOtherAdd.Rls;
                    x.MoreDiscountRls = this.TxtOtherDiss.Rls;
                    if (x.DayCount != (int)TxtDayCount.Rls)
                    {
                        ReCampute();
                        x.DayCount = (int)TxtDayCount.Rls;
                        x.Amount =   long.Parse( TxtRls.Text.ToString().Replace(",",""));
                    }
                    
                    var RowAffect =  Ctx.SaveChanges();
                    if (RowAffect > 0)
                    {
                        Global.Dialog.ShowOK("اطلاعات با موفقیت اصلاح شد");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else {
                        Global.Dialog.ShowInfo("متاسفانه اطلاعاتی ذخیره نشد");
                    }

                }
            }
            catch (Exception ex)
            {

                Global.Dialog.ShowErorr("ذخیره اطلاعات با خطا مواجه شد" , ex.Message);
            }



        }

        private void BtnHelp1_Click(object sender, EventArgs e)
        {
            ReCampute();
        }
    }
}
