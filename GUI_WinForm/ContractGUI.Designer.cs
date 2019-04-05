namespace GUI_WinForm
{
    partial class ContractGUI
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
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.txtNgayDangKy = new System.Windows.Forms.TextBox();
            this.txtPhiDK = new System.Windows.Forms.TextBox();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.rdbHuy = new System.Windows.Forms.RadioButton();
            this.rbtHoatDong = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hợp Đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phí Đăng Ký:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tình Trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Đăng Ký:";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Location = new System.Drawing.Point(97, 13);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(175, 20);
            this.txtMaHopDong.TabIndex = 5;
            // 
            // txtNgayDangKy
            // 
            this.txtNgayDangKy.Location = new System.Drawing.Point(607, 10);
            this.txtNgayDangKy.Name = "txtNgayDangKy";
            this.txtNgayDangKy.Size = new System.Drawing.Size(175, 20);
            this.txtNgayDangKy.TabIndex = 6;
            // 
            // txtPhiDK
            // 
            this.txtPhiDK.Location = new System.Drawing.Point(97, 45);
            this.txtPhiDK.Name = "txtPhiDK";
            this.txtPhiDK.Size = new System.Drawing.Size(175, 20);
            this.txtPhiDK.TabIndex = 7;
            this.txtPhiDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhiDK_KeyPress);
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(319, 12);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.Size = new System.Drawing.Size(128, 20);
            this.txtMaSim.TabIndex = 8;
            this.txtMaSim.Text = " ";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(453, 11);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(62, 23);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // rdbHuy
            // 
            this.rdbHuy.AutoSize = true;
            this.rdbHuy.Checked = true;
            this.rdbHuy.Location = new System.Drawing.Point(346, 46);
            this.rdbHuy.Name = "rdbHuy";
            this.rdbHuy.Size = new System.Drawing.Size(42, 17);
            this.rdbHuy.TabIndex = 10;
            this.rdbHuy.TabStop = true;
            this.rdbHuy.Text = "hủy";
            this.rdbHuy.UseVisualStyleBackColor = true;
            // 
            // rbtHoatDong
            // 
            this.rbtHoatDong.AutoSize = true;
            this.rbtHoatDong.Location = new System.Drawing.Point(401, 46);
            this.rbtHoatDong.Name = "rbtHoatDong";
            this.rbtHoatDong.Size = new System.Drawing.Size(74, 17);
            this.rbtHoatDong.TabIndex = 11;
            this.rbtHoatDong.Text = "hoạt động";
            this.rbtHoatDong.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHD);
            this.groupBox1.Location = new System.Drawing.Point(0, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 315);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hợp Đồng";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Location = new System.Drawing.Point(0, 19);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(802, 295);
            this.dgvDSHD.TabIndex = 0;
            this.dgvDSHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellContentClick);
            this.dgvDSHD.Click += new System.EventHandler(this.dgvDSHD_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(525, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm Hợp Đồng";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(707, 94);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(626, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(97, 94);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(259, 94);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Làm Tươi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(16, 94);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(526, 94);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(175, 20);
            this.txtTim.TabIndex = 20;
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(340, 94);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(129, 23);
            this.btnBackHome.TabIndex = 21;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(178, 94);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnInHoaDon.TabIndex = 22;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // ContractGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtHoatDong);
            this.Controls.Add(this.rdbHuy);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.txtPhiDK);
            this.Controls.Add(this.txtNgayDangKy);
            this.Controls.Add(this.txtMaHopDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContractGUI";
            this.Text = "Hợp Đồng";
            this.Load += new System.EventHandler(this.ContractGUI_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.TextBox txtNgayDangKy;
        private System.Windows.Forms.TextBox txtPhiDK;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.RadioButton rdbHuy;
        private System.Windows.Forms.RadioButton rbtHoatDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}