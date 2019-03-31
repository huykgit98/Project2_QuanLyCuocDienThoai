namespace GUI_WinForm
{
    partial class AddDetailGUI
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
            this.dgvDL = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnImportDL = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThemvaDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDL
            // 
            this.dgvDL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDL.Location = new System.Drawing.Point(1, 72);
            this.dgvDL.Name = "dgvDL";
            this.dgvDL.Size = new System.Drawing.Size(537, 306);
            this.dgvDL.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(13, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnImportDL
            // 
            this.btnImportDL.Location = new System.Drawing.Point(205, 13);
            this.btnImportDL.Name = "btnImportDL";
            this.btnImportDL.Size = new System.Drawing.Size(114, 23);
            this.btnImportDL.TabIndex = 2;
            this.btnImportDL.Text = "Import Dữ Liệu";
            this.btnImportDL.UseVisualStyleBackColor = true;
            this.btnImportDL.Click += new System.EventHandler(this.btnImportDL_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(325, 12);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(75, 23);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThemvaDong
            // 
            this.btnThemvaDong.Location = new System.Drawing.Point(94, 13);
            this.btnThemvaDong.Name = "btnThemvaDong";
            this.btnThemvaDong.Size = new System.Drawing.Size(88, 23);
            this.btnThemvaDong.TabIndex = 4;
            this.btnThemvaDong.Text = "Thêm và Đóng";
            this.btnThemvaDong.UseVisualStyleBackColor = true;
            this.btnThemvaDong.Click += new System.EventHandler(this.btnThemvaDong_Click);
            // 
            // AddDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 379);
            this.Controls.Add(this.btnThemvaDong);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnImportDL);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDL);
            this.Name = "AddDetailGUI";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.AddDetailGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnImportDL;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThemvaDong;
    }
}