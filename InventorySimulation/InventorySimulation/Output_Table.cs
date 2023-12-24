using InventoryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation
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
            dataTableInterarrival.Columns.Add("Day", typeof(string));
            dataTableInterarrival.Columns.Add("Cycle", typeof(int));
            dataTableInterarrival.Columns.Add("Day within cycle", typeof(int));
            dataTableInterarrival.Columns.Add("Beginning Inventory", typeof(int));
            dataTableInterarrival.Columns.Add("Random Demand", typeof(int));
            dataTableInterarrival.Columns.Add("Demand", typeof(decimal));
            dataTableInterarrival.Columns.Add("Ending Inventory", typeof(decimal));
            dataTableInterarrival.Columns.Add("Shortage Quantity", typeof(decimal));
            dataTableInterarrival.Columns.Add("Order Quantity", typeof(decimal));
            dataTableInterarrival.Columns.Add("Random Digit for Demand", typeof(decimal));
            dataTableInterarrival.Columns.Add("Lead Time", typeof(decimal));
            dataTableInterarrival.Columns.Add("Days until Order arrives", typeof(decimal));
            foreach (SimulationCase simulationCase in cases)
            {
                dataTableInterarrival.Rows.Add(
                    simulationCase.Day.ToString(),
                    simulationCase.Cycle,
                    simulationCase.DayWithinCycle,
                    simulationCase.BeginningInventory,
                    simulationCase.RandomDemand,
                    simulationCase.Demand,
                    simulationCase.EndingInventory,
                    simulationCase.ShortageQuantity,
                    simulationCase.OrderQuantity,
                    simulationCase.RandomLeadDays,
                    simulationCase.LeadDays,
                    simulationCase.DaysUntillOrderArrives
                    
                    );
            }
            dataTableInterarrival.Rows.Add(
                    "Total average",
                    null,
                    null,
                    null,
                    null,
                    null,
                    SimulationSys.ending_Sum,
                    SimulationSys.shortage_Sum,
                    null,
                    null,
                    null,
                    null

                    );
            // Refresh the DataGridView to show the simulation results
            dataGridView1.DataSource = dataTableInterarrival;
        }

        private void Performance_measures_Click(object sender, EventArgs e)
        {
            Performance_Measures performanceMeasures = new Performance_Measures(Simulation_Sys);
            performanceMeasures.Show();

        }

    }
}
