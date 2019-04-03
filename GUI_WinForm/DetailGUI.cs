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
    public partial class DetailGUI : Form
    {
        DetailBLL detail = new DetailBLL();
        public DetailGUI()
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

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetailGUI_Load(object sender, EventArgs e)
        {
            loadDataTable();

            
        }

        private void loadDataTable()
        {
            dgvCTSD.DataSource = new BindingSource(detail.GetAll(), "");
            dgvCTSD.Columns[0].HeaderText = "Mã CT Cước Tháng";
            dgvCTSD.Columns[1].HeaderText = "Mã Sim";

            dgvCTSD.Columns[2].HeaderText = "Thời Gian Bắt Đầu";
            //for (int i = 0; i < dgvCTSD.Rows.Count - 1; i++)
            //{
            //    dgvCTSD.Rows[i].Cells[2].Value = dgvCTSD.Rows[i].Cells[2].Value.ToString();
            //}
            dgvCTSD.Columns[3].HeaderText = "Thời Gian Kết Thúc";
            dgvCTSD.Columns[4].HeaderText = "Số phút khung giờ chính";
            dgvCTSD.Columns[5].HeaderText = "Số phút khung giờ phụ";
            dgvCTSD.Columns[6].HeaderText = "Tổng giá cước";
            dgvCTSD.Columns[7].Visible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            search();

        }

        private void dgvCTSD_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();

        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            AddDetailGUI addDetail_GUI = new AddDetailGUI();
            addDetail_GUI.ShowDialog();
        }
        private void search()
        {
            if (detail.SearchByName(txtTim.Text) == null)
            {
                Print_MessageBox("Không tìm thấy dữ liệu", "Kết quả");
            }
            else
            {
                dgvCTSD.DataSource = new BindingSource(detail.SearchByName(txtTim.Text), "");
            }
        }
        private void refresh()
        {
            dgvCTSD.DataSource = new BindingSource(detail.GetAll(), "");
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
