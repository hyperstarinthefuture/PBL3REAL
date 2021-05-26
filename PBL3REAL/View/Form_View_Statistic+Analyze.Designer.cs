
namespace PBL3REAL.View
{
    partial class Form_View_Statistic_Analyze
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
            this.grbx_Statistic = new System.Windows.Forms.GroupBox();
            this.dgv_Booking = new System.Windows.Forms.DataGridView();
            this.grbx_Statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_Statistic
            // 
            this.grbx_Statistic.Controls.Add(this.dgv_Booking);
            this.grbx_Statistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_Statistic.Location = new System.Drawing.Point(12, 12);
            this.grbx_Statistic.Name = "grbx_Statistic";
            this.grbx_Statistic.Size = new System.Drawing.Size(953, 524);
            this.grbx_Statistic.TabIndex = 0;
            this.grbx_Statistic.TabStop = false;
            this.grbx_Statistic.Text = "Thống kê";
            // 
            // dgv_Booking
            // 
            this.dgv_Booking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Booking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Booking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_Booking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Booking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Booking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Booking.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Booking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_Booking.Location = new System.Drawing.Point(6, 33);
            this.dgv_Booking.Name = "dgv_Booking";
            this.dgv_Booking.ReadOnly = true;
            this.dgv_Booking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Booking.RowHeadersVisible = false;
            this.dgv_Booking.RowHeadersWidth = 51;
            this.dgv_Booking.RowTemplate.Height = 29;
            this.dgv_Booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Booking.Size = new System.Drawing.Size(941, 252);
            this.dgv_Booking.TabIndex = 1;
            // 
            // Form_View_Statistic_Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(977, 588);
            this.Controls.Add(this.grbx_Statistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_View_Statistic_Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_View_Statistic_Analyze";
            this.grbx_Statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Booking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Statistic;
        private System.Windows.Forms.DataGridView dgv_Booking;
    }
}