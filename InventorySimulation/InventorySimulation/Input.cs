using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;

namespace InventorySimulation
{
    public partial class Input : Form
    {
        /*
             OrderUpTo
            11

            ReviewPeriod
            5

            StartInventoryQuantity
            3

            StartLeadDays
            2

            StartOrderQuantity
            8
 
            NumberOfDays
            25
         */
        public int OrderUpTo_val;
        public int ReviewPeriod_val;
        public int StartInventoryQuantity_val;
        public int StartLeadDays_val;
        public int StartOrderQuantity_val;
        public int NumberOfDays_val;


        string TestCase { get; set; }
        string[] lines { get; set; }
        public Input()
        {
            InitializeComponent();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.ShowDialog();
            TestCase = openFileDialog.FileName;

            if (File.Exists(TestCase))
            {

                lines = File.ReadAllLines(TestCase);
            }

            else lines = null;

            OrderUpTo.Text = lines[1];
            ReviewPeriod.Text = lines[4];
            StartInventoryQuantity.Text = lines[7];
            StartLeadDays.Text = lines[10];
            StartOrderQuantity.Text = lines[13];
            NumberOfDays.Text = lines[16];

        }

        private void Add_probability_Click(object sender, EventArgs e)
        {
            OrderUpTo_val = int.Parse(OrderUpTo.Text);
            ReviewPeriod_val = int.Parse(ReviewPeriod.Text);
            StartInventoryQuantity_val = int.Parse(StartInventoryQuantity.Text);
            StartLeadDays_val = int.Parse(StartLeadDays.Text);
            StartOrderQuantity_val = int.Parse(StartOrderQuantity.Text);
            NumberOfDays_val = int.Parse(NumberOfDays.Text);
            string s = TestCase.Substring(TestCase.Length - 13);
            View_Probability probabilities = new View_Probability(lines, s, TestCase);
            probabilities.Show();
        }
    }
}
