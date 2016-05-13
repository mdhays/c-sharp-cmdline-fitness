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
            
                // Prompt the user for minutes exercised.
                 Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();
                

                
                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {                   

                    int minutes = int.Parse(entry);
                
                     // Add minutes exercised to total
                    runningTotal = runningTotal + minutes;

        
                    // Display total minutes exercised on screen        
                    Console.WriteLine("You've exercised " + entry + " minutes");
                }
                    // Repeat until user quits.
            }
                     Console.WriteLine("Goodbye");
                
            
        }
    }
}