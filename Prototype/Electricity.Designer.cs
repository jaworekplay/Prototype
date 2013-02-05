namespace Prototype
{
    partial class Electricity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splCtn = new System.Windows.Forms.SplitContainer();
            this.rdbtn_StatusOFF = new System.Windows.Forms.RadioButton();
            this.rdbtn_StatusON = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.rdbtn_currency = new System.Windows.Forms.RadioButton();
            this.rdbtn_kWh = new System.Windows.Forms.RadioButton();
            this.lbl_PageName = new System.Windows.Forms.Label();
            this.prgbr = new System.Windows.Forms.ProgressBar();
            this.lbl_SwitchOFF = new System.Windows.Forms.Label();
            this.lbl_SwitchON = new System.Windows.Forms.Label();
            this.lbl_CurrentBill = new System.Windows.Forms.Label();
            this.lbl_CurrentUsage = new System.Windows.Forms.Label();
            this.btn_backToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).BeginInit();
            this.splCtn.Panel1.SuspendLayout();
            this.splCtn.Panel2.SuspendLayout();
            this.splCtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // splCtn
            // 
            this.splCtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCtn.Location = new System.Drawing.Point(0, 0);
            this.splCtn.Name = "splCtn";
            this.splCtn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splCtn.Panel1
            // 
            this.splCtn.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.splCtn.Panel1.Controls.Add(this.rdbtn_StatusOFF);
            this.splCtn.Panel1.Controls.Add(this.rdbtn_StatusON);
            this.splCtn.Panel1.Controls.Add(this.lbl_Status);
            this.splCtn.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splCtn.Panel2
            // 
            this.splCtn.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splCtn.Panel2.Controls.Add(this.lbl_Bill);
            this.splCtn.Panel2.Controls.Add(this.rdbtn_currency);
            this.splCtn.Panel2.Controls.Add(this.rdbtn_kWh);
            this.splCtn.Panel2.Controls.Add(this.lbl_PageName);
            this.splCtn.Panel2.Controls.Add(this.prgbr);
            this.splCtn.Panel2.Controls.Add(this.lbl_SwitchOFF);
            this.splCtn.Panel2.Controls.Add(this.lbl_SwitchON);
            this.splCtn.Panel2.Controls.Add(this.lbl_CurrentBill);
            this.splCtn.Panel2.Controls.Add(this.lbl_CurrentUsage);
            this.splCtn.Panel2.Controls.Add(this.btn_backToMain);
            this.splCtn.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splCtn.Size = new System.Drawing.Size(746, 583);
            this.splCtn.SplitterDistance = 81;
            this.splCtn.TabIndex = 0;
            // 
            // rdbtn_StatusOFF
            // 
            this.rdbtn_StatusOFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_StatusOFF.AutoSize = true;
            this.rdbtn_StatusOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_StatusOFF.Location = new System.Drawing.Point(642, 25);
            this.rdbtn_StatusOFF.Name = "rdbtn_StatusOFF";
            this.rdbtn_StatusOFF.Size = new System.Drawing.Size(92, 47);
            this.rdbtn_StatusOFF.TabIndex = 2;
            this.rdbtn_StatusOFF.Text = "OFF";
            this.rdbtn_StatusOFF.UseVisualStyleBackColor = true;
            // 
            // rdbtn_StatusON
            // 
            this.rdbtn_StatusON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_StatusON.AutoSize = true;
            this.rdbtn_StatusON.Checked = true;
            this.rdbtn_StatusON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_StatusON.Location = new System.Drawing.Point(412, 25);
            this.rdbtn_StatusON.Name = "rdbtn_StatusON";
            this.rdbtn_StatusON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_StatusON.TabIndex = 1;
            this.rdbtn_StatusON.TabStop = true;
            this.rdbtn_StatusON.Text = "ON";
            this.rdbtn_StatusON.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 25);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(108, 37);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.Location = new System.Drawing.Point(643, 92);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(100, 37);
            this.lbl_Bill.TabIndex = 9;
            this.lbl_Bill.Text = "label1";
            // 
            // rdbtn_currency
            // 
            this.rdbtn_currency.AutoSize = true;
            this.rdbtn_currency.Checked = true;
            this.rdbtn_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_currency.Location = new System.Drawing.Point(546, 90);
            this.rdbtn_currency.Name = "rdbtn_currency";
            this.rdbtn_currency.Size = new System.Drawing.Size(53, 41);
            this.rdbtn_currency.TabIndex = 8;
            this.rdbtn_currency.TabStop = true;
            this.rdbtn_currency.Text = "£";
            this.rdbtn_currency.UseVisualStyleBackColor = true;
            // 
            // rdbtn_kWh
            // 
            this.rdbtn_kWh.AutoSize = true;
            this.rdbtn_kWh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_kWh.Location = new System.Drawing.Point(412, 90);
            this.rdbtn_kWh.Name = "rdbtn_kWh";
            this.rdbtn_kWh.Size = new System.Drawing.Size(100, 41);
            this.rdbtn_kWh.TabIndex = 7;
            this.rdbtn_kWh.Text = "kWh";
            this.rdbtn_kWh.UseVisualStyleBackColor = true;
            // 
            // lbl_PageName
            // 
            this.lbl_PageName.AutoSize = true;
            this.lbl_PageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PageName.Location = new System.Drawing.Point(302, 422);
            this.lbl_PageName.Name = "lbl_PageName";
            this.lbl_PageName.Size = new System.Drawing.Size(100, 37);
            this.lbl_PageName.TabIndex = 6;
            this.lbl_PageName.Text = "label1";
            // 
            // prgbr
            // 
            this.prgbr.Location = new System.Drawing.Point(412, 19);
            this.prgbr.Name = "prgbr";
            this.prgbr.Size = new System.Drawing.Size(322, 37);
            this.prgbr.TabIndex = 5;
            this.prgbr.Value = 80;
            // 
            // lbl_SwitchOFF
            // 
            this.lbl_SwitchOFF.AutoSize = true;
            this.lbl_SwitchOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchOFF.Location = new System.Drawing.Point(12, 238);
            this.lbl_SwitchOFF.Name = "lbl_SwitchOFF";
            this.lbl_SwitchOFF.Size = new System.Drawing.Size(254, 37);
            this.lbl_SwitchOFF.TabIndex = 4;
            this.lbl_SwitchOFF.Text = "Switch OFF time";
            // 
            // lbl_SwitchON
            // 
            this.lbl_SwitchON.AutoSize = true;
            this.lbl_SwitchON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchON.Location = new System.Drawing.Point(12, 165);
            this.lbl_SwitchON.Name = "lbl_SwitchON";
            this.lbl_SwitchON.Size = new System.Drawing.Size(238, 37);
            this.lbl_SwitchON.TabIndex = 3;
            this.lbl_SwitchON.Text = "Switch ON time";
            // 
            // lbl_CurrentBill
            // 
            this.lbl_CurrentBill.AutoSize = true;
            this.lbl_CurrentBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentBill.Location = new System.Drawing.Point(12, 92);
            this.lbl_CurrentBill.Name = "lbl_CurrentBill";
            this.lbl_CurrentBill.Size = new System.Drawing.Size(175, 37);
            this.lbl_CurrentBill.TabIndex = 2;
            this.lbl_CurrentBill.Text = "Current Bill";
            // 
            // lbl_CurrentUsage
            // 
            this.lbl_CurrentUsage.AutoSize = true;
            this.lbl_CurrentUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentUsage.Location = new System.Drawing.Point(12, 19);
            this.lbl_CurrentUsage.Name = "lbl_CurrentUsage";
            this.lbl_CurrentUsage.Size = new System.Drawing.Size(225, 37);
            this.lbl_CurrentUsage.TabIndex = 1;
            this.lbl_CurrentUsage.Text = "Current Usage";
            // 
            // btn_backToMain
            // 
            this.btn_backToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToMain.Location = new System.Drawing.Point(546, 388);
            this.btn_backToMain.Name = "btn_backToMain";
            this.btn_backToMain.Size = new System.Drawing.Size(200, 85);
            this.btn_backToMain.TabIndex = 0;
            this.btn_backToMain.Text = "Back to Main Menu";
            this.btn_backToMain.UseVisualStyleBackColor = true;
            this.btn_backToMain.Click += new System.EventHandler(this.btn_backToMain_Click);
            // 
            // Electricity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(746, 583);
            this.Controls.Add(this.splCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Electricity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electricity";
            this.Load += new System.EventHandler(this.Electricity_Load);
            this.Leave += new System.EventHandler(this.Electricity_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Electricity_MouseClick);
            this.splCtn.Panel1.ResumeLayout(false);
            this.splCtn.Panel1.PerformLayout();
            this.splCtn.Panel2.ResumeLayout(false);
            this.splCtn.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).EndInit();
            this.splCtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splCtn;
        private System.Windows.Forms.RadioButton rdbtn_StatusOFF;
        private System.Windows.Forms.RadioButton rdbtn_StatusON;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ProgressBar prgbr;
        private System.Windows.Forms.Label lbl_SwitchOFF;
        private System.Windows.Forms.Label lbl_SwitchON;
        private System.Windows.Forms.Label lbl_CurrentBill;
        private System.Windows.Forms.Label lbl_CurrentUsage;
        private System.Windows.Forms.Button btn_backToMain;
        private System.Windows.Forms.Label lbl_PageName;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.RadioButton rdbtn_currency;
        private System.Windows.Forms.RadioButton rdbtn_kWh;
    }
}