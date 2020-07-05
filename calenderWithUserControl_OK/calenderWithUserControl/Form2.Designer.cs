namespace calenderWithUserControl
{
    partial class fm_category
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.tb_info = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.tb_title = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.9624F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Controls.Add(this.dt_end, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dt_start, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_info, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_title, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.65217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.34783F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 367);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dt_end
            // 
            this.dt_end.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_end.Location = new System.Drawing.Point(50, 80);
            this.dt_end.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(283, 20);
            this.dt_end.TabIndex = 1;
            this.dt_end.ValueChanged += new System.EventHandler(this.dt_end_ValueChanged);
            // 
            // dt_start
            // 
            this.dt_start.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_start.Location = new System.Drawing.Point(50, 30);
            this.dt_start.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(283, 20);
            this.dt_start.TabIndex = 0;
            this.dt_start.ValueChanged += new System.EventHandler(this.dt_start_ValueChanged);
            // 
            // tb_info
            // 
            this.tb_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_info.Location = new System.Drawing.Point(50, 168);
            this.tb_info.Margin = new System.Windows.Forms.Padding(0);
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(283, 135);
            this.tb_info.TabIndex = 2;
            this.tb_info.Text = "";
            this.tb_info.TextChanged += new System.EventHandler(this.tb_info_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "End";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_delete);
            this.flowLayoutPanel1.Controls.Add(this.bt_close);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 321);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 43);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // bt_save
            // 
            this.bt_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_save.Location = new System.Drawing.Point(3, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 0;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.bt_delete.Location = new System.Drawing.Point(84, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 2;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_close
            // 
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Location = new System.Drawing.Point(165, 3);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // tb_title
            // 
            this.tb_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_title.Location = new System.Drawing.Point(50, 118);
            this.tb_title.Margin = new System.Windows.Forms.Padding(0);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(283, 35);
            this.tb_title.TabIndex = 7;
            this.tb_title.Text = "";
            this.tb_title.TextChanged += new System.EventHandler(this.tb_title_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Info";
            // 
            // fm_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "fm_category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_category_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.RichTextBox tb_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.RichTextBox tb_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}