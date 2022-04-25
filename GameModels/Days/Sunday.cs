using CircularListExample.GameModels.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Days
{
    internal class Sunday : Day
    {
        public override string GetKey() => "sunday";

        public Sunday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "party",
                Activity = new Party()
            });
        }

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Vasarnap");
        }
    }
}
