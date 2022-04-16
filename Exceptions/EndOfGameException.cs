using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions
{
    abstract class EndOfGameException : Exception
    {
        public EndOfGameException(string message) : base(message)
        {
        }
    }
}
