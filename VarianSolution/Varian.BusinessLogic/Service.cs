using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varian.BusinessLogic
{
    public class Service
    {
        /// <summary>
        /// IntToRoman - Convert int to Roman number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string IntToRoman(int number)
        {
            if ((number < 1) || (number > 3999))
                throw new ArgumentOutOfRangeException("Number is out of range. Value must be betwheen 1 and 3999.");

            var sb = new StringBuilder();
            int numberOfDigits = number.ToString().Length;

            while (number > 0)
            {
                if (numberOfDigits > number.ToString().Length)
                {
                    sb.Append(" ");
                    numberOfDigits = number.ToString().Length;
                }

                if (number >= 1000)
                {
                    sb.Append("M");
                    number = number - 1000;
                }
                else if (number >= 900)
                {
                    sb.Append("CM");
                    number = number - 900;
                }
                else if (number >= 500)
                {
                    sb.Append("D");
                    number = number - 500;
                }
                else if (number >= 400)
                {
                    sb.Append("XD");
                    number = number - 400;
                }
                else if (number >= 100)
                {
                    sb.Append("C");
                    number = number - 100;
                }
                else if (number >= 90)
                {
                    sb.Append("XC");
                    number = number - 90;
                }
                else if (number >= 50)
                {
                    sb.Append("L");
                    number = number - 50;
                }
                else if (number >= 40)
                {
                    sb.Append("XL");
                    number = number - 40;
                }
                else if (number >= 10)
                {
                    sb.Append("X");
                    number = number - 10;
                }
                else if (number >= 9)
                {
                    sb.Append("IX");
                    number = number - 9;
                }
                else if (number >= 5)
                {
                    sb.Append("V");
                    number = number - 5;
                }
                else if (number >= 4)
                {
                    sb.Append("IV");
                    number = number - 4;
                }
                else if (number >= 1)
                {
                    sb.Append("I");
                    number = number - 1;
                }
            }

            return sb.ToString();

        }
    }
}
