using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI_WinForm
{
    public partial class DetailUse : Form
    {
        DetailBLL detail = new DetailBLL();
        private string _maSim;
        private DateTime _KiSD;

        public string MaSim
        {
            get { return _maSim; }
            set { _maSim = value; }
        }
        public DateTime KiSD
        {
            get { return _KiSD; }
            set { _KiSD = value; }
        }

        public DetailUse()
        {
            InitializeComponent();
        }

        private void DetailUse_Load(object sender, EventArgs e)
        {
            DateTime kiSDDate = Convert.ToDateTime(KiSD);
            DateTime hanSDDate = kiSDDate.AddMonths(1);
            dgvCTSD.DataSource = new BindingSource(detail.GetAll(MaSim,kiSDDate,hanSDDate), "");
            dgvCTSD.Columns[0].HeaderText = "Mã CT Cước Tháng";
            dgvCTSD.Columns[1].HeaderText = "Mã Sim";

            dgvCTSD.Columns[2].HeaderText = "Thời Gian Bắt Đầu";
            dgvCTSD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvCTSD.Columns[3].HeaderText = "Thời Gian Kết Thúc";
            dgvCTSD.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvCTSD.Columns[4].HeaderText = "Số phút khung giờ chính";
            dgvCTSD.Columns[5].HeaderText = "Số phút khung giờ phụ";
            dgvCTSD.Columns[6].HeaderText = "Tổng giá cước";
            dgvCTSD.Columns[7].Visible = false;
        }
    }
}
