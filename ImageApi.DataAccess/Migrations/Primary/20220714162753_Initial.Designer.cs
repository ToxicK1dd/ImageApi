﻿// <auto-generated />
using System;
using ImageApi.DataAccess.Models.Primary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImageApi.DataAccess.Migrations.Primary
{
    [DbContext(typeof(PrimaryContext))]
    [Migration("20220714162753_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AccountAccountRole", b =>
                {
                    b.Property<Guid>("AccountsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RolesId")
                        .HasColumnType("char(36)");

                    b.HasKey("AccountsId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("AccountAccountRole");
                });

            modelBuilder.Entity("DocumentShare", b =>
                {
                    b.Property<Guid>("DocumentsId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SharesId")
                        .HasColumnType("char(36)");

                    b.HasKey("DocumentsId", "SharesId");

                    b.HasIndex("SharesId");

                    b.ToTable("DocumentShare");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Account.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<bool>("Validated")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Account");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Firstname")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Lastname")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("MiddleNames")
                        .HasMaxLength(768)
                        .HasColumnType("varchar(768)");

                    b.Property<string>("Nationality")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("AccountInfo");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.AccountRole.AccountRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Address.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("AdditionalStreet")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AccountInfoId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ContactInfo.ContactInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("AccountInfoId")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Document.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<byte[]>("Blob")
                        .IsRequired()
                        .HasColumnType("LONGBLOB");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Document");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.DocumentDetail.DocumentDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("ByteSize")
                        .HasColumnType("int");

                    b.Property<Guid>("DocumentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("DocumentDetail");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.DocumentSignature.DocumentSignature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DocumentId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("DocumentSignature");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Login.Login", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.LoginDetail.LoginDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<Guid>("LoginId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Success")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("LoginId");

                    b.ToTable("LoginDetail");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.RefreshToken.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("LoginId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("LoginId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Share.Share", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("SharedWithAccountId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("SharedWithAccountId");

                    b.ToTable("Share");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ShareDetail.ShareDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid>("ShareId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ShareId");

                    b.ToTable("ShareDetail");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.SocialSecurityNumber.SocialSecurityNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountInfoId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("SocialSecurityNumber");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ValidationCode.ValidationCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("ValidationCode");
                });

            modelBuilder.Entity("AccountAccountRole", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImageApi.DataAccess.Models.Primary.AccountRole.AccountRole", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentShare", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Document.Document", null)
                        .WithMany()
                        .HasForeignKey("DocumentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImageApi.DataAccess.Models.Primary.Share.Share", null)
                        .WithMany()
                        .HasForeignKey("SharesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "Account")
                        .WithOne("AccountInfo")
                        .HasForeignKey("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Address.Address", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", "AccountInfo")
                        .WithMany("Addresses")
                        .HasForeignKey("AccountInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountInfo");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ContactInfo.ContactInfo", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", "AccountInfo")
                        .WithOne("ContactInfo")
                        .HasForeignKey("ImageApi.DataAccess.Models.Primary.ContactInfo.ContactInfo", "AccountInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountInfo");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Document.Document", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "Account")
                        .WithMany("Documents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.DocumentDetail.DocumentDetail", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Document.Document", "Document")
                        .WithOne("Detail")
                        .HasForeignKey("ImageApi.DataAccess.Models.Primary.DocumentDetail.DocumentDetail", "DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.DocumentSignature.DocumentSignature", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Document.Document", "Document")
                        .WithMany("Signatures")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Login.Login", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "Account")
                        .WithOne("Login")
                        .HasForeignKey("ImageApi.DataAccess.Models.Primary.Login.Login", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.LoginDetail.LoginDetail", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Login.Login", "Login")
                        .WithMany("LoginDetails")
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.RefreshToken.RefreshToken", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Login.Login", "Login")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Share.Share", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "Account")
                        .WithMany("Shares")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "SharedWithAccount")
                        .WithMany("Shared")
                        .HasForeignKey("SharedWithAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("SharedWithAccount");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ShareDetail.ShareDetail", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Share.Share", "Share")
                        .WithMany("ShareDetails")
                        .HasForeignKey("ShareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Share");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.SocialSecurityNumber.SocialSecurityNumber", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", "AccountInfo")
                        .WithMany("SocialSecurityNumbers")
                        .HasForeignKey("AccountInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountInfo");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.ValidationCode.ValidationCode", b =>
                {
                    b.HasOne("ImageApi.DataAccess.Models.Primary.Account.Account", "Account")
                        .WithOne("ValidationCode")
                        .HasForeignKey("ImageApi.DataAccess.Models.Primary.ValidationCode.ValidationCode", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Account.Account", b =>
                {
                    b.Navigation("AccountInfo");

                    b.Navigation("Documents");

                    b.Navigation("Login");

                    b.Navigation("Shared");

                    b.Navigation("Shares");

                    b.Navigation("ValidationCode");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.AccountInfo.AccountInfo", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("ContactInfo");

                    b.Navigation("SocialSecurityNumbers");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Document.Document", b =>
                {
                    b.Navigation("Detail");

                    b.Navigation("Signatures");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Login.Login", b =>
                {
                    b.Navigation("LoginDetails");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("ImageApi.DataAccess.Models.Primary.Share.Share", b =>
                {
                    b.Navigation("ShareDetails");
                });
#pragma warning restore 612, 618
        }
    }
}