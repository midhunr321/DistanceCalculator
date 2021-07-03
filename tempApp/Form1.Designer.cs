
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
            this.labelProcessDetail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPercentVal = new System.Windows.Forms.Label();
            this.labelPercentCap = new System.Windows.Forms.Label();
            this.labelPerCountDoneVal = new System.Windows.Forms.Label();
            this.labelPerCountDoneCap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelExpPerCountVal = new System.Windows.Forms.Label();
            this.labelExpPerCountCap = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonWebPage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonFixPopLimit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPopLimit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelProcessDetail);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.labelPercentVal);
            this.groupBox3.Controls.Add(this.labelPercentCap);
            this.groupBox3.Controls.Add(this.labelPerCountDoneVal);
            this.groupBox3.Controls.Add(this.labelPerCountDoneCap);
            this.groupBox3.Location = new System.Drawing.Point(71, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 165);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PROGRESS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // labelProcessDetail
            // 
            this.labelProcessDetail.AutoSize = true;
            this.labelProcessDetail.Location = new System.Drawing.Point(308, 132);
            this.labelProcessDetail.Name = "labelProcessDetail";
            this.labelProcessDetail.Size = new System.Drawing.Size(117, 20);
            this.labelProcessDetail.TabIndex = 7;
            this.labelProcessDetail.Text = "__________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Current Running Task";
            // 
            // labelPercentVal
            // 
            this.labelPercentVal.AutoSize = true;
            this.labelPercentVal.BackColor = System.Drawing.Color.Chartreuse;
            this.labelPercentVal.Location = new System.Drawing.Point(308, 84);
            this.labelPercentVal.Name = "labelPercentVal";
            this.labelPercentVal.Size = new System.Drawing.Size(117, 20);
            this.labelPercentVal.TabIndex = 5;
            this.labelPercentVal.Text = "__________________";
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
            this.labelPerCountDoneVal.Size = new System.Drawing.Size(117, 20);
            this.labelPerCountDoneVal.TabIndex = 3;
            this.labelPerCountDoneVal.Text = "__________________";
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
            this.labelExpPerCountVal.Size = new System.Drawing.Size(117, 20);
            this.labelExpPerCountVal.TabIndex = 3;
            this.labelExpPerCountVal.Text = "__________________";
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
            this.groupBox4.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.buttonWebPage);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 507);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 326);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // buttonWebPage
            // 
            this.buttonWebPage.Location = new System.Drawing.Point(631, 196);
            this.buttonWebPage.Name = "buttonWebPage";
            this.buttonWebPage.Size = new System.Drawing.Size(85, 30);
            this.buttonWebPage.TabIndex = 20;
            this.buttonWebPage.Text = "Open Browser";
            this.buttonWebPage.UseVisualStyleBackColor = true;
            this.buttonWebPage.Click += new System.EventHandler(this.buttonWebPage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 61);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Distance by Permutation of all possible routes between places in Km";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(509, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total distance ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 26);
            this.textBox1.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonFixPopLimit);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxPopLimit);
            this.groupBox5.Location = new System.Drawing.Point(12, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 75);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filter Data By Population";
            // 
            // buttonFixPopLimit
            // 
            this.buttonFixPopLimit.Location = new System.Drawing.Point(604, 33);
            this.buttonFixPopLimit.Name = "buttonFixPopLimit";
            this.buttonFixPopLimit.Size = new System.Drawing.Size(148, 28);
            this.buttonFixPopLimit.TabIndex = 2;
            this.buttonFixPopLimit.Text = "Filter by Population";
            this.buttonFixPopLimit.UseVisualStyleBackColor = true;
            this.buttonFixPopLimit.Click += new System.EventHandler(this.buttonFixPopLimit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Population Limit";
            // 
            // textBoxPopLimit
            // 
            this.textBoxPopLimit.Location = new System.Drawing.Point(162, 35);
            this.textBoxPopLimit.Name = "textBoxPopLimit";
            this.textBoxPopLimit.Size = new System.Drawing.Size(414, 26);
            this.textBoxPopLimit.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(271, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate Total Distance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Location = new System.Drawing.Point(12, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(777, 64);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "INPUT JSON DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input JSON File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "File Path:___________________________________________________________";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Browse JSON File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(801, 858);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Distance Calculator by Permutation of Routes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonFixPopLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPopLimit;
        private System.Windows.Forms.Label labelProcessDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonWebPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

