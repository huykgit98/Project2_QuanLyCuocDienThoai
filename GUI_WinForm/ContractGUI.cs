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
    public partial class ContractGUI : Form
    {
        SimBLL simbll = new SimBLL();
        ContractBLL contractbll = new ContractBLL();
        public ContractGUI()
        {
            InitializeComponent();
            Loadinfo_input();
            txtTim.Text = "Tìm kiếm theo tên khách hàng...";

            txtTim.GotFocus += RemoveText;
            txtTim.LostFocus += AddText;
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Tạo sẵn giá trị trong input như sau
        private void Loadinfo_input()
        {
            DateTime d = DateTime.Now;
            txtNgayDangKy.Text = d.ToString();
        }


        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void ContractGUI_Load(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");
            dgvDSHD.Columns[0].HeaderText = "Mã Hợp Đồng";
            dgvDSHD.Columns[1].HeaderText = "Mã Sim";

            dgvDSHD.Columns[2].HeaderText = "Ngày Đăng Ký";
            dgvDSHD.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSHD.Columns[3].HeaderText = "Phí";
            dgvDSHD.Columns[4].HeaderText = "Tình Trạng";
            dgvDSHD.Columns[5].Visible = false;
        }

        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            int idx = dgvDSHD.CurrentRow.Index;
            if (dgvDSHD.Rows[idx].Cells[0].Value != null)
            {
                txtMaHopDong.Text = dgvDSHD.Rows[idx].Cells[0].Value.ToString();
                txtMaSim.Text = (dgvDSHD.Rows[idx].Cells[1].Value.ToString());
                txtNgayDangKy.Text = DateTime.Parse(dgvDSHD.Rows[idx].Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txtPhiDK.Text = dgvDSHD.Rows[idx].Cells[3].Value.ToString();
                string status = dgvDSHD.Rows[idx].Cells[4].Value.ToString();
                if (status == "True")
                {
                    rbtHoatDong.Checked = true;
                    rdbHuy.Checked = false;

                }
                else
                {
                    rbtHoatDong.Checked = false;
                    rdbHuy.Checked = true;

                }
            }
        }
        //xem chi tiết Sim
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            delete();
            txtMaHopDong.Text = txtMaSim.Text = txtPhiDK.Text = txtTim.Text = "";
            txtNgayDangKy.Text = DateTime.Now.ToString();
            dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loadinfo_input();
            txtMaHopDong.Text = txtMaSim.Text = txtPhiDK.Text = txtTim.Text = "";
            txtNgayDangKy.Text = DateTime.Now.ToString();
            dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddContractGUI addcontract_gui = new AddContractGUI();
            addcontract_gui.Show();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Loadinfo_input();
            txtMaHopDong.Text = txtMaSim.Text = txtPhiDK.Text = txtTim.Text = "";
            txtNgayDangKy.Text = DateTime.Now.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            edit();
            txtMaHopDong.Text = txtMaSim.Text = txtPhiDK.Text = txtTim.Text = "";
            txtNgayDangKy.Text = DateTime.Now.ToString();
            dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            search();
        }
        private void edit()
        {
            bool status = true;
            string id_customer = simbll.getIDcustomer_in_Sim(txtMaSim.Text);
            simbll.Update_ID_Customer(txtMaSim.Text, id_customer, true);
            if (rdbHuy.Checked==true)
            {
                status = false;
                simbll.Update_ID_Customer(txtMaSim.Text, id_customer, false);
            }
            if (System.DateTime.Parse(txtNgayDangKy.Text) > DateTime.Now.Date)
            {
                Print_MessageBox("Ngày đăng ký không hợp lệ !", "Kết quả");
            }
            else
            {
                contractbll.Update(txtMaHopDong.Text, txtMaSim.Text, System.DateTime.Parse(txtNgayDangKy.Text), Convert.ToInt32(txtPhiDK.Text), status);
                Print_MessageBox("Sửa thông tin khách hàng thành công", "Thông báo sửa");
                dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");
            }
        }
        private void delete()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                contractbll.Delete(txtMaHopDong.Text);
                simbll.Update_ID_Customer(txtMaSim.Text, null, false);
                Print_MessageBox("Xóa thành công", "Thông báo xóa");
                dgvDSHD.DataSource = new BindingSource(contractbll.GetAll(), "");
            }
        }
        private void search()
        {
            if (contractbll.SearchBy_CustomerName(txtTim.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                dgvDSHD.DataSource = new BindingSource(contractbll.SearchBy_CustomerName(txtTim.Text), "");
                int idx = dgvDSHD.CurrentRow.Index;
                txtMaHopDong.Text = dgvDSHD.Rows[idx].Cells[0].Value.ToString();
                txtMaSim.Text = dgvDSHD.Rows[idx].Cells[1].Value.ToString();
                txtNgayDangKy.Text = DateTime.Parse(dgvDSHD.Rows[idx].Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
                txtPhiDK.Text = dgvDSHD.Rows[idx].Cells[3].Value.ToString();
                string status = dgvDSHD.Rows[idx].Cells[4].Value.ToString();
                if (status == "True")
                {
                    rbtHoatDong.Checked = true;
                    rdbHuy.Checked = false;

                }
                else
                {
                    rbtHoatDong.Checked = false;
                    rdbHuy.Checked = true;

                }
            }
        }

        private void txtPhiDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDSHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
