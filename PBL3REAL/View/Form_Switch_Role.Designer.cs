
namespace PBL3REAL.View
{
    partial class Form_Switch_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Switch_Role));
            this.fllaypn_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.picbx_Header = new System.Windows.Forms.PictureBox();
            this.lb_Header = new System.Windows.Forms.Label();
            this.lb_LoginRole = new System.Windows.Forms.Label();
            this.cbb_LoginRole = new System.Windows.Forms.ComboBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.fllaypn_LoginRole = new System.Windows.Forms.FlowLayoutPanel();
            this.tbllaypn_Loginout = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.fllaypn_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).BeginInit();
            this.fllaypn_LoginRole.SuspendLayout();
            this.tbllaypn_Loginout.SuspendLayout();
            this.SuspendLayout();
            // 
            // fllaypn_Header
            // 
            this.fllaypn_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fllaypn_Header.Controls.Add(this.picbx_Header);
            this.fllaypn_Header.Controls.Add(this.lb_Header);
            this.fllaypn_Header.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Header.Location = new System.Drawing.Point(102, 12);
            this.fllaypn_Header.Name = "fllaypn_Header";
            this.fllaypn_Header.Size = new System.Drawing.Size(165, 132);
            this.fllaypn_Header.TabIndex = 0;
            // 
            // picbx_Header
            // 
            this.picbx_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picbx_Header.Image = global::PBL3REAL.Properties.Resources.male_user_fluent_color_96px;
            this.picbx_Header.Location = new System.Drawing.Point(36, 3);
            this.picbx_Header.Name = "picbx_Header";
            this.picbx_Header.Size = new System.Drawing.Size(91, 90);
            this.picbx_Header.TabIndex = 0;
            this.picbx_Header.TabStop = false;
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(3, 96);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(157, 30);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "........................";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_LoginRole
            // 
            this.lb_LoginRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_LoginRole.AutoSize = true;
            this.lb_LoginRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_LoginRole.Location = new System.Drawing.Point(3, 0);
            this.lb_LoginRole.Name = "lb_LoginRole";
            this.lb_LoginRole.Size = new System.Drawing.Size(184, 28);
            this.lb_LoginRole.TabIndex = 0;
            this.lb_LoginRole.Text = "Đăng nhập với vị trí";
            this.lb_LoginRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_LoginRole
            // 
            this.cbb_LoginRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_LoginRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_LoginRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoginRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_LoginRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_LoginRole.FormattingEnabled = true;
            this.cbb_LoginRole.Location = new System.Drawing.Point(5, 31);
            this.cbb_LoginRole.Name = "cbb_LoginRole";
            this.cbb_LoginRole.Size = new System.Drawing.Size(180, 36);
            this.cbb_LoginRole.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(12, 3);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 43);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // fllaypn_LoginRole
            // 
            this.fllaypn_LoginRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fllaypn_LoginRole.Controls.Add(this.lb_LoginRole);
            this.fllaypn_LoginRole.Controls.Add(this.cbb_LoginRole);
            this.fllaypn_LoginRole.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_LoginRole.Location = new System.Drawing.Point(88, 191);
            this.fllaypn_LoginRole.Name = "fllaypn_LoginRole";
            this.fllaypn_LoginRole.Size = new System.Drawing.Size(192, 72);
            this.fllaypn_LoginRole.TabIndex = 0;
            // 
            // tbllaypn_Loginout
            // 
            this.tbllaypn_Loginout.ColumnCount = 2;
            this.tbllaypn_Loginout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_Loginout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_Loginout.Controls.Add(this.btn_Logout, 1, 0);
            this.tbllaypn_Loginout.Controls.Add(this.btn_Login, 0, 0);
            this.tbllaypn_Loginout.Location = new System.Drawing.Point(27, 335);
            this.tbllaypn_Loginout.Name = "tbllaypn_Loginout";
            this.tbllaypn_Loginout.RowCount = 1;
            this.tbllaypn_Loginout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_Loginout.Size = new System.Drawing.Size(319, 49);
            this.tbllaypn_Loginout.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.Location = new System.Drawing.Point(171, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(135, 43);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Form_Switch_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 407);
            this.Controls.Add(this.tbllaypn_Loginout);
            this.Controls.Add(this.fllaypn_LoginRole);
            this.Controls.Add(this.fllaypn_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Switch_Role";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Switch_Role";
            this.fllaypn_Header.ResumeLayout(false);
            this.fllaypn_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).EndInit();
            this.fllaypn_LoginRole.ResumeLayout(false);
            this.fllaypn_LoginRole.PerformLayout();
            this.tbllaypn_Loginout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fllaypn_Header;
        private System.Windows.Forms.PictureBox picbx_Header;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.Label lb_LoginRole;
        private System.Windows.Forms.ComboBox cbb_LoginRole;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_LoginRole;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Loginout;
        private System.Windows.Forms.Button btn_Logout;
    }
}