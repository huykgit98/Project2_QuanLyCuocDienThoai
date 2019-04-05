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
    public partial class InHDHDong : Form
    {
        private string _maHopDong;

        public string MaHopDong
        {
            get { return _maHopDong; }
            set { _maHopDong = value; }
        }
        public InHDHDong()
        {
            InitializeComponent();
        }

        private void InHDHDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InHDHopDong.DTInHopDong' table. You can move, or remove it, as needed.
            this.DTInHopDongTableAdapter.Fill(this.InHDHopDong.DTInHopDong, _maHopDong);

            this.reportViewer1.RefreshReport();
        }
    }
}
