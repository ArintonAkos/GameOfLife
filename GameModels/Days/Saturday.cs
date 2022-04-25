using CircularListExample.GameModels.Activities;

namespace CircularListExample.GameModels.Days
{
    internal class Saturday : Day
    {
        public override string GetKey() => "saturday";

        public Saturday()
        {
            activityGroups.Add(new ActivityGroup
            {
                Key = "party",
                Activity = new Party()
            });
        }

        public override void PrintName()
        {
            Console.WriteLine("A mai nap: Szombat");
        }
    }
}
