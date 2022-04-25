using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularListExample.GameModels.Activities.Catalogue
{
    class Car : BaseCatalogue
    {
        private readonly string _activityGroupKey = "travel";
        private int Count { get; set; } = 0;

        public Car()
        {
            Price = 800;
        }

        protected override void Buy(CircularList<Day> days, Player player)
        {
            base.Buy(days, player);
            Count++;
            days.ForEach(day =>
            {
                day.AddActivity(new ActivityGroup
                {
                    Key = _activityGroupKey,
                    Activity = new Travel()
                });
            });
        }

        protected override void Sell(CircularList<Day> days, Player player)
        {
            base.Sell(days, player);
            Count = Math.Max(0, Count - 1);
            days.ForEach(day =>
            {
                day.RemoveActivity(_activityGroupKey);
            });
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("car: Auto (tudsz utazni vele, amitol boldogabb leszel es kipihentebb). Ar: {0}$", Price));
        }

        public override void PrintCount()
        {
            if (Count == 0)
            {
                Console.WriteLine("\t Jelenleg nem rendelkezel autoval!");
            }
            else
            {
                Console.WriteLine("\t Jelenleg van autod!");
            }
        }

        public override DailyActivity? GetDailyActivity()
        {
            return null;
        }

        public override bool IsAvailable() => (Count == 0);
        public override int GetCount() => Count;
        public override string GetKey() => "car";
    }
}
