namespace Prototype
{
    partial class DEACT
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
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Main_CurrentPageDisplay = new System.Windows.Forms.Label();
            this.btn_CurrenUsage = new System.Windows.Forms.Button();
            this.btn_Heating = new System.Windows.Forms.Button();
            this.btn_HotWater = new System.Windows.Forms.Button();
            this.btn_Electricity = new System.Windows.Forms.Button();
            this.pnl_Electricity = new System.Windows.Forms.Panel();
            this.prgBar_ = new System.Windows.Forms.ProgressBar();
            this.lbl_CurrentUsage = new System.Windows.Forms.Label();
            this.lbl_CurrentBill = new System.Windows.Forms.Label();
            this.lbl_SwitchOnTime = new System.Windows.Forms.Label();
            this.lbl_SwitchOffTime = new System.Windows.Forms.Label();
            this.lbl_Electricity_currentPageDispaly = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.pnl_Electricity.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl_Main.Controls.Add(this.pnl_Electricity);
            this.pnl_Main.Controls.Add(this.lbl_Main_CurrentPageDisplay);
            this.pnl_Main.Controls.Add(this.btn_CurrenUsage);
            this.pnl_Main.Controls.Add(this.btn_Heating);
            this.pnl_Main.Controls.Add(this.btn_HotWater);
            this.pnl_Main.Controls.Add(this.btn_Electricity);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(756, 593);
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_Main_CurrentPageDisplay
            // 
            this.lbl_Main_CurrentPageDisplay.AutoSize = true;
            this.lbl_Main_CurrentPageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Main_CurrentPageDisplay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Main_CurrentPageDisplay.Location = new System.Drawing.Point(337, 516);
            this.lbl_Main_CurrentPageDisplay.Name = "lbl_Main_CurrentPageDisplay";
            this.lbl_Main_CurrentPageDisplay.Size = new System.Drawing.Size(100, 37);
            this.lbl_Main_CurrentPageDisplay.TabIndex = 4;
            this.lbl_Main_CurrentPageDisplay.Text = "label1";
            // 
            // btn_CurrenUsage
            // 
            this.btn_CurrenUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CurrenUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CurrenUsage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CurrenUsage.Location = new System.Drawing.Point(381, 232);
            this.btn_CurrenUsage.Name = "btn_CurrenUsage";
            this.btn_CurrenUsage.Size = new System.Drawing.Size(372, 223);
            this.btn_CurrenUsage.TabIndex = 3;
            this.btn_CurrenUsage.Text = "Current Usage";
            this.btn_CurrenUsage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CurrenUsage.UseVisualStyleBackColor = false;
            // 
            // btn_Heating
            // 
            this.btn_Heating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Heating.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Heating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Heating.Location = new System.Drawing.Point(3, 232);
            this.btn_Heating.Name = "btn_Heating";
            this.btn_Heating.Size = new System.Drawing.Size(372, 223);
            this.btn_Heating.TabIndex = 2;
            this.btn_Heating.Text = "Heating";
            this.btn_Heating.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Heating.UseVisualStyleBackColor = false;
            // 
            // btn_HotWater
            // 
            this.btn_HotWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_HotWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HotWater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HotWater.Location = new System.Drawing.Point(381, 3);
            this.btn_HotWater.Name = "btn_HotWater";
            this.btn_HotWater.Size = new System.Drawing.Size(372, 223);
            this.btn_HotWater.TabIndex = 1;
            this.btn_HotWater.Text = "Hot Water";
            this.btn_HotWater.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_HotWater.UseVisualStyleBackColor = false;
            // 
            // btn_Electricity
            // 
            this.btn_Electricity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Electricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Electricity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Electricity.Location = new System.Drawing.Point(3, 3);
            this.btn_Electricity.Name = "btn_Electricity";
            this.btn_Electricity.Size = new System.Drawing.Size(372, 223);
            this.btn_Electricity.TabIndex = 0;
            this.btn_Electricity.Text = "Electricity";
            this.btn_Electricity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Electricity.UseVisualStyleBackColor = false;
            this.btn_Electricity.Click += new System.EventHandler(this.btn_Electricity_Click);
            // 
            // pnl_Electricity
            // 
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_currentPageDispaly);
            this.pnl_Electricity.Controls.Add(this.lbl_SwitchOffTime);
            this.pnl_Electricity.Controls.Add(this.lbl_SwitchOnTime);
            this.pnl_Electricity.Controls.Add(this.lbl_CurrentBill);
            this.pnl_Electricity.Controls.Add(this.lbl_CurrentUsage);
            this.pnl_Electricity.Controls.Add(this.prgBar_);
            this.pnl_Electricity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Electricity.Location = new System.Drawing.Point(0, 0);
            this.pnl_Electricity.Name = "pnl_Electricity";
            this.pnl_Electricity.Size = new System.Drawing.Size(756, 593);
            this.pnl_Electricity.TabIndex = 5;
            this.pnl_Electricity.Visible = false;
            this.pnl_Electricity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Electricity_Paint);
            // 
            // prgBar_
            // 
            this.prgBar_.Location = new System.Drawing.Point(381, 61);
            this.prgBar_.Name = "prgBar_";
            this.prgBar_.Size = new System.Drawing.Size(218, 73);
            this.prgBar_.TabIndex = 0;
            // 
            // lbl_CurrentUsage
            // 
            this.lbl_CurrentUsage.AutoSize = true;
            this.lbl_CurrentUsage.Location = new System.Drawing.Point(12, 89);
            this.lbl_CurrentUsage.Name = "lbl_CurrentUsage";
            this.lbl_CurrentUsage.Size = new System.Drawing.Size(35, 13);
            this.lbl_CurrentUsage.TabIndex = 1;
            this.lbl_CurrentUsage.Text = "label1";
            // 
            // lbl_CurrentBill
            // 
            this.lbl_CurrentBill.AutoSize = true;
            this.lbl_CurrentBill.Location = new System.Drawing.Point(12, 213);
            this.lbl_CurrentBill.Name = "lbl_CurrentBill";
            this.lbl_CurrentBill.Size = new System.Drawing.Size(35, 13);
            this.lbl_CurrentBill.TabIndex = 2;
            this.lbl_CurrentBill.Text = "label1";
            // 
            // lbl_SwitchOnTime
            // 
            this.lbl_SwitchOnTime.AutoSize = true;
            this.lbl_SwitchOnTime.Location = new System.Drawing.Point(12, 350);
            this.lbl_SwitchOnTime.Name = "lbl_SwitchOnTime";
            this.lbl_SwitchOnTime.Size = new System.Drawing.Size(35, 13);
            this.lbl_SwitchOnTime.TabIndex = 3;
            this.lbl_SwitchOnTime.Text = "label1";
            // 
            // lbl_SwitchOffTime
            // 
            this.lbl_SwitchOffTime.AutoSize = true;
            this.lbl_SwitchOffTime.Location = new System.Drawing.Point(12, 492);
            this.lbl_SwitchOffTime.Name = "lbl_SwitchOffTime";
            this.lbl_SwitchOffTime.Size = new System.Drawing.Size(35, 13);
            this.lbl_SwitchOffTime.TabIndex = 4;
            this.lbl_SwitchOffTime.Text = "label1";
            // 
            // lbl_Electricity_currentPageDispaly
            // 
            this.lbl_Electricity_currentPageDispaly.AutoSize = true;
            this.lbl_Electricity_currentPageDispaly.Location = new System.Drawing.Point(339, 556);
            this.lbl_Electricity_currentPageDispaly.Name = "lbl_Electricity_currentPageDispaly";
            this.lbl_Electricity_currentPageDispaly.Size = new System.Drawing.Size(35, 13);
            this.lbl_Electricity_currentPageDispaly.TabIndex = 5;
            this.lbl_Electricity_currentPageDispaly.Text = "label1";
            // 
            // DEACT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 593);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DEACT";
            this.Text = "DEACT";
            this.Load += new System.EventHandler(this.DEACT_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Electricity.ResumeLayout(false);
            this.pnl_Electricity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button btn_HotWater;
        private System.Windows.Forms.Button btn_Electricity;
        private System.Windows.Forms.Label lbl_Main_CurrentPageDisplay;
        private System.Windows.Forms.Button btn_CurrenUsage;
        private System.Windows.Forms.Button btn_Heating;
        private System.Windows.Forms.Panel pnl_Electricity;
        private System.Windows.Forms.ProgressBar prgBar_;
        private System.Windows.Forms.Label lbl_CurrentBill;
        private System.Windows.Forms.Label lbl_CurrentUsage;
        private System.Windows.Forms.Label lbl_SwitchOffTime;
        private System.Windows.Forms.Label lbl_SwitchOnTime;
        private System.Windows.Forms.Label lbl_Electricity_currentPageDispaly;
    }
}

