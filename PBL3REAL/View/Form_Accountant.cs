using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PBL3REAL.View
{
    public partial class Form_Accountant : Form
    {
        public Form_Accountant()
        {
            InitializeComponent();
            dtp_From.Enabled = false;
            dtp_To.Enabled = false;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch (cbb_PeriodTime.SelectedIndex) 
            {
                case 0:
                    Form_View_Statistic_Analyze f1 = new Form_View_Statistic_Analyze(DateTime.Now.AddDays(-7), DateTime.Now);
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                    break;
                case 1:
                    Form_View_Statistic_Analyze f2 = new Form_View_Statistic_Analyze(DateTime.Now.AddDays(-30), DateTime.Now);
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    Form_View_Statistic_Analyze f3 = new Form_View_Statistic_Analyze(dtp_From.Value,dtp_To.Value);
                    this.Hide();
                    f3.ShowDialog();
                    this.Show();
                    break;
                default:
                    break;
            }
        }
        private void cbb_PeriodTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_PeriodTime.SelectedIndex == 2) { dtp_From.Enabled = true; dtp_To.Enabled = true; }
        }
    }
}
