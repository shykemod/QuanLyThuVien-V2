using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataControler.DataDuAnTableAdapters;
using static WindowsFormsApp1.DataControler.DataDuAn;

namespace WindowsFormsApp1.MenuControler
{
    public partial class ThemSach : Form
    {
        List<TheLoaiSachRow> theLoaiSachList;
        public ThemSach()
        {
            InitializeComponent();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            theLoaiSachList = new TheLoaiSachTableAdapter().GetData().ToList();
            foreach (var item in theLoaiSachList)
            {
                cbbViTri.Items.Add(item.viTriKeSach + " -- " + item.tenTheLoai);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                var SachControl = new SachTableAdapter();
                int result = SachControl.Insert(tbBarcode.Text, tbName.Text, Convert.ToDecimal(tbGia.Text), tbNXB.Value, tbTacGia.Text, theLoaiSachList[cbbViTri.SelectedIndex].viTriKeSach);
                if (result > 0) { MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
                else MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }
    }
}
