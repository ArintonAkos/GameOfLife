using CircularListExample.GameModels.Activities.Catalogue;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameModels.Activities.Store
{
    internal class Store
    {
        private CircularList<BaseCatalogue> catalogues = new(new BaseCatalogue[] 
        {
            new Property(),
            new Car(),
        });

        public Store()
        {
        }

        public void PrintStoreProperties()
        {
            catalogues.ForEach(catalogue =>
            {
                catalogue.Print();
                catalogue.PrintCount();
            });
        }

        public void GetOvernightIncome(Player player)
        {
            catalogues.ForEach(catalogue =>
            {
                DailyActivity? activity = catalogue.GetDailyActivity();

                if (activity != null)
                {
                    activity.DoActivity(player);
                    activity.Print();
                }
            });
        }

        public void HandleUserInput(CircularList<Day> days, Player player)
        {
            try
            {
                Console.Write("(Store) -> Irj be egy parancsot: ");
                string? command = Console.ReadLine();

                if (command == null)
                {
                    throw new Exception();
                }

                BaseCatalogue catalogue = catalogues.FindWhere(catalogue =>
                {
                    return (catalogue.GetKey() == command);
                });

                catalogue.DoActivity(days, player);
            } catch (Exception)
            {
                Console.WriteLine("Hibas parancs!");
            }
        }
    }
}
