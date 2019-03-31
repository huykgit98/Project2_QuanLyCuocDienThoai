namespace GUI_WinForm
{
    partial class AddContractGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThemVaDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbtHoatDong = new System.Windows.Forms.RadioButton();
            this.rbtHuy = new System.Windows.Forms.RadioButton();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSim = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnThemVaDong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.rbtHoatDong);
            this.groupBox1.Controls.Add(this.rbtHuy);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtNgayDK);
            this.groupBox1.Controls.Add(this.txtPhi);
            this.groupBox1.Controls.Add(this.txtMaSim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hợp Đồng ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(717, 58);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThemVaDong
            // 
            this.btnThemVaDong.Location = new System.Drawing.Point(619, 58);
            this.btnThemVaDong.Name = "btnThemVaDong";
            this.btnThemVaDong.Size = new System.Drawing.Size(98, 23);
            this.btnThemVaDong.TabIndex = 4;
            this.btnThemVaDong.Text = "Thêm Và Đóng";
            this.btnThemVaDong.UseVisualStyleBackColor = true;
            this.btnThemVaDong.Click += new System.EventHandler(this.btnThemVaDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(538, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbtHoatDong
            // 
            this.rbtHoatDong.AutoSize = true;
            this.rbtHoatDong.Location = new System.Drawing.Point(693, 27);
            this.rbtHoatDong.Name = "rbtHoatDong";
            this.rbtHoatDong.Size = new System.Drawing.Size(74, 17);
            this.rbtHoatDong.TabIndex = 10;
            this.rbtHoatDong.Text = "hoạt động";
            this.rbtHoatDong.UseVisualStyleBackColor = true;
            // 
            // rbtHuy
            // 
            this.rbtHuy.AutoSize = true;
            this.rbtHuy.Checked = true;
            this.rbtHuy.Location = new System.Drawing.Point(602, 29);
            this.rbtHuy.Name = "rbtHuy";
            this.rbtHuy.Size = new System.Drawing.Size(42, 17);
            this.rbtHuy.TabIndex = 9;
            this.rbtHuy.TabStop = true;
            this.rbtHuy.Text = "hủy";
            this.rbtHuy.UseVisualStyleBackColor = true;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(105, 60);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(125, 20);
            this.txtMaKH.TabIndex = 8;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Location = new System.Drawing.Point(374, 24);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(137, 20);
            this.txtNgayDK.TabIndex = 7;
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(374, 61);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(137, 20);
            this.txtPhi.TabIndex = 6;
            this.txtPhi.Text = "50000";
            this.txtPhi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhi_KeyPress);
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(62, 24);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.Size = new System.Drawing.Size(168, 20);
            this.txtMaSim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tình Trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phí (mặc định 50000):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Đăng Ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKH);
            this.groupBox2.Location = new System.Drawing.Point(1, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(0, 20);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(407, 319);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.Click += new System.EventHandler(this.dgvKH_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSim);
            this.groupBox3.Location = new System.Drawing.Point(414, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 339);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sim";
            // 
            // dgvSim
            // 
            this.dgvSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSim.Location = new System.Drawing.Point(0, 20);
            this.dgvSim.Name = "dgvSim";
            this.dgvSim.Size = new System.Drawing.Size(385, 319);
            this.dgvSim.TabIndex = 0;
            this.dgvSim.Click += new System.EventHandler(this.dgvSim_Click);
            // 
            // AddContractGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddContractGUI";
            this.Text = "Thêm Hợp Đồng";
            this.Load += new System.EventHandler(this.AddContractGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.RadioButton rbtHoatDong;
        private System.Windows.Forms.RadioButton rbtHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemVaDong;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridView dgvSim;
        private System.Windows.Forms.Button btnClear;
    }
}