﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRE.Interfaces
{
    public interface ICommission
    {
        void GenerateCommission(double total, double percentage);
    }
}
