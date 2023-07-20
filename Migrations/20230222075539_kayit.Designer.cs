﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using marsev.Context;

#nullable disable

namespace marsev.Migrations
{
    [DbContext(typeof(MMDbContext))]
    [Migration("20230222075539_kayit")]
    partial class kayit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("marsev.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "$2a$11$TL8s62Ik3JvkVWYCeku.r.hCFAJBqmP3Xa3vIHOCA.MXC0N9KfNSO",
                            Role = 1,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "$2a$11$vD4fm/e4l4tPSBALv1EVa.li5PwbdeWyBlnJKgpLo0pul1nKjRz4y",
                            Role = 2,
                            UserName = "merve"
                        });
                });

            modelBuilder.Entity("marsev.Models.Etkinlik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtkinlikAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EtkinlikTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EtkinlikTipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EtkinlikTuru")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Etkinlikler");
                });

            modelBuilder.Entity("marsev.Models.FormModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mesaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("İletisimFormu");
                });

            modelBuilder.Entity("marsev.Models.Kayit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kurum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meslek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kursId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kayitlar");
                });

            modelBuilder.Entity("marsev.Models.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Fiyat")
                        .HasColumnType("int");

                    b.Property<string>("KitapAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapResmi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("marsev.Models.KitapTalepModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kitap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kitapId")
                        .HasColumnType("int");

                    b.Property<string>("soyisim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefonno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KitapTalepleri");
                });
#pragma warning restore 612, 618
        }
    }
}
