using CircularListExample.Exceptions.Store;
using CircularListExample.GameModels.PlayerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities
{
    internal class Dice : IActivity
    {
        private readonly Random random = new();
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 5,
            Happiness = 0,
            Money = 0,
            Hunger = 0,
            Health = -5,
        });

        private bool IsWin()
        {
            int val = random.Next(2);

            return (val == 1);
        }

        public void DoActivity(Player player)
        {
            Console.Write("Ird be a teted: ");

            string? command = Console.ReadLine();
            int bet = 0;

            while (command == null || (command != null && !int.TryParse(command, out bet)) || command == "exit")
            {
                Console.Write("Kerlek helyes tetet irj be! Tet: ");

                command = Console.ReadLine();
            }
            
            bet = Math.Abs(bet);

            if (bet > player.settings.Data.Money)
            {
                throw new NotEnoughMoneyException();
            }

            int elojel = IsWin() ? 1 : -1;

            Settings newSettings = _activitySettings;
            newSettings.Data.Money = elojel * bet;

            player.UpdateSettings(player.settings + newSettings);
            CompletedTaskMessage(new ActivityOutcome
            {
                Amount = bet,
                Win = (elojel == 1)
            });
        }

        public void Print()
        {
            Console.WriteLine("Kockazas: dice (Penzt tudsz nyerni vele)");
        }

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
            if (outcome != null)
            {
                if (outcome.Win)
                {
                    Console.WriteLine(String.Format("Nyertel {0} dollart!", outcome.Amount));
                }
                else
                {
                    Console.WriteLine(String.Format("Vesztettel {0} dollart!", outcome.Amount));
                }
            }
        }
    }
}
