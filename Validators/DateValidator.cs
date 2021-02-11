using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPaterns.Interfaces;

namespace DesingPaterns.Validators
{
  public  class DateValidator : IDateValidator
    {
        public bool IsValid(string date)
        {
            DateTime myDate = DateTime.Now;
            
            string[] stringField = date.Split('.');
            int[] intField = new int[3];
            for (int i = 0; i < intField.Length; i++)
            {
                intField[i] = Convert.ToInt32(stringField[i]);
            }

            if (intField[0] < 31 && intField[1] < 12 && intField[2] < myDate.Year)
            {
                return true;
            }
            return false;

        }
    }
}
