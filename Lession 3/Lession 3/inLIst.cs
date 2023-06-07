using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_3
{
    internal class inLIst
    {
        private int[] numbers;
        public inLIst(int n)
        { 
            numbers= new int[n];
        }

        public int size()
        { return numbers.Length; }
        // phuong thuc them phan tu vao danh sach
        public void Add(int index, int value)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] = value; 
            }
        }
        //phuong thuc lay trong phan tu trong danh sach
        public int Get(int index)
        {
            if (index >= 0 && index < numbers.Length)
            { 
            return numbers[index];
            }
            return 0;
        }
    }

}
