using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataControler.DataDuAnTableAdapters;
using static WindowsFormsApp1.DataControler.DataDuAn;

namespace WindowsFormsApp1.MenuControler
{
    public partial class QuanLySach : UserControl
    {
        List<SachRow> dataSach;
        int IndexSelect = 0;
        public QuanLySach()
        {
            InitializeComponent();

        }

        string GetTheLoaiByID(string id)
        {
            var TheLoai = new TheLoaiSachTableAdapter().GetData().FindByviTriKeSach(id);
            return TheLoai.tenTheLoai;
        }

        int getCountById(string id)
        {
            var dataSachChiTiet = new SachChiTietTableAdapter().GetData().Where(a => a.Field<string>("barCodeSach").Equals(id));
            return dataSachChiTiet.Count();
        }

        void ShowData() 
        {
            if (tbFind.Text.Length == 0) dataSach = new SachTableAdapter().GetData().ToList();
            else
            {
                dataSach = new SachTableAdapter().GetData().Where(s =>
                (cbTypeSearch.SelectedIndex == 0 && s.barCodeSach.Contains(tbFind.Text)) ||
                (cbTypeSearch.SelectedIndex == 1 && s.tenSach.ToLower().Contains(tbFind.Text.ToLower())) ||
                (cbTypeSearch.SelectedIndex == 2 && s.TacGiaSach.ToLower().Contains(tbFind.Text.ToLower())) ||
                (cbTypeSearch.SelectedIndex == 3 && GetTheLoaiByID(s.TheLoaiSach).ToLower().Contains(tbFind.Text.ToLower()))
                ).ToList();
            }

            DgSach.Rows.Clear();
            for (int i = 1; i <= dataSach.Count(); i++)
            {
                var sach = dataSach[i - 1];
                DgSach.Rows.Add(
                i.ToString(),
                sach.barCodeSach,
                sach.tenSach,
                sach.giaTien,
                ((DateTime?)sach.namXuatBan)?.ToString("dd/MM/yyyy"),
                sach.TacGiaSach,
                GetTheLoaiByID(sach.TheLoaiSach),
                getCountById(sach.barCodeSach)
                );
            }
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            cbTypeSearch.SelectedIndex = 0;
            ShowData();
        }

        private void DgSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form sachCT = new QuanLySachChiTiet((string)(new SachTableAdapter().GetData().Rows[e.RowIndex])["BarCodeSach"]);
            sachCT.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new ThemSach().ShowDialog();
            ShowData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            new SuaSach((new SachTableAdapter().GetData().ToList())[IndexSelect]).ShowDialog();
            ShowData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                try
                {
                    var currentSach = (new SachTableAdapter().GetData().ToList())[IndexSelect];
                    var sach = new SachTableAdapter();
                    int result = sach.Delete(currentSach.barCodeSach, currentSach.tenSach, currentSach.giaTien, currentSach.namXuatBan, currentSach.TacGiaSach, currentSach.TheLoaiSach);
                    if (result > 0) MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    else MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            return;
        }

        private void DgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexSelect = e.RowIndex;
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void cbTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
