using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    [Serializable]
    class CHoadon
    {
        private string m_sohd;
        private DateTime m_ngaylaphd;
        private string m_tenkh;
        private List<CChitietHoadon> m_chitietHoadon;
        public string sohd
        {
            get { return m_sohd; }
            set { m_sohd = value; }
        }
        public DateTime ngaylaphd
        {
            get { return m_ngaylaphd; }
            set { m_ngaylaphd = value; }
        }
        public string tenkh
        {
            get { return m_tenkh; }
            set { m_tenkh = value; }
        }
        public List<CChitietHoadon> chitietHoadon
        {
            get { return m_chitietHoadon; }
        }
        public CHoadon()
        {
            m_sohd = "";
            m_ngaylaphd = DateTime.Now;
            m_tenkh = "";
            m_chitietHoadon = new List<CChitietHoadon>();
        }
        public CHoadon(string sohd,DateTime ngaylaphd,string tenkh)
        {
            m_sohd = sohd;
            m_ngaylaphd = ngaylaphd;
            m_tenkh = tenkh;
            m_chitietHoadon = new List<CChitietHoadon>();
        }
        public double thanhtien()
        {
            double tien = 0;
            foreach(CChitietHoadon a in m_chitietHoadon)
            {
                tien += a.thanhtien();
            }
            return tien;
        }
    }
}
