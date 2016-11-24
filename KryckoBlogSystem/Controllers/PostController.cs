using KryckoBlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KryckoBlogSystem.Controllers
{
    public class PostController : BaseController
    {
        public ActionResult Index()
        {
            var post = this.PersistenceContext.Posts.FirstOrDefault();

            ICollection<PostViewModel> posts = this.PersistenceContext.Posts.Select(p =>
            new PostViewModel()
            {
                PostID = p.Id,
                Name = p.Name,
                Content = p.Content,
                UserName = p.User.UserName,
                Comments = p.Comments
            }
            )
            .ToList();
            return View(posts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PostViewModel thePost)
        {
            var user = this.PersistenceContext.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);
            Post psot = new Models.Post
            {
                Name = thePost.Name,
                Content = thePost.Content,
                User = user
            };

            this.PersistenceContext.Posts.Add(psot);
            this.PersistenceContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}