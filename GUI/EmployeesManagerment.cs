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
            if (btnThem_Duan.Text == "Thêm")
            {
                btnThem_Duan.Text = "Lưu";
                btnSua_Duan.Text = "Cannel";
                btnXoa_Duan.Enabled = false;
            }
            else
            {
                btnThem_Duan.Text = "Thêm";
                btnSua_Duan.Text = "Sửa";
                btnXoa_Duan.Enabled = true;
                if( !Catch.cNullTB(txtTenDuAn.Text)& !Catch.cNullTB(txtDiaDiem.Text)& !Catch.cNullTB(txtMaPB_DA.Text))
                {
                    string tenda = txtTenDuAn.Text.Trim();
                    string diadiem = txtDiaDiem.Text.Trim();
                    DateTime ngaybd = Convert.ToDateTime(dtpNgayBD.Text.Trim());
                    DateTime ngaykt = Convert.ToDateTime(dtpNgayKT.Text.Trim());
                    int mapb = -Convert.ToInt32(txtMaPB_DA.Text.Trim());
                    tblDu_An duan = new tblDu_An(tenda, diadiem, ngaybd, ngaykt, mapb);
                    tblDuAn_BUS.addDu_An(duan);
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
            }

        }

        private void btnSua_Duan_Click(object sender, EventArgs e)
        {
            if (btnSua_Duan.Text == "Sửa")
            {
                btnThem_Duan.Text = "Lưu";
                btnSua_Duan.Text = "Cannel";
                btnXoa_Duan.Enabled = false;
            }
            else
            {
                btnThem_Duan.Text = "Thêm";
                btnSua_Duan.Text = "Sửa";
                btnXoa_Duan.Enabled = true;
            }
        }

        private void btnXoa_Duan_Click(object sender, EventArgs e)
        {

        }
    }
}
