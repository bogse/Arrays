using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Exceptions
{
    public class ArrayEmptyException : CustomException
    {
        public ArrayEmptyException() : base("Array is empty")
        {
        }
    }
}
