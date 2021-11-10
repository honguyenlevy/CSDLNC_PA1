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
        
        private void ThongKe_Click(object sender, EventArgs e)
        {
            String sql;

            if ((textNam.Text.Trim().Length == 0) || (textNam.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập năm thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNam.Text = "";
                textNam.Focus();
                return;
            }
     
            sql = "SELECT Year(NgayLap) FROM HoaDon WHERE Year(NgayLap) = N'" + textNam.Text.Trim() + "' ";
            if (!Function.CheckKey(sql))
            {
                MessageBox.Show("Năm bạn nhập không có trong hệ thống, bạn hãy nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNam.Focus();
                return;
            }
            Function.RunSQL(sql);
            LoadDataGridView();
        }
    }
}
