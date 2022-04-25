namespace CircularListExample.GameEngines
{
    internal static class GameEngine
    {
        private static bool exitGame = false, restartGame = false;
        private static string? name;

        public static void StartEngine()
        {
            Console.Write("Udvozollek a The Game of Life-ban! Kezdeshez ird be a neved: ");

            GetUserName();

            while (!exitGame)
            {
                new Game(name!).StartGame(ref exitGame, ref restartGame);
            }
        }

        private static void GetUserName()
        {
            name = Console.ReadLine();

            while (name == null || name.Trim() == String.Empty)
            {
                Console.Write("Kerlek helyes nevet irj be! Nev: ");
                name = Console.ReadLine();
            }
        }
    }
}
