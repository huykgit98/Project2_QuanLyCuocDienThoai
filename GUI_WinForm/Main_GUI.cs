using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI_WinForm
{
    public partial class Main_GUI : Form
    {
        SimBLL sim = new SimBLL();
        Random random = new Random();

        public Main_GUI()
        {
            InitializeComponent();
        }
        

        private void Main_GUI_Load(object sender, EventArgs e)
        {
         
        }
        private void Print_MessageBox(string StringMessage, string title)
        {
            MessageBox.Show(StringMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnPhatSinhLog_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now.AddMonths(-2);

            SaveFileDialog savefile = new SaveFileDialog();

            savefile.FileName = ".txt";

            savefile.Filter = "Text files (*.txt)|*.txt";

            var array = sim.GetAll_Array();
            if (array != null)
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    {
                        sw.WriteLine("IDSIM\tTGBD\tTGKT");
                        int itemRows = 0;
                        while (itemRows < 150)
                        {
                            t1 = t1.Add(RandomTimeSpan()).AddDays(RandomInteger(0, 2));
                            DateTime t2 = t1.Add(RandomTimeSpan());
                            itemRows++;
                            var temp = RandomInteger(0, array.Length);
                            if (t1 > DateTime.Now || t2 > DateTime.Now)
                                break;
                            sw.WriteLine(array[temp] + "\t" + t1.ToString("dd/MM/yyyy HH:mm:ss") + "\t" + t2.ToString("dd/MM/yyyy HH:mm:ss"));
                        }
                    }
                    Print_MessageBox("Tạo log phát sinh ngẫu nhiên thành công !", "Thông báo tạo log ngẫu nhiên");
                    Process.Start(savefile.FileName);
                }
            }
            else
            {
                Print_MessageBox("Tạo log phát sinh ngẫu nhiên thất bại ! Không có bất kì dữ liệu SIM nào tồn tại !", "Thông báo tạo log ngẫu nhiên");
            }
        }
        private TimeSpan RandomTimeSpan()
        {
            TimeSpan start = TimeSpan.FromMinutes(0);
            TimeSpan end = TimeSpan.FromMinutes(60);
            int maxMinutes = (int)((end - start).TotalMinutes);
            int minutes = random.Next(maxMinutes);
            return start.Add(TimeSpan.FromMinutes(minutes));
        }
        private int RandomInteger(int min, int max)
        {
            return random.Next(min, max);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            CustomerGUI frm = new CustomerGUI();
            frm.Show();
            this.Hide();
        }

        private void btnQLSim_Click(object sender, EventArgs e)
        {

            SimGUI frm = new SimGUI();
            frm.Show();
            this.Hide();

        }

        private void btnQLHopDong_Click(object sender, EventArgs e)
        {
            ContractGUI frm = new ContractGUI();
            frm.Show(); this.Hide();

        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            BillGUI frm = new BillGUI();
            frm.Show(); this.Hide();

        }

        private void btnQLCTSD_Click(object sender, EventArgs e)
        {
            DetailGUI frm = new DetailGUI();
            frm.Show(); this.Hide();

        }

        private void btnQLFare_Click(object sender, EventArgs e)
        {
            FareGUI frm = new FareGUI();
            frm.Show();
            this.Hide();
        }
    }
}
