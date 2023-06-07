// See https://aka.ms/new-console-template for more information
using System;

namespace Lession_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inLIst il = new inLIst(4);
            //il.Add(0, 100);
            //il.Add(1, 21);
            //il.Add(2, 11);
            //il.Add(3, 40);
            //for (int i = 0; i < il.size(); i++)
            //{
            //    Console.WriteLine(il.Get(i) + " ");
            //}

            MyList <int> l1 = new MyList<int>(4);

            l1.Add(0, 1);
            l1.Add(1, 30);
            l1.Add(2, 30);
            l1.Add(3, 30);
            for(int i =0; i< l1.size(); i++)
            {
                Console.WriteLine(l1.Get(i)+" ");
            }
            MyList<double> l2 = new MyList<double>(2);
            l2.Add(0, 5.2);
            l2.Add(1, 4.3);
            for (int i = 0; i < l1.size(); i++)
            {
                Console.WriteLine(l2.Get(i) + " ");
            }


        }
    }
}
