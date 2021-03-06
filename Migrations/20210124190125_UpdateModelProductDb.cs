﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTenStore.Migrations
{
    public partial class UpdateModelProductDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "precio",
                table: "Products",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "precio",
                table: "Products");
        }
    }
}
