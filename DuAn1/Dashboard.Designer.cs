﻿namespace DuAn1
{
    partial class Dashboard
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
            this.panelView = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQlSach = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.Control;
            this.panelView.Location = new System.Drawing.Point(175, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1070, 584);
            this.panelView.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.btnQlSach);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 590);
            this.panelMenu.TabIndex = 1;
            // 
            // btnQLNV
            // 
            this.btnQLNV.Location = new System.Drawing.Point(0, 142);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(170, 50);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQlSach
            // 
            this.btnQlSach.Location = new System.Drawing.Point(0, 87);
            this.btnQlSach.Name = "btnQlSach";
            this.btnQlSach.Size = new System.Drawing.Size(170, 50);
            this.btnQlSach.TabIndex = 0;
            this.btnQlSach.Text = "Quản lý sách";
            this.btnQlSach.UseVisualStyleBackColor = true;
            this.btnQlSach.Click += new System.EventHandler(this.btnQlSach_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 583);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnQlSach;
        private System.Windows.Forms.Button btnQLNV;
    }
}