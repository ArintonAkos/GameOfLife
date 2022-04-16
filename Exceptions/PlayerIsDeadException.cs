using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.Exceptions
{
    internal class PlayerIsDeadException : EndOfGameException
    {
        public PlayerIsDeadException() : base("A jatekos sajnos betegseg miatt eletet vesztette.")
        {
        }
    }
}
