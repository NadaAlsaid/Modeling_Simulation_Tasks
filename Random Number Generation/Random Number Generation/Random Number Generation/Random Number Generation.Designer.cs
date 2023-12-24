
namespace Random_Number_Generation
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Multiplier = new System.Windows.Forms.TextBox();
            this.seed = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.TextBox();
            this.Modulus = new System.Windows.Forms.TextBox();
            this.No_Iteration = new System.Windows.Forms.TextBox();
            this.Period_length = new System.Windows.Forms.TextBox();
            this.Generate_Random = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Randon_Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multiplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed (X0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Increment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(24, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modulus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(24, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Iteration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(24, 520);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actual Period Length";
            // 
            // Multiplier
            // 
            this.Multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.Multiplier.ForeColor = System.Drawing.Color.Maroon;
            this.Multiplier.Location = new System.Drawing.Point(330, 30);
            this.Multiplier.Margin = new System.Windows.Forms.Padding(2);
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Size = new System.Drawing.Size(168, 37);
            this.Multiplier.TabIndex = 6;
            // 
            // seed
            // 
            this.seed.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.seed.ForeColor = System.Drawing.Color.Maroon;
            this.seed.Location = new System.Drawing.Point(330, 103);
            this.seed.Margin = new System.Windows.Forms.Padding(2);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(168, 37);
            this.seed.TabIndex = 7;
            // 
            // Increment
            // 
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.Increment.ForeColor = System.Drawing.Color.Maroon;
            this.Increment.Location = new System.Drawing.Point(330, 175);
            this.Increment.Margin = new System.Windows.Forms.Padding(2);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(168, 37);
            this.Increment.TabIndex = 8;
            // 
            // Modulus
            // 
            this.Modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.Modulus.ForeColor = System.Drawing.Color.Maroon;
            this.Modulus.Location = new System.Drawing.Point(330, 258);
            this.Modulus.Margin = new System.Windows.Forms.Padding(2);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(168, 37);
            this.Modulus.TabIndex = 9;
            // 
            // No_Iteration
            // 
            this.No_Iteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.No_Iteration.ForeColor = System.Drawing.Color.Maroon;
            this.No_Iteration.Location = new System.Drawing.Point(330, 335);
            this.No_Iteration.Margin = new System.Windows.Forms.Padding(2);
            this.No_Iteration.Name = "No_Iteration";
            this.No_Iteration.Size = new System.Drawing.Size(168, 37);
            this.No_Iteration.TabIndex = 10;
            // 
            // Period_length
            // 
            this.Period_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.Period_length.ForeColor = System.Drawing.Color.Maroon;
            this.Period_length.Location = new System.Drawing.Point(330, 508);
            this.Period_length.Margin = new System.Windows.Forms.Padding(2);
            this.Period_length.Name = "Period_length";
            this.Period_length.Size = new System.Drawing.Size(168, 37);
            this.Period_length.TabIndex = 11;
            // 
            // Generate_Random
            // 
            this.Generate_Random.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Generate_Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Random.ForeColor = System.Drawing.Color.White;
            this.Generate_Random.Location = new System.Drawing.Point(80, 420);
            this.Generate_Random.Margin = new System.Windows.Forms.Padding(2);
            this.Generate_Random.Name = "Generate_Random";
            this.Generate_Random.Size = new System.Drawing.Size(319, 43);
            this.Generate_Random.TabIndex = 12;
            this.Generate_Random.Text = "Generate Random Numbers";
            this.Generate_Random.UseVisualStyleBackColor = false;
            this.Generate_Random.Click += new System.EventHandler(this.Generate_Random_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Randon_Numbers});
            this.dataGridView1.Location = new System.Drawing.Point(614, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(199, 533);
            this.dataGridView1.TabIndex = 13;
            // 
            // Randon_Numbers
            // 
            this.Randon_Numbers.HeaderText = "Randon Numbers";
            this.Randon_Numbers.MinimumWidth = 6;
            this.Randon_Numbers.Name = "Randon_Numbers";
            this.Randon_Numbers.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(860, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Generate_Random);
            this.Controls.Add(this.Period_length);
            this.Controls.Add(this.No_Iteration);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.Multiplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Random Number Generation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Multiplier;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.TextBox Increment;
        private System.Windows.Forms.TextBox Modulus;
        private System.Windows.Forms.TextBox No_Iteration;
        private System.Windows.Forms.TextBox Period_length;
        private System.Windows.Forms.Button Generate_Random;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Randon_Numbers;
    }
}

