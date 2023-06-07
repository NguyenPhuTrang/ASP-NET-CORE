using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Sinhvien
    {
        private string maSV;
        private string hoTen;
        
        public string Masv 
        { 
            get => maSV;
            set => maSV = value;
        }
        public string HoTen { 
            get => hoTen;
            set => hoTen = value;
        }
         public Sinhvien(string maSV, string hoTen)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
        }
    
    }
    }

