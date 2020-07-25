﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ComboSimulator.Api.Migrations.Attack
{
    public partial class AttackCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Attribute1 = table.Column<string>(maxLength: 10, nullable: true),
                    Attribute2 = table.Column<string>(maxLength: 10, nullable: true),
                    Jutsu1 = table.Column<string>(maxLength: 10, nullable: true),
                    Jutsu2 = table.Column<string>(maxLength: 10, nullable: true),
                    Causing = table.Column<string>(maxLength: 20, nullable: true),
                    Effects = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: true),
                    ImagePath = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attacks");
        }
    }
}