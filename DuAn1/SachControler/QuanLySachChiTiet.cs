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
using DuAn1.LoginControler;
using static DuAn1.DataControler.DataDuAn;

namespace DuAn1.MenuControler
{
    public partial class QuanLySachChiTiet : Form
    {
        string BarcodeSach;
        int IndexSelect = 0;
        SachChiTietRow CurrentSelect = null;
        List<SachChiTietRow> dataSachChiTiet;

        public QuanLySachChiTiet(string id)
        {
            InitializeComponent();
            BarcodeSach = id;
        }

        void ShowData()
        {
            DgSachCT.Rows.Clear();
            dataSachChiTiet = new SachChiTietTableAdapter().GetData().Where(a => a.Field<string>("barCodeSach").Equals(BarcodeSach)).ToList();
            for (int i = 1; i <= dataSachChiTiet.Count(); i++)
            {
                var sachCT = dataSachChiTiet[i-1];
                DgSachCT.Rows.Add(
                    i.ToString(),
                    sachCT.barCodeMaSach,
                    sachCT.tinhTrangSach,
                    sachCT.lanTaiBan,
                    sachCT.namTaiBan,
                    sachCT.kichCo,
                    sachCT.diemUyTinMin,
                    sachCT.NhaXuatBan
                );
            }
        }

        private void QuanLySachChiTiet_Load(object sender, EventArgs e)
        {
            ShowData();
            tbBarcode.Text = BarcodeSach;
            labelNameShow.Text = new SachTableAdapter().GetData().FindBybarCodeSach(BarcodeSach).tenSach;
        }

