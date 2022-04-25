using CircularListExample.Exceptions.Store;
using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameModels.Activities.Catalogue
{
    internal abstract class BaseCatalogue
    {
        protected int Price = 0;

        protected virtual void Buy(CircularList<Day> days, Player player)
        {
            if (!IsAvailable())
            {
                throw new EntryNotAvailableException();
            }
            if (player.settings.Data.Money < Price)
            {
                throw new NotEnoughMoneyException();
            }

            player.settings.Data.Money -= Price;
        }

        protected virtual void Sell(CircularList<Day> days, Player player)
        {
            if (GetCount() < 1)
            {
                throw new ItemNotOwnedException();
            }

            player.settings.Data.Money += Price / 2;
        }

        public abstract bool IsAvailable();
        public abstract int GetCount();
        public abstract DailyActivity? GetDailyActivity();
        public abstract void Print();
        public abstract void PrintCount();
        public abstract string GetKey();

        public void DoActivity(CircularList<Day> days, Player player)
        {
            Console.WriteLine("Vasarlas: buy. Eladas: sell.");

            String command = Console.ReadLine() ?? "";
            switch (command)
            {
                case "buy":
                    try
                    {
                        Buy(days, player);
                    } catch (StoreException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "sell":
                    try
                    {
                        Sell(days, player);
                    } catch (StoreException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Hibas bemenet!");
                    break;
            }
        }
    }
}
