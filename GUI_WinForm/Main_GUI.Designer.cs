namespace GUI_WinForm
{
    partial class Main_GUI
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
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLCTSD = new System.Windows.Forms.Button();
            this.btnQLHoaDon = new System.Windows.Forms.Button();
            this.btnQLHopDong = new System.Windows.Forms.Button();
            this.btnQLSim = new System.Windows.Forms.Button();
            this.btnPhatSinhLog = new System.Windows.Forms.Button();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btnQLFare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLKH
            // 
            this.btnQLKH.Location = new System.Drawing.Point(29, 32);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(114, 158);
            this.btnQLKH.TabIndex = 0;
            this.btnQLKH.Text = "Khách Hàng";
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLCTSD
            // 
            this.btnQLCTSD.Location = new System.Drawing.Point(489, 32);
            this.btnQLCTSD.Name = "btnQLCTSD";
            this.btnQLCTSD.Size = new System.Drawing.Size(103, 158);
            this.btnQLCTSD.TabIndex = 1;
            this.btnQLCTSD.Text = "Chi Tiết Sử Dụng";
            this.btnQLCTSD.UseVisualStyleBackColor = true;
            this.btnQLCTSD.Click += new System.EventHandler(this.btnQLCTSD_Click);
            // 
            // btnQLHoaDon
            // 
            this.btnQLHoaDon.Location = new System.Drawing.Point(379, 32);
            this.btnQLHoaDon.Name = "btnQLHoaDon";
            this.btnQLHoaDon.Size = new System.Drawing.Size(104, 158);
            this.btnQLHoaDon.TabIndex = 2;
            this.btnQLHoaDon.Text = "Hóa Đơn";
            this.btnQLHoaDon.UseVisualStyleBackColor = true;
            this.btnQLHoaDon.Click += new System.EventHandler(this.btnQLHoaDon_Click);
            // 
            // btnQLHopDong
            // 
            this.btnQLHopDong.Location = new System.Drawing.Point(268, 32);
            this.btnQLHopDong.Name = "btnQLHopDong";
            this.btnQLHopDong.Size = new System.Drawing.Size(105, 158);
            this.btnQLHopDong.TabIndex = 3;
            this.btnQLHopDong.Text = "Hợp Đồng";
            this.btnQLHopDong.UseVisualStyleBackColor = true;
            this.btnQLHopDong.Click += new System.EventHandler(this.btnQLHopDong_Click);
            // 
            // btnQLSim
            // 
            this.btnQLSim.Location = new System.Drawing.Point(149, 32);
            this.btnQLSim.Name = "btnQLSim";
            this.btnQLSim.Size = new System.Drawing.Size(113, 158);
            this.btnQLSim.TabIndex = 4;
            this.btnQLSim.Text = "SIM";
            this.btnQLSim.UseVisualStyleBackColor = true;
            this.btnQLSim.Click += new System.EventHandler(this.btnQLSim_Click);
            // 
            // btnPhatSinhLog
            // 
            this.btnPhatSinhLog.Location = new System.Drawing.Point(331, 274);
            this.btnPhatSinhLog.Name = "btnPhatSinhLog";
            this.btnPhatSinhLog.Size = new System.Drawing.Size(186, 104);
            this.btnPhatSinhLog.TabIndex = 5;
            this.btnPhatSinhLog.Text = "Phát Sinh Log Ngẫu Nhiên";
            this.btnPhatSinhLog.UseVisualStyleBackColor = true;
            this.btnPhatSinhLog.Click += new System.EventHandler(this.btnPhatSinhLog_Click);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(118, 285);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 13);
            this.lbl_time.TabIndex = 7;
            // 
            // btnQLFare
            // 
            this.btnQLFare.Location = new System.Drawing.Point(598, 32);
            this.btnQLFare.Name = "btnQLFare";
            this.btnQLFare.Size = new System.Drawing.Size(103, 158);
            this.btnQLFare.TabIndex = 8;
            this.btnQLFare.Text = "Cước Phí";
            this.btnQLFare.UseVisualStyleBackColor = true;
            this.btnQLFare.Click += new System.EventHandler(this.btnQLFare_Click);
            // 
            // Main_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQLFare);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btnPhatSinhLog);
            this.Controls.Add(this.btnQLSim);
            this.Controls.Add(this.btnQLHopDong);
            this.Controls.Add(this.btnQLHoaDon);
            this.Controls.Add(this.btnQLCTSD);
            this.Controls.Add(this.btnQLKH);
            this.Name = "Main_GUI";
            this.Text = "Quản Lý Cước Điện Thoại";
            this.Load += new System.EventHandler(this.Main_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLCTSD;
        private System.Windows.Forms.Button btnQLHoaDon;
        private System.Windows.Forms.Button btnQLHopDong;
        private System.Windows.Forms.Button btnQLSim;
        private System.Windows.Forms.Button btnPhatSinhLog;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btnQLFare;
    }
}

