using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    class Work : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 30,
            Happiness = -20,
            Money = 250,
            Hunger = 30,
            Health = 0
        });

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
        }

        public void Print()
        {
            Console.WriteLine("Munka: work (Penzt szerezhetsz vele, de ehesebb leszel es szomorubb.)");
        }
    }
}
