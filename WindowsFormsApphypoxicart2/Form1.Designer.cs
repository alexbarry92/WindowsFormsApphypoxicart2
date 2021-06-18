namespace WindowsFormsApphypoxicart2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SpPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testtext = new System.Windows.Forms.Label();
            this.hypbut = new System.Windows.Forms.Button();
            this.normbut = new System.Windows.Forms.Button();
            this.begin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.etime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_portnames = new System.Windows.Forms.ComboBox();
            this.comRefresh = new System.Windows.Forms.Button();
            this.protocolBox = new System.Windows.Forms.ComboBox();
            this.prText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.inText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SpGain = new System.Windows.Forms.NumericUpDown();
            this.iO2Gain = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pulseGain = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.inPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelmode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iO2Gain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // SpPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.SpPlot.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.SpPlot.Legends.Add(legend1);
            this.SpPlot.Location = new System.Drawing.Point(12, 31);
            this.SpPlot.Name = "SpPlot";
            this.SpPlot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueMembers = "testtext.toint()";
            this.SpPlot.Series.Add(series1);
            this.SpPlot.Size = new System.Drawing.Size(486, 192);
            this.SpPlot.TabIndex = 0;
            this.SpPlot.Text = "chart1";
            this.SpPlot.Click += new System.EventHandler(this.SpPlot_Click);
            // 
            // testtext
            // 
            this.testtext.AutoSize = true;
            this.testtext.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testtext.Location = new System.Drawing.Point(505, 52);
            this.testtext.Name = "testtext";
            this.testtext.Size = new System.Drawing.Size(66, 15);
            this.testtext.TabIndex = 1;
            this.testtext.Text = "SpO2 Value";
            this.testtext.Click += new System.EventHandler(this.testtext_Click);
            // 
            // hypbut
            // 
            this.hypbut.Location = new System.Drawing.Point(504, 234);
            this.hypbut.Name = "hypbut";
            this.hypbut.Size = new System.Drawing.Size(131, 23);
            this.hypbut.TabIndex = 2;
            this.hypbut.Text = "Switch To Hypoxia";
            this.hypbut.UseVisualStyleBackColor = true;
            this.hypbut.Click += new System.EventHandler(this.hypbut_Click);
            // 
            // normbut
            // 
            this.normbut.Enabled = false;
            this.normbut.Location = new System.Drawing.Point(504, 263);
            this.normbut.Name = "normbut";
            this.normbut.Size = new System.Drawing.Size(131, 23);
            this.normbut.TabIndex = 3;
            this.normbut.Text = "Switch To Normoxia";
            this.normbut.UseVisualStyleBackColor = true;
            this.normbut.Click += new System.EventHandler(this.normbut_Click);
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(647, 413);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(130, 23);
            this.begin.TabIndex = 4;
            this.begin.Text = "Begin Session";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SpO2 level";
            // 
            // etime
            // 
            this.etime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etime.Location = new System.Drawing.Point(641, 133);
            this.etime.Name = "etime";
            this.etime.Size = new System.Drawing.Size(136, 23);
            this.etime.TabIndex = 6;
            this.etime.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.etime.Click += new System.EventHandler(this.etime_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(638, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Elapsed Time";
            // 
            // comboBox_portnames
            // 
            this.comboBox_portnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portnames.FormattingEnabled = true;
            this.comboBox_portnames.Location = new System.Drawing.Point(641, 170);
            this.comboBox_portnames.Name = "comboBox_portnames";
            this.comboBox_portnames.Size = new System.Drawing.Size(136, 21);
            this.comboBox_portnames.TabIndex = 8;
            // 
            // comRefresh
            // 
            this.comRefresh.Location = new System.Drawing.Point(645, 200);
            this.comRefresh.Name = "comRefresh";
            this.comRefresh.Size = new System.Drawing.Size(132, 23);
            this.comRefresh.TabIndex = 9;
            this.comRefresh.Text = "Refresh COM Ports";
            this.comRefresh.UseVisualStyleBackColor = true;
            this.comRefresh.Click += new System.EventHandler(this.comRefresh_Click);
            // 
            // protocolBox
            // 
            this.protocolBox.FormattingEnabled = true;
            this.protocolBox.Items.AddRange(new object[] {
            "Active",
            "Sham"});
            this.protocolBox.Location = new System.Drawing.Point(658, 23);
            this.protocolBox.Name = "protocolBox";
            this.protocolBox.Size = new System.Drawing.Size(130, 21);
            this.protocolBox.TabIndex = 10;
            this.protocolBox.Visible = false;
            // 
            // prText
            // 
            this.prText.AutoSize = true;
            this.prText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prText.Location = new System.Drawing.Point(504, 331);
            this.prText.Name = "prText";
            this.prText.Size = new System.Drawing.Size(65, 15);
            this.prText.TabIndex = 11;
            this.prText.Text = "Pulse Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pulse Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "% SpO2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prPlot
            // 
            chartArea2.Name = "ChartArea1";
            this.prPlot.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.prPlot.Legends.Add(legend2);
            this.prPlot.Location = new System.Drawing.Point(12, 263);
            this.prPlot.Name = "prPlot";
            this.prPlot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValueMembers = "testtext.toint()";
            this.prPlot.Series.Add(series2);
            this.prPlot.Size = new System.Drawing.Size(486, 173);
            this.prPlot.TabIndex = 14;
            this.prPlot.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pulse Rate";
            // 
            // inText
            // 
            this.inText.AutoSize = true;
            this.inText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inText.Location = new System.Drawing.Point(504, 562);
            this.inText.Name = "inText";
            this.inText.Size = new System.Drawing.Size(93, 15);
            this.inText.TabIndex = 16;
            this.inText.Text = "Inspired O2 Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Inspired O2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "End Session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpGain
            // 
            this.SpGain.Location = new System.Drawing.Point(575, 52);
            this.SpGain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpGain.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.SpGain.Name = "SpGain";
            this.SpGain.Size = new System.Drawing.Size(60, 20);
            this.SpGain.TabIndex = 19;
            // 
            // iO2Gain
            // 
            this.iO2Gain.Location = new System.Drawing.Point(575, 560);
            this.iO2Gain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iO2Gain.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.iO2Gain.Name = "iO2Gain";
            this.iO2Gain.Size = new System.Drawing.Size(60, 20);
            this.iO2Gain.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "SpO2 gain";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(578, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "InO2 gain";
            // 
            // pulseGain
            // 
            this.pulseGain.Location = new System.Drawing.Point(575, 330);
            this.pulseGain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pulseGain.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.pulseGain.Name = "pulseGain";
            this.pulseGain.Size = new System.Drawing.Size(60, 20);
            this.pulseGain.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pulse gain";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Delivered O2";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // inPlot
            // 
            chartArea3.Name = "ChartArea1";
            this.inPlot.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.inPlot.Legends.Add(legend3);
            this.inPlot.Location = new System.Drawing.Point(12, 480);
            this.inPlot.Name = "inPlot";
            this.inPlot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValueMembers = "testtext.toint()";
            this.inPlot.Series.Add(series3);
            this.inPlot.Size = new System.Drawing.Size(486, 173);
            this.inPlot.TabIndex = 26;
            this.inPlot.Text = "chart1";
            // 
            // labelmode
            // 
            this.labelmode.AutoSize = true;
            this.labelmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmode.Location = new System.Drawing.Point(506, 604);
            this.labelmode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelmode.Name = "labelmode";
            this.labelmode.Size = new System.Drawing.Size(205, 29);
            this.labelmode.TabIndex = 27;
            this.labelmode.Text = "Mode: Normoxia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.labelmode);
            this.Controls.Add(this.inPlot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pulseGain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iO2Gain);
            this.Controls.Add(this.SpGain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prPlot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prText);
            this.Controls.Add(this.protocolBox);
            this.Controls.Add(this.comRefresh);
            this.Controls.Add(this.comboBox_portnames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.normbut);
            this.Controls.Add(this.hypbut);
            this.Controls.Add(this.testtext);
            this.Controls.Add(this.SpPlot);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Hypoxicart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SpPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iO2Gain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SpPlot;
        private System.Windows.Forms.Label testtext;
        private System.Windows.Forms.Button hypbut;
        private System.Windows.Forms.Button normbut;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label etime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_portnames;
        private System.Windows.Forms.Button comRefresh;
        private System.Windows.Forms.ComboBox protocolBox;
        private System.Windows.Forms.Label prText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart prPlot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label inText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown SpGain;
        private System.Windows.Forms.NumericUpDown iO2Gain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown pulseGain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart inPlot;
        private System.Windows.Forms.Label labelmode;
    }
}

