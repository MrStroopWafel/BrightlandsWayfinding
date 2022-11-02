﻿// <auto-generated />
using System;
using BrightlandsCasus.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrightlandsCasus.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BrightlandsCasus.Models.Stap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("LokaalId")
                        .HasColumnType("int");

                    b.Property<string>("StappenBeschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stap");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StappenBeschrijving = "Ingang"
                        },
                        new
                        {
                            Id = 2,
                            StappenBeschrijving = "Trap begaande grond"
                        },
                        new
                        {
                            Id = 3,
                            StappenBeschrijving = "WC"
                        },
                        new
                        {
                            Id = 4,
                            StappenBeschrijving = "Administratie"
                        },
                        new
                        {
                            Id = 5,
                            StappenBeschrijving = "Eerste verdieping lift"
                        },
                        new
                        {
                            Id = 6,
                            LokaalId = 1,
                            StappenBeschrijving = "Lokaal 1"
                        },
                        new
                        {
                            Id = 7,
                            StappenBeschrijving = "Zithal"
                        },
                        new
                        {
                            Id = 8,
                            StappenBeschrijving = "1e verdieping"
                        },
                        new
                        {
                            Id = 9,
                            StappenBeschrijving = "1e verdieping gang links"
                        },
                        new
                        {
                            Id = 10,
                            StappenBeschrijving = "1e verdieping gang rechts"
                        },
                        new
                        {
                            Id = 11,
                            StappenBeschrijving = "1e verdieping gang rechtdoor"
                        },
                        new
                        {
                            Id = 12,
                            LokaalId = 2,
                            StappenBeschrijving = "Lokaal 2"
                        },
                        new
                        {
                            Id = 13,
                            LokaalId = 3,
                            StappenBeschrijving = "Lokaal 3"
                        },
                        new
                        {
                            Id = 14,
                            LokaalId = 4,
                            StappenBeschrijving = "Lokaal 4"
                        },
                        new
                        {
                            Id = 15,
                            LokaalId = 5,
                            StappenBeschrijving = "Lokaal 5"
                        },
                        new
                        {
                            Id = 16,
                            LokaalId = 6,
                            StappenBeschrijving = "Lokaal 6"
                        });
                });

            modelBuilder.Entity("BrightlandsCasus.Models.StapConnectie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Afstand")
                        .HasColumnType("int");

                    b.Property<string>("RouteUitelg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StapFromId")
                        .HasColumnType("int");

                    b.Property<int>("StapToId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StapFromId");

                    b.HasIndex("StapToId");

                    b.ToTable("StapConnectie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Afstand = 2,
                            RouteUitelg = "Loop links naar de trap",
                            StapFromId = 1,
                            StapToId = 2
                        },
                        new
                        {
                            Id = 2,
                            Afstand = 3,
                            RouteUitelg = "Loop rechts naar de wc",
                            StapFromId = 1,
                            StapToId = 3
                        },
                        new
                        {
                            Id = 3,
                            Afstand = 2,
                            RouteUitelg = "Loop rechtdoor naar de administratie",
                            StapFromId = 1,
                            StapToId = 4
                        },
                        new
                        {
                            Id = 4,
                            Afstand = 5,
                            RouteUitelg = "Loop links naar de traplift",
                            StapFromId = 1,
                            StapToId = 5
                        },
                        new
                        {
                            Id = 5,
                            Afstand = 1,
                            RouteUitelg = "Loop rechtdoor naar de zithal",
                            StapFromId = 1,
                            StapToId = 7
                        },
                        new
                        {
                            Id = 6,
                            Afstand = 12,
                            RouteUitelg = "loop de trap op",
                            StapFromId = 2,
                            StapToId = 8
                        },
                        new
                        {
                            Id = 7,
                            Afstand = 6,
                            RouteUitelg = "Loop links de gang op",
                            StapFromId = 8,
                            StapToId = 9
                        },
                        new
                        {
                            Id = 8,
                            Afstand = 3,
                            RouteUitelg = "Loop rechts de gang op",
                            StapFromId = 8,
                            StapToId = 10
                        },
                        new
                        {
                            Id = 9,
                            Afstand = 6,
                            RouteUitelg = "Loop rechtdoor de gang op",
                            StapFromId = 8,
                            StapToId = 11
                        },
                        new
                        {
                            Id = 10,
                            Afstand = 8,
                            RouteUitelg = "Open de deur van lokaal 2",
                            StapFromId = 9,
                            StapToId = 12
                        },
                        new
                        {
                            Id = 11,
                            Afstand = 9,
                            RouteUitelg = "Open de deur van lokaal 3",
                            StapFromId = 9,
                            StapToId = 13
                        },
                        new
                        {
                            Id = 12,
                            Afstand = 2,
                            RouteUitelg = "Open de deur van lokaal 4",
                            StapFromId = 10,
                            StapToId = 14
                        },
                        new
                        {
                            Id = 13,
                            Afstand = 4,
                            RouteUitelg = "Open de deur van lokaal 5",
                            StapFromId = 10,
                            StapToId = 15
                        },
                        new
                        {
                            Id = 14,
                            Afstand = 5,
                            RouteUitelg = "Open de deur van lokaal 6",
                            StapFromId = 11,
                            StapToId = 16
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BrightlandsCasus.Models.StapConnectie", b =>
                {
                    b.HasOne("BrightlandsCasus.Models.Stap", "StapFrom")
                        .WithMany("ConnectieStartPoints")
                        .HasForeignKey("StapFromId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BrightlandsCasus.Models.Stap", "StapTo")
                        .WithMany("ConnectieEnds")
                        .HasForeignKey("StapToId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StapFrom");

                    b.Navigation("StapTo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrightlandsCasus.Models.Stap", b =>
                {
                    b.Navigation("ConnectieEnds");

                    b.Navigation("ConnectieStartPoints");
                });
#pragma warning restore 612, 618
        }
    }
}
