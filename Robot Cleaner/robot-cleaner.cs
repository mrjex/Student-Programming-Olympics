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
            string[] inputs = Console.ReadLine().Split(' ');
            string moves = Console.ReadLine();

            int r = Convert.ToInt32(inputs[0]);
            int c = Convert.ToInt32(inputs[1]);

            char[,] local = new char[r, c];
            int[] cP = new int[2];

            int output = 1;

            for (int a = 0; a < r; a++)
            {
                string rowInput = Console.ReadLine();

                for (int b = 0; b < c; b++)
                {
                    local[a, b] = rowInput[b];

                    if (local[a,b] == 'O')
                    {
                        cP[0] = a;
                        cP[1] = b;
                    }
                }
            }

            for (int m = 0; m < moves.Length; m++)
            {
                if (moves[m] == '^')
                {
                    while (local[cP[0] - 1, cP[1]] != '#')
                    {
                        cP[0]--;

                        if (local[cP[0], cP[1]] == '.')
                        {
                            output++;
                            local[cP[0], cP[1]] = 'O';
                        }

                        // CheckIfIncreaseOutput();
                    }
                }
                else if (moves[m] == '>')
                {
                    while (local[cP[0],cP[1] + 1] != '#')
                    {
                        cP[1]++;

                        if (local[cP[0], cP[1]] == '.')
                        {
                            output++;
                            local[cP[0], cP[1]] = 'O';
                        }

                        // CheckIfIncreaseOutput();
                    }
                }
                else if (moves[m] == 'v')
                {
                    while (local[cP[0] + 1, cP[1]] != '#')
                    {
                        cP[0]++;

                        if (local[cP[0], cP[1]] == '.')
                        {
                            output++;
                            local[cP[0], cP[1]] = 'O';
                        }

                        // CheckIfIncreaseOutput();
                    }
                }
                else if (moves[m] == '<')
                {
                    while (local[cP[0],cP[1] - 1] != '#')
                    {
                        cP[1]--;

                        if (local[cP[0], cP[1]] == '.')
                        {
                            output++;
                            local[cP[0], cP[1]] = 'O';
                        }

                        // CheckIfIncreaseOutput();
                    }
                }
            }

            /*
            void CheckIfIncreaseOutput()
            {
                if (local[cP[0], cP[1]] == '.')
                {
                    output++;
                    local[cP[0], cP[1]] = 'O';
                }
            }
            */

            Console.WriteLine(output);
            Console.Read();
        }
    }
}