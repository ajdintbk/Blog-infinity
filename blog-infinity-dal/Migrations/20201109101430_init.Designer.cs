﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_infinity_dal;

namespace blog_infinity_dal.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20201109101430_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_infinity_dal.Domain.Blog", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(3500)")
                        .HasMaxLength(3500);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("blog_infinity_dal.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            CreatedBy = "First",
                            Email = "firstuser@gmail.com",
                            Name = "First",
                            TimeCreated = new DateTime(2020, 11, 9, 10, 14, 29, 330, DateTimeKind.Utc).AddTicks(9366),
                            TimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            CreatedBy = "First",
                            Email = "seconduser@gmail.com",
                            Name = "Second",
                            TimeCreated = new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5666),
                            TimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            CreatedBy = "First",
                            Email = "thirduser@gmail.com",
                            Name = "Third",
                            TimeCreated = new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5740),
                            TimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Age = 22,
                            CreatedBy = "First",
                            Email = "fourthuser@gmail.com",
                            Name = "Foruth",
                            TimeCreated = new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5744),
                            TimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Age = 22,
                            CreatedBy = "First",
                            Email = "fifthuser@gmail.com",
                            Name = "Fifth",
                            TimeCreated = new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5746),
                            TimeModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("blog_infinity_dal.Domain.Blog", b =>
                {
                    b.HasOne("blog_infinity_dal.Domain.User", "User")
                        .WithMany("BlogsCreated")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}