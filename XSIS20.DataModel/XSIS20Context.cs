namespace XSIS20.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XSIS20Context : DbContext
    {
        public XSIS20Context()
            : base("name=XSIS20Context")
        {
        }

        public virtual DbSet<x_employee_leave> x_employee_leave { get; set; }
        public virtual DbSet<x_organisasi> x_organisasi { get; set; }
        public virtual DbSet<x_riwayat_pendidikan> x_riwayat_pendidikan { get; set; }
        public virtual DbSet<x_education_level> x_education_level { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.entry_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.exit_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.responsibility)
                .IsUnicode(false);

            modelBuilder.Entity<x_organisasi>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.school_name)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.entry_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.graduation_year)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.major)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.gpa)
                .HasPrecision(18, 4);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.judul_ta)
                .IsUnicode(false);

            modelBuilder.Entity<x_riwayat_pendidikan>()
                .Property(e => e.deskripsi_ta)
                .IsUnicode(false);

            modelBuilder.Entity<x_education_level>()
                .HasMany(e => e.x_riwayat_pendidikan)
                .WithRequired(e => e.x_education_level)
                .HasForeignKey(e => e.education_level_id);
        }
    }
}
