using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
        public void FillData(string[] lines)
        {
            if (lines != null)
            {
                bool isDemandDistributions = false;
                NumOfNewspapers = int.Parse(lines[1]);
                NumOfRecords = int.Parse(lines[4]);
                PurchasePrice = decimal.Parse(lines[7]);
                SellingPrice = decimal.Parse(lines[13]);
                ScrapPrice = decimal.Parse(lines[10]);
                String[] DayTypedistribution = lines[16].Split(',');

                DayTypeDistributions.Add(new DayTypeDistribution { DayType = 0, Probability = decimal.Parse(DayTypedistribution[0]) });
                DayTypeDistributions.Add(new DayTypeDistribution { DayType = (Enums.DayType)1, Probability = decimal.Parse(DayTypedistribution[1]) });
                DayTypeDistributions.Add(new DayTypeDistribution { DayType = (Enums.DayType)2, Probability = decimal.Parse(DayTypedistribution[2]) });

                foreach (string ln in lines)
                {
                    if (ln == "DemandDistributions")
                    {
                        isDemandDistributions = true;
                        continue;
                    }
                    if (isDemandDistributions)
                    {
                        if (ln == "")
                        {
                            isDemandDistributions = false;
                            continue;
                        }
                        string[] strings = ln.Split(',');
                        List<DayTypeDistribution> dayTypeDistributions = new List<DayTypeDistribution>();
                        for (int i = 1; i < 4; i++)
                        {
                            dayTypeDistributions.Add(new DayTypeDistribution { DayType = (Enums.DayType)(i - 1), Probability = decimal.Parse(strings[i]) });
                        }
                        DemandDistributions.Add(new DemandDistribution { Demand = int.Parse(strings[0]), DayTypeDistributions = dayTypeDistributions });
                    }


                }
            }
        }
        private void SelcetDemand_And_Day(int dayNumber , Random random)
        {
            
            int rndDay = random.Next(1, 101);
            Enums.DayType NewsDayType = 0;
            int index = 0,Demand = 0;
            for (int i = 0; i < DayTypeDistributions.Count; i++)
            {
                if (rndDay >= DayTypeDistributions[i].MinRange && rndDay <= DayTypeDistributions[i].MaxRange)
                {
                    NewsDayType = DayTypeDistributions[i].DayType;
                    index = i;
                    break;
                }
            }
            int rnd = random.Next(1, 101);
            for (int i = 0; i < DemandDistributions.Count; i++)
            {
                if (rnd >= DemandDistributions[i].DayTypeDistributions[index].MinRange && rnd <= DemandDistributions[i].DayTypeDistributions[index].MaxRange)
                {
                    NewsDayType = DemandDistributions[i].DayTypeDistributions[index].DayType;
                    Demand = DemandDistributions[i].Demand;
                    
                    break;
                }
            }
            SimulationTable.Add(new SimulationCase
            {
                DayNo = dayNumber,
                RandomDemand = rnd,
                RandomNewsDayType = rndDay,
                Demand = Demand,
                NewsDayType = NewsDayType
            });


        }
        public void Daily_Expenses(int demand, int Day_no)
        {
            SimulationTable[Day_no].DailyCost = (decimal)NumOfNewspapers * PurchasePrice;
            decimal Dcost, Sprofit, Lprofit, scrap;
            Dcost = SimulationTable[Day_no].DailyCost;
            int loss = 0, excess = 0;
            UnitProfit = SellingPrice - PurchasePrice;
            if (demand > NumOfNewspapers)
            {
                loss = demand - NumOfNewspapers;
                SimulationTable[Day_no].SalesProfit = (decimal)NumOfNewspapers * SellingPrice;
                SimulationTable[Day_no].LostProfit = (decimal)loss * UnitProfit;
                SimulationTable[Day_no].ScrapProfit = 0;
            }
            else if (demand < NumOfNewspapers)
            {
                excess = NumOfNewspapers - demand;
                SimulationTable[Day_no].SalesProfit = (decimal)demand * SellingPrice;
                SimulationTable[Day_no].LostProfit = 0;
                SimulationTable[Day_no].ScrapProfit = (decimal)excess * ScrapPrice;


            }
            else if (demand == NumOfNewspapers)
            {
                SimulationTable[Day_no].SalesProfit = (decimal)SellingPrice * NumOfNewspapers;
                SimulationTable[Day_no].ScrapProfit = 0;
                SimulationTable[Day_no].LostProfit = 0;
            }
            Sprofit = SimulationTable[Day_no].SalesProfit;
            Lprofit = SimulationTable[Day_no].LostProfit;
            scrap = SimulationTable[Day_no].ScrapProfit;
            SimulationTable[Day_no].DailyNetProfit = Sprofit - Dcost - Lprofit + scrap;
        }
        public void Performance_Measures()
        {
            int ExcessDays = 0, ScrapDays = 0;
           
            for (int t = 0; t < NumOfRecords; t++)
            {
                PerformanceMeasures.TotalSalesProfit += SimulationTable[t].SalesProfit;
                PerformanceMeasures.TotalCost += SimulationTable[t].DailyCost;
                if (SimulationTable[t].LostProfit > 0)
                { ExcessDays++; }
                PerformanceMeasures.TotalLostProfit += SimulationTable[t].LostProfit;
                if (SimulationTable[t].ScrapProfit > 0)
                { ScrapDays++; }
                PerformanceMeasures.TotalScrapProfit += SimulationTable[t].ScrapProfit;
                PerformanceMeasures.TotalNetProfit += SimulationTable[t].DailyNetProfit;


            }
            PerformanceMeasures.DaysWithMoreDemand = ExcessDays;
            PerformanceMeasures.DaysWithUnsoldPapers = ScrapDays;
        }
        public void MainLoop()
        {
            DayTypeDistribution.Distribution(DayTypeDistributions);
            DemandDistribution.CalculateDemandDistribution(DemandDistributions);
            Random random;
            random = new Random();
            for (int i = 0; i < NumOfRecords; i++)
            {
               
                SelcetDemand_And_Day(i+1,random);
                Daily_Expenses(SimulationTable[i].Demand, i);

            }
            Performance_Measures();
        }
    }

}

