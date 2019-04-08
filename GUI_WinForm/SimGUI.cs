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
    public partial class SimGUI : Form
    {
        SimBLL simbll = new SimBLL();
        CustomerBLL customerbll = new CustomerBLL();
        public SimGUI()
        {
            InitializeComponent();
            txtTimSim.Text = "Tìm kiếm theo tên khách hàng...";
            txtTimSim.GotFocus += RemoveText;
            txtTimSim.LostFocus += AddText;
        }
        public void RemoveText(object sender, EventArgs e)
        {
            txtTimSim.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimSim.Text))
                txtTimSim.Text = "Tìm kiếm theo tên khách hàng...";
        }
        private void btnXemMaKH_Click(object sender, EventArgs e)
        {

            
            if ((customerbll.SearchById_Customer(txtMaKH.Text) != null))
            {
                List<CUSTOMER> result = customerbll.SearchById_Customer(txtMaKH.Text);
                DetailsCustomerGUI details_customer = new DetailsCustomerGUI(result[0].id, result[0].name_cus, result[0].identify.ToString(), result[0].job, result[0].position, result[0].address, result[0].email);
                details_customer.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }

        private void btnThemSim_Click(object sender, EventArgs e)
        {
            AddSimGUI frm = new AddSimGUI();
            frm.Show();

           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtMaSim.Text = "";
            txtMaKH.Text = "";
            txtSDT.Text = "";
            rdbChuaSD.Checked = true;

        }

        private void btnTimSim_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnSuaSim_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnXoaSim_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataTable();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SimGUI_Load(object sender, EventArgs e)
        {
            dgvDSSim.DataSource = new BindingSource(simbll.GetAll(), "");
            dgvDSSim.Columns[0].HeaderText = "Mã Sim";
            dgvDSSim.Columns[1].HeaderText = "Mã khách hàng";

            dgvDSSim.Columns[2].HeaderText = "Số điện thoại";
            dgvDSSim.Columns[3].HeaderText = "Tình Trạng";
            dgvDSSim.Columns[4].Visible = false;
            dgvDSSim.Columns[5].Visible = false;
            dgvDSSim.Columns[6].Visible = false;
            dgvDSSim.Columns[7].Visible = false;
            
        }
        private void search()
        {
            if (simbll.SearchBy_CustomerName(txtTimSim.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                dgvDSSim.DataSource = new BindingSource(simbll.SearchBy_CustomerName(txtTimSim.Text), "");
                int idx = dgvDSSim.CurrentRow.Index;
                txtMaSim.Text = dgvDSSim.Rows[idx].Cells[0].Value.ToString();
                if (dgvDSSim.Rows[idx].Cells[1].Value == null)
                {
                    txtMaKH.Text = "";
                }
                else txtMaKH.Text = dgvDSSim.Rows[idx].Cells[1].Value.ToString();
                txtSDT.Text =dgvDSSim.Rows[idx].Cells[2].Value.ToString();
                string status = dgvDSSim.Rows[idx].Cells[3].Value.ToString();
                if (status == "True")
                {
                    rdbDaSD.Checked = true;
                    rdbChuaSD.Checked = false;

                }
                else
                {
                    rdbDaSD.Checked = false;
                    rdbChuaSD.Checked = true;

                }
            }
        }
        private void loadDataTable()
        {
            dgvDSSim.DataSource = new BindingSource(simbll.GetAll(), "");
        }

 
        private void dgvDSSim_Click(object sender, EventArgs e)
        {
            int idx = dgvDSSim.CurrentRow.Index;
            txtMaSim.Text = dgvDSSim.Rows[idx].Cells[0].Value.ToString();
            if (dgvDSSim.Rows[idx].Cells[1].Value == null)
            {
                txtMaKH.Text = "";
            }
            else txtMaKH.Text = dgvDSSim.Rows[idx].Cells[1].Value.ToString();
            txtSDT.Text = dgvDSSim.Rows[idx].Cells[2].Value.ToString();
            string status = dgvDSSim.Rows[idx].Cells[3].Value.ToString();
            if (status == "True")
            {
                rdbDaSD.Checked = true;
                rdbChuaSD.Checked = false;

            }
            else
            {
                rdbDaSD.Checked = false;
                rdbChuaSD.Checked = true;

            }
        }

        
        //Functio sửa row
        private void edit()
        {
            try
            {
                bool status = true;
                if (rdbChuaSD.Checked == true)
                    status = false;
                if (rdbDaSD.Checked == true)
                    status = true;
                if (txtMaKH.Text == "")
                {
                    string result = simbll.Update(txtMaSim.Text, txtSDT.Text, status);
                    Print_MessageBox(result, "Thông báo sửa");
                }
                else if(txtMaKH.Text!="")
                {
                    string result = simbll.Update(txtMaSim.Text,txtMaKH.Text, txtSDT.Text, status);
                    Print_MessageBox(result, "Thông báo sửa");
                }
                else Print_MessageBox("Có lỗi xảy ra!", "Kết quả");
            }
            catch
            {
                Print_MessageBox("phải xóa hợp đồng trước!", "Kết quả");
            }
        }

        // Function delete row
        private void delete()
        {
            DialogResult Dialogresult = MessageBox.Show("Bạn có chắc chắn xóa không ?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Dialogresult == DialogResult.Yes)
            {
                if (txtMaKH.Text == "")
                {
                    string result = simbll.Delete(txtMaSim.Text);
                    Print_MessageBox(result, "Thông báo xóa");

                    loadDataTable();
                }
                else Print_MessageBox("phải xóa hợp đồng liên quan trước!", "Kết quả");



            }
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void dgvDSSim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSSim_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 
        }
    }
}
