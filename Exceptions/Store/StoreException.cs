using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions.Store
{
    internal abstract class StoreException : Exception
    {
        public StoreException(string message) : base(message)
        {
        }
    }
}
