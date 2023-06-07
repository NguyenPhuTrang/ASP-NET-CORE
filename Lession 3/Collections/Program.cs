using Collections;
using System;
using System.Collections;

namespace Collection;

internal class Program
{
    static void Main(string[] args)
    {
    // 1. khoi tao array list
    ArrayList arrayList = new ArrayList();
    //Them phan tu vao danh sach
        arrayList.Add(4);
        arrayList.Add("C");
        arrayList.Add("Trang");
        arrayList.Add("7.1");
        Sinhvien sv1 = new Sinhvien("101", "Le Van An");
        Sinhvien sv2 = new Sinhvien("102", "Nguyen van C");
        arrayList.Add(sv1);
        arrayList.Add(sv2);
    // Xoa phan tu trong danh sach
        arrayList.Remove(1); // Xoa phan tu co index 1;
        foreach (var item in arrayList)
        {
            if ( item is Sinhvien)
            {
                Sinhvien sv = (Sinhvien)item;
                Console.WriteLine(sv.Masv + ", " +sv.HoTen);
            }
            else
            {
            Console.WriteLine(item);
            }
        }

    }
}