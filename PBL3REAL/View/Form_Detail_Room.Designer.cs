
namespace HotelManagement.View
{
    partial class Form_Detail_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Detail_Room));
            this.tbllaypn_RoomInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cbb_RoomType = new System.Windows.Forms.ComboBox();
            this.tb_RoomDescription = new System.Windows.Forms.TextBox();
            this.tb_RoomName = new System.Windows.Forms.TextBox();
            this.lb_RoomType = new System.Windows.Forms.Label();
            this.lb_RoomName = new System.Windows.Forms.Label();
            this.lb_RoomDescription = new System.Windows.Forms.Label();
            this.lb_Header = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tbllaypn_RoomStatus = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_To = new System.Windows.Forms.DateTimePicker();
            this.dtp_From = new System.Windows.Forms.DateTimePicker();
            this.cbb_RoomStatus = new System.Windows.Forms.ComboBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_To = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grbx_RoomInfo = new System.Windows.Forms.GroupBox();
            this.grbx_FromToStatus = new System.Windows.Forms.GroupBox();
            this.tbllaypn_ControlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.tb_PageNumber = new System.Windows.Forms.TextBox();
            this.fllaypn_SwitchPage = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_PrevPage = new System.Windows.Forms.Button();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.tbllaypn_RoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tbllaypn_RoomStatus.SuspendLayout();
            this.grbx_RoomInfo.SuspendLayout();
            this.grbx_FromToStatus.SuspendLayout();
            this.tbllaypn_ControlButtons.SuspendLayout();
            this.fllaypn_SwitchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbllaypn_RoomInfo
            // 
            this.tbllaypn_RoomInfo.ColumnCount = 2;
            this.tbllaypn_RoomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87013F));
            this.tbllaypn_RoomInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.12987F));
            this.tbllaypn_RoomInfo.Controls.Add(this.cbb_RoomType, 1, 2);
            this.tbllaypn_RoomInfo.Controls.Add(this.tb_RoomDescription, 1, 1);
            this.tbllaypn_RoomInfo.Controls.Add(this.tb_RoomName, 1, 0);
            this.tbllaypn_RoomInfo.Controls.Add(this.lb_RoomType, 0, 2);
            this.tbllaypn_RoomInfo.Controls.Add(this.lb_RoomName, 0, 0);
            this.tbllaypn_RoomInfo.Controls.Add(this.lb_RoomDescription, 0, 1);
            this.tbllaypn_RoomInfo.Location = new System.Drawing.Point(6, 33);
            this.tbllaypn_RoomInfo.Name = "tbllaypn_RoomInfo";
            this.tbllaypn_RoomInfo.RowCount = 3;
            this.tbllaypn_RoomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbllaypn_RoomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.85714F));
            this.tbllaypn_RoomInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46032F));
            this.tbllaypn_RoomInfo.Size = new System.Drawing.Size(417, 252);
            this.tbllaypn_RoomInfo.TabIndex = 0;
            // 
            // cbb_RoomType
            // 
            this.cbb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbb_RoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_RoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_RoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_RoomType.FormattingEnabled = true;
            this.cbb_RoomType.Location = new System.Drawing.Point(127, 211);
            this.cbb_RoomType.Name = "cbb_RoomType";
            this.cbb_RoomType.Size = new System.Drawing.Size(287, 36);
            this.cbb_RoomType.TabIndex = 3;
            // 
            // tb_RoomDescription
            // 
            this.tb_RoomDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_RoomDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RoomDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_RoomDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_RoomDescription.Location = new System.Drawing.Point(127, 39);
            this.tb_RoomDescription.Multiline = true;
            this.tb_RoomDescription.Name = "tb_RoomDescription";
            this.tb_RoomDescription.Size = new System.Drawing.Size(287, 165);
            this.tb_RoomDescription.TabIndex = 2;
            // 
            // tb_RoomName
            // 
            this.tb_RoomName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_RoomName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_RoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_RoomName.Location = new System.Drawing.Point(127, 4);
            this.tb_RoomName.Name = "tb_RoomName";
            this.tb_RoomName.Size = new System.Drawing.Size(287, 27);
            this.tb_RoomName.TabIndex = 1;
            // 
            // lb_RoomType
            // 
            this.lb_RoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_RoomType.AutoSize = true;
            this.lb_RoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_RoomType.Location = new System.Drawing.Point(8, 215);
            this.lb_RoomType.Name = "lb_RoomType";
            this.lb_RoomType.Size = new System.Drawing.Size(108, 28);
            this.lb_RoomType.TabIndex = 0;
            this.lb_RoomType.Text = "Room type";
            // 
            // lb_RoomName
            // 
            this.lb_RoomName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_RoomName.AutoSize = true;
            this.lb_RoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_RoomName.Location = new System.Drawing.Point(3, 4);
            this.lb_RoomName.Name = "lb_RoomName";
            this.lb_RoomName.Size = new System.Drawing.Size(117, 28);
            this.lb_RoomName.TabIndex = 0;
            this.lb_RoomName.Text = "Room name";
            // 
            // lb_RoomDescription
            // 
            this.lb_RoomDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_RoomDescription.AutoSize = true;
            this.lb_RoomDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_RoomDescription.Location = new System.Drawing.Point(6, 107);
            this.lb_RoomDescription.Name = "lb_RoomDescription";
            this.lb_RoomDescription.Size = new System.Drawing.Size(112, 28);
            this.lb_RoomDescription.TabIndex = 0;
            this.lb_RoomDescription.Text = "Description";
            // 
            // lb_Header
            // 
            this.lb_Header.AutoSize = true;
            this.lb_Header.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Header.Location = new System.Drawing.Point(398, 9);
            this.lb_Header.Name = "lb_Header";
            this.lb_Header.Size = new System.Drawing.Size(205, 38);
            this.lb_Header.TabIndex = 0;
            this.lb_Header.Text = "ROOM DETAIL";
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv.Location = new System.Drawing.Point(12, 347);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1023, 230);
            this.dgv.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(282, 227);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(126, 53);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tbllaypn_RoomStatus
            // 
            this.tbllaypn_RoomStatus.ColumnCount = 2;
            this.tbllaypn_RoomStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42253F));
            this.tbllaypn_RoomStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.57746F));
            this.tbllaypn_RoomStatus.Controls.Add(this.dtp_To, 1, 1);
            this.tbllaypn_RoomStatus.Controls.Add(this.dtp_From, 1, 0);
            this.tbllaypn_RoomStatus.Controls.Add(this.cbb_RoomStatus, 1, 2);
            this.tbllaypn_RoomStatus.Controls.Add(this.lb_Status, 0, 2);
            this.tbllaypn_RoomStatus.Controls.Add(this.lb_From, 0, 0);
            this.tbllaypn_RoomStatus.Controls.Add(this.lb_To, 0, 1);
            this.tbllaypn_RoomStatus.Location = new System.Drawing.Point(21, 50);
            this.tbllaypn_RoomStatus.Name = "tbllaypn_RoomStatus";
            this.tbllaypn_RoomStatus.RowCount = 3;
            this.tbllaypn_RoomStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_RoomStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_RoomStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_RoomStatus.Size = new System.Drawing.Size(426, 163);
            this.tbllaypn_RoomStatus.TabIndex = 0;
            // 
            // dtp_To
            // 
            this.dtp_To.Location = new System.Drawing.Point(89, 57);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(331, 34);
            this.dtp_To.TabIndex = 5;
            // 
            // dtp_From
            // 
            this.dtp_From.Location = new System.Drawing.Point(89, 3);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(331, 34);
            this.dtp_From.TabIndex = 4;
            // 
            // cbb_RoomStatus
            // 
            this.cbb_RoomStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.cbb_RoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_RoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_RoomStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbb_RoomStatus.FormattingEnabled = true;
            this.cbb_RoomStatus.Location = new System.Drawing.Point(89, 111);
            this.cbb_RoomStatus.Name = "cbb_RoomStatus";
            this.cbb_RoomStatus.Size = new System.Drawing.Size(331, 36);
            this.cbb_RoomStatus.TabIndex = 6;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Status.Location = new System.Drawing.Point(3, 108);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(65, 28);
            this.lb_Status.TabIndex = 0;
            this.lb_Status.Text = "Status";
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_From.Location = new System.Drawing.Point(3, 0);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(58, 28);
            this.lb_From.TabIndex = 0;
            this.lb_From.Text = "From";
            // 
            // lb_To
            // 
            this.lb_To.AutoSize = true;
            this.lb_To.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_To.Location = new System.Drawing.Point(3, 54);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(32, 28);
            this.lb_To.TabIndex = 0;
            this.lb_To.Text = "To";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(94, 227);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(126, 53);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // grbx_RoomInfo
            // 
            this.grbx_RoomInfo.Controls.Add(this.tbllaypn_RoomInfo);
            this.grbx_RoomInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbx_RoomInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_RoomInfo.Location = new System.Drawing.Point(12, 50);
            this.grbx_RoomInfo.Name = "grbx_RoomInfo";
            this.grbx_RoomInfo.Size = new System.Drawing.Size(427, 291);
            this.grbx_RoomInfo.TabIndex = 0;
            this.grbx_RoomInfo.TabStop = false;
            this.grbx_RoomInfo.Text = "Thông tin phòng";
            // 
            // grbx_FromToStatus
            // 
            this.grbx_FromToStatus.Controls.Add(this.tbllaypn_RoomStatus);
            this.grbx_FromToStatus.Controls.Add(this.btn_Add);
            this.grbx_FromToStatus.Controls.Add(this.btn_Delete);
            this.grbx_FromToStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_FromToStatus.Location = new System.Drawing.Point(565, 50);
            this.grbx_FromToStatus.Name = "grbx_FromToStatus";
            this.grbx_FromToStatus.Size = new System.Drawing.Size(470, 291);
            this.grbx_FromToStatus.TabIndex = 0;
            this.grbx_FromToStatus.TabStop = false;
            this.grbx_FromToStatus.Text = "Thiết lập trạng thái phòng ";
            // 
            // tbllaypn_ControlButtons
            // 
            this.tbllaypn_ControlButtons.ColumnCount = 3;
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68421F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbllaypn_ControlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Cancel, 2, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_OK, 0, 0);
            this.tbllaypn_ControlButtons.Controls.Add(this.btn_Reset, 1, 0);
            this.tbllaypn_ControlButtons.Location = new System.Drawing.Point(381, 622);
            this.tbllaypn_ControlButtons.Name = "tbllaypn_ControlButtons";
            this.tbllaypn_ControlButtons.RowCount = 1;
            this.tbllaypn_ControlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_ControlButtons.Size = new System.Drawing.Size(273, 46);
            this.tbllaypn_ControlButtons.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(186, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(83, 40);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_OK.Location = new System.Drawing.Point(4, 3);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(83, 40);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Reset.Location = new System.Drawing.Point(96, 3);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(83, 40);
            this.btn_Reset.TabIndex = 0;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tb_PageNumber
            // 
            this.tb_PageNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_PageNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.tb_PageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PageNumber.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_PageNumber.Location = new System.Drawing.Point(43, 2);
            this.tb_PageNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tb_PageNumber.Name = "tb_PageNumber";
            this.tb_PageNumber.ReadOnly = true;
            this.tb_PageNumber.Size = new System.Drawing.Size(94, 38);
            this.tb_PageNumber.TabIndex = 0;
            this.tb_PageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fllaypn_SwitchPage
            // 
            this.fllaypn_SwitchPage.Controls.Add(this.btn_PrevPage);
            this.fllaypn_SwitchPage.Controls.Add(this.tb_PageNumber);
            this.fllaypn_SwitchPage.Controls.Add(this.btn_NextPage);
            this.fllaypn_SwitchPage.Location = new System.Drawing.Point(858, 573);
            this.fllaypn_SwitchPage.Name = "fllaypn_SwitchPage";
            this.fllaypn_SwitchPage.Size = new System.Drawing.Size(188, 44);
            this.fllaypn_SwitchPage.TabIndex = 0;
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_PrevPage.FlatAppearance.BorderSize = 0;
            this.btn_PrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PrevPage.Image = global::PBL3REAL.Properties.Resources.prev_fluent_color_48px;
            this.btn_PrevPage.Location = new System.Drawing.Point(0, 0);
            this.btn_PrevPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(43, 43);
            this.btn_PrevPage.TabIndex = 0;
            this.btn_PrevPage.UseVisualStyleBackColor = true;
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_NextPage.FlatAppearance.BorderSize = 0;
            this.btn_NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextPage.Image = global::PBL3REAL.Properties.Resources.right_button_fluent_color_48px;
            this.btn_NextPage.Location = new System.Drawing.Point(137, 0);
            this.btn_NextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(43, 43);
            this.btn_NextPage.TabIndex = 0;
            this.btn_NextPage.UseVisualStyleBackColor = true;
            // 
            // Form_Detail_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 668);
            this.Controls.Add(this.tbllaypn_ControlButtons);
            this.Controls.Add(this.grbx_FromToStatus);
            this.Controls.Add(this.grbx_RoomInfo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lb_Header);
            this.Controls.Add(this.fllaypn_SwitchPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Detail_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Detail_Room";
            this.tbllaypn_RoomInfo.ResumeLayout(false);
            this.tbllaypn_RoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tbllaypn_RoomStatus.ResumeLayout(false);
            this.tbllaypn_RoomStatus.PerformLayout();
            this.grbx_RoomInfo.ResumeLayout(false);
            this.grbx_FromToStatus.ResumeLayout(false);
            this.tbllaypn_ControlButtons.ResumeLayout(false);
            this.fllaypn_SwitchPage.ResumeLayout(false);
            this.fllaypn_SwitchPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbllaypn_RoomInfo;
        private System.Windows.Forms.Label lb_RoomType;
        private System.Windows.Forms.Label lb_RoomName;
        private System.Windows.Forms.Label lb_RoomDescription;
        private System.Windows.Forms.Label lb_Header;
        private System.Windows.Forms.TextBox tb_RoomName;
        private System.Windows.Forms.TextBox tb_RoomDescription;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox cbb_RoomType;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_RoomStatus;
        private System.Windows.Forms.DateTimePicker dtp_To;
        private System.Windows.Forms.DateTimePicker dtp_From;
        private System.Windows.Forms.ComboBox cbb_RoomStatus;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox grbx_RoomInfo;
        private System.Windows.Forms.GroupBox grbx_FromToStatus;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_ControlButtons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox tb_PageNumber;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_SwitchPage;
        private System.Windows.Forms.Button btn_PrevPage;
        private System.Windows.Forms.Button btn_NextPage;
    }
}