namespace Prototype
{
    partial class Hot_Water
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
            this.mainCnt = new System.Windows.Forms.SplitContainer();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.rdbtn_ON = new System.Windows.Forms.RadioButton();
            this.rdbtn_OFF = new System.Windows.Forms.RadioButton();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.trckbr = new System.Windows.Forms.TrackBar();
            this.lbl_tempIndicator = new System.Windows.Forms.Label();
            this.lbl_ON = new System.Windows.Forms.Label();
            this.lbl_OFF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainCnt)).BeginInit();
            this.mainCnt.Panel1.SuspendLayout();
            this.mainCnt.Panel2.SuspendLayout();
            this.mainCnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCnt
            // 
            this.mainCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCnt.Location = new System.Drawing.Point(0, 0);
            this.mainCnt.Name = "mainCnt";
            this.mainCnt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainCnt.Panel1
            // 
            this.mainCnt.Panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.mainCnt.Panel1.Controls.Add(this.rdbtn_OFF);
            this.mainCnt.Panel1.Controls.Add(this.rdbtn_ON);
            this.mainCnt.Panel1.Controls.Add(this.lbl_Status);
            this.mainCnt.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // mainCnt.Panel2
            // 
            this.mainCnt.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mainCnt.Panel2.Controls.Add(this.lbl_OFF);
            this.mainCnt.Panel2.Controls.Add(this.lbl_ON);
            this.mainCnt.Panel2.Controls.Add(this.lbl_tempIndicator);
            this.mainCnt.Panel2.Controls.Add(this.trckbr);
            this.mainCnt.Panel2.Controls.Add(this.lbl_temp);
            this.mainCnt.Size = new System.Drawing.Size(746, 583);
            this.mainCnt.SplitterDistance = 76;
            this.mainCnt.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 24);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(108, 37);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // rdbtn_ON
            // 
            this.rdbtn_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_ON.AutoSize = true;
            this.rdbtn_ON.Checked = true;
            this.rdbtn_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_ON.Location = new System.Drawing.Point(326, 12);
            this.rdbtn_ON.Name = "rdbtn_ON";
            this.rdbtn_ON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_ON.TabIndex = 1;
            this.rdbtn_ON.TabStop = true;
            this.rdbtn_ON.Text = "ON";
            this.rdbtn_ON.UseVisualStyleBackColor = true;
            // 
            // rdbtn_OFF
            // 
            this.rdbtn_OFF.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_OFF.AutoSize = true;
            this.rdbtn_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_OFF.Location = new System.Drawing.Point(642, 12);
            this.rdbtn_OFF.Name = "rdbtn_OFF";
            this.rdbtn_OFF.Size = new System.Drawing.Size(92, 47);
            this.rdbtn_OFF.TabIndex = 2;
            this.rdbtn_OFF.Text = "OFF";
            this.rdbtn_OFF.UseVisualStyleBackColor = true;
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_temp.Location = new System.Drawing.Point(12, 75);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(200, 37);
            this.lbl_temp.TabIndex = 0;
            this.lbl_temp.Text = "Temperature";
            // 
            // trckbr
            // 
            this.trckbr.LargeChange = 10;
            this.trckbr.Location = new System.Drawing.Point(642, 3);
            this.trckbr.Maximum = 50;
            this.trckbr.Name = "trckbr";
            this.trckbr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckbr.Size = new System.Drawing.Size(45, 181);
            this.trckbr.TabIndex = 10;
            this.trckbr.TickFrequency = 10;
            this.trckbr.Scroll += new System.EventHandler(this.trckbr_Scroll);
            // 
            // lbl_tempIndicator
            // 
            this.lbl_tempIndicator.AutoSize = true;
            this.lbl_tempIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempIndicator.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tempIndicator.Location = new System.Drawing.Point(397, 45);
            this.lbl_tempIndicator.Name = "lbl_tempIndicator";
            this.lbl_tempIndicator.Size = new System.Drawing.Size(104, 73);
            this.lbl_tempIndicator.TabIndex = 11;
            this.lbl_tempIndicator.Text = "40";
            // 
            // lbl_ON
            // 
            this.lbl_ON.AutoSize = true;
            this.lbl_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ON.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ON.Location = new System.Drawing.Point(12, 209);
            this.lbl_ON.Name = "lbl_ON";
            this.lbl_ON.Size = new System.Drawing.Size(238, 37);
            this.lbl_ON.TabIndex = 12;
            this.lbl_ON.Text = "Switch ON time";
            // 
            // lbl_OFF
            // 
            this.lbl_OFF.AutoSize = true;
            this.lbl_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OFF.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_OFF.Location = new System.Drawing.Point(12, 298);
            this.lbl_OFF.Name = "lbl_OFF";
            this.lbl_OFF.Size = new System.Drawing.Size(254, 37);
            this.lbl_OFF.TabIndex = 13;
            this.lbl_OFF.Text = "Switch OFF time";
            // 
            // Hot_Water
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 583);
            this.Controls.Add(this.mainCnt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hot_Water";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hot_Water";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hot_Water_FormClosing);
            this.Load += new System.EventHandler(this.Hot_Water_Load);
            this.mainCnt.Panel1.ResumeLayout(false);
            this.mainCnt.Panel1.PerformLayout();
            this.mainCnt.Panel2.ResumeLayout(false);
            this.mainCnt.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainCnt)).EndInit();
            this.mainCnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainCnt;
        private System.Windows.Forms.RadioButton rdbtn_OFF;
        private System.Windows.Forms.RadioButton rdbtn_ON;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.TrackBar trckbr;
        private System.Windows.Forms.Label lbl_tempIndicator;
        private System.Windows.Forms.Label lbl_OFF;
        private System.Windows.Forms.Label lbl_ON;
    }
}