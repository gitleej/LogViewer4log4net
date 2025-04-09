namespace LogViewer4log4net
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLogDir = new System.Windows.Forms.TextBox();
            this.btnLoadLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLogLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKeyWords = new System.Windows.Forms.TextBox();
            this.checkBoxRegExp = new System.Windows.Forms.CheckBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.dgvLogViewer = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNoFilter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogViewer)).BeginInit();
            this.SuspendLayout();
            this.Controls.Add(tableLayoutPanel1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvLogViewer, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 681);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tbLogDir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLoadLog, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 35);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbLogDir
            // 
            this.tbLogDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogDir.Location = new System.Drawing.Point(3, 7);
            this.tbLogDir.Name = "tbLogDir";
            this.tbLogDir.Size = new System.Drawing.Size(997, 21);
            this.tbLogDir.TabIndex = 0;
            // 
            // btnLoadLog
            // 
            this.btnLoadLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadLog.Location = new System.Drawing.Point(1006, 3);
            this.btnLoadLog.Name = "btnLoadLog";
            this.btnLoadLog.Size = new System.Drawing.Size(94, 29);
            this.btnLoadLog.TabIndex = 1;
            this.btnLoadLog.Text = "打开日志";
            this.btnLoadLog.UseVisualStyleBackColor = true;
            this.btnLoadLog.Click += new System.EventHandler(this.btnLoadLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "筛选";
            this.groupBox1.Controls.Add(tableLayoutPanel3);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpBegin, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtpEnd, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbLogLevel, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbKeyWords, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxRegExp, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnApplyFilter, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnNoFilter, 10, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1091, 34);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(203, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBegin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(53, 6);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.ShowUpDown = true;
            this.dtpBegin.Size = new System.Drawing.Size(144, 21);
            this.dtpBegin.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(223, 6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(144, 21);
            this.dtpEnd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(373, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "级别：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLogLevel
            // 
            this.cbLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogLevel.FormattingEnabled = true;
            this.cbLogLevel.Location = new System.Drawing.Point(423, 7);
            this.cbLogLevel.Name = "cbLogLevel";
            this.cbLogLevel.Size = new System.Drawing.Size(94, 20);
            this.cbLogLevel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(523, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "关键字：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbKeyWords
            // 
            this.tbKeyWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeyWords.Location = new System.Drawing.Point(583, 6);
            this.tbKeyWords.Name = "tbKeyWords";
            this.tbKeyWords.Size = new System.Drawing.Size(194, 21);
            this.tbKeyWords.TabIndex = 7;
            // 
            // checkBoxRegExp
            // 
            this.checkBoxRegExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRegExp.AutoSize = true;
            this.checkBoxRegExp.Location = new System.Drawing.Point(783, 9);
            this.checkBoxRegExp.Name = "checkBoxRegExp";
            this.checkBoxRegExp.Size = new System.Drawing.Size(94, 16);
            this.checkBoxRegExp.TabIndex = 8;
            this.checkBoxRegExp.Text = "正则表达式";
            this.checkBoxRegExp.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApplyFilter.Location = new System.Drawing.Point(883, 3);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(94, 28);
            this.btnApplyFilter.TabIndex = 9;
            this.btnApplyFilter.Text = "查找";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // dgvLogViewer
            // 
            this.dgvLogViewer.AllowUserToAddRows = false;
            this.dgvLogViewer.AllowUserToDeleteRows = false;
            this.dgvLogViewer.AllowUserToResizeColumns = false;
            this.dgvLogViewer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Timestamp,
            this.ThreadId,
            this.Level,
            this.Message});
            this.dgvLogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogViewer.Location = new System.Drawing.Point(3, 98);
            this.dgvLogViewer.Name = "dgvLogViewer";
            this.dgvLogViewer.RowHeadersVisible = false;
            this.dgvLogViewer.RowTemplate.Height = 23;
            this.dgvLogViewer.Size = new System.Drawing.Size(1097, 580);
            this.dgvLogViewer.TabIndex = 2;
            this.dgvLogViewer.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogViewer_CellMouseEnter);
            this.dgvLogViewer.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogViewer_CellMouseLeave);
            // 
            // Index
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Index.DefaultCellStyle = dataGridViewCellStyle2;
            this.Index.HeaderText = "行";
            this.Index.Name = "Index";
            this.Index.Width = 60;
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "时间戳";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.Width = 200;
            // 
            // ThreadId
            // 
            this.ThreadId.HeaderText = "线程";
            this.ThreadId.Name = "ThreadId";
            // 
            // Level
            // 
            this.Level.HeaderText = "级别";
            this.Level.Name = "Level";
            this.Level.Width = 60;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "内容";
            this.Message.Name = "Message";
            // 
            // btnNoFilter
            // 
            this.btnNoFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNoFilter.Location = new System.Drawing.Point(983, 3);
            this.btnNoFilter.Name = "btnNoFilter";
            this.btnNoFilter.Size = new System.Drawing.Size(94, 28);
            this.btnNoFilter.TabIndex = 10;
            this.btnNoFilter.Text = "取消过滤";
            this.btnNoFilter.UseVisualStyleBackColor = true;
            this.btnNoFilter.Click += new System.EventHandler(this.btnNoFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1103, 681);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log4Net日志查看器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLogDir;
        private System.Windows.Forms.Button btnLoadLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLogLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKeyWords;
        private System.Windows.Forms.CheckBox checkBoxRegExp;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.DataGridView dgvLogViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button btnNoFilter;
    }
}

