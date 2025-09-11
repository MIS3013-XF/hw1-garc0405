// HW1b Grade

// Your Name: Angel Garcia Molina
// Did you seek help ? If yes, specify the helper or web link here: Same as the other one, a lot of the
// foundation comes from the HelloWorldAgain file. I did use a bit of Gemini AI to clarify my doubts.


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double str1;
            double str2;
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;
           
            string Str1AsString;
            string Str2AsString;
            string Num1AsString;
            string Num2AsString;
            string Num3AsString;
            string Num4AsString;
            string Num5AsString;
            string Num6AsString;
          
            Console.WriteLine("What is your first name?");
            Str1AsString = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Str2AsString = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            Num1AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            Num2AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            Num3AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for exam1?");
            Num4AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the exam2?");
            Num5AsString = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for the final?");
            Num6AsString = Console.ReadLine();

            string firstname = Str1AsString;
            string lastname = Str2AsString;
            num1 = Convert.ToDouble(Num1AsString);
            num2 = Convert.ToDouble(Num2AsString);
            num3 = Convert.ToDouble(Num3AsString);
            num4 = Convert.ToDouble(Num4AsString);
            num5 = Convert.ToDouble(Num5AsString);
            num6 = Convert.ToDouble(Num6AsString);

            double finalgrade = (num2 * 0.20) + (num3 * 0.15) + (num4 * 0.15) + (num5 * 0.25) + (num6 * 0.25);
            Console.WriteLine($"\n{firstname} {lastname}({num1}), your final grade is " + finalgrade.ToString("N2"));
            Console.ReadKey();




        }
    }
}
