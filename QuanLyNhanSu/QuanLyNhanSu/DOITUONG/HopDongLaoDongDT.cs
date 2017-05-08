using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class HopDongLaoDongDT
    {
        string mahopdong, loaihopdong, tungay, denngay, manhanvien;

        public string Denngay
        {
            get
            {
                return denngay;
            }

            set
            {
                denngay = value;
            }
        }

        public string Loaihopdong
        {
            get
            {
                return loaihopdong;
            }

            set
            {
                loaihopdong = value;
            }
        }

        public string Mahopdong
        {
            get
            {
                return mahopdong;
            }

            set
            {
                mahopdong = value;
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

        public string Tungay
        {
            get
            {
                return tungay;
            }

            set
            {
                tungay = value;
            }
        }
        public HopDongLaoDongDT() { }
        public HopDongLaoDongDT(string mahopdong, string loaihopdong, string tungay, string denngay, string manhanvien)
        {
            this.mahopdong = mahopdong;
            this.loaihopdong = loaihopdong;
            this.tungay = tungay;
            this.denngay = denngay;
            this.manhanvien = manhanvien;
        }

    }
}
