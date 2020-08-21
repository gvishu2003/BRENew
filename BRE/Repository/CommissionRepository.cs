using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRE.Interfaces;

namespace BRE.Repository
{
    public class CommissionRepository : IRules
    {
        public bool ShouldApply(IGetOrder reader)
        {
            return reader.Request.Any(x => x.StartsWith("commision"));
        }
    }
}
