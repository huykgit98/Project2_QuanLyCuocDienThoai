namespace GUI_WinForm
{
    partial class DetailsSimGUI
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
            this.txtMaSim = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.rbtChuaSD = new System.Windows.Forms.RadioButton();
            this.rbtDaSD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình Trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT:";
            // 
            // txtMaSim
            // 
            this.txtMaSim.Location = new System.Drawing.Point(74, 29);
            this.txtMaSim.Name = "txtMaSim";
            this.txtMaSim.ReadOnly = true;
            this.txtMaSim.Size = new System.Drawing.Size(173, 20);
            this.txtMaSim.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(74, 80);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(173, 20);
            this.txtSDT.TabIndex = 6;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(316, 26);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(173, 20);
            this.txtMaKH.TabIndex = 7;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(496, 25);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(53, 23);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // rbtChuaSD
            // 
            this.rbtChuaSD.AutoSize = true;
            this.rbtChuaSD.Checked = true;
            this.rbtChuaSD.Enabled = false;
            this.rbtChuaSD.Location = new System.Drawing.Point(316, 81);
            this.rbtChuaSD.Name = "rbtChuaSD";
            this.rbtChuaSD.Size = new System.Drawing.Size(91, 17);
            this.rbtChuaSD.TabIndex = 9;
            this.rbtChuaSD.TabStop = true;
            this.rbtChuaSD.Text = "Chưa sử dụng";
            this.rbtChuaSD.UseVisualStyleBackColor = true;
            // 
            // rbtDaSD
            // 
            this.rbtDaSD.AutoSize = true;
            this.rbtDaSD.Enabled = false;
            this.rbtDaSD.Location = new System.Drawing.Point(422, 81);
            this.rbtDaSD.Name = "rbtDaSD";
            this.rbtDaSD.Size = new System.Drawing.Size(80, 17);
            this.rbtDaSD.TabIndex = 10;
            this.rbtDaSD.TabStop = true;
            this.rbtDaSD.Text = "Đã sử dụng";
            this.rbtDaSD.UseVisualStyleBackColor = true;
            // 
            // DetailsSimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 126);
            this.Controls.Add(this.rbtDaSD);
            this.Controls.Add(this.rbtChuaSD);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtMaSim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsSimGUI";
            this.Text = "Chi Tiết Sim";
            this.Load += new System.EventHandler(this.DetailsSimGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSim;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.RadioButton rbtChuaSD;
        private System.Windows.Forms.RadioButton rbtDaSD;
    }
}