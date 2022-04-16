using CircularListExample.Exceptions;

namespace CircularListExample.GameModels.PlayerData
{
    public class Player
    {
        private readonly Random random = new();
        public readonly string Name;
        internal Settings settings = new();

        public Player(string name)
        {
            Name = name;
        }

        public void PrintInfo()
        {
            settings.PrintUserData();
        }

        internal void UpdateSettings(Settings updatedSettings)
        {
            settings = updatedSettings;

            CheckSetting<PlayerIsDeadException>(settings.Data.Health);
            CheckSetting<PlayerIsDeadByDepressionException>(settings.Data.Happiness);
            CheckSetting<PlayerIsDeadByHunger>(settings.Data.Hunger);
        }

        private void CheckSetting<T>(int settingValue) where T : Exception, new()
        {
            if (settingValue == 0)
            {
                throw new T();
            }

            if (settingValue < 10)
            {
                int numberToFind = GenerateRandomNumber(settingValue);

                if (GenerateRandomNumber(settingValue) == numberToFind)
                {
                    throw new T();
                }
            }
        }

        private int GenerateRandomNumber(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
