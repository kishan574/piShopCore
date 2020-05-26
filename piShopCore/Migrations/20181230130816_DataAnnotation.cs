using Microsoft.EntityFrameworkCore.Migrations;

namespace piShopCore.Migrations
{
    public partial class DataAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Feedbacks",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5000,
                oldNullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Feedbacks",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5000);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Feedbacks",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
