using CircularListExample.Exceptions;
using CircularListExample.Exceptions.Store;
using CircularListExample.GameModels.Activities;
using CircularListExample.GameModels.Activities.Store;
using CircularListExample.GameModels.Days;
using CircularListExample.GameModels.PlayerData;
using DataStructures;

namespace CircularListExample.GameEngines
{
    internal class Game
    {
        private readonly CircularList<Day> days = new(new Day[] { 
            new Monday(),
            new Tuesday(),
            new Wednesday(),
            new Thursday(),
            new Friday(),
            new Saturday(),
            new Sunday(),
        });
        private Day currentDay;
        private readonly Player player;
        private readonly Store store;
        private readonly Sleep sleepActivity;
        private int livedDays;

        public Game(string playerName)
        {
            player = new(playerName);
            currentDay = days.Next();
            livedDays = 0;
            store = new();
            sleepActivity = new();
        }

        public void StartGame(ref bool exitGame, ref bool restartGame)
        {
            restartGame = false;
            exitGame = false;

            Console.WriteLine(string.Format("\nUdvozollek a jatekban {0}!", player.Name));

            GameInputLooper(ref exitGame, ref restartGame);

            if (restartGame)
            {
                exitGame = false;
            }
        }

        private void Print()
        {
            player.PrintInfo();
            currentDay.PrintPlayableActivities();
        }

        private void GameInputLooper(ref bool exitGame, ref bool restartGame)
        {
            currentDay.PrintName();
            Print();

            while (!exitGame)
            {
                Console.Write("Adj meg egy parancsot: ");
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
                    case "store":
                        store.PrintStoreProperties();
                        store.HandleUserInput(days, player);
                        break;
                    case "help":
                        currentDay.PrintPlayableActivities();
                        break;
                    case "info":
                        player.PrintInfo();
                        break;
                    default:
                        try
                        {
                            if (command == "sleep")
                            {
                                livedDays++;
                                sleepActivity.DoActivity(player);
                                currentDay = days.Next();
                                currentDay.PrintName();
                                store.GetOvernightIncome(player);
                                Print();
                            }
                            else
                            {
                                currentDay.HandleUserInput(command, player);
                            }
                        }
                        catch (NotEnoughMoneyException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (EndOfGameException eoge)
                        {
                            Console.WriteLine(eoge.Message);
                            Console.WriteLine("Tulelt napok szama: {0}", livedDays);
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

            while (command != "exit" && command != "restart")
            {
                Console.WriteLine("Kerlek helyes parancsot irj be!");
                Console.WriteLine("exit -> kilepes");
                Console.WriteLine("restart -> ujrakezdes");
                
                command = Console.ReadLine();
            }

            return command;
        }
    }
}
