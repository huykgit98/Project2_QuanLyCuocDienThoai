namespace GUI_WinForm
{
    partial class DetailUse
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTSD
            // 
            this.dgvCTSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTSD.Location = new System.Drawing.Point(0, 0);
            this.dgvCTSD.Name = "dgvCTSD";
            this.dgvCTSD.Size = new System.Drawing.Size(728, 450);
            this.dgvCTSD.TabIndex = 0;
            // 
            // DetailUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dgvCTSD);
            this.Name = "DetailUse";
            this.Text = "Chi Tiết Sử Dụng";
            this.Load += new System.EventHandler(this.DetailUse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTSD;
    }
}