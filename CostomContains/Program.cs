using System;

namespace CostomContains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence:");
            string sentence = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the part which you want:");
            string part = Console.ReadLine().ToLower();

            Console.WriteLine(sentence.MyCostomContains(part));
            
        }
    }
}
