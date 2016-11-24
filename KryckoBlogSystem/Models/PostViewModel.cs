using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KryckoBlogSystem.Models
{
    public class PostViewModel
    {
        public int PostID { get; set; }

        [Display(Name="Post title")]
        public string Name { get; set; }

        [Display(Name = "Post content")]
        public string Content { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Post Comments")]
        public ICollection<PostComment> Comments { get; set; }
    }
}