using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class LuongDT
    {
        string bacluong, luongcoban, hesoluong, hesophucap;

        public string Bacluong
        {
            get
            {
                return bacluong;
            }

            set
            {
                bacluong = value;
            }
        }

        public string Hesoluong
        {
            get
            {
                return hesoluong;
            }

            set
            {
                hesoluong = value;
            }
        }

        public string Hesophucap
        {
            get
            {
                return hesophucap;
            }

            set
            {
                hesophucap = value;
            }
        }

        public string Luongcoban
        {
            get
            {
                return luongcoban;
            }

            set
            {
                luongcoban = value;
            }
        }
        public LuongDT() { }
        public LuongDT(string bacluong, string luongcoban, string hesoluong, string hesophucap)
        {
            this.bacluong=bacluong;
            this.luongcoban = luongcoban;
            this.hesoluong = hesoluong;
            this.hesophucap = hesophucap;
        }
    }
}
