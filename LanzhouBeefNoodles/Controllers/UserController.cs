using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Controllers
{
    [Route("admin/[controller]/[action]")]
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IList<String> Index()
        {
            return new List<string> { "阿莱克斯", "莱克斯", "克斯", "斯" };
        }
    }
}
