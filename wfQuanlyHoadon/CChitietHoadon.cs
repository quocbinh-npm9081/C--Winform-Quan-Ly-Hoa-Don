using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    [Serializable]
    class CChitietHoadon
    {
        private int m_soluong;
        private double m_dongia;
        private CHangHoa m_hanghoa;
        public int soluong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }
        public double dongia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }
        public CHangHoa hanghoa
        {
            get { return m_hanghoa; }
            set { m_hanghoa = value; }
        }
        public CChitietHoadon()
        {
            m_hanghoa = null;
            m_soluong = 0;
            m_dongia = 0;
        }
        public CChitietHoadon(CHangHoa hanghoa,int soluong,double dongia)
        {
            m_hanghoa = hanghoa;
            m_soluong = soluong;
            m_dongia = dongia;
        }
        public double thanhtien()
        {
            return m_dongia * m_soluong;
        }
    }
}
