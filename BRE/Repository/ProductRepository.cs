using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRE.Interfaces;

namespace BRE.Repository
{
    public class ProductRepository :IRules
    {
        private string match;

        public ProductRepository(string productType, string title)
        {
            match = $"{productType} {title}";
        }

        public bool ShouldApply(IGetOrder reader)
        {
            return reader.Request.Any(x => x.Contains(match));
        }
    }
}
