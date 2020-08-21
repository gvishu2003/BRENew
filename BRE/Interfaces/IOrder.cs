using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.Interfaces
{
    public interface IOrder
    {
        IEnumerable<string> Books { get; }

        IEnumerable<string> Video { get; }
    }
}
