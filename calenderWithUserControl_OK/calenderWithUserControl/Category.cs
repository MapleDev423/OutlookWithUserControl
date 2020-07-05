using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calenderWithUserControl
{
    class TimeFrame
    {
        private DateTime m_st, m_et;
        private String m_info;
        public TimeFrame()
        {
            m_st = DateTime.Now;
            m_et = DateTime.Now;
            m_info = "";
        }
        public TimeFrame(DateTime s, DateTime e, String inf)
        {
            m_st = s;
            m_et = e;
            m_info = inf;
        }
        public int startByMin()
        {
            return m_st.Hour * 60 + m_st.Minute;
        }
        public int endByMin()
        {
            return m_et.Hour * 60 + m_et.Minute;
        }
        public DateTime startTime()
        {
            return m_st;
        }
        public DateTime endTime()
        {
            return m_et;
        }
        public string info()
        {
            return m_info;
        }
    }
    class Category
    {
        private DateTime m_stime, m_etime;
        private String m_info, m_title;
        private List<TimeFrame> m_frameList;
        public Category()
        {
            m_stime = DateTime.Now;
            m_etime = DateTime.Now;
            m_title = "Title";
            m_info = "";
            m_frameList = new List<TimeFrame>();
        }
        public Category(DateTime s, DateTime e, String title, String info)
        {
            m_stime = s;
            m_etime = e;
            m_title = title;
            m_info = info;
            m_frameList = new List<TimeFrame>();

        }
        public void setStime(DateTime s) { m_stime = s; }
        public void setEtime(DateTime e) { m_etime = e; }
        public void setTitle(String t) { m_title = t; }
        public void setInfo(String info) { m_info = info; }
        public String categoryInfo() { return m_info; }
        public String categoryTitle() { return m_title; }
        public DateTime startTime()
        {
            return m_stime;
        }
        public DateTime endTime()
        {
            return m_etime;
        }
        public int stimeByMin()
        {
            return m_stime.Hour * 60 + m_stime.Minute;
        }
        public int etimeByMin()
        {
            return m_etime.Hour * 60 + m_etime.Minute;
        }

        public int canAddTimeFrame(int t)
        {
            if (!(t > stimeByMin() && t < etimeByMin()))
            {
                return -2;//not
            }
            int s = 0, e = 0;
            for (int i = 0; i < m_frameList.Count; i++)
            {
                s = m_frameList[i].startByMin();
                e = m_frameList[i].endByMin();
                if (t > s && t < e)
                {
                    return i;//detail
                }
            }
            return -1;//insert
        }
        public bool canSaveTimeFrame(int s, int e, int uindex = -100)
        {
            if (!(s > stimeByMin() && e < etimeByMin()))
                return false;
            for (int i = 0; i < m_frameList.Count; i++)
            {
                if (!((s >= m_frameList[i].endByMin() && e >= m_frameList[i].endByMin()) || (s <= m_frameList[i].startByMin() && e <= m_frameList[i].startByMin())))
                {
                    if (i != uindex)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        public void updateTimeFrame(TimeFrame t, int ind)
        {
            m_frameList[ind] = t;
        }
        public void addTimeFrame(TimeFrame t)
        {
            m_frameList.Add(t);
        }
        public void deleteTimeFrame(int tn)
        {
            m_frameList.RemoveAt(tn);
        }
        public List<TimeFrame> timeFrame()
        {
            return m_frameList;
        }

    }
}
