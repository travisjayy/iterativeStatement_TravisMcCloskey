using System;

namespace iterativeStatement_TravisMcCloskey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number between 2 and 10 and witness some magic:");
            int start = 0;
            try
            {
                string input = Console.ReadLine();
                int inputValue = int.Parse(input);
                if (inputValue % 2 == start)
                {
                    for (int userInput = start; userInput < inputValue + 1; userInput++)
                    {
                        Console.WriteLine("You entered an even number :D");
                    }
                }
                else
                {
                    for (int userInput = start; userInput < inputValue - 1; userInput++)
                    {
                        Console.WriteLine("You entered an odd number D;");
                    }
                }
            }
            catch
            {
            }
        }
    }
}
