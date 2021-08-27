using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class addMembershipTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CustomerItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerItems_MembershipTypeId",
                table: "CustomerItems",
                column: "MembershipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerItems_MembershipTypeItems_MembershipTypeId",
                table: "CustomerItems",
                column: "MembershipTypeId",
                principalTable: "MembershipTypeItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerItems_MembershipTypeItems_MembershipTypeId",
                table: "CustomerItems");

            migrationBuilder.DropIndex(
                name: "IX_CustomerItems_MembershipTypeId",
                table: "CustomerItems");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CustomerItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
