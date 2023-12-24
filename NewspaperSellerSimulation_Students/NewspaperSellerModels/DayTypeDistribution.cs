using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public static void Distribution(List<DayTypeDistribution> distribution)
        {
            int min = 0, max = 0;
            decimal cummlative = 0m;
            for (int i = 0; i < distribution.Count; i++)
            {
                if (i == 0)
                {
                    cummlative = distribution[0].Probability;
                    min = 1;

                }
                else
                {
                    cummlative = distribution[i].Probability + distribution[i - 1].CummProbability;
                    min = distribution[i - 1].MaxRange + 1;

                }
                distribution[i].CummProbability = cummlative;
                max = (int)(distribution[i].CummProbability * 100m);
                if (max >= 100) { max = 100; }
                distribution[i].MinRange = min;
                distribution[i].MaxRange = max;
            }
        }
    }
}
