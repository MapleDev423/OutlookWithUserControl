using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
namespace calenderWithUserControl
{
    public partial class Myoutlook : UserControl
    {
        //#define
        int m_category_width = 200;
        int m_timeframe_height = 40;//(for)
        int m_categoryMargin = 0;
        //define--end

        List<Category> m_categoryList;
        List<int> m_categoryVisibleList;
        int m_timeP;

        DateTime m_nowDate;

        bool m_catehover;
        int m_catHoverIndex;

        //color 
        const string userRoot = "HKEY_CURRENT_USER";
        const string subkey = "MyOutlook";
        const string keyName = userRoot + "\\" + subkey;
        string outkey = "outline";
        string catekey = "cateKey";
        string cateBoxkey = "cateBoxkey";
        string cateOutkey = "cateOutkey";
        string tBoxkey = "tBoxkey";
        string tOutkey = "tOutkey";
        string cateFontkey = "cateFontColorkey";
        string timeFontkey = "timeFontColorkey";
        string timeRangeSkey = "timeRangeS";
        string timeRangeEkey = "timeRangeE";

     
        SettingForm m_settingform;
        Color m_outline;
        Color m_cateColor;

        Color m_categoryBoxColor;
        Color m_categoryBoxOutline;
        Color m_timeframeBoxColor;
        Color m_timeframeOutline;

        Color m_timeBarColor;

        Color m_cateFontColor;
        Color m_timeFontColor;

