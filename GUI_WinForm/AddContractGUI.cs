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
    public partial class AddContractGUI : Form
    {
        CustomerBLL customer = new CustomerBLL();
        SimBLL simbll = new SimBLL();
        ContractBLL contractbll = new ContractBLL();
        public AddContractGUI()
        {
            InitializeComponent();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            Add();
            Loadinfo();
            Clear();
        }

        private void btnThemVaDong_Click(object sender, EventArgs e)
        {
            Add();
            this.Dispose();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Add()
        {
            bool status = true;
            if (rbtHuy.Checked==true)
                status = false;
            if (txtMaSim.Text != "")
            {
                string result = contractbll.Create(txtMaSim.Text, Convert.ToDateTime(txtNgayDK.Text), Convert.ToInt32(txtPhi.Text), status);
                simbll.Update_ID_Customer(txtMaSim.Text, txtMaKH.Text, status);
                Print_MessageBox(result, "Thông báo thêm");
                dgvKH.DataSource = new BindingSource(customer.GetAll(), "");
                dgvSim.DataSource = new BindingSource(simbll.GetAll(), "");
            }
            else Print_MessageBox("Mã sim trống !!", "Thông báo");


        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            int idx = dgvKH.CurrentRow.Index;
            if (dgvKH.Rows[idx].Cells[0].Value != null)
            {
                txtMaKH.Text = dgvKH.Rows[idx].Cells[0].Value.ToString();

            }

        }

        private void dgvSim_Click(object sender, EventArgs e)
        {
            int idx = dgvSim.CurrentRow.Index;
            if (dgvSim.Rows[idx].Cells[0].Value != null)
            {
                if (dgvSim.Rows[idx].Cells[1].Value == null)
                {
                    txtMaSim.Text = dgvSim.Rows[idx].Cells[0].Value.ToString();
                }
                else
                    Print_MessageBox("Không thể chọn Sim này, vì sim này đã có khách hàng !!", "Thông báo");
            }

        }

        private void AddContractGUI_Load(object sender, EventArgs e)
        {
            Loadinfo();
            dgvKH.DataSource = new BindingSource(customer.GetAll(), "");
            dgvKH.Columns[0].HeaderText = "Mã KH";
            dgvKH.Columns[1].HeaderText = "Tên KH";
            dgvKH.Columns[2].HeaderText = "Số CMND";
            dgvKH.Columns[3].HeaderText = "Nghề Nghiệp";
            dgvKH.Columns[4].Visible = false;
            dgvKH.Columns[5].Visible = false;
            dgvKH.Columns[6].Visible = false;
            dgvKH.Columns[7].Visible = false;

            dgvSim.DataSource = new BindingSource(simbll.GetAll(), "");
            dgvSim.Columns[0].HeaderText = "Mã Sim";
            dgvSim.Columns[1].HeaderText = "Mã KH";
            dgvSim.Columns[2].HeaderText = "SĐT";
            dgvSim.Columns[3].HeaderText = "Tình Trạng";
            dgvSim.Columns[4].Visible = false;
            dgvSim.Columns[5].Visible = false;
            dgvSim.Columns[6].Visible = false;
            dgvSim.Columns[7].Visible = false;
        }
        public void Loadinfo()
        {
            DateTime d = DateTime.Now;
            txtNgayDK.Text = d.ToString("MM/dd/yyyy");
            rbtHoatDong.Checked = true;
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtPhi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void Clear()
        {
            TextBox[] textboxs = new TextBox[] { txtPhi, txtMaKH };
            for (int i = 0; i < textboxs.Length; i++)
            {
                textboxs[i].Text = "";
            }
        }
    }
}
