﻿using System;
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
        public IActionResult Create(Models.Blog blog)
        {
            var _blog = new Models.Blog();
            _blog.UserId = blog.UserId;
            _blog.BlogPost = blog.BlogPost;
            _blog.CategoryId = blog.CategoryId;
            _blog.TimeStamp = DateTime.Now.ToString("yyyy/MM/dd H:mm");

            context.Blogs.Add(_blog);
            context.SaveChanges();

            return View("Index");
        }

    }
}
