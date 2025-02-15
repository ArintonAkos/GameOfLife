﻿using CircularListExample.GameModels.Activities;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameModels.Days
{
    class Monday : Day
    {
        public Monday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "dice",
                Activity = new Dice()
            });
        }

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Hetfo");
        }

        public override string GetKey() => "monday";
    }
}
