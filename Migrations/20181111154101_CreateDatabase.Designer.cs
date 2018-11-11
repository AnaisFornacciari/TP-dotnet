﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaylistManager.Data;

namespace PlaylistManager.Migrations
{
    [DbContext(typeof(PlaylistManagerContext))]
    [Migration("20181111154101_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("PlaylistManager.Models.Playlist", b =>
                {
                    b.Property<int>("PlaylistId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("PlaylistId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("PlaylistManager.Models.PlaylistSong", b =>
                {
                    b.Property<int>("SongId");

                    b.Property<int>("PlaylistId");

                    b.HasKey("SongId", "PlaylistId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("SongOfPlaylist");
                });

            modelBuilder.Entity("PlaylistManager.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Genre");

                    b.Property<int?>("PlaylistId");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("SongId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("PlaylistManager.Models.PlaylistSong", b =>
                {
                    b.HasOne("PlaylistManager.Models.Playlist", "Playlist")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlaylistManager.Models.Song", "Song")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlaylistManager.Models.Song", b =>
                {
                    b.HasOne("PlaylistManager.Models.Playlist")
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId");
                });
#pragma warning restore 612, 618
        }
    }
}