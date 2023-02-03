using Arrays.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Array
{
    public class ArrayUtilities<T>
    {
        private T[] data;
        private int count;

        public ArrayUtilities(int size)
        {
            if (size <= 0)
            {
                throw new InvalidArraySizeException();
            }
            data = new T[size];
            count = 0;
        }

        public T[] Data
        {
            get { return data; }
            set { data = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public T GetData(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArrayIndexOutOfRangeException();
            }
            return data[index];
        }

        public void EnsureArrayCapacity()
        {
            if (count == data.Length)
            {
                int newSize = data.Length == 0 ? 4 : data.Length * 2;
                T[] newArray = new T[newSize];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = data[i];
                }
                data = newArray;
            }
        }

        public void ShiftItemsLeft(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }
            data[count - 1] = default;
            count--;
        }

        public void ShiftItemsRight(int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                data[i + 1] = data[i];
            }
        }
    }

}
