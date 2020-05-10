﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using final_pro.Models;

namespace final_pro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200510045707_initail")]
    partial class initail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("final_pro.Models.Postbook", b =>
                {
                    b.Property<string>("title")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ISBN")
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("title");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}