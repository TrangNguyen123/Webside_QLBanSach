using QuanLyNhanSu.DOITUONG;
using QuanLyNhanSu.MOHINH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.CONTROL
{
    class PhongBanCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
        PhongBanMH pbMH = new PhongBanMH();
        public DataTable GetData()
        {
            return pbMH.GetData();
        }
        public bool AddData(PhongBanDT dtPB)
        {
            return pbMH.AddData(dtPB);
        }
        public bool UpdateData(PhongBanDT dtPB)
        {
            return pbMH.UpdateData(dtPB);
        }
        public bool DeleteData(string ma)
        {
            return pbMH.DeleteData(ma);
        }
    }
}
