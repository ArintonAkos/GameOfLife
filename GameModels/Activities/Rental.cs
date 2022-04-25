using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    internal class Rental : DailyActivity
    {
        public Rental(int count) : base(count)
        {
        }

        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 0,
            Happiness = 0,
            Money = 250,
            Hunger = 0,
            Health = 0
        });

        public override void Print()
        {
            if (Count > 0)
            {
                int income = _activitySettings.Data.Money * Count;

                Console.WriteLine("{0} bevetelt szereztel {1} db ingatlanbol!", income, Count);
            }
        }

        public override void DoActivity(Player player)
        {
            Settings tmpSettings = _activitySettings;
            tmpSettings.Data.Money *= Count;
            player.UpdateSettings(player.settings + tmpSettings);
        }
    }
}
