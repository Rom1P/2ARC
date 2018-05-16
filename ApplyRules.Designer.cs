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
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.addNewIpButton = new System.Windows.Forms.Button();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.blockPortButton = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.NetworkButton = new System.Windows.Forms.Button();
            this.resetPortButton = new System.Windows.Forms.Button();
            this.resetIPButton = new System.Windows.Forms.Button();
            this.deleteSelectedIP = new System.Windows.Forms.Button();
            this.RemovePortButton = new System.Windows.Forms.Button();
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
            // IPtextBox
            // 
            this.IPtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtextBox.Location = new System.Drawing.Point(223, 71);
            this.IPtextBox.Multiline = true;
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(199, 32);
            this.IPtextBox.TabIndex = 2;
            // 
            // addNewIpButton
            // 
            this.addNewIpButton.Location = new System.Drawing.Point(223, 173);
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
            this.listBoxIP.Location = new System.Drawing.Point(223, 303);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(199, 147);
            this.listBoxIP.TabIndex = 4;
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.Location = new System.Drawing.Point(501, 303);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(199, 147);
            this.listBoxPort.TabIndex = 7;
            // 
            // blockPortButton
            // 
            this.blockPortButton.Location = new System.Drawing.Point(501, 173);
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
            this.textBoxPort.Location = new System.Drawing.Point(501, 71);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(199, 32);
            this.textBoxPort.TabIndex = 5;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(12, 632);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(104, 33);
            this.menuButton.TabIndex = 8;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // NetworkButton
            // 
            this.NetworkButton.Location = new System.Drawing.Point(786, 632);
            this.NetworkButton.Name = "NetworkButton";
            this.NetworkButton.Size = new System.Drawing.Size(136, 33);
            this.NetworkButton.TabIndex = 9;
            this.NetworkButton.Text = "Use on network traffic";
            this.NetworkButton.UseVisualStyleBackColor = true;
            this.NetworkButton.Click += new System.EventHandler(this.NetworkButton_Click);
            // 
            // resetPortButton
            // 
            this.resetPortButton.Location = new System.Drawing.Point(501, 486);
            this.resetPortButton.Name = "resetPortButton";
            this.resetPortButton.Size = new System.Drawing.Size(199, 43);
            this.resetPortButton.TabIndex = 11;
            this.resetPortButton.Text = "Reset Port Block List";
            this.resetPortButton.UseVisualStyleBackColor = true;
            this.resetPortButton.Click += new System.EventHandler(this.resetPortButton_Click);
            // 
            // resetIPButton
            // 
            this.resetIPButton.Location = new System.Drawing.Point(223, 486);
            this.resetIPButton.Name = "resetIPButton";
            this.resetIPButton.Size = new System.Drawing.Size(199, 43);
            this.resetIPButton.TabIndex = 10;
            this.resetIPButton.Text = "Reset IP Block List";
            this.resetIPButton.UseVisualStyleBackColor = true;
            this.resetIPButton.Click += new System.EventHandler(this.resetIPButton_Click);
            // 
            // deleteSelectedIP
            // 
            this.deleteSelectedIP.BackgroundImage = global::_2ARC.Properties.Resources.trash;
            this.deleteSelectedIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteSelectedIP.Location = new System.Drawing.Point(121, 332);
            this.deleteSelectedIP.Name = "deleteSelectedIP";
            this.deleteSelectedIP.Size = new System.Drawing.Size(60, 64);
            this.deleteSelectedIP.TabIndex = 12;
            this.deleteSelectedIP.UseVisualStyleBackColor = true;
            this.deleteSelectedIP.Click += new System.EventHandler(this.deleteSelectedIP_Click);
            // 
            // RemovePortButton
            // 
            this.RemovePortButton.BackgroundImage = global::_2ARC.Properties.Resources.trash;
            this.RemovePortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemovePortButton.Location = new System.Drawing.Point(745, 332);
            this.RemovePortButton.Name = "RemovePortButton";
            this.RemovePortButton.Size = new System.Drawing.Size(60, 64);
            this.RemovePortButton.TabIndex = 13;
            this.RemovePortButton.UseVisualStyleBackColor = true;
            this.RemovePortButton.Click += new System.EventHandler(this.RemovePortButton_Click);
            // 
            // ApplyRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 677);
            this.Controls.Add(this.RemovePortButton);
            this.Controls.Add(this.deleteSelectedIP);
            this.Controls.Add(this.resetPortButton);
            this.Controls.Add(this.resetIPButton);
            this.Controls.Add(this.NetworkButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.listBoxPort);
            this.Controls.Add(this.blockPortButton);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.listBoxIP);
            this.Controls.Add(this.addNewIpButton);
            this.Controls.Add(this.IPtextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.Load += new System.EventHandler(this.ApplyRules_Load);
            this.Resize += new System.EventHandler(this.ApplyRules_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon iconTray;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button addNewIpButton;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.Button blockPortButton;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button NetworkButton;
        private System.Windows.Forms.Button resetPortButton;
        private System.Windows.Forms.Button resetIPButton;
        private System.Windows.Forms.Button deleteSelectedIP;
        private System.Windows.Forms.Button RemovePortButton;
    }
}