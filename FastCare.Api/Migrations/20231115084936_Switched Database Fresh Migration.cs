using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastCare.Api.Migrations
{
    /// <inheritdoc />
    public partial class SwitchedDatabaseFreshMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DoctorRatings = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorExperience = table.Column<int>(type: "INTEGER", nullable: false),
                    DoctorDegree = table.Column<string>(type: "TEXT", nullable: true),
                    DoctorBio = table.Column<string>(type: "TEXT", nullable: true),
                    DoctorLocation = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
