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
    public partial class Heating : Form
    {
        private DEACT m_mainWnd;
        public Heating()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rdbtn_ON.Checked)
                splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            else
                splCtn.Panel1.BackColor = System.Drawing.Color.IndianRed;
        }

        private void Heating_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_mainWnd = new DEACT();
            m_mainWnd.Show();
        }
    }
}
