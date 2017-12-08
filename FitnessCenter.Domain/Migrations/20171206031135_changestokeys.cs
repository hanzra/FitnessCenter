using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FitnessCenter.Domain.Migrations
{
    public partial class changestokeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_FitnessClass_ClassID",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_ClassID",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Schedule");

            migrationBuilder.AddColumn<int>(
                name: "FitnessClassClassID",
                table: "Schedule",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_FitnessClassClassID",
                table: "Schedule",
                column: "FitnessClassClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_FitnessClass_FitnessClassClassID",
                table: "Schedule",
                column: "FitnessClassClassID",
                principalTable: "FitnessClass",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_FitnessClass_FitnessClassClassID",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_FitnessClassClassID",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "FitnessClassClassID",
                table: "Schedule");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ClassID",
                table: "Schedule",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_FitnessClass_ClassID",
                table: "Schedule",
                column: "ClassID",
                principalTable: "FitnessClass",
                principalColumn: "ClassID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
