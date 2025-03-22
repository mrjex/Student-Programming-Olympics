using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringFirstRowInputs = Console.ReadLine().Split(' ');
            string[] stringSecondRowInputs = Console.ReadLine().Split(' ');

            int maximalAmount = Convert.ToInt32(stringFirstRowInputs[0]);
            int pairs = Convert.ToInt32(stringFirstRowInputs[1]);
            int currentAmount = 0;
            int acceptedPairs = 0;

            // Go through each pair
            for (int i = 0; i < pairs; i++)
            {
                // If the current couple fits in the salon
                if (currentAmount + Convert.ToInt32(stringSecondRowInputs[i]) <= maximalAmount)
                {
                    currentAmount += Convert.ToInt32(stringSecondRowInputs[i]);
                    acceptedPairs++;
                }
            }

            Console.WriteLine(pairs - acceptedPairs);
            Console.Read();
        }
    }
}