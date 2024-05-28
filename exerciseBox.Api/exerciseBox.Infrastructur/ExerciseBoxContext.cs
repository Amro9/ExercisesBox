﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using exerciseBox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace exerciseBox.Infrastructur;

public partial class ExerciseBoxContext : DbContext
{
    public ExerciseBoxContext(DbContextOptions<ExerciseBoxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BranchesSubjectsJunctions> BranchesSubjectsJunctions { get; set; }

    public virtual DbSet<Questions> Questions { get; set; }

    public virtual DbSet<QuestionDifficultyLevels> QuestionDifficultyLevels { get; set; }

    public virtual DbSet<Schools> Schools { get; set; }

    public virtual DbSet<SchoolBranchs> SchoolBranches { get; set; }

    public virtual DbSet<SchoolLevels> SchoolLevels { get; set; }

    public virtual DbSet<SchoolTypes> SchoolTypes { get; set; }

    public virtual DbSet<SchoolsBranchesJunctions> SchoolsBranchesJunctions { get; set; }

    public virtual DbSet<SchoolsLevelsJunctions> SchoolsLevelsJunctions { get; set; }

    public virtual DbSet<SchoolsSubjectsJunctions> SchoolsSubjectsJunctions { get; set; }

    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<Teachers> Teachers { get; set; }

    public virtual DbSet<TeachersSchoolLevelsJunctions> TeachersSchoolLevelsJunctions { get; set; }

    public virtual DbSet<TeachersSubjectsJunctions> TeachersSubjectsJunctions { get; set; }

    public virtual DbSet<Topics> Topics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BranchesSubjectsJunctions>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchSu__3213E83FA614003D");

            entity.ToTable("BranchesSubjectsJunction");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Branch)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.BranchNavigation).WithMany(p => p.BranchesSubjectsJunctions)
                .HasForeignKey(d => d.Branch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchSubjectJunction_SchoolBranch");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.BranchesSubjectsJunctions)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchSubjectJunction_Subject");
        });

        modelBuilder.Entity<Questions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Question__3213E83FE270C59C");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.answer)
                .IsRequired()
                .IsUnicode(false);
            entity.Property(e => e.author)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.content)
                .IsRequired()
                .IsUnicode(false);
            entity.Property(e => e.difficultyLevel)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.topic)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.authorNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_Teachers");

            entity.HasOne(d => d.difficultyLevelNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.difficultyLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_QuestionDifficultyLevels");

            entity.HasOne(d => d.schoolLevelNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.schoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_SchoolLevels");

            entity.HasOne(d => d.topicNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.topic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_topics");
        });

        modelBuilder.Entity<QuestionDifficultyLevels>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Question__3213E83F87383249");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.description)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Schools>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schools__3213E83F6448D8B3");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SchoolType)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SchoolTypeNavigation).WithMany(p => p.Schools)
                .HasForeignKey(d => d.SchoolType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Schools_SchoolTypes");
        });

        modelBuilder.Entity<SchoolBranchs>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__SchoolBr__3213E83F8A499D30");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchoolLevels>(entity =>
        {
            entity.HasKey(e => e.level).HasName("PK__SchoolLe__3213E83F9B40A2F8");

            entity.Property(e => e.level).ValueGeneratedNever();
        });

        modelBuilder.Entity<SchoolTypes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolTy__3213E83F5B096B3E");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchoolsBranchesJunctions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__SchoolBr__3213E83F342AC604");

            entity.ToTable("SchoolsBranchesJunction");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.branch)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.school)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.branchNavigation).WithMany(p => p.SchoolsBranchesJunctions)
                .HasForeignKey(d => d.branch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolBranchesJunction_SchoolBranch");

            entity.HasOne(d => d.schoolNavigation).WithMany(p => p.SchoolsBranchesJunctions)
                .HasForeignKey(d => d.school)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolBranchesJunction_Schools");
        });

        modelBuilder.Entity<SchoolsLevelsJunctions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__SchoolLe__3213E83F18FF1263");

            entity.ToTable("SchoolsLevelsJunction");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.school)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.schoolNavigation).WithMany(p => p.SchoolsLevelsJunctions)
                .HasForeignKey(d => d.school)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsLevelsJunction_Schools");

            entity.HasOne(d => d.schoolLevelNavigation).WithMany(p => p.SchoolsLevelsJunctions)
                .HasForeignKey(d => d.schoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsLevelsJunction_SchoolLevels");
        });

        modelBuilder.Entity<SchoolsSubjectsJunctions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__SchoolSu__3213E83F951C3653");

            entity.ToTable("SchoolsSubjectsJunction");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.school)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.schoolNavigation).WithMany(p => p.SchoolsSubjectsJunctions)
                .HasForeignKey(d => d.school)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsSubjectsJunction_SchoolsSubjectsJunction");

            entity.HasOne(d => d.subjectNavigation).WithMany(p => p.SchoolsSubjectsJunctions)
                .HasForeignKey(d => d.subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsSubjectsJunction_Subject");
        });

        modelBuilder.Entity<Subjects>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Subject__3213E83F267525CF");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.shortcut)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Teachers>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teacher__3213E83F92A904E3");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FamilyName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.School)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SchoolNavigation).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teacher_Schools");
        });

        modelBuilder.Entity<TeachersSchoolLevelsJunctions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Teachers__3213E83F9B0C3F1A");

            entity.ToTable("TeachersSchoolLevelsJunction");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.teacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.schoolLevelNavigation).WithMany(p => p.TeachersSchoolLevelsJunctions)
                .HasForeignKey(d => d.schoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSchoolLevelsJunction_SchoolLevels");

            entity.HasOne(d => d.teacherNavigation).WithMany(p => p.TeachersSchoolLevelsJunctions)
                .HasForeignKey(d => d.teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSchoolLevelsJunction_Teachers");
        });

        modelBuilder.Entity<TeachersSubjectsJunctions>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Teachers__3213E83F7583CB84");

            entity.ToTable("TeachersSubjectsJunction");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.teacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.subjectNavigation).WithMany(p => p.TeachersSubjectsJunctions)
                .HasForeignKey(d => d.subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSubjectsJunction_Subject");

            entity.HasOne(d => d.teacherNavigation).WithMany(p => p.TeachersSubjectsJunctions)
                .HasForeignKey(d => d.teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSubjectsJunction_Teacher");
        });

        modelBuilder.Entity<Topics>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__topics__3213E83FCC31C10D");

            entity.Property(e => e.id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.description)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.subjectNavigation).WithMany(p => p.Topics)
                .HasForeignKey(d => d.subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_topics_Subject");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}