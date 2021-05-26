using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PBL3REAL.BLL;
using PBL3REAL.DAL;
using PBL3REAL.ViewModel;
using PBL3REAL.Extention;
namespace PBL3REAL.View
{
    public partial class Form_User_Profile : Form
    {
        private int ID = 0;
        private QLUserBLL qLUserBLL;
        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public Form_User_Profile(int id, string role, bool Editable)
        {
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
            ID = id;
            addToCbb();
            LoadData(role, Editable);
        }
        //Load Data
        private void addToCbb()
        {
            cbb_Role.DataSource = qLUserBLL.getRoleForUser();
            cbb_Role.DisplayMember = "RoleName";
        }
        private void LoadData(string role, bool Editable)
        {
            if (ID == 0)
            {
                //Add
                //Generate ID
            }    
            else
            {
                //View or Edit
                lb_Header.Text = "   " + QLUserBLL.stoUser.UserCode + "   ";
                tb_Username.Text = QLUserBLL.stoUser.UserName;
                tb_Email.Text = QLUserBLL.stoUser.UserGmail;
                tb_Password.Text = QLUserBLL.stoUser.UserPassword;
                tb_Phone.Text = QLUserBLL.stoUser.UserPhone;
                if (QLUserBLL.stoUser.UserGender)
                {
                    rbtn_Male.Checked = true;
                }
                else
                {
                    rbtn_Female.Checked = true;
                }
                cbb_Role.Text = role;
                cbb_Role.Enabled = false;
            }
            if (!Editable)
            {
                tb_Username.Enabled = false;
                tb_Password.Enabled = false;
                tb_Email.Enabled = false;
                tb_Phone.Enabled = false;
                rbtn_Male.Enabled = false;
                rbtn_Female.Enabled = false;
                btn_OK.Enabled = false;
                btn_Reset.Enabled = false;
                cbb_Role.Enabled = false;
                lbx_User.Visible = false;
                fllaypn_User.Visible = false;
            }
        }
        //Check Data
        private bool CheckVietNamChar(string s)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    if (s.Contains(VietNamChar[i][j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private int CheckData()
        {
            int phone = 0;
            if (tb_Username.Text == "" || tb_Email.Text == "" || tb_Password.Text == "" || tb_Phone.Text == "" 
                || (rbtn_Male.Checked == false && rbtn_Female.Checked == false))
            { return 0; }    
            if (int.TryParse(tb_Phone.Text,out phone) == false)
            { return 1; }
            if (tb_Email.Text.Contains(' ') == true || tb_Password.Text.Contains(' ') == true 
                || CheckVietNamChar(tb_Email.Text) == true || CheckVietNamChar(tb_Password.Text) == true)
            { return 2; }
            return 3;
        }
        //User Processing Functions
        private void ViewUser()
        {
            //UserVM userVM = UserBLL.findDetailUser(2);
            //string json = JsonConvert.SerializeObject(userVM, Formatting.Indented);
            //richTextBox1.Text = json;
        }
        private void AddUser()
        {
            UserVM userVM = qLUserBLL.getAll()[0];
            userVM.IdUser = 0; // Generate ???
            userVM.UserCode = "PhanTest"; // Generate
            userVM.UserName = tb_Username.Text.Replace(" ",String.Empty);
            userVM.UserPassword = tb_Password.Text.Replace(" ", String.Empty);
            userVM.UserGmail = tb_Email.Text.Replace(" ", String.Empty);
            userVM.UserPhone = tb_Phone.Text.Replace(" ", String.Empty);
            if (rbtn_Male.Checked)
            {
                userVM.UserGender = true;
            }
            else
            {
                userVM.UserGender = false;
            }
            userVM.ListRole.RemoveAt(0);
            userVM.ListImg.Clear();
            ImageVM imageVM = new ImageVM
            {
                ImgstoUrl = "/home/cuong/pro/vip/dangcap"
            };
            userVM.ListImg.Add(imageVM);
            qLUserBLL.addUser(userVM);
        }
        private void UpdateUserInfo()
        {
            UserVM temp = new UserVM();
            temp.UserName = tb_Username.Text.Replace(" ", String.Empty);
            temp.UserPassword = tb_Password.Text.Replace(" ", String.Empty);
            temp.UserGmail = tb_Email.Text.Replace(" ", String.Empty);
            temp.UserPhone = tb_Phone.Text.Replace(" ", String.Empty);
            if (rbtn_Male.Checked)
            {
                temp.UserGender = true;
            }
            else
            {
                temp.UserGender = false;
            }
            temp.UserCode = lb_Header.Text;
            RoleVM roleVM1 = new RoleVM
            {
                IdRole = 2
            };
            RoleVM roleVM2 = new RoleVM
            {
                IdRole = 3
            };
            temp.ListRole.Add(roleVM1);
            temp.ListRole.Add(roleVM2);
            qLUserBLL.updateUser(temp, null);
        }
        //Hàm tạo folder & insert ảnh
        public Image InsertIMG()
        {
            string palettesPath = "\\Properties\\Room_Type";
            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(palettesPath))
                {
                    System.IO.Directory.CreateDirectory(palettesPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
                MessageBox.Show("Error!");
            }
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(open.FileName);
            }
            return null;
        }
        //Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //Reset Data
            tb_Username.Text = "";
            tb_Email.Text = "";
            tb_Phone.Text = "";
            tb_Password.Text = "";
            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            cbb_Role.SelectedItem = null;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            //Check Data
            switch (CheckData())
            {
                case 0:
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show("Số điện thoại bạn nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show("Email hoặc mật khẩu bạn nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    if (ID == 0)
                    {
                        AddUser();
                        //Thông báo trả về thành công
                    }   
                    else
                    {
                        UpdateUserInfo();
                        //Thông báo trả về thành công
                    }
                    break;
                default:
                    break;
            }
        }
        private void picbx_Add_Click(object sender, EventArgs e)
        {
            //Add role 
            lbx_User.Items.Add(((CbbItem)cbb_Role.SelectedItem).text);
        }
        private void picbx_Delete_Click(object sender, EventArgs e)
        {
            //Delete role
            lbx_User.Items.RemoveAt(lbx_User.Items.Count-1);
        }
        private void picbx_Header_Click(object sender, EventArgs e)
        {
            //Change avatar
            picbx_Header.Image = InsertIMG();
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void picbx_Header_DoubleClick(object sender, EventArgs e)
        {
            //Reset to default
            picbx_Header.Image = Properties.Resources.male_user_fluent_color_96px;
            picbx_Header.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
