using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace News_website.Migrations
{
    /// <inheritdoc />
    public partial class db02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 50, 117, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 8, "TRUNG NGHĨA", 1, "Theo trang Bola, 4 cầu thủ gốc Hà Lan gồm Jay Idzes, Justin Hubner, Nathan Tjoe-A-On và Ragnar Oratmangoen đang chuẩn bị hoàn tất các thủ tục nhập quốc tịch Indonesia, qua đó sẵn sàng cùng đội bóng xứ Vạn đảo tham dự Asian Cup 2023.\r\n\r\nTại Asian Cup 2023, đoàn quân của của thầy trò HLV Shin Tae Yong đặt mục tiêu vượt qua vòng bảng. Đây là nhiệm vụ không dễ khi Indonesia rất khó có điểm trước Nhật Bản và Iraq. Vì vậy, cuộc đối đầu với Việt Nam là cơ hội duy nhất để đội bóng xứ Vạn đảo giành tấm vé vớt với tư cách 1 trong 4 đội hạng 3 có thành tích tốt nhất.Dù vấp phải nhiều ý kiến trái chiều từ dư luận trong nước, song PSI vẫn đang trung thành với chính sách cởi mở trong việc nhập tịch cầu thủ, nhất là từ thời điểm HLV Shin Tae Yong lên dẫn dắt ĐT Indonesia.\r\n\r\nỞ loạt trận vòng loại thứ 2 World Cup 2026 khu vực châu Á vừa qua, đội tuyển Indonesia chơi không tốt khi chỉ có 1 điểm sau 2 trận đấu. Theo báo chí nước này, việc không có sự phục vụ của 2 cầu thủ nhập tịch, Marselino Ferdinand và Ivar Jenner, do chấn thương đã ảnh hưởng tới lối chơi của thầy trò HLV Shin Tae Yong. Điều này phần nào cho thấy Garuda dường như không tự tin với nguồn cầu thủ nội đang sở hữu. ", "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/104/indonesia-nhap-tich.jpg", "Indonesia Hà Lan hóa trước ngày đấu đội tuyển Việt Nam" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 15, 475, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 15, 475, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 15, 475, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "RequestedDate",
                value: new DateTime(2023, 11, 30, 15, 54, 15, 475, DateTimeKind.Local).AddTicks(732));
        }
    }
}
