using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.PlayerData
{
   public class SettingsDataModel
    {
        public virtual int Health { get; set; }
        public virtual int Happiness { get; set; }
        public virtual int Tiredness { get; set; }
        public virtual int Money { get; set; }
        public virtual int Hunger { get; set; }
    }

    public class DefaultSettingsDataModel : SettingsDataModel
    {
        public override int Health => 90;

        public override int Happiness => 75;

        public override int Tiredness => 10;

        public override int Money => 500;

        public override int Hunger => 10;
    }
}
