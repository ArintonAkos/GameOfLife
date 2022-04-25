using CircularListExample.GameModels.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Days
{
    internal class Thursday : Day
    {
        public Thursday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "socialize",
                Activity = new Socialize()
            });
        }
        public override string GetKey() => "thursday";

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Csutortok");
        }
    }
}
