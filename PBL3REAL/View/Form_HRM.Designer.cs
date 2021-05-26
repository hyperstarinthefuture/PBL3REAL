
namespace PBL3REAL.View
{
    partial class Form_HRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HRM));
            this.tabControl_HRM = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tabPage_HRM = new System.Windows.Forms.TabPage();
            this.dgv_HRM = new System.Windows.Forms.DataGridView();
            this.fllaypn_HRMButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_HRMView = new System.Windows.Forms.Button();
            this.btn_HRMAdd = new System.Windows.Forms.Button();
            this.btn_HRMEdit = new System.Windows.Forms.Button();
            this.btn_HRMDelete = new System.Windows.Forms.Button();
            this.tbllaypn_HRM = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_HRMSearch = new System.Windows.Forms.PictureBox();
            this.picbx_HRMSort = new System.Windows.Forms.PictureBox();
            this.cbb_HRMSort = new System.Windows.Forms.ComboBox();
            this.tb_HRMSearch = new System.Windows.Forms.TextBox();
            this.lb_HRMSearch = new System.Windows.Forms.Label();
            this.lb_HRMSort = new System.Windows.Forms.Label();
            this.tabControl_HRM.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_HRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HRM)).BeginInit();
            this.fllaypn_HRMButtons.SuspendLayout();
            this.tbllaypn_HRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_HRMSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_HRMSort)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_HRM
            // 
            this.tabControl_HRM.Controls.Add(this.tabPage_General);
            this.tabControl_HRM.Controls.Add(this.tabPage_HRM);
            this.tabControl_HRM.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl_HRM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_HRM.Location = new System.Drawing.Point(0, 0);
            this.tabControl_HRM.Name = "tabControl_HRM";
            this.tabControl_HRM.SelectedIndex = 0;
            this.tabControl_HRM.Size = new System.Drawing.Size(970, 699);
            this.tabControl_HRM.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.tabPage_General.Controls.Add(this.btn_Home);
            this.tabPage_General.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_General.Location = new System.Drawing.Point(4, 37);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(962, 658);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "Chung";
            // 
            // btn_Home
            // 
            this.btn_Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Image = global::PBL3REAL.Properties.Resources.home_page_fluent_color_96px;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Home.Location = new System.Drawing.Point(384, 238);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(194, 183);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "Return Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tabPage_HRM
            // 
            this.tabPage_HRM.Controls.Add(this.dgv_HRM);
            this.tabPage_HRM.Controls.Add(this.fllaypn_HRMButtons);
            this.tabPage_HRM.Controls.Add(this.tbllaypn_HRM);
            this.tabPage_HRM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_HRM.Location = new System.Drawing.Point(4, 37);
            this.tabPage_HRM.Name = "tabPage_HRM";
            this.tabPage_HRM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HRM.Size = new System.Drawing.Size(962, 658);
            this.tabPage_HRM.TabIndex = 1;
            this.tabPage_HRM.Text = "Quản lí nhân sự";
            this.tabPage_HRM.UseVisualStyleBackColor = true;
            // 
            // dgv_HRM
            // 
            this.dgv_HRM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_HRM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HRM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_HRM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_HRM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HRM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_HRM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_HRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_HRM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_HRM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_HRM.Location = new System.Drawing.Point(3, 153);
            this.dgv_HRM.Name = "dgv_HRM";
            this.dgv_HRM.ReadOnly = true;
            this.dgv_HRM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_HRM.RowHeadersVisible = false;
            this.dgv_HRM.RowHeadersWidth = 51;
            this.dgv_HRM.RowTemplate.Height = 29;
            this.dgv_HRM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HRM.Size = new System.Drawing.Size(955, 501);
            this.dgv_HRM.TabIndex = 0;
            // 
            // fllaypn_HRMButtons
            // 
            this.fllaypn_HRMButtons.Controls.Add(this.btn_HRMView);
            this.fllaypn_HRMButtons.Controls.Add(this.btn_HRMAdd);
            this.fllaypn_HRMButtons.Controls.Add(this.btn_HRMEdit);
            this.fllaypn_HRMButtons.Controls.Add(this.btn_HRMDelete);
            this.fllaypn_HRMButtons.Location = new System.Drawing.Point(442, -3);
            this.fllaypn_HRMButtons.Name = "fllaypn_HRMButtons";
            this.fllaypn_HRMButtons.Size = new System.Drawing.Size(517, 147);
            this.fllaypn_HRMButtons.TabIndex = 0;
            // 
            // btn_HRMView
            // 
            this.btn_HRMView.FlatAppearance.BorderSize = 0;
            this.btn_HRMView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRMView.Image = global::PBL3REAL.Properties.Resources.show_property_96px;
            this.btn_HRMView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HRMView.Location = new System.Drawing.Point(3, 3);
            this.btn_HRMView.Name = "btn_HRMView";
            this.btn_HRMView.Size = new System.Drawing.Size(123, 147);
            this.btn_HRMView.TabIndex = 0;
            this.btn_HRMView.Text = "Xem thông tin người dùng đã chọn";
            this.btn_HRMView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HRMView.UseVisualStyleBackColor = true;
            // 
            // btn_HRMAdd
            // 
            this.btn_HRMAdd.FlatAppearance.BorderSize = 0;
            this.btn_HRMAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRMAdd.Image = global::PBL3REAL.Properties.Resources.add_fluent_color_96px;
            this.btn_HRMAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HRMAdd.Location = new System.Drawing.Point(132, 3);
            this.btn_HRMAdd.Name = "btn_HRMAdd";
            this.btn_HRMAdd.Size = new System.Drawing.Size(123, 147);
            this.btn_HRMAdd.TabIndex = 0;
            this.btn_HRMAdd.Text = "Thêm người dùng mới";
            this.btn_HRMAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HRMAdd.UseVisualStyleBackColor = true;
            // 
            // btn_HRMEdit
            // 
            this.btn_HRMEdit.FlatAppearance.BorderSize = 0;
            this.btn_HRMEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRMEdit.Image = global::PBL3REAL.Properties.Resources.edit_property_fluent_color_96px;
            this.btn_HRMEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HRMEdit.Location = new System.Drawing.Point(261, 3);
            this.btn_HRMEdit.Name = "btn_HRMEdit";
            this.btn_HRMEdit.Size = new System.Drawing.Size(123, 147);
            this.btn_HRMEdit.TabIndex = 0;
            this.btn_HRMEdit.Text = "Chỉnh sửa thông tin người dùng đã chọn";
            this.btn_HRMEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HRMEdit.UseVisualStyleBackColor = true;
            // 
            // btn_HRMDelete
            // 
            this.btn_HRMDelete.FlatAppearance.BorderSize = 0;
            this.btn_HRMDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRMDelete.Image = global::PBL3REAL.Properties.Resources.waste_fluent_color_96px;
            this.btn_HRMDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HRMDelete.Location = new System.Drawing.Point(390, 3);
            this.btn_HRMDelete.Name = "btn_HRMDelete";
            this.btn_HRMDelete.Size = new System.Drawing.Size(123, 147);
            this.btn_HRMDelete.TabIndex = 0;
            this.btn_HRMDelete.Text = "Xóa người dùng đã chọn";
            this.btn_HRMDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HRMDelete.UseVisualStyleBackColor = true;
            // 
            // tbllaypn_HRM
            // 
            this.tbllaypn_HRM.ColumnCount = 3;
            this.tbllaypn_HRM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.09678F));
            this.tbllaypn_HRM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.90322F));
            this.tbllaypn_HRM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tbllaypn_HRM.Controls.Add(this.picbx_HRMSearch, 2, 1);
            this.tbllaypn_HRM.Controls.Add(this.picbx_HRMSort, 2, 0);
            this.tbllaypn_HRM.Controls.Add(this.cbb_HRMSort, 1, 0);
            this.tbllaypn_HRM.Controls.Add(this.tb_HRMSearch, 1, 1);
            this.tbllaypn_HRM.Controls.Add(this.lb_HRMSearch, 0, 1);
            this.tbllaypn_HRM.Controls.Add(this.lb_HRMSort, 0, 0);
            this.tbllaypn_HRM.Location = new System.Drawing.Point(5, 20);
            this.tbllaypn_HRM.Name = "tbllaypn_HRM";
            this.tbllaypn_HRM.RowCount = 2;
            this.tbllaypn_HRM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_HRM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_HRM.Size = new System.Drawing.Size(386, 111);
            this.tbllaypn_HRM.TabIndex = 0;
            // 
            // picbx_HRMSearch
            // 
            this.picbx_HRMSearch.Image = global::PBL3REAL.Properties.Resources.search_fluent_color_48px;
            this.picbx_HRMSearch.Location = new System.Drawing.Point(335, 58);
            this.picbx_HRMSearch.Name = "picbx_HRMSearch";
            this.picbx_HRMSearch.Size = new System.Drawing.Size(48, 48);
            this.picbx_HRMSearch.TabIndex = 10;
            this.picbx_HRMSearch.TabStop = false;
            // 
            // picbx_HRMSort
            // 
            this.picbx_HRMSort.Image = global::PBL3REAL.Properties.Resources.filter_fluent_color_48px;
            this.picbx_HRMSort.Location = new System.Drawing.Point(335, 3);
            this.picbx_HRMSort.Name = "picbx_HRMSort";
            this.picbx_HRMSort.Size = new System.Drawing.Size(48, 48);
            this.picbx_HRMSort.TabIndex = 9;
            this.picbx_HRMSort.TabStop = false;
            // 
            // cbb_HRMSort
            // 
            this.cbb_HRMSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_HRMSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_HRMSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_HRMSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_HRMSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_HRMSort.FormattingEnabled = true;
            this.cbb_HRMSort.Location = new System.Drawing.Point(126, 3);
            this.cbb_HRMSort.Name = "cbb_HRMSort";
            this.cbb_HRMSort.Size = new System.Drawing.Size(203, 39);
            this.cbb_HRMSort.TabIndex = 1;
            // 
            // tb_HRMSearch
            // 
            this.tb_HRMSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_HRMSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_HRMSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_HRMSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_HRMSearch.Location = new System.Drawing.Point(126, 58);
            this.tb_HRMSearch.Name = "tb_HRMSearch";
            this.tb_HRMSearch.Size = new System.Drawing.Size(203, 31);
            this.tb_HRMSearch.TabIndex = 2;
            // 
            // lb_HRMSearch
            // 
            this.lb_HRMSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HRMSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_HRMSearch.Location = new System.Drawing.Point(3, 55);
            this.lb_HRMSearch.Name = "lb_HRMSearch";
            this.lb_HRMSearch.Size = new System.Drawing.Size(117, 56);
            this.lb_HRMSearch.TabIndex = 0;
            this.lb_HRMSearch.Text = "Tìm kiếm";
            // 
            // lb_HRMSort
            // 
            this.lb_HRMSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HRMSort.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_HRMSort.Location = new System.Drawing.Point(3, 0);
            this.lb_HRMSort.Name = "lb_HRMSort";
            this.lb_HRMSort.Size = new System.Drawing.Size(117, 55);
            this.lb_HRMSort.TabIndex = 0;
            this.lb_HRMSort.Text = "Sắp xếp theo";
            // 
            // Form_HRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(966, 699);
            this.Controls.Add(this.tabControl_HRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_HRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HRM";
            this.tabControl_HRM.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_HRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HRM)).EndInit();
            this.fllaypn_HRMButtons.ResumeLayout(false);
            this.tbllaypn_HRM.ResumeLayout(false);
            this.tbllaypn_HRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_HRMSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_HRMSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_HRM;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_HRM;
        private System.Windows.Forms.DataGridView dgv_HRM;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_HRMButtons;
        private System.Windows.Forms.Button btn_HRMView;
        private System.Windows.Forms.Button btn_HRMAdd;
        private System.Windows.Forms.Button btn_HRMEdit;
        private System.Windows.Forms.Button btn_HRMDelete;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_HRM;
        private System.Windows.Forms.PictureBox picbx_HRMSearch;
        private System.Windows.Forms.PictureBox picbx_HRMSort;
        private System.Windows.Forms.ComboBox cbb_HRMSort;
        private System.Windows.Forms.TextBox tb_HRMSearch;
        private System.Windows.Forms.Label lb_HRMSearch;
        private System.Windows.Forms.Label lb_HRMSort;
        private System.Windows.Forms.Button btn_Home;
    }
}