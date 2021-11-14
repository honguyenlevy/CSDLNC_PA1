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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QuanLyBanHang.GUI
{
    
    public partial class frmTaoHD : Form
    {
        DataTable CTHoaDon;
        public frmTaoHD()
        {
            InitializeComponent();
        }

        DataSet GetAllHoaDon()
        {
            DataSet data = new DataSet();
            String sql = "SELECT ct.MaSP, sp.TenSP, ct.SoLuong, ct.GiaBan, ct.GiaGiam, ct.ThanhTien FROM CT_HoaDon ct, SanPham sp, HoaDon hd, KhachHang kh WHERE ct.MaHD = N'" + textMaHoaDon.Text + "' AND ct.MaSP = sp.MaSP AND hd.MaHD = ct.MaHD AND kh.MaKH = N'" + comboMaKhachHang.SelectedValue +"' AND hd.MaKH = kh.MaKH";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void LoadDataGridView()
        {
            gridHoaDon.DataSource = GetAllHoaDon().Tables[0];
            
        }

        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            ThemHoaDon.Enabled = true;
            LuuHoaDon.Enabled = true;
            textMaHoaDon.ReadOnly = false;
            textTenKhachHang.ReadOnly = true;
            textGiaBan.ReadOnly = true;
            textTenSanPham.ReadOnly = true;
            textThanhTien.ReadOnly = true;
            textTongTien.ReadOnly = true;
            textGiaGiam.ReadOnly = true;
            textTongTien.Text = "0";
            ///
            Function.FillCombo("SELECT MaKH FROM KhachHang", comboMaKhachHang, "MaKH", "MaKH");
            comboMaKhachHang.SelectedIndex = -1;
            Function.FillCombo("SELECT MaSP FROM SanPham", comboMaSanPham, "MaSP", "MaSP");
            comboMaSanPham.SelectedIndex = -1;
            
            if(textMaHoaDon.Text != "")
            {
                LoadInfoHoaDon();
            }
            LoadDataGridView();
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayLap FROM HoaDon WHERE MaHD = N'" + textMaHoaDon.Text + "'";
            textNgayLap.Value = DateTime.Parse(Function.GetFieldValues(str));
            str = "SELECT MaKH FROM HoaDon WHERE MaHD = N'" + textMaHoaDon.Text + "'";
            comboMaKhachHang.Text = Function.GetFieldValues(str);
            str = "SELECT TongTien FROM HoaDon WHERE MaHD = N'" + textMaHoaDon.Text + "'";
            textTongTien.Text = Function.GetFieldValues(str);
        }

        private void ResetValues()
        {
            textMaHoaDon.Text = "";
            textNgayLap.Text = DateTime.Now.ToShortDateString();
            comboMaKhachHang.Text = "";
            textTongTien.Text = "0";
            comboMaSanPham.Text = "";
            textSoLuong.Text = "";
            textGiaGiam.Text = "0";
            textThanhTien.Text = "0";
        }

        private void ResetValuesSP()
        {
            
            textSoLuong.Text = "";
            textGiaBan.Text = "0";
            textGiaGiam.Text = "0";
            textThanhTien.Text = "0";
            comboMaSanPham.Text = "0";
            textThanhTien.Text = "0";
        }

        private void ResetValuesKH()
        {
            comboMaKhachHang.Text = "";
            
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void LuuHoaDon_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, Tongmoi;
            sql = "SELECT MaHD FROM HoaDon WHERE MaHD = N'" + textMaHoaDon.Text + "'";
            if (!Function.CheckKey(sql))
            {
               

                if (textNgayLap.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textNgayLap.Focus();
                    return;
                }
                
                if (comboMaKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboMaKhachHang.Focus();
                    return;
                }
                sql = "INSERT INTO HoaDon(MaHD, MaKH, NgayLap, TongTien) VALUES (N'" + textMaHoaDon.Text.Trim() + "','" + comboMaKhachHang.SelectedValue + "','" + Function.CoverDataTime(textNgayLap.Text.Trim()) + "'," + textTongTien.Text + ")";


                Function.RunSQL(sql);
            }
            if (comboMaKhachHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboMaKhachHang.Focus();
                return;
            }
            if ((textSoLuong.Text.Trim().Length == 0) || (textSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoLuong.Text = "";
                textSoLuong.Focus();
                return;
            }
            if (textGiaGiam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textGiaGiam.Focus();
                return;
            }
            sql = "SELECT MaSP FROM CT_HoaDon ct, HoaDon hd WHERE ct.MaSP =N'" + comboMaSanPham.SelectedValue + "' AND ct.MaHD = N'" + textMaHoaDon.Text.Trim() + "' AND ct.MaHD = hd.MaHD AND hd.MAKH = N'" + comboMaKhachHang.SelectedValue + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesSP();
                comboMaSanPham.Focus();
                return;
            }
        
            string sql1 = Convert.ToString(Function.GetFieldValues("Select distinct MaKH From HoaDon where MaHD = N'" + textMaHoaDon.Text.Trim() + "'"));
            string sql2 = Convert.ToString(Function.GetFieldValues("Select MaKH From HoaDon where MaKH = N'" + comboMaKhachHang.SelectedValue + "'"));
            if (sql1 != sql2)
            {
                MessageBox.Show("Mã khách hàng này không tồn tại trong hóa đơn này, bạn hãy chọn mã khách hàng khác hoặc chọn đơn hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesKH();
                comboMaKhachHang.Focus();
                return;
            }

            sl = Convert.ToDouble(Function.GetFieldValues("SELECT SoLuongTon FROM SanPham WHERE MaSP = N'" + comboMaSanPham.SelectedValue + "'"));
            if (Convert.ToDouble(textSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSoLuong.Text = "";
                textSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO CT_HoaDon(MaHD, MaSP,SoLuong, GiaBan, GiaGiam,ThanhTien) VALUES(N'" + textMaHoaDon.Text.Trim() + "',N'" + comboMaSanPham.SelectedValue + "'," + textSoLuong.Text + "," + textGiaBan.Text + "," + textGiaGiam.Text + "," + textThanhTien.Text + ")";
            Function.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của sản phẩm
            SLcon = sl - Convert.ToDouble(textSoLuong.Text);
            sql = "UPDATE SanPham SET SoLuongTon =" + SLcon + " WHERE MaSP= N'" + comboMaSanPham.SelectedValue + "'";
            Function.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            Tongmoi = Convert.ToDouble(Function.GetFieldValues("SELECT TongTien FROM HoaDon WHERE MaHD = N'" + textMaHoaDon.Text + "'"));
            
            sql = "UPDATE HoaDon SET TongTien =" + Tongmoi + " WHERE MaHD = N'" + textMaHoaDon.Text + "'";
            Function.RunSQL(sql);
            textTongTien.Text = Tongmoi.ToString();
            ResetValuesSP();
        }


        private void ThemHoaDon_Click(object sender, EventArgs e)
        {
            LuuHoaDon.Enabled = true;
            ThemHoaDon.Enabled = false;
            ResetValues();
            LoadDataGridView();
        }

        private void comboMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboMaKhachHang.Text == "")
            {
                textTenKhachHang.Text = "";
              
            }
            str = "Select Ten from KhachHang where MaKH = N'" + comboMaKhachHang.SelectedValue + "'";
            textTenKhachHang.Text = Function.GetFieldValues(str);            
        }      

        private void textSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (textSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(textSoLuong.Text);
            if (textGiaGiam.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(textGiaGiam.Text);
            if (textGiaBan.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(textGiaBan.Text);
            tt = sl * dg - sl * gg;
            textThanhTien.Text = tt.ToString();
        }

        private void comboMaSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboMaSanPham.Text == "")
            {
                textTenSanPham.Text = "";
                textGiaBan.Text = "";
                textGiaGiam.Text = "";
            }
            str = "SELECT TenSP FROM SanPham WHERE MaSP =N'" + comboMaSanPham.SelectedValue + "'";
            textTenSanPham.Text = Function.GetFieldValues(str);
            str = "SELECT GiaBan FROM CT_HoaDon WHERE MaSP =N'" + comboMaSanPham.SelectedValue + "'";
            textGiaBan.Text = Function.GetFieldValues(str);
            str = "SELECT GiaGiam FROM CT_HoaDon WHERE MaSP =N'" + comboMaSanPham.SelectedValue + "'";
            textGiaGiam.Text = Function.GetFieldValues(str);
        }       
    }
}
