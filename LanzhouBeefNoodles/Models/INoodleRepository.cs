using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface INoodleRepository
    {
        IEnumerable<Noodles> GetAllNoodles();
        Noodles GetNoodleById(int id);
    }
}
