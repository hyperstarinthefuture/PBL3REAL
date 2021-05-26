using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.ViewModel;
namespace PBL3REAL.View
{
    public partial class Form_Staff : Form
    {
        private QLUserBLL qLUserBLL;
        private string LoggedRole;
        public Form_Staff(int id, string role)
        {
            InitializeComponent();
            LoggedRole = role;
            qLUserBLL = new QLUserBLL();
            LoadData();
        }
        //Load Data
        private void LoadData()
        {
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
            lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";
            switch(LoggedRole)
            {
                case "Receptionist":
                    btn_Work.Image = Properties.Resources.front_desk_fluent_color_96px;
                    btn_Work.Text = "Receptionist";
                    break;
                case "Clerk":
                    btn_Work.Image = Properties.Resources.accounting_96px;
                    break;
                default:
                    break;
            }    
        }
        //Events
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Form_User_Profile f = new Form_User_Profile(QLUserBLL.stoUser.IdUser, LoggedRole, false);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            switch(LoggedRole)
            {
                case "Receptionist":
                    Form_Receptionist f1 = new Form_Receptionist(QLUserBLL.stoUser.IdUser,LoggedRole);
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();
                    break;
                case "Clerk":
                    Form_Accountant f2 = new Form_Accountant();
                    this.Hide();
                    f2.ShowDialog();
                    this.Show();
                    break;
                default:
                    break;
            }    
        }
    }
}
