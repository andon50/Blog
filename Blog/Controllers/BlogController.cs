using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext context { get; set; }

        public BlogController(BlogContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var blogs = context.Blogs.Include(u => u.User).Include(c => c.Category).OrderBy(t => t.TimeStamp).ToList();
            return View(blogs);
        }

        [HttpGet] //skickar till vyn
        public IActionResult Create()
        {
            ViewBag.Action = "Create";
            return View();
        }

        [HttpPost] //hämtar från vyn till controllern 
        public IActionResult Create(Models.Blog _blog)
        {
            var blog = new Models.Blog();
            blog.UserId = _blog.UserId;
            blog.BlogPost = _blog.BlogPost;
            blog.CategoryId = _blog.CategoryId;
            blog.TimeStamp = DateTime.Now.ToString("yyyy/MM/dd H:mm");

            context.Blogs.Add(blog);
            context.SaveChanges();

            //var blogs = context.Blogs.Include(u => u.User).Include(c => c.Category).OrderBy(t => t.TimeStamp).ToList();

            return View("Msg", blog);
        }

    }
}
