using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    internal class ExitGame : ICommand
    {
        public char Character { get; } = 'x';
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
