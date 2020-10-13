using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

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
            var blogs = context.Blogs.OrderBy(b => b.GetDateTime).ToList();
            return View(blogs);
        }

        public IActionResult Add()
        {

            return View();
        }
    }
}
