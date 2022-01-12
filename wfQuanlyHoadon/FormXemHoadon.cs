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
    public partial class FormXemHoadon : Form
    {
        public object m_hoadon;
        public FormXemHoadon()
        {
            InitializeComponent();
        }
        private void hienthiHD(CHoadon x)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HoadonView.chuyendoi(x);
            dgv.DataSource = bs;
        }
        private void FormXemHoadon_Load(object sender, EventArgs e)
        {
            CHoadon x = m_hoadon as CHoadon;
            txtSohd.Text = x.sohd;
            txtTenKH.Text = x.tenkh;
            dtpNgaylaphd.Value = x.ngaylaphd;
            hienthiHD(x);
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
