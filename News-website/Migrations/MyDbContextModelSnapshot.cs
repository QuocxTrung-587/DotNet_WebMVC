﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News_website.Models;

#nullable disable

namespace News_website.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("News_website.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RequestApproved")
                        .HasColumnType("bit");

                    b.Property<string>("RequestedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bóng đá",
                            RequestApproved = true,
                            RequestedBy = "StoreOwner",
                            RequestedDate = new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3577)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bóng rổ",
                            RequestApproved = true,
                            RequestedBy = "StoreOwner",
                            RequestedDate = new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3588)
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bóng chuyền",
                            RequestApproved = true,
                            RequestedBy = "StoreOwner",
                            RequestedDate = new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3589)
                        },
                        new
                        {
                            Id = 4,
                            Name = "Đua xe F1",
                            RequestApproved = true,
                            RequestedBy = "StoreOwner",
                            RequestedDate = new DateTime(2023, 11, 30, 16, 8, 43, 355, DateTimeKind.Local).AddTicks(3637)
                        });
                });

            modelBuilder.Entity("News_website.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "TRUNG NGHĨA",
                            CategoryId = 1,
                            Description = "Cơ hội vào vòng knock-out Champions League của MU đang ngày càng mờ mịt sau trận hòa 3-3 với Galatasaray. HLV Erik ten Hag đã mắc khá nhiều sai lầm ở trận đấu này.\r\nỞ chuyến làm khách trên sân của Galatasaray, MU đã vượt lên dẫn 2-0 chỉ sau 18 phút. Tuy nhiên những sai lầm ở hàng thủ đã khiến Quỷ đỏ chỉ có thể nhận về kết quả hòa 3-3.\r\n\r\nCơ hội vào vòng 1/8 của MU đang cực kỳ mong manh. Ở lượt đấu cuối, họ sẽ phải đánh bại Bayern Munich trên sân nhà đồng thời hy vọng rằng Galatasaray và Copenhagen sẽ cầm chân nhau trong trận đấu còn lại. \r\n\r\nHLV Erik ten Hag đã phải chịu áp lực cực lớn sau khởi đầu mùa giải mờ nhạt của Man United. Và áp lực đó dường như sẽ không giảm bớt sau khi ông không thể giúp Quỷ đỏ đánh bại Galatasaray.\r\n\r\nDưới đây là 3 sai lầm mà ông thầy người Hà Lan đã mắc phải ở trận đấu này.",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/77/hojlund.jpg",
                            Title = "3 sai lầm của Ten Hag khiến MU bị Galatasaray cầm hòa"
                        },
                        new
                        {
                            Id = 2,
                            Author = "TRUNG NGHĨA",
                            CategoryId = 1,
                            Description = "MU đã có sự khởi đầu hoàn hảo trong chuyến làm khách tới sân của Galatasaray ở lượt trận áp chót vào rạng sáng này 30/11, khi cầu thủ trẻ Garnacho có trận đấu thứ hai liên tiếp ghi bàn với tình huống mở tỷ số ở phút 12. Sau khi ghi bàn, Garnacho đã chạy nhanh đến cột cờ góc trước mặt khán giả nhà và đưa tay lên tai trong màn ăn mừng của mình.\r\n\r\nPha ăn mừng của Garnacho đã vấp phải phản ứng rất mạnh tới từ thủ thành của đội chủ nhà Muslera. Cựu tuyển thủ Uruguay đã thực hiện pha chạy nước rút hơn 30m đến vị trí của Garnacho như thể muốn ăn tươi nuốt sống cầu thủ MU.Rất may là mọi chuyện đã được giải quyết và không có hậu quả nghiêm trọng khi đội trưởng của MU, Bruno Fernandes đã rất nhanh tiến tới tóm lấy Garnacho và bảo cầu thủ trẻ người Argentina dừng việc mình đang làm. Có thể thấy Fernandes đang ôm đầu Garnacho trong tay trước khi trọng tài Jose Sanchez cũng có lời nói với cầu thủ của MU.\r\n\r\nSở dĩ có tình huống ăn mừng quá khích tới từ Garnacho là bởi anh và các đồng đội đã phải đón nhận bầu không khí thù địch trên sân Rams Park, nơi mà các CĐV của Galatasaray đưa ra rất nhiều biểu ngữ Welcome to Hell (Chào mừng tới địa ngục) trên khắp các khán đài.",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/41/Garnacho.jpg",
                            Title = "Garnacho ăn mừng thái quá bị thủ môn Galatasaray dằn mặt"
                        },
                        new
                        {
                            Id = 3,
                            Author = "TRUNG NGHĨA",
                            CategoryId = 1,
                            Description = "Trước trận này, Paz mới chỉ có 3 lần đá chính cho đội một Real. Tiền vệ công sinh năm 2004 này ra mắt Los Blancos khi vào sân từ ghế dự bị ở trận Braga vào ngày 8/11. Sau đó 3 ngày, Paz ra mắt La Liga khi cũng vào sân trong hiệp 2 ở chiến thắng trước Valencia.\r\n\r\nQuay lại với trận lượt về gặp Napoli ở Champions League, Paz được tung vào sân ở phút 65 thay cho Brahim Diaz. Khi đấy, tỷ số đang là 2-2 và nó được giữ cho tới tận phút 84. Đây chính là khoảnh khắc định mệnh của Paz. Sau khi nhận bóng từ Rudiger, Paz có pha dứt điểm ngoài vòng cấm chuẩn xác tái lập thế dẫn bàn cho Real. Chung cuộc, chủ nhà thắng 4-2 và vẫn giữ mạch toàn thắng sau cả 5 trận.\r\n\r\nVới riêng Paz, đây là pha lập công đầu tiên cho đội một Real, cũng là bàn ra mắt Champions League. Sau trận đấu, chàng trai 19 tuổi này không giấu được sự tự hào: \"Tôi vô cùng hạnh phúc. Đây là một giấc mơ. Đến tận bây giờ tôi vẫn chưa thể tin nổi. Tôi cảm thấy may mắn vì nhận được sự giúp đỡ của cả đội\".",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/31/nico%20paz.jpg",
                            Title = "Sao 19 tuổi Nico Paz ghi bàn đầu tiên cho Real Madrid"
                        },
                        new
                        {
                            Id = 4,
                            Author = "DUY HỒNG",
                            CategoryId = 1,
                            Description = "Đặc biệt, đây là bàn thắng thứ 10 của Jude Bellingham tại UEFA Champions League trong sự nghiệp và pha lập công cũng giúp anh ghi tên vào kỷ lục của giải đấu khi trở thành cầu thủ người Anh đầu tiên ghi 10 bàn tại Cúp C1/Champions League trước khi bước sang tuổi 21. \r\n\r\nChưa hết, Bellingham trở thành cầu thủ đầu tiên trong lịch sử Champions League ghi bàn trong 4 trận đầu với Real Madrid (4 bàn), vượt qua Christian Karembeu, người năm 1998 ghi bàn trong 3 trận đầu. \r\n\r\n Sang hiệp 2, đôi bên tiếp tục rượt đuổi tỷ số. Chung cuộc, Real Madrid giành chiến thắng 4-2 trước Napoli. Thất thủ trước Real, Napoli đứng thứ 2 với 7 điểm. Ở lượt cuối, Napoli chỉ cần hòa Sporting Braga là sẽ theo chân Real Madrid đi tiếp.\r\n\r\nCách đây vài ngày, Bellingham (14 bàn) trở thành cầu thủ ghi bàn nhiều nhất trong 15 trận đầu đá cho Real, vượt qua kỷ lục 13 bàn của Cristiano Ronaldo, Alfredo Di Stefano và Pruden Sanchez. Bốn ngôi sao xếp tiếp theo gồm: Ferenc Puskas (11 bàn), Raul Gonzalez (7), Hugo Sanchez (7) và Karim Benzema (5).",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/8/real-madrid-4-2-napoli-118.jpg",
                            Title = "Bellingham lại có thêm kỷ lục"
                        },
                        new
                        {
                            Id = 5,
                            Author = "VIỆT LONG",
                            CategoryId = 2,
                            Description = "Buộc phải giành chiến thắng ít nhất 12 điểm trước Sacramento Kings để lọt vào tứ kết NBA In-Season Tournament, Golden State Warriors đã tạo được cách biệt tương đối an toàn nhờ dẫn trước 24 điểm ở hiệp 2.\r\n\r\nNhưng rồi mọi thứ đổ vỡ hoàn toàn đối với Stephen Curry và các đồng đội, đặc biệt là trong 1 phút cuối trận khi Kings hoàn tất màn lội ngược dòng bằng show diễn cá nhân của Malik Monk.Có ba cú run điểm đáng chú ý được các cầu thủ Sacarmento thực hiện trong trận đấu vòng bảng In-Season Tournament này. \r\n\r\nĐầu tiên là chuỗi điểm 14-3 để thu hẹp khoảng cách từ 24 điểm xuống 13 ở hiệp 3. Sau đó là cú 19-6 để xoá bỏ hoàn toàn lợi thế dẫn trước của Warriors, đưa Kings lên dẫn ngược lại 1 điểm vào giữa hiệp 4 (tỷ số 110-110).\r\n\r\nGolden State sau đó đáp trả để vươn lên dẫn 123-118 trước khi bước vào phút cuối hiệp 4, nhưng nỗ lực này đã làm nền cho chuỗi điểm 6-0 kết thúc trận đấu của Sacramento Kings.",
                            Image = "https://cdnmedia.webthethao.vn/uploads/2023-11-29/stephen-curry-draymond-green-sai-lam-kings-nguoc-dong-24-diem-4.jpg",
                            Title = "Stephen Curry và Green sai lầm tai hại"
                        },
                        new
                        {
                            Id = 6,
                            Author = "VIỆT LONG",
                            CategoryId = 3,
                            Description = "Nhiều gương mặt nổi tiếng của làng bóng chuyền Việt Nam đã tham dự lớp huấn luyện thể lực 2023 do Quỹ đoàn kết Olympic cùng FIVB và Liên đoàn bóng chuyền Việt Nam thực hiện.Lớp học chính thức khai giải ngày 22-11 tại Đại học TDTT Bắc Ninh. Dự lớp học lần này có 50 học viên là các HLV, các VĐV tại các đội bóng nam, nữ và ở các Trung tâm Huấn luyện TDTT nhiều địa phương góp mặt. Trong số các học viên lần này có chủ công Ngô Văn Kiều (Sanest Khánh Hòa). Mới đây, Ngô Văn Kiều đã vô địch quốc gia cùng đội nam Sanest Khánh Hòa, tuy nhiên chủ công nổi danh một thời của bóng chuyền nam Việt Nam đã ít được ra sân hơn trước vì lý do tuổi tác. Theo nhiều dự báo, Ngô Văn Kiều tới đây sẽ chuyển dần sang công tác huấn luyện chuyên môn ở đơn vị chủ quản của mình tại Khánh Hòa. Cùng dự lớp học lần này với Ngô Văn Kiều còn có phụ công Phạm Thái Hưng và HLV Phạm Văn Nghiệp của đội nam Khánh Hòa.\r\n\r\nTrong khi đó, 2 HLV của các đội tuyển bóng chuyền nam, nữ Việt Nam là ông Nguyễn Tuấn Kiệt, ông Trần Đình Tiền cũng có tên là học viên của lớp học trên. Cùng với họ, một số HLV trưởng các đội bóng ở giải vô địch quốc gia cùng tham gia học như Phạm Minh Dũng, Thái Anh Văn, Trần Văn Giáp, Dương Tấn Vinh...\r\n\r\nNăm nay, lớp học có 50 học viên. Chương trình học sẽ do giảng viên của Olympic tham gia giảng dạy và trao đổi các thông tin với thành viên của lớp học. Ngày 26-11, lớp học bế giảng. Trước đó vào tháng 7 năm nay, Liên đoàn bóng chuyền Việt Nam và Quỹ đoàn kết Olympic cùng FIVB cũng tổ chức khóa đào tạo HLV cấp 1 quốc gia dành cho bóng chuyền trong nhà và cũng thu hút 50 HLV tham dự (khi đó Ngô Văn Kiều có tham gia khóa học trên).",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/36/park%20Choong%20Kyun.jpg",
                            Title = "Chủ công Ngô Văn Kiều toả sáng"
                        },
                        new
                        {
                            Id = 7,
                            Author = "VIỆT LONG",
                            CategoryId = 4,
                            Description = "Verstappen cùng Red Bull vẫn có khả năng phá vỡ thêm kỉ lục tại chặng đua cuối cùng của mùa giải 2023 này. Khởi đầu mùa giải chỉ với 35 chiến thắng tất cả, nhà vô địch hiện đang ‘cầm hòa’ Vettel khi cùng sở hữu con số 53 chiến thắng chặng.\r\n\r\nVới kết thúc viên mãn tại Abu Dhabi, Verstappen sẽ vượt qua Vettel trở thành tay đua bước lên vị trí cao nhất trên podium nhiều thứ 3 trong lịch sử. Tay đua Red Bull sau đó vẫn còn chặng đua dài trước khi có thể đuổi kịp tới con số 91 của Schumacher, và con số 103 đáng kinh ngạc của Hamilton.\r\n\r\nRed Bull cũng có cơ hội hạ màn với chiến thắng thứ 21 của mùa giải 2023. Chính Red Bull trong \"triều đại thứ 2 của mình\" đã kết thúc mạch thắng của Mercerdes tại Abu Dhabi này, và bảo toàn chiếc cúp số 1 trong 3 năm vừa qua. Không thể phủ nhận rằng đây là mùa giải Red Bull áp đảo hoàn toàn.Trong khi nhà vô địch phải nghĩ xem chiến thắng sắp tới của họ sẽ phá vỡ kỉ lục đang tồn tại nào, thì cuộc đua về nhì vẫn chưa ngã ngũ. Mercerdes đã có phong độ ổn định trong toàn mùa giải, đã ghi điểm đều đặn, nhưng lại có dấu hiệu tụt dốc đáng lo ngại kể từ Brazil.\r\n\r\nFerrari hoàn toàn lột xác sau gói nâng cấp được áp dụng tại Monza, đỉnh điểm là Singapore, nơi duy nhất Red Bull bị đánh bại bởi Sainz. Leclerc cũng thể hiện sự nguy hiểm với 3 vị trí pole trong 4 chặng đua vừa qua. Nhờ sự ‘lơ là’ của Mercerdes, khoảng cách giữa hai đội hiện tại vỏn vẹn 4 điểm khi bước vào vòng đấu cuối cùng này.\r\n\r\nFerrari nắm giữ đà tiến lên phía trước. Nhưng Mũi tên bạc còn đó là lợi thế về điểm số, cũng như một chút ưu thế về địa điểm - nơi mà Mercerdes đã từng chiến thắng tại Yas Marina tới 6 lần. Cuộc đấu giữa hai đội cuối tuần này chắc chắn khó đoán, và đáng được đón đợi. ",
                            Image = "https://icdn.24h.com.vn/upload/4-2023/images/2023-11-24/dua-xe-F1-Abu-Dhabi-GP-Cao-trao-cuoc-dua-ve-nhi-3740-1700794868-264-width740height416.jpg",
                            Title = "Đua xe F1, Abu Dhabi GP: Cao trào cuộc đua về nhì"
                        },
                        new
                        {
                            Id = 8,
                            Author = "TRUNG NGHĨA",
                            CategoryId = 1,
                            Description = "Theo trang Bola, 4 cầu thủ gốc Hà Lan gồm Jay Idzes, Justin Hubner, Nathan Tjoe-A-On và Ragnar Oratmangoen đang chuẩn bị hoàn tất các thủ tục nhập quốc tịch Indonesia, qua đó sẵn sàng cùng đội bóng xứ Vạn đảo tham dự Asian Cup 2023.\r\n\r\nTại Asian Cup 2023, đoàn quân của của thầy trò HLV Shin Tae Yong đặt mục tiêu vượt qua vòng bảng. Đây là nhiệm vụ không dễ khi Indonesia rất khó có điểm trước Nhật Bản và Iraq. Vì vậy, cuộc đối đầu với Việt Nam là cơ hội duy nhất để đội bóng xứ Vạn đảo giành tấm vé vớt với tư cách 1 trong 4 đội hạng 3 có thành tích tốt nhất.Dù vấp phải nhiều ý kiến trái chiều từ dư luận trong nước, song PSI vẫn đang trung thành với chính sách cởi mở trong việc nhập tịch cầu thủ, nhất là từ thời điểm HLV Shin Tae Yong lên dẫn dắt ĐT Indonesia.\r\n\r\nỞ loạt trận vòng loại thứ 2 World Cup 2026 khu vực châu Á vừa qua, đội tuyển Indonesia chơi không tốt khi chỉ có 1 điểm sau 2 trận đấu. Theo báo chí nước này, việc không có sự phục vụ của 2 cầu thủ nhập tịch, Marselino Ferdinand và Ivar Jenner, do chấn thương đã ảnh hưởng tới lối chơi của thầy trò HLV Shin Tae Yong. Điều này phần nào cho thấy Garuda dường như không tự tin với nguồn cầu thủ nội đang sở hữu. ",
                            Image = "https://cdn.bongdaplus.vn/Assets/Media/2023/11/30/104/indonesia-nhap-tich.jpg",
                            Title = "Indonesia Hà Lan hóa trước ngày đấu đội tuyển Việt Nam"
                        });
                });

            modelBuilder.Entity("News_website.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Salespeople"
                        },
                        new
                        {
                            Id = 3,
                            Name = "HQAdministrator"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Customers"
                        });
                });

            modelBuilder.Entity("News_website.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@gmail.com",
                            FullName = "Admin",
                            Gender = "Nam",
                            IsLocked = false,
                            Password = "P@ssw0rd",
                            Phone = "0123456789",
                            Username = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "storeowner@gmail.com",
                            FullName = "Store Owner",
                            Gender = "Nam",
                            IsLocked = false,
                            Password = "P@ssw0rd",
                            Phone = "9876543210",
                            Username = "StoreOwner"
                        });
                });

            modelBuilder.Entity("News_website.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("News_website.Models.Post", b =>
                {
                    b.HasOne("News_website.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("News_website.Models.Role", b =>
                {
                    b.HasOne("News_website.Models.User", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("News_website.Models.UserRole", b =>
                {
                    b.HasOne("News_website.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News_website.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("News_website.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("News_website.Models.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
