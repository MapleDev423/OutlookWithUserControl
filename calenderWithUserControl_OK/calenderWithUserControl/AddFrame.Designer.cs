namespace calenderWithUserControl
{
    partial class AddFrame
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_info = new System.Windows.Forms.RichTextBox();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_delete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Info";
            // 
            // tb_info
            // 
            this.tb_info.Location = new System.Drawing.Point(24, 121);
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(281, 125);
            this.tb_info.TabIndex = 13;
            this.tb_info.Text = "";
            // 
            // dt_end
            // 
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_end.Location = new System.Drawing.Point(109, 50);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(196, 20);
            this.dt_end.TabIndex = 12;
            this.dt_end.ValueChanged += new System.EventHandler(this.dt_end_ValueChanged);
            // 
            // dt_start
            // 
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_start.Location = new System.Drawing.Point(109, 16);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(196, 20);
            this.dt_start.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "EndTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "StartTime";
            // 
            // bt_save
            // 
            this.bt_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_save.Location = new System.Drawing.Point(3, 3);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(71, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(157, 3);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(71, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_save);
            this.flowLayoutPanel1.Controls.Add(this.bt_delete);
            this.flowLayoutPanel1.Controls.Add(this.bt_cancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 261);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 40);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // bt_delete
            // 
            this.bt_delete.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.bt_delete.Location = new System.Drawing.Point(80, 3);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(71, 23);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Visible = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // AddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "AddFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFrame_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tb_info;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_delete;

    }
}