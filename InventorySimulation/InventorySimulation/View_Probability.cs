using InventoryModels;
using InventoryTesting;
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
    public partial class View_Probability : Form
    {
        private SimulationSystem Simulation { get; set; }
        string TestCase { get; set; }
        string[] lines { get; set; }
        string path { get; set; }
        public View_Probability(string[] lines, string TestCase, string path )
        {
            this.path = path;
            this.TestCase = TestCase;
            InitializeComponent();
            this.lines = lines;
            //this is for data grid 1 (probabiliy_day_type)

            bool fill_table1 = true;
            int count1 = 19;
            while (fill_table1)
            {
                if (lines != null)
                {
                    //Daily_Demand.Rows.Add();
                    String line2 = lines[count1];
                    string[] value2 = line2.Split(',');
                    if (lines[count1].Equals(""))
                    {
                        fill_table1 = false;
                        break;
                    }
                    else
                    {
                        Daily_Demand.Rows.Add(value2[0], value2[1]);
                        count1++;
                    }
                }
                else
                {
                    break;
                    fill_table1 = false;
                }
            }
            bool fill_table2 = true;
            count1 += 2;
            while (fill_table2)
            {
                if (lines != null && count1 < lines.Length)
                {
                    //Daily_Demand.Rows.Add();
                    String line2 = lines[count1];
                    string[] value2 = line2.Split(',');
                    if (lines[count1].Equals(""))
                    {
                        fill_table1 = false;
                        break;
                    }
                    else
                    {
                        Leadtime_probability.Rows.Add(value2[0], value2[1]);
                        count1++;
                    }
                }
                else
                {
                    fill_table2 = false;
                    break;
                }
            }

        }

        private void view_final_table_Click(object sender, EventArgs e)
        {
            SimulationSystem SimulationSystem = new SimulationSystem();
            SimulationSystem.Reading(lines);
            SimulationSystem.FillTable(); 
            string result = TestingManager.Test(SimulationSystem, TestCase);
            MessageBox.Show(result);

            Output_Table output = new Output_Table(SimulationSystem);
            output.Show();
        }

        private void Daily_Demand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
