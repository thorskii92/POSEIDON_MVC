using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POSEIDON.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "District",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

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
        }
    }
}
