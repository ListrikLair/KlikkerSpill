using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class AddPPC : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = ' ';

        public AddPPC(ClickerGame game)
        {
            _game = game;
        }

        public void Run()
        {
            _game.Click();
        }
    }
}
