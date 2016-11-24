using KryckoBlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KryckoBlogSystem.Controllers
{
    public class PostCommentController : BaseController
    {

        [HttpGet]
        public ActionResult Create(int commentedPostID)
        {
            return View(new PostCommentViewModel()
            {
                CommentedPostID = commentedPostID,
                CommentAuthor = HttpContext.User.Identity.Name
            });
        }

        [HttpPost]
        public ActionResult Create(PostCommentViewModel theComment)
        {
            var user = this.PersistenceContext.Users.FirstOrDefault(u => u.UserName == theComment.CommentAuthor);
            var post = this.PersistenceContext.Posts.FirstOrDefault(p => p.Id == theComment.CommentedPostID);
            PostComment comment = new Models.PostComment
            {
                Content = theComment.Content,
                CommentedPost = post,
                CommentAuthor = user,
            };

            this.PersistenceContext.PostsComments.Add(comment);
            this.PersistenceContext.SaveChanges();

            return RedirectToAction("Index", "Post");
        }
    }
}