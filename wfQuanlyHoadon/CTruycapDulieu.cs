using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace wfQuanlyHoadon
{
    [Serializable]
    class CTruycapDulieu
    {
        private static CTruycapDulieu m_data = null;
        private List<CHangHoa> m_dsHH;
        private List<CHoadon> m_dsHD;
        private CTruycapDulieu()
        {
            m_dsHH = new List<CHangHoa>();
            m_dsHD = new List<CHoadon>();
        }
        public static CTruycapDulieu khoitao()
        {
            if (m_data == null) m_data = new CTruycapDulieu();
            return m_data;
        }
        public List<CHangHoa> getDSHanghoa()
        {
            return m_dsHH;
        }
        public List<CHoadon> getDSHoadon()
        {
            return m_dsHD;
        }
        public bool ghiDulieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, m_data);
                f.Close();
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        public bool docDulieu(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_data = bf.Deserialize(f) as CTruycapDulieu;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
