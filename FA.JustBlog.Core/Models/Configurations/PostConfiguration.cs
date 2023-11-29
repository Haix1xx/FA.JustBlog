using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(255);
            builder.Property(p => p.PostContent).IsRequired().HasMaxLength(10000);
            builder.Property(p => p.ShortDescription).HasMaxLength(255);
            builder.Property(p => p.UrlSlug).IsRequired().HasMaxLength(255);
            builder.HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);

            builder.HasData(
                new Post
                {
                    Id = 1,
                    Title = "Title latest",
                    UrlSlug = "title-latest",
                    PostContent = "This is an post content",
                    PostedOn = DateTime.Now,
                    Published = false,
                    Modified = "yes",
                    ShortDescription = "short",
                    CategoryId = 1,
                },
                new Post
                {
                    Id = 2,
                    Title = "Title new releases",
                    UrlSlug = "latest-release",
                    PostContent = "This is an post content",
                    PostedOn = DateTime.Now,
                    Published = false,
                    Modified = "yes",
                    ShortDescription = "short",
                    CategoryId = 1,
                },
                new Post
                {
                    Id = 3,
                    Title = "BillBoard Hot100 Release",
                    UrlSlug = "hot100-bb",
                    PostContent = "This is an post content",
                    PostedOn = DateTime.Now,
                    Published = true,
                    Modified = "yes",
                    ShortDescription = "short",
                    CategoryId = 3,
                },
                new Post
                {
                    Id = 4,
                    Title = "Title hotest",
                    UrlSlug = "news-hot",
                    PostContent = "This is an post content",
                    PostedOn = DateTime.Now,
                    Published = false,
                    Modified = "yes",
                    ShortDescription = "short",
                    CategoryId = 1,
                },
                new Post
                {
                    Id = 5,
                    Title = "Football Well-Player",
                    UrlSlug = "football-player",
                    PostContent = "This is an post content",
                    PostedOn = DateTime.Now,
                    Published = true,
                    Modified = "yes",
                    ShortDescription = "short",
                    CategoryId = 2,
                });
        }
    }
}
