using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class ChucVuDT
    {
        string machucvu, tenchucvu;

        public string Machucvu
        {
            get
            {
                return machucvu;
            }

            set
            {
                machucvu = value;
            }
        }

        public string Tenchucvu
        {
            get
            {
                return tenchucvu;
            }

            set
            {
                tenchucvu = value;
            }
        }
        public ChucVuDT() { }
        public ChucVuDT(string machucvu, string tenchucvu)
        {
            this.machucvu = machucvu;
            this.tenchucvu = tenchucvu;
        }
    }
}
