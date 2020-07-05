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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myoutlook1_Load(object sender, EventArgs e)
        {
            myoutlook1.updateVertical();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myoutlook1.Myoutlook_FormClosing();
        }
    }
}
