using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForm
{
    public partial class DetailsCustomerGUI : Form
    {
        private string id;
        private string name_cus;
        private string v;
        private string job;
        private string position;
        private string address;
        private string email;

        public DetailsCustomerGUI()
        {
            InitializeComponent();
        }

        public DetailsCustomerGUI(string id, string name_cus, string v, string job, string position, string address, string email)
        {
            this.id = id;
            this.name_cus = name_cus;
            this.v = v;
            this.job = job;
            this.position = position;
            this.address = address;
            this.email = email;
            InitializeComponent();

        }

        private void DetailsCustomerGUI_Load(object sender, EventArgs e)
        {
            txtIDKH.Text = id;
            txtTenKH.Text = name_cus;
            txtCMND.Text = v;
            txtNgheNghiep.Text = job;
            txtChucVu.Text = position;
            txtDiaChi.Text = address;
            txtEmail.Text = email;
        }
    }
}
