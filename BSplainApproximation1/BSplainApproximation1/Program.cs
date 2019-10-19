using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace BSplainApproximation1
{
    class Field : Form
    {
        private Data Fun = new Data();
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox LogOutputBox;
        private CheckBox checkBox1;
        private Button button2;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogOutputBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Верхня межа у";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Нижня межа у";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "-10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість елементів";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "20";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 91);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.MarkerSize = 3;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1073, 558);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // LogOutputBox
            // 
            this.LogOutputBox.Location = new System.Drawing.Point(1092, 41);
            this.LogOutputBox.Multiline = true;
            this.LogOutputBox.Name = "LogOutputBox";
            this.LogOutputBox.Size = new System.Drawing.Size(250, 611);
            this.LogOutputBox.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1092, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Додатково";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Апроксимувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Порядок сплайна";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(389, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ступінь уточнення";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(389, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // Field
            // 
            this.ClientSize = new System.Drawing.Size(1354, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LogOutputBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Field";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Field()
        {
            InitializeComponent();
        }

        private void LogOutput(string target, bool additinoal)
        {
            if (!additinoal)
            { 
                LogOutputBox.Text += target + Environment.NewLine;
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            Fun.Clear();
            chart1.Series[1].Points.Clear();
            int N;
            double UpperBound;
            double LowerBound;
            try
            {
                N = Convert.ToInt32(textBox3.Text);
                if (N < 3 || N > 200)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutput("Wrong number of elements",false);
                return;
            }
            try
            {
                UpperBound = Convert.ToDouble(textBox1.Text);
                LowerBound = Convert.ToDouble(textBox2.Text);
                if (UpperBound < LowerBound)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutput("Wrong upper or lower bound", false);
                return;
            }
            Random a = new Random();
            int i = 0;
            for (i = 0; i < N; i++)
            {
                Fun.t.Add(i);
                Fun.p.Add(LowerBound+a.NextDouble()* (UpperBound - LowerBound));
            }
            Fun.SortByT();

            chart1.Series[0].Points.Clear();
            for (i = 0; i < N; i++)
            {
                chart1.Series[0].Points.AddXY(Fun.t[i], Fun.p[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            if (chart1.Series[0].Points.Count==0)
            {
                LogOutput("Спочатку згенеруйте точки", false);
                return;
            }
            int r;
            int u;
            try
            {
                r = Convert.ToInt32(textBox4.Text);
                u = Convert.ToInt32(textBox5.Text);
            }
            catch
            {
                LogOutput("Невірний ввід, порядок та ступінь уточнення сплайну мають бути цілими числами", false);
                return;
            }
            if (r < 0 || u < 0)
            {
                LogOutput("Невірний ввід, порядок та ступінь уточнення сплайну мають бути додатними", false);
                return;
            }
            if (r >= Fun.GammaMatrix.Count || u>= Fun.GammaMatrix[r].Count)
            {
                LogOutput("Сплайн такого порядку і ступеня уточнення не підтримуеться", false);
                return;
            }
            double Step = 1;
            double tempp, tempx;
            int j, i, k, l;
            if (r % 2 == 1)
            {
                for (i = (((r-1) / 2)) + u; i < Fun.p.Count - u - (((r-1) / 2))-1; i++)
                {
                    for (double x = -1; x < 1; x += 0.05)
                    {
                        tempx = 0;
                        for (j = 0; j < r + 1; j++)
                        {
                            tempp = 0;
                            for (k = -u - r / 2; k < r / 2 + 2 + u; k++)
                            {
                                tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[i + k] * Math.Pow(x, j);
                            }
                            tempx += tempp;
                        }
                        chart1.Series[1].Points.AddXY(Fun.t[i] + ((x+1) / 2) * Step, Fun.GammaMult[r][u] * tempx);
                    }
                }
            }
            else
            {
                for (i = ((r) / 2) + u; i < Fun.p.Count - u - ((r) / 2);i++)
                {
                    for (double x = -1; x < 1; x += 0.05)
                    {
                        tempx = 0;
                        for (j = 0; j < r + 1; j++)
                        {
                            tempp = 0;
                            for (k = -u-r/2; k < r/2 + 1 + u; k++)
                            {
                                tempp += Fun.GammaMatrix[r][u][k+u+r/2,j] *Fun.p[i + k] * Math.Pow(x,j);
                            }
                            tempx += tempp;
                        }
                        chart1.Series[1].Points.AddXY(Fun.t[i]+(x/2)*Step, Fun.GammaMult[r][u]*tempx);
                    }
                }
            }
            
        }
    }

    class Prыogram
    {
        static void Main(string[] args)
        {
            Field any = new Field();
            Application.Run(any);
        }
    }
}
