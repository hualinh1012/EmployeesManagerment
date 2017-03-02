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
using Entity;
namespace GUI
{
    public partial class EmployeesManagerment : Form
    {
        public EmployeesManagerment()
        {
            InitializeComponent();
        }

        private void EmployeesManagerment_Load(object sender, EventArgs e)
        {
            showDu_An();
        }
        public void showDu_An()
        {
            dgvDuAn.DataSource = tblDuAn_BUS.loadDu_An();
        }
        
    }
}
