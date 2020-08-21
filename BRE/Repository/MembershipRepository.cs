using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRE.Interfaces;

namespace BRE.Repository
{
    public class MembershipRepository : IRules
    {
        private MembershipType typeOfMembership;
        private string match;

        public MembershipRepository(MembershipType typeOfMembership)
        {
            this.typeOfMembership = typeOfMembership;
            match = "membership request " + typeOfMembership.ToString().ToLower();
        }

        public bool ShouldApply(IGetOrder reader)
        {
            return reader.Request.Any(x => x.Contains(match));
        }
    }
}
