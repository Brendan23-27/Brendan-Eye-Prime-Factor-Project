using System;
using Prime_Factors_class;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prime_Factor_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? userInput;
            int intUserInput;
            List<int> solution;
            string results;

            Console.WriteLine("Hello please enter a number to calculate its prime factor(s)");
            userInput = Console.ReadLine();

           intUserInput = Convert.ToInt32(userInput);

           solution = PrimeFactors.PrimeFactorCalculator(intUserInput);
            results = string.Join(",", solution);

            Console.WriteLine("its prime factor(s) is/are " + results);
    
        }
    }
}
