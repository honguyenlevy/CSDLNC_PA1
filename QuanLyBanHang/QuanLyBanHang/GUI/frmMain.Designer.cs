
namespace QuanLyBanHang
{
    partial class MainQL
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
            this.tieu_de = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.Thoat = new System.Windows.Forms.Button();
            this.DoanhThu = new System.Windows.Forms.Button();
            this.DanhSachHoaDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gioi_thieu = new System.Windows.Forms.Panel();
            this.tieu_de.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tieu_de
            // 
            this.tieu_de.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tieu_de.Controls.Add(this.label1);
            this.tieu_de.Dock = System.Windows.Forms.DockStyle.Top;
            this.tieu_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieu_de.Location = new System.Drawing.Point(0, 0);
            this.tieu_de.Name = "tieu_de";
            this.tieu_de.Size = new System.Drawing.Size(800, 100);
            this.tieu_de.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu.Controls.Add(this.Thoat);
            this.menu.Controls.Add(this.DoanhThu);
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.DanhSachHoaDon);
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Location = new System.Drawing.Point(0, 100);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 350);
            this.menu.TabIndex = 1;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thoat.Location = new System.Drawing.Point(300, 254);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(201, 42);
            this.Thoat.TabIndex = 3;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // DoanhThu
            // 
            this.DoanhThu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DoanhThu.Location = new System.Drawing.Point(300, 189);
            this.DoanhThu.Name = "DoanhThu";
            this.DoanhThu.Size = new System.Drawing.Size(201, 42);
            this.DoanhThu.TabIndex = 2;
            this.DoanhThu.Text = "Doanh Thu";
            this.DoanhThu.UseVisualStyleBackColor = false;
            this.DoanhThu.Click += new System.EventHandler(this.DoanhThu_Click);
            // 
            // DanhSachHoaDon
            // 
            this.DanhSachHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DanhSachHoaDon.Location = new System.Drawing.Point(300, 122);
            this.DanhSachHoaDon.Name = "DanhSachHoaDon";
            this.DanhSachHoaDon.Size = new System.Drawing.Size(201, 42);
            this.DanhSachHoaDon.TabIndex = 1;
            this.DanhSachHoaDon.Text = "Danh sách Hóa Đơn";
            this.DanhSachHoaDon.UseVisualStyleBackColor = false;
            this.DanhSachHoaDon.Click += new System.EventHandler(this.DanhSachHoaDon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(300, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo Hóa Đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.TaoHoaDon_Click);
            // 
            // gioi_thieu
            // 
            this.gioi_thieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gioi_thieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioi_thieu.Location = new System.Drawing.Point(0, 100);
            this.gioi_thieu.Name = "gioi_thieu";
            this.gioi_thieu.Size = new System.Drawing.Size(800, 0);
            this.gioi_thieu.TabIndex = 0;
            // 
            // MainQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gioi_thieu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tieu_de);
            this.Name = "MainQL";
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.MainQL_Load);
            this.tieu_de.ResumeLayout(false);
            this.tieu_de.PerformLayout();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tieu_de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel gioi_thieu;
        private System.Windows.Forms.Button DanhSachHoaDon;
        private System.Windows.Forms.Button DoanhThu;
        private System.Windows.Forms.Button Thoat;
    }
}

