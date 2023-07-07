using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bware.Models;

public partial class BwareContext : DbContext
{
    public BwareContext()
    {
    }

    public BwareContext(DbContextOptions<BwareContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; Initial catalog=Bware; integrated security=SSPI; TrustServerCertificate= True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6CDE64A52CA");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductBrand).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.ProductPrice).HasColumnType("money");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
