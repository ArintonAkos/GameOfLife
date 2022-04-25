using CircularListExample.GameModels.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Days
{
    internal class Wednesday : Day
    {
        public Wednesday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "dice",
                Activity = new Dice()
            });
        }

        public override string GetKey() => "wednesday";

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Szerda");
        }
    }
}
