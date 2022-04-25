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
            Hunger = 10,
            Health = -10,
        });

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
            Console.WriteLine("Sikeresen buliztal!");
        }

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
            CompletedTaskMessage(null);
        }

        public void Print()
        {
            Console.WriteLine("Bulizas: party (Boldogabbak leszel, de ehesebbek es faradtabbak is)");
        }
    }
}
