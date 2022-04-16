using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions
{
    internal class PlayerIsDeadByHunger : EndOfGameException
    {
        public PlayerIsDeadByHunger() : base("A jatekos sajnos ehseg miatt eletet vesztette.")
        {
        }
    }
}
