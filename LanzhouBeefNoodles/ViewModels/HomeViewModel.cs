using LanzhouBeefNoodles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.ViewModels
{
    public class HomeViewModel
    {
        public IList<Noodles> Noodles { get; set; }
        public IList<Feedbacks> Feedbacks { get; set; }
    }
}
