using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Prototype
{
    public partial class DEACT : Form
    {
        public DEACT()
        {
            InitializeComponent();
            billValue = new Bill();
            location = new Point(this.Width / 2 - 40, this.Height / 2 + 240);
            g_Location = location;
            g_nHeight = this.Height;
            g_Width = this.Width;
            
        }
        public int g_nHeight;
        public int g_Width;
        public Point g_Location;
        #region myStuff
        private Bill billValue;
        private enum EPageNumbers
        {
            Electricity = 0,
            HotWater,
            Heating,
            CurrentUsage,
            BillStatus,
            Monitor,
            Weather,
            Security,
            Settings,
            count
        };
        private int m_nCurrentPage;
        private Pages pageNames = new Pages();
        private System.Drawing.Point location;
        #endregion
        #region Electricity,HotWater,Heating

            private Hot_Water htWtr;
            private Heating htng;
            private Electricity elc;

        #endregion
        private void DEACT_Load(object sender, EventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.count;
            this.lbl_Main_CurrentPageDisplay.Text = pageNames.PageNameCallback(m_nCurrentPage);
            this.lbl_Main_CurrentPageDisplay.Location = location;
        }

        private void btn_Electricity_Click(object sender, EventArgs e)
        {
            this.Hide();
            elc = new Electricity();
            elc.Height = g_nHeight;
            elc.Width = g_Width;
            elc.Show();
        }

        private void CleanUP(object sender, EventArgs e)
        {
            elc.Close();
            this.Close();
            Application.Exit();
        }

        private void DEACT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HotWater_Click(object sender, EventArgs e)
        {
            htWtr = new Hot_Water();
            this.Hide();
            htWtr.Show();
        }

        private void btn_Heating_Click(object sender, EventArgs e)
        {
            htng = new Heating();
            this.Hide();
            htng.Show();
        }
    }
}
