namespace _2ARC
{
    partial class LauncherWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherWindow));
            this.ReadButton = new System.Windows.Forms.Button();
            this.CurrentNetworkButton = new System.Windows.Forms.Button();
            this.RulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(355, 153);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(153, 68);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Read output file";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.UseWaitCursor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CurrentNetworkButton
            // 
            this.CurrentNetworkButton.Location = new System.Drawing.Point(355, 279);
            this.CurrentNetworkButton.Name = "CurrentNetworkButton";
            this.CurrentNetworkButton.Size = new System.Drawing.Size(153, 68);
            this.CurrentNetworkButton.TabIndex = 1;
            this.CurrentNetworkButton.Text = "Current Network";
            this.CurrentNetworkButton.UseVisualStyleBackColor = true;
            this.CurrentNetworkButton.Click += new System.EventHandler(this.CurrentNetworkButton_Click);
            // 
            // RulesButton
            // 
            this.RulesButton.Location = new System.Drawing.Point(355, 402);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(153, 68);
            this.RulesButton.TabIndex = 2;
            this.RulesButton.Text = "SetRules";
            this.RulesButton.UseVisualStyleBackColor = true;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.CurrentNetworkButton);
            this.Controls.Add(this.ReadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2ARC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button CurrentNetworkButton;
        private System.Windows.Forms.Button RulesButton;
    }
}