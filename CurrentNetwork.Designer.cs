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
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.timerReload = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonIconTray
            // 
            this.buttonIconTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.buttonIconTray.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIconTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIconTray.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIconTray.ForeColor = System.Drawing.Color.White;
            this.buttonIconTray.Location = new System.Drawing.Point(810, 687);
            this.buttonIconTray.Name = "buttonIconTray";
            this.buttonIconTray.Size = new System.Drawing.Size(197, 53);
            this.buttonIconTray.TabIndex = 2;
            this.buttonIconTray.Text = "Reduce To System Tray";
            this.buttonIconTray.UseVisualStyleBackColor = false;
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
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(590, 603);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 51);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkBoxDevMode
            // 
            this.checkBoxDevMode.AutoSize = true;
            this.checkBoxDevMode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDevMode.ForeColor = System.Drawing.Color.White;
            this.checkBoxDevMode.Location = new System.Drawing.Point(427, 704);
            this.checkBoxDevMode.Name = "checkBoxDevMode";
            this.checkBoxDevMode.Size = new System.Drawing.Size(160, 21);
            this.checkBoxDevMode.TabIndex = 4;
            this.checkBoxDevMode.Text = "Use Developper Mode";
            this.checkBoxDevMode.UseVisualStyleBackColor = true;
            this.checkBoxDevMode.CheckedChanged += new System.EventHandler(this.checkBoxDevMode_CheckedChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(308, 603);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(112, 51);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(12, 688);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(145, 51);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.listBoxOutput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOutput.ForeColor = System.Drawing.Color.White;
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 17;
            this.listBoxOutput.Location = new System.Drawing.Point(151, 82);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(698, 480);
            this.listBoxOutput.TabIndex = 10;
            // 
            // timerReload
            // 
            this.timerReload.Interval = 2000;
            this.timerReload.Tick += new System.EventHandler(this.timerReload_Tick);
            // 
            // CurrentNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1019, 752);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.checkBoxDevMode);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.buttonIconTray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentNetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentNetwork_Closing);
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
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Timer timerReload;
    }
}