        private void DgSachCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexSelect = e.RowIndex;
            if (IndexSelect < 0) return;
            CurrentSelect = new SachChiTietTableAdapter().GetData().Where(sct => sct.barCodeSach.Equals(BarcodeSach)).ToList()[IndexSelect];
            tbBarcodeSach.Text = CurrentSelect.barCodeMaSach;
            tbTinhTrang.Text = CurrentSelect.tinhTrangSach;
            tbLanTaiBan.Text = CurrentSelect.lanTaiBan.ToString();
            tbKichCo.Text = CurrentSelect.kichCo;
            tbNamTaiBan.Text = CurrentSelect.namTaiBan.ToString();
            tbUyTin.Text = CurrentSelect.diemUyTinMin.ToString();
            tbNhaXuatBan.Text = CurrentSelect.NhaXuatBan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbBarcodeSach.Text == "") { MessageBox.Show("Vui lòng nhập barcode", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbBarcodeSach.Focus(); return; }
            if (new SachChiTietTableAdapter().GetData().FindBybarCodeMaSach(tbBarcodeSach.Text) != null) { MessageBox.Show("barcode đã tồn tại", "Thông báo"); tbBarcodeSach.Focus(); return; }
            if (tbTinhTrang.Text == "") { MessageBox.Show("Vui lòng nhập tình trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbTinhTrang.Focus(); return; }
            int DiemUyTin;
            if (tbUyTin.Text == "" || !(int.TryParse(tbUyTin.Text, out DiemUyTin) && DiemUyTin > 0 && DiemUyTin < 10000))
            { MessageBox.Show("Vui lòng nhập lại điểm uy tín tối thiểu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbUyTin.Focus(); return; }
            int SoLanTaiBan;
            if (tbLanTaiBan.Text == "" || !(int.TryParse(tbLanTaiBan.Text, out SoLanTaiBan) && SoLanTaiBan > 0 && SoLanTaiBan < 100)) 
                { MessageBox.Show("Vui lòng nhập lại số lần tái bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbLanTaiBan.Focus(); return; }
            int NamTaiBan;
            if (tbNamTaiBan.Text == "" || !(int.TryParse(tbNamTaiBan.Text, out NamTaiBan) && NamTaiBan > 1900 && NamTaiBan < DateTime.Now.Year)) 
                { MessageBox.Show("Vui lòng nhập năm tái bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNamTaiBan.Focus(); return; }
            if (tbNhaXuatBan.Text == "") { MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNhaXuatBan.Focus(); return; }
            if (tbKichCo.Text == "") { MessageBox.Show("Vui lòng nhập kích cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbKichCo.Focus(); return; }
            try
            {
                int result = new SachChiTietTableAdapter().Insert(tbBarcodeSach.Text, tbBarcode.Text, tbTinhTrang.Text, SoLanTaiBan, tbKichCo.Text, NamTaiBan, DiemUyTin, tbNhaXuatBan.Text);
                if (result > 0) { MessageBox.Show("Thêm thành công", "Thông báo"); ShowData(); LoginRes.dashboard.qlSachForm.ShowData(); }
                else MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentSelect == null) return;  
            var check = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                try
                {
                    int result = new SachChiTietTableAdapter().Delete(
                        CurrentSelect.barCodeMaSach,
                        CurrentSelect.barCodeSach,
                        CurrentSelect.tinhTrangSach,
                        CurrentSelect.lanTaiBan,
                        CurrentSelect.kichCo,
                        CurrentSelect.namTaiBan,
                        CurrentSelect.diemUyTinMin,
                        CurrentSelect.NhaXuatBan
                        );
                    if (result > 0) { MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); ShowData(); LoginRes.dashboard.qlSachForm.ShowData(); }
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbBarcodeSach.Text == "") { MessageBox.Show("Vui lòng nhập barcode", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbBarcodeSach.Focus(); return; }
            if (new SachChiTietTableAdapter().GetData().FindBybarCodeMaSach(tbBarcodeSach.Text) == null) { MessageBox.Show("barcode không tồn tại", "Thông báo"); tbBarcodeSach.Focus(); return; }
            if (tbTinhTrang.Text == "") { MessageBox.Show("Vui lòng nhập tình trạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbTinhTrang.Focus(); return; }
            int DiemUyTin;
            if (tbUyTin.Text == "" || !(int.TryParse(tbUyTin.Text, out DiemUyTin) && DiemUyTin > 0 && DiemUyTin < 10000))
            { MessageBox.Show("Vui lòng nhập lại điểm uy tín tối thiểu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbUyTin.Focus(); return; }
            int SoLanTaiBan;
            if (tbLanTaiBan.Text == "" || !(int.TryParse(tbLanTaiBan.Text, out SoLanTaiBan) && SoLanTaiBan > 0 && SoLanTaiBan < 100))
            { MessageBox.Show("Vui lòng nhập lại số lần tái bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbLanTaiBan.Focus(); return; }
            int NamTaiBan;
            if (tbNamTaiBan.Text == "" || !(int.TryParse(tbNamTaiBan.Text, out NamTaiBan) && NamTaiBan > 1900 && NamTaiBan < DateTime.Now.Year))
            { MessageBox.Show("Vui lòng nhập năm tái bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNamTaiBan.Focus(); return; }
            if (tbNhaXuatBan.Text == "") { MessageBox.Show("Vui lòng nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNhaXuatBan.Focus(); return; }
            if (tbKichCo.Text == "") { MessageBox.Show("Vui lòng nhập kích cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbKichCo.Focus(); return; }
            try
            {
                CurrentSelect.barCodeMaSach = tbBarcodeSach.Text;
                CurrentSelect.barCodeSach = tbBarcode.Text;
                CurrentSelect.tinhTrangSach = tbTinhTrang.Text;
                CurrentSelect.lanTaiBan = SoLanTaiBan;
                CurrentSelect.kichCo = tbKichCo.Text;
                CurrentSelect.namTaiBan = NamTaiBan;
                CurrentSelect.diemUyTinMin = DiemUyTin;
                CurrentSelect.NhaXuatBan = tbNhaXuatBan.Text;
                int result = new SachChiTietTableAdapter().Update(CurrentSelect);
                if (result > 0) { MessageBox.Show("Sửa thành công", "Thông báo"); ShowData(); LoginRes.dashboard.qlSachForm.ShowData(); }

            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
        }
    }
}
