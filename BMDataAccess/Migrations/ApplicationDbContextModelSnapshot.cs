﻿// <auto-generated />
using System;
using BMDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BMDataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BMModel.Advertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfAdvertise")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KindId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("TransferId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidityDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KindId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("SenderId");

                    b.HasIndex("TransferId");

                    b.ToTable("Advertise");
                });

            modelBuilder.Entity("BMModel.Areas.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("BMModel.Areas.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("BMModel.Categories.Kind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DocId")
                        .HasColumnType("int");

                    b.Property<int>("ElectronicId")
                        .HasColumnType("int");

                    b.Property<int>("NonElectronicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocId");

                    b.HasIndex("ElectronicId");

                    b.HasIndex("NonElectronicId");

                    b.ToTable("Kind");
                });

            modelBuilder.Entity("BMModel.Categories.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("BMModel.Categories.Types.Doc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Doc");
                });

            modelBuilder.Entity("BMModel.Categories.Types.Electronic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Electronic");
                });

            modelBuilder.Entity("BMModel.Categories.Types.NonElectronic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<double>("Width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("NonElectronic");
                });

            modelBuilder.Entity("BMModel.Personals.Receiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberIran")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberTurkey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Receiver");
                });

            modelBuilder.Entity("BMModel.Personals.Sender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberIran")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberTurkey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Sender");
                });

            modelBuilder.Entity("BMModel.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationCityId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationCountryId")
                        .HasColumnType("int");

                    b.Property<int>("KindId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OriginCityId")
                        .HasColumnType("int");

                    b.Property<int>("OriginCountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PickUpTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DestinationCityId");

                    b.HasIndex("DestinationCountryId");

                    b.HasIndex("KindId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("OriginCityId");

                    b.HasIndex("OriginCountryId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Transfer");
                });

            modelBuilder.Entity("BMModel.Advertise", b =>
                {
                    b.HasOne("BMModel.Categories.Kind", "Kind")
                        .WithMany()
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Categories.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Personals.Sender", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Transfer", "Transfer")
                        .WithMany()
                        .HasForeignKey("TransferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kind");

                    b.Navigation("Material");

                    b.Navigation("Sender");

                    b.Navigation("Transfer");
                });

            modelBuilder.Entity("BMModel.Categories.Kind", b =>
                {
                    b.HasOne("BMModel.Categories.Types.Doc", "Doc")
                        .WithMany()
                        .HasForeignKey("DocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Categories.Types.Electronic", "Electronic")
                        .WithMany()
                        .HasForeignKey("ElectronicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Categories.Types.NonElectronic", "NonElectronic")
                        .WithMany()
                        .HasForeignKey("NonElectronicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doc");

                    b.Navigation("Electronic");

                    b.Navigation("NonElectronic");
                });

            modelBuilder.Entity("BMModel.Personals.Receiver", b =>
                {
                    b.HasOne("BMModel.Areas.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Areas.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BMModel.Personals.Sender", b =>
                {
                    b.HasOne("BMModel.Areas.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Areas.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BMModel.Transfer", b =>
                {
                    b.HasOne("BMModel.Areas.City", "DestinationCity")
                        .WithMany()
                        .HasForeignKey("DestinationCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Areas.Country", "DestinationCountry")
                        .WithMany()
                        .HasForeignKey("DestinationCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Categories.Kind", "Kind")
                        .WithMany()
                        .HasForeignKey("KindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Categories.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Areas.City", "OriginCity")
                        .WithMany()
                        .HasForeignKey("OriginCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Areas.Country", "Country")
                        .WithMany()
                        .HasForeignKey("OriginCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Personals.Receiver", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BMModel.Personals.Sender", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("DestinationCity");

                    b.Navigation("DestinationCountry");

                    b.Navigation("Kind");

                    b.Navigation("Material");

                    b.Navigation("OriginCity");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });
#pragma warning restore 612, 618
        }
    }
}
