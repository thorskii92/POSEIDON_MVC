using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace POSEIDON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9939), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9943), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9945), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9947), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9949), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9952), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9955), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9957), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9959), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9961), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9963), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9990), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9993), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9790), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9794), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9795), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9797), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9799), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9800), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9804), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9805), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9809), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9814), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9815), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9818), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9820), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9822), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9823), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9825), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9826), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9828), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9830), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 940, DateTimeKind.Local).AddTicks(13), new DateTime(2023, 8, 15, 12, 17, 28, 940, DateTimeKind.Local).AddTicks(14) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 940, DateTimeKind.Local).AddTicks(15), new DateTime(2023, 8, 15, 12, 17, 28, 940, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9556), new DateTime(2023, 8, 15, 12, 17, 28, 939, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9762), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9763) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9765), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9771), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9773), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9775), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9776), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9780), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9782), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9807), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9810), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9659), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9662), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9663), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9666), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9668), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9669), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9672), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9673), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9675) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9676), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9678), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9679), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9681), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9682), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9684), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9685), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9686), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9688), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9689), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9691), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9692), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9694), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9695), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9831), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9833), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9479), new DateTime(2023, 8, 15, 3, 4, 47, 799, DateTimeKind.Local).AddTicks(9491) });
        }
    }
}
