using Arrays.Exceptions;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Array
{
    //This is a static array because the size of the array is defined at creation time
    //and cannot be changed afterwards.The code implements a simple method to ensure 
    //the array has sufficient capacity before inserting a new item, but it does not 
    //increase the size of the array beyond its original size defined at construction.
    public class StaticArray<T>
    {
        private ArrayUtilities<T> _array;

        public StaticArray(int size)
        {
            _array = new ArrayUtilities<T>(size);
        }

        public int Count
        {
            get { return _array.Count; }
        }

        public T GetData(int index)
        {
            return _array.GetData(index);
        }

        public void InsertLast(T item)
        {
            _array.EnsureArrayCapacity();
            _array.Data[_array.Count] = item;
            _array.Count++;
        }

        public void InsertAtIndex(int index, T item)
        {
            if (index < 0 || index > _array.Count)
            {
                throw new ArrayIndexOutOfRangeException();
            }
            _array.EnsureArrayCapacity();
            _array.ShiftItemsRight(index);
            _array.Data[index] = item;
            _array.Count++;
        }

        public void InsertFirst(T item)
        {
            InsertAtIndex(0, item);
        }

        public object DeleteLast()
        {
            if (_array.Count == 0)
            {
                throw new ArrayEmptyException();
            }
            T deletedItem = _array.Data[_array.Count - 1];
            _array.Data[_array.Count - 1] = default;
            _array.Count--;
            return deletedItem;
        }

        public T Delete(int index)
        {
            if (index < 0 || index >= _array.Count)
            {
                throw new ArrayIndexOutOfRangeException();
            }
            T deletedItem = _array.Data[index];
            _array.ShiftItemsLeft(index);
            return deletedItem;
        }
    }
}

