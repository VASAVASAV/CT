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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Button button3;
        private TabPage tabPage3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBox9;
        private Label label9;
        private Button button5;
        private Label label10;
        private TextBox textBox10;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Згенерувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Верхня межа у";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Нижня межа у";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "-10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кількість елементів";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 58);
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
            this.chart1.Location = new System.Drawing.Point(13, 137);
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
            this.chart1.Size = new System.Drawing.Size(1073, 550);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // LogOutputBox
            // 
            this.LogOutputBox.Location = new System.Drawing.Point(1092, 88);
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
            this.button2.Location = new System.Drawing.Point(895, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Апроксимувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Порядок сплайна";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(515, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ступінь уточнення";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(515, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 119);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 93);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Рівномірний сплайн";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 93);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Нерівномірний сплайн";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Нижня межа у";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(9, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Верхня межа у";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "-10";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(9, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Кількість елементів";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 81);
            this.button3.TabIndex = 7;
            this.button3.Text = "Згенерувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(488, 93);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Зіронька";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(378, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 87);
            this.button4.TabIndex = 13;
            this.button4.Text = "Згенерувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 60);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            this.textBox9.Text = "5";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Кількість вершин";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(738, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 69);
            this.button5.TabIndex = 16;
            this.button5.Text = "Регуляризація";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(621, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "кроків регуляризації";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(515, 93);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 17;
            // 
            // Field
            // 
            this.ClientSize = new System.Drawing.Size(1354, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LogOutputBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Name = "Field";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
            Fun.mode = Mode.Standard;
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
                LogOutput("Wrong number of elements", false);
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
                Fun.p.Add(LowerBound + a.NextDouble() * (UpperBound - LowerBound));
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
            if (chart1.Series[0].Points.Count == 0)
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
            if (r >= Fun.GammaMatrix.Count || u >= Fun.GammaMatrix[r].Count)
            {
                LogOutput("Сплайн такого порядку і ступеня уточнення не підтримуеться", false);
                return;
            }
            double Step = 1;
            double tempp, tempx;
            switch (Fun.mode)
            {
                case Mode.Standard:
                    {
                        int j, i, k, l;
                        if (r % 2 == 1)
                        {
                            for (i = (((r - 1) / 2)) + u; i < Fun.p.Count - u - (((r - 1) / 2)) - 1; i++)
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
                                    chart1.Series[1].Points.AddXY(Fun.t[i] + ((x + 1) / 2) * Step, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        else
                        {
                            for (i = ((r) / 2) + u; i < Fun.p.Count - u - ((r) / 2); i++)
                            {
                                for (double x = -1; x < 1; x += 0.05)
                                {
                                    tempx = 0;
                                    for (j = 0; j < r + 1; j++)
                                    {
                                        tempp = 0;
                                        for (k = -u - r / 2; k < r / 2 + 1 + u; k++)
                                        {
                                            tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[i + k] * Math.Pow(x, j);
                                        }
                                        tempx += tempp;
                                    }
                                    chart1.Series[1].Points.AddXY(Fun.t[i] + (x / 2) * Step, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        break;
                    }
                case Mode.NotEquidistant:
                    {
                        double tempp1, tempx1;
                        Data Temp1 = new Data();
                        Data Temp2 = new Data();
                        int j, i, k, l;
                        if (r % 2 == 1)
                        {
                            for (i = (((r - 1) / 2)) + u; i < Fun.p.Count - u - (((r - 1) / 2)) - 1; i++)
                            {
                                for (double x = -1; x < 1; x += 0.05)
                                {
                                    tempx = 0;
                                    tempx1 = 0;
                                    for (j = 0; j < r + 1; j++)
                                    {
                                        tempp1 = 0;
                                        tempp = 0;
                                        for (k = -u - r / 2; k < r / 2 + 2 + u; k++)
                                        {
                                            tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[i + k] * Math.Pow(x, j);
                                            tempp1 += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.t[i + k] * Math.Pow(x, j);
                                        }
                                        tempx += tempp;
                                        tempx1 += tempp1;
                                    }
                                    chart1.Series[1].Points.AddXY(Fun.GammaMult[r][u] * tempx1, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        else
                        {
                            for (i = ((r) / 2) + u; i < Fun.p.Count - u - ((r) / 2); i++)
                            {
                                for (double x = -1; x < 1; x += 0.05)
                                {
                                    tempx = 0;
                                    tempx1 = 0;
                                    for (j = 0; j < r + 1; j++)
                                    {
                                        tempp1 = 0;
                                        tempp = 0;
                                        for (k = -u - r / 2; k < r / 2 + 1 + u; k++)
                                        {
                                            tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[i + k] * Math.Pow(x, j);
                                            tempp1 += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.t[i + k] * Math.Pow(x, j);
                                        }
                                        tempx += tempp;
                                        tempx1 += tempp1;
                                    }
                                    chart1.Series[1].Points.AddXY(Fun.GammaMult[r][u] * tempx1, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        break;
                    }
                case Mode.Star:
                    {
                        int j, i, k, l;
                        Fun.mode = Mode.Star;
                        //chart1.Series[0].Points.Clear();
                        int Num;
                        try
                        {
                            Num = Convert.ToInt32(textBox9.Text);
                            if (Num < 2 || Num > 50)
                            {
                                throw new Exception();
                            }
                        }
                        catch
                        {
                            LogOutput("Wrong number of pikes", false);
                            return;
                        }
                        double step = (Math.PI) / Num;
                        Fun.Clear();
                        int PointNum;
                        for (i = 0; i < Num; i++)
                        {

                            try
                            {
                                PointNum = Convert.ToInt32(dataGridView1.Rows[0].Cells[2 * i].Value);
                                if (PointNum < 0)
                                    throw new Exception();
                            }
                            catch
                            {
                                PointNum = 1;
                            }
                            for (j = 0; j < PointNum; j++)
                            {
                                Fun.p.Add(Math.Sin(step * 2 * i));
                                Fun.t.Add(Math.Cos(step * 2 * i));
                            }
                            try
                            {
                                PointNum = Convert.ToInt32(dataGridView1.Rows[0].Cells[2 * i + 1].Value);
                                if (PointNum < 0)
                                    throw new Exception();
                            }
                            catch
                            {
                                PointNum = 1;
                            }
                            for (j = 0; j < PointNum; j++)
                            {
                                Fun.p.Add(Math.Sin(step * (2 * i + 1)) / 2);
                                Fun.t.Add(Math.Cos(step * (2 * i + 1)) / 2);
                            }
                        }
                        double tempp1, tempx1;
                        Data Temp1 = new Data();
                        Data Temp2 = new Data();
                        if (r % 2 == 1)
                        {
                            for (i = 0; i < Fun.p.Count + 1; i++)
                            {
                                for (double x = -1; x < 1; x += 0.05)
                                {
                                    tempx = 0;
                                    tempx1 = 0;
                                    for (j = 0; j < r + 1; j++)
                                    {
                                        tempp1 = 0;
                                        tempp = 0;
                                        for (k = -u - r / 2; k < r / 2 + 2 + u; k++)
                                        {
                                            tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[(i + k + Fun.p.Count * 5) % Fun.p.Count] * Math.Pow(x, j);
                                            tempp1 += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.t[(i + k + Fun.p.Count * 5) % Fun.p.Count] * Math.Pow(x, j);
                                        }
                                        tempx += tempp;
                                        tempx1 += tempp1;
                                    }
                                    chart1.Series[1].Points.AddXY(Fun.GammaMult[r][u] * tempx1, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        else
                        {
                            for (i = 0; i < Fun.p.Count + 1; i++)
                            {
                                for (double x = -1; x < 1; x += 0.05)
                                {
                                    tempx = 0;
                                    tempx1 = 0;
                                    for (j = 0; j < r + 1; j++)
                                    {
                                        tempp1 = 0;
                                        tempp = 0;
                                        for (k = -u - r / 2; k < r / 2 + 1 + u; k++)
                                        {
                                            tempp += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.p[(i + k + Fun.p.Count * 5) % Fun.p.Count] * Math.Pow(x, j);
                                            tempp1 += Fun.GammaMatrix[r][u][k + u + r / 2, j] * Fun.t[(i + k + Fun.p.Count * 5) % Fun.p.Count] * Math.Pow(x, j);
                                        }
                                        tempx += tempp;
                                        tempx1 += tempp1;
                                    }
                                    chart1.Series[1].Points.AddXY(Fun.GammaMult[r][u] * tempx1, Fun.GammaMult[r][u] * tempx);
                                }
                            }
                        }
                        break;
                    }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fun.Clear();
            Fun.mode = Mode.NotEquidistant;
            chart1.Series[1].Points.Clear();
            int N;
            double UpperBound;
            double LowerBound;
            try
            {
                N = Convert.ToInt32(textBox8.Text);
                if (N < 3 || N > 200)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutput("Wrong number of elements", false);
                return;
            }
            try
            {
                UpperBound = Convert.ToDouble(textBox6.Text);
                LowerBound = Convert.ToDouble(textBox7.Text);
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
                Fun.t.Add(a.NextDouble() * (N));
                Fun.p.Add(LowerBound + a.NextDouble() * (UpperBound - LowerBound));
            }
            Fun.SortByT();
            chart1.Series[0].Points.Clear();
            for (i = 0; i < N; i++)
            {
                chart1.Series[0].Points.AddXY(Fun.t[i], Fun.p[i]);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int Num;
            try
            {
                Num = Convert.ToInt32(textBox9.Text);
                if (Num < 2 || Num > 50)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutput("Wrong number of pikes", false);
                return;
            }
            for (int i = 0; i < Num; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[2 * i].HeaderText = "" + (i + 1) + "↑";
                dataGridView1.Columns[2 * i].Width = 30;
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Columns[2 * i + 1].HeaderText = "" + (i + 1) + "↓";
                dataGridView1.Columns[2 * i + 1].Width = 30;
            }
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].HeaderText = "" + (1) + "↑";
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Width = 30;
            dataGridView1.Rows.Add();
            for (int i = 0; i < Num; i++)
            {
                dataGridView1.Rows[0].Cells[2 * i].Value = "1";
                dataGridView1.Rows[0].Cells[2 * i + 1].Value = "1";
            }
            dataGridView1.Rows[0].Cells[dataGridView1.Columns.Count - 1].Value = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fun.mode = Mode.Star;
            chart1.Series[0].Points.Clear();
            int Num;
            try
            {
                Num = Convert.ToInt32(textBox9.Text);
                if (Num < 2 || Num > 50)
                {
                    throw new Exception();
                }
            }
            catch
            {
                LogOutput("Wrong number of pikes", false);
                return;
            }
            double step = (Math.PI) / Num;
            for (int i = 0; i < Num; i++)
            {
                chart1.Series[0].Points.AddXY(Math.Cos(step * 2 * i), Math.Sin(step * 2 * i));
                chart1.Series[0].Points.AddXY(Math.Cos(step * (2 * i + 1)) / 2, Math.Sin(step * (2 * i + 1)) / 2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            if (chart1.Series[0].Points.Count == 0)
            {
                LogOutput("Спочатку згенеруйте точки", false);
                return;
            }
            int Step;
            try
            {
                Step = Convert.ToInt32(textBox10.Text);
                if (Step < 0 || Step > 12)
                    throw new Exception();
            }
            catch
            {
                LogOutput("Неправильна кількість ітерацій", false);
                return;
            }
            List<List<double>> approxp = new List<List<double>>;
            List<List<double> > approxt = new List<List<double>>];
            List<Tuple<double, double>> localpt = new List<Tuple<double, double>>();
            for (int i = 0; i < Fun.p.Count; i++)
            {
                localpt.Add(new Tuple<double, double>(Fun.t[i], Fun.p[i]));
            }
            localpt=localpt.OrderBy(x=>x.Item1).ToList();
            for (int i = 0; i < localpt.Count; i++)
            {
                approxp[0].Add(localpt[i].Item2);
                approxt[0].Add(localpt[i].Item1);
            }
            //Count number of entries on each smallest step
            for (i)
            {

            }
            for (int i = Step - 1; i > 0; i--)
            {
                
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
