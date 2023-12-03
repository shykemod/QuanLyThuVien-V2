using System.Windows.Forms;

namespace DuAn1.MenuControler
{
    partial class SuaSach
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
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNXB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTacGia = new System.Windows.Forms.TextBox();
            this.cbbViTri = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(84, 10);
            this.tbBarcode.MaxLength = 13;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(351, 20);
            this.tbBarcode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(84, 36);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 20);
            this.tbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(84, 61);
            this.tbGia.MaxLength = 12;
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(102, 20);
            this.tbGia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày xuất bản";
            // 
            // tbNXB
            // 
            this.tbNXB.CustomFormat = "dd/MM/yyyy";
            this.tbNXB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbNXB.Location = new System.Drawing.Point(288, 61);
            this.tbNXB.MaxDate = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            this.tbNXB.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.tbNXB.Name = "tbNXB";
            this.tbNXB.Size = new System.Drawing.Size(147, 20);
            this.tbNXB.TabIndex = 9;
            this.tbNXB.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tác giả";
            // 
            // tbTacGia
            // 
            this.tbTacGia.Location = new System.Drawing.Point(84, 86);
            this.tbTacGia.MaxLength = 256;
            this.tbTacGia.Name = "tbTacGia";
            this.tbTacGia.Size = new System.Drawing.Size(351, 20);
            this.tbTacGia.TabIndex = 10;
            // 
            // cbbViTri
            // 
            this.cbbViTri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbViTri.FormattingEnabled = true;
            this.cbbViTri.Location = new System.Drawing.Point(84, 111);
            this.cbbViTri.Name = "cbbViTri";
            this.cbbViTri.Size = new System.Drawing.Size(351, 21);
            this.cbbViTri.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vị trí";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(155, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(179, 20);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // SuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 173);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbViTri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTacGia);
            this.Controls.Add(this.tbNXB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa thông tin sách";
            this.Load += new System.EventHandler(this.SuaSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbBarcode;
        private Label label1;
        private Label label2;
        private TextBox tbName;
        private Label label3;
        private TextBox tbGia;
        private Label label4;
        private DateTimePicker tbNXB;
        private Label label5;
        private TextBox tbTacGia;
        private ComboBox cbbViTri;
        private Label label6;
        private Button btnSua;
    }
}