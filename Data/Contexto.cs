using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using EtecTube.Models;

namespace EtecTube.Data
{
    public class Contexto : IdentityDbContext<User>
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Identity Name Definition
            // Renomeando as Tabela
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogins");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserTokens");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
            });
            #endregion

            #region Populate Identity
            string ADMIN_ID = Guid.NewGuid().ToString();
            string MODERADOR_ID = Guid.NewGuid().ToString();
            string USUARIO_ID = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole{
                    Id = ADMIN_ID,
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole{
                    Id = MODERADOR_ID,
                    Name = "Moderador",
                    NormalizedName = "MODERADOR"
                },
                new IdentityRole{
                    Id = USUARIO_ID,
                    Name = "Usuario",
                    NormalizedName = "USUARIO"
                }
            );
            var hash = new PasswordHasher<User>();
            byte[] avatarPic = File.ReadAllBytes(Directory.GetCurrentDirectory() + @"/wwwroot/img/avatar.png");
            modelBuilder.Entity<User>().HasData(
                new User{
                    Id = ADMIN_ID,
                    FullName = "Leonardo de Souza Barreto",
                    Nickname = "Leo",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@etectube.com.br",
                    NormalizedEmail = "ADMIN@ETECTUBE.COM.BR",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    ProfilePicture = avatarPic
                }
            );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>{
                    RoleId = ADMIN_ID,
                    UserId = ADMIN_ID
                }
            );
            #endregion

            #region Populate Channels
            Guid[] guid = new Guid[5];
            for (int i = 0; i < 5; i++) guid[i] = Guid.NewGuid();
            modelBuilder.Entity<Channel>().HasData(
                new Channel()
                {
                    Id = guid[0],
                    Name = "Irmãos Piologo",
                    ChannelPicture = "~/img/Channels/piologo.jpg",
                    UserId = ADMIN_ID
                },
                new Channel()
                {
                    Id = guid[1],
                    Name = "Melodicka Bros",
                    ChannelPicture = "~/img/Channels/melodicka.jpg",
                    UserId = ADMIN_ID
                },
                new Channel()
                {
                    Id = guid[2],
                    Name = "Frog Leap Studios",
                    ChannelPicture = "~/img/Channels/frogleapstudios.jpg",
                    UserId = ADMIN_ID
                },
                new Channel()
                {
                    Id = guid[3],
                    Name = "99 Coders",
                    ChannelPicture = "~/img/Channels/99coders.jpg",
                    UserId = ADMIN_ID
                },
                new Channel()
                {
                    Id = guid[4],
                    Name = "Balta.IO",
                    ChannelPicture = "~/img/Channels/balta.jpg",
                    UserId = ADMIN_ID
                }
            );
            #endregion

            #region Populate Videos
            modelBuilder.Entity<Video>().HasData(
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[0],
                    Name = "Avaiana de Pau Edição de 10 anos em FULL HD!",
                    Description = "VALE A PENA VER DE NOVO! Com mais de 17 milhões de views desde sua criação em 2004, este clássico da internet brasileira aparece pela primeira vez em FULL HD. É bom relembrar esse clássico, pois nesse ano de comemoração de 10 anos, vai rolar também a esperada Avaiana de Pau 2!!! Fiquem ligados!",
                    Thumbnail = "~/img/Videos/avaiana_pau.png",
                    PublishedDate = DateTime.Parse("30/01/2014"),
                    Likes = 79000,
                    Dislikes = 0,
                    Visualizations = 2354441
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[0],
                    Name = "Avaiane de Plume - A Avaiane dos Mimimi",
                    Description = "Chegou a novidade que as Menines esperavam, a Avaiane de Plume, porem será que ela é tão eficaz quanto a original de Pau?",
                    Thumbnail = "~/img/Videos/avaiana_plume.png",
                    PublishedDate = DateTime.Parse("24/03/2021"),
                    Likes = 65000,
                    Dislikes = 0,
                    Visualizations = 498251
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[1],
                    Name = "Falling In Reverse - ZOMBIFIED (Acoustic Cover)",
                    Description = "Let's start the year with an acoustic cover of the new song Zombified by @Falling In Reverse.",
                    Thumbnail = "~/img/Videos/falling_reverse.png",
                    PublishedDate = DateTime.Parse("09/01/2022"),
                    Likes = 2300,
                    Dislikes = 0,
                    Visualizations = 25759
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[1],
                    Name = "Country Roads but it's CYBERPUNK/INDUSTRIAL/SCI-FI wtf",
                    Description = "What if John Denver came from a different universe to bring us some electro cyberpunk industrial synthwave sci-fi futuristic metal vibes?",
                    Thumbnail = "~/img/Videos/country_roads.png",
                    PublishedDate = DateTime.Parse("20/11/2019"),
                    Likes = 85000,
                    Dislikes = 0,
                    Visualizations = 1284517
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[2],
                    Name = "What Is Love (metal cover by Leo Moracchioli feat. Priscila Serrano)",
                    Description = "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.",
                    Thumbnail = "~/img/Videos/what_is_love.png",
                    PublishedDate = DateTime.Parse("16/07/2021"),
                    Likes = 101000,
                    Dislikes = 0,
                    Visualizations = 2810254
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[2],
                    Name = "Carry On Wayward Son (metal cover by Leo Moracchioli feat. Truls Haugen)",
                    Description = "Hi there, my name is Leo and run a studio on the westside of Norway where I do music and video stuff for youtube. I also have a band called Frog Leap, where we do my metal covers live. For my covers I play everything myself as well as record, mix, master, shoot and edit the music & videos.",
                    Thumbnail = "~/img/Videos/carry_on_wayward_son.png",
                    PublishedDate = DateTime.Parse("31/01/2020"),
                    Likes = 102000,
                    Dislikes = 0,
                    Visualizations = 4725330
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[3],
                    Name = "Criando um app para compras de supermercado #07 - Finalizando o layout do app",
                    Description = "O que acha de criarmos uma aplicação completa juntos passo a passo? É um app para compras em supermercado. Acompanhe a série de vídeos.",
                    Thumbnail = "~/img/Videos/app_delphi.png",
                    PublishedDate = DateTime.Parse("21/02/2022"),
                    Likes = 186,
                    Dislikes = 0,
                    Visualizations = 1013
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[4],
                    Name = "var, string, System.String e StringBuilder no C# | por André Baltieri #balta",
                    Description = "String, string ou StringBuilder? Para que servem e quando devemos utilizar cada um destes tipos no C#!",
                    Thumbnail = "~/img/Videos/balta_string.png",
                    PublishedDate = DateTime.Parse("07/02/2022"),
                    Likes = 257,
                    Dislikes = 0,
                    Visualizations = 1726
                },
                new Video()
                {
                    Id = Guid.NewGuid(),
                    ChannelId = guid[4],
                    Name = "C# 10 e .NET 6 - Novidades na manipulação de listas | por André Baltieri #balta",
                    Description = "Participe do balta.io Experience, um evento online, ao vivo e gratuito que vai reunir grandes nomes da internet em uma experiência única! https://balta.io/experience",
                    Thumbnail = "~/img/Videos/balta_c10.png",
                    PublishedDate = DateTime.Parse("15/10/2021"),
                    Likes = 1000,
                    Dislikes = 0,
                    Visualizations = 8473
                }
            );
            #endregion
        }
    }
}