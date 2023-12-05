using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class UpgradePPC : ICommand
    {
        private ClickerGame _game;

        public UpgradePPC(ClickerGame game)
        {
            _game = game;
        }

        public char Character { get; } = 'k';
        public void Run()
        {
            _game.Upgrade();
        }
    }
}
