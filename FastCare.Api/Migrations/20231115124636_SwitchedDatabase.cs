using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastCare.Api.Migrations
{
    /// <inheritdoc />
    public partial class SwitchedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    Ratings = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    MedicalAccountType = table.Column<int>(type: "int", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    DrugId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DrugName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugWeight = table.Column<int>(type: "int", nullable: false),
                    DrugVolume = table.Column<int>(type: "int", nullable: false),
                    DrugPrice = table.Column<double>(type: "float", nullable: false),
                    DrugDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrugManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.DrugId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Drugs");
        }
    }
}
