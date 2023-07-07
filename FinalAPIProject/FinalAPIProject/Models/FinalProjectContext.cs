using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalAPIProject.Models;

public partial class FinalProjectContext : DbContext
{
    public FinalProjectContext()
    {
    }

    public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admintable> Admintables { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Orderdetail> Orderdetails { get; set; }

    public virtual DbSet<Productdetail> Productdetails { get; set; }

    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; initial catalog=FinalProject;integrated security=SSPI;TrustServerCertificate=True;");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admintable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Admintable");

            entity.Property(e => e.AdminPassword).HasMaxLength(10);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Cusid).HasName("PK__Customer__2F0794C814783B1E");

            entity.ToTable("Customer");

            entity.Property(e => e.Cusaddress).HasMaxLength(40);
            entity.Property(e => e.Cusname).HasMaxLength(30);
            entity.Property(e => e.Cuspassword).HasMaxLength(10);
        });

        modelBuilder.Entity<Orderdetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Orderid).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Cus).WithMany()
                .HasForeignKey(d => d.Cusid)
                .HasConstraintName("FK__Orderdeta__Cusid__6477ECF3");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.Productid)
                .HasConstraintName("FK__Orderdeta__Produ__656C112C");
        });

        modelBuilder.Entity<Productdetail>(entity =>
        {
            entity.HasKey(e => e.Productid).HasName("PK__Productd__B40F3AA58B45D0C9");

            entity.Property(e => e.Costperquantity).HasColumnType("money");
            entity.Property(e => e.Productname).HasMaxLength(40);
            entity.Property(e => e.Producttype).HasMaxLength(40);
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

      

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
