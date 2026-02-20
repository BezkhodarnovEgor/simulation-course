namespace lab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            InputAngle = new NumericUpDown();
            label3 = new Label();
            InputSpeed = new NumericUpDown();
            label4 = new Label();
            InputSize = new NumericUpDown();
            label5 = new Label();
            InputWeight = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            InputTStep = new NumericUpDown();
            ResultsLabel = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputAngle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputTStep).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 15D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 15D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(1, 128);
            chart1.Name = "chart1";
            chart1.Size = new Size(696, 564);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 4;
            label2.Text = "Angle";
            // 
            // InputAngle
            // 
            InputAngle.DecimalPlaces = 1;
            InputAngle.Location = new Point(82, 9);
            InputAngle.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            InputAngle.Name = "InputAngle";
            InputAngle.Size = new Size(103, 27);
            InputAngle.TabIndex = 3;
            InputAngle.Value = new decimal(new int[] { 45, 0, 0, 0 });
            InputAngle.ValueChanged += InputAngle_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 6;
            label3.Text = "Speed";
            // 
            // InputSpeed
            // 
            InputSpeed.DecimalPlaces = 1;
            InputSpeed.Location = new Point(82, 42);
            InputSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            InputSpeed.Name = "InputSpeed";
            InputSpeed.Size = new Size(103, 27);
            InputSpeed.TabIndex = 5;
            InputSpeed.Value = new decimal(new int[] { 4, 0, 0, 0 });
            InputSpeed.ValueChanged += InputSpeed_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(206, 13);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "Size";
            // 
            // InputSize
            // 
            InputSize.DecimalPlaces = 1;
            InputSize.Location = new Point(276, 6);
            InputSize.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            InputSize.Name = "InputSize";
            InputSize.Size = new Size(103, 27);
            InputSize.TabIndex = 7;
            InputSize.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(206, 50);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Weight";
            // 
            // InputWeight
            // 
            InputWeight.DecimalPlaces = 1;
            InputWeight.Location = new Point(276, 43);
            InputWeight.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            InputWeight.Name = "InputWeight";
            InputWeight.Size = new Size(103, 27);
            InputWeight.TabIndex = 9;
            InputWeight.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(430, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Launch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 13;
            label1.Text = "t step";
            // 
            // InputTStep
            // 
            InputTStep.DecimalPlaces = 4;
            InputTStep.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            InputTStep.Location = new Point(82, 75);
            InputTStep.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            InputTStep.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            InputTStep.Name = "InputTStep";
            InputTStep.Size = new Size(103, 27);
            InputTStep.TabIndex = 12;
            InputTStep.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(735, 82);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(0, 20);
            ResultsLabel.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(735, 42);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 15;
            label6.Text = "Results:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 754);
            Controls.Add(label6);
            Controls.Add(ResultsLabel);
            Controls.Add(label1);
            Controls.Add(InputTStep);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(InputWeight);
            Controls.Add(label4);
            Controls.Add(InputSize);
            Controls.Add(label3);
            Controls.Add(InputSpeed);
            Controls.Add(label2);
            Controls.Add(InputAngle);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputAngle).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputTStep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
        private NumericUpDown InputAngle;
        private Label label3;
        private NumericUpDown InputSpeed;
        private Label label4;
        private NumericUpDown InputSize;
        private Label label5;
        private NumericUpDown InputWeight;
        private Button button1;
        private Label label1;
        private NumericUpDown InputTStep;
        private Label ResultsLabel;
        private Label label6;
    }
}
