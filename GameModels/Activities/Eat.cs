using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    class Eat : IActivity
    {
        private readonly Settings _activitySettings = new(new SettingsDataModel
        {
            Tiredness = 0,
            Happiness = 10,
            Money = -100,
            Hunger = -15,
            Health = 5,
        });
        
        public void DoActivity(Player player)
        {
            player.UpdateSettings(player.settings + _activitySettings);
        }

        public void Print()
        {
            Console.WriteLine("Eves: eat (Ehseget lehet enyhiteni vele, de penzbe kerul.)");
        }
    }
}
