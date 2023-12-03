using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuAn1.MenuControler;
using DuAn1.NhanVienControler;

namespace DuAn1
{
    public partial class Dashboard : Form
    {
        public QuanLySach qlSachForm = new QuanLySach();
        public QuanLyNhanVien qlNhanVienForm = new QuanLyNhanVien();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelView.Controls.Add(qlSachForm);
        }

        private void btnQlSach_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            panelView.Controls.Add(qlSachForm);
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            panelView.Controls.Clear();
            panelView.Controls.Add(qlNhanVienForm);
        }
    }
}
