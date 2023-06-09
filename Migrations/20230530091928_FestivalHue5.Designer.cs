﻿// <auto-generated />
using System;
using FestivalHue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FestivalHue.Migrations
{
    [DbContext(typeof(FestivalHueContext))]
    [Migration("20230530091928_FestivalHue5")]
    partial class FestivalHue5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FestivalHue.Dto.FavouriteProgramDto", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("FavouriteProgramDto");
                });

            modelBuilder.Entity("FestivalHue.Models.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AboutId");

                    b.ToTable("About");
                });

            modelBuilder.Entity("FestivalHue.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("AdminId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("FestivalHue.Models.Checkin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId", "TicketId");

                    b.HasIndex("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Checkin");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteProgram", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "ProgramId");

                    b.HasIndex("ProgramId");

                    b.ToTable("FavouriteProgram");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteService", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("FavouriteService");
                });

            modelBuilder.Entity("FestivalHue.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("FestivalHue.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lattitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationMap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pathimage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typedata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("FestivalHue.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<string>("PathIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeData")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("FestivalHue.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("arrange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isnew")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsId");

                    b.HasIndex("AdminId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("FestivalHue.Models.Notification", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProgramName")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProgramId");

                    b.HasIndex("ProgramId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("FestivalHue.Models.ProgramType", b =>
                {
                    b.Property<int>("Type_program")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Type_program"));

                    b.Property<string>("ProgramTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type_program");

                    b.ToTable("ProgramType");
                });

            modelBuilder.Entity("FestivalHue.Models.Programm", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Md5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProgramContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<int>("Type_inoff")
                        .HasColumnType("int");

                    b.Property<int>("Type_program")
                        .HasColumnType("int");

                    b.Property<int>("arrange")
                        .HasColumnType("int");

                    b.HasKey("ProgramId");

                    b.HasIndex("AdminId");

                    b.HasIndex("GroupId");

                    b.HasIndex("LocationId");

                    b.HasIndex("Type_program");

                    b.ToTable("Program");
                });

            modelBuilder.Entity("FestivalHue.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("FestivalHue.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubMenuId")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeData")
                        .HasColumnType("int");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("FestivalHue.Models.SubMenu", b =>
                {
                    b.Property<int>("SubMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubMenuId"));

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("PathIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeData")
                        .HasColumnType("int");

                    b.HasKey("SubMenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("FestivalHue.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("ProgramId");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("FestivalHue.Models.TicketLocation", b =>
                {
                    b.Property<int>("TicketLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketLocationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Arrange")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Laititude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longtitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Md5")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.HasKey("TicketLocationId");

                    b.ToTable("TicketLocation");
                });

            modelBuilder.Entity("FestivalHue.Models.TicketType", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketTypeId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TicketName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketTypeId");

                    b.ToTable("TicketType");
                });

            modelBuilder.Entity("FestivalHue.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ServiceSubMenu", b =>
                {
                    b.Property<int>("ServicesServiceId")
                        .HasColumnType("int");

                    b.Property<int>("SubMenusSubMenuId")
                        .HasColumnType("int");

                    b.HasKey("ServicesServiceId", "SubMenusSubMenuId");

                    b.HasIndex("SubMenusSubMenuId");

                    b.ToTable("ServiceSubMenu");
                });

            modelBuilder.Entity("ServiceUser", b =>
                {
                    b.Property<int>("ServicesServiceId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("ServicesServiceId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("ServiceUser");
                });

            modelBuilder.Entity("FestivalHue.Models.Admin", b =>
                {
                    b.HasOne("FestivalHue.Models.Role", "Role")
                        .WithMany("Admins")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FestivalHue.Models.Checkin", b =>
                {
                    b.HasOne("FestivalHue.Models.Admin", "Admin")
                        .WithMany("Checkins")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Ticket", "Ticket")
                        .WithMany("Checkins")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", null)
                        .WithMany("Checkins")
                        .HasForeignKey("UserId");

                    b.Navigation("Admin");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteProgram", b =>
                {
                    b.HasOne("FestivalHue.Models.Programm", "Programm")
                        .WithMany("FavouritePrograms")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany("FavouritePrograms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Programm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteService", b =>
                {
                    b.HasOne("FestivalHue.Models.Service", "Service")
                        .WithMany("FavouriteServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany("FavouriteServices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.News", b =>
                {
                    b.HasOne("FestivalHue.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("FestivalHue.Models.Notification", b =>
                {
                    b.HasOne("FestivalHue.Models.Programm", "Programm")
                        .WithMany("Notifications")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Programm");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.Programm", b =>
                {
                    b.HasOne("FestivalHue.Models.Admin", "Admin")
                        .WithMany("Programms")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Group", "Group")
                        .WithMany("Programms")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Location", "Location")
                        .WithMany("Programms")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.ProgramType", "ProgramType")
                        .WithMany("Programms")
                        .HasForeignKey("Type_program")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Group");

                    b.Navigation("Location");

                    b.Navigation("ProgramType");
                });

            modelBuilder.Entity("FestivalHue.Models.SubMenu", b =>
                {
                    b.HasOne("FestivalHue.Models.Menu", "Menu")
                        .WithMany("SubMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("FestivalHue.Models.Ticket", b =>
                {
                    b.HasOne("FestivalHue.Models.Programm", "Programm")
                        .WithMany("Tickets")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.TicketType", "TicketType")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Programm");

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.User", b =>
                {
                    b.HasOne("FestivalHue.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ServiceSubMenu", b =>
                {
                    b.HasOne("FestivalHue.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.SubMenu", null)
                        .WithMany()
                        .HasForeignKey("SubMenusSubMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServiceUser", b =>
                {
                    b.HasOne("FestivalHue.Models.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalHue.Models.Admin", b =>
                {
                    b.Navigation("Checkins");

                    b.Navigation("Programms");
                });

            modelBuilder.Entity("FestivalHue.Models.Group", b =>
                {
                    b.Navigation("Programms");
                });

            modelBuilder.Entity("FestivalHue.Models.Location", b =>
                {
                    b.Navigation("Programms");
                });

            modelBuilder.Entity("FestivalHue.Models.Menu", b =>
                {
                    b.Navigation("SubMenus");
                });

            modelBuilder.Entity("FestivalHue.Models.ProgramType", b =>
                {
                    b.Navigation("Programms");
                });

            modelBuilder.Entity("FestivalHue.Models.Programm", b =>
                {
                    b.Navigation("FavouritePrograms");

                    b.Navigation("Notifications");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FestivalHue.Models.Role", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FestivalHue.Models.Service", b =>
                {
                    b.Navigation("FavouriteServices");
                });

            modelBuilder.Entity("FestivalHue.Models.Ticket", b =>
                {
                    b.Navigation("Checkins");
                });

            modelBuilder.Entity("FestivalHue.Models.TicketType", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FestivalHue.Models.User", b =>
                {
                    b.Navigation("Checkins");

                    b.Navigation("FavouritePrograms");

                    b.Navigation("FavouriteServices");

                    b.Navigation("Notifications");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
