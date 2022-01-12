using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class HoadonView
    {
        public string sohd { get; set; }
        public string ngaylaphd { get; set; }
        public string tenkh { get; set; }
        public string mahang { get; set; }
        public string tenhang { get; set; }
        public string dvt { get; set; }
        public string dongia { get; set; }
        public string soluong { get; set; }
        public string thanhtien { get; set; }
        public static List<HoadonView> chuyendoi(CHoadon hd)
        {
            List<HoadonView> ds = new List<HoadonView>();
            foreach(CChitietHoadon a in hd.chitietHoadon)
            {
                HoadonView b = new HoadonView();
                b.sohd = hd.sohd;
                b.ngaylaphd = hd.ngaylaphd.ToString();
                b.tenkh = hd.tenkh;
                b.mahang = a.hanghoa.mahang;
                b.tenhang = a.hanghoa.tenhang;
                b.dvt = a.hanghoa.dvt;
                b.dongia = a.dongia.ToString();
                b.soluong = a.soluong.ToString();
                b.thanhtien = a.thanhtien().ToString();
                ds.Add(b);
            }
            return ds;
        }

    }
}
