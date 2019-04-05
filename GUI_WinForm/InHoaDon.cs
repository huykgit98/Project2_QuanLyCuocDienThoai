using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForm
{
    public partial class InHoaDon : Form
    {
        private string _maHD;
        
        public string Mahd
        {
            get { return _maHD; }
            set { _maHD = value; }
        }
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            string mahd = _maHD;
            // TODO: This line of code loads data into the 'DSInHD.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DSInHD.DataTable1, mahd);

            this.rpInHoaDonFrm.RefreshReport();
        }
    }
}
