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
    public partial class CustomerGUI : Form
    {
        CustomerBLL customers = new CustomerBLL();
        CustomerBLL customer = new CustomerBLL();

        public CustomerGUI()
        {
            InitializeComponent();
            txtTimKH.Text = "Tìm kiếm theo tên khách hàng...";

            txtTimKH.GotFocus += RemoveText;
            txtTimKH.LostFocus += AddText;
        }

        public void RemoveText(object sender, EventArgs e)
        {
            txtTimKH.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKH.Text))
                txtTimKH.Text = "Tìm kiếm theo tên khách hàng...";
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void loadDataTable()
        {
            dgvDSKH.DataSource = new BindingSource(customers.GetAll(), "");
            dgvDSKH.Columns[0].HeaderText = "Mã KH";
            dgvDSKH.Columns[1].HeaderText = "Tên KH";
            dgvDSKH.Columns[2].HeaderText = "CMND";
            dgvDSKH.Columns[3].HeaderText = "Nghề Nghiệp";
            dgvDSKH.Columns[4].HeaderText = "Chức Vụ";
            dgvDSKH.Columns[5].HeaderText = "Địa Chỉ";
            dgvDSKH.Columns[6].HeaderText = "Email";
            dgvDSKH.Columns[7].Visible= false;

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            
                var result = customer.Create(txtTenKH.Text, Convert.ToInt32(txtCMND.Text), txtNgheNghiep.Text, txtChucVu.Text, txtDiaChi.Text, txtEmail.Text);
                Print_MessageBox(result, "Thông báo thêm");
                loadDataTable();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDKH.Text = txtTenKH.Text = txtCMND.Text = txtNgheNghiep.Text = txtChucVu.Text = txtDiaChi.Text =txtEmail.Text="";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            edit();
            txtIDKH.Text = txtTenKH.Text = txtCMND.Text = txtNgheNghiep.Text = txtChucVu.Text = txtDiaChi.Text = txtEmail.Text = "";
            loadDataTable();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delete();
            txtIDKH.Text = txtTenKH.Text = txtCMND.Text = txtNgheNghiep.Text = txtChucVu.Text = txtDiaChi.Text = txtEmail.Text = "";
            loadDataTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtIDKH.Text = txtTenKH.Text = txtCMND.Text = txtNgheNghiep.Text = txtChucVu.Text = txtDiaChi.Text = txtEmail.Text = "";
            dgvDSKH.DataSource = new BindingSource(customers.GetAll(), "");

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            search();

        }

        private void dgvDSKH_Click(object sender, EventArgs e)
        {
            int idx = dgvDSKH.CurrentRow.Index;
            txtIDKH.Text = dgvDSKH.Rows[idx].Cells[0].Value.ToString();
            txtTenKH.Text = dgvDSKH.Rows[idx].Cells[1].Value.ToString();
            txtCMND.Text = dgvDSKH.Rows[idx].Cells[2].Value.ToString();
            txtNgheNghiep.Text = dgvDSKH.Rows[idx].Cells[3].Value.ToString();
            txtChucVu.Text = dgvDSKH.Rows[idx].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvDSKH.Rows[idx].Cells[5].Value.ToString();
            txtEmail.Text = dgvDSKH.Rows[idx].Cells[6].Value.ToString();

        }

        private void search()
        {
            if (customers.SearchByName(txtTimKH.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                int idx = dgvDSKH.CurrentRow.Index;
                dgvDSKH.DataSource = new BindingSource(customers.SearchByName(txtTimKH.Text), "");
                txtIDKH.Text = dgvDSKH.Rows[idx].Cells[0].Value.ToString();
                txtTenKH.Text = dgvDSKH.Rows[idx].Cells[1].Value.ToString();
                txtCMND.Text = dgvDSKH.Rows[idx].Cells[2].Value.ToString();
                txtNgheNghiep.Text = dgvDSKH.Rows[idx].Cells[3].Value.ToString();
                txtChucVu.Text = dgvDSKH.Rows[idx].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDSKH.Rows[idx].Cells[5].Value.ToString();
                txtEmail.Text = dgvDSKH.Rows[idx].Cells[6].Value.ToString();
            }
        }
        private void edit()
        {
            var result = customers.Update(txtIDKH.Text, txtTenKH.Text, Convert.ToInt32(txtCMND.Text), txtNgheNghiep.Text, txtChucVu.Text, txtDiaChi.Text, txtEmail.Text);
            Print_MessageBox(result, "Thông báo sửa");
            dgvDSKH.DataSource = new BindingSource(customers.GetAll(), "");
        }
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                var result = customers.Delete(txtIDKH.Text);
                Print_MessageBox(result, "Thông báo xóa");
                dgvDSKH.DataSource = new BindingSource(customers.GetAll(), "");
            }
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
