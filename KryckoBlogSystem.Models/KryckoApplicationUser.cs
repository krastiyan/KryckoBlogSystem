using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;

namespace KryckoBlogSystem.Models
{

    public class KryckoApplicationUser : IdentityUser
    {

        public KryckoApplicationUser()
        {
            this.Posts = new HashSet<Post>();
            this.PostsComments = new HashSet<PostComment>();
        }

        //[Key]
        //public int Id { get; set; }
        //Above would hide inheruted automatic property Id from Identity package

        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<PostComment> PostsComments { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<KryckoApplicationUser> manager)
       {
           // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
           var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
           // Add custom user claims here
           return userIdentity;
       }
    }
}
