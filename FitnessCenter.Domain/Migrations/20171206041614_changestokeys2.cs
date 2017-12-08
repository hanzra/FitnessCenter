using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FitnessCenter.Domain.Migrations
{
    public partial class changestokeys2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ScheduleID",
                table: "Schedule",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "FitnessClass",
                newName: "ID");

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
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Schedule",
                newName: "ScheduleID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FitnessClass",
                newName: "ClassID");

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
    }
}
