using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }
        public decimal NumberOfCustomerInQueue { get; set; }
        public decimal sumWaitingTime { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public void FillData(string[] lines)
        {
            int count = 1;
            if (lines != null)
            {
                bool isInterarrivalDistribution = false;

                bool isServiceDistribution_Server = false;
                count = 1;
                Server server = null;
                NumberOfServers = int.Parse(lines[1]);
                StoppingNumber = int.Parse(lines[4]);
                switch (lines[7])
                {
                    case "1":
                        StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
                        break;
                    case "2":
                        StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
                        break;
                    default:
                        break;
                }
                switch (lines[10])
                {
                    case "1":
                        SelectionMethod = Enums.SelectionMethod.HighestPriority;
                        break;
                    case "2":
                        SelectionMethod = Enums.SelectionMethod.Random;
                        break;
                    case "3":
                        SelectionMethod = Enums.SelectionMethod.LeastUtilization;
                        break;
                    default:
                        break;
                }

                foreach (string ln in lines)
                {
                    if (ln == "InterarrivalDistribution")
                    {
                        isInterarrivalDistribution = true;
                        continue;
                    }
                    if (isInterarrivalDistribution)
                    {
                        if (ln == "")
                        {
                            isInterarrivalDistribution = false;
                            continue;
                        }
                        string[] strings = ln.Split(',');
                        InterarrivalDistribution.Add(new TimeDistribution(int.Parse(strings[0]), decimal.Parse(strings[1])));
                    }

                    if (ln.Equals("ServiceDistribution_Server" + count.ToString()))
                    {

                        isServiceDistribution_Server = true;
                        server = new Server();
                        server.ID = count;
                        continue;
                    }
                    if (isServiceDistribution_Server)
                    {
                        if (ln == "")
                        {
                            isServiceDistribution_Server = false;
                            Servers.Add(server);
                            count++;
                            continue;
                        }
                        string[] strings = ln.Split(',');
                        server.TimeDistribution.Add(new TimeDistribution(
                        int.Parse(strings[0]), decimal.Parse(strings[1])));
                    }
                }
                Servers.Add(server);
            }
        }

        private void StoppingCriteriaCondition(int Customer_No, Random rnd)
        {
            int random;
            int inter;
            int arriv = 0;
            int old_arriv = 0;
            if (Customer_No == 0)
            {

                inter = 0;
                arriv = 0;
                SimulationTable.Add(new SimulationCase { RandomInterArrival = 1, ArrivalTime = arriv, InterArrival = inter, CustomerNumber = Customer_No });
            }
            else
            {
                random = rnd.Next(1, 101);
                for (int i = 0; i < InterarrivalDistribution.Count; i++)
                {
                    if (random >= InterarrivalDistribution[i].MinRange && random <= InterarrivalDistribution[i].MaxRange)
                    {
                        //inter = i + 1;
                        inter = InterarrivalDistribution[i].Time;
                        arriv = inter + SimulationTable[Customer_No - 1].ArrivalTime;
                        SimulationTable.Add(new SimulationCase { RandomInterArrival = random, ArrivalTime = arriv, InterArrival = inter, CustomerNumber = Customer_No });
                        break;
                    }
                }
            }
        }

        private void CalculateServiceTime(int tableId, int indexServerId, Random rnd)
        {

            List<TimeDistribution> timeDistributions = new List<TimeDistribution>();
            timeDistributions = Servers[indexServerId].TimeDistribution;
            int random;
            random = rnd.Next(1, 101);
            for (int i = 0; i < timeDistributions.Count; i++)
            {
                if (random >= timeDistributions[i].MinRange && random <= timeDistributions[i].MaxRange)
                {
                    SimulationTable[tableId].RandomService = random;
                    SimulationTable[tableId].ServiceTime = timeDistributions[i].Time;
                    break;
                }
            }

        }

        public void SimulationCaseCalculate()
        {
            /*
            * Calculate arrival & inter-arival
            * */

            int Customer_No = 0;
            Random rnd = new Random();
            Random random = new Random();

            TimeDistribution.Distribution(InterarrivalDistribution);

            for (int s = 0; s < Servers.Count; s++)
            {
                TimeDistribution.Distribution(Servers[s].TimeDistribution);
            }

            if ((int)(StoppingCriteria) == 1)
            {
                while (Customer_No < StoppingNumber)
                {
                    StoppingCriteriaCondition(Customer_No, rnd);
                    Customer_No++;
                }
                for (int Customer = 0; Customer < Customer_No; Customer++)
                {
                    if (SelectionMethod == Enums.SelectionMethod.HighestPriority)
                    {
                        HighPriority(Customer, rnd);
                    }
                    else if (SelectionMethod == Enums.SelectionMethod.Random)
                    {
                        RandomServer(Customer, random, rnd);
                    }
                    else if (SelectionMethod == Enums.SelectionMethod.LeastUtilization)
                    {
                        LeastUtilizationServer(Customer, rnd);
                    }

                }
            }
            else
            {

                do
                {

                    StoppingCriteriaCondition(Customer_No, rnd);

                    if (SelectionMethod == Enums.SelectionMethod.HighestPriority)
                    {
                            HighPriority(Customer_No, rnd);
                    }
                    else if (SelectionMethod == Enums.SelectionMethod.Random)
                    {
                        RandomServer(Customer_No, random, rnd);
                    }
                    else if (SelectionMethod == Enums.SelectionMethod.LeastUtilization)
                    {
                        LeastUtilizationServer(Customer_No, rnd);
                    }
                    Customer_No++;
                    /*end of server calculations*/

                } while (SimulationTable[Customer_No-1].EndTime <= StoppingNumber);

            }


        }

        private void HighPriority(int tableId,Random random)
        {
            int indexServerId=0 , minFinishTime = Servers[0].FinishTime;
            if (tableId == 0 ) {
                SimulationTable[tableId].AssignedServer = Servers[0];
                calculateTimesServers(tableId, 0 , random);
                Servers[0].FinishTime = SimulationTable[tableId].EndTime;

                return; 
            }
            for (int k = 0; k < Servers.Count; k++)
            {

                if (Servers[k].FinishTime < minFinishTime && minFinishTime > SimulationTable[tableId].ArrivalTime )
                {
                   indexServerId = k ;
                   minFinishTime = Servers[k].FinishTime; 
                }
            }

            SimulationTable[tableId].AssignedServer = Servers[indexServerId];
            calculateTimesServers(tableId, indexServerId, random);
            Servers[indexServerId].FinishTime = SimulationTable[tableId].EndTime;


        }

        private void RandomServer(int tableId, Random random, Random random2)
        {

            int rnd = random.Next(0,Servers.Count);
            calculateTimesServers(tableId, rnd, random2);
            SimulationTable[tableId].AssignedServer = Servers[rnd];
            Servers[rnd].FinishTime = SimulationTable[tableId].EndTime;
        }

        private void LeastUtilizationServer(int tableId, Random random)
        {
            int totalWorkingTime = Servers[0].TotalWorkingTime;
            int indexServerId = 0;
            for (int k = 1; k < Servers.Count; k++)
            {
                if (totalWorkingTime < Servers[k].TotalWorkingTime) {
                    indexServerId = k; 
                }
            }
            calculateTimesServers(tableId,indexServerId,random);
            SimulationTable[tableId].AssignedServer = Servers[indexServerId];
            Servers[indexServerId].FinishTime = SimulationTable[tableId].EndTime;
        }

        private void calculateTimesServers(int tableId,int indexServerId, Random rnd)
        {


            CalculateServiceTime(tableId, indexServerId, rnd);
            if (tableId == 0)
            {
                SimulationTable[tableId].StartTime = 0;
                SimulationTable[tableId].EndTime = SimulationTable[tableId].ServiceTime;

            }
            else
            {
                if (Servers[indexServerId].FinishTime > SimulationTable[tableId].ArrivalTime)
                {
                    SimulationTable[tableId].StartTime = Servers[indexServerId].FinishTime;
                    NumberOfCustomerInQueue++;
                }
                else
                    SimulationTable[tableId].StartTime = SimulationTable[tableId].ArrivalTime;
                SimulationTable[tableId].EndTime = SimulationTable[tableId].ServiceTime + SimulationTable[tableId].StartTime;

            }
            SimulationTable[tableId].TimeInQueue = SimulationTable[tableId].StartTime - SimulationTable[tableId].ArrivalTime;
            sumWaitingTime += SimulationTable[tableId].TimeInQueue;
            Servers[indexServerId].TotalWorkingTime += SimulationTable[tableId].ServiceTime;
        }

        public void PerformanceMeasuresPerSystem()
        {
            Maximumqueuelength();

            PerformanceMeasures.AverageWaitingTime = (sumWaitingTime) / SimulationTable.Count ;
            PerformanceMeasures.WaitingProbability = (NumberOfCustomerInQueue) / SimulationTable.Count;

        }
       
        public void PerformanceMeasuresPerServer()
        {
            int totalSim_time = 0;
            for (int i = 0; i < SimulationTable.Count; i++)
            {
                if (SimulationTable[i].EndTime > totalSim_time)
                    totalSim_time = SimulationTable[i].EndTime;
            }
         
            for (int i = 0; i < NumberOfServers; i++)
            {
                int total_service = 0;
                int servers_customers = 0;
                for (int j = 0; j < SimulationTable.Count; j++)
                {
                    if (SimulationTable[j].AssignedServer.ID == i + 1)
                    {
                        total_service += SimulationTable[j].ServiceTime;
                        servers_customers++;
                    }
                }
                int idle = totalSim_time - total_service;

                if (servers_customers < 1)
                    servers_customers = 1;
                if (idle < 0)
                    idle = 0;
                Servers[i].AverageServiceTime = (Convert.ToDecimal(total_service) / servers_customers);
                Servers[i].Utilization = (Convert.ToDecimal(total_service) / totalSim_time);
                Servers[i].IdleProbability = (Convert.ToDecimal(idle) / totalSim_time);
            }
            
        }

        public void Maximumqueuelength()
        {

            int max = 0;

            for (int i = 0; i < SimulationTable.Count; ++i)
            {
                if (SimulationTable[i].TimeInQueue != 0)
                {
                    int temp_length = 1;
                    for (int j = i + 1; j < SimulationTable.Count; j++)
                    {

                        if (SimulationTable[j].ArrivalTime < SimulationTable[i].StartTime)
                            temp_length++;
                    }
                    if (temp_length > max)
                        max = temp_length;
                }
            }


            PerformanceMeasures.MaxQueueLength = max;
        }
    }
}
