namespace prayer_time_1._0._0
{
    partial class windowLabel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLabel2 = new System.Windows.Forms.Label();
            this.cDate = new System.Windows.Forms.Label();
            this.cTimeDate = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSunrise = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(244, 181);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSunrise);
            this.tabPage1.Controls.Add(this.txtLabel2);
            this.tabPage1.Controls.Add(this.cDate);
            this.tabPage1.Controls.Add(this.cTimeDate);
            this.tabPage1.Controls.Add(this.txtLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(236, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLabel2
            // 
            this.txtLabel2.AutoSize = true;
            this.txtLabel2.Location = new System.Drawing.Point(6, 52);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.Size = new System.Drawing.Size(45, 13);
            this.txtLabel2.TabIndex = 3;
            this.txtLabel2.Text = "Sunrise:";
            // 
            // cDate
            // 
            this.cDate.AutoSize = true;
            this.cDate.Location = new System.Drawing.Point(13, 29);
            this.cDate.Name = "cDate";
            this.cDate.Size = new System.Drawing.Size(28, 13);
            this.cDate.TabIndex = 2;
            this.cDate.Text = "date";
            // 
            // cTimeDate
            // 
            this.cTimeDate.AutoSize = true;
            this.cTimeDate.Location = new System.Drawing.Point(13, 16);
            this.cTimeDate.Name = "cTimeDate";
            this.cTimeDate.Size = new System.Drawing.Size(26, 13);
            this.cTimeDate.TabIndex = 1;
            this.cTimeDate.Text = "time";
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(6, 3);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(117, 13);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "Current Time and Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(236, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monthly";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSunrise
            // 
            this.txtSunrise.AutoSize = true;
            this.txtSunrise.Location = new System.Drawing.Point(13, 65);
            this.txtSunrise.Name = "txtSunrise";
            this.txtSunrise.Size = new System.Drawing.Size(16, 13);
            this.txtSunrise.TabIndex = 4;
            this.txtSunrise.Text = "---";
            // 
            // windowLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(267, 230);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "windowLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prayer Reminder";
            this.Load += new System.EventHandler(this.windowLabel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label cTimeDate;
        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cDate;
        private System.Windows.Forms.Label txtLabel2;
        private System.Windows.Forms.Label txtSunrise;
    }
}

