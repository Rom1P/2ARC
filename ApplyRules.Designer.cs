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
            this.buttonIconTray.Location = new System.Drawing.Point(668, 577);
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
            this.IPtextBox.Location = new System.Drawing.Point(128, 161);
            this.IPtextBox.Multiline = true;
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(199, 35);
            this.IPtextBox.TabIndex = 2;
            // 
            // addNewIpButton
            // 
            this.addNewIpButton.Location = new System.Drawing.Point(130, 283);
            this.addNewIpButton.Name = "addNewIpButton";
            this.addNewIpButton.Size = new System.Drawing.Size(197, 70);
            this.addNewIpButton.TabIndex = 3;
            this.addNewIpButton.Text = "Block Trafic with this IP Address";
            this.addNewIpButton.UseVisualStyleBackColor = true;
            this.addNewIpButton.Click += new System.EventHandler(this.AddNewIpButton_Click);
            // 
            // ApplyRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 630);
            this.Controls.Add(this.addNewIpButton);
            this.Controls.Add(this.IPtextBox);
            this.Controls.Add(this.buttonIconTray);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyRules";
            this.Text = "ApplyRules";
            this.Resize += new System.EventHandler(this.ApplyRules_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIconTray;
        private System.Windows.Forms.NotifyIcon iconTray;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button addNewIpButton;
    }
}