/*
  private void CalculateSimulationTable()
        {
     //  UnitProfit = SellingPrice - PurchasePrice;
            decimal profitPerNewspaper;
            for (int i = 0; i < SimulationTable.Count; i++)
            {
                profitPerNewspaper = SellingPrice - PurchasePrice;
                SimulationTable[i].SalesProfit = SellingPrice * SimulationTable[i].Demand;
                SimulationTable[i].DailyCost = NumOfNewspapers * PurchasePrice;
                SimulationTable[i].LostProfit = Math.Max(0, SimulationTable[i].Demand - NumOfNewspapers) * profitPerNewspaper;
                SimulationTable[i].ScrapProfit = Math.Max(0, NumOfNewspapers - SimulationTable[i].Demand) * ScrapPrice;
                SimulationTable[i].DailyNetProfit = SimulationTable[i].SalesProfit
                    - SimulationTable[i].DailyCost
                    - SimulationTable[i].LostProfit
                    + SimulationTable[i].ScrapProfit;
                PerformanceMeasures.TotalLostProfit += SimulationTable[i].LostProfit;
                PerformanceMeasures.TotalScrapProfit += SimulationTable[i].ScrapProfit;
                PerformanceMeasures.TotalNetProfit += SimulationTable[i].DailyNetProfit;
                PerformanceMeasures.TotalSalesProfit += SimulationTable[i].SalesProfit;
                PerformanceMeasures.TotalCost += SimulationTable[i].DailyCost;
                if (SimulationTable[i].ScrapProfit != 0)
                    PerformanceMeasures.DaysWithUnsoldPapers++;
                if (SimulationTable[i].LostProfit == 0)
                    PerformanceMeasures.DaysWithMoreDemand++;
            }
        }
 */

