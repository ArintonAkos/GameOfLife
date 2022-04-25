using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.PlayerData
{
   public class SettingsDataModel
    {
        public int Health { get; set; }
        public int Happiness { get; set; }
        public int Tiredness { get; set; }
        public int Money { get; set; }
        public int Hunger { get; set; }
    }

    public class DefaultSettingsDataModel : SettingsDataModel
    {
        public DefaultSettingsDataModel()
        {
            Health = 90;
            Happiness = 75;
            Tiredness = 10;
            Money = 500;
            Hunger = 10;
        }
    }
}
