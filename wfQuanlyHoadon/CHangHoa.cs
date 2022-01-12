using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    [Serializable]
    class CHangHoa
    {
        private string m_mahang;
        private string m_tenhang;
        private string m_dvt;
        private double m_dongia;
        public string mahang
        {
            get { return m_mahang; }
            set { m_mahang = value; }
        }
        public string tenhang
        {
            get { return m_tenhang; }
            set { m_tenhang = value; }
        }
        public string dvt
        {
            get { return m_dvt; }
            set { m_dvt = value; }
        }
        public double dongia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }
        public CHangHoa(string mahang,string tenhang,string dvt,double dongia)
        {
            m_mahang = mahang;
            m_tenhang = tenhang;
            m_dvt = dvt;
            m_dongia = dongia;
        }
        public CHangHoa()
        {
            m_mahang = "";
            m_tenhang = "";
            m_dvt = "";
            m_dongia = 0.0;
        }
    }
}
