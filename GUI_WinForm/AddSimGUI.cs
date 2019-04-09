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
    public partial class AddSimGUI : Form
    {
        CustomerBLL customer = new CustomerBLL();
        SimBLL simbll = new SimBLL();
        public AddSimGUI()
        {
            InitializeComponent();
        }

        private void AddSimGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvDSKH_Click(object sender, EventArgs e)
        {
            
            
        }
        // Click vào rỗng để cho id customer là trống, thêm số dt
        private void btnRong_Click(object sender, EventArgs e)
        {
            rdbSuDung.Checked = false;
            rdbChuaSD.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnThemvaDong_Click(object sender, EventArgs e)
        {
            Add(); Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Refresh_All();

        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Function Thêm khách hàng
        private void Add()
        {
            try
            {
                string result;

                bool status = true;
                if (rdbChuaSD.Checked == true)
                    status = false;
                else
                    status = true;
                result = simbll.Create1(txtSDTKH.Text, status);
                Print_MessageBox(result, "Thông báo thêm");
            }
            catch
            {
                Print_MessageBox("Vui lòng nhập đầy đủ thông tin hoặc đúng định dạng!", "Kết quả");
            }
        }

        // Function Thêm khách hàng ==> close
        private void Add_Close()
        {
            Add();
            Close();
        }

        // Function làm lại, refresh
        private void Refresh_All()
        {
            TextBox[] textboxs = new TextBox[] { txtSDTKH };
            for (int i = 0; i < textboxs.Length; i++)
            {
                textboxs[i].Text = "";
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
