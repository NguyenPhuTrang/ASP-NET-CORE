using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession_3
{
    class MyList <T>
    {
        private T[] numbers;
        public MyList(int n)
        {
            numbers = new T[n];
        }

        public int size()
        { return numbers.Length; }
        // phuong thuc them phan tu vao danh sach
        public void Add(int index, T value)
        {
            if (index >= 0 && index < numbers.Length)
            {
                numbers[index] = value;
            }
        }
        //phuong thuc lay trong phan tu trong danh sach
        public T Get(int index)
        {
            if (index >= 0 && index < numbers.Length)
            {
                return numbers[index];
            }
            return default(T);
        }
    }
}

