namespace GUI_WinForm
{
    partial class InHDHDong
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InHDHopDong = new GUI_WinForm.InHDHopDong();
            this.DTInHopDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTInHopDongTableAdapter = new GUI_WinForm.InHDHopDongTableAdapters.DTInHopDongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InHDHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTInHopDongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DTInHopDongBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_WinForm.rpHDHopDong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // InHDHopDong
            // 
            this.InHDHopDong.DataSetName = "InHDHopDong";
            this.InHDHopDong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTInHopDongBindingSource
            // 
            this.DTInHopDongBindingSource.DataMember = "DTInHopDong";
            this.DTInHopDongBindingSource.DataSource = this.InHDHopDong;
            // 
            // DTInHopDongTableAdapter
            // 
            this.DTInHopDongTableAdapter.ClearBeforeFill = true;
            // 
            // InHDHDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InHDHDong";
            this.Text = "In Hóa Đơn Hợp Đồng";
            this.Load += new System.EventHandler(this.InHDHDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InHDHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTInHopDongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DTInHopDongBindingSource;
        private InHDHopDong InHDHopDong;
        private InHDHopDongTableAdapters.DTInHopDongTableAdapter DTInHopDongTableAdapter;
    }
}