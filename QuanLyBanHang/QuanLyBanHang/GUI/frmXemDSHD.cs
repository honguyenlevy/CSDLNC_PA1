using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;

namespace QuanLyBanHang.GUI
{
    public partial class frmXemDSHD : Form
    {
        //DataTable DSHD;
        public frmXemDSHD()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        DataSet GetAllHoaDon()
        {
            DataSet data = new DataSet();
            String sql = "SELECT * FROM HoaDon";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void batDau_click(object sender, EventArgs e)
        {
            dataGridDSHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDSHD.DataSource = GetAllHoaDon().Tables[0];
        }
    }
}
