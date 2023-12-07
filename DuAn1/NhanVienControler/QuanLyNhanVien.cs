using DuAn1.DataControler.DataDuAnTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DuAn1.DataControler.DataDuAn;

namespace DuAn1.NhanVienControler
{
    public partial class QuanLyNhanVien : UserControl
    {
        List<NhanVienRow> listNv;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            DgNhanVien.Rows.Clear();
            listNv = new NhanVienTableAdapter().GetData().Where(nv => !nv.role).ToList();
            for (int i = 1; i <= listNv.Count(); i++)
            {

                var nhanVien = listNv[i - 1];
                DgNhanVien.Rows.Add(
                i.ToString(),
                nhanVien.idNhanVien,
                nhanVien.hoTen,
                nhanVien.gioiTinh ? "Nam" : "Nữ",
                nhanVien.ngaySinh.ToString("dd/MM/yyyy"),
                nhanVien.soDienThoai,
                nhanVien.email,
                nhanVien.diaChi,
                nhanVien.userName,
                nhanVien.passWord

                );
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

            ShowData();

        }
    }
}
