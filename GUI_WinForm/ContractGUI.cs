﻿using System;
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
    public partial class ContractGUI : Form
    {
        public ContractGUI()
        {
            InitializeComponent();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            Main_GUI frm = new Main_GUI();
            frm.Show();
            this.Hide();
        }
    }
}
