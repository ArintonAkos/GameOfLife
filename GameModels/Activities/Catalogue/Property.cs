using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameModels.Activities.Catalogue
{
    class Property : BaseCatalogue
    {
        private int Count { get; set; } = 0;

        public Property()
        {
            Price = 2500;
        }
        
        protected override void Buy(CircularList<Day> days, Player player)
        {
            base.Buy(days, player);
            Count++;
        }

        protected override void Sell(CircularList<Day> days, Player player)
        {
            base.Sell(days, player);
            Count = Math.Max(0, Count - 1);
        }

        public override void Print()
        {
            Console.WriteLine(String.Format("property: Ingatlan (napi bevetelt kapsz tole). Ar: {0}$", Price));
        }

        public override void PrintCount()
        {
            Console.WriteLine(String.Format("\t Jelenleg {0} db ingatlanod van!", Count));
        }

        public override DailyActivity? GetDailyActivity()
        {
            return new Rental(Count);
        }
        public override bool IsAvailable() => true;

        public override int GetCount() => Count;
        public override string GetKey() => "property";
    }
}
