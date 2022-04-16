using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions.Store
{
    internal class ItemNotOwnedException : StoreException
    {
        public ItemNotOwnedException() : base("Nem rendelkezel ezzel az elemmel!")
        {
        }
    }
}
