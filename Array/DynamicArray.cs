using Arrays.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Array
{
    public class DynamicArray<T>
    {
        private ArrayUtilities<T> _array;

        public DynamicArray(int initialCapacity = 4)
        {
            _array = new ArrayUtilities<T>(initialCapacity);
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

        public T DeleteLast()
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
