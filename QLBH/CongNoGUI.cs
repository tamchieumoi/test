using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLBH
{
    public partial class CongNoGUI : Form
    {
        public CongNoGUI()
        {
            InitializeComponent();
        }

        private void CongNoGUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CongNoBUS.GetAllKhachHang();
        }
    }
}
