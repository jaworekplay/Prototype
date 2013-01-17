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
    public partial class DEACT : Form
    {
        public DEACT()
        {
            InitializeComponent();
        }
        #region myStuff
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
        #endregion

        private void DEACT_Load(object sender, EventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.count;

            this.lbl_Main_CurrentPageDisplay.Text = pageNames.PageNameCallback(m_nCurrentPage);
        }

        private void pnl_Electricity_Paint(object sender, PaintEventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.Electricity;
            this.lbl_Electricity_currentPageDispaly.Text = pageNames.PageNameCallback(m_nCurrentPage);
        }

        private void btn_Electricity_Click(object sender, EventArgs e)
        {
            this.pnl_Main.Visible = false;
            this.pnl_Electricity.Show();
            this.pnl_Electricity.Visible = true;
        }
    }
}
