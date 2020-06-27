namespace BITool16550
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StudGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.RegStudButton = new System.Windows.Forms.Button();
            this.ForenameTxtBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MobileTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CampusChkBox = new System.Windows.Forms.CheckBox();
            this.VaccChckBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.StudGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // StudGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.StudGraph.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.StudGraph.Legends.Add(legend5);
            this.StudGraph.Location = new System.Drawing.Point(285, 12);
            this.StudGraph.Name = "StudGraph";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.StudGraph.Series.Add(series5);
            this.StudGraph.Size = new System.Drawing.Size(286, 319);
            this.StudGraph.TabIndex = 0;
            this.StudGraph.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegStudButton
            // 
            this.RegStudButton.Location = new System.Drawing.Point(11, 354);
            this.RegStudButton.Name = "RegStudButton";
            this.RegStudButton.Size = new System.Drawing.Size(241, 28);
            this.RegStudButton.TabIndex = 2;
            this.RegStudButton.Text = "Register a Student";
            this.RegStudButton.UseVisualStyleBackColor = true;
            this.RegStudButton.Click += new System.EventHandler(this.RegStudButton_Click);
            // 
            // ForenameTxtBox
            // 
            this.ForenameTxtBox.Location = new System.Drawing.Point(72, 150);
            this.ForenameTxtBox.Name = "ForenameTxtBox";
            this.ForenameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ForenameTxtBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show/Refresh Students Graph";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(88, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Register a Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname";
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(72, 176);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTxtBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mobile";
            // 
            // MobileTxtBox
            // 
            this.MobileTxtBox.Location = new System.Drawing.Point(72, 202);
            this.MobileTxtBox.Name = "MobileTxtBox";
            this.MobileTxtBox.Size = new System.Drawing.Size(100, 20);
            this.MobileTxtBox.TabIndex = 9;
            this.MobileTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of birth";
            // 
            // CampusChkBox
            // 
            this.CampusChkBox.AutoSize = true;
            this.CampusChkBox.Location = new System.Drawing.Point(12, 291);
            this.CampusChkBox.Name = "CampusChkBox";
            this.CampusChkBox.Size = new System.Drawing.Size(164, 17);
            this.CampusChkBox.TabIndex = 15;
            this.CampusChkBox.Text = "Student Living in the Campus";
            this.CampusChkBox.UseVisualStyleBackColor = true;
            // 
            // VaccChckBox
            // 
            this.VaccChckBox.AutoSize = true;
            this.VaccChckBox.Location = new System.Drawing.Point(11, 314);
            this.VaccChckBox.Name = "VaccChckBox";
            this.VaccChckBox.Size = new System.Drawing.Size(151, 17);
            this.VaccChckBox.TabIndex = 16;
            this.VaccChckBox.Text = "Student Need Vaccination";
            this.VaccChckBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.VaccChckBox);
            this.Controls.Add(this.CampusChkBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MobileTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SurnameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ForenameTxtBox);
            this.Controls.Add(this.RegStudButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudGraph);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StudGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegStudButton;
        private System.Windows.Forms.TextBox ForenameTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurnameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MobileTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CampusChkBox;
        private System.Windows.Forms.CheckBox VaccChckBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

