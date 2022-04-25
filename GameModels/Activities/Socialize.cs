using CircularListExample.GameModels.PlayerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities
{
    class Socialize : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 15,
            Happiness = 40,
            Money = -150,
            Hunger = 15,
            Health = 5,
        });

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
            Console.WriteLine("Sikeresen talalkoztal a barataiddal!");
        }

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
            CompletedTaskMessage(null);
        }

        public void Print()
        {
            Console.WriteLine("Szocializalas: socialize (Boldogabbak, faradtabbak, ehesebbek es egeszsegebbek leszunk. Penzbe kerul)");
        }
    }
}
