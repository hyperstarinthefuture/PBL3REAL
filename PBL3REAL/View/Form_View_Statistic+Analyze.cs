using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.Extention;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.ViewModel;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Data.SqlClient;
namespace PBL3REAL.View
{
    public partial class Form_View_Statistic_Analyze : Form
    {
        private System.ComponentModel.IContainer componentsTEMP = null;
        System.Windows.Forms.DataVisualization.Charting.Chart C1;
        QLInvoiceBLL invoiceBLL;
        List<Statistic_InvoiceVM> listVM;
        public Form_View_Statistic_Analyze(/*DateTime from, DateTime to*/)
        {
            InitializeComponent();
            C1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            //this.componentsTEMP = new System.ComponentModel.Container();
            //System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            //System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            //this.C1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            //((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            //this.SuspendLayout();
            ////
            //// chart1
            ////
            //chartArea1.Name = "ChartArea1";
            //this.C1.ChartAreas.Add(chartArea1);
            //this.C1.Dock = System.Windows.Forms.DockStyle.Fill;
            //legend1.Name = "Legend1";
            //this.C1.Legends.Add(legend1);
            //this.C1.Location = new System.Drawing.Point(20, 20);
            //this.C1.Name = "chart1";
            //// this.chart1.Size = new System.Drawing.Size(284, 212);
            //this.C1.TabIndex = 0;
            //this.C1.Text = "chart1";
            //this.Load += new System.EventHandler(this.Form_View_Statistic_Analyze_Load);
            //((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            //this.ResumeLayout(false);
            //C1.Series.Clear();

            //var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            //{
            //    Name = "Total",
            //    Color = System.Drawing.Color.Green,
            //    IsVisibleInLegend = false,
            //    IsXValueIndexed = true,
            //    ChartType = SeriesChartType.Line
            //};


            //this.C1.Series.Add(series1);
            //C1.Invalidate();
            invoiceBLL = new QLInvoiceBLL();
            listVM = invoiceBLL.findForStatistic(Convert.ToDateTime("2021-04-28"), Convert.ToDateTime("2021-05-10"));
            dgv_Booking.DataSource = listVM;
            //FillChart();
            grbx_Statistic.Visible = false;
            chart1.DataSource = listVM;
            chart1.Series.Add("Income");
            chart1.Series["Income"].XValueMember = "Date";
            chart1.Series["Income"].YValueMembers = "TotalByDate";
            chart1.Visible = true;
            //this.C1.SaveImage(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\chart.png", ChartImageFormat.Png);
            //this.C1.
        }
        public void statistics(string query, int type)
        {
            //int len = dt.Rows.Count;
            //if (len == 0)
            //{
            //    MessageBox.Show("Không có giao dịch trong khoảng thời gian này!", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
            //double[] ArrDb = new double[len];
            //int d;
            //if (type == 1)
            //{
            //    d = 1;
            //}
            //else
            //{
            //    d = -1;
            //}
            //for (int i = 0; i < len; i++)
            //{
            //    DataRow dr = dt.Rows[i];
            //    ArrDb[i] = Double.Parse(dr.ItemArray[0].ToString()) * d;
            //}
            //MaxHeap stc = new MaxHeap(ArrDb, len);
            //foreach (DataRow item in dt.Rows)
            //{
            //    if (Double.Parse(item.ItemArray[0].ToString()) == d * (stc.Maximum()))
            //    {
            //        Tbx1.Text = item.ItemArray[0].ToString();
            //        Tbx2.Text = item.ItemArray[1].ToString();
            //        Tbx3.Text = item.ItemArray[2].ToString();
            //    }
            //}
        }
        public void FillChart()
        {
            C1.DataSource = listVM;
            C1.Series.Add("Income");
            C1.Series["Income"].XValueMember = "Date";
            C1.Series["Income"].YValueMembers = "TotalByDate";
            //if (type == 1)
            //{
            //    C1.Series["Series1"].XValueMember = "Ngày";
            //    C1.Series["Series1"].YValueMembers = "Số tiền đã thu";
            //}
            //else
            //{
            //    C1.Series["Series1"].XValueMember = "Mục đích chi tiêu";
            //    C1.Series["Series1"].YValueMembers = "Số tiền đã chi";
            //}
            C1.Series["Income"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


        }
        public class MaxHeap
        {
            public MaxHeap(double[] input, int length)
            {
                this.Length = length;
                this.Array = input;
                BuildMaxHeap();
            }
            public double[] Array { get; private set; }
            public int Length { get; private set; }
            private void BuildMaxHeap()
            {
                for (int i = this.Length / 2; i > 0; i--)
                {
                    MaxHeapify(i);
                }
                return;
            }
            public void MaxHeapify(int index)
            {
                var left = 2 * index;
                var right = 2 * index + 1;
                int max = index;
                if (left <= this.Length && this.Array[left - 1] > this.Array[index - 1])
                {
                    max = left;
                }
                if (right <= this.Length && this.Array[right - 1] > this.Array[max - 1])
                {
                    max = right;
                }
                if (max != index)
                {
                    double temp = this.Array[max - 1];
                    this.Array[max - 1] = this.Array[index - 1];
                    this.Array[index - 1] = temp;
                    MaxHeapify(max);
                }
                return;
            }
            public double Maximum()
            {
                return this.Array[0];
            }
            public string rs;
            public string pointtime;
            public int len;
        }

        private void Form_View_Statistic_Analyze_Load(object sender, EventArgs e)
        {

        }
    }
}
