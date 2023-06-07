using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Tester.Models
{
    public partial class QLSINHVIENContext : DbContext
    {
        public QLSINHVIENContext()
        {
        }

        public QLSINHVIENContext(DbContextOptions<QLSINHVIENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-PB55PLBV\\SQLEXPRESS; Database = QLSINHVIEN; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv);

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(50)
                    .HasColumnName("MaSV");

                entity.Property(e => e.DiemTb).HasColumnName("DiemTB");

                entity.Property(e => e.Lop).HasMaxLength(50);

                entity.Property(e => e.TenSv)
                    .HasMaxLength(50)
                    .HasColumnName("TenSV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
