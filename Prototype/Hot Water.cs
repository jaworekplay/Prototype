using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Hot_Water : Form
    {
        private DEACT m_MainWnd;
        public Hot_Water()
        {
            InitializeComponent();
            m_MainWnd = new DEACT();
        }

        private void Hot_Water_Load(object sender, EventArgs e)
        {

        }

        private void Hot_Water_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_MainWnd.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rdbtn_ON.Checked)
                mainCnt.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            else
                mainCnt.Panel1.BackColor = System.Drawing.Color.IndianRed;
        }

        private void trckbr_Scroll(object sender, EventArgs e)
        {
            lbl_tempIndicator.Text = (trckbr.Value + 40).ToString();
        }
    }
}
