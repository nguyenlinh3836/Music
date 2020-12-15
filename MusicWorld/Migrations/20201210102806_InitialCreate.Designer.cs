﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicWorld.Models;

namespace MusicWorld.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20201210102806_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MusicWorld.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImgAlbum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MusicWorld.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Achievement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("MusicWorld.Models.ArtistAlbum", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "AlbumId");

                    b.HasIndex("AlbumId");

                    b.ToTable("ArtistAlbums");
                });

            modelBuilder.Entity("MusicWorld.Models.ArtistTrack", b =>
                {
                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("ArtistId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("ArtistTracks");
                });

            modelBuilder.Entity("MusicWorld.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MusicWorld.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("TrackLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UrlImg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("MusicWorld.Models.ArtistAlbum", b =>
                {
                    b.HasOne("MusicWorld.Models.Album", "Album")
                        .WithMany("ArtistAlbums")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicWorld.Models.Artist", "Artist")
                        .WithMany("ArtistAlbums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicWorld.Models.ArtistTrack", b =>
                {
                    b.HasOne("MusicWorld.Models.Artist", "Artist")
                        .WithMany("ArtistTracks")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicWorld.Models.Track", "Track")
                        .WithMany("ArtistTracks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MusicWorld.Models.Track", b =>
                {
                    b.HasOne("MusicWorld.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");

                    b.HasOne("MusicWorld.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId");

                    b.Navigation("Album");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("MusicWorld.Models.Album", b =>
                {
                    b.Navigation("ArtistAlbums");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicWorld.Models.Artist", b =>
                {
                    b.Navigation("ArtistAlbums");

                    b.Navigation("ArtistTracks");
                });

            modelBuilder.Entity("MusicWorld.Models.Genre", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicWorld.Models.Track", b =>
                {
                    b.Navigation("ArtistTracks");
                });
#pragma warning restore 612, 618
        }
    }
}
