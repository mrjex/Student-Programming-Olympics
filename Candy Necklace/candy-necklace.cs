using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemSolving2
{
    class Program
    {
        static int currentBs = 0;
        static int maxBs = 0;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sequenceLength = input.Length / 2;

            int start = 0;
            int end = sequenceLength - 1;

            for (int i = 0; i < sequenceLength; i++)
            {
                if (input[i] == 'B')
                {
                    currentBs++;
                }
            }

            UpdateMaxBs();

            for (int x = 0; x < input.Length - 1; x++)
            {
                if (input[start] == 'B')
                {
                    currentBs--;
                }

                start++;
                end++;

                if (end == input.Length)
                {
                    end = 0;
                }

                if (input[end] == 'B')
                {
                    currentBs++;
                }

                UpdateMaxBs();
            }

            Console.WriteLine(maxBs);
            Console.Read();
        }

        static void UpdateMaxBs()
        {
            if (currentBs > maxBs)
            {
                maxBs = currentBs;
            }
        }
    }
}