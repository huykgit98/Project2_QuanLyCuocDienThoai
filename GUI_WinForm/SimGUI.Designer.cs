namespace GUI_WinForm
{
    partial class SimGUI
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
            this.dgvDSSim = new System.Windows.Forms.DataGridView();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtTimSim = new System.Windows.Forms.TextBox();
            this.btnSuaSim = new System.Windows.Forms.Button();
            this.btnXoaSim = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimSim = new System.Windows.Forms.Button();
            this.btnThemSim = new System.Windows.Forms.Button();
            this.btnXemMaKH = new System.Windows.Forms.Button();
            this.rdbDaSD = new System.Windows.Forms.RadioButton();
            this.rdbChuaSD = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSim);
            this.groupBox2.Location = new System.Drawing.Point(13, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách SIM";
            // 
            // dgvDSSim
            // 
            this.dgvDSSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSim.Location = new System.Drawing.Point(3, 16);
            this.dgvDSSim.Name = "dgvDSSim";
            this.dgvDSSim.RowHeadersWidth = 50;
            this.dgvDSSim.Size = new System.Drawing.Size(453, 282);
            this.dgvDSSim.TabIndex = 0;
            this.dgvDSSim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSim_CellContentClick);
            this.dgvDSSim.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSSim_CellFormatting);
            this.dgvDSSim.Click += new System.EventHandler(this.dgvDSSim_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(340, 75);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 46;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtTimSim
            // 
            this.txtTimSim.Location = new System.Drawing.Point(229, 122);
            this.txtTimSim.Name = "txtTimSim";
            this.txtTimSim.Size = new System.Drawing.Size(186, 20);
            this.txtTimSim.TabIndex = 45;
            // 
            // btnSuaSim
            // 
            this.btnSuaSim.Location = new System.Drawing.Point(99, 75);
            this.btnSuaSim.Name = "btnSuaSim";
            this.btnSuaSim.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSim.TabIndex = 44;
            this.btnSuaSim.Text = "Sửa";
            this.btnSuaSim.UseVisualStyleBackColor = true;
            this.btnSuaSim.Click += new System.EventHandler(this.btnSuaSim_Click);
            // 
            // btnXoaSim
            // 
            this.btnXoaSim.Location = new System.Drawing.Point(178, 75);
            this.btnXoaSim.Name = "btnXoaSim";
            this.btnXoaSim.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSim.TabIndex = 43;
            this.btnXoaSim.Text = "Xóa";
            this.btnXoaSim.UseVisualStyleBackColor = true;
            this.btnXoaSim.Click += new System.EventHandler(this.btnXoaSim_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(259, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.Text = "Làm Tươi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimSim
            // 
            this.btnTimSim.Location = new System.Drawing.Point(421, 122);
            this.btnTimSim.Name = "btnTimSim";
            this.btnTimSim.Size = new System.Drawing.Size(33, 20);
            this.btnTimSim.TabIndex = 40;
            this.btnTimSim.Text = "Tìm";
            this.btnTimSim.UseVisualStyleBackColor = true;
            this.btnTimSim.Click += new System.EventHandler(this.btnTimSim_Click);
            // 
            // btnThemSim
            // 
            this.btnThemSim.Location = new System.Drawing.Point(18, 75);
            this.btnThemSim.Name = "btnThemSim";
            this.btnThemSim.Size = new System.Drawing.Size(75, 23);
            this.btnThemSim.TabIndex = 39;
            this.btnThemSim.Text = "Thêm";
            this.btnThemSim.UseVisualStyleBackColor = true;
            this.btnThemSim.Click += new System.EventHandler(this.btnThemSim_Click);
            // 
            // btnXemMaKH
            // 
            this.btnXemMaKH.Location = new System.Drawing.Point(399, 12);
            this.btnXemMaKH.Name = "btnXemMaKH";
            this.btnXemMaKH.Size = new System.Drawing.Size(57, 20);
            this.btnXemMaKH.TabIndex = 38;
            this.btnXemMaKH.Text = "Xem";
            this.btnXemMaKH.UseVisualStyleBackColor = true;
            this.btnXemMaKH.Click += new System.EventHandler(this.btnXemMaKH_Click);
            // 
            // rdbDaSD
            // 
            this.rdbDaSD.AutoSize = true;
            this.rdbDaSD.Location = new System.Drawing.Point(392, 42);
            this.rdbDaSD.Name = "rdbDaSD";
            this.rdbDaSD.Size = new System.Drawing.Size(80, 17);
            this.rdbDaSD.TabIndex = 37;
            this.rdbDaSD.Text = "Đã sử dụng";
            this.rdbDaSD.UseVisualStyleBackColor = true;
            // 
            // rdbChuaSD
            // 
            this.rdbChuaSD.AutoSize = true;
            this.rdbChuaSD.Checked = true;
            this.rdbChuaSD.Location = new System.Drawing.Point(248, 42);
            this.rdbChuaSD.Name = "rdbChuaSD";
            this.rdbChuaSD.Size = new System.Drawing.Size(138, 17);
            this.rdbChuaSD.TabIndex = 36;
            this.rdbChuaSD.TabStop = true;
            this.rdbChuaSD.Text = "Chưa sử dụng / Bị khóa";
            this.rdbChuaSD.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(67, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(107, 20);
            this.txtSDT.TabIndex = 35;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(274, 12);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(119, 20);
            this.txtMaKH.TabIndex = 34;
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(67, 12);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.ReadOnly = true;
            this.txtMaSim.Size = new System.Drawing.Size(107, 20);
            this.txtMaSim.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tình Trạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Sim:";
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(99, 120);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(114, 23);
            this.btnBackHome.TabIndex = 47;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // SimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTimSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSuaSim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXoaSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimSim);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.btnThemSim);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.btnXemMaKH);
            this.Controls.Add(this.rdbChuaSD);
            this.Controls.Add(this.rdbDaSD);
            this.Name = "SimGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý SIM";
            this.Load += new System.EventHandler(this.SimGUI_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSim;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtTimSim;
        private System.Windows.Forms.Button btnSuaSim;
        private System.Windows.Forms.Button btnXoaSim;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTimSim;
        private System.Windows.Forms.Button btnThemSim;
        private System.Windows.Forms.Button btnXemMaKH;
        private System.Windows.Forms.RadioButton rdbDaSD;
        private System.Windows.Forms.RadioButton rdbChuaSD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackHome;
    }
}