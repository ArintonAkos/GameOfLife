using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions
{
    internal class PlayerIsDeadByTiredness : EndOfGameException
    {
        public PlayerIsDeadByTiredness() : base("A jatekos sajnos faradsag miatt eletet vesztette. :(")
        {
        }
    }
}
