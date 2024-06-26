﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace exerciseBox.Domain.Entities;

public partial class ExercisesBoxContext : DbContext
{
    public ExercisesBoxContext(DbContextOptions<ExercisesBoxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BranchesSubjectsJunction> BranchesSubjectsJunction { get; set; }

    public virtual DbSet<ExerciseSheetQuestionJunction> ExerciseSheetQuestionJunction { get; set; }

    public virtual DbSet<ExerciseSheets> ExerciseSheets { get; set; }

    public virtual DbSet<Folders> Folders { get; set; }

    public virtual DbSet<FoldersQuestionsJunction> FoldersQuestionsJunction { get; set; }

    public virtual DbSet<QuestionDifficultyLevels> QuestionDifficultyLevels { get; set; }

    public virtual DbSet<Questions> Questions { get; set; }

    public virtual DbSet<SchoolBranches> SchoolBranches { get; set; }

    public virtual DbSet<SchoolLevels> SchoolLevels { get; set; }

    public virtual DbSet<SchoolTypes> SchoolTypes { get; set; }

    public virtual DbSet<SchoolTypesLevelsJunction> SchoolTypesLevelsJunction { get; set; }

    public virtual DbSet<Schools> Schools { get; set; }

    public virtual DbSet<SchoolsBranchesJunction> SchoolsBranchesJunction { get; set; }

    public virtual DbSet<SchoolsSubjectsJunction> SchoolsSubjectsJunction { get; set; }

    public virtual DbSet<Subjects> Subjects { get; set; }

    public virtual DbSet<Teachers> Teachers { get; set; }

    public virtual DbSet<TeachersHiddenQuestions> TeachersHiddenQuestions { get; set; }

    public virtual DbSet<TeachersSchoolLevelsJunction> TeachersSchoolLevelsJunction { get; set; }

    public virtual DbSet<TeachersSubjectsJunction> TeachersSubjectsJunction { get; set; }

    public virtual DbSet<Topics> Topics { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BranchesSubjectsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BranchSu__3213E83FA614003D");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Branch)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("branch");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");

            entity.HasOne(d => d.BranchNavigation).WithMany(p => p.BranchesSubjectsJunction)
                .HasForeignKey(d => d.Branch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchSubjectJunction_SchoolBranch");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.BranchesSubjectsJunction)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BranchSubjectJunction_Subject");
        });

        modelBuilder.Entity<ExerciseSheetQuestionJunction>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.ExerciseSheet)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("exerciseSheet");
            entity.Property(e => e.Question)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("question");

            entity.HasOne(d => d.ExerciseSheetNavigation).WithMany(p => p.ExerciseSheetQuestionJunction)
                .HasForeignKey(d => d.ExerciseSheet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseSheetQuestionJunction_ExerciseSheets");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.ExerciseSheetQuestionJunction)
                .HasForeignKey(d => d.Question)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseSheetQuestionJunction_Questions");
        });

        modelBuilder.Entity<ExerciseSheets>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.ClassNumberPlaceHolder).HasColumnName("classNumberPlaceHolder");
            entity.Property(e => e.ClassNumberText)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("classNumberText");
            entity.Property(e => e.DatePlaceHolder).HasColumnName("datePlaceHolder");
            entity.Property(e => e.MarkPlaceHolder).HasColumnName("markPlaceHolder");
            entity.Property(e => e.NamePlaceHolder).HasColumnName("namePlaceHolder");
            entity.Property(e => e.SubjectPlaceHolder).HasColumnName("subjectPlaceHolder");
            entity.Property(e => e.Teacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher");
            entity.Property(e => e.Tilte)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tilte");
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("topic");

            entity.HasOne(d => d.TeacherNavigation).WithMany(p => p.ExerciseSheets)
                .HasForeignKey(d => d.Teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExerciseSheets_Teachers");

            entity.HasOne(d => d.TopicNavigation).WithMany(p => p.ExerciseSheets)
                .HasForeignKey(d => d.Topic)
                .HasConstraintName("FK_ExerciseSheets_Topics");
        });

        modelBuilder.Entity<Folders>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Folders__3213E83FDD862A75");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Teacher)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher");
            entity.Property(e => e.Topic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("topic");

            entity.HasOne(d => d.TeacherNavigation).WithMany(p => p.Folders)
                .HasForeignKey(d => d.Teacher)
                .HasConstraintName("FK_Folders_Teachers");

            entity.HasOne(d => d.TopicNavigation).WithMany(p => p.Folders)
                .HasForeignKey(d => d.Topic)
                .HasConstraintName("FK_Folders_Topics");
        });

        modelBuilder.Entity<FoldersQuestionsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FoldersQ__3213E83FA24EFB5C");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Folder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("folder");
            entity.Property(e => e.Question)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("question");

            entity.HasOne(d => d.QuestionNavigation).WithMany(p => p.FoldersQuestionsJunction)
                .HasForeignKey(d => d.Question)
                .HasConstraintName("FK__FoldersQu__quest__6CA31EA0");
        });

        modelBuilder.Entity<QuestionDifficultyLevels>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3213E83F87383249");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Questions>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Question__3213E83FE270C59C");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Answer)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("answer");
            entity.Property(e => e.Author)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.DifficultyLevel)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("difficultyLevel");
            entity.Property(e => e.InnerHtml)
                .IsUnicode(false)
                .HasColumnName("innerHtml");
            entity.Property(e => e.QuestionIsPrivate).HasColumnName("questionIsPrivate");
            entity.Property(e => e.QuestionText)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("questionText");
            entity.Property(e => e.SchoolBranch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("schoolBranch");
            entity.Property(e => e.SchoolLevel).HasColumnName("schoolLevel");
            entity.Property(e => e.SchoolType).HasColumnName("schoolType");
            entity.Property(e => e.Topic)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("topic");

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.Author)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_Teachers");

            entity.HasOne(d => d.DifficultyLevelNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.DifficultyLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_QuestionDifficultyLevels");

            entity.HasOne(d => d.SchoolBranchNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.SchoolBranch)
                .HasConstraintName("FK_Questions_SchoolBranches");

            entity.HasOne(d => d.SchoolLevelNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.SchoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_SchoolLevels");

            entity.HasOne(d => d.SchoolTypeNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.SchoolType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_SchoolTypes");

            entity.HasOne(d => d.TopicNavigation).WithMany(p => p.Questions)
                .HasForeignKey(d => d.Topic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_topics");
        });

        modelBuilder.Entity<SchoolBranches>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolBr__3213E83F8A499D30");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SchoolLevels>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PK__SchoolLe__3213E83F9B40A2F8");

            entity.Property(e => e.Level)
                .ValueGeneratedNever()
                .HasColumnName("level");
        });

        modelBuilder.Entity<SchoolTypes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolTy__3213E83F5B096B3E");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SchoolTypesLevelsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolLe__3213E83F18FF1263");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.SchoolLevel).HasColumnName("schoolLevel");
            entity.Property(e => e.SchoolType).HasColumnName("schoolType");

            entity.HasOne(d => d.SchoolLevelNavigation).WithMany(p => p.SchoolTypesLevelsJunction)
                .HasForeignKey(d => d.SchoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsLevelsJunction_SchoolLevels");

            entity.HasOne(d => d.SchoolTypeNavigation).WithMany(p => p.SchoolTypesLevelsJunction)
                .HasForeignKey(d => d.SchoolType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolTypesLevelsJunction_SchoolTypes");
        });

        modelBuilder.Entity<Schools>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__Schools__3213E83F6448D8B3");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SchoolType).HasColumnName("schoolType");

            entity.HasOne(d => d.SchoolTypeNavigation).WithMany(p => p.Schools)
                .HasForeignKey(d => d.SchoolType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Schools_SchoolTypes");
        });

        modelBuilder.Entity<SchoolsBranchesJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolBr__3213E83F342AC604");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Branch)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("branch");
            entity.Property(e => e.School)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("school");

            entity.HasOne(d => d.BranchNavigation).WithMany(p => p.SchoolsBranchesJunction)
                .HasForeignKey(d => d.Branch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolBranchesJunction_SchoolBranch");

            entity.HasOne(d => d.SchoolNavigation).WithMany(p => p.SchoolsBranchesJunction)
                .HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsBranchesJunction_Schools");
        });

        modelBuilder.Entity<SchoolsSubjectsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SchoolSu__3213E83F951C3653");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.School)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("school");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");

            entity.HasOne(d => d.SchoolNavigation).WithMany(p => p.SchoolsSubjectsJunction)
                .HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsSubjectsJunction_Schools");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.SchoolsSubjectsJunction)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolsSubjectsJunction_Subject");
        });

        modelBuilder.Entity<Subjects>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subject__3213E83F267525CF");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Shortcut)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("shortcut");
        });

        modelBuilder.Entity<Teachers>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK_Teacher");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FamilyName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("familyName");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.School)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("school");
            entity.Property(e => e.Surname)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("surname");

            entity.HasOne(d => d.SchoolNavigation).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teachers_Schools");
        });

        modelBuilder.Entity<TeachersHiddenQuestions>(entity =>
        {
            entity.ToTable("teachersHiddenQuestions");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.QuestionId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("questionId");
            entity.Property(e => e.TeacherId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacherId");

            entity.HasOne(d => d.Question).WithMany(p => p.TeachersHiddenQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_teachersHiddenQuestions_Questions");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeachersHiddenQuestions)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_teachersHiddenQuestions_Teachers");
        });

        modelBuilder.Entity<TeachersSchoolLevelsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3213E83F9B0C3F1A");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.SchoolLevel).HasColumnName("schoolLevel");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.Teacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher");

            entity.HasOne(d => d.SchoolLevelNavigation).WithMany(p => p.TeachersSchoolLevelsJunction)
                .HasForeignKey(d => d.SchoolLevel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSchoolLevelsJunction_SchoolLevels");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.TeachersSchoolLevelsJunction)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSchoolLevelsJunction_Subjects");

            entity.HasOne(d => d.TeacherNavigation).WithMany(p => p.TeachersSchoolLevelsJunction)
                .HasForeignKey(d => d.Teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSchoolLevelsJunction_Teachers");
        });

        modelBuilder.Entity<TeachersSubjectsJunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3213E83F7583CB84");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");
            entity.Property(e => e.Teacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("teacher");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.TeachersSubjectsJunction)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSubjectsJunction_Subject");

            entity.HasOne(d => d.TeacherNavigation).WithMany(p => p.TeachersSubjectsJunction)
                .HasForeignKey(d => d.Teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeachersSubjectsJunction_Teachers");
        });

        modelBuilder.Entity<Topics>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__topics__3213E83FCC31C10D");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("subject");

            entity.HasOne(d => d.SubjectNavigation).WithMany(p => p.Topics)
                .HasForeignKey(d => d.Subject)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_topics_Subject");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}