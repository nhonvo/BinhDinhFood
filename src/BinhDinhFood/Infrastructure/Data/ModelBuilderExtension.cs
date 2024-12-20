using BinhDinhFood.Domain.Entities.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BinhDinhFood.Infrastructure.Data;

public static class ModelBuilderExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Authentication seeding data
        // Step 1: Seeding Roles
        var adminRoleId = new Guid("A3314BE5-4C77-4FB6-82AD-302014682A73");
        var userRoleId = new Guid("B4314BE5-4C77-4FB6-82AD-302014682B13");

        var roles = new List<RoleIdentity>
        {
            new RoleIdentity
            {
                Id = adminRoleId,
                Name = Role.Admin.ToString(),
                NormalizedName = "ADMIN"
            },
            new RoleIdentity
            {
                Id = userRoleId,
                Name = Role.User.ToString(),
                NormalizedName = "USER"
            }
        };
        modelBuilder.Entity<RoleIdentity>().HasData(roles);

        // Step 2: Seeding Media (Avatars)
        var avatar1Id = 51;
        var avatar2Id = 52;
        var avatar3Id = 53;

        modelBuilder.Entity<Media>().HasData(new List<Media>
        {
            new () { Id = avatar1Id, PathMedia = "https://example.com/avatar1.png", Type = MediaType.Image },
            new () { Id = avatar2Id, PathMedia = "https://example.com/avatar2.png", Type = MediaType.Image },
            new () { Id = avatar3Id, PathMedia = "https://example.com/avatar3.png", Type = MediaType.Image },
        });

        // Step 3: Seeding Users with AvatarId
        var hashed = new PasswordHasher<ApplicationUser>();

        var normalUsers = new List<ApplicationUser>
        {
            new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Name = "Võ Thương Trường Nhơn",
                UserName = "truongnhon",
                PasswordHash = hashed.HashPassword(null, "P@ssw0rd"),
                Email = "truongnhon@example.com",
                Address = "Quy Nhơn, Bình Định",
                PhoneNumber = "0905726748",
                ImageId = avatar1Id, // Assign Avatar
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Name = "Nguyễn Hồng Thái",
                UserName = "thai",
                PasswordHash = hashed.HashPassword(null, "P@ssw0rd"),
                Email = "hongthai@example.com",
                Address = "Tây Ninh",
                PhoneNumber = "0905726748",
                ImageId = avatar2Id, // Assign Avatar
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Name = "Phạm Đức Tài",
                UserName = "tai",
                PasswordHash = hashed.HashPassword(null, "P@ssw0rd"),
                Email = "taiphamduc@example.com",
                Address = "Nam Định",
                PhoneNumber = "0905726748",
                ImageId = avatar3Id, // Assign Avatar
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid(),
                Name = "dotnet evil",
                UserName = "nhondeptrai",
                PasswordHash = hashed.HashPassword(null, "P@ssw0rd"),
                Email = "nhondeptrai@example.com",
                Address = "Saigon",
                PhoneNumber = "0905726748",
                SecurityStamp = Guid.NewGuid().ToString()
            }
        };

        var adminUserId = Guid.NewGuid();
        normalUsers.Add(new ApplicationUser
        {
            Id = adminUserId,
            Name = "Admin User",
            UserName = "admin",
            PasswordHash = hashed.HashPassword(null, "P@ssw0rd"),
            Email = "admin@example.com",
            Address = "Admin City",
            PhoneNumber = "123456789",
            SecurityStamp = Guid.NewGuid().ToString()
        });

        modelBuilder.Entity<ApplicationUser>().HasData(normalUsers);

        // Step 4: Seeding UserRoles (Mapping Users to Roles)
        var userRoles = new List<UserRoles>
        {
            new UserRoles
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            },
            new UserRoles
            {
                RoleId = userRoleId,
                UserId = normalUsers.First(u => u.UserName == "truongnhon").Id
            },
            new UserRoles
            {
                RoleId = userRoleId,
                UserId = normalUsers.First(u => u.UserName == "thai").Id
            },
            new UserRoles
            {
                RoleId = userRoleId,
                UserId = normalUsers.First(u => u.UserName == "tai").Id
            },
            new UserRoles
            {
                RoleId = userRoleId,
                UserId = normalUsers.First(u => u.UserName == "nhondeptrai").Id
            }
        };
        modelBuilder.Entity<UserRoles>().HasData(userRoles);

        // book seeding data
        modelBuilder.Entity<Book>().HasData(
            new Book
            {
                Id = 1,
                Title = "C# Programming",
                Description = "A comprehensive guide to C# programming.",
                Price = 29.99
            },
            new Book
            {
                Id = 2,
                Title = "ASP.NET Core Development",
                Description = "Learn how to build web applications using ASP.NET Core.",
                Price = 35.50
            },
            new Book
            {
                Id = 3,
                Title = "Entity Framework Core In Action",
                Description = "Master the Entity Framework Core ORM for .NET development.",
                Price = 40.00
            },
            new Book
            {
                Id = 4,
                Title = "Blazor WebAssembly: The Complete Guide",
                Description = "Everything you need to know about building Blazor WebAssembly applications.",
                Price = 45.99
            },
            new Book
            {
                Id = 5,
                Title = "Design Patterns in C#",
                Description = "Implement common design patterns in C# to improve code structure.",
                Price = 50.00
            }
        );

        // category seeding data
        modelBuilder.Entity<Category>().HasData(new List<Category>
        {
            new ()
            {
                Id = 1,
                Name = "Đồ khô",
                DateCreated = DateTime.Parse("2022-08-19")
            },
            new ()
            {
                Id = 2,
                Name = "Bánh truyền thống",
                DateCreated = DateTime.Parse("2022-08-19")
            },
            new ()
            {
                Id = 3,
                Name = "Đồ đặc sản",
                DateCreated = DateTime.Parse("2022-08-19")
            }
        });


        var (productImage1, productImage2, productImage3, productImage4, productImage5, productImage6, productImage7, productImage8, productImage9, productImage10, productImage11, productImage12, productImage13, productImage14, productImage15, productImage16, productImage17, productImage18, productImage19, productImage20, productImage21, productImage22, productImage23, productImage24, productImage25, productImage26, productImage27, productImage28) = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28);

        modelBuilder.Entity<Media>().HasData(new List<Media>
        {
            new () { Id = 21, ProductId= productImage1, PathMedia = "chaca.png", Type = MediaType.Image },
            new () { Id = 22, ProductId= productImage2, PathMedia = "tom-kho-gia-bao-nhieu-1kg.jpg", Type = MediaType.Image },
            new () { Id = 23, ProductId= productImage3, PathMedia = "mamnhum.png", Type = MediaType.Image },
            new () { Id = 24, ProductId= productImage4, PathMedia = "cach-lam-ca-kho-tam-gia-vi.jpg", Type = MediaType.Image },
            new () { Id = 25, ProductId= productImage5, PathMedia = "nem.png", Type = MediaType.Image },
            new () { Id = 26, ProductId= productImage6, PathMedia = "banhit.png", Type = MediaType.Image },
            new () { Id = 27, ProductId= productImage7, PathMedia = "mucrim.png", Type = MediaType.Image },
            new () { Id = 28, ProductId= productImage8, PathMedia = "chatre.png", Type = MediaType.Image },
            new () { Id = 29, ProductId= productImage9, PathMedia = "banhthuan.png", Type = MediaType.Image },
            new () { Id = 30, ProductId= productImage10, PathMedia = "ruoubauda.png", Type = MediaType.Image },
            new () { Id = 31, ProductId= productImage11, PathMedia = "muc-ngao-ot-dac-san-binh-dinh-lam-qua.jpg", Type = MediaType.Image },
            new () { Id = 32, ProductId= productImage12, PathMedia = "cach-lua-ca-chi-vang-kho-ngon.jpg", Type = MediaType.Image },
            new () { Id = 33, ProductId= productImage13, PathMedia = "Banh-trang-nuoc-dua-am-thuc-binh-dinh.jpg", Type = MediaType.Image },
            new () { Id = 34, ProductId= productImage14, PathMedia = "nuoc-mam-nhi-nguyen-chat-tam-quan-binh-dinh.jpg", Type = MediaType.Image },
            new () { Id = 35, ProductId= productImage15, PathMedia = "các-món-từ-ruốc-khô.jpg", Type = MediaType.Image },
            new () { Id = 36, ProductId= productImage16, PathMedia = "cá-lao-khô-quy-nhơn.jpg", Type = MediaType.Image },
            new () { Id = 37, ProductId= productImage17, PathMedia = "banhhong.jpg", Type = MediaType.Image },
            new () { Id = 38, ProductId= productImage18, PathMedia = "banhtrangchaca.jpg", Type = MediaType.Image },
            new () { Id = 39, ProductId= productImage19, PathMedia = "muc-ngao-ot-dac-san-binh-dinh-lam-qua.jpg", Type = MediaType.Image },
            new () { Id = 40, ProductId= productImage20, PathMedia = "chả-ram-tôm-đất-quy-nhơn-ngon-loại-1.jpg", Type = MediaType.Image },
            new () { Id = 41, ProductId= productImage21, PathMedia = "ghe-sua-chien-gion.jpg", Type = MediaType.Image },
            new () { Id = 42, ProductId= productImage22, PathMedia = "muc-mot-nang-gia-bao-nhieu-1kg.jpg", Type = MediaType.Image },
            new () { Id = 43, ProductId= productImage23, PathMedia = "cá-đù-một-nắng.jpg", Type = MediaType.Image },
            new () { Id = 44, ProductId= productImage24, PathMedia = "cha-bo-binh-dinh-nha-lam.jpg", Type = MediaType.Image },
            new () { Id = 45, ProductId= productImage25, PathMedia = "banh-trang-nhung-binh-dinh.jpg", Type = MediaType.Image }
        });

        // Product seeding data
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Name = "Chả cá Quy Nhơn",
            Price = 120000,
            Description = "Mặc dù chả cá có thể là đặc sản và có mặt ở nhiều nơi nhưng không phải hương vị chả cá nào cũng như nhau. Sở dĩ chả cá Quy Nhơn là một trong các đặc sản Bình Định nổi tiếng vì vị ngon và lạ đặc trưng. Với nguyên liệu được tuyển chọn từ những con cá biển tươi ngon nhất và công thức chế biến độc quyền của người dân đã tạo nên sự khác biệt cho chả cá Quy Nhơn.\n Chả cá Quy Nhơn phổ biến có 2 loại là chả hấp và chả chiên. Ngoài việc thưởng thức thực tiếp miếng chả dai, giòn, thơm ngon đặc biệt, các bạn có thể dùng chả cá này để làm “topping” cho các món ăn khác như cơm, bún, phở. Đây cũng là một lựa chọn thích hợp để bạn mua về làm quà cho người thân và bạn bè nữa đó.",
            Quality = 100,
            OffPrice = 10,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 2,
            Name = "Tôm khô",
            Price = 84000,
            Description = "Tôm khô còn gọi là tôm nõn khô là một trong các loại thực phẩm giàu dinh dưỡng rất tốt cho sức khỏe. Chúng được làm từ tôm tươi tự nhiên và phơi khô dưới ánh nắng mặt trời hoặc sấy khô thủ công. 1kg tôm tươi làm được khoảng 2 lạng tôm khô, thành phẩm tôm có kích thước nhỏ hơn, có vị ngọt thanh đậm đà rất thơm.\nGiá trị dinh dưỡng của tôm vẫn giữ gần như nguyên vẹn, trong 100g tôm khô có: 347 kcal, 75,6g đạm, 235mg canxi, 4,6mg sắt, vitamin B1, B2, PP và 3,8g chất béo chưa bảo hòa.",
            Quality = 20,
            OffPrice = 20,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 3,
            Name = "Mắm Nhum Mỹ An Bình Định",
            Price = 20000,
            Description = "Nhum có rất nhiều loại khác nhau, nhưng mắm nhum tại Bình Định đặc biệt được làm từ con nhum ta, tạo hương vị ngon đến nỗi “ăn với món gì cũng ngon”. Đồng thời mắm Nhum tại Mỹ An cũng từng là đặc sản Bình Định được tiến vua, và hiện nay là một món ăn mà du khách không thể bỏ lỡ khi đến Bình Định du lịch.\nNhum vốn là động vật với bê ngoài gai góc có thể làm đau người dân nếu đạp phải, và người dân nơi đây đã biến chúng thành một món ngon tuyệt vời. Mắm nhum còn có thể là món quà hảo hạng giúp bạn dùng làm quà tặng sau khi đến Bình Định du lịch, nếu được thì bạn nên đến Mỹ An để mua mắm nhum nhé.",
            Quality = 100,
            OffPrice = 5,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 4,
            Name = "Cá cơm khô",
            Price = 18000,
            Description = "cá cơm giàu vitamin A, nhiều axit béo, vitamin E, canxi, Vitamin A, giúp mắt sáng, ngăn ngừa các bệnh về mắt, duy trì làn da khỏe mạnh. Ăn cá cơm giúp giảm lượng cholesterol trong máu, ngăn ngừa các bệnh về tim mạch.\nCá cơm cung cấp một lượng lớn protein và đạm, nên chúng được sử dụng để làm nước mắm nhĩ",
            Quality = 55,
            OffPrice = 15,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 5,
            Name = "Nem chợ huyện",
            Price = 150000,
            Description = "Nem chua là một trong các đặc sản Bình Định được chế biến cầu kỳ và công phu. Với công thức hương vị đặc biệt để ướp những miếng thịt heo tươi ngon nhất và gói bên trong những lớp lá khế non và lớp lá chuối cầu kì, hương vị thơm ngon nổi tiếng của nem chợ huyện cũng từ đó mà vang xa.\nĐến Bình Định ngồi cắn một miếng nem và nhâm nhi một ít rượu Bàu Đá cũng đủ để bạn nhớ về hương vị ấy mỗi khi nhắc đến chuyến du lịch này đó. Ngoài ra, nem cũng là lựa chọn thích hợp để làm quà tặng, với hương vị tuyệt vời ấy ai lại lỡ không thích món quà mà bạn tặng.",
            Quality = 100,
            OffPrice = 20,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 6,
            Name = "Bánh ít lá gai",
            Price = 100000,
            Description = "“Muốn ăn bánh ít lá gai Lấy chồng Bình Định sợ dài đường đi\"Bánh ít lá gai là một trong các đặc sản Bình Định nổi tiếng. Để làm nên những chiếc bánh ít thơm ngon nức tiếng, người làm bánh phải lựa chọn và chuẩn bị những chiếc lá gai rất cầu kỳ vì đây là yếu tố quan trong quyết định đến hương vị của bánh. Kế đến là nếp và nhân cũng được lựa chọn và chế biến từ những nguyên liệu ngon nhất.\n Sau một quá trình xay bột, làm nhân, gói và hấp bánh, những chiếc bánh ít lá gai thơm ngon, dẻo dai với vị ngọt của nhân đậu xanh hoặc nhân dừa đã được ra lò. Với đặc sản này bạn nên thử ít nhất một lần, và đây cũng được xem là một món quà mà chắc chắn người thân của bạn sẽ thích.",
            Quality = 100,
            OffPrice = 10,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 7,
            Name = "Mực rim Quy Nhơn",
            Price = 150000,
            Description = "Mực rim là món ăn phổ biến khiến du thích yêu thích có mặt ở hầu hết những vùng biển lớn. Tuy nhiên mực rim hay còn gọi là mực ngào Bình Định có một hương vị thơm ngon rất riêng từ vùng biển duyên hải miền Trung. Mực rim Quy Nhơn được người dân làm từ những con mực tươi nhất và hương vị không nơi nào giống được.\n Với hương thơm ngon đặc biệt cùng vị cay cay kích thích vị giác, mực rim trở thành món ăn vặt siêu ngon và được mọi người vô cùng yêu thích. Đồng thời, với những hũ mực rim được làm sẵn giúp bạn có thể dễ dàng lựa chọn đặc sản Bình Định này để làm quà tặng.",
            Quality = 100,
            OffPrice = 5,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 8,
            Name = "Chả Tré rơm",
            Price = 35000,
            Description = "Với tên gọi độc và lạ của món Chả Tré, món đặc sản Bình Định này đã gợi nên sự tò mò với nhiều du khách muốn tìm hiểu và được thử món ăn độc đáo này. Mặc dù đã có mặt phổ biến khắp các tỉnh thành Trung Trung bộ, nhưng hương vị thơm ngon nhất vẫn là chả Tré Bình Định với cách làm và công thức chỉ vùng đất Bình Định mới làm nên được.\n Thành phần nguyên liệu làm chả Tré cũng tương tự với các loại nem, bì của miền bắc. Nhưng Tré Bình Định được người dân nơi đây khéo léo thay thế bằng nhiều loại nguyên liệu khác như tai heo, lỗ mũi heo, da heo, thịt ba chỉ,...Tré cũng thích hợp để trở thành món quà mang về khi bạn đến thăm Bình Định.",
            Quality = 100,
            OffPrice = 20,
            Rating = 3,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 9,
            Name = "Bánh thuẫn",
            Price = 15000,
            Description = "Nếu như Hà Nội có bánh cốm, Hải Dương có bánh đậu xanh, Vũng Tàu có bánh bông lan trứng muối,...và những loại bánh làm quà đặc trưng của nhiều tỉnh khác thì Quy Nhơn lại bánh thuẫn nổi tiếng để làm quà tặng cho người thân và bạn bè. Đây cũng là loại bánh phổ biến vào ngày Tết của người dân miền Trung.\n Bánh thuẫn có vị thơm ngon từ nguyên liệu như trứng gà, bột năng, bột bình tinh, đường, đâu ăn, vani và đặc biệt là khuôn đúc bánh. Quá trình đúc bánh bằng than đã góp phần tạo nên được mùi thơm đặc trưng của đặc sản Bình Định này.",
            Quality = 100,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 10,
            Name = "Rượu Bầu đá",
            Price = 40000,
            Description = "Sở dĩ rượu Bàu đá được biết đến là một trong những đặc sản Bình Định nổi tiếng vì đây là loại rượu không nấu từ gạo thông thường như những loại rượu khác. Rượu Bàu đá Bình Định được nấu từ gạo lứt và chỉ khi sử dụng một nguồn nước trong một làng của tỉnh Bình Định mới đạt được hương vị ngon nhất.\n Từ xưa, rượu Bàu đá đã được tiến cung cho vua nên được xếp vào loại đặc sản thượng hạng của Bình Định. Rượu nổi tiếng dễ say vì có độ cồn rất cao, lên đến 50. Nhưng điều khiến người ta yêu thích hương vị của rượu là vị thanh mát mang lại cảm giác sảng khoái vô cùng. Đây cũng là một món quà thích hợp thể hiện sự kính trọng bạn có thể chọn.",
            Quality = 100,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-08-19"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 11,
            Name = "Mực ngào Bình Định",
            Price = 250000,
            Description = "Một trong những món ăn phải kể đến đầu tiên trong dah sách những món đặc sản Bình Định đó chính là mực ngào. Mực ngào có một hương vị thơm ngon rất riêng thu hút khách du lịch. Để chế biến được món mực ngào người đầu bếp đã phải rất công phu, tài tình tỉ mỉ chăm chút cho món ăn. Mực sau khi đươc thu mua từ những cảng hải sản tươi ngon được đem về sơ chế và chế biến luôn để giữ được độ tươi ngon nguyên vẹn  của mực.\nMực được  ướp cùng tiêu, tỏi, ớt, mắm và một số loại gia vị khác để tạo độ thơm ngon đặc trưng của mực. Món ăn này có vị cay đặc trưng, thơm thơm của các loại gia vị sẽ làm bạn thích thú và muốn ăn ngay từ cái nhìn đầu tiên. Gía của một cân mực ngào giao động từ  200.000 – 400.000 đồng.",
            Quality = 100,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 12,
            Name = "Khô cá chỉ vàng",
            Price = 135000,
            Description = "Cá chỉ vàng là loài cá nước mặn (còn gọi là cá ngân chỉ) thức ăn của chúng là những sinh vật nổi. Thân cá dẹp hình thoi, hai bên có một sọc vàng chạy thẳng từ sau mắt đến gần vây đuôi, phần lưng màu xanh xám, bụng trắng bạc, trên mang cá có chấm đen, vây đuôi vàng, đầu cá hơi nhọn, miệng chếch, hàm dưới nhô ra.\n Cá chỉ vàng thịt trắng có vị ngọt thơm, giàu vitamin B, Omega 3 giúp ngăn ngừa bệnh tim mạch, tốt cho não bộ, cải thiện giấc ngủ...",
            Quality = 100,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 13,
            Name = "Bánh tráng nước dừa",
            Price = 120000,
            Description = "Khi đến du lịch Bình Định không thể không nhắc tới  món bánh tráng nước dừa. Đây là một món đặc sản nơi xứ dừa. Công đoạn chế biến bánh không quá cầu kì nhưng đòi hỏi sự tỉ mỉ, có kinh nghiệm của người tráng bánh. Nguyên liệu của bánh chủ yếu là Củ Mì ( củ sắn) được sắt nhỏ, xay lấy nước. Cơm dừa được nạo thành sợi nhỏ,  nước dừa và vừng đen. Tất cả đều được đổ chung vào một nồi lớn, trộn đều cho các gia vị hòa quyện cùng với nhau và được đun nóng. Bên cạnh đó có một chảo đang được đun nóng. Khi chảo nóng lên người tráng bánh sẽ dùng một cái gáo làm bằng sọ dừa có cán dài múc từng gáo nước bánh lên chảo và tráng đều. Tráng bánh phải đều tay để cơm dừa và vừng đen được dàn đều mặt bánh. Bánh phải tròn mỏng và không bị chỗ dày, chỗ mỏng thì mới là bánh đạt chuẩn. cứ tráng được mười chiếc  bánh thì đem ra phơi. khi ăn bạn cần nướng lên để bánh có độ phồng và dậy hết mùi thơm của vừng, của nước cốt dừa và cơm dừa. Có thể ăn bánh thay cơm ăn chỉ thấy no mà không thấy chán.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 14,
            Name = "Nước mắm nhĩ Bình Định",
            Price = 95000,
            Description = "Nước mắm nhĩ hay nhỉ còn gọi là nước mắm kéo lù hoặc mắm cốt, là loại nước mắm được hứng từ các giọt nước mắm đầu tiên được “nhỉ” ra. Hay nói cách khác là rò rỉ ra từng giọt, từng giọt từ lỗ van đang đóng kín ở đáy của thùng hay lu vại đang muối cá đã đến thời gian chín có thể lấy nước mắm thành phẩm.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 15,
            Name = "Ruốt khô",
            Price = 200000,
            Description = "Con ruốc còn gọi là tép biển, tép moi, ở Việt Nam được coi là đặc sản. Chúng là động vật giáp xác 10 chân sống ở vùng nước mặn ven biển hay nước lợ. Ruốc dạng như tôm nhỏ, chỉ lớn khoảng 10–40 mm Do kích thước của con ruốc biển nhỏ, nên thường được dùng để làm nước mắm ruốc (là một loại mắm đặc sản của miền biển) hoặc phơi khô ruốc để chế biến thành các món ăn dân dã đậm đà hương vị biển.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 16,
            Name = "Cá Lao Khô Tẩm Gia Vị",
            Price = 125000,
            Description = "Hải sản Quy Nhơn nổi tiếng khắp cả nước với nhiều loại hải sản phong phú đa dạng, trong đó Cá lao là một loại hải sản khô đặc biệt thơm ngon, chúng là một loại cá biển, sau khi được ngư dân đánh bắt được xẻ thịt, phơi khô tạo nên một loại thực phẩm thơm ngon đúng chất tinh túy từ biển.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 17,
            Name = "Bánh hồng Tam Quan",
            Price = 200000,
            Description = "Bánh hồng Tam Quan là một trong những món đặc sản của Bình Định, được xem như biểu trưng cho tin vui, thường xuất hiện trong các dịp cưới hỏi của người dân nơi đây.\n Điều đặc biệt bánh hồng Tam Quan là bánh được làm từ gạo nếp Ngự nổi tiếng dẻo thơm. Do hoàn toàn không có chất bảo quản nên bánh chỉ để được 5 ngày thôi bạn nhé.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 18,
            Name = "Bánh tráng chả cá",
            Price = 400000,
            Description = "Bánh tráng chả cá là một trong những đặc sản nổi tiếng gần xa của Bình Định. Bánh tráng chả cá được làm từ nguyên liệu chính là cá cùng một ít gia vị và bột năng. Để món ăn đúng vị hơn bạn nên ăn kèm với rau răm nhé.",
            Quality = 50,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 19,
            Name = "Mực ngào vị tỏi",
            Price = 200000,
            Description = "Nếu đã đến với đất Bình Định thì bạn nhất định phải thử qua món mực ngào vị tỏi nhé. Món ăn là sự hòa quyện giữa vị mực vừa tươi vừa giòn cùng vị cay đặc trưng của ớt và tỏi. Bạn nhớ bảo quản món này ở nhiệt độ thoáng mát nha.",
            Quality = 100,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-03"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 20,
            Name = "Chả ram tôm đất",
            Price = 890000,
            Description = "Chả ram tôm đất là một trong những món ngon đặc sản nổi tiếng của miền đất võ Bình Định, món ăn này phù hợp với mọi lứa tuổi, từ già đến trẻ đều yêu thích và thường xuyên xuất hiện trong các bữa cơm gia đình.\n Miếng chả ram tôm đất Bình Định giòn tan của lớp bánh tráng chiên bên ngoài, bên trong có thịt tôm ngọt tự nhiên, một chút ngầy ngậy của thịt mỡ, tất cả tạo nên hương vị đặc biệt hấp dẫn, gây nghiện cho thực khách khi dùng thử món ăn độc đáo này.",
            Quality = 45,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-06"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 21,
            Name = "Ghẹ sữa rim tỏi ớt, rang me, chiên giòn",
            Price = 90000,
            Description = "Ghẹ sữa là ghẹ còn non có kích thước nhỏ, cỡ ngón chân cái người lớn, nhiều nhất vào tháng 5 đến tháng 11, thời điểm ghẹ sinh sản nhiều.\nGhẹ sữa có hàm lượng dinh dưỡng cao, nhiều canxi, đạm, sắt, các vitamin A, B1, B2, C và đặc biệt là magnesium, calcium và axit béo omega 3, có lợi cho sức khỏe và rất tốt cho người có vấn đề tim mạch và hỗ trợ tăng trưởng chiều cao cho trẻ.",
            Quality = 44,
            OffPrice = 15,
            Rating = 4,
            DateCreated = DateTime.Parse("2022-09-06"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 22,
            Name = "Mực một nắng",
            Price = 500000,
            Description = "Mực một nắng là loại hải sản đặc biệt, để làm mực 1 nắng được ngon, sau khi xẻ phải rửa mực tươi bằng nước biển, rồi phơi dưới trời nắng gắt. Chỉ được phơi qua một nắng để mực vẫn giữ được độ tươi ngon, bên ngoài ráo nước, bên trong dẻo và giòn. \nNhững vùng biển có nước biển càng mặn thì mực 1 nắng sẽ càng ngon, đặc biệt là các khu vực miền Trung. Mực một nắng có nhiều loại, nhưng mực ngon nhất vẫn là làm từ những con mực ống và mực lá.\nĐây là một trong các đặc sản nổi tiếng của Bình Định được du khách tìm mua làm quà.",
            Quality = 50,
            OffPrice = 20,
            Rating = 2,
            DateCreated = DateTime.Parse("2022-09-06"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 23,
            Name = "Cá đù một nắng",
            Price = 16000,
            Description = "Cá đù hay Cá lù đù là một họ cá thuộc bộ Cá vược (Perciformes) có kích thước lớn, chúng sống ở vùng biển nhiệt đới, cận nhiệt đới. Tại vùng biển Việt Nam, có khoảng 270 loài trong 70 chi, đáng kể nhất là cá lù đù bạc chiếm số lượng lớn trong 20 loài như cá lù đù măng đen, cá lù đù lỗ tai đen, cá lù đù kẽm, cá lù đù sóc, cá lù đù đỏ dạ...\nChúng sống thành từng đàn lớn ở gần bờ, thường núp trong những rạn, hốc đá. Thức ăn của chúng là các loại động vật thủy sinh, côn trùng hay cá nhỏ, giáp xác.\n Vì muốn dự trữ được lâu nên sau khi được đánh bắt, ngư dân chọn cá tươi làm sạch, xẻ lóc bỏ xương, bỏ đầu để ráo. Sau đó, đem phơi khô dưới 1 nắng gắt để cá se lại để thịt dẻo dẻo. Hoặc có thể phơi cho thật khô để dự trữ ăn dần.\n Cá đù 1 nắng phần thân sau của cá có nhiều mỡ, rất béo. Loại cá này có vị ngọt dịu deo dẻo và đặc biệt thịt mềm, hậu bùi, có thể chế biến thành nhiều món ngon hấp dẫn. \nHiện nay, đây là đặc sản được rất nhiều người săn lùng, kể cả người nước ngoài cũng rất thích thú với vị ngon ngọt của nó “đặc biệt là giá cả phải chăng”.",
            Quality = 12,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-06"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 24,
            Name = "Chả Bò (Giò Bò) Bình Định Chính Gốc – Cây 500G",
            Price = 180000,
            Description = "Chả Bò (Giò Bò) Bình Định Chính Gốc – Cây 500G",
            Quality = 15,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-06"),
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 25,
            Name = "Bánh Tráng Nhúng Giòn Phù Mỹ",
            Price = 45000,
            Description = "Đến với Bình Định, du khách sẽ được thưởng thức những món được làm từ các loại bánh tráng. Nào là bánh tráng mè nướng, bánh tráng nước cốt dừa Tam Quan hay bánh tráng bột mì nhứt nướng, bánh tráng gạo nhúng, … loại bánh nào cũng ngon nhứt nách. Hôm nay, Đặc Sản Bình Định Online xin được giới thiệu đến quý khách một loại bánh tráng độc đáo hơn cả đó là bánh tráng nhúng giòn Phù Mỹ. Hãy cùng khám phá bạn nhé. Nếu có cơ hội đến Bình Định hãy thử một lần thưởng thức loại bánh tráng đặc sản Phù Mỹ để tự cảm nhận hương vị thơm ngon đặc trưng của nó nhé.",
            Quality = 20,
            OffPrice = 0,
            Rating = 0,
            DateCreated = DateTime.Parse("2022-09-06"),
        });
        // productCategory seeding

        var random = new Random();
        var productCategorySeed = new List<ProductCategory>();

        for (int productId = 1; productId <= 25; productId++)
        {
            // Assign random categories to each product (1 to 3 categories per product)
            var assignedCategories = random.Next(1, 4);  // Random number of categories (1 to 3)
            var categoryIds = new HashSet<int>();

            for (int i = 0; i < assignedCategories; i++)
            {
                int categoryId;

                do
                {
                    categoryId = random.Next(1, 4);  // Random category ID (1 to 3)
                }
                while (!categoryIds.Add(categoryId));  // Ensure no duplicate category for the same product

                productCategorySeed.Add(new ProductCategory
                {
                    ProductId = productId,
                    CategoryId = categoryId
                });
            }
        }

        modelBuilder.Entity<ProductCategory>().HasData(productCategorySeed);

        // media seeding data
        var (blogImage1, blogImage2, blogImage3, blogImage4, blogImage5, blogImage6, blogImage7, blogImage8, blogImage9, blogImage10) = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

        modelBuilder.Entity<Media>().HasData(new List<Media>
        {
            new () { Id = 11, BlogId= blogImage1, PathMedia = "mucrim.png", Type = MediaType.Image },
            new () { Id = 12, BlogId= blogImage2, PathMedia = "chatre.png", Type = MediaType.Image },
            new () { Id = 13, BlogId= blogImage3, PathMedia = "chaca.png", Type = MediaType.Image },
            new () { Id = 14, BlogId= blogImage3, PathMedia = "banh-xeo-my-cang-dac-san-binh-dinh.vntrip-e1501650332846.jpg", Type = MediaType.Image },
            new () { Id = 15, BlogId= blogImage3, PathMedia = "Banh-trang-nuoc-dua-am-thuc-binh-dinh.jpg", Type = MediaType.Image },
            new () { Id = 16, BlogId= blogImage3, PathMedia = "bat-bun-song-than.jpg", Type = MediaType.Image },
            new () { Id = 17, BlogId= blogImage3, PathMedia = "cua-huynh-de-vntrip-e1536313616403.jpg", Type = MediaType.Image },
            new () { Id = 18, BlogId= blogImage3, PathMedia = "goi-ca-chinh-binh-dinh.jpg", Type = MediaType.Image },
            new () { Id = 19, BlogId= blogImage3, PathMedia = "banhhong.jpg", Type = MediaType.Image },
            new () { Id = 20, BlogId= blogImage3, PathMedia = "banhtrangchaca.jpg", Type = MediaType.Image },
        });

        // Blog seeding data
        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 1,
            Name = "Mực rim Quy Nhơn",
            Content = "Mực rim là món ăn phổ biến khiến du thích yêu thích có mặt ở hầu hết những vùng biển lớn. Tuy nhiên mực rim hay còn gọi là mực ngào Bình Định có một hương vị thơm ngon rất riêng từ vùng biển duyên hải miền Trung. Mực rim Quy Nhơn được người dân làm từ những con mực tươi nhất và hương vị không nơi nào giống được. Với hương thơm ngon đặc biệt cùng vị cay cay kích thích vị giác, mực rim trở thành món ăn vặt siêu ngon và được mọi người vô cùng yêu thích. Đồng thời, với những hũ mực rim được làm sẵn giúp bạn có thể dễ dàng lựa chọn đặc sản Bình Định này để làm quà tặng.",
            DateCreated = DateTime.Parse("2022-08-25")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 2,
            Name = "Chả Tré rơm",
            Content = "Với tên gọi độc và lạ của món Chả Tré, món đặc sản Bình Định này đã gợi nên sự tò mò với nhiều du khách muốn tìm hiểu và được thử món ăn độc đáo này. Mặc dù đã có mặt phổ biến khắp các tỉnh thành Trung Trung bộ, nhưng hương vị thơm ngon nhất vẫn là chả Tré Bình Định với cách làm và công thức chỉ vùng đất Bình Định mới làm nên được.Thành phần nguyên liệu làm chả Tré cũng tương tự với các loại nem, bì của miền bắc. Nhưng Tré Bình Định được người dân nơi đây khéo léo thay thế bằng nhiều loại nguyên liệu khác như tai heo, lỗ mũi heo, da heo, thịt ba chỉ,...Tré cũng thích hợp để trở thành món quà mang về khi bạn đến thăm Bình Định.",
            DateCreated = DateTime.Parse("2022-08-25")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 3,
            Name = "Chả cá Quy Nhơn",
            Content = "Mặc dù chả cá có thể là đặc sản và có mặt ở nhiều nơi nhưng không phải hương vị chả cá nào cũng như nhau. Sở dĩ chả cá Quy Nhơn là một trong các đặc sản Bình Định nổi tiếng vì vị ngon và lạ đặc trưng. Với nguyên liệu được tuyển chọn từ những con cá biển tươi ngon nhất và công thức chế biến độc quyền của người dân đã tạo nên sự khác biệt cho chả cá Quy Nhơn. Chả cá Quy Nhơn phổ biến có 2 loại là chả hấp và chả chiên. Ngoài việc thưởng thức thực tiếp miếng chả dai, giòn, thơm ngon đặc biệt, các bạn có thể dùng chả cá này để làm “topping” cho các món ăn khác như cơm, bún, phở. Đây cũng là một lựa chọn thích hợp để bạn mua về làm quà cho người thân và bạn bè nữa đó.",
            DateCreated = DateTime.Parse("2022-08-25")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 4,
            Name = "Bánh Xèo Mỹ Cang",
            Content = "Đây là một món ngon đặc sản Quy Nhơn rất đỗi bình dị nhưng được du khách rất yêu thích. Nó được bày bán ở hầu hết các quán xá vỉa hè ở Bình Định. Bánh xèo được làm được những  nguyên liệu đơn giản như thịt heo băm nhuyễn, hành phi, rau thơm, trứng và bột gạo. Gaọ sẽ được tuyển chọn những những gạo to chắc mẩy không bị sâu để tạo độ ngọt của bánh. Gạo sẽ được đem đi xay và nấu bột thành một thứ hỗn hợp dẻo, đập trứng cho thịt băm và một số loại gia vị vào. Bên cạnh đó đac có một cái chảo đang được đun nóng. Người nấu sẽ múc từng múc lên chảo để tráng những miếng bánh, dải thịt băm nhuyễn đã được xào chín lên bên trên bề mặt bánh và guộn đều tay để bánh to tròn và đẹp. Hoặc có thể là những con tôm tươi ngon. Khi  ăn ăn kèm với rau thơm và nước chấm.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 5,
            Name = "Bánh tráng nước dừa",
            Content = "Khi đến du lịch Bình Định không thể không nhắc tới  món bánh tráng nước dừa. Đây là một món đặc sản nơi xứ dừa. Công đoạn chế biến bánh không quá cầu kì nhưng đòi hỏi sự tỉ mỉ, có kinh nghiệm của người tráng bánh. Nguyên liệu của bánh chủ yếu là Củ Mì ( củ sắn) được sắt nhỏ, xay lấy nước. Cơm dừa được nạo thành sợi nhỏ,  nước dừa và vừng đen. Tất cả đều được đổ chung vào một nồi lớn, trộn đều cho các gia vị hòa quyện cùng với nhau và được đun nóng. Bên cạnh đó có một chảo đang được đun nóng. Khi chảo nóng lên người tráng bánh sẽ dùng một cái gáo làm bằng sọ dừa có cán dài múc từng gáo nước bánh lên chảo và tráng đều. Tráng bánh phải đều tay để cơm dừa và vừng đen được dàn đều mặt bánh. Bánh phải tròn mỏng và không bị chỗ dày, chỗ mỏng thì mới là bánh đạt chuẩn. cứ tráng được mười chiếc  bánh thì đem ra phơi. khi ăn bạn cần nướng lên để bánh có độ phồng và dậy hết mùi thơm của vừng, của nước cốt dừa và cơm dừa. Có thể ăn bánh thay cơm ăn chỉ thấy no mà không thấy chán.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 6,
            Name = "Bún song  thần",
            Content = "Bún song thần có chút khác biệt với các loại bún thông thường khác bởi thay vì sợi bún được làm từ bột gạo hay bột củ mì kéo sợi thì bún song thần lại được làm từ bột đậu xanh. Bún Song thần đặc sản Bình Định có màu trắng đặc trưng. Bún được đặt song  song bên nhau nên có tên là bún song thần. Món đặc sản này có giá trị dinh dưỡng cao hơn các loại bún khác. Tuy nhiên giá thành của bún khá cao bởi 5kg đậu xanh chỉ là được 1kg bún.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 7,
            Name = "Cua Huỳnh Đế",
            Content = "Món món hải sản ngon nức tiếng ở Bình Định. Cua Huỳnh đếđược xem là vua của các loại cua bởi nó có mai đỏ vàng như một bộ long bào uy nghi của các nhà vua, hai bên có gai li ti sắc nhọn, hai chiếc càng to chắc khỏe. Cua thường sống trong những ngách đá trên biển Bình Định. Cua Huỳnh Đế có thịt thơm, chắc  và có thể chế biến thành nhiều món ăn ngon khác nhau như cua nướng, cua hấp… đều rất thơm ngon.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 8,
            Name = "Gỏi cá chích",
            Content = "Cá Chích là loại cá nước ngọt sống ở các sông hồ ao suối. Cũng bởi Bình Định có nhiều sông hồ nên đây là môi trường thuận lợi để loài đặc sản này sinh sống. Cá Chích đặc sản Bình Định có thân  hình nhỏ, dài. Cá Chích sau khi được  đánh bắt lên sẽ được làm  sạch  và chiên giòn. Vì  là loài cá có kích cỡ nhỏ nên  khi ăn  người ta sẽ kẹp cả con cá đã được chiên vàng ăn với bánh phở cuốn, kèm rau thơm, dưa chuột. Cá ngọt thịt nên bạn ăn sẽ không bị chán. Tuy Nhiên nếu bạn là tín đồ gỏi sống bạn có thể được  thưởng thức gỏi cá chích với những thớ thịt  đc lọc xương làm sạch.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 9,
            Name = "Bánh hồng Tam Quan",
            Content = "Bánh hồng Tam Quan là một trong những món đặc sản của Bình Định, được xem như biểu trưng cho tin vui, thường xuất hiện trong các dịp cưới hỏi của người dân nơi đây. Điều đặc biệt bánh hồng Tam Quan là bánh được làm từ gạo nếp Ngự nổi tiếng dẻo thơm. Do hoàn toàn không có chất bảo quản nên bánh chỉ để được 5 ngày thôi bạn nhé.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 10,
            Name = "Bánh tráng chả cá",
            Content = "Bánh tráng chả cá là một trong những đặc sản nổi tiếng gần xa của Bình Định. Bánh tráng chả cá được làm từ nguyên liệu chính là cá cùng một ít gia vị và bột năng. Để món ăn đúng vị hơn bạn nên ăn kèm với rau răm nhé.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 11,
            Name = "Mực ngào vị tỏi",
            Content = "Nếu đã đến với đất Bình Định thì bạn nhất định phải thử qua món mực ngào vị tỏi nhé. Món ăn là sự hòa quyện giữa vị mực vừa tươi vừa giòn cùng vị cay đặc trưng của ớt và tỏi. Bạn nhớ bảo quản món này ở nhiệt độ thoáng mát nha.",
            DateCreated = DateTime.Parse("2022-09-03")
        });

        // media seeding data
        var bannerImage1 = 1;
        var bannerImage2 = 2;
        var bannerImage3 = 3;

        modelBuilder.Entity<Media>().HasData(new List<Media>
        {
            new () { Id = 1, BannerId= bannerImage1, PathMedia = "slide_home_1.jpg", Type = MediaType.Image },
            new () { Id = 2, BannerId= bannerImage2, PathMedia = "slide_home_2.jpg", Type = MediaType.Image },
            new () { Id = 3, BannerId= bannerImage3, PathMedia = "slide_home_3.jpg", Type = MediaType.Image },
        });
        // Banner seeding data
        modelBuilder.Entity<Banner>().HasData(new Banner
        {
            Id = 1,
            Name = "Chả cá Quy Nhơn",
            Discount = 10,  // 10% discount
            Price = 100000,
            Description = "Chả cá Quy Nhơn nổi tiếng với hương vị đặc trưng, được làm từ cá tươi ngon vùng biển Quy Nhơn.",
            DateCreated = DateTime.Parse("2022-08-19")
        });

        modelBuilder.Entity<Banner>().HasData(new Banner
        {
            Id = 2,
            Name = "Gỏi cá Chình",
            Discount = 15,  // 15% discount
            Price = 200000,
            Description = "Gỏi cá chình là món ăn đặc sản với hương vị chua ngọt, kết hợp từ cá chình tươi ngon và các loại rau thơm.",
            DateCreated = DateTime.Parse("2022-09-10")
        });

        modelBuilder.Entity<Banner>().HasData(new Banner
        {
            Id = 3,
            Name = "Nem chợ Huyện",
            Discount = 5,  // 5% discount
            Price = 150000,
            Description = "Nem chợ Huyện, món ăn truyền thống với hương vị thơm ngon, được làm từ thịt heo tươi và gia vị đặc trưng.",
            DateCreated = DateTime.Parse("2022-10-01")
        });
    }
}
