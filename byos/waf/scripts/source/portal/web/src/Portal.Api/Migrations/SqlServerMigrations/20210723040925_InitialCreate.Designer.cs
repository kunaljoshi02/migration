﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.Data;

namespace Portal.Api.Migrations.SqlServerMigrations
{
    [DbContext(typeof(PortalContext))]
    [Migration("20210723040925_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portal.Data.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentBalance")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)")
                        .HasDefaultValueSql("0.00");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("107dc19b-0a82-457f-a00c-db505626760e"),
                            AccountNo = "686847363244",
                            CurrentBalance = 0m,
                            IsActive = true,
                            UserId = new Guid("a4cf2558-c4c2-45fc-90fb-a9b869a97cac")
                        },
                        new
                        {
                            Id = new Guid("7547d22a-53c3-46dd-85b9-cc193bb5f87a"),
                            AccountNo = "815571025629",
                            CurrentBalance = 0m,
                            IsActive = true,
                            UserId = new Guid("f8a65bad-7097-4516-848f-6a290752e4df")
                        });
                });

            modelBuilder.Entity("Portal.Data.Entities.Profile", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("UserId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("a4cf2558-c4c2-45fc-90fb-a9b869a97cac"),
                            FirstName = "Daniel",
                            LastName = "Melamed"
                        },
                        new
                        {
                            UserId = new Guid("f8a65bad-7097-4516-848f-6a290752e4df"),
                            FirstName = "Ting",
                            LastName = "Niu"
                        });
                });

            modelBuilder.Entity("Portal.Data.Entities.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)")
                        .HasDefaultValueSql("0.00");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PostedBalance")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(12, 2)
                        .HasColumnType("decimal(12,2)")
                        .HasDefaultValueSql("0.00");

                    b.Property<DateTimeOffset>("XtnDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("XtnType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Portal.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTimeOffset>("CurrentLoginDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastLoginDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a4cf2558-c4c2-45fc-90fb-a9b869a97cac"),
                            CurrentLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            LastLoginDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Login = "dmelamed3244",
                            Password = "AQAAAAEAACcQAAAAEDIqmsf247/x1et+A3X8EuUmi28a5qv3y+5zap7qLx1wKggXy4pYAqb4IdbYbXF7GA=="
                        },
                        new
                        {
                            Id = new Guid("f8a65bad-7097-4516-848f-6a290752e4df"),
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
