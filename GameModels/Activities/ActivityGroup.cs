using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities
{
    internal class ActivityGroup
    {
        public string Key { get; set; } = "";
        public IActivity Activity { get; set; }
    }
}
