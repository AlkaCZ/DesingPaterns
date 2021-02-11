using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPaterns.Interfaces;

namespace DesingPaterns.Validators
{
 public class SurnameValidator : IStringValidator
    {
        public bool IsValid(string s)
        {
            return s.Length > 3;
        }
    }
}
