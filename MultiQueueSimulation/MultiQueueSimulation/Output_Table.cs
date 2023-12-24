using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultiQueueSimulation
{
    public partial class Output_Table : Form
    {
        private SimulationSystem SimulationSystem { get; set; }

        public Output_Table(SimulationSystem SimulationSystem)
        {
            InitializeComponent();
            this.SimulationSystem = SimulationSystem;
            List<SimulationCase> cases = new List<SimulationCase>();
            // Update the text box values based on the simulation results
            cases = SimulationSystem.SimulationTable;
            DataTable dataTableInterarrival = new DataTable();
            dataTableInterarrival.Columns.Add("AssignedServer", typeof(int) );
            dataTableInterarrival.Columns.Add("CustomerNumber", typeof(int));
            dataTableInterarrival.Columns.Add("RandomInterArrival", typeof(int));
            dataTableInterarrival.Columns.Add("InterArrival", typeof(int)); 
            dataTableInterarrival.Columns.Add("ArrivalTime", typeof(int));
            dataTableInterarrival.Columns.Add("RandomService", typeof(int));
            dataTableInterarrival.Columns.Add("ServiceTime", typeof(int));
            dataTableInterarrival.Columns.Add("StartTime", typeof(int));
            dataTableInterarrival.Columns.Add("EndTime", typeof(int));
            dataTableInterarrival.Columns.Add("TimeInQueue", typeof(int));

            foreach (SimulationCase simulationCase in cases)
            {
                dataTableInterarrival.Rows.Add(
                    simulationCase.AssignedServer.ID,
                    simulationCase.CustomerNumber+1,
                    simulationCase.RandomInterArrival,
                    simulationCase.InterArrival,
                    simulationCase.ArrivalTime,
                    simulationCase.RandomService,
                    simulationCase.ServiceTime,
                    simulationCase.StartTime,
                    simulationCase.EndTime,
                    simulationCase.TimeInQueue

                    );
            }
            // Refresh the DataGridView to show the simulation results
            dataGridView1.DataSource = dataTableInterarrival;
            //Controls.Add(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Queue<int>> ServersTime = new List<Queue<int>>();
            List<int> index = new List<int>(SimulationSystem.Servers.Count);
            for (int i = 0; i < SimulationSystem.SimulationTable.Count; i++)
            {
                Queue<int> time = new Queue<int>();
                int id = SimulationSystem.SimulationTable[i].AssignedServer.ID;
                if (!index.Contains(id))
                {
                    time.Enqueue(SimulationSystem.SimulationTable[i].StartTime);
                    time.Enqueue(SimulationSystem.SimulationTable[i].EndTime);
                    ServersTime.Add(time);
                    index.Add(id);
                    continue;
                }
                ServersTime[index.IndexOf(id)].Enqueue(SimulationSystem.SimulationTable[i].StartTime);
                ServersTime[index.IndexOf(id)].Enqueue(SimulationSystem.SimulationTable[i].EndTime);

            }

            for (int i = 0; i < SimulationSystem.NumberOfServers ; i++)
            {
                if (index.Contains(i + 1))
                {
                    Charts charts = new Charts(ServersTime[i], SimulationSystem.Servers[i].FinishTime, SimulationSystem.Servers[i].ID);
                    charts.Show();
                }
                else
                {
                    Queue<int> time = new Queue<int>();
                    time.Enqueue(1);
                    ServersTime.Add(time);
                    Charts charts = new Charts(ServersTime[i], SimulationSystem.Servers[i].FinishTime, SimulationSystem.Servers[i].ID);
                    charts.Show();
                }
            }

            PerformanceMeasure performanceMeasures = new PerformanceMeasure(SimulationSystem);
            performanceMeasures.Show();
           
        }


    }
}
