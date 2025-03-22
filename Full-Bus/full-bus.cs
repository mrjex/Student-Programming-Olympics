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

            int stations = Convert.ToInt32(firstRowInputs[0]);
            int busMaximum = Convert.ToInt32(firstRowInputs[1]);

            int[][] peoplesAtStation = new int[stations - 1][];
            int[][] stationsTimers = new int[stations - 1][];

            // Read inputs
            for (int i = 0; i < stations - 1; i++)
            {
                string[] stringPeopleAtStation = Console.ReadLine().Split(' ');

                peoplesAtStation[i] = new int[stringPeopleAtStation.Length];
                stationsTimers[i] = new int[stringPeopleAtStation.Length - 1];

                for (int o = 0; o < stringPeopleAtStation.Length; o++)
                {
                    peoplesAtStation[i][o] = Convert.ToInt32(stringPeopleAtStation[o]);

                    // Skip the first field
                    if (o > 0)
                    {
                        stationsTimers[i][o - 1] = -1;
                    }
                }
            }

            int currentBusAmount = 0;
            int waitingPeople = 0;

            // Go through every station where people are jumping on the bus
            for (int s = 0; s < stations - 1; s++)
            {
                // Go through the queue at the current station
                for (int p = 0; p < peoplesAtStation[s].Length - 1; p++)
                {
                    for (int sc = 0; sc < stations - 1; sc++)
                    {
                        for (int pc = 0; pc < peoplesAtStation[sc].Length - 1; pc++)
                        {
                            // Check if people are leaving the bus, which increases the space for others
                            if (stationsTimers[sc][pc] == s + 1)
                            {
                                stationsTimers[sc][pc] = -2;
                                currentBusAmount--;
                            }
                        }
                    }

                    // Let the current person in the queue jump on the bus
                    if (currentBusAmount < busMaximum)
                    {
                        currentBusAmount++;
                        stationsTimers[s][p] = peoplesAtStation[s][p + 1];
                    }
                    else
                    {
                        waitingPeople++;
                    }
                }
            }

            Console.WriteLine(waitingPeople);
            Console.Read();
        }
    }
}