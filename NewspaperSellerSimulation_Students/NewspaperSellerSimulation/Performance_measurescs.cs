using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;


namespace NewspaperSellerSimulation
{
    public partial class Performance_measurescs : Form
    {
        private SimulationSystem SimulationSystem { get; set; }
        public Performance_measurescs(SimulationSystem Simulation_Sys)
        {
            InitializeComponent();
            total_sale.Text = (Simulation_Sys.PerformanceMeasures.TotalSalesProfit).ToString();
            total_cost.Text = (Simulation_Sys.PerformanceMeasures.TotalCost).ToString();
            total_lost_profit.Text = (Simulation_Sys.PerformanceMeasures.TotalLostProfit).ToString();
            total_salvage.Text = (Simulation_Sys.PerformanceMeasures.TotalScrapProfit).ToString();
            net_profit.Text = (Simulation_Sys.PerformanceMeasures.TotalNetProfit).ToString();
            day_excess.Text = (Simulation_Sys.PerformanceMeasures.DaysWithMoreDemand).ToString();
            day_unsold.Text = (Simulation_Sys.PerformanceMeasures.DaysWithUnsoldPapers).ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
