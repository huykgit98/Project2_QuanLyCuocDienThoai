namespace GUI_WinForm
{
    partial class InHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpInHoaDonFrm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSInHD = new GUI_WinForm.DSInHD();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new GUI_WinForm.DSInHDTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSInHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpInHoaDonFrm
            // 
            this.rpInHoaDonFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InHoaDon";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rpInHoaDonFrm.LocalReport.DataSources.Add(reportDataSource1);
            this.rpInHoaDonFrm.LocalReport.ReportEmbeddedResource = "GUI_WinForm.ReportInHoaDon.rdlc";
            this.rpInHoaDonFrm.Location = new System.Drawing.Point(0, 0);
            this.rpInHoaDonFrm.Name = "rpInHoaDonFrm";
            this.rpInHoaDonFrm.ServerReport.BearerToken = null;
            this.rpInHoaDonFrm.Size = new System.Drawing.Size(800, 450);
            this.rpInHoaDonFrm.TabIndex = 0;
            // 
            // DSInHD
            // 
            this.DSInHD.DataSetName = "DSInHD";
            this.DSInHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSInHD;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpInHoaDonFrm);
            this.Name = "InHoaDon";
            this.Text = "In Hóa Đơn Cước Điện Thoại";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSInHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpInHoaDonFrm;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSInHD DSInHD;
        private DSInHDTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}