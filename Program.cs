using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Simplify_Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a fraction");
                string fraction = Console.ReadLine();
                if (Regex.IsMatch(fraction, @"^[0-9]+\/[0-9]+$"))
                {
                    Console.WriteLine(Simplify(fraction));
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a correctly formatted fraction. Please try again.");
                }
            }
            
        }
        static string Simplify(string fraction)
        {
            string[] stringNums = fraction.Split('/');
            int num1 = Convert.ToInt32(stringNums[0]);
            int num2 = Convert.ToInt32(stringNums[1]);
            
            for(int i = num1; i > 0; i--)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    num1 /= i;
                    num2 /= i;
                }
            }
            return num1 + "/" + num2;
        }
    }
}
