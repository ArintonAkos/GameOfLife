using CircularListExample.GameModels.PlayerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities
{
    class Travel : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = -20,
            Happiness = 40,
            Money = -100,
            Hunger = -20,
            Health = 0,
        });

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
            Console.WriteLine("Sikeresen elutaztal!");
        }

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
            CompletedTaskMessage(null);
        }

        public void Print()
        {
            Console.WriteLine("Utazas: travel (Boldogabb, kipihentebb es kevesbe leszel ehes, viszont penzbe kerul)");
        }
    }
}
