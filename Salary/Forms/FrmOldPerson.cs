using Common;
using Ef.Entities;
using EF.Classes;
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
    public partial class FrmOldPerson : Permission.ClsMyForms
    {
        public FrmOldPerson()
        {
            InitializeComponent();
        }

        private void FrmOldPerson_Load(object sender, EventArgs e)
        {
            FillGrd();
        }

        private void FillGrd()
        {
            try
            {
                using (Context ctx = new Context())
                {
                    var query =
                       from R in ctx.RetiredPersons
                       join c in ctx.Calendar on R.DateOfRetired equals c.Persian_Date
                       join p in ctx.Personel on R.ID_Pr equals p.ID
                       join t in ctx.TarafHesab on p.ID_TarafHesab equals t.ID
                       where 1 == 1
                       select new {
                                    R.ID,
                                    R.ID_Pr,    
                                    t.FullName,
                                    R.Description, 
                                    c.Pr_DateDisplay
                       };
                    this.Grd.DataSource = query.ToList().ToDataTable();
                }

                this.Grd.Columns["ID"].IsVisible = false; 
                this.Grd.Columns["ID_Pr"].HeaderText = "کد پرسنلی";
                this.Grd.Columns["FullName"].HeaderText = "نام";
                this.Grd.Columns["Description"].HeaderText = "توضیحات";
                this.Grd.Columns["Pr_DateDisplay"].HeaderText = "تاریخ بازنشستگی";
                this.Grd.Columns["ID"].Width = 80;
                this.Grd.Columns["ID_Pr"].Width = 120;
                this.Grd.Columns["FullName"].Width = 270;
                this.Grd.Columns["Description"].Width = 450;
                this.Grd.Columns["Pr_DateDisplay"].Width = 150;

            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("خواندن داده ها با خطا مواجه شد", ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Grd.CurrentRow is null)
                {
                    return;
                }

                long ID = (long)this.Grd.CurrentRow.Cells["id"].Value;

                if (Global.Dialog.ShowQuestion("آیا برای حذف مطمئن هستید ؟"))
                {
                    if (Delete(ID))
                    {
                        Global.Dialog.ShowOK("حذف با موفقیت انجام شد ");
                        FillGrd();
                    }
                    else 
                    { 
                        Global.Dialog.ShowInfo("حذف انجام نشد");
                    }
                }
            }
            catch (Exception ex)
            {
                Global.Dialog.ShowErorr("حذف با خطا مواجه شد", ex.Message);
            }

        }

        private Boolean  Delete( long ID)
        {
            try
            {
                using (Context Ctx = new Context())
                {
                    var x =   Ctx.RetiredPersons.Find(ID) ;
                    Ctx.RetiredPersons.Remove(x);
                    return Ctx.SaveChanges() != 0 ; 
                }
            }
            catch (Exception ex )
            {
                throw ex; 
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            StiReport Rep = new StiReport();
            Rep.AddDatasource((DataTable)this.Grd.DataSource);
            Rep.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddRetiredPersons frm = new FrmAddRetiredPersons() ;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                FillGrd();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (this.Grd.CurrentRow is null )
            {
                return; 
            }

            long ID = (long)this.Grd.CurrentRow.Cells["id"].Value;
            RetiredPersons retiredPersons; 
            using (Context Ctx = new Context() )
            {
                retiredPersons = Ctx.RetiredPersons.Find(ID);
            }
            if (retiredPersons is null )
            {
                return;
            }
            FrmAddRetiredPersons frm = new FrmAddRetiredPersons(retiredPersons);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                FillGrd();
            }
            
        }
    }
}
