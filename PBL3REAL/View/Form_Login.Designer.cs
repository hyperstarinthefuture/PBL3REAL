
namespace PBL3REAL.View
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.fllaypn_ControlBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tbllaypn_LoginInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tb_UserCode = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_UserCode = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.picbx_Header = new System.Windows.Forms.PictureBox();
            this.fllaypn_Header = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Header = new System.Windows.Forms.Label();
            this.toolTip_Warning = new System.Windows.Forms.ToolTip(this.components);
            this.fllaypn_ControlBar.SuspendLayout();
            this.tbllaypn_LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).BeginInit();
            this.fllaypn_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // fllaypn_ControlBar
            // 
            this.fllaypn_ControlBar.Controls.Add(this.btn_Minimize);
            this.fllaypn_ControlBar.Controls.Add(this.btn_Exit);
            this.fllaypn_ControlBar.Location = new System.Drawing.Point(308, -3);
            this.fllaypn_ControlBar.Name = "fllaypn_ControlBar";
            this.fllaypn_ControlBar.Size = new System.Drawing.Size(100, 45);
            this.fllaypn_ControlBar.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Image = global::PBL3REAL.Properties.Resources.shrink_fluent_color_48px;
            this.btn_Minimize.Location = new System.Drawing.Point(3, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(42, 42);
            this.btn_Minimize.TabIndex = 0;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = global::PBL3REAL.Properties.Resources.cancel_fluent_color_48px;
            this.btn_Exit.Location = new System.Drawing.Point(51, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(42, 42);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tbllaypn_LoginInfo
            // 
            this.tbllaypn_LoginInfo.ColumnCount = 2;
            this.tbllaypn_LoginInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tbllaypn_LoginInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tbllaypn_LoginInfo.Controls.Add(this.tb_UserCode, 1, 0);
            this.tbllaypn_LoginInfo.Controls.Add(this.tb_Password, 1, 1);
            this.tbllaypn_LoginInfo.Controls.Add(this.lb_UserCode, 0, 0);
            this.tbllaypn_LoginInfo.Controls.Add(this.lb_Password, 0, 1);
            this.tbllaypn_LoginInfo.Location = new System.Drawing.Point(12, 227);
            this.tbllaypn_LoginInfo.Name = "tbllaypn_LoginInfo";
            this.tbllaypn_LoginInfo.RowCount = 2;
            this.tbllaypn_LoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_LoginInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbllaypn_LoginInfo.Size = new System.Drawing.Size(372, 144);
            this.tbllaypn_LoginInfo.TabIndex = 0;
            // 
            // tb_UserCode
            // 
            this.tb_UserCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_UserCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_UserCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_UserCode.Location = new System.Drawing.Point(158, 3);
            this.tb_UserCode.Name = "tb_UserCode";
            this.tb_UserCode.Size = new System.Drawing.Size(211, 34);
            this.tb_UserCode.TabIndex = 1;
            this.tb_UserCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_UserCode.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Password.Location = new System.Drawing.Point(158, 75);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(211, 34);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // lb_UserCode
            // 
            this.lb_UserCode.AutoSize = true;
            this.lb_UserCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_UserCode.Location = new System.Drawing.Point(3, 0);
            this.lb_UserCode.Name = "lb_UserCode";
            this.lb_UserCode.Size = new System.Drawing.Size(147, 31);
            this.lb_UserCode.TabIndex = 0;
            this.lb_UserCode.Text = "Mã tài khoản";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Password.Location = new System.Drawing.Point(3, 72);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(110, 31);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Mật khẩu";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(137, 393);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 48);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // picbx_Header
            // 
            this.picbx_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picbx_Header.Image = global::PBL3REAL.Properties.Resources.enter_fluent_color_96px;
            this.picbx_Header.Location = new System.Drawing.Point(31, 3);
            this.picbx_Header.Name = "picbx_Header";
            this.picbx_Header.Size = new System.Drawing.Size(82, 91);
            this.picbx_Header.TabIndex = 4;
            this.picbx_Header.TabStop = false;
            // 
            // fllaypn_Header
            // 
            this.fllaypn_Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fllaypn_Header.Controls.Add(this.picbx_Header);
            this.fllaypn_Header.Controls.Add(this.lb_Header);
            this.fllaypn_Header.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Header.Location = new System.Drawing.Point(137, 63);
            this.fllaypn_Header.Name = "fllaypn_Header";
            this.fllaypn_Header.Size = new System.Drawing.Size(149, 137);
            this.fllaypn_Header.TabIndex = 0;
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(3, 97);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(138, 38);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "Welcome";
            this.lb_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip_Warning
            // 
            this.toolTip_Warning.ToolTipTitle = "Warning";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(402, 534);
            this.Controls.Add(this.fllaypn_Header);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tbllaypn_LoginInfo);
            this.Controls.Add(this.fllaypn_ControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.fllaypn_ControlBar.ResumeLayout(false);
            this.tbllaypn_LoginInfo.ResumeLayout(false);
            this.tbllaypn_LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Header)).EndInit();
            this.fllaypn_Header.ResumeLayout(false);
            this.fllaypn_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fllaypn_ControlBar;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_LoginInfo;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_UserCode;
        private System.Windows.Forms.Label lb_UserCode;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.PictureBox picbx_Header;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Header;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.ToolTip toolTip_Warning;
    }
}