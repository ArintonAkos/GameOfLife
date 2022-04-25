using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions.Store
{
    internal class NotEnoughMoneyException : StoreException
    {
        public NotEnoughMoneyException() : base("Hiba! Nem rendelkezel elegendo penzzel!")
        {
        }
    }
}
