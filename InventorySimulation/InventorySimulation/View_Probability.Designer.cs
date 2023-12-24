
namespace InventorySimulation
{
    partial class View_Probability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view_final_table = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Leadtime_probability = new System.Windows.Forms.DataGridView();
            this.Lead_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lead_probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Daily_Demand = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Leadtime_probability)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily_Demand)).BeginInit();
            this.SuspendLayout();
            // 
            // view_final_table
            // 
            this.view_final_table.BackColor = System.Drawing.Color.White;
            this.view_final_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.view_final_table.ForeColor = System.Drawing.Color.Maroon;
            this.view_final_table.Location = new System.Drawing.Point(394, 669);
            this.view_final_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_final_table.Name = "view_final_table";
            this.view_final_table.Size = new System.Drawing.Size(301, 42);
            this.view_final_table.TabIndex = 10;
            this.view_final_table.Text = "View Final Table";
            this.view_final_table.UseVisualStyleBackColor = false;
            this.view_final_table.Click += new System.EventHandler(this.view_final_table_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(298, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Demand probability  for each day type";
            // 
            // Leadtime_probability
            // 
            this.Leadtime_probability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Leadtime_probability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lead_time,
            this.Lead_probability});
            this.Leadtime_probability.Location = new System.Drawing.Point(315, 363);
            this.Leadtime_probability.Margin = new System.Windows.Forms.Padding(4);
            this.Leadtime_probability.Name = "Leadtime_probability";
            this.Leadtime_probability.RowHeadersWidth = 51;
            this.Leadtime_probability.Size = new System.Drawing.Size(518, 225);
            this.Leadtime_probability.TabIndex = 8;
            // 
            // Lead_time
            // 
            this.Lead_time.HeaderText = "Lead Time (day)";
            this.Lead_time.MinimumWidth = 6;
            this.Lead_time.Name = "Lead_time";
            this.Lead_time.Width = 125;
            // 
            // Lead_probability
            // 
            this.Lead_probability.HeaderText = "Probability";
            this.Lead_probability.MinimumWidth = 6;
            this.Lead_probability.Name = "Lead_probability";
            this.Lead_probability.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Probability for each day type";
            // 
            // Daily_Demand
            // 
            this.Daily_Demand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Daily_Demand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.daily_probability});
            this.Daily_Demand.Location = new System.Drawing.Point(315, 72);
            this.Daily_Demand.Margin = new System.Windows.Forms.Padding(4);
            this.Daily_Demand.Name = "Daily_Demand";
            this.Daily_Demand.RowHeadersWidth = 51;
            this.Daily_Demand.Size = new System.Drawing.Size(518, 211);
            this.Daily_Demand.TabIndex = 6;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.Width = 125;
            // 
            // daily_probability
            // 
            this.daily_probability.HeaderText = "Probability";
            this.daily_probability.MinimumWidth = 6;
            this.daily_probability.Name = "daily_probability";
            this.daily_probability.Width = 125;
            // 
            // View_Probability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 752);
            this.Controls.Add(this.view_final_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Leadtime_probability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Daily_Demand);
            this.Name = "View_Probability";
            this.Text = "View_Probability";
            ((System.ComponentModel.ISupportInitialize)(this.Leadtime_probability)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Daily_Demand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view_final_table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Daily_Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily_probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lead_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lead_probability;
        private System.Windows.Forms.DataGridView Leadtime_probability;
    }
}