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
            Form_View_Statistic_Analyze f = new Form_View_Statistic_Analyze();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
