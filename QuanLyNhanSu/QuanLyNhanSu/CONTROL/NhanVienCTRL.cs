using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QuanLyNhanSu.MOHINH;
using QuanLyNhanSu.DOITUONG;

namespace QuanLyNhanSu.CONTROL
{
    class NhanVienCTRL
    {
        //xu ly dich vu ,chinh sua thong tin truoc khi dua len bang
       NhanVienMH  nvMH = new NhanVienMH();
        public DataTable GetData()
        {
            return nvMH.GetData();
        }
        public bool AddData(NhanVienDT dtNV)
        {
            return nvMH.AddData(dtNV);
        }
        public bool UpdateData(NhanVienDT dtNV)
        {
            return nvMH.UpdateData(dtNV);
        }
        public bool DeleteData(string ma)
        {
            return nvMH.DeleteData(ma);
        }

    }
}
