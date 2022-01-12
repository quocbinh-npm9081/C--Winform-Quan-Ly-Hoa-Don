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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            CTruycapDulieu data = CTruycapDulieu.khoitao();
            if (data.docDulieu("hoadon.dat") == true)
                MessageBox.Show("Đọc dữ liệu thành công!");
            else MessageBox.Show("Không đọc được dữ liệu!");
        }
        private void hanghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHanghoa f = new FormHanghoa();
            f.MdiParent = this;
            f.Show();
        }

        private void ghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTruycapDulieu data = CTruycapDulieu.khoitao();
            if (data.ghiDulieu("hoadon.dat") == true)
                MessageBox.Show("Ghi dữ liệu thành công!");
            else MessageBox.Show("Không ghi được dữ liệu!");
        }

        private void hoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoadon f = new FormHoadon();
            f.MdiParent = this;
            f.Show();
        }

        
    }
}
