using CircularListExample.GameModels.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Days
{
    internal class Friday : Day
    {
        public override string GetKey() => "friday";

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Pentek");
        }

        public Friday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "party",
                Activity = new Party()
            });
        }
    }
}
