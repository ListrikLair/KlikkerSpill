using KlikkerSpill;

namespace KlikkerSpill

{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new ClickerGame();
            var commands = new CommandSet(game);

            while (true)
            {
                Console.Clear();
                game.Draw();
                var command = Console.ReadKey().KeyChar;
                commands.RunCommand(command);

            }
        }
    }
}