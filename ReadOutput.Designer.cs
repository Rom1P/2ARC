﻿namespace _2ARC
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
            this.ApplyRulesButton = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoMenu
            // 
            this.GoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.GoMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GoMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoMenu.ForeColor = System.Drawing.Color.White;
            this.GoMenu.Location = new System.Drawing.Point(12, 571);
            this.GoMenu.Name = "GoMenu";
            this.GoMenu.Size = new System.Drawing.Size(116, 49);
            this.GoMenu.TabIndex = 0;
            this.GoMenu.Text = "Menu";
            this.GoMenu.UseVisualStyleBackColor = false;
            this.GoMenu.Click += new System.EventHandler(this.GoMenu_Click);
            // 
            // ApplyRulesButton
            // 
            this.ApplyRulesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ApplyRulesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ApplyRulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyRulesButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyRulesButton.ForeColor = System.Drawing.Color.White;
            this.ApplyRulesButton.Location = new System.Drawing.Point(339, 557);
            this.ApplyRulesButton.Name = "ApplyRulesButton";
            this.ApplyRulesButton.Size = new System.Drawing.Size(212, 41);
            this.ApplyRulesButton.TabIndex = 1;
            this.ApplyRulesButton.Text = "Apply Rules to this file";
            this.ApplyRulesButton.UseVisualStyleBackColor = false;
            this.ApplyRulesButton.Click += new System.EventHandler(this.ApplyRulesButton_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.textBoxOutput.ForeColor = System.Drawing.Color.White;
            this.textBoxOutput.Location = new System.Drawing.Point(81, 97);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(761, 430);
            this.textBoxOutput.TabIndex = 2;
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.openFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.ForeColor = System.Drawing.Color.White;
            this.openFileButton.Location = new System.Drawing.Point(370, 24);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(155, 37);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // ReadOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(921, 632);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.ApplyRulesButton);
            this.Controls.Add(this.GoMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firewall";
            this.Load += new System.EventHandler(this.ReadOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button GoMenu;
        private System.Windows.Forms.Button ApplyRulesButton;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button openFileButton;
    }
}