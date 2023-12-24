namespace InventorySimulation
{
    partial class Input
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
            this.label6 = new System.Windows.Forms.Label();
            this.Add_probability = new System.Windows.Forms.Button();
            this.StartOrderQuantity = new System.Windows.Forms.TextBox();
            this.StartLeadDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StartInventoryQuantity = new System.Windows.Forms.TextBox();
            this.ReviewPeriod = new System.Windows.Forms.TextBox();
            this.OrderUpTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumberOfDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(454, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Input";
            // 
            // Add_probability
            // 
            this.Add_probability.BackColor = System.Drawing.Color.White;
            this.Add_probability.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.Add_probability.ForeColor = System.Drawing.Color.Maroon;
            this.Add_probability.Location = new System.Drawing.Point(365, 555);
            this.Add_probability.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_probability.Name = "Add_probability";
            this.Add_probability.Size = new System.Drawing.Size(231, 34);
            this.Add_probability.TabIndex = 22;
            this.Add_probability.Text = "Add Probabilities";
            this.Add_probability.UseVisualStyleBackColor = false;
            this.Add_probability.Click += new System.EventHandler(this.Add_probability_Click);
            // 
            // StartOrderQuantity
            // 
            this.StartOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.StartOrderQuantity.Location = new System.Drawing.Point(639, 346);
            this.StartOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartOrderQuantity.Name = "StartOrderQuantity";
            this.StartOrderQuantity.Size = new System.Drawing.Size(192, 34);
            this.StartOrderQuantity.TabIndex = 21;
            // 
            // StartLeadDays
            // 
            this.StartLeadDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.StartLeadDays.Location = new System.Drawing.Point(639, 277);
            this.StartLeadDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartLeadDays.Name = "StartLeadDays";
            this.StartLeadDays.Size = new System.Drawing.Size(192, 34);
            this.StartLeadDays.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Review Period";
            // 
            // StartInventoryQuantity
            // 
            this.StartInventoryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.StartInventoryQuantity.Location = new System.Drawing.Point(639, 212);
            this.StartInventoryQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartInventoryQuantity.Name = "StartInventoryQuantity";
            this.StartInventoryQuantity.Size = new System.Drawing.Size(192, 34);
            this.StartInventoryQuantity.TabIndex = 18;
            // 
            // ReviewPeriod
            // 
            this.ReviewPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.ReviewPeriod.Location = new System.Drawing.Point(639, 150);
            this.ReviewPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReviewPeriod.Name = "ReviewPeriod";
            this.ReviewPeriod.Size = new System.Drawing.Size(192, 34);
            this.ReviewPeriod.TabIndex = 17;
            // 
            // OrderUpTo
            // 
            this.OrderUpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.OrderUpTo.Location = new System.Drawing.Point(639, 76);
            this.OrderUpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderUpTo.Name = "OrderUpTo";
            this.OrderUpTo.Size = new System.Drawing.Size(192, 34);
            this.OrderUpTo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Order Up To";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Order Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Lead Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Start Inventory Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(28, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Number Of Days";
            // 
            // NumberOfDays
            // 
            this.NumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.NumberOfDays.Location = new System.Drawing.Point(639, 435);
            this.NumberOfDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberOfDays.Name = "NumberOfDays";
            this.NumberOfDays.Size = new System.Drawing.Size(192, 34);
            this.NumberOfDays.TabIndex = 25;
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 633);
            this.Controls.Add(this.NumberOfDays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add_probability);
            this.Controls.Add(this.StartOrderQuantity);
            this.Controls.Add(this.StartLeadDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StartInventoryQuantity);
            this.Controls.Add(this.ReviewPeriod);
            this.Controls.Add(this.OrderUpTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Input";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_probability;
        private System.Windows.Forms.TextBox StartOrderQuantity;
        private System.Windows.Forms.TextBox StartLeadDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartInventoryQuantity;
        private System.Windows.Forms.TextBox ReviewPeriod;
        private System.Windows.Forms.TextBox OrderUpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumberOfDays;
    }
}