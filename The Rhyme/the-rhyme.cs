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
            string[] inputs = Console.ReadLine().Split(' ');
            byte[] numbers = new byte[2] { Convert.ToByte(inputs[0]), Convert.ToByte(inputs[1]) };

            List<byte> childs = new List<byte>();

            for (byte x = 1; x <= numbers[1]; x++)
            {
                childs.Add(x);
            }

            byte c = 1;
            byte i = 0;
            bool useShortCut = false;

            while (childs.Count != 1)
            {
                if (c == numbers[0] || useShortCut)
                {
                    c = 0;
                    childs.RemoveAt(i);

                    i--;
                    useShortCut = false;
                }

                if (i == childs.Count - 1)
                {
                    i = 0;
                }
                else
                {
                    i++;
                }

                c++;

                if (numbers[0] - childs.Count == c)
                {
                    useShortCut = true;
                }
            }

            Console.WriteLine(childs[0]);
            Console.Read();
        }
    }
}