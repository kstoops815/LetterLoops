using System;


namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string of letters.");
            var input = Console.ReadLine();
            foreach (char i in input)
            {
                Console.WriteLine(i);
            }
        }
    }
}
