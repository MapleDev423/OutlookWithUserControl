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
    public partial class SettingForm : Form
    {
        Color m_outline, m_category, m_categoryBoxColor, m_categoryBoxOutline, m_timeframeBoxColor, m_timeframeOutline, m_cateFont, m_timeFont;
        Myoutlook parent;
        public SettingForm(Myoutlook p)
        {
            InitializeComponent();
            parent = p;
            //  m_outline = null;
            //  m_category = null;
        }
        public void setNowValue(Color o, Color c, Color cb, Color cl, Color tc, Color tl, Color cf, Color tf,int sti,int eti)
        {
            m_outline = o;
            m_category = c;
            m_categoryBoxColor = cb;
            m_categoryBoxOutline = cl;
            m_timeframeBoxColor = tc;
            m_timeframeOutline = tl;
            m_cateFont = cf;
            m_timeFont = tf;

            bt_outline.BackColor = m_outline;
            bt_category.BackColor = m_category;
            bt_categoryBox.BackColor = cb;
            bt_categoryOutline.BackColor = cl;
            bt_timeframeBox.BackColor = tc;
            bt_timeframeOutline.BackColor = tl;
            bt_cateFont.BackColor = m_cateFont;
            bt_timeFont.BackColor = m_timeFont;
            //bt_category.BackColor = m_category;
            trackBar1.Value = m_outline.A;
            trackBar2.Value = m_category.A;
            trackBar3.Value = m_categoryBoxColor.A;
            trackBar4.Value = m_categoryBoxOutline.A;
            trackBar5.Value = m_timeframeBoxColor.A;
            trackBar6.Value = m_timeframeOutline.A;
            trackBar7.Value = m_cateFont.A;
            trackBar8.Value = m_timeFont.A;

            dt_start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, sti / 60, sti % 60,0);
            dt_end.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, eti / 60, eti % 60,0);


        }
        public void setColorVariable(Color outl, Color cate)
        {
            m_outline = outl;
            m_category = cate;
        }
        public Color OpenColorDialog()
        {
            cdlg.ShowDialog();
            return cdlg.Color;
        }

        private void bt_outline_Click(object sender, EventArgs e)
        {
            m_outline = OpenColorDialog();
            m_outline = Color.FromArgb((int)trackBar1.Value, m_outline.R, m_outline.G, m_outline.B);
            bt_outline.BackColor = m_outline;
            parent.setOutlineColor(m_outline);
        }

        private void bt_category_Click(object sender, EventArgs e)
        {
            //  m_outline = OpenColorDialog();
            m_category = OpenColorDialog();
            m_category = Color.FromArgb((int)trackBar2.Value, m_category.R, m_category.G, m_category.B);

            bt_category.BackColor = m_category;

            parent.setCategoryColor(m_category);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
        private void bt_categoryBox_Click(object sender, EventArgs e)
        {
            m_categoryBoxColor = OpenColorDialog();
            m_categoryBoxColor = Color.FromArgb((int)trackBar3.Value, m_categoryBoxColor.R, m_categoryBoxColor.G, m_categoryBoxColor.B);
            bt_categoryBox.BackColor = m_categoryBoxColor;

            parent.setCategoryBoxColor(m_categoryBoxColor);
        }
        private void bt_categoryOutline_Click(object sender, EventArgs e)
        {
            m_categoryBoxOutline = OpenColorDialog();
            m_categoryBoxOutline = Color.FromArgb((int)trackBar4.Value, m_categoryBoxOutline.R, m_categoryBoxOutline.G, m_categoryBoxOutline.B);
            bt_categoryOutline.BackColor = m_categoryBoxOutline;

            parent.setCategoryBoxOutlineColor(m_categoryBoxOutline);
        }
        private void bt_timeframeBox_Click(object sender, EventArgs e)
        {
            m_timeframeBoxColor = OpenColorDialog();
            m_timeframeBoxColor = Color.FromArgb((int)trackBar5.Value, m_timeframeBoxColor.R, m_timeframeBoxColor.G, m_timeframeBoxColor.B);
            bt_timeframeBox.BackColor = m_timeframeBoxColor;

            parent.setTimeframeBoxColor(m_timeframeBoxColor);
        }
        private void bt_timeframeOutline_Click(object sender, EventArgs e)
        {
            m_timeframeOutline = OpenColorDialog();
            m_timeframeOutline = Color.FromArgb((int)trackBar6.Value, m_timeframeOutline.R, m_timeframeOutline.G, m_timeframeOutline.B);
            bt_timeframeOutline.BackColor = m_timeframeOutline;
            parent.setTimeframeOutline(m_timeframeOutline);
        }
        private void bt_timeBar_Click(object sender, EventArgs e)
        {
            parent.setTimeBoxColor(OpenColorDialog());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nd_timeline_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nd_outline_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nd_category_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nd_catebox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nd_catline_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            m_outline = Color.FromArgb((int)trackBar1.Value, m_outline.R, m_outline.G, m_outline.B);
            parent.setOutlineColor(m_outline);
            bt_outline.BackColor = m_outline;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            m_category = Color.FromArgb((int)trackBar2.Value, m_category.R, m_category.G, m_category.B);
            bt_category.BackColor = m_category;
            parent.setCategoryColor(m_category);

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            m_categoryBoxColor = Color.FromArgb((int)trackBar3.Value, m_categoryBoxColor.R, m_categoryBoxColor.G, m_categoryBoxColor.B);
            bt_categoryBox.BackColor = m_categoryBoxColor;
            parent.setCategoryBoxColor(m_categoryBoxColor);
            //parent.
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            m_categoryBoxOutline = Color.FromArgb((int)trackBar4.Value, m_categoryBoxOutline.R, m_categoryBoxOutline.G, m_categoryBoxOutline.B);
            bt_categoryOutline.BackColor = m_categoryBoxOutline;
            //parent.setCategoryColor(m_categoryBoxOutline);
            parent.setCategoryBoxOutlineColor(m_categoryBoxOutline);
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            m_timeframeBoxColor = Color.FromArgb((int)trackBar5.Value, m_timeframeBoxColor.R, m_timeframeBoxColor.G, m_timeframeBoxColor.B);
            bt_timeframeBox.BackColor = m_timeframeBoxColor;
            //parent.setCategoryColor(m_timeframeBoxColor);
            parent.setTimeframeBoxColor(m_timeframeBoxColor);
        }

        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            m_timeframeOutline = Color.FromArgb((int)trackBar6.Value, m_timeframeOutline.R, m_timeframeOutline.G, m_timeframeOutline.B);
            bt_timeframeOutline.BackColor = m_timeframeOutline;
            parent.setTimeframeOutline(m_timeframeOutline);
        }

        private void trackBar7_ValueChanged(object sender, EventArgs e)
        {
            m_cateFont = Color.FromArgb((int)trackBar7.Value, m_cateFont.R, m_cateFont.G, m_cateFont.B);
            bt_cateFont.BackColor = m_cateFont;
            parent.setCateFontColor(m_cateFont);
        }

        private void trackBar8_ValueChanged(object sender, EventArgs e)
        {
            m_timeFont = Color.FromArgb((int)trackBar8.Value, m_timeFont.R, m_timeFont.G, m_timeFont.B);
            bt_timeFont.BackColor = m_timeFont;
            parent.setTimeFontColor(m_timeFont);
        }

        private void bt_cateFont_Click(object sender, EventArgs e)
        {
            m_cateFont = OpenColorDialog();
            m_cateFont = Color.FromArgb((int)trackBar7.Value, m_cateFont.R, m_cateFont.G, m_cateFont.B);
            bt_cateFont.BackColor = m_cateFont;
            parent.setCateFontColor(m_cateFont);
        }

        private void bt_timeFont_Click(object sender, EventArgs e)
        {
            m_timeFont = OpenColorDialog();
            m_timeFont = Color.FromArgb((int)trackBar8.Value, m_timeFont.R, m_timeFont.G, m_timeFont.B);
            bt_timeFont.BackColor = m_timeFont;
            parent.setTimeFontColor(m_timeFont);
        }
        private void dt_start_ValueChanged(object sender, EventArgs e)
        {
            parent.setTimeRange(dt_start.Value, dt_end.Value);
        }

        private void dt_end_ValueChanged(object sender, EventArgs e)
        {
            parent.setTimeRange(dt_start.Value, dt_end.Value);
        }
        private void trackBar7_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SettingForm_Load_1(object sender, EventArgs e)
        {

        }

       
    }
}
