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
    class LuongCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
        LuongMH lMH = new LuongMH();
        public DataTable GetData()
        {
            return lMH.GetData();
        }
        public bool AddData(LuongDT dtL)
        {
            return lMH.AddData(dtL);
        }
        public bool UpdateData(LuongDT dtL)
        {
            return lMH.UpdateData(dtL);
        }
        public bool DeleteData(string bacluong)
        {
            return lMH.DeleteData(bacluong);
        }

    }
}
