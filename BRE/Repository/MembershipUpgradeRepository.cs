using BRE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BRE.Repository
{
    public class MembershipUpgradeRepository : IRules
    {
        public bool ShouldApply(IGetOrder reader)
        {            
            return reader.Request.Any(x => x.StartsWith("membership upgrade"));
        }
    }
}
