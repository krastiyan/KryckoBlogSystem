﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryckoBlogSystem.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Content { get; set; }

        public virtual KryckoApplicationUser User { get; set; }

        public virtual List<PostComment> Comments { get; set; }
    }
}
