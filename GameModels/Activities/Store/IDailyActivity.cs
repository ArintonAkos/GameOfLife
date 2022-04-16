using CircularListExample.GameModels.PlayerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities.Store
{
    internal abstract class DailyActivity
    {
        protected int Count { get; set; }
        public DailyActivity(int count)
        {
            Count = count;
        }

        public abstract void Print();
        public abstract void DoActivity(Player player);
    }
}
