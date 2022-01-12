using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class CXulyHoadon
    {
        private List<CHoadon> dsHD;
        public CXulyHoadon()
        {
            CTruycapDulieu data = CTruycapDulieu.khoitao();
            dsHD = data.getDSHoadon();
        }
        public List<CHoadon> getDSHoadon()
        {
            return dsHD;
        }
        public CHoadon tim(string sohd)
        {
            foreach(CHoadon a in dsHD)
            {
                if (a.sohd == sohd) return a;
            }
            return null;
        }
        public bool them(CHoadon x)
        {
            CHoadon t = tim(x.sohd);
            if (t == null)
            {
                dsHD.Add(x);
                return true;
            }
            return false;
        }
    }
}
