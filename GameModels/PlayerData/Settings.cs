using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.PlayerData
{
    public class Settings
    {
        public SettingsDataModel Data { get; set; }

        public Settings()
        {
            Data = new DefaultSettingsDataModel();
        }

        public Settings(SettingsDataModel settingsData)
        {
            Data = settingsData;
        }

        public void PrintUserData()
        {
            Console.WriteLine(String.Format("Eletero: {0}%", Data.Health));
            Console.WriteLine(String.Format("Boldogsag: {0}%", Data.Happiness));
            Console.WriteLine(String.Format("Faradtsag: {0}%", Data.Tiredness));
            Console.WriteLine(String.Format("Ehseg: {0}%", Data.Hunger));
            Console.WriteLine(String.Format("Penz: ${0}", Data.Money));
        }

        public static Settings operator +(Settings a, Settings b)
        {
            Settings settings = new();

            int losedHealth = 0;
            settings.Data.Tiredness = Math.Min(Math.Max(0, a.Data.Tiredness + b.Data.Tiredness), 100);
            if (settings.Data.Tiredness > 85)
            {
                losedHealth = 5;
            }

            settings.Data.Health = Math.Min(Math.Max(0, (a.Data.Health + b.Data.Health) - losedHealth), 100);
            settings.Data.Happiness = Math.Min(Math.Max(0, a.Data.Happiness + b.Data.Happiness), 100);
            settings.Data.Hunger = Math.Min(Math.Max(0, a.Data.Hunger + b.Data.Hunger), 100);
            settings.Data.Money = Math.Max(0, a.Data.Money + b.Data.Money);

            return settings;
        }
    }
}
