using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions
{
    internal class PlayerIsDeadByDepressionException : EndOfGameException
    {
        public PlayerIsDeadByDepressionException() : base("A jatekos sajnos szomorusagaban eletet vesztette.  :(")
        {
        }
    }
}
