using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calenderWithUserControl
{
    public partial class fm_category : Form
    {
        Myoutlook parent;
        int updateIndex = -1;
        public fm_category()
        {
            InitializeComponent();
            parent = null;
        }
        public void setParent(Myoutlook f)
        {
            parent = f;
        }
        public void setNowTime(int s, int e)
        {
            dt_start.Value = new DateTime(dt_start.Value.Year, dt_start.Value.Month, dt_start.Value.Day, s / 60, s % 60, 0);
            dt_end.Value = new DateTime(dt_end.Value.Year, dt_end.Value.Month, dt_end.Value.Day, e / 60, e % 60, 0);

        }
        public DateTime getStartTime()
        {
            return dt_start.Value;
        }
        public DateTime getEndTime()
        {
            return dt_end.Value;
        }
        public String getCategoryInfo()
        {
            return tb_info.Text;
        }
        public String getCategoryTitle()
        {
            return tb_title.Text;
        }
        public void setCategory(DateTime s, DateTime e, String t, String info, int index)
        {
            dt_start.Value = s;
            dt_end.Value = e;
            tb_info.Text = info;
            tb_title.Text = t;
            updateIndex = index;
            bt_save.Text = "update";
            bt_delete.Visible = true;
        }

        public bool canAdd()
        {
            if (parent.validateTimeRange(dt_start.Value, dt_end.Value, updateIndex))
            {
                return true;
            }
            return false;
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {

        }
        private void fm_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.Ignore)
            {
                if (MessageBox.Show("Do you want to continue", "Alarm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    parent.removeCategory(updateIndex);
                }
                else
                {
                    e.Cancel = true;
                }

            }

            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                //if validate
                if (dt_end.Value < dt_start.Value)
                {
                    MessageBox.Show("EndTime must be bigger than StartTime");
                    e.Cancel = true;
                }
                /*
                if (canAdd())
                {
                    e.Cancel = false;
                }
                else
                {
                    MessageBox.Show("Time OverLapping!!!");
                    e.Cancel = true;
                }
                */
            }

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dt_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt_end_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }

        private void bt_close_Click(object sender, EventArgs e)
        {

        }

        private void tb_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
