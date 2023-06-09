﻿// <auto-generated />
using CompanyManagement.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompanyManagement.DAL.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyManagement.DAL.Data.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CompanyManagement.DAL.Data.Models.Developer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("CompanyManagement.DAL.Data.Models.Ticket", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("deptid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("deptid");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.Property<int>("Developersid")
                        .HasColumnType("int");

                    b.Property<int>("Ticketsid")
                        .HasColumnType("int");

                    b.HasKey("Developersid", "Ticketsid");

                    b.HasIndex("Ticketsid");

                    b.ToTable("DeveloperTicket");
                });

            modelBuilder.Entity("CompanyManagement.DAL.Data.Models.Ticket", b =>
                {
                    b.HasOne("CompanyManagement.DAL.Data.Models.Department", "dept")
                        .WithMany("Tickets")
                        .HasForeignKey("deptid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dept");
                });

            modelBuilder.Entity("DeveloperTicket", b =>
                {
                    b.HasOne("CompanyManagement.DAL.Data.Models.Developer", null)
                        .WithMany()
                        .HasForeignKey("Developersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyManagement.DAL.Data.Models.Ticket", null)
                        .WithMany()
                        .HasForeignKey("Ticketsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyManagement.DAL.Data.Models.Department", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
