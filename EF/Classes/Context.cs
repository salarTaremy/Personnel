namespace EF.Classes
{

    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Ef.Entities;

    public partial class Context : DbContext
    {
        public Context()
            //: base("name=CtxCnn")
            : base("data source=192.168.200.220;initial catalog=Personnel;user id=sa;password=Ba2015th2;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<EydiSanavat> EydiSanavat { get; set; }
        public virtual DbSet<EydiSanavatDetail> EydiSanavatDetail { get; set; }
        public virtual DbSet<RetiredPersons> RetiredPersons { get; set; }
        public virtual DbSet<Calendar> Calendar { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<TarafHesab> TarafHesab { get; set; }
        public virtual DbSet<PonyForms> PonyForms { get; set; }

    }
}
