using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPaterns.Interfaces;

namespace DesingPaterns.Validators
{
 public   class BcnValidator : IBCNValidator
    {
        public bool IsValid(string s, string date)
        {
            //První část r. čísla
            string[] stringBCN = s.Split('/');
            char[] firstPart = stringBCN[0].ToCharArray();

            

            //for (int i = 0; i < stringBCN[0].Length; i++)
            //{
            //    intFirstPart[i] = Convert.ToInt32(firstPart[i]);
            //}
            

            //Datum narození
            string[] stringDateField = date.Split('.');
            int[] intDateField = new int[6];
            char[] Days;
            char[] Months;
            Days = stringDateField[0].ToCharArray();
            Months = stringDateField[1].ToCharArray();
            //Year


            if (firstPart[0] == intDateField[0] && firstPart[1] == intDateField[1] && firstPart[2] == intDateField[2] && firstPart[3] == intDateField[3] && firstPart[4] == intDateField[4])
            {
                return true;
            }

            return false;

        }
    }
}
