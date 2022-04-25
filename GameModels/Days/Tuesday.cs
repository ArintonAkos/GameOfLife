using CircularListExample.GameModels.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Days
{
    internal class Tuesday : Day
    {
        public Tuesday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "socialize",
                Activity = new Socialize()
            });
        }
        public override string GetKey() => "tuesday";

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Kedd");
        }
    }
}
