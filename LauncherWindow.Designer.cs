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
            this.ReadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ReadButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadButton.ForeColor = System.Drawing.Color.White;
            this.ReadButton.Location = new System.Drawing.Point(138, 458);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(153, 68);
            this.ReadButton.TabIndex = 0;
            this.ReadButton.Text = "Read output file";
            this.ReadButton.UseVisualStyleBackColor = false;
            this.ReadButton.UseWaitCursor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CurrentNetworkButton
            // 
            this.CurrentNetworkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.CurrentNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentNetworkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNetworkButton.ForeColor = System.Drawing.Color.White;
            this.CurrentNetworkButton.Location = new System.Drawing.Point(608, 458);
            this.CurrentNetworkButton.Name = "CurrentNetworkButton";
            this.CurrentNetworkButton.Size = new System.Drawing.Size(153, 68);
            this.CurrentNetworkButton.TabIndex = 1;
            this.CurrentNetworkButton.Text = "Current Network";
            this.CurrentNetworkButton.UseVisualStyleBackColor = false;
            this.CurrentNetworkButton.Click += new System.EventHandler(this.CurrentNetworkButton_Click);
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.RulesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RulesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesButton.ForeColor = System.Drawing.Color.White;
            this.RulesButton.Location = new System.Drawing.Point(376, 458);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(153, 68);
            this.RulesButton.TabIndex = 2;
            this.RulesButton.Text = "SetRules";
            this.RulesButton.UseVisualStyleBackColor = false;
            this.RulesButton.Click += new System.EventHandler(this.RulesButton_Click);
            // 
            // LauncherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(901, 621);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.CurrentNetworkButton);
            this.Controls.Add(this.ReadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.Load += new System.EventHandler(this.LauncherWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button CurrentNetworkButton;
        private System.Windows.Forms.Button RulesButton;
    }
}