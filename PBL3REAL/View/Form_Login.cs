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
    public partial class Form_Login : Form
    {
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
        public Form_Login()
        {
            InitializeComponent();
            qLUserBLL = new QLUserBLL();
        }
        //Check Data 
        //Solution: (https://)itexpress.vn/tin-tuc/loc-dau-tieng-viet-trong-c-va-javascript-160.html
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
        private bool CheckData()
        {
            if (tb_UserCode.Text.Contains(' ') == true || tb_Password.Text.Contains(' ') == true || CheckVietNamChar(tb_UserCode.Text) == true
                || CheckVietNamChar(tb_Password.Text) == true || tb_UserCode.Text.Length == 0 || tb_Password.Text.Length == 0)
            { return false; }
            return true;
        }
        private bool CheckUser()
        {
            bool check = false;
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("code", tb_UserCode.Text);
            properties.Add("password", tb_Password.Text);
            try
            {
                UserVM userVM = qLUserBLL.checkUser(properties);
                if (userVM != null)
                {
                    QLUserBLL.stoUser = userVM;
                    check = true;
                }
            }
            catch (Exception) {}
            return check;
        }
        //Events
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Check Data
            if (CheckData())
            {
                //Gọi hàm kiểm tra & cho phép đăng nhập
                if (CheckUser())
                {
                    Form_Switch_Role f = new Form_Switch_Role();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Mã tài khoản hoặc mật khẩu đã nhập không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã tài khoản hoặc mật khẩu đã nhập không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            //Solution: (https://)stackoverflow.com/questions/7285386/how-to-minimize-and-maximize-in-c-net/7285418
            this.WindowState = FormWindowState.Minimized;
        }
        //Solution: (https://)docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time?view=netframeworkdesktop-4.8
        //Solution: (https://)www.c-sharpcorner.com/uploadfile/mahesh/tooltip-in-C-Sharp/
        //Solution: (https://)docs.microsoft.com/en-us/dotnet/api/system.windows.forms.tooltipicon?view=net-5.0
        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            toolTip_Warning.SetToolTip(tb_UserCode, "Tên tài khoản không được chứa dấu thanh & khoảng trắng");
            toolTip_Warning.ToolTipIcon = ToolTipIcon.Warning;
        }
        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            toolTip_Warning.SetToolTip(tb_Password, "Mật khẩu không được chứa dấu thanh & khoảng trắng");
            toolTip_Warning.ToolTipIcon = ToolTipIcon.Warning;
        }
    }
}
