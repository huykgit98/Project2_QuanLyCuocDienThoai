namespace GUI_WinForm
{
    partial class BillGUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.txtPhiThueBao = new System.Windows.Forms.TextBox();
            this.txtCuocThang = new System.Windows.Forms.TextBox();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.txtNgayCat = new System.Windows.Forms.TextBox();
            this.txtPhutSuDung = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCatSim = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTBDinhChi = new System.Windows.Forms.Button();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phí Thuê Bao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kì Sử Dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cước Tháng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Sim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hạn Thanh Toán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tình Trạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phút Sử Dụng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(130, 13);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(253, 20);
            this.txtMaHD.TabIndex = 8;
            this.txtMaHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNgayLapPhieu
            // 
            this.txtNgayLapPhieu.Location = new System.Drawing.Point(130, 46);
            this.txtNgayLapPhieu.Name = "txtNgayLapPhieu";
            this.txtNgayLapPhieu.Size = new System.Drawing.Size(253, 20);
            this.txtNgayLapPhieu.TabIndex = 9;
            // 
            // txtPhiThueBao
            // 
            this.txtPhiThueBao.Location = new System.Drawing.Point(126, 84);
            this.txtPhiThueBao.Name = "txtPhiThueBao";
            this.txtPhiThueBao.Size = new System.Drawing.Size(253, 20);
            this.txtPhiThueBao.TabIndex = 10;
            // 
            // txtCuocThang
            // 
            this.txtCuocThang.Location = new System.Drawing.Point(126, 127);
            this.txtCuocThang.Name = "txtCuocThang";
            this.txtCuocThang.Size = new System.Drawing.Size(253, 20);
            this.txtCuocThang.TabIndex = 11;
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(487, 10);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.ReadOnly = true;
            this.txtMaSim.Size = new System.Drawing.Size(253, 20);
            this.txtMaSim.TabIndex = 12;
            // 
            // txtNgayCat
            // 
            this.txtNgayCat.Location = new System.Drawing.Point(487, 49);
            this.txtNgayCat.Name = "txtNgayCat";
            this.txtNgayCat.Size = new System.Drawing.Size(253, 20);
            this.txtNgayCat.TabIndex = 13;
            // 
            // txtPhutSuDung
            // 
            this.txtPhutSuDung.Location = new System.Drawing.Point(487, 127);
            this.txtPhutSuDung.Name = "txtPhutSuDung";
            this.txtPhutSuDung.Size = new System.Drawing.Size(253, 20);
            this.txtPhutSuDung.TabIndex = 14;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(487, 84);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(253, 20);
            this.txtTinhTrang.TabIndex = 15;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(740, 8);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(48, 23);
            this.btnXem.TabIndex = 16;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(481, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 23);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm Hóa Đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(145, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCatSim
            // 
            this.btnCatSim.Location = new System.Drawing.Point(303, 16);
            this.btnCatSim.Name = "btnCatSim";
            this.btnCatSim.Size = new System.Drawing.Size(75, 23);
            this.btnCatSim.TabIndex = 21;
            this.btnCatSim.Text = "Cắt";
            this.btnCatSim.UseVisualStyleBackColor = true;
            this.btnCatSim.Click += new System.EventHandler(this.btnCatSim_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(226, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(72, 23);
            this.btnIn.TabIndex = 22;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(713, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 23;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(590, 19);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(117, 20);
            this.txtTim.TabIndex = 24;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(465, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Làm Tươi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTBDinhChi);
            this.groupBox1.Controls.Add(this.dgvDSHD);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.btnCatSim);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(1, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 237);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // btnTBDinhChi
            // 
            this.btnTBDinhChi.Location = new System.Drawing.Point(45, 16);
            this.btnTBDinhChi.Name = "btnTBDinhChi";
            this.btnTBDinhChi.Size = new System.Drawing.Size(94, 23);
            this.btnTBDinhChi.TabIndex = 27;
            this.btnTBDinhChi.Text = "Gửi TB Đình Chỉ";
            this.btnTBDinhChi.UseVisualStyleBackColor = true;
            this.btnTBDinhChi.Click += new System.EventHandler(this.btnTBDinhChi_Click);
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(0, 45);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.Size = new System.Drawing.Size(792, 192);
            this.dgvDSHD.TabIndex = 26;
            this.dgvDSHD.Click += new System.EventHandler(this.dgvDSHD_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(581, 169);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(159, 23);
            this.btnBackHome.TabIndex = 27;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ngày Lập:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(126, 171);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(253, 20);
            this.txtInvoiceDate.TabIndex = 29;
            // 
            // BillGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtPhutSuDung);
            this.Controls.Add(this.txtNgayCat);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.txtCuocThang);
            this.Controls.Add(this.txtPhiThueBao);
            this.Controls.Add(this.txtNgayLapPhieu);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BillGUI";
            this.Text = "Hóa Đơn Tính Cước";
            this.Load += new System.EventHandler(this.BillGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtNgayLapPhieu;
        private System.Windows.Forms.TextBox txtPhiThueBao;
        private System.Windows.Forms.TextBox txtCuocThang;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.TextBox txtNgayCat;
        private System.Windows.Forms.TextBox txtPhutSuDung;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCatSim;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnTBDinhChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInvoiceDate;
    }
}