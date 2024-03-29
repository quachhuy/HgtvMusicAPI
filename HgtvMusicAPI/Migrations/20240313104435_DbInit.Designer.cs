﻿// <auto-generated />
using System;
using HgtvMusicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HgtvMusicAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240313104435_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HgtvMusicAPI.Data.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdmin"));

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdAdmin");

                    b.HasIndex("IdUser");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Album", b =>
                {
                    b.Property<int>("IdAlbum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlbum"));

                    b.Property<int?>("IdSinger")
                        .HasColumnType("int");

                    b.Property<string>("NameAlbum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path_Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseYear")
                        .HasColumnType("date");

                    b.HasKey("IdAlbum");

                    b.HasIndex("IdSinger");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"));

                    b.Property<string>("NameCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path_Img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Playlist", b =>
                {
                    b.Property<int>("IdPlaylist")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlaylist"));

                    b.Property<DateOnly>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("PlaylistName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdPlaylist");

                    b.HasIndex("IdUser");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Singer", b =>
                {
                    b.Property<int>("IdSinger")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSinger"));

                    b.Property<int>("Follower")
                        .HasColumnType("int");

                    b.Property<string>("NameSinger")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Path_Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSinger");

                    b.ToTable("Singer");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Song", b =>
                {
                    b.Property<int>("IdSong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSong"));

                    b.Property<int?>("IdAlbum")
                        .HasColumnType("int");

                    b.Property<int?>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int?>("IdSinger")
                        .HasColumnType("int");

                    b.Property<string>("NameSong")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Path_Img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSong");

                    b.HasIndex("IdAlbum");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdSinger");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Admin", b =>
                {
                    b.HasOne("HgtvMusicAPI.Data.User", "User")
                        .WithMany("Admins")
                        .HasForeignKey("IdUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Album", b =>
                {
                    b.HasOne("HgtvMusicAPI.Data.Singer", "Singer")
                        .WithMany("Albums")
                        .HasForeignKey("IdSinger");

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Playlist", b =>
                {
                    b.HasOne("HgtvMusicAPI.Data.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("IdUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Song", b =>
                {
                    b.HasOne("HgtvMusicAPI.Data.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("IdAlbum");

                    b.HasOne("HgtvMusicAPI.Data.Category", "Category")
                        .WithMany("Songs")
                        .HasForeignKey("IdCategory");

                    b.HasOne("HgtvMusicAPI.Data.Singer", "Singer")
                        .WithMany("Songs")
                        .HasForeignKey("IdSinger");

                    b.Navigation("Album");

                    b.Navigation("Category");

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Category", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.Singer", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("HgtvMusicAPI.Data.User", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
