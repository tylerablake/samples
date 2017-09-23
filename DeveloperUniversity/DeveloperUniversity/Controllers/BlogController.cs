using DeveloperUniversity.Models;
using DeveloperUniversity.Models.ViewModels;
using DeveloperUniversity.Repositories;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DeveloperUniversity.Controllers
{
    public class BlogController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private BlogRepository _blogRepository = new BlogRepository();

        public ViewResult Index(int p = 1)
        {
            // pick latest 10 posts
            var posts = _blogRepository.Posts(p - 1, 10);

            var totalPosts = _blogRepository.TotalPosts();

            var listViewModel = new BlogListViewModel()
            {
                Posts = posts,
                TotalPosts = totalPosts
            };

            ViewBag.Title = "Latest Posts";

            return View("List", listViewModel);
        }

        //// GET: Blog
        //public ActionResult Index()
        //{
        //    //Grab 10 blog posts.
        //    var blogPosts = _db.Posts.Take(10);

        //    return View(blogPosts);
        //}

        public ActionResult Manage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Post() { PostedOn = DateTime.Today.Date});
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                _db.Posts.Add(post);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(post);
            }            
        }
    }
}