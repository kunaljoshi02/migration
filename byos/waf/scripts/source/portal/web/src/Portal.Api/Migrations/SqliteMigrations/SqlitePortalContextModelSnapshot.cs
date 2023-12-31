﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.Data;

namespace Portal.Api.Migrations.SqliteMigrations
{
    [DbContext(typeof(SqlitePortalContext))]
    partial class SqlitePortalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Portal.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CurrentBalance")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("0.00");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(true);

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d025d833-9669-4112-818e-d30cc9ea2f90"),
                            AccountNo = "686847363244",
                            CurrentBalance = 0m,
                            IsActive = true,
                            UserId = new Guid("215d6524-19d2-4ed1-b38c-53813905a110")
                        },
                        new
                        {
                            Id = new Guid("76405848-2c80-4a43-bb7d-a0dce7bbb38b"),
                            AccountNo = "815571025629",
                            CurrentBalance = 0m,
                            IsActive = true,
                            UserId = new Guid("3ae1dab6-8675-4b8a-9aa3-cb55d1cd5901")
                        });
                });

            modelBuilder.Entity("Portal.Data.Entities.Profile", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("215d6524-19d2-4ed1-b38c-53813905a110"),
                            FirstName = "Daniel",
                            LastName = "Melamed"
                        },
                        new
                        {
                            UserId = new Guid("3ae1dab6-8675-4b8a-9aa3-cb55d1cd5901"),
                            FirstName = "Ting",
                            LastName = "Niu"
                        });
                });

            modelBuilder.Entity("Portal.Data.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("0.00");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PostedBalance")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("0.00");

                    b.Property<DateTimeOffset>("XtnDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("XtnType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Portal.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTimeOffset>("CurrentLoginDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("LastLoginDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("215d6524-19d2-4ed1-b38c-53813905a110"),
                            CurrentLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            LastLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Login = "dmelamed3244",
                            Password = "AQAAAAEAACcQAAAAEDIqmsf247/x1et+A3X8EuUmi28a5qv3y+5zap7qLx1wKggXy4pYAqb4IdbYbXF7GA=="
                        },
                        new
                        {
                            Id = new Guid("3ae1dab6-8675-4b8a-9aa3-cb55d1cd5901"),
                            CurrentLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            LastLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Login = "tniu5629",
                            Password = "AQAAAAEAACcQAAAAEBpBdRt4iTKKnJGc1m9LPXHpSIeUb0McYEjeGg2v5bHUQlJGJROTMTj2V7Is45M8xQ=="
                        });
                });

            modelBuilder.Entity("Portal.Data.Entities.Account", b =>
                {
                    b.HasOne("Portal.Data.Entities.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portal.Data.Entities.Profile", b =>
                {
                    b.HasOne("Portal.Data.Entities.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Portal.Data.Entities.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Portal.Data.Entities.Transaction", b =>
                {
                    b.HasOne("Portal.Data.Entities.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Portal.Data.Entities.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Portal.Data.Entities.User", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
