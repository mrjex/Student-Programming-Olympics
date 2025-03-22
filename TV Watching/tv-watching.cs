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
            string[] firstRowInputs = Console.ReadLine().Split(' ');

            int amountOfParties = Convert.ToInt32(firstRowInputs[0]);
            int amountOfSeries = Convert.ToInt32(firstRowInputs[1]);

            string[] stringSeries = Console.ReadLine().Split(' ');

            int[][] partiesInformations = new int[amountOfParties][];
            int[] pD = new int[amountOfParties];

            int cD = 0;
            int hW = 0;

            bool notEnoughTime = false;
            List<int> seriesLeft = new List<int>();

            for (int i = 0; i < amountOfSeries; i++)
            {
                seriesLeft.Add(Convert.ToInt32(stringSeries[i]));
            }

            for (int i = 0; i < amountOfParties; i++)
            {
                string[] partyInfo = Console.ReadLine().Split(' ');

                pD[i] = Convert.ToInt32(partyInfo[0]);
                partiesInformations[i] = new int[partyInfo.Length - 2];

                for (int o = 2; o < partyInfo.Length; o++)
                {
                    partiesInformations[i][o - 2] = Convert.ToInt32(partyInfo[o]);
                }
            }

            int cS = 0;

            for (int a = 0; a < amountOfParties; a++)
            {
                if (cD > 0)
                {
                    hW += (pD[a] - cD - 1) * 10;
                    cD = pD[a];
                }
                else
                {
                    hW += (pD[a] - cD) * 10;
                    cD = pD[a];
                }

                for (int o = 0; o < partiesInformations[a].Length; o++)
                {
                    cS = seriesLeft[partiesInformations[a][o] - 1];

                    if (cS != 0)
                    {
                        if (hW >= cS)
                        {
                            hW -= cS;
                            seriesLeft[partiesInformations[a][o] - 1] = 0;
                        }
                        else
                        {
                            notEnoughTime = true;
                            break;
                        }
                    }
                }

                if (notEnoughTime)
                {
                    break;
                }
            }

            if (notEnoughTime)
            {
                Console.WriteLine("Nej");
            }
            else
            {
                Console.WriteLine("Ja");
            }

            Console.Read();
        }
    }
}