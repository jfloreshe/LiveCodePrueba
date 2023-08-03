using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoleBased.Migrations
{
    /// <inheritdoc />
    public partial class Setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    IdProfile = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LogUserCreation = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LogUserModification = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LogDateCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    LogDateModification = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.IdProfile);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    LogUserCreation = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    LogUserModification = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LogDateCreation = table.Column<DateTime>(type: "datetime", nullable: false),
                    LogDateModification = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "ProfileUser",
                columns: table => new
                {
                    ProfilesIdProfile = table.Column<int>(type: "int", nullable: false),
                    UsersIdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUser", x => new { x.ProfilesIdProfile, x.UsersIdUser });
                    table.ForeignKey(
                        name: "FK_ProfileUser_Profiles_ProfilesIdProfile",
                        column: x => x.ProfilesIdProfile,
                        principalTable: "Profiles",
                        principalColumn: "IdProfile",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileUser_Users_UsersIdUser",
                        column: x => x.UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileUser_UsersIdUser",
                table: "ProfileUser",
                column: "UsersIdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfileUser");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
