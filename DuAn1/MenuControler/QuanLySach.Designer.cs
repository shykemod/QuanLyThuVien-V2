using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.MenuControler
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgSach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.cbTypeSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgSach)).BeginInit();
            this.SuspendLayout();
            // 
            // DgSach
            // 
            this.DgSach.AllowUserToAddRows = false;
            this.DgSach.AllowUserToDeleteRows = false;
            this.DgSach.AllowUserToResizeColumns = false;
            this.DgSach.AllowUserToResizeRows = false;
            this.DgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSach.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.ID,
            this.Ten,
            this.Gia,
            this.NamXuatBan,
            this.TacGia,
            this.TheLoai,
            this.SoLuong});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgSach.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgSach.GridColor = System.Drawing.Color.DarkGray;
            this.DgSach.Location = new System.Drawing.Point(6, 69);
            this.DgSach.Name = "DgSach";
            this.DgSach.ReadOnly = true;
            this.DgSach.RowTemplate.Height = 25;
            this.DgSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSach.Size = new System.Drawing.Size(1055, 459);
            this.DgSach.TabIndex = 0;
            this.DgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSach_CellClick);
            this.DgSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSach_CellDoubleClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "Stt";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 59.39498F;
            this.ID.HeaderText = "Barcode";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.FillWeight = 59.39498F;
            this.Ten.HeaderText = "Tên sách";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.FillWeight = 44.54623F;
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.FillWeight = 44.54623F;
            this.NamXuatBan.HeaderText = "Năm xuất bản";
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.FillWeight = 74.24372F;
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // TheLoai
            // 
            this.TheLoai.FillWeight = 74.24372F;
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 30F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(758, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(962, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(860, 40);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(58, 40);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(187, 20);
            this.tbFind.TabIndex = 5;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // cbTypeSearch
            // 
            this.cbTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeSearch.FormattingEnabled = true;
            this.cbTypeSearch.Items.AddRange(new object[] {
            "Tìm theo barcode",
            "Tìm theo tên",
            "Tìm theo tác giả",
            "Tìm theo thể loại"});
            this.cbTypeSearch.Location = new System.Drawing.Point(251, 40);
            this.cbTypeSearch.Name = "cbTypeSearch";
            this.cbTypeSearch.Size = new System.Drawing.Size(121, 21);
            this.cbTypeSearch.TabIndex = 6;
            this.cbTypeSearch.SelectedIndexChanged += new System.EventHandler(this.cbTypeSearch_SelectedIndexChanged);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTypeSearch);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DgSach);
            this.Name = "QuanLySach";
            this.Size = new System.Drawing.Size(1070, 584);
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgSach;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn NamXuatBan;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.ComboBox cbTypeSearch;
    }
}
