namespace GUI_WinForm
{
    partial class DetailGUI
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
            this.dgvCTSD = new System.Windows.Forms.DataGridView();
            this.btnImportData = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnBackHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTSD
            // 
            this.dgvCTSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSD.Location = new System.Drawing.Point(3, 69);
            this.dgvCTSD.Name = "dgvCTSD";
            this.dgvCTSD.Size = new System.Drawing.Size(764, 378);
            this.dgvCTSD.TabIndex = 0;
            this.dgvCTSD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvCTSD.Click += new System.EventHandler(this.dgvCTSD_Click);
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(34, 4);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(95, 23);
            this.btnImportData.TabIndex = 1;
            this.btnImportData.Text = "Import Dữ Liệu";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(702, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(65, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(149, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(422, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(274, 20);
            this.txtTim.TabIndex = 5;
            // 
            // btnBackHome
            // 
            this.btnBackHome.Location = new System.Drawing.Point(245, 4);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(145, 23);
            this.btnBackHome.TabIndex = 6;
            this.btnBackHome.Text = "Về Màn Hình Chính";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // DetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.dgvCTSD);
            this.Name = "DetailGUI";
            this.Text = "Chi Tiết Sử Dụng";
            this.Load += new System.EventHandler(this.DetailGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTSD;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnBackHome;
    }
}