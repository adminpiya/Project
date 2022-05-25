using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Controllers
{
    public class NoodleController : Controller
    {
        // GET: /<controller>/
        public IList<String> Index()
        {
            return new List<string> { "牛肉面", "羊肉面", "鸡蛋面" };
        }
    }
}
