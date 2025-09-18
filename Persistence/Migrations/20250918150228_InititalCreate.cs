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
                name: "DASH_usoCPU_Total",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    jobname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usoCpuPorcentaje = table.Column<double>(type: "float", nullable: false),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lpar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipochart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    workload = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DASH_usoCPU_Total", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DASH_usoCPU_Total");
        }
    }
}
