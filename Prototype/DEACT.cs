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
            location = new Point(this.Width / 2 - 40, this.Height / 2 + 240);
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
        private System.Drawing.Point location;
        #endregion

        private void DEACT_Load(object sender, EventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.count;
            this.lbl_Main_CurrentPageDisplay.Text = pageNames.PageNameCallback(m_nCurrentPage);
            this.lbl_Main_CurrentPageDisplay.Location = location;
        }

        private void pnl_Electricity_Paint(object sender, PaintEventArgs e)
        {
            m_nCurrentPage = (int)EPageNumbers.Electricity;
            this.lbl_Electricity_currentPageDispaly.Text = pageNames.PageNameCallback(m_nCurrentPage);
            lbl_Electricity_currentPageDispaly.Location = location;
            lbl_Electricity_CurrentUsage_value.Text = "£110.83";
            lbl_Electricity_ON_value.Text = "08:00 AM";
            lbl_Electricity_OFF_value.Text = "11:30 PM";
            this.prgBar_CurrentUsage.Value = 80;
        }

        private void btn_Electricity_Click(object sender, EventArgs e)
        {
            this.pnl_Electricity.Show();
            this.pnl_Electricity.Visible = true;
            this.btn_Electricity_back.Text = "Back";
            this.lbl_CurrentUsage.Text = "Current Usage: ";
            lbl_CurrentBill.Text = "Current Bill: ";
            lbl_SwitchOnTime.Text = "Switch ON: ";
            lbl_SwitchOffTime.Text = "Switch OFF: ";
        }

        private void btn_Electricity_back_Click(object sender, EventArgs e)
        {
            this.pnl_Electricity.Visible = false;
            this.prgBar_CurrentUsage.Value = 0;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.prgBar_CurrentUsage.Value = e.ProgressPercentage;
            this.Text = e.ProgressPercentage.ToString();
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            prgBar_CurrentUsage.Value = 67;
        }
    }
}
