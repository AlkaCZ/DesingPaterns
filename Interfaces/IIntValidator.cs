﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPaterns.Interfaces
{
    interface IBCNValidator
    {
        bool IsValid(string s, string date);
    }
}
