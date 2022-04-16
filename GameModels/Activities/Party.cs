using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    class Party : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 10,
            Happiness = 20,
            Money = 0,
            Hunger = 15,
            Health = 0,
        });

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
        }

        public void Print()
        {
            Console.WriteLine("Bulizas: party (Boldogabbak leszunk, de ehesebbek es faradtabbak is.)");
        }
    }
}
