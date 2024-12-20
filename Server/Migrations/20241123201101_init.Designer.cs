﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Server.Context;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241123201101_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Server.Models.Games", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GameId"));

                    b.Property<string>("GameGenre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("TotalTime")
                        .HasColumnType("integer");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Server.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("AccountDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Server.Models.UserScoreData", b =>
                {
                    b.Property<int>("ScoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScoreId"));

                    b.Property<float?>("AudioScore")
                        .HasColumnType("real");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<string>("GameStatus")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<float?>("GameplayScore")
                        .HasColumnType("real");

                    b.Property<float?>("GraphicScore")
                        .HasColumnType("real");

                    b.Property<float?>("QualityScore")
                        .HasColumnType("real");

                    b.Property<float?>("StoryScore")
                        .HasColumnType("real");

                    b.Property<float?>("SumScore")
                        .HasColumnType("real");

                    b.Property<float?>("TimePlayed")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ScoreId");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("UserScoreData");
                });

            modelBuilder.Entity("Server.Models.UserScoreData", b =>
                {
                    b.HasOne("Server.Models.Games", "Games")
                        .WithMany("ScoreData")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Models.User", "User")
                        .WithMany("ScoreData")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Games");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Server.Models.Games", b =>
                {
                    b.Navigation("ScoreData");
                });

            modelBuilder.Entity("Server.Models.User", b =>
                {
                    b.Navigation("ScoreData");
                });
#pragma warning restore 612, 618
        }
    }
}
