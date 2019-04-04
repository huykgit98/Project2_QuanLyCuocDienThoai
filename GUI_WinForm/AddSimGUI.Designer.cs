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
            this.rdbSuDung = new System.Windows.Forms.RadioButton();
            this.rdbChuaSD = new System.Windows.Forms.RadioButton();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemvaDong = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSuDung);
            this.groupBox1.Controls.Add(this.rdbChuaSD);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnThemvaDong);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sim";
            // 
            // rdbSuDung
            // 
            this.rdbSuDung.AutoSize = true;
            this.rdbSuDung.Location = new System.Drawing.Point(194, 71);
            this.rdbSuDung.Name = "rdbSuDung";
            this.rdbSuDung.Size = new System.Drawing.Size(63, 17);
            this.rdbSuDung.TabIndex = 11;
            this.rdbSuDung.Text = "sử dụng";
            this.rdbSuDung.UseVisualStyleBackColor = true;
            // 
            // rdbChuaSD
            // 
            this.rdbChuaSD.AutoSize = true;
            this.rdbChuaSD.Checked = true;
            this.rdbChuaSD.Location = new System.Drawing.Point(74, 71);
            this.rdbChuaSD.Name = "rdbChuaSD";
            this.rdbChuaSD.Size = new System.Drawing.Size(90, 17);
            this.rdbChuaSD.TabIndex = 10;
            this.rdbChuaSD.TabStop = true;
            this.rdbChuaSD.Text = "chưa sử dụng";
            this.rdbChuaSD.UseVisualStyleBackColor = true;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(74, 32);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(216, 20);
            this.txtSDTKH.TabIndex = 9;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tình Trạng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SĐT:";
            // 
            // btnThemvaDong
            // 
            this.btnThemvaDong.Location = new System.Drawing.Point(86, 131);
            this.btnThemvaDong.Name = "btnThemvaDong";
            this.btnThemvaDong.Size = new System.Drawing.Size(91, 23);
            this.btnThemvaDong.TabIndex = 4;
            this.btnThemvaDong.Text = "Thêm Và Đóng";
            this.btnThemvaDong.UseVisualStyleBackColor = true;
            this.btnThemvaDong.Click += new System.EventHandler(this.btnThemvaDong_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(183, 131);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 131);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AddSimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 163);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSimGUI";
            this.Text = "Thêm";
            this.Load += new System.EventHandler(this.AddSimGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemvaDong;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbSuDung;
        private System.Windows.Forms.RadioButton rdbChuaSD;
        private System.Windows.Forms.TextBox txtSDTKH;
    }
}