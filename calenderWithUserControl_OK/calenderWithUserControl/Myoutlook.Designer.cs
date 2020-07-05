namespace calenderWithUserControl
{
    partial class Myoutlook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pl_time = new System.Windows.Forms.Panel();
            this.pl_timecontent = new System.Windows.Forms.Panel();
            this.pl_categoryPanel = new System.Windows.Forms.Panel();
            this.pl_category = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl_main = new System.Windows.Forms.Panel();
            this.pl_content = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_timeframe = new System.Windows.Forms.ComboBox();
            this.bt_prvDay = new System.Windows.Forms.Button();
            this.bt_nxtDay = new System.Windows.Forms.Button();
            this.bt_out = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.bt_setting = new System.Windows.Forms.Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pl_time.SuspendLayout();
            this.pl_categoryPanel.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Controls.Add(this.pl_time, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pl_categoryPanel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pl_main, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.559444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.779222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66134F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1322, 754);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pl_time
            // 
            this.pl_time.Controls.Add(this.pl_timecontent);
            this.pl_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_time.Location = new System.Drawing.Point(3, 111);
            this.pl_time.Name = "pl_time";
            this.pl_time.Size = new System.Drawing.Size(60, 640);
            this.pl_time.TabIndex = 0;
            // 
            // pl_timecontent
            // 
            this.pl_timecontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_timecontent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_timecontent.Location = new System.Drawing.Point(10, 3);
            this.pl_timecontent.Name = "pl_timecontent";
            this.pl_timecontent.Size = new System.Drawing.Size(47, 623);
            this.pl_timecontent.TabIndex = 0;
            this.pl_timecontent.Click += new System.EventHandler(this.pl_timecontent_Click);
            this.pl_timecontent.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_timecontent_Paint);
            this.pl_timecontent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pl_timecontent_MouseClick);
            // 
            // pl_categoryPanel
            // 
            this.pl_categoryPanel.Controls.Add(this.pl_category);
            this.pl_categoryPanel.Controls.Add(this.panel2);
            this.pl_categoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_categoryPanel.Location = new System.Drawing.Point(69, 54);
            this.pl_categoryPanel.Name = "pl_categoryPanel";
            this.pl_categoryPanel.Size = new System.Drawing.Size(1236, 51);
            this.pl_categoryPanel.TabIndex = 1;
            // 
            // pl_category
            // 
            this.pl_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.pl_category.Location = new System.Drawing.Point(3, 3);
            this.pl_category.Name = "pl_category";
            this.pl_category.Size = new System.Drawing.Size(1240, 45);
            this.pl_category.TabIndex = 1;
            this.pl_category.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_category_Paint);
            this.pl_category.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pl_category_MouseClick);
            this.pl_category.MouseLeave += new System.EventHandler(this.pl_category_MouseLeave);
            this.pl_category.MouseHover += new System.EventHandler(this.pl_category_MouseHover);
            this.pl_category.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pl_category_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(3, -78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2165, 18);
            this.panel2.TabIndex = 0;
            // 
            // pl_main
            // 
            this.pl_main.AutoScroll = true;
            this.pl_main.Controls.Add(this.pl_content);
            this.pl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_main.Location = new System.Drawing.Point(69, 111);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(1236, 640);
            this.pl_main.TabIndex = 2;
            this.pl_main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pl_main_Scroll);
            this.pl_main.LocationChanged += new System.EventHandler(this.pl_main_LocationChanged);
            this.pl_main.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pl_main_MouseWheel);
            // 
            // pl_content
            // 
            this.pl_content.BackColor = System.Drawing.Color.White;
            this.pl_content.Location = new System.Drawing.Point(3, 3);
            this.pl_content.Name = "pl_content";
            this.pl_content.Size = new System.Drawing.Size(1240, 623);
            this.pl_content.TabIndex = 0;
            this.pl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_content_Paint);
            this.pl_content.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pl_content_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.05F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.05F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.05F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.139999F));
            this.tableLayoutPanel2.Controls.Add(this.cb_timeframe, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_prvDay, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_nxtDay, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_out, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_in, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_setting, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_date, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(69, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1236, 35);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cb_timeframe
            // 
            this.cb_timeframe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_timeframe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timeframe.FormattingEnabled = true;
            this.cb_timeframe.Items.AddRange(new object[] {
            "15 Min",
            "30 Min",
            "1 Hour",
            "2 Hours"});
            this.cb_timeframe.Location = new System.Drawing.Point(3, 3);
            this.cb_timeframe.Name = "cb_timeframe";
            this.cb_timeframe.Size = new System.Drawing.Size(119, 21);
            this.cb_timeframe.TabIndex = 0;
            this.cb_timeframe.SelectedIndexChanged += new System.EventHandler(this.cb_timeframe_SelectedIndexChanged);
            // 
            // bt_prvDay
            // 
            this.bt_prvDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_prvDay.Location = new System.Drawing.Point(530, 3);
            this.bt_prvDay.Name = "bt_prvDay";
            this.bt_prvDay.Size = new System.Drawing.Size(31, 29);
            this.bt_prvDay.TabIndex = 1;
            this.bt_prvDay.Text = "<";
            this.bt_prvDay.UseVisualStyleBackColor = true;
            this.bt_prvDay.Click += new System.EventHandler(this.bt_prvDay_Click);
            // 
            // bt_nxtDay
            // 
            this.bt_nxtDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_nxtDay.Location = new System.Drawing.Point(692, 3);
            this.bt_nxtDay.Name = "bt_nxtDay";
            this.bt_nxtDay.Size = new System.Drawing.Size(30, 29);
            this.bt_nxtDay.TabIndex = 2;
            this.bt_nxtDay.Text = ">";
            this.bt_nxtDay.UseVisualStyleBackColor = true;
            this.bt_nxtDay.Click += new System.EventHandler(this.bt_nxtDay_Click);
            // 
            // bt_out
            // 
            this.bt_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_out.Location = new System.Drawing.Point(1059, 3);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(31, 29);
            this.bt_out.TabIndex = 3;
            this.bt_out.Text = "-";
            this.bt_out.UseVisualStyleBackColor = true;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_in
            // 
            this.bt_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_in.Location = new System.Drawing.Point(1096, 3);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(31, 29);
            this.bt_in.TabIndex = 5;
            this.bt_in.Text = "+";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // bt_setting
            // 
            this.bt_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_setting.Location = new System.Drawing.Point(1133, 3);
            this.bt_setting.Name = "bt_setting";
            this.bt_setting.Size = new System.Drawing.Size(100, 29);
            this.bt_setting.TabIndex = 7;
            this.bt_setting.Text = "Setting";
            this.bt_setting.UseVisualStyleBackColor = true;
            this.bt_setting.Click += new System.EventHandler(this.bt_setting_Click);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(567, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(119, 35);
            this.lb_date.TabIndex = 8;
            this.lb_date.Text = "label1";
            this.lb_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Myoutlook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Myoutlook";
            this.Size = new System.Drawing.Size(1322, 754);
            this.Resize += new System.EventHandler(this.Myoutlook_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pl_time.ResumeLayout(false);
            this.pl_categoryPanel.ResumeLayout(false);
            this.pl_main.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pl_time;
        private System.Windows.Forms.Panel pl_timecontent;
        private System.Windows.Forms.Panel pl_categoryPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Panel pl_content;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_timeframe;
        private System.Windows.Forms.Button bt_prvDay;
        private System.Windows.Forms.Button bt_nxtDay;
        private System.Windows.Forms.Button bt_out;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.Button bt_setting;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Panel pl_category;
    }
}
