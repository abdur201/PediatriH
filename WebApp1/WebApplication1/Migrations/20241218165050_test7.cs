﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class test7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NobetTarihi",
                table: "NobetModels",
                newName: "NobetBit");

            migrationBuilder.AddColumn<DateTime>(
                name: "NobetBas",
                table: "NobetModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NobetBas",
                table: "NobetModels");

            migrationBuilder.RenameColumn(
                name: "NobetBit",
                table: "NobetModels",
                newName: "NobetTarihi");
        }
    }
}
