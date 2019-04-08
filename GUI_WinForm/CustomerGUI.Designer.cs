namespace GUI_WinForm
{
    partial class CustomerGUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.btnTimKH = new System.Windows.Forms.Button();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtIDKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSKH);
            this.groupBox2.Location = new System.Drawing.Point(3, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Location = new System.Drawing.Point(0, 19);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.Size = new System.Drawing.Size(693, 234);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellContentClick);
            this.dgvDSKH.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSKH_ColumnHeaderMouseClick);
            this.dgvDSKH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSKH_DataBindingComplete);
            this.dgvDSKH.Click += new System.EventHandler(this.dgvDSKH_Click);
            // 
            // btnTimKH
            // 
            this.btnTimKH.Location = new System.Drawing.Point(612, 176);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(75, 20);
            this.btnTimKH.TabIndex = 43;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.UseVisualStyleBackColor = true;
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(403, 176);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(206, 20);
            this.txtTimKH.TabIndex = 42;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(172, 152);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 41;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(431, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(91, 152);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(10, 152);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(350, 93);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemKH.TabIndex = 36;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(90, 42);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(195, 20);
            this.txtNgheNghiep.TabIndex = 35;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(90, 69);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(195, 20);
            this.txtChucVu.TabIndex = 34;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(350, 15);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(337, 20);
            this.txtTenKH.TabIndex = 33;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(350, 42);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(337, 20);
            this.txtCMND.TabIndex = 32;
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(350, 68);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(337, 20);
            this.txtDiaChi.TabIndex = 30;
            // 
            // txtIDKH
            // 
            this.txtIDKH.Location = new System.Drawing.Point(90, 19);
            this.txtIDKH.Name = "txtIDKH";
            this.txtIDKH.ReadOnly = true;
            this.txtIDKH.Size = new System.Drawing.Size(195, 20);
            this.txtIDKH.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Chức Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nghề Nghiệp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID KH:";
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(253, 152);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(112, 23);
            this.btnBackHome.TabIndex = 44;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // CustomerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNgheNghiep);
            this.Controls.Add(this.txtIDKH);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCMND);
            this.Name = "CustomerGUI";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.CustomerGUI_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.Button btnTimKH;
        private System.Windows.Forms.TextBox txtTimKH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtIDKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHome;
    }
}