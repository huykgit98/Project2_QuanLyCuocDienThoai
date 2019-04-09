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
    public partial class AddBillGUI : Form
    {
        BillBLL bill = new BillBLL();
        DetailBLL detail = new DetailBLL();
        SimBLL sim = new SimBLL();
        CustomerBLL customer = new CustomerBLL();
        public AddBillGUI()
        {
            InitializeComponent();
        }

        private void btnThemBill_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnThemVaDong_Click(object sender, EventArgs e)
        {
            Add_Close();
        }

        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm hóa đơn
        private void Add()
        {
            if (txtMaSim.Text == "")
            {
                Print_MessageBox("Chưa chọn mã sim !", "Kết quả");

            }
            else if (sim.checkifLocked(txtMaSim.Text) == false)
            {
                Print_MessageBox("SIM không hợp lệ và đã bị khóa ! Hãy chọn SIM khác ! ", "Kết quả");
            }
           
            else if(txtNgayLapPhieu.Text=="")
            {
                Print_MessageBox("Kì sử dụng không hợp lệ !", "Kết quả");

            }
            else if ((Convert.ToDateTime(txtNgayLapPhieu.Text) > DateTime.Now.Date))
            {
                Print_MessageBox("kì sử dụng không hợp lệ !", "Kết quả");
            }
            else
            {
                var Id_SIM = txtMaSim.Text;
                var date_export = new DateTime(Convert.ToDateTime(txtNgayLapPhieu.Text).Year, Convert.ToDateTime(txtNgayLapPhieu.Text).Day, Convert.ToDateTime(txtNgayLapPhieu.Text).Month);
                var invoice_date = new DateTime(Convert.ToDateTime(txtInvoice_date.Text).Year, Convert.ToDateTime(txtInvoice_date.Text).Day, Convert.ToDateTime(txtInvoice_date.Text).Month);
                var date_cut = invoice_date.AddMonths(1);
                var date_endUse = date_export.AddMonths(1);
                var TotalFare = detail.GetFare(Id_SIM, date_export, date_endUse);

                // Gửi email để thông báo                
                string id_customer = sim.getIDcustomer_in_Sim(Id_SIM);
                string email = customer.getEmail_in_Customer(id_customer);
                string name_customer = customer.getName_in_Customer(id_customer);
                
                
                    bill.SendBillByEmail(email, name_customer, Id_SIM, date_export, invoice_date, date_cut, 50000, TotalFare + Convert.ToInt32(txtPhiThueBao.Text));
                // Lưu vào database
                
                    var result = bill.Create(Id_SIM, date_export, invoice_date, date_cut, Convert.ToInt32(txtPhiThueBao.Text), TotalFare + Convert.ToInt32(txtPhiThueBao.Text), false);
                    Print_MessageBox(result, "Thông báo thêm");
                
            }
        }

        // Function Thêm hóa đơn ==> refresh
        private void Add_New()
        {
            Add();
            Refresh_All();
        }

        // Function Thêm hóa đơn ==> close
        private void Add_Close()
        {
            Add();
            Close();
        }
        // Function làm lại, refresh
        private void Refresh_All()
        {
            txtMaSim.Text = "";
            txtPhiThueBao.Text = "50000";
            txtInvoice_date.Text = DateTime.Now.Date.Day.ToString()+"/"+ DateTime.Now.Date.Month.ToString()+"/"+ DateTime.Now.Date.Year.ToString();
        }

        // Function Đóng bảng
        private void close()
        {
            this.Dispose();
        }
        private void AddBillGUI_Load(object sender, EventArgs e)
        {
            txtInvoice_date.Text = DateTime.Now.Date.Day.ToString() + "/" + DateTime.Now.Date.Month.ToString() + "/" + DateTime.Now.Date.Year.ToString();
            dgvAddBill.DataSource = sim.GetAll();
            dgvAddBill.Columns[0].HeaderText = "Mã Sim";
            dgvAddBill.Columns[1].HeaderText = "Mã khách hàng";

            dgvAddBill.Columns[2].HeaderText = "Số điện thoại";
            
            dgvAddBill.Columns[3].HeaderText = "Tình Trạng";
            dgvAddBill.Columns[4].Visible = false;
            dgvAddBill.Columns[5].Visible = false;
            dgvAddBill.Columns[6].Visible = false;
            dgvAddBill.Columns[7].Visible = false;

        }
        private void dgvAddBill_Click(object sender, EventArgs e)
        {
            int idx = dgvAddBill.CurrentRow.Index;
            txtMaSim.Text = dgvAddBill.Rows[idx].Cells[0].Value.ToString();
        }

        private void btnRong_Click(object sender, EventArgs e)
        {
            txtMaSim.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh_All();
        }

        private void txtNgayLapPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();

        }
    }
}
