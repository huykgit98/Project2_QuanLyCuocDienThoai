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
        CustomerBLL customer = new CustomerBLL();

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
            inHoaDon();
        }

        private void inHoaDon()
        {
            InHoaDon frm = new InHoaDon();
            frm.Mahd = txtMaHD.Text;
            frm.Show();
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
                Print_MessageBox("Hóa đơn này đã thanh toán, không được cắt!", "Kết quả");
            }
            else if (simbll.checkifLocked(txtMaSim.Text) == false)
            {
                Print_MessageBox("Hợp đồng tương ứng với hóa đơn không hợp lệ và đã bị cắt trước đó", "Kết quả");
            }
            else if ((d1 - d2).TotalDays >= 3)
            {
                try
                {
                    try
                    {
                        contractbll.cancelContract_bySimID(txtMaSim.Text);
                        //lỗi do chưa tạo hợp đồng giữa sim và  khách hàng (thêm hợp đồng trước nhé)
                    }
                    catch { }
                    simbll.lockSim(txtMaSim.Text);
                    Print_MessageBox("Đã cắt hóa đơn và hợp đồng tương ứng", "Kết quả");
                }
                
                catch
            {
                Print_MessageBox("Sim chưa có hợp đồng không thể cắt!", "Kết quả");

            }
            }
            else Print_MessageBox("Chưa đủ ngày để có thể cắt!", "Kết quả");


        }

        private void clear()
        {
            txtMaHD.Text = txtTinhTrang.Text = txtPhutSuDung.Text = txtNgayCat.Text = txtMaSim.Text = txtPhiThueBao.Text = txtNgayLapPhieu.Text = txtCuocThang.Text=txtInvoiceDate.Text="";
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
                dgvDSHD.DataSource = new BindingSource(billbll.SearchBy_CustomerName(txtTim.Text), "");
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

                dgvDSHD.Columns[7].HeaderText = "Ngày Lập";
                
                
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

        private void btnTBDinhChi_Click(object sender, EventArgs e)
        {
            var Id_SIM = txtMaSim.Text;
            var date_export = new DateTime(Convert.ToDateTime(txtNgayLapPhieu.Text).Year, Convert.ToDateTime(txtNgayLapPhieu.Text).Day, Convert.ToDateTime(txtNgayLapPhieu.Text).Month);
            var invoice_date = new DateTime(Convert.ToDateTime(txtInvoiceDate.Text).Year, Convert.ToDateTime(txtInvoiceDate.Text).Day, Convert.ToDateTime(txtInvoiceDate.Text).Month);
            var date_cut = invoice_date.AddMonths(1);
            var date_endUse = date_export.AddMonths(1);
            var TotalFare = detailbll.GetFare(Id_SIM, date_export, date_endUse);

            // Gửi email để thông báo                
            string id_customer = simbll.getIDcustomer_in_Sim(Id_SIM);
            string email = customer.getEmail_in_Customer(id_customer);
            string name_customer = customer.getName_in_Customer(id_customer);
            string phone = simbll.getPhone_in_Customer(id_customer);
            string address = customer.getAddress_in_Customer(id_customer);

            billbll.SendBillByEmail1(email, name_customer, phone, address, Id_SIM, date_export, invoice_date, date_cut, 50000, TotalFare + Convert.ToInt32(txtPhiThueBao.Text));
            // Lưu vào database
            Print_MessageBox("Gửi mail thông báo việc đình chỉ sim thành công!", "Thông báo gửi");
        }

        private void btnXemCTSD_Click(object sender, EventArgs e)
        {
            DetailUse frm =new DetailUse();
            frm.MaSim = txtMaSim.Text;
            frm.KiSD =  new DateTime(Convert.ToDateTime(txtNgayLapPhieu.Text).Year, Convert.ToDateTime(txtNgayLapPhieu.Text).Day, Convert.ToDateTime(txtNgayLapPhieu.Text).Month);

            frm.Show();
        }

    }
}
