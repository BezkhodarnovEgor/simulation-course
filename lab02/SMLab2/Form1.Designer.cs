namespace SMLab2
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
            temperatureLUpDown = new NumericUpDown();
            temperatureRUpDown = new NumericUpDown();
            tileCountUpDown = new NumericUpDown();
            timeStepUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            temperatureMUpDown = new NumericUpDown();
            label6 = new Label();
            conductivityUpDown = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            capacityUpDown = new NumericUpDown();
            densityUpDown = new NumericUpDown();
            label9 = new Label();
            lengthUpDown = new NumericUpDown();
            label10 = new Label();
            allTimeUpDown = new NumericUpDown();
            label11 = new Label();
            middleTemp = new Label();
            ((System.ComponentModel.ISupportInitialize)temperatureLUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)temperatureRUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tileCountUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeStepUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)temperatureMUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conductivityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lengthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allTimeUpDown).BeginInit();
            SuspendLayout();
            // 
            // temperatureLUpDown
            // 
            temperatureLUpDown.DecimalPlaces = 1;
            temperatureLUpDown.Location = new Point(310, 12);
            temperatureLUpDown.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            temperatureLUpDown.Minimum = new decimal(new int[] { 273, 0, 0, int.MinValue });
            temperatureLUpDown.Name = "temperatureLUpDown";
            temperatureLUpDown.Size = new Size(93, 27);
            temperatureLUpDown.TabIndex = 1;
            temperatureLUpDown.Value = new decimal(new int[] { 20, 0, 0, int.MinValue });
            // 
            // temperatureRUpDown
            // 
            temperatureRUpDown.DecimalPlaces = 1;
            temperatureRUpDown.Location = new Point(310, 45);
            temperatureRUpDown.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            temperatureRUpDown.Minimum = new decimal(new int[] { 273, 0, 0, int.MinValue });
            temperatureRUpDown.Name = "temperatureRUpDown";
            temperatureRUpDown.Size = new Size(93, 27);
            temperatureRUpDown.TabIndex = 2;
            temperatureRUpDown.Value = new decimal(new int[] { 910, 0, 0, 0 });
            // 
            // tileCountUpDown
            // 
            tileCountUpDown.DecimalPlaces = 4;
            tileCountUpDown.Location = new Point(529, 45);
            tileCountUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            tileCountUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            tileCountUpDown.Name = "tileCountUpDown";
            tileCountUpDown.Size = new Size(93, 27);
            tileCountUpDown.TabIndex = 3;
            tileCountUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // timeStepUpDown
            // 
            timeStepUpDown.DecimalPlaces = 4;
            timeStepUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            timeStepUpDown.Location = new Point(529, 78);
            timeStepUpDown.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            timeStepUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 262144 });
            timeStepUpDown.Name = "timeStepUpDown";
            timeStepUpDown.Size = new Size(93, 27);
            timeStepUpDown.TabIndex = 4;
            timeStepUpDown.Value = new decimal(new int[] { 1, 0, 0, 262144 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "temp Left";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 47);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "temp Right";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 47);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "tiles size";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 80);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 8;
            label4.Text = "time step";
            // 
            // button1
            // 
            button1.Location = new Point(640, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 80);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 11;
            label5.Text = "temp Middle";
            label5.Click += label5_Click;
            // 
            // temperatureMUpDown
            // 
            temperatureMUpDown.DecimalPlaces = 1;
            temperatureMUpDown.Location = new Point(310, 78);
            temperatureMUpDown.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            temperatureMUpDown.Minimum = new decimal(new int[] { 273, 0, 0, int.MinValue });
            temperatureMUpDown.Name = "temperatureMUpDown";
            temperatureMUpDown.Size = new Size(93, 27);
            temperatureMUpDown.TabIndex = 10;
            temperatureMUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 80);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 17;
            label6.Text = "conductivity";
            // 
            // conductivityUpDown
            // 
            conductivityUpDown.DecimalPlaces = 3;
            conductivityUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            conductivityUpDown.Location = new Point(109, 78);
            conductivityUpDown.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            conductivityUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            conductivityUpDown.Name = "conductivityUpDown";
            conductivityUpDown.Size = new Size(93, 27);
            conductivityUpDown.TabIndex = 16;
            conductivityUpDown.Value = new decimal(new int[] { 401, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 47);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 15;
            label7.Text = "heat capacity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 14);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 14;
            label8.Text = "density";
            // 
            // capacityUpDown
            // 
            capacityUpDown.DecimalPlaces = 3;
            capacityUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            capacityUpDown.Location = new Point(109, 45);
            capacityUpDown.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
            capacityUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            capacityUpDown.Name = "capacityUpDown";
            capacityUpDown.Size = new Size(93, 27);
            capacityUpDown.TabIndex = 13;
            capacityUpDown.Value = new decimal(new int[] { 385, 0, 0, 0 });
            // 
            // densityUpDown
            // 
            densityUpDown.DecimalPlaces = 1;
            densityUpDown.Location = new Point(109, 12);
            densityUpDown.Maximum = new decimal(new int[] { 14000, 0, 0, 0 });
            densityUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            densityUpDown.Name = "densityUpDown";
            densityUpDown.Size = new Size(93, 27);
            densityUpDown.TabIndex = 12;
            densityUpDown.Value = new decimal(new int[] { 8960, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(421, 14);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 19;
            label9.Text = "length";
            // 
            // lengthUpDown
            // 
            lengthUpDown.DecimalPlaces = 2;
            lengthUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            lengthUpDown.Location = new Point(529, 12);
            lengthUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            lengthUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            lengthUpDown.Name = "lengthUpDown";
            lengthUpDown.Size = new Size(93, 27);
            lengthUpDown.TabIndex = 18;
            lengthUpDown.Value = new decimal(new int[] { 2, 0, 0, 65536 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(421, 113);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 21;
            label10.Text = "time";
            // 
            // allTimeUpDown
            // 
            allTimeUpDown.DecimalPlaces = 1;
            allTimeUpDown.Increment = new decimal(new int[] { 1, 0, 0, 262144 });
            allTimeUpDown.Location = new Point(529, 111);
            allTimeUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            allTimeUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            allTimeUpDown.Name = "allTimeUpDown";
            allTimeUpDown.Size = new Size(93, 27);
            allTimeUpDown.TabIndex = 20;
            allTimeUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 210);
            label11.Name = "label11";
            label11.Size = new Size(149, 20);
            label11.TabIndex = 22;
            label11.Text = "Middle temperature: ";
            // 
            // middleTemp
            // 
            middleTemp.AutoSize = true;
            middleTemp.Location = new Point(167, 210);
            middleTemp.Name = "middleTemp";
            middleTemp.Size = new Size(17, 20);
            middleTemp.TabIndex = 23;
            middleTemp.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(middleTemp);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(allTimeUpDown);
            Controls.Add(label9);
            Controls.Add(lengthUpDown);
            Controls.Add(label6);
            Controls.Add(conductivityUpDown);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(capacityUpDown);
            Controls.Add(densityUpDown);
            Controls.Add(label5);
            Controls.Add(temperatureMUpDown);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(timeStepUpDown);
            Controls.Add(tileCountUpDown);
            Controls.Add(temperatureRUpDown);
            Controls.Add(temperatureLUpDown);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)temperatureLUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)temperatureRUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)tileCountUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeStepUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)temperatureMUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)conductivityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)lengthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)allTimeUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown temperatureLUpDown;
        private NumericUpDown temperatureRUpDown;
        private NumericUpDown tileCountUpDown;
        private NumericUpDown timeStepUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private NumericUpDown temperatureMUpDown;
        private Label label6;
        private NumericUpDown conductivityUpDown;
        private Label label7;
        private Label label8;
        private NumericUpDown capacityUpDown;
        private NumericUpDown densityUpDown;
        private Label label9;
        private NumericUpDown lengthUpDown;
        private Label label10;
        private NumericUpDown allTimeUpDown;
        private Label label11;
        private Label middleTemp;
    }
}
