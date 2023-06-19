﻿// <auto-generated />
using JukeBox;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JukeBox.Migrations
{
    [DbContext(typeof(DbdContextClass))]
    [Migration("20230616093931_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JukeBox.Genres", b =>
                {
                    b.Property<string>("Genre")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("GenreDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Genre");

                    b.ToTable("Genres", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}