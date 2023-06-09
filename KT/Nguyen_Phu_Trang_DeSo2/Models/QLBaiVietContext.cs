﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Nguyen_Phu_Trang_DeSo2.Models
{
    public partial class QLBaiVietContext : DbContext
    {
        public QLBaiVietContext()
        {
        }

        public QLBaiVietContext(DbContextOptions<QLBaiVietContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-PB55PLBV\\SQLEXPRESS; Database = QLBaiViet; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BaiViet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BaiViet");

                entity.Property(e => e.MaBaiViet)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NgayPost).HasColumnType("date");

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TieuDe)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
