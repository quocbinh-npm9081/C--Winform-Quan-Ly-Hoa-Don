using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfQuanlyHoadon
{
    class CXulyHanghoa
    {
        private List<CHangHoa> data;
        public CXulyHanghoa()
        {
            CTruycapDulieu xl = CTruycapDulieu.khoitao();
            data = xl.getDSHanghoa();
        }
        public List<CHangHoa> getDSHanghoa()
        {
            return data;
        }
        public CHangHoa tim(string mahang)
        {
            foreach(CHangHoa a in data)
            {
                if (a.mahang == mahang) return a;
            }
            return null;
        }
        public bool them(CHangHoa a)
        {
            CHangHoa b = tim(a.mahang);
            if(b==null)
            {
                data.Add(a);
                return true;
            }
            return false;
        }
        public bool xoa(string mahang)
        {
            CHangHoa b = tim(mahang);
            if(b!=null)
            {
                data.Remove(b);
                return true;
            }
            return false;
        }
        public bool sua(CHangHoa a)
        {
            CHangHoa b = tim(a.mahang);
            if (b != null)
            {
                b.tenhang = a.tenhang;
                b.dvt = a.dvt;
                b.dongia = a.dongia;
                return true;
            }
            return false;
        }
    }
}
