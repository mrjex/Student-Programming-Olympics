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
            char[] consonants = new char[20] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
            uint sameConsonantCounter = 1;

            char lastChar;

            string input = Console.ReadLine();
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool isConsonant = false;

                if (i == 0)
                {
                    lastChar = input[0];
                }
                else
                {
                    lastChar = input[i - 1];
                }

                for (int c = 0; c < consonants.Length; c++)
                {
                    // Current char is a consonant
                    if (input[i] == consonants[c])
                    {
                        if (input[i] == lastChar && i > 0)
                        {
                            sameConsonantCounter++;
                        }
                        else
                        {
                            sameConsonantCounter = 1;
                        }

                        isConsonant = true;
                    }
                }

                if (!isConsonant)
                {
                    sameConsonantCounter = 1;
                }

                if (sameConsonantCounter <= 2)
                {
                    output += input[i];
                }
            }

            Console.WriteLine(output);
            Console.Read();
        }
    }
}