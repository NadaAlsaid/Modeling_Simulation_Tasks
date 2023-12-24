using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DemandDistribution
    {
        public DemandDistribution()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
        }
        public int Demand { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public static void CalculateDemandDistribution(List<DemandDistribution> Ddistributions)
        {
            decimal totalpropcumulative1 = 0, totalpropcumulative2 = 0, totalpropcumulative3 = 0;
            int minRange1 = 1, minRange2 = 1, minRange3 = 1;
            foreach (var distribution in Ddistributions)
            {
                
                totalpropcumulative1 += distribution.DayTypeDistributions[0].Probability;
                distribution.DayTypeDistributions[0].CummProbability = totalpropcumulative1;
                distribution.DayTypeDistributions[0].MinRange = minRange1;
                distribution.DayTypeDistributions[0].MaxRange = (int)(totalpropcumulative1 * 100);
                minRange1 = distribution.DayTypeDistributions[0].MaxRange+1; 
                totalpropcumulative2 += distribution.DayTypeDistributions[1].Probability;
                distribution.DayTypeDistributions[1].CummProbability = totalpropcumulative2;
                distribution.DayTypeDistributions[1].MinRange = minRange2;
                distribution.DayTypeDistributions[1].MaxRange = (int)(totalpropcumulative2 * 100);
                minRange2 = distribution.DayTypeDistributions[0].MaxRange + 1;
                totalpropcumulative3 += distribution.DayTypeDistributions[2].Probability;
                distribution.DayTypeDistributions[2].CummProbability = totalpropcumulative3;
                distribution.DayTypeDistributions[2].MinRange = minRange3;
                distribution.DayTypeDistributions[2].MaxRange = (int)(totalpropcumulative3 * 100);
                minRange3 = distribution.DayTypeDistributions[2].MaxRange + 1;

            }
        }

    }
}

