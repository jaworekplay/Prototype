namespace Prototype
{
    partial class Heating
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
            this.rdbtn_OFF = new System.Windows.Forms.RadioButton();
            this.rdbtn_ON = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tempIndicator = new System.Windows.Forms.Label();
            this.trckbr = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).BeginInit();
            this.splCtn.Panel1.SuspendLayout();
            this.splCtn.Panel2.SuspendLayout();
            this.splCtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).BeginInit();
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
            this.splCtn.Panel1.Controls.Add(this.rdbtn_OFF);
            this.splCtn.Panel1.Controls.Add(this.rdbtn_ON);
            this.splCtn.Panel1.Controls.Add(this.lbl_Status);
            this.splCtn.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splCtn.Panel2
            // 
            this.splCtn.Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splCtn.Panel2.Controls.Add(this.trckbr);
            this.splCtn.Panel2.Controls.Add(this.lbl_tempIndicator);
            this.splCtn.Panel2.Controls.Add(this.label1);
            this.splCtn.Size = new System.Drawing.Size(746, 583);
            this.splCtn.SplitterDistance = 77;
            this.splCtn.TabIndex = 0;
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
            // rdbtn_ON
            // 
            this.rdbtn_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbtn_ON.AutoSize = true;
            this.rdbtn_ON.Checked = true;
            this.rdbtn_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_ON.Location = new System.Drawing.Point(327, 12);
            this.rdbtn_ON.Name = "rdbtn_ON";
            this.rdbtn_ON.Size = new System.Drawing.Size(76, 47);
            this.rdbtn_ON.TabIndex = 1;
            this.rdbtn_ON.TabStop = true;
            this.rdbtn_ON.Text = "ON";
            this.rdbtn_ON.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 22);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(108, 37);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // lbl_tempIndicator
            // 
            this.lbl_tempIndicator.AutoSize = true;
            this.lbl_tempIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempIndicator.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_tempIndicator.Location = new System.Drawing.Point(397, 44);
            this.lbl_tempIndicator.Name = "lbl_tempIndicator";
            this.lbl_tempIndicator.Size = new System.Drawing.Size(104, 73);
            this.lbl_tempIndicator.TabIndex = 12;
            this.lbl_tempIndicator.Text = "40";
            // 
            // trckbr
            // 
            this.trckbr.LargeChange = 10;
            this.trckbr.Location = new System.Drawing.Point(642, 3);
            this.trckbr.Maximum = 50;
            this.trckbr.Name = "trckbr";
            this.trckbr.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckbr.Size = new System.Drawing.Size(45, 181);
            this.trckbr.TabIndex = 13;
            this.trckbr.TickFrequency = 10;
            // 
            // Heating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 583);
            this.Controls.Add(this.splCtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Heating";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heating";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Heating_FormClosing);
            this.splCtn.Panel1.ResumeLayout(false);
            this.splCtn.Panel1.PerformLayout();
            this.splCtn.Panel2.ResumeLayout(false);
            this.splCtn.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCtn)).EndInit();
            this.splCtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trckbr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splCtn;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.RadioButton rdbtn_OFF;
        private System.Windows.Forms.RadioButton rdbtn_ON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tempIndicator;
        private System.Windows.Forms.TrackBar trckbr;
    }
}