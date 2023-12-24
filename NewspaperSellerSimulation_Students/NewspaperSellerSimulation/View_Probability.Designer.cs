
namespace NewspaperSellerSimulation
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
            this.probabiliy_day_type = new System.Windows.Forms.DataGridView();
            this.Day_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.demand_probability = new System.Windows.Forms.DataGridView();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_final_table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.probabiliy_day_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_probability)).BeginInit();
            this.SuspendLayout();
            // 
            // probabiliy_day_type
            // 
            this.probabiliy_day_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.probabiliy_day_type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day_Type,
            this.Probability_day});
            this.probabiliy_day_type.Location = new System.Drawing.Point(320, 89);
            this.probabiliy_day_type.Name = "probabiliy_day_type";
            this.probabiliy_day_type.RowHeadersWidth = 51;
            this.probabiliy_day_type.Size = new System.Drawing.Size(300, 141);
            this.probabiliy_day_type.TabIndex = 1;
            // 
            // Day_Type
            // 
            this.Day_Type.HeaderText = "Day Type";
            this.Day_Type.MinimumWidth = 6;
            this.Day_Type.Name = "Day_Type";
            this.Day_Type.Width = 125;
            // 
            // Probability_day
            // 
            this.Probability_day.HeaderText = "Probability";
            this.Probability_day.MinimumWidth = 6;
            this.Probability_day.Name = "Probability_day";
            this.Probability_day.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(277, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Probability for each day type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(269, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Demand probability  for each day type";
            // 
            // demand_probability
            // 
            this.demand_probability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demand_probability.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Good,
            this.Fair,
            this.Poor});
            this.demand_probability.Location = new System.Drawing.Point(188, 315);
            this.demand_probability.Name = "demand_probability";
            this.demand_probability.RowHeadersWidth = 51;
            this.demand_probability.Size = new System.Drawing.Size(553, 227);
            this.demand_probability.TabIndex = 3;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.MinimumWidth = 6;
            this.Demand.Name = "Demand";
            this.Demand.Width = 125;
            // 
            // Good
            // 
            this.Good.HeaderText = "Good";
            this.Good.MinimumWidth = 6;
            this.Good.Name = "Good";
            this.Good.Width = 125;
            // 
            // Fair
            // 
            this.Fair.HeaderText = "Fair";
            this.Fair.MinimumWidth = 6;
            this.Fair.Name = "Fair";
            this.Fair.Width = 125;
            // 
            // Poor
            // 
            this.Poor.HeaderText = "poor";
            this.Poor.MinimumWidth = 6;
            this.Poor.Name = "Poor";
            this.Poor.Width = 125;
            // 
            // view_final_table
            // 
            this.view_final_table.BackColor = System.Drawing.Color.White;
            this.view_final_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.view_final_table.ForeColor = System.Drawing.Color.Maroon;
            this.view_final_table.Location = new System.Drawing.Point(341, 564);
            this.view_final_table.Margin = new System.Windows.Forms.Padding(2);
            this.view_final_table.Name = "view_final_table";
            this.view_final_table.Size = new System.Drawing.Size(226, 34);
            this.view_final_table.TabIndex = 5;
            this.view_final_table.Text = "View Final Table";
            this.view_final_table.UseVisualStyleBackColor = false;
            this.view_final_table.Click += new System.EventHandler(this.view_final_table_Click);
            // 
            // View_Probability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 609);
            this.Controls.Add(this.view_final_table);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.demand_probability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.probabiliy_day_type);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View_Probability";
            this.Text = "View Probabilities";
            ((System.ComponentModel.ISupportInitialize)(this.probabiliy_day_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demand_probability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView probabiliy_day_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView demand_probability;
        private System.Windows.Forms.Button view_final_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor;

    }
}