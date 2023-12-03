using System.Drawing;
using System.Windows.Forms;

namespace DuAn1.MenuControler
{
    partial class QuanLySachChiTiet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgSachCT = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamTaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemUyTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.labelNameShow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKichCo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUyTin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNamTaiBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLanTaiBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTinhTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBarcodeSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgSachCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgSachCT
            // 
            this.DgSachCT.AllowUserToAddRows = false;
            this.DgSachCT.AllowUserToDeleteRows = false;
            this.DgSachCT.AllowUserToResizeColumns = false;
            this.DgSachCT.AllowUserToResizeRows = false;
            this.DgSachCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSachCT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgSachCT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgSachCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSachCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Barcode,
            this.TinhTrang,
            this.LanTaiBan,
            this.NamTaiBan,
            this.KichCo,
            this.DiemUyTin,
            this.NhaXuatBan});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgSachCT.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgSachCT.GridColor = System.Drawing.Color.DarkGray;
            this.DgSachCT.Location = new System.Drawing.Point(13, 182);
            this.DgSachCT.Name = "DgSachCT";
            this.DgSachCT.ReadOnly = true;
            this.DgSachCT.RowTemplate.Height = 25;
            this.DgSachCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSachCT.Size = new System.Drawing.Size(846, 331);
            this.DgSachCT.TabIndex = 1;
            this.DgSachCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSachCT_CellClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 30F;
            this.stt.HeaderText = "Stt";
            this.stt.MinimumWidth = 40;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode Id";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng sách";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // LanTaiBan
            // 
            this.LanTaiBan.HeaderText = "Lần tái bản";
            this.LanTaiBan.Name = "LanTaiBan";
            this.LanTaiBan.ReadOnly = true;
            // 
            // NamTaiBan
            // 
            this.NamTaiBan.HeaderText = "Năm tái bản";
            this.NamTaiBan.Name = "NamTaiBan";
            this.NamTaiBan.ReadOnly = true;
            // 
            // KichCo
            // 
            this.KichCo.HeaderText = "Kích cỡ";
            this.KichCo.Name = "KichCo";
            this.KichCo.ReadOnly = true;
            // 
            // DiemUyTin
            // 
            this.DiemUyTin.HeaderText = "Điểm uy tín";
            this.DiemUyTin.Name = "DiemUyTin";
            this.DiemUyTin.ReadOnly = true;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.FillWeight = 200F;
            this.NhaXuatBan.HeaderText = "Nhà xuất bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(660, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa sách";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(763, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa sách";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(558, 153);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Barcode thông tin:";
            // 
            // tbBarcode
            // 
            this.tbBarcode.BackColor = System.Drawing.Color.White;
            this.tbBarcode.Location = new System.Drawing.Point(113, 16);
            this.tbBarcode.MaxLength = 13;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.ReadOnly = true;
            this.tbBarcode.Size = new System.Drawing.Size(281, 20);
            this.tbBarcode.TabIndex = 13;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(457, 19);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 13);
            this.lbName.TabIndex = 15;
            this.lbName.Text = "Tên sách:";
            // 
            // labelNameShow
            // 
            this.labelNameShow.AutoSize = true;
            this.labelNameShow.Location = new System.Drawing.Point(516, 19);
            this.labelNameShow.Name = "labelNameShow";
            this.labelNameShow.Size = new System.Drawing.Size(23, 13);
            this.labelNameShow.TabIndex = 16;
            this.labelNameShow.Text = "null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKichCo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbNhaXuatBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbUyTin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNamTaiBan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbLanTaiBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTinhTrang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbBarcodeSach);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 104);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // tbKichCo
            // 
            this.tbKichCo.BackColor = System.Drawing.Color.White;
            this.tbKichCo.Location = new System.Drawing.Point(689, 44);
            this.tbKichCo.MaxLength = 13;
            this.tbKichCo.Name = "tbKichCo";
            this.tbKichCo.ReadOnly = true;
            this.tbKichCo.Size = new System.Drawing.Size(147, 20);
            this.tbKichCo.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(644, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Kích cỡ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nhà xuất bản: ";
            // 
            // tbNhaXuatBan
            // 
            this.tbNhaXuatBan.BackColor = System.Drawing.Color.White;
            this.tbNhaXuatBan.Location = new System.Drawing.Point(413, 70);
            this.tbNhaXuatBan.MaxLength = 50;
            this.tbNhaXuatBan.Name = "tbNhaXuatBan";
            this.tbNhaXuatBan.ReadOnly = true;
            this.tbNhaXuatBan.Size = new System.Drawing.Size(210, 20);
            this.tbNhaXuatBan.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Điểm uy tín: ";
            // 
            // tbUyTin
            // 
            this.tbUyTin.BackColor = System.Drawing.Color.White;
            this.tbUyTin.Location = new System.Drawing.Point(98, 71);
            this.tbUyTin.MaxLength = 10;
            this.tbUyTin.Name = "tbUyTin";
            this.tbUyTin.ReadOnly = true;
            this.tbUyTin.Size = new System.Drawing.Size(210, 20);
            this.tbUyTin.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Năm tái bản: ";
            // 
            // tbNamTaiBan
            // 
            this.tbNamTaiBan.BackColor = System.Drawing.Color.White;
            this.tbNamTaiBan.Location = new System.Drawing.Point(413, 44);
            this.tbNamTaiBan.MaxLength = 4;
            this.tbNamTaiBan.Name = "tbNamTaiBan";
            this.tbNamTaiBan.ReadOnly = true;
            this.tbNamTaiBan.Size = new System.Drawing.Size(210, 20);
            this.tbNamTaiBan.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lần tái bản: ";
            // 
            // tbLanTaiBan
            // 
            this.tbLanTaiBan.BackColor = System.Drawing.Color.White;
            this.tbLanTaiBan.Location = new System.Drawing.Point(413, 18);
            this.tbLanTaiBan.MaxLength = 10;
            this.tbLanTaiBan.Name = "tbLanTaiBan";
            this.tbLanTaiBan.ReadOnly = true;
            this.tbLanTaiBan.Size = new System.Drawing.Size(210, 20);
            this.tbLanTaiBan.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tình trạng sách: ";
            // 
            // tbTinhTrang
            // 
            this.tbTinhTrang.BackColor = System.Drawing.Color.White;
            this.tbTinhTrang.Location = new System.Drawing.Point(98, 45);
            this.tbTinhTrang.MaxLength = 50;
            this.tbTinhTrang.Name = "tbTinhTrang";
            this.tbTinhTrang.ReadOnly = true;
            this.tbTinhTrang.Size = new System.Drawing.Size(210, 20);
            this.tbTinhTrang.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Barcode sách:";
            // 
            // tbBarcodeSach
            // 
            this.tbBarcodeSach.BackColor = System.Drawing.Color.White;
            this.tbBarcodeSach.Location = new System.Drawing.Point(98, 19);
            this.tbBarcodeSach.MaxLength = 13;
            this.tbBarcodeSach.Name = "tbBarcodeSach";
            this.tbBarcodeSach.ReadOnly = true;
            this.tbBarcodeSach.Size = new System.Drawing.Size(210, 20);
            this.tbBarcodeSach.TabIndex = 15;
            // 
            // QuanLySachChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNameShow);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DgSachCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuanLySachChiTiet";
            this.Text = "QuanLySachChiTiet";
            this.Load += new System.EventHandler(this.QuanLySachChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgSachCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgSachCT;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn TinhTrang;
        private DataGridViewTextBoxColumn LanTaiBan;
        private DataGridViewTextBoxColumn NamTaiBan;
        private DataGridViewTextBoxColumn KichCo;
        private DataGridViewTextBoxColumn DiemUyTin;
        private DataGridViewTextBoxColumn NhaXuatBan;
        private Button btnSua;
        private Button btnDelete;
        private Button btnThem;
        private Label label2;
        private TextBox tbBarcode;
        private Label lbName;
        private Label labelNameShow;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox tbBarcodeSach;
        private Label label4;
        private TextBox tbTinhTrang;
        private Label label5;
        private TextBox tbLanTaiBan;
        private Label label6;
        private TextBox tbNamTaiBan;
        private Label label8;
        private TextBox tbNhaXuatBan;
        private Label label7;
        private TextBox tbUyTin;
        private Label label9;
        private TextBox tbKichCo;
    }
}