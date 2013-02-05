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

        private void btn_backToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //lbl_PageName.Location = new Point(this.Width / 2 - 40, this.Height / 2 + 240);
            if (rdbtn_currency.Checked)
                lbl_Bill.Text = bill.DisplayBill();
            else
                lbl_Bill.Text = bill.DisplayBill(true);
            lbl_PageName.Text = pageNames.PageNameCallback(0);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (!rdbtn_StatusON.Checked)
                splCtn.Panel1.BackColor = System.Drawing.Color.IndianRed;
            else
                splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
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
    }
}
