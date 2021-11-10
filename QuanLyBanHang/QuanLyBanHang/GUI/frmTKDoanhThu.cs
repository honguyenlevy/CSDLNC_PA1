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

namespace QuanLyBanHang.GUI
{
    public partial class frmTKDoanhThu : Form
    {
        public frmTKDoanhThu()
        {
            InitializeComponent();
        }


        DataSet GetAllThongKe()
        {
            DataSet data = new DataSet();
            //String sql = "select  ct.MaSP, sp.TenSP, sum(ct.SoLuong * (ct.GiaBan - ct.GiaGiam)) as ThanhTien from CT_HoaDon ct, SanPham sp where ct.MaSP = sp.MaSP and ct.MaHD in (select MaHD from HoaDon where month(NgayLap) = N'"+textThang.Text.Trim()+"' and year(NgayLap) = N'"+textNam.Text.Trim()+"') group by ct.MaSP, sp.TenSP order by sum(ct.SoLuong * (ct.GiaBan - ct.GiaGiam)) DESC;";
            String sql = "select distinct  month(Ngaylap) as N'Tháng', sum(TongTien) as N'Tổng doanh thu' from HoaDon where year(NgayLap) = N'" + textNam.Text.Trim() + "' group by month(NgayLap) order by month(NgayLap); ";

            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }


        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDataGridView()
        {
            dataGridDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDoanhThu.DataSource = GetAllThongKe().Tables[0];

        }

        private void dataGridDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        
        private void ThongKe_Click(object sender, EventArgs e)
        {
            String sql;//= "select cthd.MaSP, sp.TenSP, cthd.ThanhTien from CT_HoaDon cthd, SanPham sp where cthd.MaSP = sp.MaSP and  cthd.ThanhTien in (select max(ThanhTien) from CT_HoaDon)";

            if ((textNam.Text.Trim().Length == 0) || (textNam.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập năm thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNam.Text = "";
                textNam.Focus();
                return;
            }
            //string nam = "select distinct YEAR(NgayLap) from HoaDon order by YEAR(NgayLap)";
            //if ((textThang.Text.Trim().Length == 0) || (textThang.Text == "0"))
            //{
            //    MessageBox.Show("Bạn phải nhập tháng thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    textThang.Text = "";
            //    textThang.Focus();
            //    return;
            //}
            //sql = "SELECT Month(NgayLap) FROM HoaDon WHERE Month(NgayLap) = N'" + textThang.Text.Trim() + "' ";
            //if (!Function.CheckKey(sql))
            //{
            //    MessageBox.Show("Tháng bạn nhập không đúng, bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //ResetValuesSP();
            //    textThang.Focus();
            //    return;
            //}
            sql = "SELECT Year(NgayLap) FROM HoaDon WHERE Year(NgayLap) = N'" + textNam.Text.Trim() + "' ";
            if (!Function.CheckKey(sql))
            {
                MessageBox.Show("Năm bạn nhập không đúng, bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ResetValuesSP();
                textNam.Focus();
                return;
            }
            Function.RunSQL(sql);
            LoadDataGridView();
        }

      
    }
}
