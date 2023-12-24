using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public int  ending_Sum = 0, shortage_Sum = 0;

        public void Reading(string[] lines)
        {
          
            OrderUpTo = int.Parse(lines[1]);
            ReviewPeriod = int.Parse(lines[4]);
            StartInventoryQuantity = int.Parse(lines[7]);
            StartLeadDays = int.Parse(lines[10]);
            StartOrderQuantity = int.Parse(lines[13]);
            NumberOfDays = int.Parse(lines[16]);

            int start = ReadDistribution(lines, DemandDistribution, 19);
            start = ReadDistribution(lines, LeadDaysDistribution , start+2);
            
        }

        private int ReadDistribution(string[] sr, List<Distribution> distributionList, int start)
        {
            int i = start;
            for (i = start; i< sr.Length && sr[i] != "" ; i++)
            {
                string[] values = sr[i].Split(',');

                Distribution distribution = new Distribution();
                distribution.Value = int.Parse(values[0]);
                distribution.Probability = decimal.Parse(values[1]);

                distributionList.Add(distribution);
            }

            CalculateCumulativeProbabilities(distributionList);
            return  i;
        }

        private void CalculateCumulativeProbabilities(List<Distribution> distributionList)
        {
            decimal cumulativeProbability = 0;

            foreach (var distribution in distributionList)
            {
                cumulativeProbability += distribution.Probability;
                distribution.CummProbability = cumulativeProbability;
                distribution.MinRange = (int)(100*(cumulativeProbability - distribution.Probability));
                distribution.MaxRange = (int)(cumulativeProbability *100);
            }
        }

        private int GenerateRandomNumber(int minNum, int maxNum)
        {
            Random random = new Random();
            int randomNum = random.Next(minNum, maxNum);
            Thread.Sleep(10);
            return randomNum;
        }

        private int GetRange(int randomNum, List<Distribution> DistributionList)
        {
            for (int i = 0; i < DistributionList.Count(); i++)
                if (randomNum <= DistributionList[i].MaxRange && randomNum >= DistributionList[i].MinRange)
                    return DistributionList[i].Value;

            return 0;
        }

        public void FillTable()
        {
            SimulationCase simulationCase;
            int cycle = 1, dayWithinCycle, orderQuantity = StartOrderQuantity;

            for (int i = 0; i < NumberOfDays; i++)
            {
                simulationCase = new SimulationCase();
                simulationCase.Day = i + 1;
                simulationCase.DayWithinCycle = (i) % (ReviewPeriod) +1;
                simulationCase.Cycle = cycle;

                if (i == 0)
                {
                    simulationCase.BeginningInventory = StartInventoryQuantity;
                    simulationCase.DaysUntillOrderArrives = StartLeadDays - 1;
                }
                else if (i == 1)
                {
                    simulationCase.BeginningInventory = SimulationTable[i - 1].EndingInventory;
                }
                else
                {
                    if (SimulationTable[i - 2].DaysUntillOrderArrives == 1)
                        simulationCase.BeginningInventory = orderQuantity + SimulationTable[i - 1].EndingInventory;
                    else
                        simulationCase.BeginningInventory = SimulationTable[i - 1].EndingInventory;

                }

                simulationCase.RandomDemand = GenerateRandomNumber(1, 100);
                simulationCase.Demand = GetRange(simulationCase.RandomDemand, DemandDistribution);

                if (simulationCase.Demand >= simulationCase.BeginningInventory)
                {
                    simulationCase.EndingInventory = 0;

                    if (i == 0)
                    {
                        simulationCase.ShortageQuantity = simulationCase.Demand - simulationCase.BeginningInventory;
                    }
                    else
                    {
                        if (SimulationTable[i - 1].ShortageQuantity != 0)
                            simulationCase.ShortageQuantity = SimulationTable[i - 1].ShortageQuantity + simulationCase.Demand - simulationCase.BeginningInventory;

                        else
                            simulationCase.ShortageQuantity = simulationCase.Demand - simulationCase.BeginningInventory;

                    }
                }
                else
                {
                    if (i == 0)
                    {
                        simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand;

                    }
                    else
                    {
                        if (SimulationTable[i - 1].ShortageQuantity != 0)
                        {
                            if (simulationCase.BeginningInventory - simulationCase.Demand - SimulationTable[i - 1].ShortageQuantity >= 0)
                                simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand - SimulationTable[i - 1].ShortageQuantity;
                            else
                            {
                                simulationCase.EndingInventory = 0;
                                simulationCase.ShortageQuantity = -(simulationCase.BeginningInventory - simulationCase.Demand - SimulationTable[i - 1].ShortageQuantity);

                            }
                        }
                        else
                            simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand;

                    }
                }

                if (i != 0)
                {
                    if (SimulationTable[i - 1].DaysUntillOrderArrives != 0)
                        simulationCase.DaysUntillOrderArrives = SimulationTable[i - 1].DaysUntillOrderArrives - 1;
                }

                if (simulationCase.DayWithinCycle == ReviewPeriod)
                {
                    cycle++;

                    simulationCase.OrderQuantity = OrderUpTo - simulationCase.EndingInventory + simulationCase.ShortageQuantity;
                    orderQuantity = simulationCase.OrderQuantity;
                    simulationCase.RandomLeadDays = GenerateRandomNumber(1, 100);
                    simulationCase.LeadDays = GetRange(simulationCase.RandomLeadDays, LeadDaysDistribution);
                    simulationCase.DaysUntillOrderArrives = simulationCase.LeadDays;

                }

                ending_Sum += simulationCase.EndingInventory;
                shortage_Sum += simulationCase.ShortageQuantity;
                SimulationTable.Add(simulationCase);

            }

            PerformanceMeasures.EndingInventoryAverage = (decimal)((decimal)ending_Sum / (decimal)NumberOfDays);
            PerformanceMeasures.ShortageQuantityAverage = (decimal)((decimal)shortage_Sum / (decimal)NumberOfDays);
        }

    }
}
