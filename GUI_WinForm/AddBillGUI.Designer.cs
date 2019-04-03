namespace GUI_WinForm
{
    partial class AddBillGUI
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.txtPhiThueBao = new System.Windows.Forms.TextBox();
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.btnThemVaDong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAddBill = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtNgayLapPhieu);
            this.groupBox1.Controls.Add(this.txtPhiThueBao);
            this.groupBox1.Controls.Add(this.txtMaSim);
            this.groupBox1.Controls.Add(this.btnThemVaDong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(238, 206);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNgayLapPhieu
            // 
            this.txtNgayLapPhieu.Location = new System.Drawing.Point(104, 82);
            this.txtNgayLapPhieu.Name = "txtNgayLapPhieu";
            this.txtNgayLapPhieu.Size = new System.Drawing.Size(245, 20);
            this.txtNgayLapPhieu.TabIndex = 7;
            // 
            // txtPhiThueBao
            // 
            this.txtPhiThueBao.Location = new System.Drawing.Point(104, 142);
            this.txtPhiThueBao.Name = "txtPhiThueBao";
            this.txtPhiThueBao.Size = new System.Drawing.Size(245, 20);
            this.txtPhiThueBao.TabIndex = 6;
            this.txtPhiThueBao.Text = "50000";
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(103, 30);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.Size = new System.Drawing.Size(210, 20);
            this.txtMaSim.TabIndex = 5;
            // 
            // btnThemVaDong
            // 
            this.btnThemVaDong.Location = new System.Drawing.Point(117, 206);
            this.btnThemVaDong.Name = "btnThemVaDong";
            this.btnThemVaDong.Size = new System.Drawing.Size(94, 23);
            this.btnThemVaDong.TabIndex = 4;
            this.btnThemVaDong.Text = "Thêm và Đóng";
            this.btnThemVaDong.UseVisualStyleBackColor = true;
            this.btnThemVaDong.Click += new System.EventHandler(this.btnThemVaDong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Tính Cước:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phí Thuê Bao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAddBill);
            this.groupBox2.Location = new System.Drawing.Point(375, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách";
            // 
            // dgvAddBill
            // 
            this.dgvAddBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddBill.Location = new System.Drawing.Point(1, 20);
            this.dgvAddBill.Name = "dgvAddBill";
            this.dgvAddBill.Size = new System.Drawing.Size(423, 234);
            this.dgvAddBill.TabIndex = 0;
            this.dgvAddBill.Click += new System.EventHandler(this.dgvAddBill_Click);
            // 
            // AddBillGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBillGUI";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.AddBillGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAddBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemVaDong;
        private System.Windows.Forms.TextBox txtNgayLapPhieu;
        private System.Windows.Forms.TextBox txtPhiThueBao;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.Button btnRefresh;
    }
}