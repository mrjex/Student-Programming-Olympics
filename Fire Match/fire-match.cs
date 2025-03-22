using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattisProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = Convert.ToByte(Console.ReadLine()); // Amount of sticks
            byte w = Convert.ToByte(Console.ReadLine()); // Length
            byte d = Convert.ToByte(Console.ReadLine()); // Max sticks

            byte c = 0;
            bool shortcut = false;

            string[] output = new string[n];

            while (c != n)
            {
                if (shortcut)
                {
                    Console.ReadLine();

                    c++;
                    continue;
                }

                if (Convert.ToByte(Console.ReadLine()) <= w && d > 0)
                {
                    output[c] = "Asken";
                    d--;
                }
                else
                {
                    output[c] = "Papperskorgen";
                }

                if (d == 0)
                {
                    for (byte b = (byte)(c + 1); b < output.Length; b++)
                    {
                        output[b] = "Papperskorgen";
                    }

                    shortcut = true;
                }

                c++;
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }

            Console.Read();
        }
    }
}