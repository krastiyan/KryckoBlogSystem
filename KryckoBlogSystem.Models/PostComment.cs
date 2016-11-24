using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryckoBlogSystem.Models
{
    public class PostComment
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public virtual Post CommentedPost { get; set; }

        public virtual KryckoApplicationUser CommentAuthor { get; set; }
    }
}
