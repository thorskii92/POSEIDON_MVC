using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POSEIDON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    deleted_at = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: true),
                    isBulk = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classifications_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MeterReaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterReaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterReaders_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Barangays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    BarangayCode = table.Column<string>(type: "longtext", nullable: true),
                    LocationType = table.Column<string>(type: "longtext", nullable: true),
                    Status = table.Column<string>(type: "longtext", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barangays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barangays_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Barangays_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clusters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    BarangayId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "longtext", nullable: true),
                    Status = table.Column<string>(type: "longtext", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Deleted_At = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clusters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clusters_Barangays_BarangayId",
                        column: x => x.BarangayId,
                        principalTable: "Barangays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name", "created_at", "deleted_at", "updated_at" },
                values: new object[] { 1, "Palawan", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9479), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId", "created_at", "deleted_at", "updated_at" },
                values: new object[,]
                {
                    { 1, "Aborlan", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9659), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9660) },
                    { 2, "Agutaya", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9662), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9662) },
                    { 3, "Araceli", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9663), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9664) },
                    { 4, "Balabac", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9665), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9665) },
                    { 5, "Bataraza", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9666), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9667) },
                    { 6, "Brooke's Point", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9668), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9668) },
                    { 7, "Busuanga", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9669), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9671) },
                    { 8, "Cagayancillo", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9672), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9672) },
                    { 9, "Coron", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9673), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9674) },
                    { 10, "Culion", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9675), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9675) },
                    { 11, "Cuyo", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9676), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9677) },
                    { 12, "Dumaran", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9678), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9678) },
                    { 13, "El Nido", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9679), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9680) },
                    { 14, "Kalayaan", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9681), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9681) },
                    { 15, "Linapacan", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9682), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9683) },
                    { 16, "Magsaysay", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9684), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9684) },
                    { 17, "Narra", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9685), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9686) },
                    { 18, "Puerto Princesa", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9686), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9687) },
                    { 19, "Quezon", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9688), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9688) },
                    { 20, "Rizal", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9689), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9690) },
                    { 21, "Roxas", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9691), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9691) },
                    { 22, "San Vicente", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9692), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9693) },
                    { 23, "Sofronio Española", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9694), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9694) },
                    { 24, "Taytay", 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9695), null, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9696) }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Created_At", "Deleted_At", "DistrictId", "Name", "Status", "Updated_At" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9831), null, 1, "Calupisan River Water System", "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9832) },
                    { 2, new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9833), null, 1, "Magtayob River Water System", "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9834) }
                });

            migrationBuilder.InsertData(
                table: "Barangays",
                columns: new[] { "Id", "BarangayCode", "Created_At", "Deleted_At", "DistrictId", "LocationType", "Name", "PlantId", "Status", "Updated_At" },
                values: new object[,]
                {
                    { 1, "01", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9762), null, 20, "Urban", "Punta-Baja", 1, "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9763) },
                    { 2, "02", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9765), null, 20, "Rural", "Bunog", 1, "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9765) },
                    { 3, "03", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9767), null, 20, "Rural", "Iraan", 1, "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9767) },
                    { 4, "04", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9769), null, 20, "Rural", "Campong-Ulay", 1, "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9769) },
                    { 5, "05", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9771), null, 20, "Rural", "Ransang", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9771) },
                    { 6, "06", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9773), null, 20, "Rural", "Candawaga", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9773) },
                    { 7, "07", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9775), null, 20, "Rural", "Culasian", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9775) },
                    { 8, "08", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9776), null, 20, "Rural", "Panalingaan", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9777) },
                    { 9, "09", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9778), null, 20, "Rural", "Taburi", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9779) },
                    { 10, "10", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9780), null, 20, "Rural", "Latud", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9781) },
                    { 11, "11", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9782), null, 20, "Rural", "Canipaan", 1, "Inactive", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9783) }
                });

            migrationBuilder.InsertData(
                table: "Clusters",
                columns: new[] { "Id", "BarangayId", "Code", "Created_At", "Deleted_At", "Name", "Status", "Updated_At" },
                values: new object[,]
                {
                    { 1, 1, "001", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9807), null, "Malapandeg", "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9807) },
                    { 2, 1, "002", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9810), null, "Katutubo", "Active", new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9810) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barangays_DistrictId",
                table: "Barangays",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Barangays_PlantId",
                table: "Barangays",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Classifications_DistrictId",
                table: "Classifications",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Clusters_BarangayId",
                table: "Clusters",
                column: "BarangayId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_MeterReaders_DistrictId",
                table: "MeterReaders",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_DistrictId",
                table: "Plants",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "Clusters");

            migrationBuilder.DropTable(
                name: "MeterReaders");

            migrationBuilder.DropTable(
                name: "Barangays");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
