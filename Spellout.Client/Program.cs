using System;
using Spellout.Library;

namespace Spellout.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter a number (max 19 characters: )");

                string inputNumber = Console.ReadLine ();
                INumberToWord converter = new IndianSystem();
                bool isValid = converter.Validate(inputNumber);

                if (isValid)
                {
                    Console.WriteLine("Spelling : " + converter.Convert(inputNumber));
                    Console.ReadLine ();
                }
                else 
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.ReadLine ();
                }                
            } while (ShouldContinue());
        }

        private static bool ShouldContinue()
        {
            Console.WriteLine("Do you want to continue?(y/n) :");
            string response = Console.ReadLine ();
            return response.ToLower().Trim() == "y";
        }
    }
}
