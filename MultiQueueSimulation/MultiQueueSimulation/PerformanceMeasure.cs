using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class PerformanceMeasure : Form
    {
        // private TableLayoutPanel tableLayoutPanel;
        DataGridView dataGridView = new DataGridView();
        private SimulationSystem SimulationSystem { get; set; }

        public PerformanceMeasure(SimulationSystem SimulationSystem)
        {
            this.SimulationSystem = SimulationSystem;
            InitializeComponent();
            // Create the DataGridView
            dataGridView.Dock = DockStyle.Fill;
            dataGridView = new DataGridView();
            dataGridView.Location = new Point(85, 70);
            dataGridView.Size = new Size(450, 150);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSize = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowCount = 3;

            // Add the DataGridView to the form
            Controls.Add(dataGridView);

            // Generate columns dynamically
            GenerateColumns(SimulationSystem.NumberOfServers);
            label11.Text = (SimulationSystem.PerformanceMeasures.AverageWaitingTime).ToString();
            label12.Text = (SimulationSystem.PerformanceMeasures.WaitingProbability).ToString();
            label13.Text = (SimulationSystem.PerformanceMeasures.MaxQueueLength).ToString();


        }

        private void GenerateColumns(int ServerCount)
        {

            //Set the text labels for the first column
            dataGridView.Rows[0].HeaderCell.Value = "Average service time ";
            dataGridView.Rows[1].HeaderCell.Value = "Idle time prob ";
            dataGridView.Rows[2].HeaderCell.Value = "Utilization ";
            dataGridView.AutoResizeRows();

            // Add columns to the DataGridView dynamically
            for (int i = 0; i < ServerCount; i++)
            {
                string columnName = "SERVER  " + (i + 1);

                //Create a new column
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnName;

                // Add the column to the DataGridView
                dataGridView.Columns.Add(column);
                if (i == 0) dataGridView.Columns.RemoveAt(0);
                dataGridView.Rows[0].Cells[i].Value = SimulationSystem.Servers[i].AverageServiceTime;
                dataGridView.Rows[1].Cells[i].Value = SimulationSystem.Servers[i].IdleProbability;
                dataGridView.Rows[2].Cells[i].Value = SimulationSystem.Servers[i].Utilization;


            }

        }

    }
}
