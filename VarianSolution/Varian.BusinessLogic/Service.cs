using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Varian.BusinessLogic.Model;

namespace Varian.BusinessLogic
{
    public class Service
    {
        /// <summary>
        /// IntToRoman - Convert int to Roman number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Roman number</returns>
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

        /// <summary>
        /// ReplaceIntToRomanNumber - replace int to roman numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns>ReplaceIntToRomanNumberOutput</returns>
        public static ReplaceIntToRomanNumberOutput ReplaceIntToRomanNumber(string input)
        {
            var output = new ReplaceIntToRomanNumberOutput
            {
                NumberOfReplacements = 0,
                NewString = input
            };

            // It will replace only the number that are whole word.
            // Example: Wpa81 is an username. 81 would not match to be replaced.
            var reg = new Regex(@"\b[0-9]+\b");
            var matchList = reg.Matches(input);
            var list = matchList.Cast<Match>().Select(match => int.Parse(match.Value)).ToList();

            foreach (var item in list)
            {
                if(item >= 1 && item <= 3999)
                {
                    output.NewString = Regex.Replace(output.NewString, @"\b"+item.ToString()+@"\b", IntToRoman(item));
                    output.NumberOfReplacements++;
                }
            }

            return output;
        }
    }
}
