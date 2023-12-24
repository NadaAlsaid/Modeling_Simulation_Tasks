using NewspaperSellerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class Output_Table : Form
    {
        public SimulationSystem Simulation_Sys { get; set; }
        public Output_Table(SimulationSystem SimulationSys)
        {
            InitializeComponent();
            this.Simulation_Sys = SimulationSys;
            List<SimulationCase> cases = new List<SimulationCase>();
            // Update the text box values based on the simulation results
            cases = SimulationSys.SimulationTable;
            DataTable dataTableInterarrival = new DataTable();
            dataTableInterarrival.Columns.Add("Day", typeof(int));
            dataTableInterarrival.Columns.Add("Random digit for type of day", typeof(int));
            dataTableInterarrival.Columns.Add("Type of Newsday", typeof(Enums.DayType));
            dataTableInterarrival.Columns.Add("Random digits for demand", typeof(int));
            dataTableInterarrival.Columns.Add("Demand", typeof(int));
            dataTableInterarrival.Columns.Add("Revenue for Sales", typeof(decimal));
            dataTableInterarrival.Columns.Add("Lost profit from execess demand", typeof(decimal));
            dataTableInterarrival.Columns.Add("Salvage from Sale of Scrap", typeof(decimal));
            dataTableInterarrival.Columns.Add("Daily Profit", typeof(decimal));
            foreach (SimulationCase simulationCase in cases)
            {
                dataTableInterarrival.Rows.Add(
                    simulationCase.DayNo,
                    simulationCase.RandomNewsDayType,
                    simulationCase.NewsDayType,
                    simulationCase.RandomDemand,
                    simulationCase.Demand,
                    simulationCase.SalesProfit,
                    simulationCase.LostProfit,
                    simulationCase.ScrapProfit,
                    simulationCase.DailyNetProfit

                    );
            }
            // Refresh the DataGridView to show the simulation results
            dataGridView1.DataSource = dataTableInterarrival;
        }

        private void Performance_measures_Click(object sender, EventArgs e)
        {
            Performance_measurescs performanceMeasures = new Performance_measurescs(Simulation_Sys);
            performanceMeasures.Show();
        }
    }
}
