namespace TeknikServis.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MvcContext : DbContext
    {
        public MvcContext()
            : base("name=MvcContext")
        {
        }

        public virtual DbSet<Ariza> Arizas { get; set; }
        public virtual DbSet<Ariza_Tip> Ariza_Tip { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Malzeme> Malzemes { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Onarim> Onarims { get; set; }
        public virtual DbSet<Onarim_Malzeme> Onarim_Malzeme { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tedarik> Tedariks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ariza>()
                .HasMany(e => e.Onarims)
                .WithRequired(e => e.Ariza)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ariza_Tip>()
                .HasMany(e => e.Arizas)
                .WithRequired(e => e.Ariza_Tip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Sifre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Malzeme>()
                .HasMany(e => e.Onarim_Malzeme)
                .WithRequired(e => e.Malzeme)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Malzeme>()
                .HasMany(e => e.Tedariks)
                .WithRequired(e => e.Malzeme)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.TC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.Arizas)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Onarim>()
                .HasMany(e => e.Onarim_Malzeme)
                .WithRequired(e => e.Onarim)
                .WillCascadeOnDelete(false);
        }
    }
}
