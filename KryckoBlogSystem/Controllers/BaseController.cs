using KryckoBlogSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KryckoBlogSystem.Controllers
{
    public class BaseController : Controller
    {

        public BaseController()
            : this(new KryckoBlogSystemDBContext())
        {
        }
        public BaseController(KryckoBlogSystemDBContext context)
        {
            this.PersistenceContext = context;
        }
        public KryckoBlogSystemDBContext PersistenceContext
        {
            get;
            set;
        }
    }
}