using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MultiQueueModels;
using MultiQueueTesting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MultiQueueSimulation
{
    public partial class Charts : Form
    {
        private Queue<int> QueueSimulationSystem { get; set; }
        private int endPoint,id; 
        public Charts(Queue<int> QueueSimulationSystem, int endPoint, int id )
        {
            this.QueueSimulationSystem = QueueSimulationSystem;
            this.endPoint = endPoint;
            this.id = id;
            InitializeComponent();


            this.Size = new Size(70 + endPoint *10  , 400);

  
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            label1.Text = "Server " + id.ToString();
            int size = QueueSimulationSystem.Count;
            int maxinterval=0, mininterval=0;
            if (size > 1)
            {
                mininterval = QueueSimulationSystem.Dequeue();
                maxinterval = QueueSimulationSystem.Dequeue();
            }

            base.OnPaint(e);

            Graphics g = e.Graphics;
            int graphWidth = this.ClientSize.Width - 60;
            int graphHeight = this.ClientSize.Height - 60;
            int barY = graphHeight - (50 * graphHeight) / 100 + 40, barHeight = (50 * graphHeight) / 100 ;
            // Draw x-axis line
            g.DrawLine(Pens.Black, 40, graphHeight + 40, graphWidth + 40, graphHeight + 40);

            // Draw y-axis line
            g.DrawLine(Pens.Black, 40, 40, 40, graphHeight + 40);
            for (int i = 1; i <= endPoint ; i+=5 )
            {
                g.DrawString(i.ToString(), this.Font, Brushes.Black, new PointF(40+i*5 , barY + barHeight + 7));
            }
            for (int i = 0; i < size/2; i++)
            {
                // Calculate bar dimensions
                int barWidth = maxinterval - mininterval;

                // Draw the bar range
                Rectangle barRect = new Rectangle(40+ mininterval*5 , barY, barWidth*5, barHeight);
                g.FillRectangle(Brushes.Blue, barRect);


                if (QueueSimulationSystem.Count > 1)
                    mininterval = QueueSimulationSystem.Dequeue();
                if (QueueSimulationSystem.Count > 1)
                    maxinterval = QueueSimulationSystem.Dequeue();

            }
            // Draw the constant value label
            g.DrawString(1.ToString(), this.Font, Brushes.Black, new PointF(5, barY - 7));
            g.DrawString("Busy", this.Font, Brushes.Black, new PointF(5, barY - 20));
            // Draw the range label
            g.DrawString("idle ", this.Font, Brushes.Black, new PointF(5, barY + barHeight + 7));
            g.DrawString("Time ", this.Font, Brushes.Black, new PointF(graphWidth + 40, barY + barHeight + 7));
        }

    }
    
}

