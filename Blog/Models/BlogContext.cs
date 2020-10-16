using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "P", CategoryName = "Politics" },
                new Category { CategoryId = "E", CategoryName = "Economy" },
                new Category { CategoryId = "W", CategoryName = "Weather" },
                new Category { CategoryId = "S", CategoryName = "Sports" }
                );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "MonaLisa" },
                new User { UserId = 2, UserName = "PlåtNiklas" },
                new User { UserId = 3, UserName = "SkånskaLasse" }
                );

            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    BlogId = 1,
                    BlogPost = "Senaste nytt från Ekot ",
                    TimeStamp = "2020-06-01",
                    CategoryId = "P",
                    UserId = 2
                },
                new Blog
                {
                    BlogId = 2,
                    BlogPost = "TT nyheter i sammanfattning ... ",
                    TimeStamp = "2020-06-02",
                    CategoryId = "P",
                    UserId = 2
                },
                new Blog
                {
                    BlogId = 3,
                    BlogPost = "Änglarna gjorde mål på Sankte Pär i Pärleporten ... ",
                    TimeStamp = "2020-06-03",
                    CategoryId = "S",
                    UserId = 1
                },
                new Blog
                {
                    BlogId = 4,
                    BlogPost = "Vädret mycket regn, åska och det blåser smådj_vlar",
                    TimeStamp = "2020-06-04",
                    CategoryId = "W",
                    UserId = 3
                }
                );
        }
    }
}
