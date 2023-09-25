﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceManagement.Migrations
{
    public partial class add_Table_RelationInOutEntry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelationInOutEntry",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OutcomingEntryId = table.Column<long>(nullable: false),
                    IncomingEntryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationInOutEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelationInOutEntry_IncomingEntryTypes_IncomingEntryId",
                        column: x => x.IncomingEntryId,
                        principalTable: "IncomingEntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationInOutEntry_OutcomingEntryTypes_OutcomingEntryId",
                        column: x => x.OutcomingEntryId,
                        principalTable: "OutcomingEntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelationInOutEntry_IncomingEntryId",
                table: "RelationInOutEntry",
                column: "IncomingEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationInOutEntry_OutcomingEntryId",
                table: "RelationInOutEntry",
                column: "OutcomingEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelationInOutEntry");
        }
    }
}
