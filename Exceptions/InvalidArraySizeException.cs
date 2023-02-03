using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Exceptions
{
    public class InvalidArraySizeException : CustomException
    {
        public InvalidArraySizeException() : base("Array size must be positive")
        {
        }
    }
}
