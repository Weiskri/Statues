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

            List<int> statueSizesNeeded = new List<int>();

            Console.WriteLine("Hello, Ratiorg! To determine how many statues you need to complete your collection, I will ask you for your current statue sizes.");
            Console.WriteLine();
            Console.WriteLine("To begin, please enter the size of one of your statues.");
            userInput = int.Parse(Console.ReadLine());
            inputs.Add(userInput);

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

            inputs.Sort();

            Console.WriteLine("The sizes you entered are: ");
            inputs.ForEach(Console.WriteLine);

            int firstInput = inputs.First();
            int lastInput = inputs.Last();

            IEnumerable<int> sequence = Enumerable.Range(firstInput, (inputs.Count - 1));

            Console.WriteLine(sequence);

            //for (int i=0; i < inputs.Count; i++)
            //{
            //    if (((inputs[i+1] - inputs[i]) > 1) == true) {
            //        statueSizesNeeded.Add((inputs[i] + 1));
            //    }

            //}
            Console.ReadLine();
            
            


        }
    }
}
