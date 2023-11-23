using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_DaiLy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DienThoai",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaDaiLy",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaHTPPID",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NguoiDaiDien",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TenDaiLy",
                table: "HeThongPhanPhoi",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HeThongPhanPhoi_MaHTPPID",
                table: "HeThongPhanPhoi",
                column: "MaHTPPID");

            migrationBuilder.AddForeignKey(
                name: "FK_HeThongPhanPhoi_HeThongPhanPhoi_MaHTPPID",
                table: "HeThongPhanPhoi",
                column: "MaHTPPID",
                principalTable: "HeThongPhanPhoi",
                principalColumn: "MaHTPP",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HeThongPhanPhoi_HeThongPhanPhoi_MaHTPPID",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropIndex(
                name: "IX_HeThongPhanPhoi_MaHTPPID",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "DienThoai",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "MaDaiLy",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "MaHTPPID",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "NguoiDaiDien",
                table: "HeThongPhanPhoi");

            migrationBuilder.DropColumn(
                name: "TenDaiLy",
                table: "HeThongPhanPhoi");
        }
    }
}
