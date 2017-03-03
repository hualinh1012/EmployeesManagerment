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
            buidingDu_An();
        }


        /// <summary>
        /// BANG DU AN
        /// </summary>
        public void showDu_An()
        {
            dgvDuAn.DataSource = tblDuAn_BUS.loadDu_An();
        }

        public void clearData()
        {
            txtMaDuAn.Text = "";
            txtMaPB_DA.Text = "";
            txtTenDuAn.Text = "";
            txtDiaDiem.Text = "";
        }

        public void Enebal()
        {
            txtMaDuAn.Enabled = false;
            txtTenDuAn.Enabled = false;
            txtMaPB_DA.Enabled = false;
            txtDiaDiem.Enabled = false;
            dtpNgayKT.Enabled = false;
            dtpNgayBD.Enabled = false;
        }

        public void UnEnebal()
        {
            txtMaDuAn.Enabled = true;
            txtTenDuAn.Enabled = true;
            txtMaPB_DA.Enabled = true;
            txtDiaDiem.Enabled = true;
            dtpNgayKT.Enabled = true;
            dtpNgayBD.Enabled = true;
        }


        public void buidingDu_An()
        {
            txtMaDuAn.DataBindings.Clear();
            txtMaDuAn.DataBindings.Add("Text",dgvDuAn.DataSource,"MaDA");
            txtTenDuAn.DataBindings.Clear();
            txtTenDuAn.DataBindings.Add("Text", dgvDuAn.DataSource, "tenDA");
            txtDiaDiem.DataBindings.Clear();
            txtDiaDiem.DataBindings.Add("Text", dgvDuAn.DataSource, "diaDiem");
            dtpNgayBD.DataBindings.Clear();
            dtpNgayBD.DataBindings.Add("Text", dgvDuAn.DataSource, "ngayBatDau");
            dtpNgayKT.DataBindings.Clear();
            dtpNgayKT.DataBindings.Add("Text", dgvDuAn.DataSource, "ngayKetThuc");
            txtMaPB_DA.DataBindings.Clear();
            txtMaPB_DA.DataBindings.Add("Text", dgvDuAn.DataSource, "maPB");
        }

        
        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Duan_Click(object sender, EventArgs e)
        {
            clearData();
            btnThem_Duan.Text = "Huy";
            btnSua_Duan.Text = "Cannel";
            btnXoaDuan.Text = "Luu";
            UnEnebal();

        }
    }
}
