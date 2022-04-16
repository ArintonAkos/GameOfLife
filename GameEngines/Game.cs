using CircularListExample.Exceptions;
using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameEngines
{
    internal class Game
    {
        private static readonly CircularList<Day> days = new(new Day[] { 
            new Monday(),
            new Tuesday(),
            new Wednesday(),
            new Thursday(),
            new Friday(),
            new Saturday(),
            new Sunday(),
        });
        private Day currentDay = days.Next();
        private readonly Player player;
        private readonly Store store = new();

        public Game(string playerName)
        {
            player = new(playerName);
        }

        public void StartGame(ref bool exitGame, ref bool restartGame)
        {
            restartGame = false;
            exitGame = false;

            Console.WriteLine(string.Format("Udvozollek a jatekban {0}!", player.Name));

            GameInputLooper(ref exitGame, ref restartGame);

            if (restartGame)
            {
                exitGame = false;
            }
        }

        private void GameInputLooper(ref bool exitGame, ref bool restartGame)
        {
            while (!exitGame)
            {
                player.PrintInfo();
                player.settings.PrintUserData();
                currentDay.PrintPlayableActivities();

                Console.WriteLine("Adj meg egy parancsot: ");
                string? command = Console.ReadLine();
                switch (command)
                {
                    case null:
                        Console.WriteLine("Hibas bemenet!");
                        break;
                    case "exit":
                        restartGame = false;
                        exitGame = true;
                        break;
                    case "sleep":
                        currentDay = days.Next();
                        store.GetOvernightIncome(player);
                        break;
                    case "store":
                        store.PrintStoreProperties();
                        store.HandleUserInput(command, days, player);
                        break;
                    default:
                        try
                        {
                            currentDay.HandleUserInput(command, player);
                        }
                        catch (EndOfGameException eoge)
                        {
                            Console.WriteLine(eoge.Message);
                            GetPlayerChoiceOnGameEnd(ref exitGame, ref restartGame);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Hibas bemenet!");
                        }
                        break;
                }
            }
        }

        private static void GetPlayerChoiceOnGameEnd(ref bool exitGame, ref bool restartGame)
        {
            Console.WriteLine("Uj jatekot inditasz (restart) vagy kilepsz (exit)?");
            string? endGameCommand = GetCorrectCommand();

            if (endGameCommand == "exit")
            {
                restartGame = false;
            }
            else
            {
                restartGame = true;
            }

            exitGame = true;
        }

        private static string GetCorrectCommand()
        {
            string? command = Console.ReadLine();

            while (command != "exit" || command != "restart")
            {
                Console.WriteLine("Kerlek helyes parancsot irj be!");
                Console.WriteLine("exit -> kilepes");
                Console.WriteLine("restart -> ujrakezdes");
            }

            return command;
        }
    }
}
