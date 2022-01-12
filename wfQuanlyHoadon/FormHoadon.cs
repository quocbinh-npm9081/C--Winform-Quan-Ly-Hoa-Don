using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfQuanlyHoadon
{
    public partial class FormHoadon : Form
    {
        private CXulyHanghoa xlHH;
        private CXulyHoadon xlHD;
        private CHoadon hd;
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void FormHoadon_Load(object sender, EventArgs e)
        {
            xlHH = new CXulyHanghoa();
            xlHD = new CXulyHoadon();

            hd = new CHoadon();
            hienthiCombo(xlHH.getDSHanghoa());
            hienthiDSHD(xlHD.getDSHoadon());
        }
        private void hienthiCombo(List<CHangHoa> ds)
        {
            cmbMahang.DisplayMember = "mahang";
            cmbMahang.ValueMember = "mahang";
            cmbMahang.DataSource = ds;
        }
        private void hienthiDSHD(List<CHoadon> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            dgvDMHD.DataSource = bs;
        }
        private void cmbMahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahang=cmbMahang.SelectedValue.ToString();
            CHangHoa a = xlHH.tim(mahang);
            txtTenhang.Text = a.tenhang;
            txtDvt.Text = a.dvt;
            txtDongia.Text = a.dongia.ToString();
            txtSoluong.Text = "1";
        }
        private void btbChonhh_Click(object sender, EventArgs e)
        {
            CChitietHoadon ct = new CChitietHoadon();
            string mahang = cmbMahang.SelectedValue.ToString();
            ct.hanghoa = xlHH.tim(mahang);
            ct.dongia = ct.hanghoa.dongia;
            ct.soluong = int.Parse(txtSoluong.Text);

            hd.chitietHoadon.Add(ct);
            hienthiHD(hd);
        }
        private void hienthiHD(CHoadon x)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HoadonView.chuyendoi(x);
            dgv.DataSource = bs;
        }
        private void btnLaphd_Click(object sender, EventArgs e)
        {
            hd.sohd = txtSohd.Text;
            hd.tenkh = txtTenKH.Text;
            hd.ngaylaphd = dtpNgaylaphd.Value;
            if(xlHD.them(hd)==true)
            {
                hienthiDSHD(xlHD.getDSHoadon());
                hd = new CHoadon();
                hienthiHD(hd);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn không thành công!");
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dgvDMHD.SelectedRows)
            {
                string sohd = r.Cells[0].Value.ToString();
                CHoadon x = xlHD.tim(sohd);
                if(x!=null)
                {
                    FormXemHoadon f = new FormXemHoadon();
                    f.m_hoadon = x;
                    f.ShowDialog();
                    break;
                }
            }
        }       
    }
}
