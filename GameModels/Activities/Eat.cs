using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    class Eat : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 0,
            Happiness = 0,
            Money = -150,
            Hunger = -35,
            Health = 10,
        });

        public void CompletedTaskMessage(ActivityOutcome? outcome)
        {
            Console.WriteLine("Sikeresen ettel!");
        }

        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
            CompletedTaskMessage(null);
        }

        public void Print()
        {
            Console.WriteLine("Eves: eat (Ehseget lehet enyhiteni vele, de penzbe kerul)");
        }
    }
}
