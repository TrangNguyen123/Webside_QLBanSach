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
    class TrinhDoHocVanCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
        TrinhDoHocVanMH tvMH = new TrinhDoHocVanMH();
        public DataTable GetData()
        {
            return tvMH.GetData();
        }
        public bool AddData(TrinhDoHocVanDT dtTV)
        {
            return tvMH.AddData(dtTV);
        }
        public bool UpdateData(TrinhDoHocVanDT dtTV)
        {
            return tvMH.UpdateData(dtTV);
        }
        public bool DeleteData(string ma)
        {
            return tvMH.DeleteData(ma);
        }

    }
}
