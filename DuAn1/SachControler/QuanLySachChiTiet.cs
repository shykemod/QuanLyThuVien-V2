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
    public partial class QuanLySachChiTiet : Form
    {
        string BarcodeSach;
        int IndexSelect = 0;
        List<SachChiTietRow> dataSachChiTiet;

        public QuanLySachChiTiet(string id)
        {
            InitializeComponent();
            BarcodeSach = id;
        }

        void ShowData()
        {
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

        }
    }
}
