namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQlSach = new System.Windows.Forms.Button();
            this.dataDuAn = new WindowsFormsApp1.DataControler.DataDuAn();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new WindowsFormsApp1.DataControler.DataDuAnTableAdapters.SachTableAdapter();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Location = new System.Drawing.Point(175, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1070, 584);
            this.panelView.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnQlSach);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(170, 590);
            this.panelMenu.TabIndex = 1;
            // 
            // btnQlSach
            // 
            this.btnQlSach.Location = new System.Drawing.Point(13, 113);
            this.btnQlSach.Name = "btnQlSach";
            this.btnQlSach.Size = new System.Drawing.Size(154, 23);
            this.btnQlSach.TabIndex = 0;
            this.btnQlSach.Text = "Quản lý sách";
            this.btnQlSach.UseVisualStyleBackColor = true;
            this.btnQlSach.Click += new System.EventHandler(this.btnQlSach_Click);
            // 
            // dataDuAn
            // 
            this.dataDuAn.DataSetName = "DataDuAn";
            this.dataDuAn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.dataDuAn;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
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
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelMenu;
        private DataControler.DataDuAn dataDuAn;
        private System.Windows.Forms.BindingSource sachBindingSource;
        private DataControler.DataDuAnTableAdapters.SachTableAdapter sachTableAdapter;
        private System.Windows.Forms.Button btnQlSach;
    }
}