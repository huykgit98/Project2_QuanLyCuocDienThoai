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
    public partial class FareGUI : Form
    {
        FareBLL fare = new FareBLL();
        public FareGUI()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }

        private void FareGUI_Load(object sender, EventArgs e)
        {
            loadDataTable();

        }
        private void clear()
        {
            txtIDKhoangGio.Text = ""; txtCuocPhi.Text = "0";
        }

        // Function làm tươi danh sách
        private void refresh()
        {
            clear();
            dgvDSCP.DataSource = new BindingSource(fare.GetAll(), "");
        }

        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Functio sửa row
        private void edit()
        {//7:00:00 23:00:00
            if ( txtTGBD.Text == txtTGKT.Text)
                Print_MessageBox("Khung giờ không hợp lệ ! Vui lòng nhập lại !", "Kết quả");
            else
            {
                fare.Update(txtIDKhoangGio.Text, Convert.ToInt32(txtCuocPhi.Text), TimeSpan.Parse(txtTGBD.Text), TimeSpan.Parse(txtTGKT.Text));
                if (txtIDKhoangGio.Text == "DAY")
                    fare.Update_rest("NIGHT", TimeSpan.Parse(txtTGKT.Text), TimeSpan.Parse(txtTGBD.Text));
                else
                    fare.Update_rest("DAY", TimeSpan.Parse(txtTGBD.Text), TimeSpan.Parse(txtTGKT.Text));
                Print_MessageBox("Sửa thông tin phí cước theo khung giờ thành công !", "Thông báo sửa");
            }
            dgvDSCP.DataSource = new BindingSource(fare.GetAll(), "");
        }
        private void loadDataTable()
        {
            dgvDSCP.DataSource = new BindingSource(fare.GetAll(), "");
            dgvDSCP.Columns[0].HeaderText = "Mã cước";
            dgvDSCP.Columns[1].HeaderText = "Thời gian bắt đầu";
            dgvDSCP.Columns[2].HeaderText = "Thời gian kết thúc";
            dgvDSCP.Columns[3].HeaderText = "Cước phí";
        }

        private void dgvDSCP_Click(object sender, EventArgs e)
        {
            int idx = dgvDSCP.CurrentRow.Index;
            txtIDKhoangGio.Text = dgvDSCP.Rows[idx].Cells[0].Value.ToString();
            txtTGBD.Text = dgvDSCP.Rows[idx].Cells[1].Value.ToString();
            txtTGKT.Text = dgvDSCP.Rows[idx].Cells[2].Value.ToString();
            txtCuocPhi.Text = dgvDSCP.Rows[idx].Cells[3].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            refresh();

        }
    }
}
