using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class NhanVienDT
    {
        string manhanvien, tennhanvien, ngaysinh, gioitinh, quequan, sodienthoai, dantoc, maphongban, machucvu, matrinhdohocvan, bacluong;

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

        public string Dantoc
        {
            get
            {
                return dantoc;
            }

            set
            {
                dantoc = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

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

        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
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

        public string Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
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

        public string Tennhanvien
        {
            get
            {
                return tennhanvien;
            }

            set
            {
                tennhanvien = value;
            }
        }
        public NhanVienDT() { }
        public NhanVienDT( string manhanvien, string tennhanvien, string ngaysinh, string gioitinh, string quequan, string sodienthoai, string dantoc, string maphongban, string machucvu, string matrinhdohocvan, string bacluong)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.quequan = quequan;
            this.sodienthoai = sodienthoai;
            this.dantoc = dantoc;
            this.maphongban = maphongban;
            this.machucvu = machucvu;
            this.matrinhdohocvan = matrinhdohocvan;
            this.bacluong = bacluong;
        }
    }
}
