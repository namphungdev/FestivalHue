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
    [Migration("20230504075817_Dbinit")]
    partial class Dbinit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdminTicket", b =>
                {
                    b.Property<int>("AdminsAdminId")
                        .HasColumnType("int");

                    b.Property<int>("TicketsTicketId")
                        .HasColumnType("int");

                    b.HasKey("AdminsAdminId", "TicketsTicketId");

                    b.HasIndex("TicketsTicketId");

                    b.ToTable("AdminTicket");
                });

            modelBuilder.Entity("FestivalHue.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AdminName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("Created_at")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.HasKey("AdminId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RoleId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("FestivalHue.Models.Checkin", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId", "UserId");

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

                    b.Property<string>("GroupDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Lattitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationImage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationMap")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pathimage")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Typedata")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("longtitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("FestivalHue.Models.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuId"));

                    b.Property<int?>("MenuId1")
                        .HasColumnType("int");

                    b.Property<string>("PathIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeData")
                        .HasColumnType("int");

                    b.HasKey("MenuId");

                    b.HasIndex("MenuId1");

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

            modelBuilder.Entity("FestivalHue.Models.Program", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<int>("Latitude")
                        .HasColumnType("int");

                    b.Property<int>("Longtitude")
                        .HasColumnType("int");

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

                    b.Property<int?>("SubMenuId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeData")
                        .HasColumnType("int");

                    b.HasKey("SubMenuId");

                    b.HasIndex("MenuId");

                    b.HasIndex("SubMenuId1");

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

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
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

                    b.Property<int>("Address")
                        .HasColumnType("int");

                    b.Property<int>("Arrange")
                        .HasColumnType("int");

                    b.Property<int>("Content")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("Image")
                        .HasColumnType("int");

                    b.Property<int>("Laititude")
                        .HasColumnType("int");

                    b.Property<int>("Longtitude")
                        .HasColumnType("int");

                    b.Property<int>("Md5")
                        .HasColumnType("int");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<int>("Title")
                        .HasColumnType("int");

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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Created_at")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("RoleId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("Updated_at")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId1");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProgramUser", b =>
                {
                    b.Property<int>("ProgramsProgramId")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserId")
                        .HasColumnType("int");

                    b.HasKey("ProgramsProgramId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("ProgramUser");
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

            modelBuilder.Entity("AdminTicket", b =>
                {
                    b.HasOne("FestivalHue.Models.Admin", null)
                        .WithMany()
                        .HasForeignKey("AdminsAdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Ticket", null)
                        .WithMany()
                        .HasForeignKey("TicketsTicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FestivalHue.Models.Admin", b =>
                {
                    b.HasOne("FestivalHue.Models.Location", null)
                        .WithMany("Admins")
                        .HasForeignKey("LocationId");

                    b.HasOne("FestivalHue.Models.Role", "Role")
                        .WithMany("Admins")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FestivalHue.Models.Checkin", b =>
                {
                    b.HasOne("FestivalHue.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteProgram", b =>
                {
                    b.HasOne("FestivalHue.Models.Program", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.FavouriteService", b =>
                {
                    b.HasOne("FestivalHue.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.Menu", b =>
                {
                    b.HasOne("FestivalHue.Models.Menu", null)
                        .WithMany("Menus")
                        .HasForeignKey("MenuId1");
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
                    b.HasOne("FestivalHue.Models.Program", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.Program", b =>
                {
                    b.HasOne("FestivalHue.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Group");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("FestivalHue.Models.SubMenu", b =>
                {
                    b.HasOne("FestivalHue.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.SubMenu", null)
                        .WithMany("SubMenus")
                        .HasForeignKey("SubMenuId1");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("FestivalHue.Models.Ticket", b =>
                {
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

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FestivalHue.Models.User", b =>
                {
                    b.HasOne("FestivalHue.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", null)
                        .WithMany("Users")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ProgramUser", b =>
                {
                    b.HasOne("FestivalHue.Models.Program", null)
                        .WithMany()
                        .HasForeignKey("ProgramsProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FestivalHue.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("FestivalHue.Models.Location", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("FestivalHue.Models.Menu", b =>
                {
                    b.Navigation("Menus");
                });

            modelBuilder.Entity("FestivalHue.Models.Role", b =>
                {
                    b.Navigation("Admins");
                });

            modelBuilder.Entity("FestivalHue.Models.SubMenu", b =>
                {
                    b.Navigation("SubMenus");
                });

            modelBuilder.Entity("FestivalHue.Models.TicketType", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FestivalHue.Models.User", b =>
                {
                    b.Navigation("Tickets");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
