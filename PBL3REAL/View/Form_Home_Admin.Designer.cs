
namespace PBL3REAL.View
{
    partial class Form_Home_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home_Admin));
            this.fllaypn_Navbar = new System.Windows.Forms.FlowLayoutPanel();
            this.picbx_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Receptionist = new System.Windows.Forms.Button();
            this.btn_Service = new System.Windows.Forms.Button();
            this.btn_Accountant = new System.Windows.Forms.Button();
            this.btn_HRM = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.fllaypn_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fllaypn_Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Logo)).BeginInit();
            this.fllaypn_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fllaypn_Navbar
            // 
            this.fllaypn_Navbar.Controls.Add(this.picbx_Logo);
            this.fllaypn_Navbar.Controls.Add(this.btn_Receptionist);
            this.fllaypn_Navbar.Controls.Add(this.btn_Service);
            this.fllaypn_Navbar.Controls.Add(this.btn_Accountant);
            this.fllaypn_Navbar.Controls.Add(this.btn_HRM);
            this.fllaypn_Navbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.fllaypn_Navbar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Navbar.Location = new System.Drawing.Point(0, 0);
            this.fllaypn_Navbar.Name = "fllaypn_Navbar";
            this.fllaypn_Navbar.Size = new System.Drawing.Size(149, 731);
            this.fllaypn_Navbar.TabIndex = 0;
            // 
            // picbx_Logo
            // 
            this.picbx_Logo.BackgroundImage = global::PBL3REAL.Properties.Resources.hotel_fluent_color_120px;
            this.picbx_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbx_Logo.Location = new System.Drawing.Point(3, 3);
            this.picbx_Logo.Name = "picbx_Logo";
            this.picbx_Logo.Size = new System.Drawing.Size(144, 140);
            this.picbx_Logo.TabIndex = 4;
            this.picbx_Logo.TabStop = false;
            // 
            // btn_Receptionist
            // 
            this.btn_Receptionist.FlatAppearance.BorderSize = 0;
            this.btn_Receptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Receptionist.Image = global::PBL3REAL.Properties.Resources.front_desk_fluent_color_96px;
            this.btn_Receptionist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Receptionist.Location = new System.Drawing.Point(3, 149);
            this.btn_Receptionist.Name = "btn_Receptionist";
            this.btn_Receptionist.Size = new System.Drawing.Size(144, 140);
            this.btn_Receptionist.TabIndex = 0;
            this.btn_Receptionist.Text = "Receptionist";
            this.btn_Receptionist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Receptionist.UseVisualStyleBackColor = true;
            this.btn_Receptionist.Click += new System.EventHandler(this.btn_Receptionist_Click);
            // 
            // btn_Service
            // 
            this.btn_Service.FlatAppearance.BorderSize = 0;
            this.btn_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Service.Image = global::PBL3REAL.Properties.Resources.food_service_96px;
            this.btn_Service.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Service.Location = new System.Drawing.Point(3, 295);
            this.btn_Service.Name = "btn_Service";
            this.btn_Service.Size = new System.Drawing.Size(144, 140);
            this.btn_Service.TabIndex = 0;
            this.btn_Service.Text = "Service";
            this.btn_Service.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Service.UseVisualStyleBackColor = true;
            // 
            // btn_Accountant
            // 
            this.btn_Accountant.FlatAppearance.BorderSize = 0;
            this.btn_Accountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accountant.Image = global::PBL3REAL.Properties.Resources.accounting_96px;
            this.btn_Accountant.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Accountant.Location = new System.Drawing.Point(3, 441);
            this.btn_Accountant.Name = "btn_Accountant";
            this.btn_Accountant.Size = new System.Drawing.Size(144, 140);
            this.btn_Accountant.TabIndex = 0;
            this.btn_Accountant.Text = "Accountant";
            this.btn_Accountant.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Accountant.UseVisualStyleBackColor = true;
            this.btn_Accountant.Click += new System.EventHandler(this.btn_Accountant_Click);
            // 
            // btn_HRM
            // 
            this.btn_HRM.FlatAppearance.BorderSize = 0;
            this.btn_HRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRM.Image = global::PBL3REAL.Properties.Resources.staff_fluent_color_96px;
            this.btn_HRM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HRM.Location = new System.Drawing.Point(3, 587);
            this.btn_HRM.Name = "btn_HRM";
            this.btn_HRM.Size = new System.Drawing.Size(144, 140);
            this.btn_HRM.TabIndex = 0;
            this.btn_HRM.Text = "Human Resources";
            this.btn_HRM.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HRM.UseVisualStyleBackColor = true;
            this.btn_HRM.Click += new System.EventHandler(this.btn_HRM_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Image = global::PBL3REAL.Properties.Resources.triangle_arrow_material_filled__535c68_24px;
            this.btn_Menu.Location = new System.Drawing.Point(968, 0);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(38, 25);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // fllaypn_Menu
            // 
            this.fllaypn_Menu.Controls.Add(this.btn_Profile);
            this.fllaypn_Menu.Controls.Add(this.btn_Logout);
            this.fllaypn_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllaypn_Menu.Location = new System.Drawing.Point(871, 26);
            this.fllaypn_Menu.Name = "fllaypn_Menu";
            this.fllaypn_Menu.Size = new System.Drawing.Size(138, 84);
            this.fllaypn_Menu.TabIndex = 0;
            // 
            // btn_Profile
            // 
            this.btn_Profile.FlatAppearance.BorderSize = 0;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Image = global::PBL3REAL.Properties.Resources.profile_fluent_color_36px;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(3, 3);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(138, 36);
            this.btn_Profile.TabIndex = 0;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::PBL3REAL.Properties.Resources.sign_out_fluent_color_36px;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(3, 45);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(138, 36);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(206, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form_Home_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1006, 731);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.fllaypn_Menu);
            this.Controls.Add(this.fllaypn_Navbar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Home_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Admin!";
            this.VisibleChanged += new System.EventHandler(this.Form_Home_Admin_VisibleChanged);
            this.fllaypn_Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_Logo)).EndInit();
            this.fllaypn_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Navbar;
        private System.Windows.Forms.PictureBox picbx_Logo;
        private System.Windows.Forms.Button btn_Receptionist;
        private System.Windows.Forms.Button btn_Service;
        private System.Windows.Forms.Button btn_Accountant;
        private System.Windows.Forms.Button btn_HRM;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Menu;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}