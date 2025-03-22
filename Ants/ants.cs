using System;

namespace ProblemSolving2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint totalLegs = Convert.ToUInt32(Console.ReadLine());
            string output = " ERROR ";

            for (uint x = 0; x < totalLegs; x++)
            {
                for (uint y = 0; y < totalLegs; y++)
                {
                    if ((x * 6) + (y * 8) == totalLegs && x + y == 42)
                    {
                        output = x.ToString();
                        break​
                    }
                }

                if (output == x.ToString())
                {
                    break​
                }
            }

            Console.WriteLine(output);
            Console.Read();
        }
    }
}