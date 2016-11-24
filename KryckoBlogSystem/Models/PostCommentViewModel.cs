using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KryckoBlogSystem.Models
{
    public class PostCommentViewModel
    {
        [Display(Name = "Comment content")]
        public string Content { get; set; }

        public int CommentedPostID { get; set; }

        [Display(Name = "Commentor: ")]
        public string CommentAuthor { get; set; }
    }
}