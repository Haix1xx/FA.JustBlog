﻿// <auto-generated />
using System;
using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(JustBlogContext))]
    partial class JustBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "latest news",
                            Name = "News",
                            UrlSlug = "news"
                        },
                        new
                        {
                            Id = 2,
                            Description = "latest news about sport",
                            Name = "Sport",
                            UrlSlug = "sport"
                        },
                        new
                        {
                            Id = 3,
                            Description = "latest news about music",
                            Name = "Music",
                            UrlSlug = "music"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Modified = "yes",
                            PostContent = "This is an post content",
                            PostedOn = new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1516),
                            Published = false,
                            ShortDescription = "short",
                            Title = "Title latest",
                            UrlSlug = "title-latest"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Modified = "yes",
                            PostContent = "This is an post content",
                            PostedOn = new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1541),
                            Published = false,
                            ShortDescription = "short",
                            Title = "Title new releases",
                            UrlSlug = "latest-release"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Modified = "yes",
                            PostContent = "This is an post content",
                            PostedOn = new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1547),
                            Published = true,
                            ShortDescription = "short",
                            Title = "BillBoard Hot100 Release",
                            UrlSlug = "hot100-bb"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Modified = "yes",
                            PostContent = "This is an post content",
                            PostedOn = new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1551),
                            Published = false,
                            ShortDescription = "short",
                            Title = "Title hotest",
                            UrlSlug = "news-hot"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Modified = "yes",
                            PostContent = "This is an post content",
                            PostedOn = new DateTime(2023, 11, 29, 20, 3, 25, 666, DateTimeKind.Local).AddTicks(1556),
                            Published = true,
                            ShortDescription = "short",
                            Title = "Football Well-Player",
                            UrlSlug = "football-player"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 1,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 2,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 3,
                            TagId = 2
                        },
                        new
                        {
                            PostId = 4,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 5,
                            TagId = 3
                        },
                        new
                        {
                            PostId = 5,
                            TagId = 1
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UrlSlug");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 0,
                            Description = "Description",
                            Name = "latest",
                            UrlSlug = "latest"
                        },
                        new
                        {
                            Id = 2,
                            Count = 0,
                            Description = "Description",
                            Name = "hotest",
                            UrlSlug = "hotest"
                        },
                        new
                        {
                            Id = 3,
                            Count = 0,
                            Description = "Description",
                            Name = "funny",
                            UrlSlug = "funny"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Post", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tag", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
