﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG73020_EAD_Group1.Entities;

#nullable disable

namespace PROG73020EADGroup1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Project_Account", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("Projects_Accounts");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Account", b =>
                {
                    b.HasOne("PROG73020_EAD_Group1.Entities.Project", null)
                        .WithMany("Members")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Project_Account", b =>
                {
                    b.HasOne("PROG73020_EAD_Group1.Entities.Account", "Account")
                        .WithMany("Projects_Accounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG73020_EAD_Group1.Entities.Project", "Project")
                        .WithMany("Projects_Accounts")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Account", b =>
                {
                    b.Navigation("Projects_Accounts");
                });

            modelBuilder.Entity("PROG73020_EAD_Group1.Entities.Project", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Projects_Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
