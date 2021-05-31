
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
            this.tbllaypn_Statistic = new System.Windows.Forms.TableLayoutPanel();
            this.btn_StatisticExportToExcel = new System.Windows.Forms.Button();
            this.btn_StatisticExportToImage = new System.Windows.Forms.Button();
            this.btn_StatisticCancel = new System.Windows.Forms.Button();
            this.fllaypn_Statistic = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.grbx_Analyze = new System.Windows.Forms.GroupBox();
            this.tbllaypn_Analyze = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AnalyzeExportToExcel = new System.Windows.Forms.Button();
            this.btn_AnalyzeExportToImage = new System.Windows.Forms.Button();
            this.btn_AnalyzeCancel = new System.Windows.Forms.Button();
            this.rtb_Analyze = new System.Windows.Forms.RichTextBox();
            this.grbx_Statistic.SuspendLayout();
            this.tbllaypn_Statistic.SuspendLayout();
            this.fllaypn_Statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistic)).BeginInit();
            this.grbx_Analyze.SuspendLayout();
            this.tbllaypn_Analyze.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Statistic
            // 
            this.grbx_Statistic.Controls.Add(this.tbllaypn_Statistic);
            this.grbx_Statistic.Controls.Add(this.fllaypn_Statistic);
            this.grbx_Statistic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_Statistic.Location = new System.Drawing.Point(14, 8);
            this.grbx_Statistic.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.grbx_Statistic.Name = "grbx_Statistic";
            this.grbx_Statistic.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.grbx_Statistic.Size = new System.Drawing.Size(1350, 667);
            this.grbx_Statistic.TabIndex = 0;
            this.grbx_Statistic.TabStop = false;
            this.grbx_Statistic.Text = "Thống kê";
            // 
            // tbllaypn_Statistic
            // 
            this.tbllaypn_Statistic.ColumnCount = 1;
            this.tbllaypn_Statistic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_Statistic.Controls.Add(this.btn_StatisticExportToExcel, 0, 2);
            this.tbllaypn_Statistic.Controls.Add(this.btn_StatisticExportToImage, 0, 1);
            this.tbllaypn_Statistic.Controls.Add(this.btn_StatisticCancel, 0, 0);
            this.tbllaypn_Statistic.Location = new System.Drawing.Point(1167, 158);
            this.tbllaypn_Statistic.Name = "tbllaypn_Statistic";
            this.tbllaypn_Statistic.RowCount = 3;
            this.tbllaypn_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.38235F));
            this.tbllaypn_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.61765F));
            this.tbllaypn_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tbllaypn_Statistic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbllaypn_Statistic.Size = new System.Drawing.Size(186, 272);
            this.tbllaypn_Statistic.TabIndex = 0;
            // 
            // btn_StatisticExportToExcel
            // 
            this.btn_StatisticExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_StatisticExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_StatisticExportToExcel.FlatAppearance.BorderSize = 0;
            this.btn_StatisticExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatisticExportToExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_StatisticExportToExcel.Location = new System.Drawing.Point(41, 189);
            this.btn_StatisticExportToExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StatisticExportToExcel.Name = "btn_StatisticExportToExcel";
            this.btn_StatisticExportToExcel.Size = new System.Drawing.Size(103, 64);
            this.btn_StatisticExportToExcel.TabIndex = 0;
            this.btn_StatisticExportToExcel.Text = "Export to Excel";
            this.btn_StatisticExportToExcel.UseVisualStyleBackColor = false;
            this.btn_StatisticExportToExcel.Click += new System.EventHandler(this.btn_StatisticExportToExcel_Click);
            // 
            // btn_StatisticExportToImage
            // 
            this.btn_StatisticExportToImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_StatisticExportToImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_StatisticExportToImage.FlatAppearance.BorderSize = 0;
            this.btn_StatisticExportToImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatisticExportToImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_StatisticExportToImage.Location = new System.Drawing.Point(41, 84);
            this.btn_StatisticExportToImage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StatisticExportToImage.Name = "btn_StatisticExportToImage";
            this.btn_StatisticExportToImage.Size = new System.Drawing.Size(103, 64);
            this.btn_StatisticExportToImage.TabIndex = 0;
            this.btn_StatisticExportToImage.Text = "Export to Image";
            this.btn_StatisticExportToImage.UseVisualStyleBackColor = false;
            this.btn_StatisticExportToImage.Click += new System.EventHandler(this.btn_StatisticExportToImage_Click);
            // 
            // btn_StatisticCancel
            // 
            this.btn_StatisticCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_StatisticCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_StatisticCancel.FlatAppearance.BorderSize = 0;
            this.btn_StatisticCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StatisticCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_StatisticCancel.Location = new System.Drawing.Point(41, 11);
            this.btn_StatisticCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_StatisticCancel.Name = "btn_StatisticCancel";
            this.btn_StatisticCancel.Size = new System.Drawing.Size(104, 40);
            this.btn_StatisticCancel.TabIndex = 0;
            this.btn_StatisticCancel.Text = "Cancel";
            this.btn_StatisticCancel.UseVisualStyleBackColor = false;
            this.btn_StatisticCancel.Click += new System.EventHandler(this.btn_StatisticCancel_Click);
            // 
            // fllaypn_Statistic
            // 
            this.fllaypn_Statistic.Controls.Add(this.dgv_Statistic);
            this.fllaypn_Statistic.Location = new System.Drawing.Point(9, 40);
            this.fllaypn_Statistic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fllaypn_Statistic.Name = "fllaypn_Statistic";
            this.fllaypn_Statistic.Size = new System.Drawing.Size(1151, 614);
            this.fllaypn_Statistic.TabIndex = 0;
            // 
            // dgv_Statistic
            // 
            this.dgv_Statistic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_Statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Statistic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Statistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.dgv_Statistic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Statistic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Statistic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Statistic.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Statistic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Statistic.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.dgv_Statistic.Location = new System.Drawing.Point(5, 8);
            this.dgv_Statistic.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.dgv_Statistic.Name = "dgv_Statistic";
            this.dgv_Statistic.ReadOnly = true;
            this.dgv_Statistic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Statistic.RowHeadersVisible = false;
            this.dgv_Statistic.RowHeadersWidth = 51;
            this.dgv_Statistic.RowTemplate.Height = 29;
            this.dgv_Statistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Statistic.Size = new System.Drawing.Size(1135, 344);
            this.dgv_Statistic.TabIndex = 0;
            // 
            // grbx_Analyze
            // 
            this.grbx_Analyze.Controls.Add(this.tbllaypn_Analyze);
            this.grbx_Analyze.Controls.Add(this.rtb_Analyze);
            this.grbx_Analyze.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbx_Analyze.Location = new System.Drawing.Point(14, 686);
            this.grbx_Analyze.Name = "grbx_Analyze";
            this.grbx_Analyze.Size = new System.Drawing.Size(1350, 384);
            this.grbx_Analyze.TabIndex = 0;
            this.grbx_Analyze.TabStop = false;
            this.grbx_Analyze.Text = "Phân tích";
            // 
            // tbllaypn_Analyze
            // 
            this.tbllaypn_Analyze.ColumnCount = 1;
            this.tbllaypn_Analyze.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllaypn_Analyze.Controls.Add(this.btn_AnalyzeExportToExcel, 0, 2);
            this.tbllaypn_Analyze.Controls.Add(this.btn_AnalyzeExportToImage, 0, 1);
            this.tbllaypn_Analyze.Controls.Add(this.btn_AnalyzeCancel, 0, 0);
            this.tbllaypn_Analyze.Location = new System.Drawing.Point(1167, 62);
            this.tbllaypn_Analyze.Name = "tbllaypn_Analyze";
            this.tbllaypn_Analyze.RowCount = 3;
            this.tbllaypn_Analyze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.38235F));
            this.tbllaypn_Analyze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.61765F));
            this.tbllaypn_Analyze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tbllaypn_Analyze.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbllaypn_Analyze.Size = new System.Drawing.Size(186, 272);
            this.tbllaypn_Analyze.TabIndex = 0;
            // 
            // btn_AnalyzeExportToExcel
            // 
            this.btn_AnalyzeExportToExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AnalyzeExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_AnalyzeExportToExcel.FlatAppearance.BorderSize = 0;
            this.btn_AnalyzeExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnalyzeExportToExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AnalyzeExportToExcel.Location = new System.Drawing.Point(41, 189);
            this.btn_AnalyzeExportToExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AnalyzeExportToExcel.Name = "btn_AnalyzeExportToExcel";
            this.btn_AnalyzeExportToExcel.Size = new System.Drawing.Size(103, 64);
            this.btn_AnalyzeExportToExcel.TabIndex = 0;
            this.btn_AnalyzeExportToExcel.Text = "Export to Excel";
            this.btn_AnalyzeExportToExcel.UseVisualStyleBackColor = false;
            // 
            // btn_AnalyzeExportToImage
            // 
            this.btn_AnalyzeExportToImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AnalyzeExportToImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_AnalyzeExportToImage.FlatAppearance.BorderSize = 0;
            this.btn_AnalyzeExportToImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnalyzeExportToImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AnalyzeExportToImage.Location = new System.Drawing.Point(41, 84);
            this.btn_AnalyzeExportToImage.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AnalyzeExportToImage.Name = "btn_AnalyzeExportToImage";
            this.btn_AnalyzeExportToImage.Size = new System.Drawing.Size(103, 64);
            this.btn_AnalyzeExportToImage.TabIndex = 0;
            this.btn_AnalyzeExportToImage.Text = "Export to Image";
            this.btn_AnalyzeExportToImage.UseVisualStyleBackColor = false;
            // 
            // btn_AnalyzeCancel
            // 
            this.btn_AnalyzeCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AnalyzeCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_AnalyzeCancel.FlatAppearance.BorderSize = 0;
            this.btn_AnalyzeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnalyzeCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AnalyzeCancel.Location = new System.Drawing.Point(40, 11);
            this.btn_AnalyzeCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AnalyzeCancel.Name = "btn_AnalyzeCancel";
            this.btn_AnalyzeCancel.Size = new System.Drawing.Size(105, 40);
            this.btn_AnalyzeCancel.TabIndex = 0;
            this.btn_AnalyzeCancel.Text = "Cancel";
            this.btn_AnalyzeCancel.UseVisualStyleBackColor = false;
            // 
            // rtb_Analyze
            // 
            this.rtb_Analyze.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb_Analyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            this.rtb_Analyze.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Analyze.Location = new System.Drawing.Point(745, 23);
            this.rtb_Analyze.Name = "rtb_Analyze";
            this.rtb_Analyze.ReadOnly = true;
            this.rtb_Analyze.Size = new System.Drawing.Size(404, 345);
            this.rtb_Analyze.TabIndex = 0;
            this.rtb_Analyze.Text = "";
            //
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Name = "Biểu đồ thống kê";
            this.chart1.Size = new System.Drawing.Size(600, 200);
            this.chart1.Location = new System.Drawing.Point(600, 600);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Biểu đồ thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.fllaypn_Statistic.Controls.Add(chart1);
            this.ResumeLayout(false);
            // 
            // Form_View_Statistic_Analyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1378, 1082);
            this.Controls.Add(this.grbx_Analyze);
            this.Controls.Add(this.grbx_Statistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Form_View_Statistic_Analyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_View_Statistic_Analyze_Load);
            this.grbx_Statistic.ResumeLayout(false);
            this.tbllaypn_Statistic.ResumeLayout(false);
            this.fllaypn_Statistic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Statistic)).EndInit();
            this.grbx_Analyze.ResumeLayout(false);
            this.tbllaypn_Analyze.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.GroupBox grbx_Statistic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel fllaypn_Statistic;
        private System.Windows.Forms.DataGridView dgv_Statistic;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Statistic;
        private System.Windows.Forms.Button btn_StatisticExportToExcel;
        private System.Windows.Forms.Button btn_StatisticCancel;
        private System.Windows.Forms.Button btn_StatisticExportToImage;
        private System.Windows.Forms.GroupBox grbx_Analyze;
        private System.Windows.Forms.TableLayoutPanel tbllaypn_Analyze;
        private System.Windows.Forms.Button btn_AnalyzeExportToExcel;
        private System.Windows.Forms.Button btn_AnalyzeExportToImage;
        private System.Windows.Forms.Button btn_AnalyzeCancel;
        private System.Windows.Forms.RichTextBox rtb_Analyze;
    }
}