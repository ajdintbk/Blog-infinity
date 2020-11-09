using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blog_infinity_dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeModified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    TimeModified = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 64, nullable: false),
                    Summary = table.Column<string>(maxLength: 350, nullable: false),
                    Content = table.Column<string>(maxLength: 3500, nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedBy", "Email", "ModifiedBy", "Name", "TimeCreated", "TimeModified" },
                values: new object[,]
                {
                    { 1, 22, "First", "firstuser@gmail.com", null, "First", new DateTime(2020, 11, 9, 10, 14, 29, 330, DateTimeKind.Utc).AddTicks(9366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 22, "First", "seconduser@gmail.com", null, "Second", new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5666), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 22, "First", "thirduser@gmail.com", null, "Third", new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5740), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 22, "First", "fourthuser@gmail.com", null, "Foruth", new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5744), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 22, "First", "fifthuser@gmail.com", null, "Fifth", new DateTime(2020, 11, 9, 10, 14, 29, 331, DateTimeKind.Utc).AddTicks(5746), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
