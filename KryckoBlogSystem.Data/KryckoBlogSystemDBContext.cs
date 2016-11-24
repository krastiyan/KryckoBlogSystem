using KryckoBlogSystem.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KryckoBlogSystem.Data
{
    public class KryckoBlogSystemDBContext :  IdentityDbContext<KryckoApplicationUser>
    {
        public KryckoBlogSystemDBContext()
            :base("KryckoBlogSystemConnection")
        {
                
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<PostComment> PostsComments { get; set; }

        //Below would hide inherited automatically created property users from Identity package
        //IDbSet<KryckoApplicationUser> Users { get; set; }

        public static KryckoBlogSystemDBContext Create()
        {
            return new KryckoBlogSystemDBContext();
        }
    }
}
