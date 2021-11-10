
namespace QuanLyBanHang.GUI
{
    partial class frmTaoHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.textNgayLap = new System.Windows.Forms.DateTimePicker();
            this.MaKhachHang = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.Label();
            this.textMaHoaDon = new System.Windows.Forms.TextBox();
            this.MaHoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.LuuHoaDon = new System.Windows.Forms.Button();
            this.ThemHoaDon = new System.Windows.Forms.Button();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.TongTien = new System.Windows.Forms.Label();
            this.gridHoaDon = new System.Windows.Forms.DataGridView();
            this.ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.textSoLuong = new System.Windows.Forms.TextBox();
            this.textThanhTien = new System.Windows.Forms.TextBox();
            this.ThanhTien = new System.Windows.Forms.Label();
            this.textGiaGiam = new System.Windows.Forms.TextBox();
            this.GiaGiam = new System.Windows.Forms.Label();
            this.textGiaBan = new System.Windows.Forms.TextBox();
            this.GiaBan = new System.Windows.Forms.Label();
            this.textTenSanPham = new System.Windows.Forms.TextBox();
            this.TenSanPham = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.Label();
            this.comboMaSanPham = new System.Windows.Forms.ComboBox();
            this.MaSanPham = new System.Windows.Forms.Label();
            this.cTHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).BeginInit();
            this.ChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.splitContainer1.Panel2.Controls.Add(this.Thoat);
            this.splitContainer1.Panel2.Controls.Add(this.LuuHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.ThemHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.textTongTien);
            this.splitContainer1.Panel2.Controls.Add(this.TongTien);
            this.splitContainer1.Panel2.Controls.Add(this.gridHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.ChiTietHoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTenKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboMaKhachHang);
            this.groupBox1.Controls.Add(this.textNgayLap);
            this.groupBox1.Controls.Add(this.MaKhachHang);
            this.groupBox1.Controls.Add(this.NgayLap);
            this.groupBox1.Controls.Add(this.textMaHoaDon);
            this.groupBox1.Controls.Add(this.MaHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(23, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // textTenKhachHang
            // 
            this.textTenKhachHang.Location = new System.Drawing.Point(511, 53);
            this.textTenKhachHang.Name = "textTenKhachHang";
            this.textTenKhachHang.Size = new System.Drawing.Size(161, 22);
            this.textTenKhachHang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(388, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // comboMaKhachHang
            // 
            this.comboMaKhachHang.FormattingEnabled = true;
            this.comboMaKhachHang.Location = new System.Drawing.Point(511, 25);
            this.comboMaKhachHang.Name = "comboMaKhachHang";
            this.comboMaKhachHang.Size = new System.Drawing.Size(161, 24);
            this.comboMaKhachHang.TabIndex = 4;
            this.comboMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboMaKhachHang_SelectedIndexChanged);
            // 
            // textNgayLap
            // 
            this.textNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textNgayLap.Location = new System.Drawing.Point(179, 53);
            this.textNgayLap.Name = "textNgayLap";
            this.textNgayLap.Size = new System.Drawing.Size(161, 22);
            this.textNgayLap.TabIndex = 3;
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.AutoSize = true;
            this.MaKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaKhachHang.Location = new System.Drawing.Point(388, 28);
            this.MaKhachHang.Name = "MaKhachHang";
            this.MaKhachHang.Size = new System.Drawing.Size(105, 17);
            this.MaKhachHang.TabIndex = 0;
            this.MaKhachHang.Text = "Mã khách hàng";
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSize = true;
            this.NgayLap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NgayLap.Location = new System.Drawing.Point(73, 58);
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Size = new System.Drawing.Size(64, 17);
            this.NgayLap.TabIndex = 2;
            this.NgayLap.Text = "Ngày lập";
            // 
            // textMaHoaDon
            // 
            this.textMaHoaDon.Location = new System.Drawing.Point(179, 23);
            this.textMaHoaDon.Name = "textMaHoaDon";
            this.textMaHoaDon.Size = new System.Drawing.Size(161, 22);
            this.textMaHoaDon.TabIndex = 1;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.AutoSize = true;
            this.MaHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaHoaDon.Location = new System.Drawing.Point(73, 28);
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Size = new System.Drawing.Size(83, 17);
            this.MaHoaDon.TabIndex = 0;
            this.MaHoaDon.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thoat.Location = new System.Drawing.Point(630, 273);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(145, 28);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // LuuHoaDon
            // 
            this.LuuHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LuuHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LuuHoaDon.Location = new System.Drawing.Point(631, 239);
            this.LuuHoaDon.Name = "LuuHoaDon";
            this.LuuHoaDon.Size = new System.Drawing.Size(145, 28);
            this.LuuHoaDon.TabIndex = 3;
            this.LuuHoaDon.Text = "Lưu hóa đơn";
            this.LuuHoaDon.UseVisualStyleBackColor = false;
            this.LuuHoaDon.Click += new System.EventHandler(this.LuuHoaDon_Click);
            // 
            // ThemHoaDon
            // 
            this.ThemHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThemHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThemHoaDon.Location = new System.Drawing.Point(630, 205);
            this.ThemHoaDon.Name = "ThemHoaDon";
            this.ThemHoaDon.Size = new System.Drawing.Size(145, 28);
            this.ThemHoaDon.TabIndex = 2;
            this.ThemHoaDon.Text = "Thêm hóa đơn";
            this.ThemHoaDon.UseVisualStyleBackColor = false;
            this.ThemHoaDon.Click += new System.EventHandler(this.ThemHoaDon_Click);
            // 
            // textTongTien
            // 
            this.textTongTien.Location = new System.Drawing.Point(652, 177);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.ReadOnly = true;
            this.textTongTien.Size = new System.Drawing.Size(136, 22);
            this.textTongTien.TabIndex = 1;
            // 
            // TongTien
            // 
            this.TongTien.AutoSize = true;
            this.TongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TongTien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TongTien.Location = new System.Drawing.Point(627, 157);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(68, 17);
            this.TongTien.TabIndex = 0;
            this.TongTien.Text = "Tổng tiền";
            // 
            // gridHoaDon
            // 
            this.gridHoaDon.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.gridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHoaDon.Location = new System.Drawing.Point(23, 141);
            this.gridHoaDon.Name = "gridHoaDon";
            this.gridHoaDon.RowHeadersWidth = 51;
            this.gridHoaDon.RowTemplate.Height = 24;
            this.gridHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHoaDon.Size = new System.Drawing.Size(598, 160);
            this.gridHoaDon.TabIndex = 1;
            // 
            // ChiTietHoaDon
            // 
            this.ChiTietHoaDon.Controls.Add(this.textSoLuong);
            this.ChiTietHoaDon.Controls.Add(this.textThanhTien);
            this.ChiTietHoaDon.Controls.Add(this.ThanhTien);
            this.ChiTietHoaDon.Controls.Add(this.textGiaGiam);
            this.ChiTietHoaDon.Controls.Add(this.GiaGiam);
            this.ChiTietHoaDon.Controls.Add(this.textGiaBan);
            this.ChiTietHoaDon.Controls.Add(this.GiaBan);
            this.ChiTietHoaDon.Controls.Add(this.textTenSanPham);
            this.ChiTietHoaDon.Controls.Add(this.TenSanPham);
            this.ChiTietHoaDon.Controls.Add(this.SoLuong);
            this.ChiTietHoaDon.Controls.Add(this.comboMaSanPham);
            this.ChiTietHoaDon.Controls.Add(this.MaSanPham);
            this.ChiTietHoaDon.Location = new System.Drawing.Point(23, 3);
            this.ChiTietHoaDon.Name = "ChiTietHoaDon";
            this.ChiTietHoaDon.Size = new System.Drawing.Size(752, 132);
            this.ChiTietHoaDon.TabIndex = 0;
            this.ChiTietHoaDon.TabStop = false;
            this.ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // textSoLuong
            // 
            this.textSoLuong.Location = new System.Drawing.Point(179, 66);
            this.textSoLuong.Name = "textSoLuong";
            this.textSoLuong.Size = new System.Drawing.Size(161, 22);
            this.textSoLuong.TabIndex = 13;
            this.textSoLuong.TextChanged += new System.EventHandler(this.textSoLuong_TextChanged);
            // 
            // textThanhTien
            // 
            this.textThanhTien.Location = new System.Drawing.Point(518, 97);
            this.textThanhTien.Name = "textThanhTien";
            this.textThanhTien.ReadOnly = true;
            this.textThanhTien.Size = new System.Drawing.Size(161, 22);
            this.textThanhTien.TabIndex = 12;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSize = true;
            this.ThanhTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ThanhTien.Location = new System.Drawing.Point(421, 102);
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Size = new System.Drawing.Size(76, 17);
            this.ThanhTien.TabIndex = 11;
            this.ThanhTien.Text = "Thành tiền";
            // 
            // textGiaGiam
            // 
            this.textGiaGiam.Location = new System.Drawing.Point(518, 64);
            this.textGiaGiam.Name = "textGiaGiam";
            this.textGiaGiam.ReadOnly = true;
            this.textGiaGiam.Size = new System.Drawing.Size(161, 22);
            this.textGiaGiam.TabIndex = 10;
            // 
            // GiaGiam
            // 
            this.GiaGiam.AutoSize = true;
            this.GiaGiam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GiaGiam.Location = new System.Drawing.Point(421, 69);
            this.GiaGiam.Name = "GiaGiam";
            this.GiaGiam.Size = new System.Drawing.Size(64, 17);
            this.GiaGiam.TabIndex = 9;
            this.GiaGiam.Text = "Giá giảm";
            // 
            // textGiaBan
            // 
            this.textGiaBan.Location = new System.Drawing.Point(518, 30);
            this.textGiaBan.Name = "textGiaBan";
            this.textGiaBan.ReadOnly = true;
            this.textGiaBan.Size = new System.Drawing.Size(161, 22);
            this.textGiaBan.TabIndex = 8;
            // 
            // GiaBan
            // 
            this.GiaBan.AutoSize = true;
            this.GiaBan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GiaBan.Location = new System.Drawing.Point(421, 38);
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Size = new System.Drawing.Size(58, 17);
            this.GiaBan.TabIndex = 7;
            this.GiaBan.Text = "Giá bán";
            // 
            // textTenSanPham
            // 
            this.textTenSanPham.Location = new System.Drawing.Point(179, 97);
            this.textTenSanPham.Name = "textTenSanPham";
            this.textTenSanPham.ReadOnly = true;
            this.textTenSanPham.Size = new System.Drawing.Size(161, 22);
            this.textTenSanPham.TabIndex = 6;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoSize = true;
            this.TenSanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TenSanPham.Location = new System.Drawing.Point(73, 102);
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Size = new System.Drawing.Size(99, 17);
            this.TenSanPham.TabIndex = 5;
            this.TenSanPham.Text = "Tên sản phẩm";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSize = true;
            this.SoLuong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SoLuong.Location = new System.Drawing.Point(73, 69);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(69, 17);
            this.SoLuong.TabIndex = 3;
            this.SoLuong.Text = "Số Lượng";
            // 
            // comboMaSanPham
            // 
            this.comboMaSanPham.FormattingEnabled = true;
            this.comboMaSanPham.Location = new System.Drawing.Point(179, 30);
            this.comboMaSanPham.Name = "comboMaSanPham";
            this.comboMaSanPham.Size = new System.Drawing.Size(161, 24);
            this.comboMaSanPham.TabIndex = 2;
            this.comboMaSanPham.SelectedIndexChanged += new System.EventHandler(this.comboMaSanPham_SelectedIndexChanged);
            // 
            // MaSanPham
            // 
            this.MaSanPham.AutoSize = true;
            this.MaSanPham.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaSanPham.Location = new System.Drawing.Point(73, 30);
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.Size = new System.Drawing.Size(93, 17);
            this.MaSanPham.TabIndex = 0;
            this.MaSanPham.Text = "Mã sản phẩm";
            // 
            // cTHoaDonBindingSource
            // 
            this.cTHoaDonBindingSource.DataMember = "CT_HoaDon";
            // 
            // frmTaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTaoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM MỚI HÓA ĐƠN";
            this.Load += new System.EventHandler(this.TaoHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHoaDon)).EndInit();
            this.ChiTietHoaDon.ResumeLayout(false);
            this.ChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ChiTietHoaDon;
        private System.Windows.Forms.DataGridView gridHoaDon;
        //private Data.SunDataSet sunDataSet;
        private System.Windows.Forms.BindingSource cTHoaDonBindingSource;
        //private Data.SunDataSetTableAdapters.CT_HoaDonTableAdapter cT_HoaDonTableAdapter;
        private System.Windows.Forms.Label MaSanPham;
        private System.Windows.Forms.TextBox textTenSanPham;
        private System.Windows.Forms.Label TenSanPham;
        private System.Windows.Forms.Label SoLuong;
        private System.Windows.Forms.ComboBox comboMaSanPham;
        private System.Windows.Forms.Label GiaGiam;
        private System.Windows.Forms.TextBox textGiaBan;
        private System.Windows.Forms.Label GiaBan;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button LuuHoaDon;
        private System.Windows.Forms.Button ThemHoaDon;
        private System.Windows.Forms.TextBox textTongTien;
        private System.Windows.Forms.Label TongTien;
        private System.Windows.Forms.TextBox textThanhTien;
        private System.Windows.Forms.Label ThanhTien;
        private System.Windows.Forms.TextBox textGiaGiam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboMaKhachHang;
        private System.Windows.Forms.DateTimePicker textNgayLap;
        private System.Windows.Forms.Label MaKhachHang;
        private System.Windows.Forms.Label NgayLap;
        private System.Windows.Forms.TextBox textMaHoaDon;
        private System.Windows.Forms.Label MaHoaDon;
        private System.Windows.Forms.TextBox textTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSoLuong;
    }
}