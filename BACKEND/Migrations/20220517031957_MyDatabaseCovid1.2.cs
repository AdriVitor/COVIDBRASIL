using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COVID.Migrations
{
    public partial class MyDatabaseCovid12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "DataCountryModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CityCode",
                table: "DataCountryModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "DataCountryModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "DataCountryModels",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Deaths",
                table: "DataCountryModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lat",
                table: "DataCountryModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Lon",
                table: "DataCountryModels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "DataCountryModels",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "CityCode",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "Deaths",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "DataCountryModels");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "DataCountryModels");
        }
    }
}
