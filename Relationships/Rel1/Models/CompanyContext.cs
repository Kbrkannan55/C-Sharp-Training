using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Rel1.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; Initial catalog=Company; integrated security=SSPI; TrustServerCertificate= True");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK__dept__BE2C337D1D2DCBC9");

            entity.ToTable("dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Depname)
                .HasMaxLength(25)
                .HasColumnName("depname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__emp__AF4CE865FAF66B9E");

            entity.ToTable("emp");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Deptno).HasColumnName("deptno");
            entity.Property(e => e.Empname)
                .HasMaxLength(25)
                .HasColumnName("empname");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("FK__emp__deptno__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