        int m_trangS, m_trangE;
        public Myoutlook()
        {
            InitializeComponent();
            initVal();
           // initTimeHeight();
            initColor();
            loadInfo();

        }
        public void initVal()
        {
            m_categoryList = new List<Category>();
            m_categoryVisibleList = new List<int>();
            m_timeP = 30;
            cb_timeframe.SelectedIndex = 1;
            m_nowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,0,0,0);
            m_catehover = false;
            m_catHoverIndex = 0;
            invalidateDateLbl();
        }
        public void initColor()
        {
            m_settingform = new SettingForm(this);
            Byte[] clrtemp = (Byte[])Registry.GetValue(keyName, outkey, new Byte[] { 255, 141, 173, 216}/*Color.FromArgb(197, 214, 236)*/);
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 141, 173, 216 };
            m_outline = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);
            
            clrtemp = (Byte[])Registry.GetValue(keyName, catekey, new Byte[] { 255, 197, 214, 236 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 197, 214, 236 };
            m_cateColor = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, cateBoxkey, new Byte[] { 50, 197, 214, 236 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 50, 197, 214, 236 };
            m_categoryBoxColor = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, cateOutkey, new Byte[] { 255, 141, 173, 216 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 141, 173, 216 };
            m_categoryBoxOutline = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, tBoxkey, new Byte[] { 200, 197, 214, 236 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 200, 197, 214, 236 };
            m_timeframeBoxColor = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, tOutkey, new Byte[] { 255, 141, 173, 216 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 141, 173, 216 };
            m_timeframeOutline = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, cateFontkey, new Byte[] { 255, 21, 53, 66 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 21, 53, 66 };
            m_cateFontColor = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            clrtemp = (Byte[])Registry.GetValue(keyName, timeFontkey, new Byte[] { 255, 51, 83, 126 });
            if (clrtemp == null)
                clrtemp = new Byte[] { 255, 51, 83, 126 };
            m_timeFontColor = Color.FromArgb(clrtemp[0], clrtemp[1], clrtemp[2], clrtemp[3]);

            m_trangS = (int)Registry.GetValue(keyName, timeRangeSkey, 480);
            m_trangE = (int)Registry.GetValue(keyName, timeRangeEkey, 960);

            m_settingform.setNowValue(
                m_outline,
                m_cateColor,
                m_categoryBoxColor,
                m_categoryBoxOutline,
                m_timeframeBoxColor,
                m_timeframeOutline,
                m_cateFontColor,
                m_timeFontColor,
                m_trangS,
                m_trangE
                );
        }
        public void invalidateDateLbl()
        {
            lb_date.Text = m_nowDate.ToString("MMM d yyyy");
        }

        public void initTimeHeight()
        {
            pl_content.Size = new Size(pl_content.Size.Width, 12 * (120 / m_timeP) * m_timeframe_height);
            pl_timecontent.Size= new Size(pl_timecontent.Size.Width, 12 * (120 / m_timeP) * m_timeframe_height);
        }
        public void resetVisibleCategory()
        {
            m_categoryVisibleList.Clear();
            for (int i = 0; i < m_categoryList.Count; i++)
            {
                if (CanEnable(i))
                {
                    m_categoryVisibleList.Add(i);
                }
            }

        }
        public void addCategory(DateTime s,DateTime e,String title, String inf)
        {
            Category cateTemp = new Category(s, e,title, inf);
            m_categoryList.Add(cateTemp);
            resetVisibleCategory();
            invalidateRelateWithCategory();
            saveInfo();
        }
        public void updateCategory(int index,DateTime s, DateTime e, String title, String inf)
        {
            m_categoryList[index].setStime(s);
            m_categoryList[index].setEtime(e);
            m_categoryList[index].setTitle(title);
            m_categoryList[index].setInfo(inf);
            resetVisibleCategory();

            invalidateRelateWithCategory();

            saveInfo();
        }
        public void removeCategory(int upindex)
        {
            m_categoryList.RemoveAt(upindex);
            resetVisibleCategory();

            invalidateRelateWithCategory();

            saveInfo();
        }
        public bool validateTimeRange(DateTime s, DateTime e,int upIndex)
        {
            DateTime ns = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, s.Hour, s.Minute, 0);
            DateTime ne = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, e.Hour, e.Minute, 0);
            if (ns > ne)
            {
                return false;
            }
            for (int i = 0; i < m_categoryList.Count; i++)
            {
                if (!((ns >= m_categoryList[i].endTime() && ne >= m_categoryList[i].endTime()) || (ns <= m_categoryList[i].startTime() && ne <= m_categoryList[i].startTime())))
                {
                    if (i != upIndex)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }
        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pl_main_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            pl_timecontent.Top = pl_content.Top;
        }

        private void pl_category_MouseHover(object sender, EventArgs e)
        {
            m_catehover = true;
            Point pos = pl_category.PointToClient(Cursor.Position);
            int i = pos.X / m_category_width;
            if (i <= m_categoryVisibleList.Count)
            {
                //Mouse.OverrideCursor = Cursors.Hand;
               // this.Cursor = Cursors.Hand;
               // if (i != m_catHoverIndex)
                {
                    m_catHoverIndex = i;
                    pl_category.Invalidate();
                }
            }
           
        }
        private void pl_category_MouseMove(object sender, MouseEventArgs e)
        {
            Point pos = pl_category.PointToClient(Cursor.Position);
            int i = pos.X / m_category_width;
            if (i <= m_categoryVisibleList.Count)
            {
                if (i != m_catHoverIndex)
                {
                    m_catHoverIndex = i;
                    pl_category.Invalidate();
                }
                this.Cursor = Cursors.Hand;

            }
            else
            {
                this.Cursor = Cursors.Arrow;

            }
        }
        private void pl_category_MouseLeave(object sender, EventArgs e)
        {
            m_catehover = false;
            this.Cursor = Cursors.Arrow;

            pl_category.Invalidate();

        }
        private void pl_category_Paint(object sender, PaintEventArgs e)
        {
            float ph = pl_category.Size.Height;

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            Color customColor = Color.FromArgb(50,100, 100, 100);
            SolidBrush shadowBrush = new SolidBrush(customColor);
            if ((m_categoryVisibleList.Count == m_catHoverIndex) && m_catehover)
                e.Graphics.FillRectangle(shadowBrush, new Rectangle(new Point(m_catHoverIndex * m_category_width, m_categoryMargin), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)));

            for (int i = 0; i < m_categoryVisibleList.Count; i++)
            {
                if(i == m_catHoverIndex && m_catehover)
                    e.Graphics.FillRectangle(shadowBrush, new Rectangle(new Point(i * m_category_width, m_categoryMargin), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)));
                    else
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(m_outline), 2), new Rectangle(new Point(i * m_category_width, m_categoryMargin), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)));

                e.Graphics.DrawString(m_categoryList[m_categoryVisibleList[i]].categoryTitle(), new Font("Arial", 13), new SolidBrush(m_cateFontColor), new Rectangle(new Point(i * m_category_width, m_categoryMargin + 5), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)), drawFormat);
            }
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(m_outline)), new Rectangle(new Point(m_category_width * m_categoryVisibleList.Count, m_categoryMargin), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)));
            e.Graphics.DrawString("+", new Font("Arial", 13), new SolidBrush(m_cateFontColor), new Rectangle(new Point(m_category_width * m_categoryVisibleList.Count, m_categoryMargin + 5), new Size(m_category_width, (int)ph - 2 * m_categoryMargin)), drawFormat);

        }

        private void pl_category_MouseClick(object sender, MouseEventArgs e)
        {
            int i = e.X / m_category_width;

            if (i == m_categoryVisibleList.Count)//Add Button
            {
                //add category
                fm_category fm = new fm_category();
                fm.setParent(this);
                fm.setNowTime(m_trangS, m_trangE);
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    int year = m_nowDate.Year;
                    int month = m_nowDate.Month;
                    int day = m_nowDate.Day;
                    addCategory(new DateTime(year, month, day, fm.getStartTime().Hour, fm.getStartTime().Minute, 0), new DateTime(year, month, day, fm.getEndTime().Hour, fm.getEndTime().Minute, 0),fm.getCategoryTitle() , fm.getCategoryInfo());
                }
                //
            }
            else if (i < m_categoryVisibleList.Count)
            {
                fm_category fm = new fm_category();
                fm.setParent(this);
                fm.setCategory(m_categoryList[m_categoryVisibleList[i]].startTime(), m_categoryList[m_categoryVisibleList[i]].endTime(), m_categoryList[m_categoryVisibleList[i]].categoryTitle(), m_categoryList[i].categoryInfo(), m_categoryVisibleList[i]);
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    int year = m_nowDate.Year;
                    int month = m_nowDate.Month;
                    int day = m_nowDate.Day;
                    updateCategory(m_categoryVisibleList[i], new DateTime(year, month, day, fm.getStartTime().Hour, fm.getStartTime().Minute, 0), new DateTime(year, month, day, fm.getEndTime().Hour, fm.getEndTime().Minute, 0), fm.getCategoryTitle(), fm.getCategoryInfo());
                }
            }

        }
        private void pl_content_MouseClick(object sender, MouseEventArgs e)
        {
            int cat_num = e.X / m_category_width;

            if (cat_num < m_categoryVisibleList.Count)
            {
                int nt = (int)(((double)e.Y / (double)pl_content.Size.Height) * (double)60 * (double)24);
                int canInsert = m_categoryList[m_categoryVisibleList[cat_num]].canAddTimeFrame(nt);
                if (canInsert == -1)
                {
                    //add
                    AddFrame frameDlg = new AddFrame();
                    frameDlg.setStartTime(nt);
                    if (frameDlg.ShowDialog() == DialogResult.OK)
                    {
                        int sst = frameDlg.sTime();
                        int eet = frameDlg.eTime();
                        if (m_categoryList[m_categoryVisibleList[cat_num]].canSaveTimeFrame(sst, eet))
                        {
                            DateTime st = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, sst / 60, sst % 60, 0);
                            DateTime et = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, eet / 60, eet % 60, 0);
                            TimeFrame ftemp = new TimeFrame(st, et, frameDlg.info());
                            m_categoryList[m_categoryVisibleList[cat_num]].addTimeFrame(ftemp);
                            pl_content.Invalidate();
                        }
                        else
                        {
                            MessageBox.Show("Time OverLapping!!!");
                        }

                    }
                    saveInfo();
                   
                }
                else if(canInsert == -2)//not
                {
                  //  MessageBox.Show("No Issue!!!");

                }
                else//detail
                {
                    
                    AddFrame frameDlg = new AddFrame();
                    TimeFrame tf = m_categoryList[m_categoryVisibleList[cat_num]].timeFrame()[canInsert];
                    frameDlg.setFrame(tf.startByMin(), tf.endByMin(), tf.info(), this, m_categoryVisibleList[cat_num], canInsert);
                    if (frameDlg.ShowDialog() == DialogResult.OK)
                    {
                        int sst = frameDlg.sTime();
                        int eet = frameDlg.eTime();
                        if (m_categoryList[m_categoryVisibleList[cat_num]].canSaveTimeFrame(sst, eet, canInsert))
                        {
                            DateTime st = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, sst / 60, sst % 60, 0);
                            DateTime et = new DateTime(m_nowDate.Year, m_nowDate.Month, m_nowDate.Day, eet / 60, eet % 60, 0);
                            TimeFrame ftemp = new TimeFrame(st, et, frameDlg.info());
                            m_categoryList[m_categoryVisibleList[cat_num]].updateTimeFrame(ftemp, canInsert);
                            pl_content.Invalidate();
                        }
                        else
                        {
                            MessageBox.Show("Time OverLapping!!!");
                        }

                    }
                    saveInfo();
                    /*
                    string s = m_categoryList[cat_num].timeFrame()[canInsert].startTime().ToString();
                    s += "-";
                    s += m_categoryList[cat_num].timeFrame()[canInsert].endTime().ToString();
                    s += "\n";
                    s += m_categoryList[cat_num].timeFrame()[canInsert].info();
                    MessageBox.Show(s);
                    */
                }

            }
        }
        public void removeTimeFrame(int cn, int tn)
        {
            m_categoryList[cn].deleteTimeFrame(tn);
            pl_content.Invalidate();

        }
        private bool CanEnable(int id)
        {
            int cSt = m_categoryList[id].stimeByMin();
            int cEt = m_categoryList[id].etimeByMin();
          // if((cSt))
            if ((Math.Max(cEt, m_trangE) - Math.Min(cSt, m_trangS)) < (cEt - cSt + m_trangE - m_trangS))
            {
                return true;
            }
            return false;
        }
        private void pl_content_Paint(object sender, PaintEventArgs e)
        {
            
            Color color = Color.FromArgb(230, 236, 246);
            SolidBrush shBrush = new SolidBrush(color);
            e.Graphics.FillRectangle(shBrush, new Rectangle(new Point(0, 0),
                   new Size(pl_content.Size.Width, pl_content.Size.Height * m_trangS / 60 / 24)));
            e.Graphics.DrawRectangle(new Pen(Brushes.DeepSkyBlue), new Rectangle(new Point(0, 0),
                   new Size(pl_content.Size.Width, pl_content.Size.Height * m_trangS / 60 / 24)));
            e.Graphics.FillRectangle(shBrush, new Rectangle(new Point(0, pl_content.Size.Height * m_trangE / 24 / 60),
                  new Size(pl_content.Size.Width, pl_content.Size.Height - pl_content.Size.Height * m_trangE / 24 / 60)));
            e.Graphics.DrawRectangle(new Pen(Brushes.DeepSkyBlue),new Rectangle(new Point(0, pl_content.Size.Height * m_trangE / 24 / 60),
                  new Size(pl_content.Size.Width, pl_content.Size.Height - pl_content.Size.Height * m_trangE / 24 / 60)));
             
          //  double startTIndx = (((double)m_trangS) / 60 / 48);
            for (int i = 0; i < (12/* - startTIndx*/) * (120 / m_timeP); i++)
            {
                if ((i % (120 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(m_outline)), new Point(0, i * m_timeframe_height), new Point(pl_content.Size.Width, i * m_timeframe_height));
                }
                else if ((i % (60 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(m_outline)), new Point(0, i * m_timeframe_height), new Point(pl_content.Size.Width, i * m_timeframe_height));
                }
                else if ((i % (30 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(220, 226, 236))), new Point(0, i * m_timeframe_height), new Point(pl_content.Size.Width, i * m_timeframe_height));
                }
                else if ((i % (15 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(220, 226, 236))), new Point(0, i * m_timeframe_height), new Point(pl_content.Size.Width, i * m_timeframe_height));
                }
                //e.Graphics.DrawLine(new Pen(Brushes.DeepSkyBlue), new Point(0, i * (15 / m_timeP) * m_timeframe_height), new Point(pl_content.Size.Width, i * (15 / m_timeP) * m_timeframe_height));
            }
            
            SolidBrush shadowBrush = new SolidBrush(m_categoryBoxColor);
            double contentHeight = (double)pl_content.Size.Height;
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            for (int i = 0; i < m_categoryVisibleList.Count; i++)
            {
             
                e.Graphics.DrawLine(new Pen(new SolidBrush(m_outline)), new Point(i * m_category_width, 0), new Point(i * m_category_width, pl_content.Size.Height));

                double sscale = (double)m_categoryList[m_categoryVisibleList[i]].stimeByMin() / 60 / 24;
                double escale = (double)m_categoryList[m_categoryVisibleList[i]].etimeByMin() / 60 / 24;


                e.Graphics.FillRectangle(shadowBrush, new Rectangle(new Point(i * m_category_width + 4, (int)(sscale * contentHeight)),
                    new Size(m_category_width - 8, (int)((escale - sscale) * contentHeight))));
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(m_categoryBoxOutline)), new Rectangle(new Point(i * m_category_width + 4, (int)(sscale * contentHeight)),
                  new Size(m_category_width - 8, (int)((escale - sscale) * contentHeight))));
                if (m_categoryList[m_categoryVisibleList[i]].timeFrame().Count != 0)
                {
                  //  double fWidth = m_category_width / m_categoryList[i].timeFrame().Count;
                    for (int j = 0; j < m_categoryList[m_categoryVisibleList[i]].timeFrame().Count; j++)
                    {
                        double ssscale = (double)m_categoryList[m_categoryVisibleList[i]].timeFrame()[j].startByMin() / 60 / 24;
                        double eescale = (double)m_categoryList[m_categoryVisibleList[i]].timeFrame()[j].endByMin() / 60 / 24;


                        e.Graphics.FillRectangle(new SolidBrush(m_timeframeBoxColor), new Rectangle(new Point(i * m_category_width + 10, (int)(ssscale * contentHeight)),
                            new Size(m_category_width - 20, (int)((eescale - ssscale) * contentHeight))));
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(m_timeframeOutline)), new Rectangle(new Point(i * m_category_width + 10, (int)(ssscale * contentHeight)),
                          new Size(m_category_width - 20, (int)((eescale - ssscale) * contentHeight))));
                        e.Graphics.DrawString(m_categoryList[m_categoryVisibleList[i]].timeFrame()[j].info(), new Font("Arial", 12), new SolidBrush(m_timeFontColor), new Rectangle(new Point(i * m_category_width + 10, (int)(ssscale * contentHeight)),
                          new Size(m_category_width - 20, (int)((eescale - ssscale) * contentHeight))),drawFormat);
                    }
                }
            }
            //
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(m_outline)), new Rectangle(new Point(-1, -1),
                 pl_content.Size));
        }

  
        private void pl_main_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                pl_category.Left = pl_content.Left;
            }
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                //if(pl_main.AutoScrollPosition.Y)
                pl_timecontent.Top = pl_content.Top;
            }
        }

        private void pl_timecontent_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 12 * (120 / m_timeP); i++)
            {
                if ((i % (120 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(169, 176, 184))), new Point(0, i * m_timeframe_height), new Point(pl_timecontent.Size.Width, i * m_timeframe_height));
                    int t = ((int)(((double)i / (60 / (double)m_timeP))));
                    if (t == 6)
                    {
                        e.Graphics.DrawString(t.ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":am", new Font("Arial", 8), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));
                    }
                    else if (t == 12)
                    {
                        e.Graphics.DrawString(t.ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":pm", new Font("Arial", 8), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));
                    }
                    else if (t > 12)
                    {
                        e.Graphics.DrawString((t - 12).ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":00", new Font("Arial", 10), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));

                    }
                    else
                    {
                        e.Graphics.DrawString(t.ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":00", new Font("Arial", 10), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));

                    }
                  
                }
                else if ((i % (60 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(169, 176, 184))), new Point(0, i * m_timeframe_height), new Point(pl_timecontent.Size.Width, i * m_timeframe_height));
                    int t = (i / (60 / m_timeP));
                    if (t > 12)
                    {
                        e.Graphics.DrawString((t - 12).ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":00", new Font("Arial", 10), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));

                    }
                    else
                    {
                        e.Graphics.DrawString(t.ToString(), new Font("Arial", 13), Brushes.DeepSkyBlue, new Point(0, i * m_timeframe_height));
                        e.Graphics.DrawString(":00", new Font("Arial", 10), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));

                    }

                }
                else if ((i % (30 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(Brushes.DeepSkyBlue), new Point(pl_timecontent.Size.Width / 2, i * m_timeframe_height), new Point(pl_timecontent.Size.Width, i * m_timeframe_height));
                    e.Graphics.DrawString(":30", new Font("Arial", 10), Brushes.DeepSkyBlue, new Point(15, i * m_timeframe_height));

                }
                else if ((i % (15 / m_timeP)) == 0)
                {
                    e.Graphics.DrawLine(new Pen(Brushes.DeepSkyBlue), new Point(pl_timecontent.Size.Width / 4, i * m_timeframe_height), new Point(pl_timecontent.Size.Width, i * m_timeframe_height));

                }

            }
           
        }

        private void cb_timeframe_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_timeP = 15 * (int)Math.Pow((double)2,(double)((cb_timeframe.SelectedIndex)));
            initTimeHeight();
            pl_timecontent.Invalidate();
            pl_content.Invalidate();
        }

        private void pl_timecontent_Click(object sender, EventArgs e)
        {
            
        }

        private void pl_timecontent_MouseClick(object sender, MouseEventArgs e)
        {
            int pressMin = (int)((double)e.Y / (double)pl_timecontent.Size.Height * (double)60 * (double)24);
            for (int i = 0; i < m_categoryList.Count; i++)
            {
                if (pressMin >= m_categoryList[i].stimeByMin() && pressMin <= m_categoryList[i].etimeByMin())
                {
               //     MessageBox.Show(m_categoryList[i].categoryInfo(),m_categoryList[i].categoryTitle(),MessageBoxButtons.OK);
                }
            }
        }
        //Date
        private void bt_prvDay_Click(object sender, EventArgs e)
        {
            saveInfo();
            m_nowDate = m_nowDate.AddDays(-1);
            invalidateDateLbl();
            loadInfo();
        }

        private void bt_nxtDay_Click(object sender, EventArgs e)
        {
            saveInfo();
            m_nowDate = m_nowDate.AddDays(1);
            invalidateDateLbl();
            loadInfo();
        }
        public void saveInfo()
        {
            StreamWriter sw = File.AppendText("info/" + m_nowDate.ToString("MMMdyyyy") + "_");
            //StreamWriter sw = new StreamWriter(m_nowDate.ToString("MMMdyyyy"));
            sw.WriteLine(m_categoryList.Count);

            for (int i = 0; i < m_categoryList.Count; i++)
            {
                String info = "";
                info += m_categoryList[i].stimeByMin();
                info += "*()*";
                info += m_categoryList[i].etimeByMin();
                info += "*()*";
                info += m_categoryList[i].categoryTitle().Replace("\n","*BLACKSPACE*");
                info += "*()*";
                info += m_categoryList[i].categoryInfo().Replace("\n", "*BLACKSPACE*");
                info += "*()*";
                info += m_categoryList[i].timeFrame().Count;
                info += "*()*";
                for (int j = 0; j < m_categoryList[i].timeFrame().Count; j++)
                {
                    
                    info += m_categoryList[i].timeFrame()[j].startByMin();
                    info += "+()+";
                    info += m_categoryList[i].timeFrame()[j].endByMin();
                    info += "+()+";
                    info += m_categoryList[i].timeFrame()[j].info().Replace("\n","*BLACKSPACE*");
                //    info += "P()P";
                    info += "APOLOMP";
                }
           //     info += "*()*";
                sw.WriteLine(info);
            }
            sw.Close();
            File.Copy("info/" + m_nowDate.ToString("MMMdyyyy") + "_", "info/" + m_nowDate.ToString("MMMdyyyy"), true);
            File.Delete("info/" + m_nowDate.ToString("MMMdyyyy") + "_");
        }
        public void loadInfo()
        {
            m_categoryList.Clear();
            if (File.Exists(@"info/" + m_nowDate.ToString("MMMdyyyy")))
            {
                StreamReader sr = new StreamReader("info/" + m_nowDate.ToString("MMMdyyyy"));
                string counts = sr.ReadLine();
                int cnt = Int32.Parse(counts);

                string[] stringSeparators = new string[] { "*()*" };
                string[] tinfoSep = new string[]{ "APOLOMP" };
                string[] tinfoSepd = new string[]{ "+()+" };

                TimeFrame ttemp = null;
                for (int i = 0; i < cnt; i++)
                {
                    String info = sr.ReadLine();
                    String[] infoSplit = info.Split(stringSeparators, 6, StringSplitOptions.RemoveEmptyEntries);
                    int st = Int32.Parse(infoSplit[0]);
                    int et = Int32.Parse(infoSplit[1]);
                    m_categoryList.Add(new Category(m_nowDate.AddMinutes(st), m_nowDate.AddMinutes(et), infoSplit[2].Replace("*BLACKSPACE*", "\n"), infoSplit[3].Replace("*BLACKSPACE*", "\n")));
                    int tcnt = Int32.Parse(infoSplit[4]);
                    if (tcnt != 0)
                    {
                        String tframe = infoSplit[5];
                        //String s = "+(tf)+";
                        String[] tinfoSplit = tframe.Split(tinfoSep, tcnt, StringSplitOptions.RemoveEmptyEntries);
                        Category ct = m_categoryList[m_categoryList.Count - 1];
                        for (int j = 0; j < tinfoSplit.Length; j++)
                        {
                            string[] tinfoSplitd = tinfoSplit[j].Split(tinfoSepd, 3, StringSplitOptions.RemoveEmptyEntries);
                            int stf = Int32.Parse(tinfoSplitd[0]);
                            int eft = Int32.Parse(tinfoSplitd[1]);

                            ttemp = new TimeFrame(m_nowDate.AddMinutes(stf), m_nowDate.AddMinutes(eft), tinfoSplitd[2].Replace("*BLACKSPACE*", "\n"));
                            ct.addTimeFrame(ttemp);
                        }
                    }
                }
               
                sr.Close();
            }
            else
            {

            }
            //
            invalidateRelateWithCategory();

            initTimeHeight();
            updateVertical();
            resetVisibleCategory();
            //pl_main.AutoScrollPosition = new Point(0, pl_main.VerticalScroll.Maximum * m_trangS / 60 / 24);
            //pl_timecontent.Top = pl_content.Top;
        }
        public void updateVertical()
        {
            pl_main.AutoScrollPosition = new Point(0, pl_main.VerticalScroll.Maximum * m_trangS / 60 / 24);
            pl_timecontent.Top = pl_content.Top;
        }
        private void pl_main_LocationChanged(object sender, EventArgs e)
        {
            ;
            int a = 1;
        }
        private void invalidateRelateWithCategory()
        {

            int cate_wi = (m_categoryVisibleList.Count + 1) * m_category_width;
            int panel_wi = pl_categoryPanel.Size.Width;
            pl_content.Size = new Size(cate_wi > panel_wi ? cate_wi : panel_wi, pl_content.Size.Height);
            pl_category.Size = new Size(cate_wi > panel_wi ? cate_wi : panel_wi, pl_category.Size.Height);
            pl_content.Invalidate();
            pl_category.Invalidate();
        }
        private void bt_in_Click(object sender, EventArgs e)
        {
         //   ColorDialog dlg = new ColorDialog();
         //   dlg.ShowDialog();
            m_category_width += 30;
            invalidateRelateWithCategory();

        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            m_category_width -= 30;
            invalidateRelateWithCategory();
        }

        private void bt_setting_Click(object sender, EventArgs e)
        {
            if (m_settingform.ShowDialog() == DialogResult.OK)
            {

            }
        }
        public void setOutlineColor(Color clr,int al = -1)
        {
            if (al == -1)
                m_outline = clr;
            else
                m_outline = Color.FromArgb(al, m_outline.R, m_outline.G, m_outline.B);
            invalidateRelateWithCategory();
        }
        public void setCategoryColor(Color clr, int al = -1)
        {
            if (al == -1)
                pl_category.BackColor = clr;
            else
                pl_category.BackColor = Color.FromArgb(al, pl_category.BackColor.R, pl_category.BackColor.G, pl_category.BackColor.B);
            
        }
        public void setCategoryBoxColor(Color clr, int al = -1)
        {
            if (al == -1)
                m_categoryBoxColor = clr;
            else
                m_categoryBoxColor = Color.FromArgb(al, m_categoryBoxColor.R, m_categoryBoxColor.G, m_categoryBoxColor.B);
            
            pl_content.Invalidate();
        }
        public void setCategoryBoxOutlineColor(Color clr, int al = -1)
        {
            if (al == -1)
                m_categoryBoxOutline = clr;
            else
                m_categoryBoxOutline = Color.FromArgb(al, m_categoryBoxOutline.R, m_categoryBoxOutline.G, m_categoryBoxOutline.B);
            
            pl_content.Invalidate();
        }
        public void setTimeframeBoxColor(Color clr, int al = -1)
        {
            if (al == -1)
                m_timeframeBoxColor = clr;
            else
                m_timeframeBoxColor = Color.FromArgb(al, m_timeframeBoxColor.R, m_timeframeBoxColor.G, m_timeframeBoxColor.B);
            
            pl_content.Invalidate();
        }
        public void setTimeframeOutline(Color clr, int al = -1)
        {
            if (al == -1)
                m_timeframeOutline = clr;
            else
                m_timeframeOutline = Color.FromArgb(al, m_timeframeOutline.R, m_timeframeOutline.G, m_timeframeOutline.B);
            
            pl_content.Invalidate();
        }
        public void setTimeBoxColor(Color clr, int al = -1)
        {
            if (al == -1)
                m_timeBarColor = clr;
            else
                m_timeBarColor = Color.FromArgb(al, m_timeBarColor.R, m_timeBarColor.G, m_timeBarColor.B);
            
            pl_timecontent.Invalidate();
        }
        public void setCateFontColor(Color clr)
        {
            m_cateFontColor = clr;
            pl_category.Invalidate();
        }
        public void setTimeFontColor(Color clr)
        {
            m_timeFontColor = clr;
            pl_content.Invalidate();
        }
        public void setTimeRange(DateTime s, DateTime e)
        {
            m_trangS = s.Hour * 60 + s.Minute;
            m_trangE = e.Hour * 60 + e.Minute;
            pl_content.Invalidate();
            pl_main.AutoScrollPosition = new Point(0, pl_main.VerticalScroll.Maximum * m_trangS / 60 / 24);
            pl_timecontent.Top = pl_content.Top;
            resetVisibleCategory();
            pl_content.Invalidate();
            pl_category.Invalidate();
        }
        public void Myoutlook_FormClosing()//YOU MUST CALL THIS FUNCTION BEFORE CLOSING OUTSIDE
        {
            Registry.SetValue(keyName, outkey, new Byte[]{m_outline.A, m_outline.R, m_outline.G, m_outline.B});
            Registry.SetValue(keyName, catekey, new Byte[] { m_cateColor.A, m_cateColor.R, m_cateColor.G, m_cateColor.B });
            Registry.SetValue(keyName, cateBoxkey, new Byte[] { m_categoryBoxColor.A, m_categoryBoxColor.R, m_categoryBoxColor.G, m_categoryBoxColor.B });
            Registry.SetValue(keyName, cateOutkey, new Byte[] { m_categoryBoxOutline.A, m_categoryBoxOutline.R, m_categoryBoxOutline.G, m_categoryBoxOutline.B });
            Registry.SetValue(keyName, tBoxkey, new Byte[] { m_timeframeBoxColor.A, m_timeframeBoxColor.R, m_timeframeBoxColor.G, m_timeframeBoxColor.B });
            Registry.SetValue(keyName, tOutkey, new Byte[] { m_timeframeOutline.A, m_timeframeOutline.R, m_timeframeOutline.G, m_timeframeOutline.B });
            Registry.SetValue(keyName, cateFontkey, new Byte[] { m_cateFontColor.A, m_cateFontColor.R, m_cateFontColor.G, m_cateFontColor.B });
            Registry.SetValue(keyName, timeFontkey, new Byte[] { m_timeFontColor.A, m_timeFontColor.R, m_timeFontColor.G, m_timeFontColor.B });
            Registry.SetValue(keyName, timeRangeSkey, m_trangS);
            Registry.SetValue(keyName, timeRangeEkey, m_trangE);

        }

      

        private void Myoutlook_Resize(object sender, EventArgs e)
        {
            invalidateRelateWithCategory();
        }
    }
}
