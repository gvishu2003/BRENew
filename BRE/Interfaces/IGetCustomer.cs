﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.Interfaces
{
    public interface IGetCustomer
    {
        ICustomer GetCustomer(int customerId);
    }
}
