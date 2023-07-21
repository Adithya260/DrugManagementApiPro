using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DrugManagement.Data.Entities;

public partial class DmaContext : DbContext
{
    public DmaContext()
    {
    }

    public DmaContext(DbContextOptions<DmaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblDrug> TblDrugs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-S2L1QAE\\SQLEXPRESS;Database=DMA;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblDrug>(entity =>
        {
            entity.HasKey(e => e.DrugId).HasName("PK__tblDrug__908D6616C236830C");

            entity.ToTable("tblDrug");

            entity.Property(e => e.Cost)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DrugName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExpiryDate)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
