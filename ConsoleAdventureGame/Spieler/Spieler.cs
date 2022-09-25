using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventureGame
{
    internal class Spieler
    {
        public int maxLeben { get; set; }
        public int Leben { get; set; }
        public Waffe ausgerüsteteWaffe { get; set; }

        public Spieler()
        {
            maxLeben = 100;
            Leben = maxLeben;
        }

    }
}
