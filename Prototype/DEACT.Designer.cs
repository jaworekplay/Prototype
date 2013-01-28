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
            this.pnl_Electricity = new System.Windows.Forms.Panel();
            this.rdbtn_Electricity_UsageUnits_Pounds = new System.Windows.Forms.RadioButton();
            this.rdbtn_Electricity_UsageUnits_kWh = new System.Windows.Forms.RadioButton();
            this.rdbtn_Electricity_Status_value_OFF = new System.Windows.Forms.RadioButton();
            this.rdbtn_Electricity_Status_value_ON = new System.Windows.Forms.RadioButton();
            this.lbl_Electricity_Status = new System.Windows.Forms.Label();
            this.lbl_Electricity_Season_value = new System.Windows.Forms.Label();
            this.lbl_Electricity_Season = new System.Windows.Forms.Label();
            this.lbl_Electricity_OFF_value = new System.Windows.Forms.Label();
            this.lbl_Electricity_ON_value = new System.Windows.Forms.Label();
            this.lbl_Electricity_CurrentUsage_value = new System.Windows.Forms.Label();
            this.btn_Electricity_back = new System.Windows.Forms.Button();
            this.lbl_Electricity_currentPageDispaly = new System.Windows.Forms.Label();
            this.lbl_SwitchOffTime = new System.Windows.Forms.Label();
            this.lbl_SwitchOnTime = new System.Windows.Forms.Label();
            this.lbl_CurrentBill = new System.Windows.Forms.Label();
            this.lbl_CurrentUsage = new System.Windows.Forms.Label();
            this.prgBar_CurrentUsage = new System.Windows.Forms.ProgressBar();
            this.lbl_Main_CurrentPageDisplay = new System.Windows.Forms.Label();
            this.btn_CurrenUsage = new System.Windows.Forms.Button();
            this.btn_Heating = new System.Windows.Forms.Button();
            this.btn_HotWater = new System.Windows.Forms.Button();
            this.btn_Electricity = new System.Windows.Forms.Button();
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
            // pnl_Electricity
            // 
            this.pnl_Electricity.Controls.Add(this.rdbtn_Electricity_UsageUnits_Pounds);
            this.pnl_Electricity.Controls.Add(this.rdbtn_Electricity_UsageUnits_kWh);
            this.pnl_Electricity.Controls.Add(this.rdbtn_Electricity_Status_value_OFF);
            this.pnl_Electricity.Controls.Add(this.rdbtn_Electricity_Status_value_ON);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_Status);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_Season_value);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_Season);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_OFF_value);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_ON_value);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_CurrentUsage_value);
            this.pnl_Electricity.Controls.Add(this.btn_Electricity_back);
            this.pnl_Electricity.Controls.Add(this.lbl_Electricity_currentPageDispaly);
            this.pnl_Electricity.Controls.Add(this.lbl_SwitchOffTime);
            this.pnl_Electricity.Controls.Add(this.lbl_SwitchOnTime);
            this.pnl_Electricity.Controls.Add(this.lbl_CurrentBill);
            this.pnl_Electricity.Controls.Add(this.lbl_CurrentUsage);
            this.pnl_Electricity.Controls.Add(this.prgBar_CurrentUsage);
            this.pnl_Electricity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Electricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Electricity.Location = new System.Drawing.Point(0, 0);
            this.pnl_Electricity.Name = "pnl_Electricity";
            this.pnl_Electricity.Size = new System.Drawing.Size(756, 593);
            this.pnl_Electricity.TabIndex = 5;
            this.pnl_Electricity.Visible = false;
            this.pnl_Electricity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Electricity_Paint);
            // 
            // rdbtn_Electricity_UsageUnits_Pounds
            // 
            this.rdbtn_Electricity_UsageUnits_Pounds.AutoCheck = false;
            this.rdbtn_Electricity_UsageUnits_Pounds.AutoSize = true;
            this.rdbtn_Electricity_UsageUnits_Pounds.Checked = true;
            this.rdbtn_Electricity_UsageUnits_Pounds.Location = new System.Drawing.Point(518, 259);
            this.rdbtn_Electricity_UsageUnits_Pounds.Name = "rdbtn_Electricity_UsageUnits_Pounds";
            this.rdbtn_Electricity_UsageUnits_Pounds.Size = new System.Drawing.Size(53, 41);
            this.rdbtn_Electricity_UsageUnits_Pounds.TabIndex = 16;
            this.rdbtn_Electricity_UsageUnits_Pounds.TabStop = true;
            this.rdbtn_Electricity_UsageUnits_Pounds.Text = "£";
            this.rdbtn_Electricity_UsageUnits_Pounds.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Electricity_UsageUnits_kWh
            // 
            this.rdbtn_Electricity_UsageUnits_kWh.AutoCheck = false;
            this.rdbtn_Electricity_UsageUnits_kWh.AutoSize = true;
            this.rdbtn_Electricity_UsageUnits_kWh.Location = new System.Drawing.Point(381, 259);
            this.rdbtn_Electricity_UsageUnits_kWh.Name = "rdbtn_Electricity_UsageUnits_kWh";
            this.rdbtn_Electricity_UsageUnits_kWh.Size = new System.Drawing.Size(100, 41);
            this.rdbtn_Electricity_UsageUnits_kWh.TabIndex = 15;
            this.rdbtn_Electricity_UsageUnits_kWh.Text = "kWh";
            this.rdbtn_Electricity_UsageUnits_kWh.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Electricity_Status_value_OFF
            // 
            this.rdbtn_Electricity_Status_value_OFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_Electricity_Status_value_OFF.AutoCheck = false;
            this.rdbtn_Electricity_Status_value_OFF.AutoSize = true;
            this.rdbtn_Electricity_Status_value_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtn_Electricity_Status_value_OFF.Location = new System.Drawing.Point(638, 31);
            this.rdbtn_Electricity_Status_value_OFF.Name = "rdbtn_Electricity_Status_value_OFF";
            this.rdbtn_Electricity_Status_value_OFF.Size = new System.Drawing.Size(92, 47);
            this.rdbtn_Electricity_Status_value_OFF.TabIndex = 14;
            this.rdbtn_Electricity_Status_value_OFF.Text = "OFF";
            this.rdbtn_Electricity_Status_value_OFF.UseVisualStyleBackColor = true;
            this.rdbtn_Electricity_Status_value_OFF.Click += new System.EventHandler(this.rdbtn_Electricity_Status_value_OFF_Click);
            // 
            // rdbtn_Electricity_Status_value_ON
            // 
            this.rdbtn_Electricity_Status_value_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_Electricity_Status_value_ON.AutoCheck = false;
            this.rdbtn_Electricity_Status_value_ON.AutoSize = true;
            this.rdbtn_Electricity_Status_value_ON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbtn_Electricity_Status_value_ON.Location = new System.Drawing.Point(383, 31);
            this.rdbtn_Electricity_Status_value_ON.Name = "rdbtn_Electricity_Status_value_ON";
            this.rdbtn_Electricity_Status_value_ON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_Electricity_Status_value_ON.TabIndex = 13;
            this.rdbtn_Electricity_Status_value_ON.TabStop = true;
            this.rdbtn_Electricity_Status_value_ON.Text = "ON";
            this.rdbtn_Electricity_Status_value_ON.UseVisualStyleBackColor = true;
            // 
            // lbl_Electricity_Status
            // 
            this.lbl_Electricity_Status.AutoSize = true;
            this.lbl_Electricity_Status.Location = new System.Drawing.Point(12, 31);
            this.lbl_Electricity_Status.Name = "lbl_Electricity_Status";
            this.lbl_Electricity_Status.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_Status.TabIndex = 12;
            this.lbl_Electricity_Status.Text = "label1";
            // 
            // lbl_Electricity_Season_value
            // 
            this.lbl_Electricity_Season_value.AutoSize = true;
            this.lbl_Electricity_Season_value.Location = new System.Drawing.Point(374, 322);
            this.lbl_Electricity_Season_value.Name = "lbl_Electricity_Season_value";
            this.lbl_Electricity_Season_value.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_Season_value.TabIndex = 11;
            this.lbl_Electricity_Season_value.Text = "label1";
            // 
            // lbl_Electricity_Season
            // 
            this.lbl_Electricity_Season.AutoSize = true;
            this.lbl_Electricity_Season.Location = new System.Drawing.Point(12, 322);
            this.lbl_Electricity_Season.Name = "lbl_Electricity_Season";
            this.lbl_Electricity_Season.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_Season.TabIndex = 10;
            this.lbl_Electricity_Season.Text = "label1";
            // 
            // lbl_Electricity_OFF_value
            // 
            this.lbl_Electricity_OFF_value.AutoSize = true;
            this.lbl_Electricity_OFF_value.Location = new System.Drawing.Point(374, 464);
            this.lbl_Electricity_OFF_value.Name = "lbl_Electricity_OFF_value";
            this.lbl_Electricity_OFF_value.Size = new System.Drawing.Size(102, 37);
            this.lbl_Electricity_OFF_value.TabIndex = 9;
            this.lbl_Electricity_OFF_value.Text = "label2";
            // 
            // lbl_Electricity_ON_value
            // 
            this.lbl_Electricity_ON_value.AutoSize = true;
            this.lbl_Electricity_ON_value.Location = new System.Drawing.Point(374, 390);
            this.lbl_Electricity_ON_value.Name = "lbl_Electricity_ON_value";
            this.lbl_Electricity_ON_value.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_ON_value.TabIndex = 8;
            this.lbl_Electricity_ON_value.Text = "label1";
            // 
            // lbl_Electricity_CurrentUsage_value
            // 
            this.lbl_Electricity_CurrentUsage_value.AutoSize = true;
            this.lbl_Electricity_CurrentUsage_value.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Electricity_CurrentUsage_value.Location = new System.Drawing.Point(631, 259);
            this.lbl_Electricity_CurrentUsage_value.Name = "lbl_Electricity_CurrentUsage_value";
            this.lbl_Electricity_CurrentUsage_value.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_CurrentUsage_value.TabIndex = 7;
            this.lbl_Electricity_CurrentUsage_value.Text = "label1";
            // 
            // btn_Electricity_back
            // 
            this.btn_Electricity_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Electricity_back.Location = new System.Drawing.Point(607, 503);
            this.btn_Electricity_back.Name = "btn_Electricity_back";
            this.btn_Electricity_back.Size = new System.Drawing.Size(146, 84);
            this.btn_Electricity_back.TabIndex = 6;
            this.btn_Electricity_back.Text = "button1";
            this.btn_Electricity_back.UseVisualStyleBackColor = true;
            this.btn_Electricity_back.Click += new System.EventHandler(this.btn_Electricity_back_Click);
            // 
            // lbl_Electricity_currentPageDispaly
            // 
            this.lbl_Electricity_currentPageDispaly.AutoSize = true;
            this.lbl_Electricity_currentPageDispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Electricity_currentPageDispaly.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Electricity_currentPageDispaly.Location = new System.Drawing.Point(339, 528);
            this.lbl_Electricity_currentPageDispaly.Name = "lbl_Electricity_currentPageDispaly";
            this.lbl_Electricity_currentPageDispaly.Size = new System.Drawing.Size(100, 37);
            this.lbl_Electricity_currentPageDispaly.TabIndex = 5;
            this.lbl_Electricity_currentPageDispaly.Text = "label1";
            // 
            // lbl_SwitchOffTime
            // 
            this.lbl_SwitchOffTime.AutoSize = true;
            this.lbl_SwitchOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchOffTime.Location = new System.Drawing.Point(12, 464);
            this.lbl_SwitchOffTime.Name = "lbl_SwitchOffTime";
            this.lbl_SwitchOffTime.Size = new System.Drawing.Size(100, 37);
            this.lbl_SwitchOffTime.TabIndex = 4;
            this.lbl_SwitchOffTime.Text = "label1";
            // 
            // lbl_SwitchOnTime
            // 
            this.lbl_SwitchOnTime.AutoSize = true;
            this.lbl_SwitchOnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SwitchOnTime.Location = new System.Drawing.Point(12, 390);
            this.lbl_SwitchOnTime.Name = "lbl_SwitchOnTime";
            this.lbl_SwitchOnTime.Size = new System.Drawing.Size(100, 37);
            this.lbl_SwitchOnTime.TabIndex = 3;
            this.lbl_SwitchOnTime.Text = "label1";
            // 
            // lbl_CurrentBill
            // 
            this.lbl_CurrentBill.AutoSize = true;
            this.lbl_CurrentBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentBill.Location = new System.Drawing.Point(12, 259);
            this.lbl_CurrentBill.Name = "lbl_CurrentBill";
            this.lbl_CurrentBill.Size = new System.Drawing.Size(100, 37);
            this.lbl_CurrentBill.TabIndex = 2;
            this.lbl_CurrentBill.Text = "label1";
            // 
            // lbl_CurrentUsage
            // 
            this.lbl_CurrentUsage.AutoSize = true;
            this.lbl_CurrentUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentUsage.Location = new System.Drawing.Point(12, 167);
            this.lbl_CurrentUsage.Name = "lbl_CurrentUsage";
            this.lbl_CurrentUsage.Size = new System.Drawing.Size(100, 37);
            this.lbl_CurrentUsage.TabIndex = 1;
            this.lbl_CurrentUsage.Text = "label1";
            // 
            // prgBar_CurrentUsage
            // 
            this.prgBar_CurrentUsage.Location = new System.Drawing.Point(383, 167);
            this.prgBar_CurrentUsage.Name = "prgBar_CurrentUsage";
            this.prgBar_CurrentUsage.Size = new System.Drawing.Size(347, 37);
            this.prgBar_CurrentUsage.TabIndex = 0;
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
            this.btn_CurrenUsage.BackgroundImage = global::Prototype.Properties.Resources.CurrentUsage_icon;
            this.btn_CurrenUsage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CurrenUsage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CurrenUsage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_CurrenUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CurrenUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CurrenUsage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CurrenUsage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CurrenUsage.Location = new System.Drawing.Point(381, 232);
            this.btn_CurrenUsage.Name = "btn_CurrenUsage";
            this.btn_CurrenUsage.Size = new System.Drawing.Size(372, 223);
            this.btn_CurrenUsage.TabIndex = 3;
            this.btn_CurrenUsage.Text = "Current Usage";
            this.btn_CurrenUsage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CurrenUsage.UseVisualStyleBackColor = false;
            // 
            // btn_Heating
            // 
            this.btn_Heating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Heating.BackgroundImage = global::Prototype.Properties.Resources.heating_icon;
            this.btn_Heating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Heating.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Heating.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Heating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Heating.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Heating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Heating.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Heating.Location = new System.Drawing.Point(3, 232);
            this.btn_Heating.Name = "btn_Heating";
            this.btn_Heating.Size = new System.Drawing.Size(372, 223);
            this.btn_Heating.TabIndex = 2;
            this.btn_Heating.Text = "Heating";
            this.btn_Heating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Heating.UseVisualStyleBackColor = false;
            // 
            // btn_HotWater
            // 
            this.btn_HotWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_HotWater.BackgroundImage = global::Prototype.Properties.Resources.HotWater_icon;
            this.btn_HotWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_HotWater.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_HotWater.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_HotWater.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_HotWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HotWater.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_HotWater.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HotWater.Location = new System.Drawing.Point(381, 3);
            this.btn_HotWater.Name = "btn_HotWater";
            this.btn_HotWater.Size = new System.Drawing.Size(372, 223);
            this.btn_HotWater.TabIndex = 1;
            this.btn_HotWater.Text = "Hot Water";
            this.btn_HotWater.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HotWater.UseVisualStyleBackColor = false;
            // 
            // btn_Electricity
            // 
            this.btn_Electricity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Electricity.BackgroundImage = global::Prototype.Properties.Resources.Electricity_icon;
            this.btn_Electricity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Electricity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Electricity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Electricity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Electricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Electricity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Electricity.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Electricity.Location = new System.Drawing.Point(3, 3);
            this.btn_Electricity.Name = "btn_Electricity";
            this.btn_Electricity.Size = new System.Drawing.Size(372, 223);
            this.btn_Electricity.TabIndex = 0;
            this.btn_Electricity.Text = "Electricity";
            this.btn_Electricity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Electricity.UseVisualStyleBackColor = false;
            this.btn_Electricity.Click += new System.EventHandler(this.btn_Electricity_Click);
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
        private System.Windows.Forms.ProgressBar prgBar_CurrentUsage;
        private System.Windows.Forms.Label lbl_CurrentBill;
        private System.Windows.Forms.Label lbl_CurrentUsage;
        private System.Windows.Forms.Label lbl_SwitchOffTime;
        private System.Windows.Forms.Label lbl_SwitchOnTime;
        private System.Windows.Forms.Label lbl_Electricity_currentPageDispaly;
        private System.Windows.Forms.Button btn_Electricity_back;
        private System.Windows.Forms.Label lbl_Electricity_CurrentUsage_value;
        private System.Windows.Forms.Label lbl_Electricity_OFF_value;
        private System.Windows.Forms.Label lbl_Electricity_ON_value;
        private System.Windows.Forms.Label lbl_Electricity_Season_value;
        private System.Windows.Forms.Label lbl_Electricity_Season;
        private System.Windows.Forms.RadioButton rdbtn_Electricity_Status_value_ON;
        private System.Windows.Forms.Label lbl_Electricity_Status;
        private System.Windows.Forms.RadioButton rdbtn_Electricity_Status_value_OFF;
        private System.Windows.Forms.RadioButton rdbtn_Electricity_UsageUnits_Pounds;
        private System.Windows.Forms.RadioButton rdbtn_Electricity_UsageUnits_kWh;
    }
}

