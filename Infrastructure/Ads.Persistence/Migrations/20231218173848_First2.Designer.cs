﻿// <auto-generated />
using System;
using Ads.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ads.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231218173848_First2")]
    partial class First2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ClickCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("OnSale")
                        .HasColumnType("bit");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("UserId");

                    b.ToTable("AdvertComments");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("AdvertImagePath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("AdvertImages");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Rating")
                        .HasMaxLength(5)
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("UserId");

                    b.ToTable("AdvertRatings");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertSliderImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("AdvertSliderImagePath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("AdvertSliderImage");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.CategoryAdvert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryAdverts");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PageImagePath")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 12, 18, 20, 38, 48, 271, DateTimeKind.Local).AddTicks(7605),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Theme = "Dark Theme",
                            Value = "Black"
                        });
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.SubCategoryAdvert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("SubCategoryAdverts");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("SettingId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserImagePath")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("SettingId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ankara",
                            AdvertId = 0,
                            CreatedDate = new DateTime(2023, 12, 18, 20, 38, 48, 271, DateTimeKind.Local).AddTicks(7856),
                            Email = "admin@test.com",
                            FirstName = "Admin",
                            IsActive = true,
                            LastName = "Admin",
                            Password = "123",
                            Phone = "0850",
                            RoleId = 1,
                            SettingId = 1,
                            UserGuid = new Guid("70f64220-402a-4782-9457-09389bb0be64"),
                            UserImagePath = "Ankara Ankara Ankara",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("OtoServisSatis.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TcNo")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("AdvertId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Advert", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.User", "User")
                        .WithMany("Adverts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertComment", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("AdvertComments")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ads.Domain.Entities.Concrete.User", "User")
                        .WithMany("AdvertComments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertImage", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("AdvertImages")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertRating", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("AdvertRatings")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Ads.Domain.Entities.Concrete.User", "User")
                        .WithMany("AdvertRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.AdvertSliderImage", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("AdvertSliderImages")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.CategoryAdvert", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("CategoryAdverts")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ads.Domain.Entities.Concrete.Category", "Category")
                        .WithMany("CategoryAdverts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Setting", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Page", "Page")
                        .WithMany("Settings")
                        .HasForeignKey("PageId");

                    b.Navigation("Page");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.SubCategory", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.SubCategoryAdvert", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("SubCategoryAdverts")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ads.Domain.Entities.Concrete.SubCategory", "SubCategory")
                        .WithMany("SubCategoryAdverts")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.User", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Ads.Domain.Entities.Concrete.Setting", "Setting")
                        .WithMany("Users")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Setting");
                });

            modelBuilder.Entity("OtoServisSatis.Entities.Customer", b =>
                {
                    b.HasOne("Ads.Domain.Entities.Concrete.Advert", "Advert")
                        .WithMany("Customers")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Advert", b =>
                {
                    b.Navigation("AdvertComments");

                    b.Navigation("AdvertImages");

                    b.Navigation("AdvertRatings");

                    b.Navigation("AdvertSliderImages");

                    b.Navigation("CategoryAdverts");

                    b.Navigation("Customers");

                    b.Navigation("SubCategoryAdverts");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Category", b =>
                {
                    b.Navigation("CategoryAdverts");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Page", b =>
                {
                    b.Navigation("Settings");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.Setting", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.SubCategory", b =>
                {
                    b.Navigation("SubCategoryAdverts");
                });

            modelBuilder.Entity("Ads.Domain.Entities.Concrete.User", b =>
                {
                    b.Navigation("AdvertComments");

                    b.Navigation("AdvertRatings");

                    b.Navigation("Adverts");
                });
#pragma warning restore 612, 618
        }
    }
}
