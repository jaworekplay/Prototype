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
    public partial class Electricity : Form
    {
        public Electricity()
        {
            InitializeComponent();
            pageNames = new Pages();
            bill = new Bill();
            MainWindow = new DEACT();
        }

        //these are main window controls
        private DEACT MainWindow;
        private Pages pageNames;
        private Bill bill;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!rdbtn_StatusON.Checked)
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.IndianRed;
                prgbr.Value = 0;
            }
            else
            {
                splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
                prgbr.Value = 80;
            }
        }

        private void Electricity_MouseClick(object sender, MouseEventArgs e)
        {
            splCtn.Refresh();
        }

        private void Electricity_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Electricity_Load(object sender, EventArgs e)
        {
            lbl_PageName.Text = pageNames.PageNameCallback(0);

        }

        private void Electricity_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainWindow.Show();
        }

        private void splCtn_Panel2_Paint(object sender, PaintEventArgs e)
        {
            lbl_Bill.Text = bill.DisplayBill(false);
        }

        private void splCtn_Click(object sender, EventArgs e)
        {
            if (rdbtn_kWh.Checked)
                lbl_Bill.Text = bill.DisplayBill(false);
            else
                lbl_Bill.Text = bill.DisplayBill(true);
            splCtn.Panel2.Refresh();
        }
    }
}
