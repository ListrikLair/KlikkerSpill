using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class IncreaseUpgrade : ICommand
    {
        private ClickerGame _game;
        public char Character { get; } = 's';

        public IncreaseUpgrade(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.UpgradeIncrease();
        }
    }
}
