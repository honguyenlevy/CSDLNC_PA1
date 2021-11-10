
namespace QuanLyBanHang.GUI
{
    partial class frmXemDSHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridDSHD = new System.Windows.Forms.DataGridView();
            this.Thoat = new System.Windows.Forms.Button();
            this.batDau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // dataGridDSHD
            // 
            this.dataGridDSHD.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDSHD.Location = new System.Drawing.Point(12, 96);
            this.dataGridDSHD.Name = "dataGridDSHD";
            this.dataGridDSHD.RowHeadersWidth = 51;
            this.dataGridDSHD.RowTemplate.Height = 24;
            this.dataGridDSHD.Size = new System.Drawing.Size(776, 355);
            this.dataGridDSHD.TabIndex = 1;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(698, 56);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 34);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // batDau
            // 
            this.batDau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batDau.Location = new System.Drawing.Point(39, 56);
            this.batDau.Name = "batDau";
            this.batDau.Size = new System.Drawing.Size(94, 34);
            this.batDau.TabIndex = 3;
            this.batDau.Text = "Bắt đầu";
            this.batDau.UseVisualStyleBackColor = false;
            this.batDau.Click += new System.EventHandler(this.batDau_click);
            // 
            // frmXemDSHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.batDau);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.dataGridDSHD);
            this.Controls.Add(this.label1);
            this.Name = "frmXemDSHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XEM DANH SÁCH HÓA ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridDSHD;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button batDau;
    }
}