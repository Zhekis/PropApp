using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SuggestImprovements;

public partial class LeanSiContext : DbContext
{
    public LeanSiContext()
    {
    }

    public LeanSiContext(DbContextOptions<LeanSiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Judgment> Judgments { get; set; }

    public virtual DbSet<Loss> Losses { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<ProposalKeys> Proposals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LeanSI;Username=postgres;Password=acer");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Area_pkey");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Area_ID_seq\"'::regclass)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Authors_pkey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstName).HasColumnType("character varying");
            entity.Property(e => e.LastName).HasColumnType("character varying");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Authors)
                .HasForeignKey(d => d.Department)
                .HasConstraintName("Department");

            entity.HasOne(d => d.PositionNavigation).WithMany(p => p.Authors)
                .HasForeignKey(d => d.Position)
                .HasConstraintName("Position");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_pkey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Judgment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Judgment_pkey");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Judgment_ID_seq\"'::regclass)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Loss>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Losses_pkey");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Position_pkey");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Position_ID_seq\"'::regclass)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        modelBuilder.Entity<ProposalKeys>(entity =>
        {
            entity.HasKey(e => e.Number).HasName("Proposals_pkey");

            entity.Property(e => e.Description).HasColumnType("character varying");

            entity.HasOne(d => d.AreaNavigation).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.Area)
                .HasConstraintName("Area");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.Author)
                .HasConstraintName("Author");

            entity.HasOne(d => d.JudgmentNavigation).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.Judgment)
                .HasConstraintName("Judgment");

            entity.HasOne(d => d.LossNavigation).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.Loss)
                .HasConstraintName("Loss");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
