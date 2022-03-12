using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EtecTube.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nickname = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserNameChangeLimit = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "longblob", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Channel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChannelPicture = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Channel_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChannelId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(8000)", maxLength: 8000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Thumbnail = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Likes = table.Column<uint>(type: "int unsigned", nullable: false),
                    Dislikes = table.Column<uint>(type: "int unsigned", nullable: false),
                    Visualizations = table.Column<uint>(type: "int unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b12d85ea-5a1d-4a45-b89e-bebebeeddf31", "439fd587-c06d-4e48-b067-87b24165a637", "Administrador", "ADMINISTRADOR" },
                    { "916b457d-ccc3-4832-b31c-3792aa10e3e2", "f55e4180-7050-45cd-abfd-ca0cc700ed0c", "Moderador", "MODERADOR" },
                    { "ab8868c8-8a8d-40d2-8981-96074633d86f", "75ffccd0-80d9-4880-9c59-34b659d4c04f", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserNameChangeLimit" },
                values: new object[] { "b12d85ea-5a1d-4a45-b89e-bebebeeddf31", 0, "9c61bdbd-4802-4a86-8291-b976b2eae4ae", "admin@etectube.com.br", true, "Leonardo de Souza Barreto", false, null, "Leo", "ADMIN@ETECTUBE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEMufpH1N3SlmJKF9edKnlVw7A2ACv3x9U+baJeAAj5NXKAJBCuFw0iinn0GRB2NZ7Q==", null, false, null, "49282936", false, "Admin", 10 });

            migrationBuilder.InsertData(
                table: "Channel",
                columns: new[] { "Id", "ChannelPicture", "Name", "UserId" },
                values: new object[,]
                {
                    { new Guid("50d782a4-e0bd-4b41-8f48-6cb294793f8a"), "~/img/Channels/piologo.jpg", "Irmãos Piologo", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" },
                    { new Guid("05a816f7-b1d9-45d4-a34c-784075ab365e"), "~/img/Channels/melodicka.jpg", "Melodicka Bros", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" },
                    { new Guid("f977bcee-42df-4b6c-91a9-bdf3da992d0f"), "~/img/Channels/frogleapstudios.jpg", "Frog Leap Studios", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" },
                    { new Guid("ec728374-badd-419a-8384-6c3a1ef5fd94"), "~/img/Channels/99coders.jpg", "99 Coders", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" },
                    { new Guid("ffdf91f9-2284-4580-85d2-4616f12633d2"), "~/img/Channels/balta.jpg", "Balta.IO", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b12d85ea-5a1d-4a45-b89e-bebebeeddf31", "b12d85ea-5a1d-4a45-b89e-bebebeeddf31" });

            migrationBuilder.InsertData(
                table: "Video",
                columns: new[] { "Id", "ChannelId", "Description", "Dislikes", "Likes", "Name", "PublishedDate", "Thumbnail", "Visualizations" },
                values: new object[,]
                {
                    { new Guid("1cd871d8-3d2c-46c6-b9f1-9f68c1dfa4d7"), new Guid("50d782a4-e0bd-4b41-8f48-6cb294793f8a"), "VALE A PENA VER DE NOVO! Com mais de 17 milhões de views desde sua criação em 2004, este clássico da internet brasileira aparece pela primeira vez em FULL HD. É bom relembrar esse clássico, pois nesse ano de comemoração de 10 anos, vai rolar também a esperada Avaiana de Pau 2!!! Fiquem ligados!", 0u, 79000u, "Avaiana de Pau Edição de 10 anos em FULL HD!", new DateTime(2014, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/avaiana_pau.png", 2354441u },
                    { new Guid("7d090b7d-2af9-4934-9279-5a2cebc9cd94"), new Guid("50d782a4-e0bd-4b41-8f48-6cb294793f8a"), "Chegou a novidade que as Menines esperavam, a Avaiane de Plume, porem será que ela é tão eficaz quanto a original de Pau?", 0u, 65000u, "Avaiane de Plume - A Avaiane dos Mimimi", new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/avaiana_plume.png", 498251u },
                    { new Guid("ab60bafc-6501-45f8-9b1e-958bbab788ce"), new Guid("05a816f7-b1d9-45d4-a34c-784075ab365e"), "Let's start the year with an acoustic cover of the new song Zombified by @Falling In Reverse.", 0u, 2300u, "Falling In Reverse - ZOMBIFIED (Acoustic Cover)", new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/falling_reverse.png", 25759u },
                    { new Guid("a53934d1-266e-42f6-b688-27f5571cde2b"), new Guid("05a816f7-b1d9-45d4-a34c-784075ab365e"), "What if John Denver came from a different universe to bring us some electro cyberpunk industrial synthwave sci-fi futuristic metal vibes?", 0u, 85000u, "Country Roads but it's CYBERPUNK/INDUSTRIAL/SCI-FI wtf", new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/country_roads.png", 1284517u },
                    { new Guid("cd39a371-8213-48d9-abac-3707e5df64b5"), new Guid("f977bcee-42df-4b6c-91a9-bdf3da992d0f"), "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.", 0u, 101000u, "What Is Love (metal cover by Leo Moracchioli feat. Priscila Serrano)", new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/what_is_love.png", 2810254u },
                    { new Guid("566060d5-dda9-4c96-bffa-f1cb7c01fe1e"), new Guid("f977bcee-42df-4b6c-91a9-bdf3da992d0f"), "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.", 0u, 102000u, "Carry On Wayward Son (metal cover by Leo Moracchioli feat. Truls Haugen)", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/carry_on_wayward_son.png", 4725330u },
                    { new Guid("c7214694-18c8-4ca4-8773-9350b578a9a4"), new Guid("ec728374-badd-419a-8384-6c3a1ef5fd94"), "O que acha de criarmos uma aplicação completa juntos passo a passo? É um app para compras em supermercado. Acompanhe a série de vídeos.", 0u, 186u, "Criando um app para compras de supermercado #07 - Finalizando o layout do app", new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/app_delphi.png", 1013u },
                    { new Guid("92585681-6c8c-498f-8552-f8b816c73a7d"), new Guid("ffdf91f9-2284-4580-85d2-4616f12633d2"), "String, string ou StringBuilder? Para que servem e quando devemos utilizar cada um destes tipos no C#!", 0u, 257u, "var, string, System.String e StringBuilder no C# | por André Baltieri #balta", new DateTime(2022, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/balta_string.png", 1726u },
                    { new Guid("7a4a3fa3-bc11-4f67-9920-64f645952079"), new Guid("ffdf91f9-2284-4580-85d2-4616f12633d2"), "Participe do balta.io Experience, um evento online, ao vivo e gratuito que vai reunir grandes nomes da internet em uma experiência única! https://balta.io/experience", 0u, 1000u, "C# 10 e .NET 6 - Novidades na manipulação de listas | por André Baltieri #balta", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "~/img/Videos/balta_c10.png", 8473u }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Channel_UserId",
                table: "Channel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Video_ChannelId",
                table: "Video",
                column: "ChannelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Channel");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
