namespace _2ARC
{
    partial class CurrentNetwork
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentNetwork));
            this.buttonIconTray = new System.Windows.Forms.Button();
            this.iconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.checkBoxDevMode = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIconTray
            // 
            this.buttonIconTray.Location = new System.Drawing.Point(810, 702);
            this.buttonIconTray.Name = "buttonIconTray";
            this.buttonIconTray.Size = new System.Drawing.Size(197, 38);
            this.buttonIconTray.TabIndex = 2;
            this.buttonIconTray.Text = "Reduce To System Tray";
            this.buttonIconTray.UseVisualStyleBackColor = true;
            this.buttonIconTray.Click += new System.EventHandler(this.buttonIconTray_Click);
            // 
            // iconTray
            // 
            this.iconTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconTray.BalloonTipText = "Application running in bakcground";
            this.iconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconTray.Icon")));
            this.iconTray.Text = "Firewall";
            this.iconTray.Visible = true;
            this.iconTray.Click += new System.EventHandler(this.OnClickIconTray);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(455, 702);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 33);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkBoxDevMode
            // 
            this.checkBoxDevMode.AutoSize = true;
            this.checkBoxDevMode.Location = new System.Drawing.Point(617, 711);
            this.checkBoxDevMode.Name = "checkBoxDevMode";
            this.checkBoxDevMode.Size = new System.Drawing.Size(133, 17);
            this.checkBoxDevMode.TabIndex = 4;
            this.checkBoxDevMode.Text = "Use Developper Mode";
            this.checkBoxDevMode.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(455, 649);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 33);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(12, 705);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(104, 33);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // CurrentNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 752);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.checkBoxDevMode);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.buttonIconTray);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentNetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.Load += new System.EventHandler(this.CurrentNetwork_Load);
            this.Resize += new System.EventHandler(this.CurrentNetwork_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIconTray;
        private System.Windows.Forms.NotifyIcon iconTray;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox checkBoxDevMode;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button menuButton;
    }
}