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
        public IActionResult Create(Blog blog)
        {
            
            //var blogs = context.Blogs.OrderBy(x => x.TimeStamp).Include(c => c.Category).Include(u => u.User).Take(10).FirstOrDefault();
            context.Blogs.Add(blog);
            

            return View(blog);
        }




        //var blogs = context.Blogs.OrderBy(x => x.Created).Include(c => c.Category).Include(u => u.User).Take(10).FirstOrDefault();
    }
}
