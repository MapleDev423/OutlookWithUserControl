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
    public partial class AddFrame : Form
    {
        Myoutlook parent;
        int m_ca;
        int m_t;
        public AddFrame()
        {
            InitializeComponent();
            parent = null;
            m_ca = -1;
            m_t = -1;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }
        public int sTime()
        {
            return dt_start.Value.Hour * 60 + dt_start.Value.Minute;
        }
        public int eTime()
        {
            return dt_end.Value.Hour * 60 + dt_end.Value.Minute;
        }
        public String info()
        {
            return tb_info.Text;
        }
        public void setStartTime(int s)
        {
            dt_start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, s / 60, s % 60, 0);
            dt_end.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, s / 60 + 1, s % 60, 0);

            // dt_start.Value.Hour = s / 60;
            // dt_start.Value.Minute = s % 60;
        }
        public void setFrame(int s, int e, string inf, Myoutlook f, int cn, int tn)
        {
            dt_start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, s / 60, s % 60, 0);
            dt_end.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, e / 60, e % 60, 0);
            tb_info.Text = inf;
            bt_save.Text = "Update";
            bt_delete.Visible = true;
            parent = f;
            m_ca = cn;
            m_t = tn;
        }

        private void AddFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.Ignore)
            {
                if (MessageBox.Show("Do you want to continue", "Alarm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    parent.removeTimeFrame(m_ca, m_t);
                }
                else
                {
                    e.Cancel = true;
                }

            }
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                if (dt_start.Value > dt_end.Value)
                {
                    MessageBox.Show("EndTime must be bigger than StartTime");
                    e.Cancel = true;
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void dt_end_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
