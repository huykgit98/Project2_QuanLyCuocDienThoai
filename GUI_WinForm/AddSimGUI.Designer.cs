namespace GUI_WinForm
{
    partial class AddSimGUI
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThemvaDong = new System.Windows.Forms.Button();
            this.Mã = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.rdbChuaSD = new System.Windows.Forms.RadioButton();
            this.rdbSuDung = new System.Windows.Forms.RadioButton();
            this.btnRong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRong);
            this.groupBox1.Controls.Add(this.rdbSuDung);
            this.groupBox1.Controls.Add(this.rdbChuaSD);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Mã);
            this.groupBox1.Controls.Add(this.btnThemvaDong);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sim";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 171);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(178, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThemvaDong
            // 
            this.btnThemvaDong.Location = new System.Drawing.Point(81, 171);
            this.btnThemvaDong.Name = "btnThemvaDong";
            this.btnThemvaDong.Size = new System.Drawing.Size(91, 23);
            this.btnThemvaDong.TabIndex = 4;
            this.btnThemvaDong.Text = "Thêm Và Đóng";
            this.btnThemvaDong.UseVisualStyleBackColor = true;
            this.btnThemvaDong.Click += new System.EventHandler(this.btnThemvaDong_Click);
            // 
            // Mã
            // 
            this.Mã.AutoSize = true;
            this.Mã.Location = new System.Drawing.Point(7, 32);
            this.Mã.Name = "Mã";
            this.Mã.Size = new System.Drawing.Size(43, 13);
            this.Mã.TabIndex = 5;
            this.Mã.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tình Trạng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(69, 29);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(216, 20);
            this.txtMaKH.TabIndex = 8;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(69, 72);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(216, 20);
            this.txtSDTKH.TabIndex = 9;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // rdbChuaSD
            // 
            this.rdbChuaSD.AutoSize = true;
            this.rdbChuaSD.Checked = true;
            this.rdbChuaSD.Location = new System.Drawing.Point(69, 111);
            this.rdbChuaSD.Name = "rdbChuaSD";
            this.rdbChuaSD.Size = new System.Drawing.Size(90, 17);
            this.rdbChuaSD.TabIndex = 10;
            this.rdbChuaSD.TabStop = true;
            this.rdbChuaSD.Text = "chưa sử dụng";
            this.rdbChuaSD.UseVisualStyleBackColor = true;
            // 
            // rdbSuDung
            // 
            this.rdbSuDung.AutoSize = true;
            this.rdbSuDung.Location = new System.Drawing.Point(189, 111);
            this.rdbSuDung.Name = "rdbSuDung";
            this.rdbSuDung.Size = new System.Drawing.Size(63, 17);
            this.rdbSuDung.TabIndex = 11;
            this.rdbSuDung.Text = "sử dụng";
            this.rdbSuDung.UseVisualStyleBackColor = true;
            // 
            // btnRong
            // 
            this.btnRong.Location = new System.Drawing.Point(284, 27);
            this.btnRong.Name = "btnRong";
            this.btnRong.Size = new System.Drawing.Size(44, 23);
            this.btnRong.TabIndex = 12;
            this.btnRong.Text = "Rỗng";
            this.btnRong.UseVisualStyleBackColor = true;
            this.btnRong.Click += new System.EventHandler(this.btnRong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSKH);
            this.groupBox2.Location = new System.Drawing.Point(335, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Location = new System.Drawing.Point(0, 19);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.Size = new System.Drawing.Size(337, 188);
            this.dgvDSKH.TabIndex = 0;
            this.dgvDSKH.Click += new System.EventHandler(this.dgvDSKH_Click);
            // 
            // AddSimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 207);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSimGUI";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.AddSimGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemvaDong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mã;
        private System.Windows.Forms.RadioButton rdbSuDung;
        private System.Windows.Forms.RadioButton rdbChuaSD;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnRong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSKH;
    }
}