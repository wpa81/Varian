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
            string input;
            ReplaceIntToRomanNumberOutput output = null;
            while (true)
            {
                Console.WriteLine("Enter a string to test the ReplaceIntToRomanNumber method.");
                input = Console.ReadLine();
                output = Service.ReplaceIntToRomanNumber(input);
                if(output != null)
                {
                    Console.WriteLine("Number of replacements: " + output.NumberOfReplacements);
                    Console.WriteLine("New string: " + output.NewString);
                } else
                {
                    Console.WriteLine("Something bad happened!!!");
                }
                Console.WriteLine("----------------------------------");


            }

        }
    }
}
