﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Concrete;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(ImagesContext))]
    [Migration("20240428165724_mg")]
    partial class mg
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Entity.Images", b =>
                {
                    b.Property<int>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ImgId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entity.ResponseImages", b =>
                {
                    b.Property<int>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("diseaseRates")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("second_top_disease")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("second_top_disease_Rate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("top_disease")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("top_disease_Rate")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImgId");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Entity.feedback", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
