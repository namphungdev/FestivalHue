using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FestivalHue.Migrations
{
    /// <inheritdoc />
    public partial class Dbinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationImage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocationMap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pathimage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    longtitude = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Lattitude = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Typedata = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeData = table.Column<int>(type: "int", nullable: false),
                    MenuId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuId);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_MenuId1",
                        column: x => x.MenuId1,
                        principalTable: "Menu",
                        principalColumn: "MenuId");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeData = table.Column<int>(type: "int", nullable: false),
                    SubMenuId = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longtitude = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "TicketLocation",
                columns: table => new
                {
                    TicketLocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<int>(type: "int", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    Longtitude = table.Column<int>(type: "int", nullable: false),
                    Laititude = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<int>(type: "int", nullable: false),
                    Arrange = table.Column<int>(type: "int", nullable: false),
                    Md5 = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketLocation", x => x.TicketLocationId);
                });

            migrationBuilder.CreateTable(
                name: "TicketType",
                columns: table => new
                {
                    TicketTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketType", x => x.TicketTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SubMenu",
                columns: table => new
                {
                    SubMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeData = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenu", x => x.SubMenuId);
                    table.ForeignKey(
                        name: "FK_SubMenu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubMenu_SubMenu_SubMenuId1",
                        column: x => x.SubMenuId1,
                        principalTable: "SubMenu",
                        principalColumn: "SubMenuId");
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RoleId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admin_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Admin_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CMND = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceSubMenu",
                columns: table => new
                {
                    ServicesServiceId = table.Column<int>(type: "int", nullable: false),
                    SubMenusSubMenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSubMenu", x => new { x.ServicesServiceId, x.SubMenusSubMenuId });
                    table.ForeignKey(
                        name: "FK_ServiceSubMenu_Service_ServicesServiceId",
                        column: x => x.ServicesServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceSubMenu_SubMenu_SubMenusSubMenuId",
                        column: x => x.SubMenusSubMenuId,
                        principalTable: "SubMenu",
                        principalColumn: "SubMenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isnew = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    longtitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arrange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    AdminId = table.Column<int>(type: "int", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Type_inoff = table.Column<int>(type: "int", nullable: false),
                    Type_program = table.Column<int>(type: "int", nullable: false),
                    arrange = table.Column<int>(type: "int", nullable: false),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Md5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramId);
                    table.ForeignKey(
                        name: "FK_Program_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Program_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Program_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavouriteService",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteService", x => new { x.UserId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_FavouriteService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteService_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceUser",
                columns: table => new
                {
                    ServicesServiceId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceUser", x => new { x.ServicesServiceId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_ServiceUser_Service_ServicesServiceId",
                        column: x => x.ServicesServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TicketTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_TicketType_TicketTypeId",
                        column: x => x.TicketTypeId,
                        principalTable: "TicketType",
                        principalColumn: "TicketTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavouriteProgram",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteProgram", x => new { x.UserId, x.ProgramId });
                    table.ForeignKey(
                        name: "FK_FavouriteProgram_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteProgram_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    ProgramName = table.Column<int>(type: "int", nullable: false),
                    FDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => new { x.UserId, x.ProgramId });
                    table.ForeignKey(
                        name: "FK_Notification_Program_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notification_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramUser",
                columns: table => new
                {
                    ProgramsProgramId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramUser", x => new { x.ProgramsProgramId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_ProgramUser_Program_ProgramsProgramId",
                        column: x => x.ProgramsProgramId,
                        principalTable: "Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramUser_User_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminTicket",
                columns: table => new
                {
                    AdminsAdminId = table.Column<int>(type: "int", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTicket", x => new { x.AdminsAdminId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_AdminTicket_Admin_AdminsAdminId",
                        column: x => x.AdminsAdminId,
                        principalTable: "Admin",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminTicket_Ticket_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => new { x.TicketId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Checkin_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkin_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_LocationId",
                table: "Admin",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_RoleId",
                table: "Admin",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTicket_TicketsTicketId",
                table: "AdminTicket",
                column: "TicketsTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_UserId",
                table: "Checkin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteProgram_ProgramId",
                table: "FavouriteProgram",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteService_ServiceId",
                table: "FavouriteService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_MenuId1",
                table: "Menu",
                column: "MenuId1");

            migrationBuilder.CreateIndex(
                name: "IX_News_AdminId",
                table: "News",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_ProgramId",
                table: "Notification",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_AdminId",
                table: "Program",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_GroupId",
                table: "Program",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_LocationId",
                table: "Program",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramUser_UsersUserId",
                table: "ProgramUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceSubMenu_SubMenusSubMenuId",
                table: "ServiceSubMenu",
                column: "SubMenusSubMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceUser_UsersUserId",
                table: "ServiceUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_MenuId",
                table: "SubMenu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenu_SubMenuId1",
                table: "SubMenu",
                column: "SubMenuId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketTypeId",
                table: "Ticket",
                column: "TicketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId1",
                table: "User",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminTicket");

            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "FavouriteProgram");

            migrationBuilder.DropTable(
                name: "FavouriteService");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "ProgramUser");

            migrationBuilder.DropTable(
                name: "ServiceSubMenu");

            migrationBuilder.DropTable(
                name: "ServiceUser");

            migrationBuilder.DropTable(
                name: "TicketLocation");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "SubMenu");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "TicketType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
