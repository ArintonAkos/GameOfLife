﻿using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    class Sleep : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = -50,
            Happiness = 15,
            Money = 0,
            Hunger = 25,
            Health = 0,
        });

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
        }

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
        }

        public void Print()
        {
            Console.WriteLine("Alvas: sleep (Faradtsagot enyhithetjuk, de ehesebb leszel tole)");
        }
    }
}
