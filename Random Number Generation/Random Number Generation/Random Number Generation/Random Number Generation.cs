using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Random_Click(object sender, EventArgs e)
        {
            long multiplier = long.Parse( Multiplier.Text );
            long Seed = long.Parse( seed.Text );
            long increment = long.Parse( Increment.Text );
            long modulus = long.Parse( Modulus.Text );
            int no_Iteration = int.Parse(No_Iteration.Text);
            Random_Number_Generation lcg = new Random_Number_Generation(
                multiplier, increment, modulus, Seed , no_Iteration);
            long[] randomNumbers = lcg.GeneratedRandomNumbers();
            long cycleLength = lcg.CalculateCycleLength();

            Period_length.Text = cycleLength.ToString();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                dataGridView1.Rows.Add( randomNumbers[i] );
            }
        }
    }
}
