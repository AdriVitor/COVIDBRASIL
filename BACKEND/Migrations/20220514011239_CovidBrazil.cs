using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COVID.Migrations
{
    public partial class CovidBrazil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataCountryModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    Confirmed = table.Column<int>(type: "INTEGER", nullable: false),
                    Recovered = table.Column<int>(type: "INTEGER", nullable: false),
                    Active = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCountryModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataCountryModels");
        }
    }
}
