using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class PhongBanDT
    {
        string maphongban, tenphongban, diachi, sodienthoai;

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Maphongban
        {
            get
            {
                return maphongban;
            }

            set
            {
                maphongban = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public string Tenphongban
        {
            get
            {
                return tenphongban;
            }

            set
            {
                tenphongban = value;
            }
        }
        public PhongBanDT()
        {
        }
        public PhongBanDT(string maphongban, string tenphongban, string diachi, string sodienthoai)
        {
            this.maphongban = maphongban;
            this.tenphongban = tenphongban;
            this.diachi = diachi;
            this.sodienthoai = sodienthoai;

        }
    }
}
