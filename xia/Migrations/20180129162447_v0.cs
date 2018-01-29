using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace xia.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    USR_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    USR_CUR_HP = table.Column<int>(nullable: false),
                    USR_CUR_MP = table.Column<int>(nullable: false),
                    USR_EXP = table.Column<int>(nullable: false),
                    USR_LEVEL = table.Column<int>(nullable: false),
                    USR_LILIANG = table.Column<int>(nullable: false),
                    USR_MAX_HP = table.Column<int>(nullable: false),
                    USR_MAX_MP = table.Column<int>(nullable: false),
                    USR_MINJIE = table.Column<int>(nullable: false),
                    USR_MONEY = table.Column<int>(nullable: false),
                    USR_NAME = table.Column<string>(nullable: true),
                    USR_NEXT_LEVEL = table.Column<int>(nullable: false),
                    USR_SEX = table.Column<string>(nullable: true),
                    USR_WUXING = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.USR_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
