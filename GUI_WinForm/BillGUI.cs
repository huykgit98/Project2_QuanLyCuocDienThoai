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
using WebMVC.Models;

namespace GUI_WinForm
{
    public partial class BillGUI : Form
    {
        BillBLL billbll = new BillBLL();
        DetailBLL detailbll = new DetailBLL();
        SimBLL simbll = new SimBLL();
        ContractBLL contractbll = new ContractBLL();
        public BillGUI()
        {
            InitializeComponent();
            txtTim.Text = "Tìm kiếm theo tên khách hàng...";

            txtTim.GotFocus += RemoveText;
            txtTim.LostFocus += AddText;
        }
        public void RemoveText(object sender, EventArgs e)
        {
            txtTim.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim.Text))
                txtTim.Text = "Tìm kiếm theo tên khách hàng...";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (simbll.SearchById_Sim(txtMaSim.Text) != null)
            {
                List<SIM> result = simbll.SearchById_Sim(txtMaSim.Text);
                DetailsSimGUI details_sim = new DetailsSimGUI(result[0].id, result[0].id_cus, result[0].phone.ToString(), result[0].status);
                details_sim.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddBillGUI addBill_GUI = new AddBillGUI();
            addBill_GUI.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            check_payment();
        }

        private void btnCatSim_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            check_payment();
            inHoaDon();
        }

        private void inHoaDon()
        {
            throw new NotImplementedException();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delete();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            search();
        }

        private void BillGUI_Load(object sender, EventArgs e)
        {
            loadDataTable();

        }

        private void loadDataTable()
        {
            dgvDSHD.DataSource = billbll.GetAll();
            dgvDSHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvDSHD.Columns[1].HeaderText = "Mã Sim";

            dgvDSHD.Columns[2].HeaderText = "Kì Sử Dụng";
            dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[3].HeaderText = "Hạn Thanh Toán";
            dgvDSHD.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[7].HeaderText = "Ngày Lập";
            dgvDSHD.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[4].HeaderText = "Cước Thuê Bao";
            dgvDSHD.Columns[5].HeaderText = "Tổng Thanh Toán";
            dgvDSHD.Columns[6].HeaderText = "Tình Trạng";
          
            dgvDSHD.Columns[8].Visible = false;

        }

        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cut()
        {
            int idx = dgvDSHD.CurrentRow.Index;
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = DateTime.Parse(txtNgayCat.Text);
            if (txtMaHD.Text == null || txtTinhTrang.Text == "Đã thanh toán")
            {
                Print_MessageBox("Vui lòng chọn hóa đơn hợp lệ để cắt", "Kết quả");
            }
            else if (simbll.checkifLocked(txtMaSim.Text) == false)
            {
                Print_MessageBox("Hợp đồng tương ứng với hóa đơn không hợp lệ và đã bị cắt trước đó", "Kết quả");
            }
            else if ((d1 - d2).TotalDays >= 3)
            {
                try
                {

                    contractbll.cancelContract_bySimID(txtMaSim.Text);
                    //lỗi do chưa tạo hợp đồng giữa sim và  khách hàng (thêm hợp đồng trước nhé)
                    simbll.lockSim(txtMaSim.Text);
                    Print_MessageBox("Đã cắt hóa đơn và hợp đồng tương ứng", "Kết quả");
                }
                
                catch
            {
                Print_MessageBox("Sim chưa có hợp đồng không thể cắt!", "Kết quả");

            }
            }
            else Print_MessageBox("Chưa đủ ngày để có thể cắt hóa đơn!", "Kết quả");


        }

        private void clear()
        {
            txtMaHD.Text = txtTinhTrang.Text = txtPhutSuDung.Text = txtNgayCat.Text = txtMaSim.Text = txtPhiThueBao.Text = txtNgayLapPhieu.Text = "";
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            dgvDSHD.DataSource = new BindingSource(billbll.GetAll(), "");
        }

        // Function Tìm ID SIM
        //tìm sim bị lỗi do 1 kh có nhiều sim

        private void search()
        {
            if (billbll.SearchBy_CustomerName(txtTim.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                dgvDSHD.DataSource = new BindingSource(simbll.SearchBy_CustomerName(txtTim.Text), "");
                dgvDSHD.Columns[0].HeaderText = "Mã Hóa Đơn";
                dgvDSHD.Columns[1].HeaderText = "Mã Sim";

                dgvDSHD.Columns[2].HeaderText = "Ngày Xuất Phiếu";
                dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDSHD.Columns[3].HeaderText = "Ngày Cắt";
                dgvDSHD.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDSHD.Columns[4].HeaderText = "Cước Thuê Bao";
                dgvDSHD.Columns[5].HeaderText = "Cước Phí Hàng Tháng";
                dgvDSHD.Columns[6].HeaderText = "Tình Trạng";

                dgvDSHD.Columns[7].Visible = false;
                
                
            }
        }

        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            int idx = dgvDSHD.CurrentRow.Index;
            if (dgvDSHD.Rows[idx].Cells[0].Value != null)
            {
                txtMaHD.Text = dgvDSHD.Rows[idx].Cells[0].Value.ToString();
                txtMaSim.Text = dgvDSHD.Rows[idx].Cells[1].Value.ToString();
                txtNgayLapPhieu.Text = DateTime.Parse(dgvDSHD.Rows[idx].Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txtNgayCat.Text = DateTime.Parse(dgvDSHD.Rows[idx].Cells[3].Value.ToString()).ToString("dd/MM/yyyy");
                txtPhiThueBao.Text = dgvDSHD.Rows[idx].Cells[4].Value.ToString();
                txtCuocThang.Text = dgvDSHD.Rows[idx].Cells[5].Value.ToString();
                txtInvoiceDate.Text = DateTime.Parse(dgvDSHD.Rows[idx].Cells[7].Value.ToString()).ToString("dd/MM/yyyy");

                if (Convert.ToBoolean(dgvDSHD.Rows[idx].Cells[6].Value) == true)
                    txtTinhTrang.Text = "Đã thanh toán";
                else
                    txtTinhTrang.Text = "Chưa thanh toán";
                txtPhutSuDung.Text = detailbll.GetTotalUseMins(txtMaSim.Text, DateTime.Parse(dgvDSHD.Rows[idx].Cells[2].Value.ToString()), DateTime.Parse(dgvDSHD.Rows[idx].Cells[3].Value.ToString())).ToString();
            }
        }
        // Functio sửa row
        private void check_payment()
        {
            billbll.Pay(txtMaHD.Text);
            Print_MessageBox("Thanh toán thành công", "Thông báo thanh toán");
            dgvDSHD.DataSource = new BindingSource(billbll.GetAll(), "");
        }

        // Function delete row
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                billbll.Delete(txtMaHD.Text);
                Print_MessageBox("Xóa thành công", "Thông báo xóa");
                dgvDSHD.DataSource = new BindingSource(billbll.GetAll(), "");
            }
        }

    }
}
