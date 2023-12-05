using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class ClickerGame
    {
        private int _points = 0;
        private int _pointsPerClick = 1;
        private int _pointsPerClickIncrease = 1;

        public void Click()
        {
            _points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (_points < 10) return;
            _points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void UpgradeIncrease()
        {
            if (_points < 100) return;
            _points -= 100;
            _pointsPerClickIncrease++;
        }
        public void Draw()
        {
            Console.WriteLine("Kommandoer:\r\n ");
            Console.WriteLine("- SPACE = klikk (og få poeng)\r\n");
            Console.WriteLine("- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n");
            Console.WriteLine("- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n");
            Console.WriteLine("- X = avslutt applikasjonen");
            Console.WriteLine($"Du har {_points} poeng.");
            Console.WriteLine("Trykk tast for ønsket kommando.");
        }
    }
}
