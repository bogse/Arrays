using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Exceptions
{
    public class ArrayIndexOutOfRangeException : CustomException
    {
        public ArrayIndexOutOfRangeException() : base("Index is out of range")
        {
        }
    }
}
