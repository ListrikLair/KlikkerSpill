using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class CommandSet
    {
        private ICommand[] _commands;
        public CommandSet(ClickerGame game)
        {
            _commands = new ICommand[]
            {
                new AddPPC(game),
                new UpgradePPC(game),
                new IncreaseUpgrade(game),
                new ExitGame(),
            };
        }

        public void RunCommand(char userChar)
        {
            var command = FindCommand(userChar);
            if (command != null) command.Run();
        }

        private ICommand FindCommand(char userChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == userChar) return command;
            }
            return null;
        }
    }
}
