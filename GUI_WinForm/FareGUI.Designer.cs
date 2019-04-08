namespace GUI_WinForm
{
    partial class FareGUI
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
            this.btnBackHome = new System.Windows.Forms.Button();
            this.txtRefresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTGKT = new System.Windows.Forms.TextBox();
            this.txtCuocPhi = new System.Windows.Forms.TextBox();
            this.txtTGBD = new System.Windows.Forms.TextBox();
            this.txtIDKhoangGio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSCP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackHome);
            this.groupBox1.Controls.Add(this.txtRefresh);
            this.groupBox1.Controls.Add(this.txtTGKT);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtCuocPhi);
            this.groupBox1.Controls.Add(this.txtTGBD);
            this.groupBox1.Controls.Add(this.txtIDKhoangGio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cước Phí";
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(12, 118);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(116, 23);
            this.btnBackHome.TabIndex = 13;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.Location = new System.Drawing.Point(230, 118);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(75, 23);
            this.txtRefresh.TabIndex = 12;
            this.txtRefresh.Text = "Làm Tươi";
            this.txtRefresh.UseVisualStyleBackColor = true;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(149, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTGKT
            // 
            this.txtTGKT.Location = new System.Drawing.Point(118, 62);
            this.txtTGKT.Name = "txtTGKT";
            this.txtTGKT.Size = new System.Drawing.Size(314, 20);
            this.txtTGKT.TabIndex = 8;
            // 
            // txtCuocPhi
            // 
            this.txtCuocPhi.Location = new System.Drawing.Point(118, 88);
            this.txtCuocPhi.Name = "txtCuocPhi";
            this.txtCuocPhi.Size = new System.Drawing.Size(314, 20);
            this.txtCuocPhi.TabIndex = 7;
            // 
            // txtTGBD
            // 
            this.txtTGBD.Location = new System.Drawing.Point(118, 40);
            this.txtTGBD.Name = "txtTGBD";
            this.txtTGBD.Size = new System.Drawing.Size(314, 20);
            this.txtTGBD.TabIndex = 6;
            // 
            // txtIDKhoangGio
            // 
            this.txtIDKhoangGio.Location = new System.Drawing.Point(118, 17);
            this.txtIDKhoangGio.Name = "txtIDKhoangGio";
            this.txtIDKhoangGio.Size = new System.Drawing.Size(314, 20);
            this.txtIDKhoangGio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời Gian Bắt Đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cước Phí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời Gian Kết Thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Khoảng Giờ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSCP);
            this.groupBox2.Location = new System.Drawing.Point(1, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Cước Phí";
            // 
            // dgvDSCP
            // 
            this.dgvDSCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCP.Location = new System.Drawing.Point(6, 19);
            this.dgvDSCP.Name = "dgvDSCP";
            this.dgvDSCP.Size = new System.Drawing.Size(431, 96);
            this.dgvDSCP.TabIndex = 0;
            this.dgvDSCP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCP_CellContentClick);
            this.dgvDSCP.Click += new System.EventHandler(this.dgvDSCP_Click);
            // 
            // FareGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 299);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FareGUI";
            this.Text = "Quản Lý Cước Phí Theo Khoảng Thời Gian";
            this.Load += new System.EventHandler(this.FareGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDKhoangGio;
        private System.Windows.Forms.TextBox txtCuocPhi;
        private System.Windows.Forms.TextBox txtTGBD;
        private System.Windows.Forms.TextBox txtTGKT;
        private System.Windows.Forms.Button txtRefresh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvDSCP;
        private System.Windows.Forms.Button btnBackHome;
    }
}