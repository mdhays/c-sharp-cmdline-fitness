using System;

namespace cSharp.fitness
{

    class Program
    {

        static void Main()
        {

            int runningTotal = 0;

            bool keepGoing = true;

            while (keepGoing)
            {

                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(entry);

                    runningTotal = runningTotal + minutes;

                    Console.WriteLine("You've exercised " + runningTotal + " minutes");
                }

            }

            Console.WriteLine("Goodbye");

        }

    }

}