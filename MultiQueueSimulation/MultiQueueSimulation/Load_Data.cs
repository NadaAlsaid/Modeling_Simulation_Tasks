using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Load_Data : Form
    {
        int count = 1;
        private SimulationSystem SimulationSystem { get; set; }
        string TestCase { get; set; }
        string[] lines { get; set; }
        public Load_Data( string[] lines , string TestCase)
        {
            this.TestCase = TestCase;
            InitializeComponent();
            this.lines = lines ;
            if (lines != null)
            {
                // Store each line in array of strings 
               
                
                
                bool isInterarrivalDistribution = false;

                List <bool> isServiceDistribution_Server = new List<bool>() ;
                count = 1;
                
                DataTable dataTableInterarrival = new DataTable();
                dataTableInterarrival.Columns.Add("Interarrival", typeof(string));

                dataTableInterarrival.Columns.Add("Probability", typeof(string));
                //MessageBox.Show(lines[0]);
                //MessageBox.Show("ServiceDistribution_Server" + count.ToString());
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
                            dataGridView1.DataSource = dataTableInterarrival;
                            continue;
                        }
                        string[] strings = ln.Split(',');
                        dataTableInterarrival.Rows.Add(strings[0], strings[1]);
                    }

                    if (ln.Equals("ServiceDistribution_Server"+count.ToString()) ) {
                        
                        isServiceDistribution_Server.Add( true );
                        dataTableInterarrival = new DataTable();
                        dataTableInterarrival.Columns.Add("Service Time", typeof(string));
                        dataTableInterarrival.Columns.Add("Probability", typeof(string));
                        continue;
                    }
                    if (isServiceDistribution_Server.Count > count - 1 && isServiceDistribution_Server[count-1]) {
                        if (ln == "")
                        {
                            isServiceDistribution_Server[count - 1] = false;
                            dataGridViewServer(dataTableInterarrival);
                            count++;
                            continue;
                        }
                        string[] strings = ln.Split(',');
                        dataTableInterarrival.Rows.Add(strings[0], strings[1]);
                    }
                }
                dataGridViewServer(dataTableInterarrival);
            }

        }

        private void dataGridViewServer(DataTable dataTable)
        {
            DataGridView dataGridViewServer = new DataGridView();
            dataGridViewServer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServer.Location = new Point( 280 , 250+ (150*(count-1) ) );
            dataGridViewServer.Size = new System.Drawing.Size(240, 150);
            dataGridViewServer.DataSource = dataTable;
            Controls.Add(dataGridViewServer);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimulationSystem SimulationSystem = new SimulationSystem();
            SimulationSystem.FillData(lines);
            SimulationSystem.SimulationCaseCalculate();
            SimulationSystem.PerformanceMeasuresPerServer();
            SimulationSystem.PerformanceMeasuresPerSystem();
            string result = TestingManager.Test(SimulationSystem, TestCase );
            MessageBox.Show(result);
            Output_Table output = new Output_Table(SimulationSystem);
            output.Show();
        }

    }
}
