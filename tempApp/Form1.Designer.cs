
namespace tempApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelPercentVal = new System.Windows.Forms.Label();
            this.labelPercentCap = new System.Windows.Forms.Label();
            this.labelPerCountDoneVal = new System.Windows.Forms.Label();
            this.labelPerCountDoneCap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelExpPerCountVal = new System.Windows.Forms.Label();
            this.labelExpPerCountCap = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_round = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_round = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonFixPopLimit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPopLimit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 326);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPercentVal);
            this.groupBox3.Controls.Add(this.labelPercentCap);
            this.groupBox3.Controls.Add(this.labelPerCountDoneVal);
            this.groupBox3.Controls.Add(this.labelPerCountDoneCap);
            this.groupBox3.Location = new System.Drawing.Point(71, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROGRESS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelPercentVal
            // 
            this.labelPercentVal.AutoSize = true;
            this.labelPercentVal.BackColor = System.Drawing.Color.Chartreuse;
            this.labelPercentVal.Location = new System.Drawing.Point(308, 84);
            this.labelPercentVal.Name = "labelPercentVal";
            this.labelPercentVal.Size = new System.Drawing.Size(75, 20);
            this.labelPercentVal.TabIndex = 5;
            this.labelPercentVal.Text = "___________";
            this.labelPercentVal.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelPercentCap
            // 
            this.labelPercentCap.AutoSize = true;
            this.labelPercentCap.BackColor = System.Drawing.Color.Chartreuse;
            this.labelPercentCap.Location = new System.Drawing.Point(81, 86);
            this.labelPercentCap.Name = "labelPercentCap";
            this.labelPercentCap.Size = new System.Drawing.Size(184, 20);
            this.labelPercentCap.TabIndex = 4;
            this.labelPercentCap.Text = "PERCENTAGE COMPLETED";
            this.labelPercentCap.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelPerCountDoneVal
            // 
            this.labelPerCountDoneVal.AutoSize = true;
            this.labelPerCountDoneVal.Location = new System.Drawing.Point(308, 32);
            this.labelPerCountDoneVal.Name = "labelPerCountDoneVal";
            this.labelPerCountDoneVal.Size = new System.Drawing.Size(75, 20);
            this.labelPerCountDoneVal.TabIndex = 3;
            this.labelPerCountDoneVal.Text = "___________";
            // 
            // labelPerCountDoneCap
            // 
            this.labelPerCountDoneCap.AutoSize = true;
            this.labelPerCountDoneCap.Location = new System.Drawing.Point(81, 34);
            this.labelPerCountDoneCap.Name = "labelPerCountDoneCap";
            this.labelPerCountDoneCap.Size = new System.Drawing.Size(206, 20);
            this.labelPerCountDoneCap.TabIndex = 2;
            this.labelPerCountDoneCap.Text = "Permutation count carried out";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelExpPerCountVal);
            this.groupBox2.Controls.Add(this.labelExpPerCountCap);
            this.groupBox2.Location = new System.Drawing.Point(71, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expectation";
            // 
            // labelExpPerCountVal
            // 
            this.labelExpPerCountVal.AutoSize = true;
            this.labelExpPerCountVal.Location = new System.Drawing.Point(308, 32);
            this.labelExpPerCountVal.Name = "labelExpPerCountVal";
            this.labelExpPerCountVal.Size = new System.Drawing.Size(197, 20);
            this.labelExpPerCountVal.TabIndex = 3;
            this.labelExpPerCountVal.Text = "Expected Permutation Count";
            // 
            // labelExpPerCountCap
            // 
            this.labelExpPerCountCap.AutoSize = true;
            this.labelExpPerCountCap.Location = new System.Drawing.Point(81, 34);
            this.labelExpPerCountCap.Name = "labelExpPerCountCap";
            this.labelExpPerCountCap.Size = new System.Drawing.Size(197, 20);
            this.labelExpPerCountCap.TabIndex = 2;
            this.labelExpPerCountCap.Text = "Expected Permutation Count";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBox2_round);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox1_round);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(12, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 378);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "rounded to 2 decimels";
            // 
            // textBox2_round
            // 
            this.textBox2_round.Location = new System.Drawing.Point(243, 271);
            this.textBox2_round.Name = "textBox2_round";
            this.textBox2_round.Size = new System.Drawing.Size(504, 26);
            this.textBox2_round.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rounded to 2 decimel";
            // 
            // textBox1_round
            // 
            this.textBox1_round.Location = new System.Drawing.Point(195, 150);
            this.textBox1_round.Name = "textBox1_round";
            this.textBox1_round.Size = new System.Drawing.Size(441, 26);
            this.textBox1_round.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "distance by all possible lines";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(504, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "distance by order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 26);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(170, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonFixPopLimit);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxPopLimit);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 142);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // buttonFixPopLimit
            // 
            this.buttonFixPopLimit.Location = new System.Drawing.Point(626, 55);
            this.buttonFixPopLimit.Name = "buttonFixPopLimit";
            this.buttonFixPopLimit.Size = new System.Drawing.Size(148, 28);
            this.buttonFixPopLimit.TabIndex = 2;
            this.buttonFixPopLimit.Text = "Fix Population Limit";
            this.buttonFixPopLimit.UseVisualStyleBackColor = true;
            this.buttonFixPopLimit.Click += new System.EventHandler(this.buttonFixPopLimit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "POPULATION LIMIT";
            // 
            // textBoxPopLimit
            // 
            this.textBoxPopLimit.Location = new System.Drawing.Point(207, 57);
            this.textBoxPopLimit.Name = "textBoxPopLimit";
            this.textBoxPopLimit.Size = new System.Drawing.Size(414, 26);
            this.textBoxPopLimit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(805, 897);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelPerCountDoneVal;
        private System.Windows.Forms.Label labelPerCountDoneCap;
        private System.Windows.Forms.Label labelExpPerCountVal;
        private System.Windows.Forms.Label labelExpPerCountCap;
        private System.Windows.Forms.Label labelPercentVal;
        private System.Windows.Forms.Label labelPercentCap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_round;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_round;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonFixPopLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPopLimit;
    }
}

