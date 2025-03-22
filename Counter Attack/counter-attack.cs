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
        static void Main(string[] args)
        {
            int amountOfMatches = Convert.ToInt32(Console.ReadLine());
            int[,] matchScores = new int[amountOfMatches, 2];

            for (int m = 0; m < amountOfMatches; m++)
            {
                string[] scores = Console.ReadLine().Split(' ');

                for (int i = 0; i < 2; i++)
                {
                    matchScores[m, i] = Convert.ToInt32(scores[i]);
                }
            }

            int[] valuesToTryForK = new int[amountOfMatches];

            for (int m = 0; m < amountOfMatches; m++)
            {
                // F > S
                if (matchScores[m, 0] >= matchScores[m, 1])
                {
                    valuesToTryForK[m] = 0;
                }
                else
                {
                    valuesToTryForK[m] = matchScores[m, 1] - matchScores[m, 0];
                }
            }

            var possibleValuesForKHashSet = new HashSet<int>(valuesToTryForK);

            int[] kValues = new int[possibleValuesForKHashSet.Count];
            possibleValuesForKHashSet.CopyTo(kValues);

            Array.Sort(kValues);

            int finalValueForK = 0;
            int greatestDifference = int.MinValue;

            int currentDifference;

            int skogWins;
            int fribergWins;

            for (int i = 0; i < kValues.Length; i++)
            {
                skogWins = 0;
                fribergWins = 0;

                for (int m = 0; m < amountOfMatches; m++)
                {
                    // Not tie
                    if (!(Math.Abs(matchScores[m, 0] - matchScores[m, 1]) <= kValues[i]))
                    {
                        // Friberg wins
                        if (matchScores[m, 0] > matchScores[m, 1])
                        {
                            fribergWins++;
                        }

                        // Skog wins
                        else
                        {
                            skogWins++;
                        }
                    }
                }

                currentDifference = fribergWins - skogWins;

                if (currentDifference > greatestDifference)
                {
                    finalValueForK = kValues[i];
                    greatestDifference = currentDifference;
                }
            }

            Console.WriteLine(finalValueForK);
            Console.Read();
        }
    }
}