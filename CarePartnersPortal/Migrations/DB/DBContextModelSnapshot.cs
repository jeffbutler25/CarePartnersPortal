﻿// <auto-generated />
using System;
using CarePartnersPortal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarePartnersPortal.Migrations.DB
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarePartnersPortal.Branch", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Approvers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ITEquipmentOrderID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ITEquipmentOrderID");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CarePartnersPortal.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Approvers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ITEquipmentOrderID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ITEquipmentOrderID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CarePartnersPortal.EmployeeHire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditonalRequirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HireType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("EmployeeHires");
                });

            modelBuilder.Entity("CarePartnersPortal.HireType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HireTypes");
                });

            modelBuilder.Entity("CarePartnersPortal.ITEquipmentOrder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInformaiton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApprovalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<string>("Approver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("OtherAddress")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestedFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requester")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Suite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ITEquipmentOrders");
                });

            modelBuilder.Entity("CarePartnersPortal.ITOutage", b =>
                {
                    b.Property<string>("IncidentType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CrationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpactedSystems")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImpactedUsers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutageEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OutageStart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentType");

                    b.ToTable("ITOutages");
                });

            modelBuilder.Entity("CarePartnersPortal.ITSystem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactsExternal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactsInternal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationGroup")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ITSystems");
                });

            modelBuilder.Entity("CarePartnersPortal.JobTitle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("CarePartnersPortal.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ITEquipmentOrderID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ITEquipmentOrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("CarePartnersPortal.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Approvers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CarePartnersPortal.TempPW", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Access")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeExpiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TempPWs");
                });

            modelBuilder.Entity("CarePartnersPortal.Branch", b =>
                {
                    b.HasOne("CarePartnersPortal.ITEquipmentOrder", null)
                        .WithMany("Branches")
                        .HasForeignKey("ITEquipmentOrderID");
                });

            modelBuilder.Entity("CarePartnersPortal.Department", b =>
                {
                    b.HasOne("CarePartnersPortal.ITEquipmentOrder", null)
                        .WithMany("Departments")
                        .HasForeignKey("ITEquipmentOrderID");
                });

            modelBuilder.Entity("CarePartnersPortal.OrderItem", b =>
                {
                    b.HasOne("CarePartnersPortal.ITEquipmentOrder", null)
                        .WithMany("Cart")
                        .HasForeignKey("ITEquipmentOrderID");
                });
#pragma warning restore 612, 618
        }
    }
}
