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
    class ChucVuCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
        ChucVuMH cvMH = new ChucVuMH();
        public DataTable GetData()
        {
            return cvMH.GetData();
        }
        public bool AddData(ChucVuDT dtCV)
        {
            return cvMH.AddData(dtCV);
        }
        public bool UpdateData(ChucVuDT dtCV)
        {
            return cvMH.UpdateData(dtCV);
        }
        public bool DeleteData(string ma)
        {
            return cvMH.DeleteData(ma);
        }

    }
}
