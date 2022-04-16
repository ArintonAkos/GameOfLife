using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions.Store
{
    internal class EntryNotAvailableException : StoreException
    {
        public EntryNotAvailableException() : base("Ez a termek nem vasarolhato meg!")
        { }
    }
}
