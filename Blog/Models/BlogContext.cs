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
                new Category { CategoryId = "P", CategoryName = "C Sharp"},
                new Category { CategoryId = "E", CategoryName = "Java"}
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
                    BlogPost = "Älskar att koda i C sharp ... ",
                    TimeStamp = "2020-06-01",
                    CategoryId = "C",
                    UserId = 2
                },
                new Blog
                {
                    BlogId = 2,
                    BlogPost = "Älskar att koda i Java ... ",
                    TimeStamp = "2020-06-02",
                    CategoryId = "J",
                    UserId = 2
                },
                new Blog
                {
                    BlogId = 3,
                    BlogPost = "Tycker inte om att koda i C sharp ... ",
                    TimeStamp = "2020-06-03",
                    CategoryId = "C",
                    UserId = 1
                },
                new Blog
                {
                    BlogId = 4,
                    BlogPost = "Tycker inte om att koda i Java ... men gillar Java kaffe ",
                    TimeStamp = "2020-06-04",
                    CategoryId = "J",
                    UserId = 3
                }
                );
        }
    }
}
