using MultiQueueModels;
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
using static MultiQueueModels.Enums;

namespace MultiQueueSimulation
{
    public partial class Input : Form
    {
        public int num_of_servers ;
        public int server_selection_method ;
        public int stopping_conditions ;
        public int final_conditions ;
        public string stoppingCriteria, selectionMethod;

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
            textBox1.Text = lines[1];
            textBox2.Text = lines[4];
            comboBox1.SelectedIndex = 0 ;
            stopping_cond.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_of_servers = int.Parse(textBox1.Text);
            final_conditions = int.Parse(textBox2.Text);
            string s = TestCase.Substring(TestCase.Length - 13);
            Load_Data load_data = new Load_Data(lines , s);
            load_data.Show();
        }

 
        private void stopping_cond_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "Enter " + stopping_cond.Text;
            stoppingCriteria = stopping_cond.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionMethod = comboBox1.Text;
        }


    }
}
