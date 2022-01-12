using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wfQuanlyHoadon
{
    public partial class FormHanghoa : Form
    {
        private CXulyHanghoa xl;
        public FormHanghoa()
        {
            InitializeComponent();
        }

        private void FormHanghoa_Load(object sender, EventArgs e)
        {
            xl = new CXulyHanghoa();
            hienthi(xl.getDSHanghoa());
        }
        private void hienthi(List<CHangHoa> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgv.DataSource = bs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHangHoa a = new CHangHoa();
            a.mahang = txtMahang.Text;
            a.tenhang = txtTenhang.Text;
            a.dvt = txtDvt.Text;
            a.dongia = double.Parse(txtDongia.Text);
            xl.them(a);
            hienthi(xl.getDSHanghoa());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgv.SelectedRows)
            {
                string mahang = r.Cells[0].Value.ToString();
                xl.xoa(mahang);
            }
            hienthi(xl.getDSHanghoa());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CHangHoa a = new CHangHoa();
            a.mahang = txtMahang.Text;
            a.tenhang = txtTenhang.Text;
            a.dvt = txtDvt.Text;
            a.dongia = double.Parse(txtDongia.Text);
            xl.sua(a);
            hienthi(xl.getDSHanghoa());
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mahang = r.Cells[0].Value.ToString();
                CHangHoa a= xl.tim(mahang);
                txtMahang.Text = a.mahang;
                txtTenhang.Text = a.tenhang;
                txtDvt.Text = a.dvt;
                txtDongia.Text = a.dongia.ToString();
                break;
            }
        }


    }
}
