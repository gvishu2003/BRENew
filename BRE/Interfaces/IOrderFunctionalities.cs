using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.Interfaces
{
    public interface IOrderFunctionalities
    {
        IOrderFunctionalities AddMembership(MembershipType membershipType);
        IOrderFunctionalities UpgradeMembership();
        IOrderFunctionalities CreateShippingSlip();
        IOrderFunctionalities GenerateCommission();
        IOrderFunctionalities AddBook(string title);
        IOrderFunctionalities AddVideo(string title);
    }
}
