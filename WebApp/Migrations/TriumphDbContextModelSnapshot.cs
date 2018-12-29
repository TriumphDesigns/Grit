﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

namespace WebApp.Migrations
{
    [DbContext(typeof(TriumphDbContext))]
    partial class TriumphDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedToIDEmpID");

                    b.Property<string>("BusinessName");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("ClientID");

                    b.HasIndex("AssignedToIDEmpID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApp.Models.Client+Note", b =>
                {
                    b.Property<int>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("NoteId");

                    b.HasIndex("ClientID");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("WebApp.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("OwnerID");

                    b.Property<string>("State");

                    b.Property<int>("Status");

                    b.Property<string>("Zip");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WebApp.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("EnumRoles");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Notes");

                    b.Property<string>("Phone");

                    b.HasKey("EmpID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApp.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedClientIDClientID");

                    b.Property<string>("Attributes");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Name");

                    b.Property<string>("Priority");

                    b.HasKey("ID");

                    b.HasIndex("AssignedClientIDClientID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebApp.ViewModel.ClientViewModel", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignedEmpID");

                    b.Property<string>("BusinessName");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("ClientID");

                    b.HasIndex("AssignedEmpID");

                    b.ToTable("ClientVM");
                });

            modelBuilder.Entity("WebApp.Models.Client", b =>
                {
                    b.HasOne("WebApp.Models.Employee", "AssignedToID")
                        .WithMany()
                        .HasForeignKey("AssignedToIDEmpID");
                });

            modelBuilder.Entity("WebApp.Models.Client+Note", b =>
                {
                    b.HasOne("WebApp.Models.Client", "ClientId")
                        .WithMany("Notes")
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("WebApp.Models.Project", b =>
                {
                    b.HasOne("WebApp.Models.Client", "AssignedClientID")
                        .WithMany()
                        .HasForeignKey("AssignedClientIDClientID");
                });

            modelBuilder.Entity("WebApp.ViewModel.ClientViewModel", b =>
                {
                    b.HasOne("WebApp.Models.Employee", "Assigned")
                        .WithMany()
                        .HasForeignKey("AssignedEmpID");
                });
#pragma warning restore 612, 618
        }
    }
}
