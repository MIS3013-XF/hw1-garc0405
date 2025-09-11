// HW1a Sales Total

// Your Name: Angel Garcia Molina
// Did you seek help ? If yes, specify the helper or web link here: I used the "HelloWorldAgain" project
// from last week for a lot of the foundation. I used Google Gemini AI
// to polish some things I was confused about.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double str1;
            double num2;
            double num3;

            double sum;

            const double multiplier = 0.085;

            string Str1AsString;
            string Num2AsString;
            string Num3AsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            Str1AsString = Console.ReadLine();
            Console.WriteLine("How many water bottles do you want to buy?");
            Num2AsString = Console.ReadLine();
            Console.WriteLine("What is the price for each water bottle?");
            Num3AsString = Console.ReadLine();

            string productname = Str1AsString;
            num2 = Convert.ToDouble(Num2AsString);
            num3 = Convert.ToDouble(Num3AsString);

            sum = num2 * num3;
            Console.WriteLine("Your subtotal for your bill is " + sum.ToString("C"));

            double salestax = sum * multiplier;
            Console.WriteLine("Your sales tax for your bill is " + salestax.ToString("C"));

            double total = salestax + sum;
            Console.WriteLine("Your total for your bill is " + total.ToString("C"));
            Console.ReadKey();
         
        }
    }
}
