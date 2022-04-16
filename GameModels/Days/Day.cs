using CircularListExample.GameModels.Activities;
using CircularListExample.GameModels.Activities.Catalogue;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameModels.Days
{
    abstract class Day
    {
        protected CircularList<ActivityGroup> activityGroups = new(new ActivityGroup[] 
        {
            new ActivityGroup
            {
                Key = "work",
                Activity = new Work(),
            },
            new ActivityGroup
            {
                Key = "eat",
                Activity = new Eat(),
            }
        });

        public void AddActivity(ActivityGroup activityGroup)
        {
            try
            {
                ActivityGroup ag = activityGroups.FindWhere((ag) =>
                {
                    return (ag.Key == activityGroup.Key);
                });
                return;
            } catch (Exception)
            {
                activityGroups.Add(activityGroup);
            }
        }

        public void RemoveActivity(string activityGroupKey)
        {
            try
            {
                ActivityGroup ag = activityGroups.FindWhere((ag) =>
                {
                    return (ag.Key == activityGroupKey);
                });

                activityGroups.Remove(ag);
            } catch(Exception)
            {
                return;
            }
        }

        public void PrintPlayableActivities()
        {
            foreach (var activityGroup in activityGroups)
            {
                activityGroup.Activity.Print();
            };
        }

        public virtual void HandleUserInput(string command, Player player)
        {
            try
            {
                ActivityGroup activityGroup = activityGroups.FindWhere(activityGroup =>
                {
                    return (activityGroup.Key == command);
                });

                activityGroup.Activity.DoActivity(player);
            }
            catch (Exception)
            {
                Console.WriteLine("Nem talalhato ilyen parancs!");
            };
        }
    }
}
