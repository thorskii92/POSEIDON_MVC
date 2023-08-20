using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSEIDON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSomeTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created_At",
                table: "MeterReaders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_At",
                table: "MeterReaders",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_At",
                table: "MeterReaders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_At",
                table: "ConsumerStatuses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_At",
                table: "ConsumerStatuses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_At",
                table: "ConsumerStatuses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_At",
                table: "Consumers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_At",
                table: "Consumers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_At",
                table: "Consumers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_At",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted_At",
                table: "Categories",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_At",
                table: "Categories",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2697), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2703), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2706), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Barangays",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2722), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2765), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2769), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ConsumerStatuses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created_At", "Deleted_At", "Updated_At" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2540), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2545), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2548), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2555), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2557), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2568), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2570), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2582), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2589), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2630), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2633), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_At", "Updated_At" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 8, 16, 22, 45, 50, 746, DateTimeKind.Local).AddTicks(2179) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created_At",
                table: "MeterReaders");

            migrationBuilder.DropColumn(
                name: "Deleted_At",
                table: "MeterReaders");

            migrationBuilder.DropColumn(
                name: "Updated_At",
                table: "MeterReaders");

            migrationBuilder.DropColumn(
                name: "Created_At",
                table: "ConsumerStatuses");

            migrationBuilder.DropColumn(
                name: "Deleted_At",
                table: "ConsumerStatuses");

            migrationBuilder.DropColumn(
                name: "Updated_At",
                table: "ConsumerStatuses");

            migrationBuilder.DropColumn(
                name: "Created_At",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Deleted_At",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Updated_At",
                table: "Consumers");

            migrationBuilder.DropColumn(
                name: "Created_At",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Deleted_At",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Updated_At",
                table: "Categories");

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
        }
    }
}
