using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class TrinhDoHocVanDT
    {
        string matrinhdohocvan, tentrinhdohocvan, chuyennganh;

        public string Chuyennganh
        {
            get
            {
                return chuyennganh;
            }

            set
            {
                chuyennganh = value;
            }
        }

        public string Matrinhdohocvan
        {
            get
            {
                return matrinhdohocvan;
            }

            set
            {
                matrinhdohocvan = value;
            }
        }

        public string Tentrinhdohocvan
        {
            get
            {
                return tentrinhdohocvan;
            }

            set
            {
                tentrinhdohocvan = value;
            }
        }
        public TrinhDoHocVanDT() { }
        public TrinhDoHocVanDT(string matrinhdohocvan, string tentrinhdohocvan, string chuyennganh)
        {
            this.matrinhdohocvan = matrinhdohocvan;
            this.tentrinhdohocvan = tentrinhdohocvan;
            this.chuyennganh = chuyennganh;
        }
    }
}
