using System;
using Zork.Game;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Common.Game game = Common.Game.LoadFromFile(gameFilename, output, input);


            while (game.IsRunning)
            {
                output.Write("\n> ");
                input.ProcessInput();
            }


            output.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}
