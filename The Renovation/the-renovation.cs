using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.threading;
using System.Threading.Tasks;

namespace ProblemSolving2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fRI = Console.ReadLine().Split(' ');

            sbyte[] spikesNeeded = ToByteArray(Console.ReadLine().Split(' '));
            sbyte[] spikesObtained = ToByteArray(Console.ReadLine().Split(' '));

            sbyte amountOfSpikesNeeded = Convert.ToSByte(fRI[0]);
            sbyte amountOfSpikesObtained = Convert.ToSByte(fRI[1]);

            sbyte optimalSpikeToBuy = 0;
            sbyte minDifference;

            for (sbyte o = 0; o < amountOfSpikesObtained; o++)
            {
                minDifference = sbyte.MaxValue;

                for (sbyte s = 0; s < amountOfSpikesNeeded; s++)
                {
                    if (spikesNeeded[s] == 0)
                    {
                        continue;
                    }

                    sbyte spikeDifference = (sbyte)(spikesObtained[o] - spikesNeeded[s]);

                    if (spikeDifference < 0)
                    {
                        continue;
                    }

                    if (spikeDifference < minDifference)
                    {
                        optimalSpikeToBuy = s;

                        if (spikeDifference == 0)
                        {
                            break​
                        }

                        minDifference = spikeDifference;
                    }
                }

                spikesNeeded[optimalSpikeToBuy] = 0;
            }

            List<int> spikesToPurchase = new List<int>();

            for (int i = 0; i < amountOfSpikesNeeded; i++)
            {
                if (spikesNeeded[i] != 0)
                {
                    spikesToPurchase.Add(spikesNeeded[i]);
                }
            }

            spikesToPurchase.Sort();

            Console.WriteLine(spikesToPurchase.Count);
            Console.WriteLine(String.Join(" ", spikesToPurchase));

            Console.Read();
        }

        static sbyte[] ToByteArray(string[] stringArr)
        {
            sbyte[] outArr = new sbyte[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                outArr[i] = Convert.ToSByte(stringArr[i]);
            }

            return outArr;
        }
    }
}