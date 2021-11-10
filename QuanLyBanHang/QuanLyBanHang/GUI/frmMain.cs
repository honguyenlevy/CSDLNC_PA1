using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;
using System.Data.SqlClient;


namespace QuanLyBanHang
{
    public partial class MainQL : Form
    {
        public MainQL()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainQL_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void TaoHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyBanHang.GUI.frmTaoHD frm = new GUI.frmTaoHD();
            frm.ShowDialog();
        }

        private void DanhSachHoaDon_Click(object sender, EventArgs e)
        {
            QuanLyBanHang.GUI.frmXemDSHD frm = new GUI.frmXemDSHD();
            frm.ShowDialog();
        }

        private void DoanhThu_Click(object sender, EventArgs e)
        {
            QuanLyBanHang.GUI.frmTKDoanhThu frm = new GUI.frmTKDoanhThu();
            frm.ShowDialog();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Function.Disconnect();
            Application.Exit();
        }       
    }
}
