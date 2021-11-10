
namespace QuanLyBanHang.GUI
{
    partial class frmTKDoanhThu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textNam = new System.Windows.Forms.TextBox();
            this.Thong_ke = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.namThongKe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.textNam);
            this.splitContainer1.Panel1.Controls.Add(this.Thong_ke);
            this.splitContainer1.Panel1.Controls.Add(this.Thoat);
            this.splitContainer1.Panel1.Controls.Add(this.namThongKe);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridDoanhThu);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // textNam
            // 
            this.textNam.Location = new System.Drawing.Point(201, 71);
            this.textNam.Name = "textNam";
            this.textNam.Size = new System.Drawing.Size(116, 22);
            this.textNam.TabIndex = 7;
            // 
            // Thong_ke
            // 
            this.Thong_ke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thong_ke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Thong_ke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thong_ke.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thong_ke.Location = new System.Drawing.Point(489, 65);
            this.Thong_ke.Name = "Thong_ke";
            this.Thong_ke.Size = new System.Drawing.Size(117, 28);
            this.Thong_ke.TabIndex = 6;
            this.Thong_ke.Text = "Thống kê";
            this.Thong_ke.UseVisualStyleBackColor = false;
            this.Thong_ke.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Thoat.Location = new System.Drawing.Point(667, 65);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(77, 28);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // namThongKe
            // 
            this.namThongKe.AutoSize = true;
            this.namThongKe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.namThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namThongKe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.namThongKe.Location = new System.Drawing.Point(72, 76);
            this.namThongKe.Name = "namThongKe";
            this.namThongKe.Size = new System.Drawing.Size(100, 17);
            this.namThongKe.TabIndex = 1;
            this.namThongKe.Text = "Năm thống kê ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU THEO THÁNG";
            // 
            // dataGridDoanhThu
            // 
            this.dataGridDoanhThu.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dataGridDoanhThu.Name = "dataGridDoanhThu";
            this.dataGridDoanhThu.RowHeadersWidth = 51;
            this.dataGridDoanhThu.RowTemplate.Height = 24;
            this.dataGridDoanhThu.Size = new System.Drawing.Size(799, 329);
            this.dataGridDoanhThu.TabIndex = 0;
            // 
            // frmTKDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTKDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DOANH THU";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namThongKe;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.DataGridView dataGridDoanhThu;
        private System.Windows.Forms.Button Thong_ke;
        private System.Windows.Forms.TextBox textNam;
    }
}