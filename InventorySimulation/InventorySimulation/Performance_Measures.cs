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
    public partial class Performance_Measures : Form
    {
        private SimulationSystem SimulationSystem { get; set; }
        public Performance_Measures(SimulationSystem Simulation_Sys)
        {
            InitializeComponent();
            string x = (Simulation_Sys.PerformanceMeasures.EndingInventoryAverage).ToString();
            string y = (Simulation_Sys.PerformanceMeasures.ShortageQuantityAverage).ToString();
            label3.Text = x;
            label4.Text = y;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reopen_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
