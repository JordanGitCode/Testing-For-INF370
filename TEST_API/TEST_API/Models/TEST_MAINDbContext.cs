﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TEST_API.Models;

public partial class TEST_MAINDbContext : DbContext
{
    public TEST_MAINDbContext(DbContextOptions<TEST_MAINDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<ApplicationFeedback> ApplicationFeedbacks { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ConverationParticipant> ConverationParticipants { get; set; }

    public virtual DbSet<Conversation> Conversations { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Interview> Interviews { get; set; }

    public virtual DbSet<InterviewFeedback> InterviewFeedbacks { get; set; }

    public virtual DbSet<InterviewNote> InterviewNotes { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PermissionCategory> PermissionCategories { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Race> Races { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<Shortlist> Shortlists { get; set; }

    public virtual DbSet<ShortlistedCandidate> ShortlistedCandidates { get; set; }

    public virtual DbSet<Suburb> Suburbs { get; set; }

    public virtual DbSet<Title> Titles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserSession> UserSessions { get; set; }

    public virtual DbSet<Vacancy> Vacancies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__Applicat__E063E1CB8EC81CD4");

            entity.Property(e => e.ApplicationId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.Applications).HasConstraintName("FK__Applicati__User___6754599E").IsRequired(false);
        });

        modelBuilder.Entity<ApplicationFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Applicat__CD3992F86B77B4A7");

            entity.Property(e => e.FeedbackId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.ApplicationFeedbacks).HasConstraintName("FK__Applicati__Appli__7D439ABD").IsRequired(false);

            entity.HasOne(d => d.Employee).WithMany(p => p.ApplicationFeedbacks).HasConstraintName("FK__Applicati__Emplo__7E37BEF6").IsRequired(false);
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("PK__Branch__12CEB0413B9A4CC8");

            entity.Property(e => e.BranchId).ValueGeneratedNever();

            entity.HasOne(d => d.City).WithMany(p => p.Branches).HasConstraintName("FK__Branch__City_ID__5CD6CB2B").IsRequired(false);

            entity.HasOne(d => d.Country).WithMany(p => p.Branches).HasConstraintName("FK__Branch__Country___5AEE82B9").IsRequired(false);

            entity.HasOne(d => d.Province).WithMany(p => p.Branches).HasConstraintName("FK__Branch__Province__5BE2A6F2").IsRequired(false);

            entity.HasOne(d => d.Suburb).WithMany(p => p.Branches).HasConstraintName("FK__Branch__Suburb_I__5DCAEF64").IsRequired(false);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__DE9DE0201D3466BC");

            entity.Property(e => e.CityId).ValueGeneratedNever();

            entity.HasOne(d => d.Province).WithMany(p => p.Cities).HasConstraintName("FK__City__Province_I__3C69FB99").IsRequired(false);
        });

        modelBuilder.Entity<ConverationParticipant>(entity =>
        {
            entity.HasKey(e => new { e.ConversationId, e.UserId }).HasName("PK__Converat__D8A3AEEA85B8EE18");

            entity.HasOne(d => d.Conversation).WithMany(p => p.ConverationParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Converati__Conve__0B91BA14");

            entity.HasOne(d => d.User).WithMany(p => p.ConverationParticipants)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Converati__User___0C85DE4D");
        });

        modelBuilder.Entity<Conversation>(entity =>
        {
            entity.HasKey(e => e.ConversationId).HasName("PK__Conversa__CAA577F3D2D6FC16");

            entity.Property(e => e.ConversationId).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Conversations).HasConstraintName("FK__Conversat__Emplo__04E4BC85").IsRequired(false);

            entity.HasOne(d => d.User).WithMany(p => p.Conversations).HasConstraintName("FK__Conversat__User___03F0984C").IsRequired(false);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__8036CB4E13E860C7");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__781134811C0D4237");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees).HasConstraintName("FK__Employee__Branch__6383C8BA").IsRequired(false);

            entity.HasOne(d => d.Job).WithMany(p => p.Employees).HasConstraintName("FK__Employee__Job_ID__6477ECF3").IsRequired(false);

            entity.HasOne(d => d.User).WithMany(p => p.Employees).HasConstraintName("FK__Employee__User_I__628FA481").IsRequired(false);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PK__Gender__AF750E6481E037D3");

            entity.Property(e => e.GenderId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Interview>(entity =>
        {
            entity.HasKey(e => e.InterviewId).HasName("PK__Intervie__536D7219E7C35F35");

            entity.Property(e => e.InterviewId).ValueGeneratedNever();

            entity.HasOne(d => d.Employee).WithMany(p => p.Interviews).HasConstraintName("FK__Interview__Emplo__76969D2E").IsRequired(false);

            entity.HasOne(d => d.User).WithMany(p => p.Interviews).HasConstraintName("FK__Interview__User___75A278F5").IsRequired(false);

            entity.HasOne(d => d.Vacancy).WithMany(p => p.Interviews).HasConstraintName("FK__Interview__Vacan__778AC167").IsRequired(false);
        });

        modelBuilder.Entity<InterviewFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Intervie__CD3992F8429C854A");

            entity.Property(e => e.FeedbackId).ValueGeneratedNever();

            entity.HasOne(d => d.Interview).WithMany(p => p.InterviewFeedbacks).HasConstraintName("FK__Interview__Inter__01142BA1").IsRequired(false);
        });

        modelBuilder.Entity<InterviewNote>(entity =>
        {
            entity.HasKey(e => e.InterviewNoteId).HasName("PK__Intervie__2AC148BC34516ECF");

            entity.Property(e => e.InterviewNoteId).ValueGeneratedNever();

            entity.HasOne(d => d.Interview).WithMany(p => p.InterviewNotes).HasConstraintName("FK__Interview__Inter__7A672E12").IsRequired(false);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Job__E76A7686E804129D");

            entity.Property(e => e.JobId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Message__F5A446E24CB2B6ED");

            entity.Property(e => e.MessageId).ValueGeneratedNever();

            entity.HasOne(d => d.Conversation).WithMany(p => p.Messages).HasConstraintName("FK__Message__Convers__08B54D69").IsRequired(false);

            entity.HasOne(d => d.User).WithMany(p => p.Messages).HasConstraintName("FK__Message__User_ID__07C12930").IsRequired(false);
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__Permissi__89B744E50B656BE2");

            entity.Property(e => e.PermissionId).ValueGeneratedNever();

            entity.HasOne(d => d.PermissionCategory).WithMany(p => p.Permissions).HasConstraintName("FK__Permissio__Permi__5441852A").IsRequired(false);
        });

        modelBuilder.Entity<PermissionCategory>(entity =>
        {
            entity.HasKey(e => e.PermissionCategoryId).HasName("PK__Permissi__1CBE8308FD0A285F");

            entity.Property(e => e.PermissionCategoryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK__Province__D445B6428B9046B7");

            entity.Property(e => e.ProvinceId).ValueGeneratedNever();

            entity.HasOne(d => d.Country).WithMany(p => p.Provinces).HasConstraintName("FK__Province__Countr__398D8EEE").IsRequired(false);
        });

        modelBuilder.Entity<Race>(entity =>
        {
            entity.HasKey(e => e.RaceId).HasName("PK__Race__BF0E08F7363D0FEE");

            entity.Property(e => e.RaceId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Role__D80AB49B821AFB37");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionId, e.RoleId }).HasName("PK__RolePerm__2437EFAC6DA43BDD");

            entity.HasOne(d => d.Permission).WithMany(p => p.RolePermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolePermi__Permi__571DF1D5");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RolePermi__Role___5812160E");
        });

        modelBuilder.Entity<Shortlist>(entity =>
        {
            entity.HasKey(e => e.ShortlistId).HasName("PK__Shortlis__661C3D1F0D419807");

            entity.Property(e => e.ShortlistId).ValueGeneratedNever();

            entity.HasOne(d => d.Vacancy).WithMany(p => p.Shortlists).HasConstraintName("FK__Shortlist__Vacan__6EF57B66").IsRequired(false);
        });

        modelBuilder.Entity<ShortlistedCandidate>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.ShortlistId }).HasName("PK__Shortlis__C60C5241F23C1090");

            entity.HasOne(d => d.Shortlist).WithMany(p => p.ShortlistedCandidates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Shortlist__Short__72C60C4A");

            entity.HasOne(d => d.User).WithMany(p => p.ShortlistedCandidates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Shortlist__User___71D1E811");
        });

        modelBuilder.Entity<Suburb>(entity =>
        {
            entity.HasKey(e => e.SuburbId).HasName("PK__Suburb__BCFB02106EDC82ED");

            entity.Property(e => e.SuburbId).ValueGeneratedNever();

            entity.HasOne(d => d.City).WithMany(p => p.Suburbs).HasConstraintName("FK__Suburb__City_ID__3F466844").IsRequired(false);
        });

        modelBuilder.Entity<Title>(entity =>
        {
            entity.HasKey(e => e.TitleId).HasName("PK__Title__01D44740F80204C0");

            entity.Property(e => e.TitleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__206D919013CAD170");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.Gender).WithMany(p => p.Users).HasConstraintName("FK__User__Gender_ID__4BAC3F29").IsRequired(false);

            entity.HasOne(d => d.Race).WithMany(p => p.Users).HasConstraintName("FK__User__Race_ID__4AB81AF0").IsRequired(false);

            entity.HasOne(d => d.Role).WithMany(p => p.Users).HasConstraintName("FK__User__Role_ID__4CA06362").IsRequired(false);

            entity.HasOne(d => d.Title).WithMany(p => p.Users).HasConstraintName("FK__User__Title_ID__49C3F6B7").IsRequired(false);
        });

        modelBuilder.Entity<UserSession>(entity =>
        {
            entity.HasKey(e => e.UserSessionId).HasName("PK__UserSess__2884045AFCBA6487");

            entity.Property(e => e.UserSessionId).ValueGeneratedNever();

            entity.HasOne(d => d.User).WithMany(p => p.UserSessions).HasConstraintName("FK__UserSessi__User___4F7CD00D").IsRequired(false);
        });

        modelBuilder.Entity<Vacancy>(entity =>
        {
            entity.HasKey(e => e.VacancyId).HasName("PK__Vacancy__2565D5E2BA3EF477");

            entity.Property(e => e.VacancyId).ValueGeneratedNever();

            entity.HasOne(d => d.Application).WithMany(p => p.Vacancies).HasConstraintName("FK__Vacancy__Applica__6A30C649").IsRequired(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.Vacancies).HasConstraintName("FK__Vacancy__Branch___6C190EBB").IsRequired(false);

            entity.HasOne(d => d.Job).WithMany(p => p.Vacancies).HasConstraintName("FK__Vacancy__Job_ID__6B24EA82").IsRequired(false);
        });

        OnModelCreatingGeneratedFunctions(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
