using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varian.BusinessLogic;
using Varian.BusinessLogic.Model;

namespace Varian.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            //string input;
            //while (true)
            //{
            //    input = Console.ReadLine();
            //    try
            //    {
            //        if (int.TryParse(input, out number))
            //        {
            //            Console.WriteLine(Service.IntToRoman(number));
            //        }
            //        else
            //        {
            //            Console.WriteLine(input + " it's not a number");
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            // test
            var input = "Consectetur 99 vgt 999 adipiscing 9999 elit 5.";

            var output = Service.ReplaceIntToRomanNumber(input);

            Console.WriteLine("Number of replacements: " + output.NumberOfReplacements);
            Console.WriteLine("New string: " + output.NewString);

            Console.ReadLine();

        }
    }
}
