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
    class HopDongCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
        HopDongMH nvMH = new HopDongMH();
        public DataTable GetData()
        {
            return nvMH.GetData();
        }
        public bool AddData(HopDongLaoDongDT dtHD)
        {
            return nvMH.AddData(dtHD);
        }
        public bool UpdateData(HopDongLaoDongDT dtHD)
        {
            return nvMH.UpdateData(dtHD);
        }
        public bool DeleteData(string ma)
        {
            return nvMH.DeleteData(ma);
        }

    }
}
