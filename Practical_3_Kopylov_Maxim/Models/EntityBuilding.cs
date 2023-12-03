using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Practical_3_Kopylov_Maxim.Models
{
    public partial class EntityBuilding : DbContext
    {
        private static EntityBuilding _instance;
        public EntityBuilding()
            : base("name=EntityBuilding1")
        {
        }
        public static EntityBuilding GetContext()
        {
            if(_instance == null)
            {
                _instance = new EntityBuilding();
            }
            return _instance;
        }

        public virtual DbSet<avtorization> avtorization { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<doljnosti> doljnosti { get; set; }
        public virtual DbSet<dop_yslyga> dop_yslyga { get; set; }
        public virtual DbSet<itap_stroitelistva> itap_stroitelistva { get; set; }
        public virtual DbSet<itap_objekt> itap_objekt { get; set; }
        public virtual DbSet<material> material { get; set; }
        public virtual DbSet<objekt> objekt { get; set; }
        public virtual DbSet<postavki_materiala> postavki_materiala { get; set; }
        public virtual DbSet<sotrudniki> sotrudniki { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<zakaz> zakaz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<avtorization>()
                .HasMany(e => e.sotrudniki)
                .WithRequired(e => e.avtorization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .Property(e => e.nomer_phone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<client>()
                .HasMany(e => e.zakaz)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dop_yslyga>()
                .HasMany(e => e.zakaz)
                .WithMany(e => e.dop_yslyga)
                .Map(m => m.ToTable("zakaz-yslyga").MapLeftKey("ID_yslygi").MapRightKey("ID_zakaza"));

            modelBuilder.Entity<itap_stroitelistva>()
                .HasMany(e => e.itap_objekt)
                .WithRequired(e => e.itap_stroitelistva)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<material>()
                .HasMany(e => e.postavki_materiala)
                .WithRequired(e => e.material)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objekt>()
                .HasMany(e => e.itap_objekt)
                .WithRequired(e => e.objekt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objekt>()
                .HasMany(e => e.postavki_materiala)
                .WithRequired(e => e.objekt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objekt>()
                .HasMany(e => e.zakaz)
                .WithRequired(e => e.objekt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sotrudniki>()
                .HasMany(e => e.zakaz)
                .WithRequired(e => e.sotrudniki)
                .WillCascadeOnDelete(false);
        }
    }
}
