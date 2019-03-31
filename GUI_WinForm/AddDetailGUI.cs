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
using System.IO;


namespace GUI_WinForm
{
    public partial class AddDetailGUI : Form
    {
        DetailBLL detail = new DetailBLL();
        FareBLL fare = new FareBLL();
        int totalMin1, totalMin2;

        public AddDetailGUI()
        {
            InitializeComponent();
        }

        

        private void AddDetailGUI_Load(object sender, EventArgs e)
        {

        }
        private void btnThemvaDong_Click(object sender, EventArgs e)
        {
            Add_Close();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Add();

        }

        private void btnImportDL_Click(object sender, EventArgs e)
        {
            Import();


        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Refresh_All();

        }
        // Function print ra message
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Thêm khách hàng
        private void Add()
        {
            try
            {

                if (dgvDL.Rows.Count > 0)
                {
                    int i = 0;
                    while (i < dgvDL.RowCount)
                    {
                        detail.CountTimes(fare.getbeginTime("DAY"), fare.getbeginTime("NIGHT"), DateTime.ParseExact(dgvDL.Rows[i].Cells["Thời gian bắt đầu"].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact(dgvDL.Rows[i].Cells["Thời gian kết thúc"].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null), ref totalMin1, ref totalMin2);
                        var total_fare = totalMin1 * fare.getFare1("DAY") + totalMin2 * fare.getFare1("NIGHT");
                        detail.Import(dgvDL.Rows[i].Cells["Mã Sim"].Value.ToString(), DateTime.ParseExact(dgvDL.Rows[i].Cells["Thời gian bắt đầu"].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null), DateTime.ParseExact(dgvDL.Rows[i].Cells["Thời gian kết thúc"].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null), totalMin1, totalMin2, total_fare);
                        i++;
                    }
                }
                else
                    Print_MessageBox("Không tồn tại bất kì dữ liệu ! Vui lòng import log từ bên ngoài !", "Kết quả");
            }
            catch
            {
                Print_MessageBox("Thêm Thành Công!", "Kết quả");
            }
        }

        // Function Thêm khách hàng ==> refresh
        private void Import()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file text để mở";
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Mã Sim");
                    table.Columns.Add("Thời gian bắt đầu");
                    table.Columns.Add("Thời gian kết thúc");

                    using (StreamReader sr = new StreamReader(@"" + file + ""))
                    {
                        if (sr.ReadLine() == "IDSIM\tTGBD\tTGKT")
                        {
                            while (!sr.EndOfStream)
                            {
                                string[] parts = sr.ReadLine().Split('\t');
                                table.Rows.Add(parts[0], parts[1], parts[2]);
                            }
                            dgvDL.DataSource = table;
                        }
                        else
                        {
                            Print_MessageBox("File không đúng format!", "Kết quả");
                        }
                    }
                }
                catch (IOException)
                {
                }
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
            dgvDL.DataSource = null;
        }
    }
}
