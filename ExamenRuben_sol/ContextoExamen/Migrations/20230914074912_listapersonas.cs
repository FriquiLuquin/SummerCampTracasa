using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContextoExamen.Migrations
{
    public partial class listapersonas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persona",
                columns: new[] { "Id", "FechaNacimiento", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan", "123-456-7891" },
                    { 2, new DateTime(1995, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "María", "123-456-7892" },
                    { 3, new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "123-456-7893" },
                    { 4, new DateTime(1985, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "123-456-7894" },
                    { 5, new DateTime(1980, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luis", "123-456-7895" },
                    { 6, new DateTime(1975, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "123-456-7896" },
                    { 7, new DateTime(1970, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "123-456-7897" },
                    { 8, new DateTime(1965, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elena", "123-456-7898" },
                    { 9, new DateTime(1960, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabel", "123-456-7899" },
                    { 10, new DateTime(1955, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "123-456-7800" },
                    { 11, new DateTime(1950, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofía", "123-456-7801" },
                    { 12, new DateTime(1945, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pablo", "123-456-7802" },
                    { 13, new DateTime(1940, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carmen", "123-456-7803" },
                    { 14, new DateTime(1935, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "José", "123-456-7804" },
                    { 15, new DateTime(1930, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rosa", "123-456-7805" },
                    { 16, new DateTime(1925, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Javier", "123-456-7806" },
                    { 17, new DateTime(1920, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paula", "123-456-7807" },
                    { 18, new DateTime(1915, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miguel", "123-456-7808" },
                    { 19, new DateTime(1910, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristina", "123-456-7809" },
                    { 20, new DateTime(1905, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "123-456-7810" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Persona",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
