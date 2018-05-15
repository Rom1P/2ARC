namespace _2ARC
{
    partial class ApplyRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyRules));
            this.iconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonIconTray = new System.Windows.Forms.Button();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.addNewIpButton = new System.Windows.Forms.Button();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.blockPortButton = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.listBoxMac = new System.Windows.Forms.ListBox();
            this.blockMacButton = new System.Windows.Forms.Button();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // buttonIconTray
            // 
            this.buttonIconTray.Location = new System.Drawing.Point(725, 627);
            this.buttonIconTray.Name = "buttonIconTray";
            this.buttonIconTray.Size = new System.Drawing.Size(197, 38);
            this.buttonIconTray.TabIndex = 1;
            this.buttonIconTray.Text = "Reduce To System Tray";
            this.buttonIconTray.UseVisualStyleBackColor = true;
            this.buttonIconTray.Click += new System.EventHandler(this.buttonIconTray_Click);
            // 
            // IPtextBox
            // 
            this.IPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtextBox.Location = new System.Drawing.Point(91, 122);
            this.IPtextBox.Multiline = true;
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(199, 32);
            this.IPtextBox.TabIndex = 2;
            // 
            // addNewIpButton
            // 
            this.addNewIpButton.Location = new System.Drawing.Point(91, 253);
            this.addNewIpButton.Name = "addNewIpButton";
            this.addNewIpButton.Size = new System.Drawing.Size(199, 43);
            this.addNewIpButton.TabIndex = 3;
            this.addNewIpButton.Text = "Block packets from this IP";
            this.addNewIpButton.UseVisualStyleBackColor = true;
            this.addNewIpButton.Click += new System.EventHandler(this.AddNewIpButton_Click);
            // 
            // listBoxIP
            // 
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.Location = new System.Drawing.Point(91, 402);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(199, 147);
            this.listBoxIP.TabIndex = 4;
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.Location = new System.Drawing.Point(369, 402);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(199, 147);
            this.listBoxPort.TabIndex = 7;
            // 
            // blockPortButton
            // 
            this.blockPortButton.Location = new System.Drawing.Point(369, 253);
            this.blockPortButton.Name = "blockPortButton";
            this.blockPortButton.Size = new System.Drawing.Size(199, 43);
            this.blockPortButton.TabIndex = 6;
            this.blockPortButton.Text = "Block packets from this Port";
            this.blockPortButton.UseVisualStyleBackColor = true;
            this.blockPortButton.Click += new System.EventHandler(this.blockPortButton_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(369, 122);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(199, 32);
            this.textBoxPort.TabIndex = 5;
            // 
            // listBoxMac
            // 
            this.listBoxMac.FormattingEnabled = true;
            this.listBoxMac.Location = new System.Drawing.Point(662, 402);
            this.listBoxMac.Name = "listBoxMac";
            this.listBoxMac.Size = new System.Drawing.Size(199, 147);
            this.listBoxMac.TabIndex = 10;
            // 
            // blockMacButton
            // 
            this.blockMacButton.Location = new System.Drawing.Point(662, 253);
            this.blockMacButton.Name = "blockMacButton";
            this.blockMacButton.Size = new System.Drawing.Size(199, 43);
            this.blockMacButton.TabIndex = 9;
            this.blockMacButton.Text = "Block packets from this Mac Address";
            this.blockMacButton.UseVisualStyleBackColor = true;
            this.blockMacButton.Click += new System.EventHandler(this.blockMacButton_Click);
            // 
            // textBoxMac
            // 
            this.textBoxMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMac.Location = new System.Drawing.Point(662, 122);
            this.textBoxMac.Multiline = true;
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(199, 32);
            this.textBoxMac.TabIndex = 8;
            // 
            // ApplyRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 677);
            this.Controls.Add(this.listBoxMac);
            this.Controls.Add(this.blockMacButton);
            this.Controls.Add(this.textBoxMac);
            this.Controls.Add(this.listBoxPort);
            this.Controls.Add(this.blockPortButton);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.listBoxIP);
            this.Controls.Add(this.addNewIpButton);
            this.Controls.Add(this.IPtextBox);
            this.Controls.Add(this.buttonIconTray);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.Resize += new System.EventHandler(this.ApplyRules_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIconTray;
        private System.Windows.Forms.NotifyIcon iconTray;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button addNewIpButton;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.Button blockPortButton;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ListBox listBoxMac;
        private System.Windows.Forms.Button blockMacButton;
        private System.Windows.Forms.TextBox textBoxMac;
    }
}