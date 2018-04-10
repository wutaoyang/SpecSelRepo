using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SpecSelRepo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecSelResult",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaPrecisionThresholdY = table.Column<decimal>(nullable: false),
                    DataSet = table.Column<string>(nullable: true),
                    NumResources = table.Column<int>(nullable: false),
                    NumSpecies = table.Column<int>(nullable: false),
                    Option = table.Column<string>(nullable: true),
                    Output = table.Column<string>(nullable: true),
                    SdThresholdX = table.Column<decimal>(nullable: false),
                    SpeciesThresholdM = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecSelResult", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecSelResult");
        }
    }
}
