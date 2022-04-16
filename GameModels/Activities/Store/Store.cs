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
                }
            });

            player.PrintInfo();
        }

        public void HandleUserInput(string command, CircularList<Day> days, Player player)
        {
            try
            {
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
