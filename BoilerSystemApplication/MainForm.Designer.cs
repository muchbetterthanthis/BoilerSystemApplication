namespace BrilliantApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.waterLimitStateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.reduceInputStreamButton = new System.Windows.Forms.Button();
            this.increaseInputStreamButton = new System.Windows.Forms.Button();
            this.preasureInputLabel = new System.Windows.Forms.Label();
            this.helpInputStreamLabel = new System.Windows.Forms.Label();
            this.helpWaterLavelLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.x10Button = new System.Windows.Forms.Button();
            this.x1Button = new System.Windows.Forms.Button();
            this.objectPictureBox = new System.Windows.Forms.PictureBox();
            this.x2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reduceOutputStreamButton = new System.Windows.Forms.Button();
            this.preasureOutputLabel = new System.Windows.Forms.Label();
            this.increaseOutputStreamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.waterLimitStateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // waterLimitStateChart
            // 
            chartArea2.Name = "ChartArea1";
            this.waterLimitStateChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.waterLimitStateChart.Legends.Add(legend2);
            this.waterLimitStateChart.Location = new System.Drawing.Point(592, 0);
            this.waterLimitStateChart.Name = "waterLimitStateChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Water level";
            this.waterLimitStateChart.Series.Add(series2);
            this.waterLimitStateChart.Size = new System.Drawing.Size(559, 353);
            this.waterLimitStateChart.TabIndex = 1;
            this.waterLimitStateChart.Text = "chart1";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(164, 321);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(13, 13);
            this.waterLevelLabel.TabIndex = 6;
            this.waterLevelLabel.Text = "0";
            // 
            // reduceInputStreamButton
            // 
            this.reduceInputStreamButton.Location = new System.Drawing.Point(379, 26);
            this.reduceInputStreamButton.Name = "reduceInputStreamButton";
            this.reduceInputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.reduceInputStreamButton.TabIndex = 8;
            this.reduceInputStreamButton.Text = "<";
            this.reduceInputStreamButton.UseVisualStyleBackColor = true;
            this.reduceInputStreamButton.Click += new System.EventHandler(this.reducePreasureButton_Click);
            // 
            // increaseInputStreamButton
            // 
            this.increaseInputStreamButton.Location = new System.Drawing.Point(450, 26);
            this.increaseInputStreamButton.Name = "increaseInputStreamButton";
            this.increaseInputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.increaseInputStreamButton.TabIndex = 9;
            this.increaseInputStreamButton.Text = ">";
            this.increaseInputStreamButton.UseVisualStyleBackColor = true;
            this.increaseInputStreamButton.Click += new System.EventHandler(this.increasePreasureButton_Click);
            // 
            // preasureInputLabel
            // 
            this.preasureInputLabel.AutoSize = true;
            this.preasureInputLabel.Location = new System.Drawing.Point(422, 31);
            this.preasureInputLabel.Name = "preasureInputLabel";
            this.preasureInputLabel.Size = new System.Drawing.Size(13, 13);
            this.preasureInputLabel.TabIndex = 10;
            this.preasureInputLabel.Text = "0";
            // 
            // helpInputStreamLabel
            // 
            this.helpInputStreamLabel.AutoSize = true;
            this.helpInputStreamLabel.Location = new System.Drawing.Point(390, 9);
            this.helpInputStreamLabel.Name = "helpInputStreamLabel";
            this.helpInputStreamLabel.Size = new System.Drawing.Size(91, 13);
            this.helpInputStreamLabel.TabIndex = 11;
            this.helpInputStreamLabel.Text = "INPUT STREAM:";
            // 
            // helpWaterLavelLabel
            // 
            this.helpWaterLavelLabel.AutoSize = true;
            this.helpWaterLavelLabel.Location = new System.Drawing.Point(64, 321);
            this.helpWaterLavelLabel.Name = "helpWaterLavelLabel";
            this.helpWaterLavelLabel.Size = new System.Drawing.Size(64, 13);
            this.helpWaterLavelLabel.TabIndex = 12;
            this.helpWaterLavelLabel.Text = "Water level:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 363);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 69);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(182, 363);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(140, 73);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(354, 364);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(140, 72);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // x10Button
            // 
            this.x10Button.Location = new System.Drawing.Point(1011, 366);
            this.x10Button.Name = "x10Button";
            this.x10Button.Size = new System.Drawing.Size(140, 73);
            this.x10Button.TabIndex = 19;
            this.x10Button.Text = "Speed x10";
            this.x10Button.UseVisualStyleBackColor = true;
            this.x10Button.Click += new System.EventHandler(this.x10Button_Click);
            // 
            // x1Button
            // 
            this.x1Button.Location = new System.Drawing.Point(592, 366);
            this.x1Button.Name = "x1Button";
            this.x1Button.Size = new System.Drawing.Size(140, 74);
            this.x1Button.TabIndex = 21;
            this.x1Button.Text = "Speed x1";
            this.x1Button.UseVisualStyleBackColor = true;
            this.x1Button.Click += new System.EventHandler(this.x1Button_Click);
            // 
            // objectPictureBox
            // 
            this.objectPictureBox.Image = global::BrilliantApplication.Properties.Resources.Boiler;
            this.objectPictureBox.Location = new System.Drawing.Point(-9, 0);
            this.objectPictureBox.Name = "objectPictureBox";
            this.objectPictureBox.Size = new System.Drawing.Size(509, 353);
            this.objectPictureBox.TabIndex = 0;
            this.objectPictureBox.TabStop = false;
            // 
            // x2Button
            // 
            this.x2Button.Location = new System.Drawing.Point(802, 366);
            this.x2Button.Name = "x2Button";
            this.x2Button.Size = new System.Drawing.Size(140, 74);
            this.x2Button.TabIndex = 25;
            this.x2Button.Text = "Speed x2";
            this.x2Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "OUTPUT STREAM:";
            // 
            // reduceOutputStreamButton
            // 
            this.reduceOutputStreamButton.Location = new System.Drawing.Point(379, 77);
            this.reduceOutputStreamButton.Name = "reduceOutputStreamButton";
            this.reduceOutputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.reduceOutputStreamButton.TabIndex = 28;
            this.reduceOutputStreamButton.Text = "<";
            this.reduceOutputStreamButton.UseVisualStyleBackColor = true;
            this.reduceOutputStreamButton.Click += new System.EventHandler(this.reduceOutputStreamButton_Click);
            // 
            // preasureOutputLabel
            // 
            this.preasureOutputLabel.AutoSize = true;
            this.preasureOutputLabel.Location = new System.Drawing.Point(422, 82);
            this.preasureOutputLabel.Name = "preasureOutputLabel";
            this.preasureOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.preasureOutputLabel.TabIndex = 29;
            this.preasureOutputLabel.Text = "0";
            // 
            // increaseOutputStreamButton
            // 
            this.increaseOutputStreamButton.Location = new System.Drawing.Point(450, 77);
            this.increaseOutputStreamButton.Name = "increaseOutputStreamButton";
            this.increaseOutputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.increaseOutputStreamButton.TabIndex = 30;
            this.increaseOutputStreamButton.Text = ">";
            this.increaseOutputStreamButton.UseVisualStyleBackColor = true;
            this.increaseOutputStreamButton.Click += new System.EventHandler(this.increaseOutputStreamButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 524);
            this.Controls.Add(this.increaseOutputStreamButton);
            this.Controls.Add(this.preasureOutputLabel);
            this.Controls.Add(this.reduceOutputStreamButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x2Button);
            this.Controls.Add(this.x1Button);
            this.Controls.Add(this.x10Button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.helpWaterLavelLabel);
            this.Controls.Add(this.helpInputStreamLabel);
            this.Controls.Add(this.preasureInputLabel);
            this.Controls.Add(this.increaseInputStreamButton);
            this.Controls.Add(this.reduceInputStreamButton);
            this.Controls.Add(this.waterLevelLabel);
            this.Controls.Add(this.waterLimitStateChart);
            this.Controls.Add(this.objectPictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.waterLimitStateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox objectPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart waterLimitStateChart;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Button reduceInputStreamButton;
        private System.Windows.Forms.Button increaseInputStreamButton;
        private System.Windows.Forms.Label preasureInputLabel;
        private System.Windows.Forms.Label helpInputStreamLabel;
        private System.Windows.Forms.Label helpWaterLavelLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button x10Button;
        private System.Windows.Forms.Button x1Button;
        private System.Windows.Forms.Button x2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reduceOutputStreamButton;
        private System.Windows.Forms.Label preasureOutputLabel;
        private System.Windows.Forms.Button increaseOutputStreamButton;
    }
}

