namespace _2ARC
{
    partial class ReadOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadOutput));
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.GoMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoMenu
            // 
            this.GoMenu.Location = new System.Drawing.Point(12, 461);
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(75, 23);
            this.GoMenu.TabIndex = 0;
            this.GoMenu.Text = "Menu";
            this.GoMenu.UseVisualStyleBackColor = true;
            this.GoMenu.Click += new System.EventHandler(this.GoMenu_Click);
            // 
            // ReadOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 496);
            this.Controls.Add(this.GoMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadOutput";
            this.Load += new System.EventHandler(this.ReadOutput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button GoMenu;
    }
}