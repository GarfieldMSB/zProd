using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InititalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DASHusoCPUTotal",
                columns: table => new
                {
                    timestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    jobname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usoCpuPorcentaje = table.Column<double>(type: "float", nullable: false),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lpar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipochart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workload = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DASHusoCPUTotal", x => x.timestamp);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DASHusoCPUTotal");
        }
    }
}
