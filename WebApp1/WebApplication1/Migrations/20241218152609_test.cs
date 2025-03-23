using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcilModels",
                columns: table => new
                {
                    AcilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BolumId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcilModels", x => x.AcilId);
                });

            migrationBuilder.CreateTable(
                name: "AsistanModels",
                columns: table => new
                {
                    AsistanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsistanModels", x => x.AsistanId);
                });

            migrationBuilder.CreateTable(
                name: "BolumModels",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HastaSayisi = table.Column<int>(type: "int", nullable: false),
                    BosYatakSayisi = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgretimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolumModels", x => x.BolumId);
                });

            migrationBuilder.CreateTable(
                name: "NobetModels",
                columns: table => new
                {
                    NobetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    AsistanId = table.Column<int>(type: "int", nullable: false),
                    NobetTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NobetModels", x => x.NobetId);
                });

            migrationBuilder.CreateTable(
                name: "OgretimModels",
                columns: table => new
                {
                    OgretimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimModels", x => x.OgretimId);
                });

            migrationBuilder.CreateTable(
                name: "RandevuModels",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AsistanId = table.Column<int>(type: "int", nullable: false),
                    OgretimId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RandevuModels", x => x.RandevuId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcilModels");

            migrationBuilder.DropTable(
                name: "AsistanModels");

            migrationBuilder.DropTable(
                name: "BolumModels");

            migrationBuilder.DropTable(
                name: "NobetModels");

            migrationBuilder.DropTable(
                name: "OgretimModels");

            migrationBuilder.DropTable(
                name: "RandevuModels");
        }
    }
}
