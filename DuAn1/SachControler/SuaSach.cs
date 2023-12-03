using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1.DataControler.DataDuAnTableAdapters;
using static DuAn1.DataControler.DataDuAn;

namespace DuAn1.MenuControler
{
    public partial class SuaSach : Form
    {
        SachRow currentEdit;
        List<TheLoaiSachRow> theLoaiSachList;
        public SuaSach(SachRow data)
        {
            InitializeComponent();
            currentEdit = data;
        }

        private void SuaSach_Load(object sender, EventArgs e)
        {
            tbBarcode.Text = currentEdit.barCodeSach;
            tbName.Text = currentEdit.tenSach;
            tbGia.Text = currentEdit.giaTien.ToString();
            tbNXB.Value = currentEdit.namXuatBan;
            tbTacGia.Text = currentEdit.TacGiaSach;
            theLoaiSachList = new TheLoaiSachTableAdapter().GetData().ToList();
            for (int i = 0; i < theLoaiSachList.Count; i++)
            {
                cbbViTri.Items.Add(theLoaiSachList[i].viTriKeSach + " -- " + theLoaiSachList[i].tenTheLoai);
                if (currentEdit.TheLoaiSach.Equals(theLoaiSachList[i].viTriKeSach))
                {
                    cbbViTri.SelectedIndex = i;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbBarcode.Text.Length != 13)
            {
                MessageBox.Show("Mã barcode không hợp lệ, Vui Lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbBarcode.Focus(); return;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbName.Focus(); return;
            }
            decimal CheckGia;
            if (tbGia.Text == "" || !Decimal.TryParse(tbGia.Text, out CheckGia))
            {
                MessageBox.Show("Vui lòng nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbGia.Focus(); return;
            }

            if (tbTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbTacGia.Focus(); return;
            }
            if (cbbViTri.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbbViTri.Focus(); return;
            }
            try
            {
                currentEdit.barCodeSach = tbBarcode.Text;
                currentEdit.tenSach = tbName.Text;
                currentEdit.giaTien = Convert.ToDecimal(tbGia.Text);
                currentEdit.namXuatBan = tbNXB.Value;
                currentEdit.TacGiaSach = tbTacGia.Text;
                currentEdit.TheLoaiSach = theLoaiSachList[cbbViTri.SelectedIndex].viTriKeSach;
                var SachControl = new SachTableAdapter();
                int result = SachControl.Update(currentEdit);
                if (result > 0) { MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
                else MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }
    }
}
