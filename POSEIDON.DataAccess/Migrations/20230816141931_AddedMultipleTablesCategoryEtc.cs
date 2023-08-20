using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace POSEIDON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedMultipleTablesCategoryEtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConsumerStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumerStatuses", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Consumers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: true),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true),
                    Extension = table.Column<string>(type: "longtext", nullable: true),
                    AccountNo = table.Column<string>(type: "longtext", nullable: true),
                    Address = table.Column<string>(type: "longtext", nullable: true),
                    ContactNo = table.Column<string>(type: "longtext", nullable: true),
                    JobTitle = table.Column<string>(type: "longtext", nullable: true),
                    Company = table.Column<string>(type: "longtext", nullable: true),
                    StandPipe = table.Column<string>(type: "longtext", nullable: true),
                    MeterNo = table.Column<string>(type: "longtext", nullable: true),
                    LatestReading = table.Column<int>(type: "int", nullable: true),
                    isSenior = table.Column<string>(type: "longtext", nullable: true),
                    SeniorIDNo = table.Column<string>(type: "longtext", nullable: true),
                    ConnectionDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    ClusterId = table.Column<int>(type: "int", nullable: false),
                    BrgyId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consumers_Barangays_BrgyId",
                        column: x => x.BrgyId,
                        principalTable: "Barangays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumers_Classifications_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classifications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consumers_Clusters_ClusterId",
                        column: x => x.ClusterId,
                        principalTable: "Clusters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consumers_ConsumerStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "ConsumerStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3095), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3099), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3101), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3131), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3134), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3140), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3168), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.InsertData(
                table: "ConsumerStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Connected" },
                    { 2, "Disconnected" },
                    { 3, "Installation" },
                    { 4, "Disconnection" },
                    { 5, "Meter Transfer" },
                    { 6, "Name Transfer" },
                    { 7, "Reconnection" },
                    { 8, "Temporary Closure" },
                    { 9, "Temporary Closed" },
                    { 10, "Payment" }
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3024), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3032), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3035), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3037), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3037) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3038), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3041), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3042), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3044), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3045), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3047), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3048), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3051), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3053), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3054), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3057), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3058), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3060), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3061), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3063), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3064), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3186), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3188), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 8, 16, 22, 19, 31, 777, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_BrgyId",
                table: "Consumers",
                column: "BrgyId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_CategoryId",
                table: "Consumers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_ClassId",
                table: "Consumers",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_ClusterId",
                table: "Consumers",
                column: "ClusterId");

            migrationBuilder.CreateIndex(
                name: "IX_Consumers_StatusId",
                table: "Consumers",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consumers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ConsumerStatuses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4040), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4043), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4045), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4047), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4049), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4052), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4054), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4055), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4092), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4094), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4096), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4123), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4126), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3965), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3968), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3970), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3972), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3973), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3975) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3976), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3977), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3979), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3982), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3983), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3985), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3986), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3988), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3989), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3991), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3992), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3994), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3995), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3997), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3997) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3998), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4000), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4001), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4003), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4149), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4151), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3735), new DateTime(2023, 8, 15, 12, 27, 17, 44, DateTimeKind.Local).AddTicks(3747) });
        }
    }
}
