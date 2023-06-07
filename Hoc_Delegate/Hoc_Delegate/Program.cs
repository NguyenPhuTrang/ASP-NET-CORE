using System;

namespace Hoc_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 Khoi tao
            // TinhToan tinhtoan = new TinhToan(TinhTong);//cach 1;
            Func<int, int, int> tinhtoan = delegate (int a, int b) // phuong thuc nac danh
            {
                return a + b;
            };
            // Bieu thuc Lamda la cach viet ngan gon cua phuong thuc nac danh 
            Func<int, int , int > tinhToan = (a, b) => a + b;
            Action<string> display = GetInfo;

            //3 thu thi
            Console.WriteLine(tinhtoan.Invoke(3, 4));
            display("Nguyen Van A");

        }
        //public static int TinhTong(int a, int b)
        //{
        //    return a + b;
        //}
        public static int TinhHieu(int a, int b)
        { return a - b; }
        public static void GetInfo(string name)
        {
            System.Console.WriteLine("Hello " + name);
        }

    }
}



