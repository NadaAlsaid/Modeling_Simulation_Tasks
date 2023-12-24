using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Input : Form
    {

        public int No_of_Record;
        public float Newspaper_Purchase_Price;
        public float Newspaper_Selling_Price;
        public float Newspaper_Scrap_Value;
        public int orignal_no_Newspaper;

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

            NumOfNewspapers.Text = lines[1];
            NumOfRecords.Text = lines[4];
            PurchasePrice.Text = lines[7];
            ScrapPrice.Text = lines[10];
            SellingPrice.Text = lines[13];

        }

        private void Add_probability_Click(object sender, EventArgs e)
        {
            Newspaper_Purchase_Price = float.Parse(PurchasePrice.Text);
            Newspaper_Selling_Price = float.Parse(SellingPrice.Text);
            Newspaper_Scrap_Value = float.Parse(ScrapPrice.Text);
            orignal_no_Newspaper = int.Parse(NumOfNewspapers.Text);
            No_of_Record = int.Parse(NumOfRecords.Text);
            string s = TestCase.Substring(TestCase.Length - 13);
            View_Probability probabilities = new View_Probability(lines, s);
            probabilities.Show();
        }
    }
}
