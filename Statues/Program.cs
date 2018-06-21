using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statues
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;

            List<int> inputs = new List<int>();

            Console.WriteLine("Hello, Ratiorg! Let's determine how many statues you need to complete your collection.");
            Console.WriteLine();
            Console.WriteLine("To begin, please enter the size of one of your statues.");
            userInput = int.Parse(Console.ReadLine());
            inputs.Add(userInput);

            // adds user inputs to the list until the user presses 0
            while (userInput != 0)
            {
                Console.WriteLine("Please enter the size of your next statue, or press 0 to determine how many statues you need to complete your collection.");
                userInput = int.Parse(Console.ReadLine());

                if (userInput > 0)
                {
                    inputs.Add(userInput);
                }
                  
                else { }


            }

            // sorts user inputs and then gets the first and last items to determine the range
            inputs.Sort();

            int firstInput = inputs.First();
            int lastInput = inputs.Last();

            List<int> sequencedNums = new List<int>(firstInput);
            
            for (int i = firstInput; i<=lastInput; i++)
            {
                sequencedNums.Add(firstInput++);
            }

            // compares the two lists, putting elements that are in list 2 (sequencedNums) but not in list 1 into a separate list
            var diff = sequencedNums.Except(inputs).ToList();

            Console.WriteLine("Ratiorg needs : " + diff.Count + " statues to complete the collection.");

            Console.WriteLine("He needs statues with sizes:");
            diff.ForEach(Console.WriteLine);

            Console.ReadLine();
            
            


        }
    }
}
