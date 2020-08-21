using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.Interfaces
{
    public interface ICustomer
    {
        void AddMembership(MembershipType membershipType);
        void UpgradeMembership();
    }
}
