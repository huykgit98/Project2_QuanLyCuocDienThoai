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
    public partial class DetailsSimGUI : Form
    {
        CustomerBLL customerbus = new CustomerBLL();

        private string id;
        private string id_cus;
        private string v;
        private bool? status;

        public DetailsSimGUI()
        {
            InitializeComponent();
        }

        public DetailsSimGUI(string id, string id_cus, string v, bool? status)
        {
            this.id = id;
            this.id_cus = id_cus;
            this.v = v;
            this.status = status;
            InitializeComponent();

        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (customerbus.SearchById_Customer(txtMaKH.Text) != null)
            {
                List<CUSTOMER> result = customerbus.SearchById_Customer(txtMaKH.Text);
                DetailsCustomerGUI details_customer = new DetailsCustomerGUI(result[0].id, result[0].name_cus, result[0].identify.ToString(), result[0].job, result[0].position, result[0].address, result[0].email);
                details_customer.ShowDialog();
            }
            else
                Print_MessageBox("Không có thông tin này !!!", "Lỗi");
        }

        private void DetailsSimGUI_Load(object sender, EventArgs e)
        {
            txtMaSim.Text = id;
            txtMaKH.Text = id_cus;
            txtSDT.Text = v;
            if (status == false)
                rbtChuaSD.Checked = true;
            else
                rbtDaSD.Checked = true;
        }
    }
}
