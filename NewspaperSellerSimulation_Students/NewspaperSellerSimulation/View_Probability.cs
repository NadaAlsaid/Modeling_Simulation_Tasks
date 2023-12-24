using NewspaperSellerModels;
using NewspaperSellerTesting;
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
    public partial class View_Probability : Form
    {

        private SimulationSystem Simulation { get; set; }
        string TestCase { get; set; }
        string[] lines { get; set; }
        public View_Probability(string[] lines, string TestCase)
        {
            this.TestCase = TestCase;
            InitializeComponent();
            this.lines = lines;
            //this is for data grid 1 (probabiliy_day_type)
            String line1 = lines[16];
            probabiliy_day_type.Rows.Add();
            probabiliy_day_type.Rows.Add();
            probabiliy_day_type.Rows.Add();
            probabiliy_day_type.Rows[0].Cells[0].Value = "Good";
            probabiliy_day_type.Rows[1].Cells[0].Value = "Fair";
            probabiliy_day_type.Rows[2].Cells[0].Value = "Poor";
            string[] value1 = line1.Split(',');
            for (int i = 0; i < value1.Length; i++)
            {
                probabiliy_day_type.Rows[i].Cells[1].Value = value1[i];
            }
            bool fill_table = true;
            int count = 19;
            while (fill_table)
            {
                if (lines != null && count < lines.Length)
                {
                    String line2 = lines[count];
                    string[] value2 = line2.Split(',');
                    demand_probability.Rows.Add(value2[0], value2[1], value2[2], value2[3]);
                    count++;
                }
                else
                {
                    fill_table = false;
                }
            }
        }

        private void view_final_table_Click(object sender, EventArgs e)
        {
            SimulationSystem SimulationSystem = new SimulationSystem();
            SimulationSystem.FillData(lines);
            SimulationSystem.MainLoop();
            string result = TestingManager.Test(SimulationSystem, TestCase);
            MessageBox.Show(result);
         
            Output_Table output = new Output_Table(SimulationSystem);
            output.Show();
        }

    }
}
